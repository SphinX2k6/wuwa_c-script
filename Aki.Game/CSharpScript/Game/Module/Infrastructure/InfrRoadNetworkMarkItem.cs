using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048FA RID: 18682
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMarkItem : UiPanelBase
	{
		// Token: 0x0602EE66 RID: 192102 RVA: 0x00D1627C File Offset: 0x00D1447C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickBtnToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x17005EAC RID: 24236
		// (get) Token: 0x0602EE67 RID: 192103 RVA: 0x00D1642C File Offset: 0x00D1462C
		private InfrRoadBuild Config
		{
			get
			{
				return InfrastructureConfig.Instance.GetRoadConfigById(this.RoadId).Value;
			}
		}

		// Token: 0x0602EE68 RID: 192104 RVA: 0x00D16451 File Offset: 0x00D14651
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x0602EE69 RID: 192105 RVA: 0x00D1647C File Offset: 0x00D1467C
		protected override void OnAfterShow()
		{
			if (!this.NeedPlayFinishSeq)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer == null)
				{
					return;
				}
				seqPlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
		}

		// Token: 0x0602EE6A RID: 192106 RVA: 0x00D164B1 File Offset: 0x00D146B1
		public void Refresh(int roadId)
		{
			this.RoadId = roadId;
			this.RefreshDifficulty();
			this.RefreshTopRightIcon();
			this.RefreshPanel();
		}

		// Token: 0x0602EE6B RID: 192107 RVA: 0x00D164CC File Offset: 0x00D146CC
		private void RefreshDifficulty()
		{
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(this.RoadId);
			if (roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusProgress)
			{
				int difficulty = this.Config.Difficulty;
				UiResource? uiResource;
				string path = (UiResourceConfig.Instance.GetResourceConfig(InfrastructureDefine.difficultySpriteResourceId[difficulty]) != null) ? uiResource.GetValueOrDefault().Path : null;
				this.SetSpriteByPath(path, base.GetSprite(5), true, null, null);
				return;
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite == null)
			{
				return;
			}
			sprite.SetUIActive(false);
		}

		// Token: 0x0602EE6C RID: 192108 RVA: 0x00D1656C File Offset: 0x00D1476C
		private void RefreshTopRightIcon()
		{
			InfrastructureModel instance = InfrastructureModel.Instance;
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = instance.GetRoadDataByRoadId(this.RoadId);
			UUISprite sprite = base.GetSprite(4);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			if (roadDataByRoadId == null || (roadDataByRoadId != null && roadDataByRoadId.Status == InfrStatusPb.InfrStatusLock))
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(1);
				if (item2 != null)
				{
					item2.SetUIActive(true);
				}
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer == null)
				{
					return;
				}
				seqPlayer.PlayLevelSequenceByName("LockState", false, null, false);
				return;
			}
			else
			{
				if (instance.TracedRoadId != this.RoadId)
				{
					if (instance.RecommendRoadId == this.RoadId)
					{
						UUISprite sprite3 = base.GetSprite(4);
						if (sprite3 == null)
						{
							return;
						}
						sprite3.SetUIActive(true);
					}
					return;
				}
				UUISprite sprite4 = base.GetSprite(3);
				if (sprite4 == null)
				{
					return;
				}
				sprite4.SetUIActive(true);
				return;
			}
		}

		// Token: 0x0602EE6D RID: 192109 RVA: 0x00D16648 File Offset: 0x00D14848
		private void RefreshPanel()
		{
			InfrastructureDefine.IInfrRoadData roadDataByRoadId = InfrastructureModel.Instance.GetRoadDataByRoadId(this.RoadId);
			InfrStatusPb infrStatusPb = (roadDataByRoadId != null) ? roadDataByRoadId.Status : InfrStatusPb.InfrStatusLock;
			if (infrStatusPb == InfrStatusPb.InfrStatusLock)
			{
				UUIItem item = base.GetItem(8);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				UUINiagara uiNiagara = base.GetUiNiagara(7);
				if (uiNiagara != null)
				{
					uiNiagara.SetUIActive(false);
				}
			}
			else if (infrStatusPb == InfrStatusPb.InfrStatusComplete)
			{
				if (!this.NeedPlayFinishSeq || this.FinishId != this.RoadId)
				{
					UUIItem item2 = base.GetItem(8);
					if (item2 != null)
					{
						item2.SetUIActive(false);
					}
					UUIItem item3 = base.GetItem(2);
					if (item3 != null)
					{
						item3.SetUIActive(true);
					}
					UUIItem item4 = base.GetItem(1);
					if (item4 != null)
					{
						item4.SetUIActive(true);
					}
					UUINiagara uiNiagara2 = base.GetUiNiagara(7);
					if (uiNiagara2 != null)
					{
						uiNiagara2.SetUIActive(true);
					}
					UUIItem item5 = base.GetItem(6);
					if (item5 != null)
					{
						item5.SetUIActive(true);
					}
				}
			}
			else
			{
				UUIItem item6 = base.GetItem(8);
				if (item6 != null)
				{
					item6.SetUIActive(false);
				}
				UUINiagara uiNiagara3 = base.GetUiNiagara(7);
				if (uiNiagara3 != null)
				{
					uiNiagara3.SetUIActive(true);
				}
			}
			bool roadMaterialEnough = InfrastructureModel.Instance.GetRoadMaterialEnough(this.RoadId);
			UUIItem item7 = base.GetItem(9);
			if (item7 == null)
			{
				return;
			}
			item7.SetUIActive(roadMaterialEnough && infrStatusPb == InfrStatusPb.InfrStatusProgress);
		}

		// Token: 0x0602EE6E RID: 192110 RVA: 0x00D16774 File Offset: 0x00D14974
		public void SetOnClickToggleCb(Action<int> cb)
		{
			this.OnClickToggleCb = cb;
		}

		// Token: 0x0602EE6F RID: 192111 RVA: 0x00D1677D File Offset: 0x00D1497D
		private void OnClickBtnToggle(EToggleState _)
		{
			Action<int> onClickToggleCb = this.OnClickToggleCb;
			if (onClickToggleCb == null)
			{
				return;
			}
			onClickToggleCb(this.RoadId);
		}

		// Token: 0x0602EE70 RID: 192112 RVA: 0x00D16795 File Offset: 0x00D14995
		public void SetSelected(bool selected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			if (selected)
			{
				Action<int> onClickToggleCb = this.OnClickToggleCb;
				if (onClickToggleCb == null)
				{
					return;
				}
				onClickToggleCb(this.RoadId);
			}
		}

		// Token: 0x0602EE71 RID: 192113 RVA: 0x00D167CD File Offset: 0x00D149CD
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq, int finishId)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
			this.FinishId = finishId;
		}

		// Token: 0x0602EE72 RID: 192114 RVA: 0x00D167E0 File Offset: 0x00D149E0
		public void ShowMarkFinish(Action cb)
		{
			this.NeedPlayFinishSeq = false;
			this.RefreshPanel();
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Finish", false, null, false);
			}
			this.OnFinishPlayEnd = cb;
		}

		// Token: 0x0602EE73 RID: 192115 RVA: 0x00D16824 File Offset: 0x00D14A24
		public void ShowMarkUnlock(Action cb)
		{
			InfrastructureModel.Instance.SetUnlockRoadMarkPlaySeq(this.RoadId);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayLevelSequenceByName("Unlock", false, null, false);
			}
			this.OnUnlockPlayEnd = cb;
		}

		// Token: 0x0602EE74 RID: 192116 RVA: 0x00D1686C File Offset: 0x00D14A6C
		private void OnSequenceClose(string sequenceName)
		{
			if (sequenceName == "Finish")
			{
				Action onFinishPlayEnd = this.OnFinishPlayEnd;
				if (onFinishPlayEnd != null)
				{
					onFinishPlayEnd();
				}
				this.OnFinishPlayEnd = null;
				return;
			}
			if (sequenceName == "Unlock")
			{
				Action onUnlockPlayEnd = this.OnUnlockPlayEnd;
				if (onUnlockPlayEnd != null)
				{
					onUnlockPlayEnd();
				}
				this.OnUnlockPlayEnd = null;
			}
		}

		// Token: 0x0602EE75 RID: 192117 RVA: 0x00D168C4 File Offset: 0x00D14AC4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			UUIItem uuiitem = (extendToggle != null) ? extendToggle.GetRootComponent() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x04018E0B RID: 101899
		private int RoadId;

		// Token: 0x04018E0C RID: 101900
		private bool NeedPlayFinishSeq;

		// Token: 0x04018E0D RID: 101901
		private int FinishId;

		// Token: 0x04018E0E RID: 101902
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04018E0F RID: 101903
		private Action<int> OnClickToggleCb;

		// Token: 0x04018E10 RID: 101904
		private Action OnFinishPlayEnd;

		// Token: 0x04018E11 RID: 101905
		private Action OnUnlockPlayEnd;

		// Token: 0x0200A5CE RID: 42446
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x040334EB RID: 210155
			public const int Toggle = 0;

			// Token: 0x040334EC RID: 210156
			public const int PanelIcon = 1;

			// Token: 0x040334ED RID: 210157
			public const int PanelNor = 2;

			// Token: 0x040334EE RID: 210158
			public const int SpriteTarget = 3;

			// Token: 0x040334EF RID: 210159
			public const int SpriteRecommend = 4;

			// Token: 0x040334F0 RID: 210160
			public const int SpriteStar = 5;

			// Token: 0x040334F1 RID: 210161
			public const int PanelDone = 6;

			// Token: 0x040334F2 RID: 210162
			public const int NiagaraUnlock = 7;

			// Token: 0x040334F3 RID: 210163
			public const int PanelLock = 8;

			// Token: 0x040334F4 RID: 210164
			public const int PanelUpgrade = 9;
		}
	}
}
