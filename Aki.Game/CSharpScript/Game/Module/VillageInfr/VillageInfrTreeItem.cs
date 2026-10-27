using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200487F RID: 18559
	[NullableContext(1)]
	[Nullable(0)]
	internal class VillageInfrTreeItem : UiPanelBase
	{
		// Token: 0x060308EE RID: 198894 RVA: 0x00B47288 File Offset: 0x00B45488
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUITexture)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTreeItem))
			};
		}

		// Token: 0x060308EF RID: 198895 RVA: 0x00B473CE File Offset: 0x00B455CE
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x060308F0 RID: 198896 RVA: 0x00B473FC File Offset: 0x00B455FC
		public void PlayLevelSequenceByName(string name)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName(name, false, null, false);
		}

		// Token: 0x060308F1 RID: 198897 RVA: 0x00B47425 File Offset: 0x00B45625
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "GetL" || sequenceName == "GetR")
			{
				this.NeedPlayFinish = false;
				this.RefreshFinish();
				Action onGetSeqEnd = this.OnGetSeqEnd;
				if (onGetSeqEnd == null)
				{
					return;
				}
				onGetSeqEnd();
			}
		}

		// Token: 0x060308F2 RID: 198898 RVA: 0x00B4745E File Offset: 0x00B4565E
		private void OnClickTreeItem(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<int, EVillageInfrSelectType> selectCb = this.SelectCb;
			if (selectCb != null)
			{
				selectCb(this.Id, this.SelectType);
			}
			this.SetSelected(true);
		}

		// Token: 0x060308F3 RID: 198899 RVA: 0x00B4748C File Offset: 0x00B4568C
		[NullableContext(2)]
		public void Refresh(int id, EVillageInfrSelectType type, IVillageInfrBuildFinishTipParam param = null)
		{
			this.Id = id;
			this.SelectType = type;
			this.NeedPlayFinish = (param != null && param.SelectType == EVillageInfrSelectType.Tree && param.SelectId == id);
			this.RefreshName();
			this.RefreshFinish();
			this.RefreshLevelUp();
			this.RefreshLock();
		}

		// Token: 0x060308F4 RID: 198900 RVA: 0x00B474E0 File Offset: 0x00B456E0
		private void RefreshName()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(this.Id);
				base.GetText(7).ShowTextNew(infrTreeBuild.Value.Name);
				base.GetSprite(11).SetUIActive(this.Id == VillageInfrModel.Instance.GetTraceTreeId());
				return;
			}
			base.GetSprite(11).SetUIActive(false);
		}

		// Token: 0x060308F5 RID: 198901 RVA: 0x00B47550 File Offset: 0x00B45750
		private bool IsFinish()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(this.Id);
				return treeData != null && treeData.Status == InfrV2StatusPb.InfrV2StatusComplete;
			}
			int infrMaxLevel = VillageInfrConfig.Instance.GetInfrMaxLevel();
			return this.Id >= infrMaxLevel;
		}

		// Token: 0x060308F6 RID: 198902 RVA: 0x00B4759C File Offset: 0x00B4579C
		private void RefreshFinish()
		{
			bool flag = this.IsFinish();
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetItem(4).SetUIActive(flag);
			}
			else
			{
				base.GetItem(4).SetUIActive(flag);
				UUIItem sprite = base.GetSprite(6);
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(base.GetSprite(6).changeColor);
				sprite.SetChangeColor(bUseChangeColor, fcolor);
			}
			this.RefreshLineVisible();
		}

		// Token: 0x060308F7 RID: 198903 RVA: 0x00B475FC File Offset: 0x00B457FC
		private void RefreshLineVisible()
		{
			bool flag = this.IsFinish();
			if (this.NeedPlayFinish)
			{
				flag = !flag;
			}
			bool isSelected = this.IsSelected;
			base.GetTexture(1).SetUIActive(!isSelected && !flag);
			base.GetTexture(2).SetUIActive(!isSelected && flag);
			base.GetTexture(8).SetUIActive(isSelected && !flag);
			base.GetTexture(9).SetUIActive(isSelected && flag);
			base.GetTexture(10).SetUIActive(this.NeedPlayFinish);
		}

		// Token: 0x060308F8 RID: 198904 RVA: 0x00B47685 File Offset: 0x00B45885
		private void RefreshLevelUp()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetSprite(5).SetUIActive(VillageInfrModel.Instance.GetCanTreeLevelUp(this.Id));
				return;
			}
			base.GetSprite(5).SetUIActive(VillageInfrModel.Instance.GetCanVillageLevelUp());
		}

		// Token: 0x060308F9 RID: 198905 RVA: 0x00B476C3 File Offset: 0x00B458C3
		private void RefreshLock()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetItem(3).SetUIActive(!VillageInfrModel.Instance.GetTreeIsUnlock(this.Id));
				return;
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x060308FA RID: 198906 RVA: 0x00B476FB File Offset: 0x00B458FB
		public void SetSelectCb(Action<int, EVillageInfrSelectType> cb)
		{
			this.SelectCb = cb;
		}

		// Token: 0x060308FB RID: 198907 RVA: 0x00B47704 File Offset: 0x00B45904
		public void SetOnGetSeqEnd(Action cb)
		{
			this.OnGetSeqEnd = cb;
		}

		// Token: 0x060308FC RID: 198908 RVA: 0x00B4770D File Offset: 0x00B4590D
		public void SetSelected(bool isSelected)
		{
			this.IsSelected = isSelected;
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshLineVisible();
		}

		// Token: 0x0401A173 RID: 106867
		public int Id;

		// Token: 0x0401A174 RID: 106868
		public EVillageInfrSelectType SelectType;

		// Token: 0x0401A175 RID: 106869
		private bool IsSelected;

		// Token: 0x0401A176 RID: 106870
		[Nullable(2)]
		private Action<int, EVillageInfrSelectType> SelectCb;

		// Token: 0x0401A177 RID: 106871
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401A178 RID: 106872
		[Nullable(2)]
		private Action OnGetSeqEnd;

		// Token: 0x0401A179 RID: 106873
		private bool NeedPlayFinish;
	}
}
