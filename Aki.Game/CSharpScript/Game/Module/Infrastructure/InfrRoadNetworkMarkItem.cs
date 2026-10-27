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
	// Token: 0x02005921 RID: 22817
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkMarkItem : UiPanelBase
	{
		// Token: 0x06039F43 RID: 237379 RVA: 0x00DC6F54 File Offset: 0x00DC5154
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

		// Token: 0x17008AE0 RID: 35552
		// (get) Token: 0x06039F44 RID: 237380 RVA: 0x00DC7104 File Offset: 0x00DC5304
		private InfrRoadBuild Config
		{
			get
			{
				return InfrastructureConfig.Instance.GetRoadConfigById(this.RoadId).Value;
			}
		}

		// Token: 0x06039F45 RID: 237381 RVA: 0x00DC7129 File Offset: 0x00DC5329
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
		}

		// Token: 0x06039F46 RID: 237382 RVA: 0x00DC7154 File Offset: 0x00DC5354
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

		// Token: 0x06039F47 RID: 237383 RVA: 0x00DC7189 File Offset: 0x00DC5389
		public void Refresh(int roadId)
		{
			this.RoadId = roadId;
			this.RefreshDifficulty();
			this.RefreshTopRightIcon();
			this.RefreshPanel();
		}

		// Token: 0x06039F48 RID: 237384 RVA: 0x00DC71A4 File Offset: 0x00DC53A4
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

		// Token: 0x06039F49 RID: 237385 RVA: 0x00DC7244 File Offset: 0x00DC5444
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

		// Token: 0x06039F4A RID: 237386 RVA: 0x00DC7320 File Offset: 0x00DC5520
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

		// Token: 0x06039F4B RID: 237387 RVA: 0x00DC744C File Offset: 0x00DC564C
		public void SetOnClickToggleCb(Action<int> cb)
		{
			this.OnClickToggleCb = cb;
		}

		// Token: 0x06039F4C RID: 237388 RVA: 0x00DC7455 File Offset: 0x00DC5655
		private void OnClickBtnToggle(EToggleState _)
		{
			Action<int> onClickToggleCb = this.OnClickToggleCb;
			if (onClickToggleCb == null)
			{
				return;
			}
			onClickToggleCb(this.RoadId);
		}

		// Token: 0x06039F4D RID: 237389 RVA: 0x00DC746D File Offset: 0x00DC566D
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

		// Token: 0x06039F4E RID: 237390 RVA: 0x00DC74A5 File Offset: 0x00DC56A5
		public void SetNeedPlayFinishSeq(bool needPlayFinishSeq, int finishId)
		{
			this.NeedPlayFinishSeq = needPlayFinishSeq;
			this.FinishId = finishId;
		}

		// Token: 0x06039F4F RID: 237391 RVA: 0x00DC74B8 File Offset: 0x00DC56B8
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

		// Token: 0x06039F50 RID: 237392 RVA: 0x00DC74FC File Offset: 0x00DC56FC
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

		// Token: 0x06039F51 RID: 237393 RVA: 0x00DC7544 File Offset: 0x00DC5744
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

		// Token: 0x06039F52 RID: 237394 RVA: 0x00DC759C File Offset: 0x00DC579C
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

		// Token: 0x0401E36E RID: 123758
		private int RoadId;

		// Token: 0x0401E36F RID: 123759
		private bool NeedPlayFinishSeq;

		// Token: 0x0401E370 RID: 123760
		private int FinishId;

		// Token: 0x0401E371 RID: 123761
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401E372 RID: 123762
		private Action<int> OnClickToggleCb;

		// Token: 0x0401E373 RID: 123763
		private Action OnFinishPlayEnd;

		// Token: 0x0401E374 RID: 123764
		private Action OnUnlockPlayEnd;

		// Token: 0x0200BBBF RID: 48063
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038B09 RID: 232201
			public const int Toggle = 0;

			// Token: 0x04038B0A RID: 232202
			public const int PanelIcon = 1;

			// Token: 0x04038B0B RID: 232203
			public const int PanelNor = 2;

			// Token: 0x04038B0C RID: 232204
			public const int SpriteTarget = 3;

			// Token: 0x04038B0D RID: 232205
			public const int SpriteRecommend = 4;

			// Token: 0x04038B0E RID: 232206
			public const int SpriteStar = 5;

			// Token: 0x04038B0F RID: 232207
			public const int PanelDone = 6;

			// Token: 0x04038B10 RID: 232208
			public const int NiagaraUnlock = 7;

			// Token: 0x04038B11 RID: 232209
			public const int PanelLock = 8;

			// Token: 0x04038B12 RID: 232210
			public const int PanelUpgrade = 9;
		}
	}
}
