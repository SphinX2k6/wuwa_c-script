using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200550A RID: 21770
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardBackpackGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x170068B2 RID: 26802
		// (get) Token: 0x06035F42 RID: 220994 RVA: 0x00F11668 File Offset: 0x00F0F868
		// (set) Token: 0x06035F43 RID: 220995 RVA: 0x00F11670 File Offset: 0x00F0F870
		public EFishingGridShowType ShowType
		{
			get
			{
				return this.ShowTypeInternal;
			}
			set
			{
				if (this.ShowTypeInternal == value)
				{
					return;
				}
				this.ShowTypeInternal = value;
				this.StateFunc[value]();
			}
		}

		// Token: 0x06035F44 RID: 220996 RVA: 0x00F11694 File Offset: 0x00F0F894
		private void SetDisableState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridSellDisable");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F45 RID: 220997 RVA: 0x00F116D8 File Offset: 0x00F0F8D8
		private void SetEmptyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridEmpty");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F46 RID: 220998 RVA: 0x00F1171C File Offset: 0x00F0F91C
		private void SetPreviewState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F47 RID: 220999 RVA: 0x00F11760 File Offset: 0x00F0F960
		private void SetSingleOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridReplace");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F48 RID: 221000 RVA: 0x00F117A4 File Offset: 0x00F0F9A4
		private void SetMultiOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F49 RID: 221001 RVA: 0x00F117E8 File Offset: 0x00F0F9E8
		private void SetProhibitState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F4A RID: 221002 RVA: 0x00F1182C File Offset: 0x00F0FA2C
		private void SetFinishState()
		{
			int previewBackpackData = this.ParentModel.GetPreviewBackpackData(this.BackpackGridPos);
			DockyardItemBlockData itemBlockData = this.ParentModel.BackpackData.GetItemBlockData(previewBackpackData);
			this.SetSpriteByPath(FishingConfig.Instance.GetFishingQualityConfig(itemBlockData.Data.Quality).GridSprite, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06035F4B RID: 221003 RVA: 0x00F118A0 File Offset: 0x00F0FAA0
		public DockyardBackpackGrid(DockyardBackpackPanelModelBase parentModel)
		{
			this.ParentModel = parentModel;
			this.StateFunc = new Dictionary<EFishingGridShowType, Action>
			{
				{
					EFishingGridShowType.None,
					null
				},
				{
					EFishingGridShowType.Disable,
					new Action(this.SetDisableState)
				},
				{
					EFishingGridShowType.Empty,
					new Action(this.SetEmptyState)
				},
				{
					EFishingGridShowType.Preview,
					new Action(this.SetPreviewState)
				},
				{
					EFishingGridShowType.SingleOccupancy,
					new Action(this.SetSingleOccupancyState)
				},
				{
					EFishingGridShowType.MultiOccupancy,
					new Action(this.SetMultiOccupancyState)
				},
				{
					EFishingGridShowType.Prohibit,
					new Action(this.SetProhibitState)
				},
				{
					EFishingGridShowType.Finish,
					new Action(this.SetFinishState)
				}
			};
		}

		// Token: 0x06035F4C RID: 221004 RVA: 0x00F11954 File Offset: 0x00F0FB54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035F4D RID: 221005 RVA: 0x00F119E0 File Offset: 0x00F0FBE0
		protected override void OnStart()
		{
			this.BgSprite = base.GetSprite(0);
			this.QuicklySellSprite = base.GetSprite(1);
			this.SequencePlayer = new UiSequencePlayer(this.QuicklySellSprite);
			this.RootSequence = new UiSequencePlayer(this.RootItem);
			this.SetSpriteMaskActive(false);
		}

		// Token: 0x06035F4E RID: 221006 RVA: 0x00F11A30 File Offset: 0x00F0FC30
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
			this.RootSequence.Clear();
		}

		// Token: 0x06035F4F RID: 221007 RVA: 0x00F11A48 File Offset: 0x00F0FC48
		private void SetQuicklySellSuccessState()
		{
			this.QuicklySellSprite.SetColor(FColor.FromHex("#DAC8AC"));
			this.QuicklySellSprite.SetUIActive(true);
			if (!this.SequencePlayer.IsSequenceInPlaying("Activate"))
			{
				this.SequencePlayer.PlaySequencePurely("Activate", false, false);
			}
		}

		// Token: 0x06035F50 RID: 221008 RVA: 0x00F11A9C File Offset: 0x00F0FC9C
		private void SetQuicklySellFailureState()
		{
			this.QuicklySellSprite.SetColor(FColor.FromHex("#F88D99"));
			this.QuicklySellSprite.SetUIActive(true);
			if (!this.SequencePlayer.IsSequenceInPlaying("Activate"))
			{
				this.SequencePlayer.PlaySequencePurely("Activate", false, false);
			}
		}

		// Token: 0x06035F51 RID: 221009 RVA: 0x00F11AF0 File Offset: 0x00F0FCF0
		private void SetQuicklySellNormalState()
		{
			this.QuicklySellSprite.SetUIActive(this.BackpackGridData.IsQuicklySell);
			this.SequencePlayer.StopSequenceByKey("Activate", true, true);
			if (this.BackpackGridData.IsQuicklySell)
			{
				this.QuicklySellSprite.SetColor(FColor.FromHex("#FFFFFF"));
			}
		}

		// Token: 0x06035F52 RID: 221010 RVA: 0x00F11B47 File Offset: 0x00F0FD47
		public bool InDisable()
		{
			return !this.BackpackGridData.IsValid;
		}

		// Token: 0x06035F53 RID: 221011 RVA: 0x00F11B57 File Offset: 0x00F0FD57
		public bool IsQuicklySell()
		{
			return this.BackpackGridData.IsQuicklySell;
		}

		// Token: 0x06035F54 RID: 221012 RVA: 0x00F11B64 File Offset: 0x00F0FD64
		public override void Refresh(IPanelPos pos, bool isSelected, int gridIndex)
		{
			this.BackpackGridPos = pos;
			this.BackpackGridData = this.ParentModel.BackpackData.GetBackpackGridData(pos);
			this.QuicklySellSprite.SetUIActive(this.BackpackGridData.IsQuicklySell);
			this.ShowType = (this.InDisable() ? EFishingGridShowType.Disable : EFishingGridShowType.Empty);
		}

		// Token: 0x06035F55 RID: 221013 RVA: 0x00F11BB8 File Offset: 0x00F0FDB8
		public void RefreshPreview(int id, EFishingGridShowType showType)
		{
			if (this.InDisable())
			{
				this.ShowType = EFishingGridShowType.Prohibit;
				return;
			}
			if (this.ParentModel.IsInSelectState)
			{
				this.SetSpriteMaskActive(false);
			}
			if (showType == EFishingGridShowType.Preview)
			{
				this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, id);
				this.ShowType = EFishingGridShowType.Preview;
				return;
			}
			if (showType == EFishingGridShowType.Finish)
			{
				this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, id);
				this.ShowType = EFishingGridShowType.Finish;
				return;
			}
			this.ShowType = showType;
		}

		// Token: 0x06035F56 RID: 221014 RVA: 0x00F11C2C File Offset: 0x00F0FE2C
		public void RefreshQuicklySell(EFishingQuicklySellType showType)
		{
			if (showType == EFishingQuicklySellType.QuicklySellSuccess)
			{
				this.SetQuicklySellSuccessState();
				return;
			}
			if (showType == EFishingQuicklySellType.QuicklySellFailure)
			{
				this.SetQuicklySellFailureState();
				return;
			}
			if (showType == EFishingQuicklySellType.Normal)
			{
				this.SetQuicklySellNormalState();
			}
		}

		// Token: 0x06035F57 RID: 221015 RVA: 0x00F11C4D File Offset: 0x00F0FE4D
		public void ResetQuicklySell()
		{
			this.RefreshQuicklySell(EFishingQuicklySellType.Normal);
		}

		// Token: 0x06035F58 RID: 221016 RVA: 0x00F11C56 File Offset: 0x00F0FE56
		public void ResetPreviewBgForce()
		{
			if (this.InDisable())
			{
				this.ShowType = EFishingGridShowType.Disable;
				return;
			}
			this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, -1);
			this.ShowType = EFishingGridShowType.Empty;
		}

		// Token: 0x06035F59 RID: 221017 RVA: 0x00F11C84 File Offset: 0x00F0FE84
		public void ResetPreviewBg(int id)
		{
			if (this.InDisable())
			{
				this.ShowType = EFishingGridShowType.Disable;
				return;
			}
			int previewBackpackData = this.ParentModel.GetPreviewBackpackData(this.BackpackGridPos);
			if (previewBackpackData == id || previewBackpackData == -1)
			{
				this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, -1);
				this.ShowType = EFishingGridShowType.Empty;
				this.SetSpriteMaskActive(false);
				return;
			}
			this.ShowType = EFishingGridShowType.Finish;
			this.SetSpriteMaskActive(this.ParentModel.IsInSelectState);
		}

		// Token: 0x06035F5A RID: 221018 RVA: 0x00F11CF4 File Offset: 0x00F0FEF4
		public void SetItemBlockId(int id)
		{
			this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, id);
		}

		// Token: 0x06035F5B RID: 221019 RVA: 0x00F11D08 File Offset: 0x00F0FF08
		public int GetItemBlockId()
		{
			return this.ParentModel.GetPreviewBackpackData(this.BackpackGridPos);
		}

		// Token: 0x06035F5C RID: 221020 RVA: 0x00F11D1B File Offset: 0x00F0FF1B
		public override object GetKey(IPanelPos data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06035F5D RID: 221021 RVA: 0x00F11D1E File Offset: 0x00F0FF1E
		public void SetSpriteMaskActive(bool value)
		{
			base.GetSprite(2).SetUIActive(value);
		}

		// Token: 0x06035F5E RID: 221022 RVA: 0x00F11D2D File Offset: 0x00F0FF2D
		public void PlaySequence(string sequenceName)
		{
			this.RootSequence.StopPrevSequence(false, true);
			this.RootSequence.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x0401C837 RID: 116791
		private DockyardBackpackGridData BackpackGridData;

		// Token: 0x0401C838 RID: 116792
		private IPanelPos BackpackGridPos;

		// Token: 0x0401C839 RID: 116793
		private readonly DockyardBackpackPanelModelBase ParentModel;

		// Token: 0x0401C83A RID: 116794
		private EFishingGridShowType ShowTypeInternal;

		// Token: 0x0401C83B RID: 116795
		private UUISprite BgSprite;

		// Token: 0x0401C83C RID: 116796
		private UUISprite QuicklySellSprite;

		// Token: 0x0401C83D RID: 116797
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C83E RID: 116798
		private UiSequencePlayer RootSequence;

		// Token: 0x0401C83F RID: 116799
		private readonly Dictionary<EFishingGridShowType, Action> StateFunc;

		// Token: 0x0200B16E RID: 45422
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04036DD3 RID: 224723
			public const int BgSprite = 0;

			// Token: 0x04036DD4 RID: 224724
			public const int QuicklySellSprite = 1;

			// Token: 0x04036DD5 RID: 224725
			public const int SpriteMask = 2;
		}
	}
}
