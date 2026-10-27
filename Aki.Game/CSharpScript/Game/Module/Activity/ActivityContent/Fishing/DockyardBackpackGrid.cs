using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200658C RID: 25996
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DockyardBackpackGrid : GridProxyAbstract<IPanelPos>
	{
		// Token: 0x17009550 RID: 38224
		// (get) Token: 0x0604127D RID: 266877 RVA: 0x00FCA6B8 File Offset: 0x00FC88B8
		// (set) Token: 0x0604127E RID: 266878 RVA: 0x00FCA6C0 File Offset: 0x00FC88C0
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

		// Token: 0x0604127F RID: 266879 RVA: 0x00FCA6E4 File Offset: 0x00FC88E4
		private void SetDisableState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridSellDisable");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041280 RID: 266880 RVA: 0x00FCA728 File Offset: 0x00FC8928
		private void SetEmptyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridEmpty");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041281 RID: 266881 RVA: 0x00FCA76C File Offset: 0x00FC896C
		private void SetPreviewState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridFinsh");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041282 RID: 266882 RVA: 0x00FCA7B0 File Offset: 0x00FC89B0
		private void SetSingleOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridReplace");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041283 RID: 266883 RVA: 0x00FCA7F4 File Offset: 0x00FC89F4
		private void SetMultiOccupancyState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041284 RID: 266884 RVA: 0x00FCA838 File Offset: 0x00FC8A38
		private void SetProhibitState()
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("SP_GridError");
			this.SetSpriteByPath(resourcePath, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041285 RID: 266885 RVA: 0x00FCA87C File Offset: 0x00FC8A7C
		private void SetFinishState()
		{
			int previewBackpackData = this.ParentModel.GetPreviewBackpackData(this.BackpackGridPos);
			DockyardItemBlockData itemBlockData = this.ParentModel.BackpackData.GetItemBlockData(previewBackpackData);
			this.SetSpriteByPath(FishingConfig.Instance.GetFishingQualityConfig(itemBlockData.Data.Quality).GridSprite, this.BgSprite, false, null, null);
			this.BgSprite.SetUIActive(true);
		}

		// Token: 0x06041286 RID: 266886 RVA: 0x00FCA8F0 File Offset: 0x00FC8AF0
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

		// Token: 0x06041287 RID: 266887 RVA: 0x00FCA9A4 File Offset: 0x00FC8BA4
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

		// Token: 0x06041288 RID: 266888 RVA: 0x00FCAA30 File Offset: 0x00FC8C30
		protected override void OnStart()
		{
			this.BgSprite = base.GetSprite(0);
			this.QuicklySellSprite = base.GetSprite(1);
			this.SequencePlayer = new UiSequencePlayer(this.QuicklySellSprite);
			this.RootSequence = new UiSequencePlayer(this.RootItem);
			this.SetSpriteMaskActive(false);
		}

		// Token: 0x06041289 RID: 266889 RVA: 0x00FCAA80 File Offset: 0x00FC8C80
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer.Clear();
			this.RootSequence.Clear();
		}

		// Token: 0x0604128A RID: 266890 RVA: 0x00FCAA98 File Offset: 0x00FC8C98
		private void SetQuicklySellSuccessState()
		{
			this.QuicklySellSprite.SetColor(FColor.FromHex("#DAC8AC"));
			this.QuicklySellSprite.SetUIActive(true);
			if (!this.SequencePlayer.IsSequenceInPlaying("Activate"))
			{
				this.SequencePlayer.PlaySequencePurely("Activate", false, false);
			}
		}

		// Token: 0x0604128B RID: 266891 RVA: 0x00FCAAEC File Offset: 0x00FC8CEC
		private void SetQuicklySellFailureState()
		{
			this.QuicklySellSprite.SetColor(FColor.FromHex("#F88D99"));
			this.QuicklySellSprite.SetUIActive(true);
			if (!this.SequencePlayer.IsSequenceInPlaying("Activate"))
			{
				this.SequencePlayer.PlaySequencePurely("Activate", false, false);
			}
		}

		// Token: 0x0604128C RID: 266892 RVA: 0x00FCAB40 File Offset: 0x00FC8D40
		private void SetQuicklySellNormalState()
		{
			this.QuicklySellSprite.SetUIActive(this.BackpackGridData.IsQuicklySell);
			this.SequencePlayer.StopSequenceByKey("Activate", true, true);
			if (this.BackpackGridData.IsQuicklySell)
			{
				this.QuicklySellSprite.SetColor(FColor.FromHex("#FFFFFF"));
			}
		}

		// Token: 0x0604128D RID: 266893 RVA: 0x00FCAB97 File Offset: 0x00FC8D97
		public bool InDisable()
		{
			return !this.BackpackGridData.IsValid;
		}

		// Token: 0x0604128E RID: 266894 RVA: 0x00FCABA7 File Offset: 0x00FC8DA7
		public bool IsQuicklySell()
		{
			return this.BackpackGridData.IsQuicklySell;
		}

		// Token: 0x0604128F RID: 266895 RVA: 0x00FCABB4 File Offset: 0x00FC8DB4
		public override void Refresh(IPanelPos pos, bool isSelected, int gridIndex)
		{
			this.BackpackGridPos = pos;
			this.BackpackGridData = this.ParentModel.BackpackData.GetBackpackGridData(pos);
			this.QuicklySellSprite.SetUIActive(this.BackpackGridData.IsQuicklySell);
			this.ShowType = (this.InDisable() ? EFishingGridShowType.Disable : EFishingGridShowType.Empty);
		}

		// Token: 0x06041290 RID: 266896 RVA: 0x00FCAC08 File Offset: 0x00FC8E08
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

		// Token: 0x06041291 RID: 266897 RVA: 0x00FCAC7C File Offset: 0x00FC8E7C
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

		// Token: 0x06041292 RID: 266898 RVA: 0x00FCAC9D File Offset: 0x00FC8E9D
		public void ResetQuicklySell()
		{
			this.RefreshQuicklySell(EFishingQuicklySellType.Normal);
		}

		// Token: 0x06041293 RID: 266899 RVA: 0x00FCACA6 File Offset: 0x00FC8EA6
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

		// Token: 0x06041294 RID: 266900 RVA: 0x00FCACD4 File Offset: 0x00FC8ED4
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

		// Token: 0x06041295 RID: 266901 RVA: 0x00FCAD44 File Offset: 0x00FC8F44
		public void SetItemBlockId(int id)
		{
			this.ParentModel.SetPreviewBackpackData(this.BackpackGridPos, id);
		}

		// Token: 0x06041296 RID: 266902 RVA: 0x00FCAD58 File Offset: 0x00FC8F58
		public int GetItemBlockId()
		{
			return this.ParentModel.GetPreviewBackpackData(this.BackpackGridPos);
		}

		// Token: 0x06041297 RID: 266903 RVA: 0x00FCAD6B File Offset: 0x00FC8F6B
		public override object GetKey(IPanelPos data, int displayIndex)
		{
			return data;
		}

		// Token: 0x06041298 RID: 266904 RVA: 0x00FCAD6E File Offset: 0x00FC8F6E
		public void SetSpriteMaskActive(bool value)
		{
			base.GetSprite(2).SetUIActive(value);
		}

		// Token: 0x06041299 RID: 266905 RVA: 0x00FCAD7D File Offset: 0x00FC8F7D
		public void PlaySequence(string sequenceName)
		{
			this.RootSequence.StopPrevSequence(false, true);
			this.RootSequence.PlaySequencePurely(sequenceName, false, false);
		}

		// Token: 0x04021F06 RID: 139014
		private DockyardBackpackGridData BackpackGridData;

		// Token: 0x04021F07 RID: 139015
		private IPanelPos BackpackGridPos;

		// Token: 0x04021F08 RID: 139016
		private readonly DockyardBackpackPanelModelBase ParentModel;

		// Token: 0x04021F09 RID: 139017
		private EFishingGridShowType ShowTypeInternal;

		// Token: 0x04021F0A RID: 139018
		private UUISprite BgSprite;

		// Token: 0x04021F0B RID: 139019
		private UUISprite QuicklySellSprite;

		// Token: 0x04021F0C RID: 139020
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04021F0D RID: 139021
		private UiSequencePlayer RootSequence;

		// Token: 0x04021F0E RID: 139022
		private readonly Dictionary<EFishingGridShowType, Action> StateFunc;

		// Token: 0x0200C789 RID: 51081
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C482 RID: 246914
			public const int BgSprite = 0;

			// Token: 0x0403C483 RID: 246915
			public const int QuicklySellSprite = 1;

			// Token: 0x0403C484 RID: 246916
			public const int SpriteMask = 2;
		}
	}
}
