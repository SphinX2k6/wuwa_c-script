using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x020037F6 RID: 14326
	[NullableContext(1)]
	[Nullable(0)]
	internal class VillageInfrTreeItem : UiPanelBase
	{
		// Token: 0x0602541A RID: 152602 RVA: 0x00A8205C File Offset: 0x00A8025C
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

		// Token: 0x0602541B RID: 152603 RVA: 0x00A821A2 File Offset: 0x00A803A2
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0602541C RID: 152604 RVA: 0x00A821D0 File Offset: 0x00A803D0
		public void PlayLevelSequenceByName(string name)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer == null)
			{
				return;
			}
			seqPlayer.PlayLevelSequenceByName(name, false, null, false);
		}

		// Token: 0x0602541D RID: 152605 RVA: 0x00A821F9 File Offset: 0x00A803F9
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

		// Token: 0x0602541E RID: 152606 RVA: 0x00A82232 File Offset: 0x00A80432
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

		// Token: 0x0602541F RID: 152607 RVA: 0x00A82260 File Offset: 0x00A80460
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

		// Token: 0x06025420 RID: 152608 RVA: 0x00A822B4 File Offset: 0x00A804B4
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

		// Token: 0x06025421 RID: 152609 RVA: 0x00A82324 File Offset: 0x00A80524
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

		// Token: 0x06025422 RID: 152610 RVA: 0x00A82370 File Offset: 0x00A80570
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

		// Token: 0x06025423 RID: 152611 RVA: 0x00A823D0 File Offset: 0x00A805D0
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

		// Token: 0x06025424 RID: 152612 RVA: 0x00A82459 File Offset: 0x00A80659
		private void RefreshLevelUp()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetSprite(5).SetUIActive(VillageInfrModel.Instance.GetCanTreeLevelUp(this.Id));
				return;
			}
			base.GetSprite(5).SetUIActive(VillageInfrModel.Instance.GetCanVillageLevelUp());
		}

		// Token: 0x06025425 RID: 152613 RVA: 0x00A82497 File Offset: 0x00A80697
		private void RefreshLock()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetItem(3).SetUIActive(!VillageInfrModel.Instance.GetTreeIsUnlock(this.Id));
				return;
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x06025426 RID: 152614 RVA: 0x00A824CF File Offset: 0x00A806CF
		public void SetSelectCb(Action<int, EVillageInfrSelectType> cb)
		{
			this.SelectCb = cb;
		}

		// Token: 0x06025427 RID: 152615 RVA: 0x00A824D8 File Offset: 0x00A806D8
		public void SetOnGetSeqEnd(Action cb)
		{
			this.OnGetSeqEnd = cb;
		}

		// Token: 0x06025428 RID: 152616 RVA: 0x00A824E1 File Offset: 0x00A806E1
		public void SetSelected(bool isSelected)
		{
			this.IsSelected = isSelected;
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			this.RefreshLineVisible();
		}

		// Token: 0x040149E6 RID: 84454
		public int Id;

		// Token: 0x040149E7 RID: 84455
		public EVillageInfrSelectType SelectType;

		// Token: 0x040149E8 RID: 84456
		private bool IsSelected;

		// Token: 0x040149E9 RID: 84457
		[Nullable(2)]
		private Action<int, EVillageInfrSelectType> SelectCb;

		// Token: 0x040149EA RID: 84458
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x040149EB RID: 84459
		[Nullable(2)]
		private Action OnGetSeqEnd;

		// Token: 0x040149EC RID: 84460
		private bool NeedPlayFinish;
	}
}
