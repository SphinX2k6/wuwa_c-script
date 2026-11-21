using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x020017A9 RID: 6057
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MotorcycleAlbumItemGrid : AutoAttachItem<IAlbumUiData>, IStaticVariableResetter
{
	// Token: 0x0600EC42 RID: 60482 RVA: 0x00456179 File Offset: 0x00454379
	static MotorcycleAlbumItemGrid()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleAlbumItemGrid.CreateStaticDefaultValue), new Action(MotorcycleAlbumItemGrid.ResetStaticDefaultValue));
	}

	// Token: 0x0600EC43 RID: 60483 RVA: 0x00456198 File Offset: 0x00454398
	public static void CreateStaticDefaultValue()
	{
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x0600EC44 RID: 60484 RVA: 0x004561AC File Offset: 0x004543AC
	public static void ResetStaticDefaultValue()
	{
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x0600EC45 RID: 60485 RVA: 0x004561C0 File Offset: 0x004543C0
	[NullableContext(1)]
	public MotorcycleAlbumItemGrid(AActor actor) : base(actor)
	{
	}

	// Token: 0x0600EC46 RID: 60486 RVA: 0x00456214 File Offset: 0x00454414
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnExtendTogglePanelLike)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickPanelPlaying))
		};
	}

	// Token: 0x0600EC47 RID: 60487 RVA: 0x004563A0 File Offset: 0x004545A0
	public IAlbumUiData GetAlbumData()
	{
		return this.AlbumData;
	}

	// Token: 0x0600EC48 RID: 60488 RVA: 0x004563A8 File Offset: 0x004545A8
	private void OnExtendTogglePanelLike(EToggleState state)
	{
		if (this.AlbumData != null)
		{
			Action<MotorcycleAlbumItemGrid, int> onClickAlbumItem = this.OnClickAlbumItem;
			if (onClickAlbumItem == null)
			{
				return;
			}
			onClickAlbumItem(this, this.AlbumData.Id);
		}
	}

	// Token: 0x0600EC49 RID: 60489 RVA: 0x004563CE File Offset: 0x004545CE
	private void OnClickPanelPlaying()
	{
		if (this.AlbumData != null)
		{
			Action<MotorcycleAlbumItemGrid, int> onClickBtnPlay = this.OnClickBtnPlay;
			if (onClickBtnPlay == null)
			{
				return;
			}
			onClickBtnPlay(this, this.AlbumData.Id);
		}
	}

	// Token: 0x0600EC4A RID: 60490 RVA: 0x004563F4 File Offset: 0x004545F4
	private int GetAlbumUnlockMusicNum()
	{
		if (this.AlbumData == null)
		{
			return 0;
		}
		if (this.AlbumData.Id == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			return MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().Count;
		}
		return this.AlbumData.UnlockMusicNum;
	}

	// Token: 0x0600EC4B RID: 60491 RVA: 0x00456434 File Offset: 0x00454634
	private void RefreshState()
	{
		if (this.AlbumData == null)
		{
			return;
		}
		bool flag = this.GetAlbumUnlockMusicNum() > 0;
		bool flag2 = flag && MotorcycleMusicPlayerModel.Instance.GetCurPlayAlbum() == this.AlbumData.Id;
		bool isPause = MotorcycleMusicPlayerModel.Instance.GetIsPause();
		base.GetItem(5).SetUIActive(flag2 && !isPause);
		base.GetButton(4).RootUIComp.Get().SetUIActive(flag && !flag2 && this.SelectState);
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(flag2 && isPause);
		}
		bool flag3 = MotorcycleMusicPlayerModel.Instance.IsTimeLimitAlbum(this.AlbumData.Id);
		UUIItem item2 = base.GetItem(12);
		if (item2 != null)
		{
			item2.SetUIActive(flag3);
		}
		if (flag3)
		{
			string albumTimeLimitRemainText = MotorcycleMusicPlayerModel.Instance.GetAlbumTimeLimitRemainText(this.AlbumData.Id);
			UUIText text = base.GetText(13);
			if (text == null)
			{
				return;
			}
			text.SetText(albumTimeLimitRemainText, true);
		}
	}

	// Token: 0x0600EC4C RID: 60492 RVA: 0x0045652C File Offset: 0x0045472C
	protected override void OnRefreshItem(IAlbumUiData data)
	{
		if (data == null)
		{
			return;
		}
		this.AlbumData = data;
		PhonographAlbum config = data.Config;
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(config.Title);
		}
		if (data.Id == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId())
		{
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetText(MotorcycleMusicPlayerModel.Instance.GetFavoriteMusicList().Count.ToString(), true);
			}
		}
		else
		{
			UUIText text3 = base.GetText(3);
			if (text3 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.UnlockMusicNum);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(data.AllMusicNum);
				text3.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
		}
		bool uiactive = MotorcycleMusicPlayerModel.Instance.CheckAlbumHasNewMusic(data.Id);
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		base.SetTextureByPath(config.Cover, base.GetTexture(8), null, null);
		UUIItem item2 = base.GetItem(1);
		if (item2 != null)
		{
			item2.SetUIActive(data.Id == MotorcycleMusicPlayerConfig.Instance.GetFavoriteAlbumId());
		}
		base.GetExtendToggle(0).SetToggleStateForce(data.IsSelected.GetValueOrDefault() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		this.RefreshState();
	}

	// Token: 0x0600EC4D RID: 60493 RVA: 0x0045667D File Offset: 0x0045487D
	public override void OnSelect()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		if (this.AlbumData != null)
		{
			Action<int> onSelectAlbumItem = this.OnSelectAlbumItem;
			if (onSelectAlbumItem == null)
			{
				return;
			}
			onSelectAlbumItem(this.AlbumData.Id);
		}
	}

	// Token: 0x0600EC4E RID: 60494 RVA: 0x004566B2 File Offset: 0x004548B2
	protected override void OnUnSelect()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EC4F RID: 60495 RVA: 0x004566C4 File Offset: 0x004548C4
	protected override void OnMoveItem()
	{
		float currentMovePercentage = base.GetCurrentMovePercentage();
		float num = MathUtils.Instance.RangeClamp(Math.Abs(this.RootItem.GetAnchorOffsetX()), 276f, 552f, 0f, 117f);
		if (currentMovePercentage > 0.5f)
		{
			num = -num;
		}
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetAnchorOffsetX(num);
		}
		float num2 = this.RootItem.GetAnchorOffsetX() + num;
		this.TmpRotate.Pitch = MotorcycleAlbumItemGrid.RotateCurve.GetFloatValue(num2);
		float floatValue = MotorcycleAlbumItemGrid.AlphaCurve.GetFloatValue(num2);
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAlpha(floatValue);
		}
		float floatValue2 = MotorcycleAlbumItemGrid.ScaleCurve.GetFloatValue(num2);
		UUIItem item2 = base.GetItem(9);
		FRotator frotator = this.TmpRotate.ToUeRotator();
		item2.SetUIRelativeRotation(frotator);
		this.TmpVector.Set((double)floatValue2, (double)floatValue2, (double)floatValue2);
		base.GetItem(9).SetUIItemScale(this.TmpVector.ToUeVectorOld());
		if (num2 > 70f)
		{
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(true);
			}
			UUIItem item4 = base.GetItem(6);
			if (item4 != null)
			{
				item4.SetAlpha(MathUtils.Instance.RangeClamp(num2, 70f, 170f, 0f, 1f));
			}
		}
		else
		{
			UUIItem item5 = base.GetItem(6);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
		}
		if (num2 < -70f)
		{
			UUIItem item6 = base.GetItem(7);
			if (item6 != null)
			{
				item6.SetUIActive(true);
			}
			UUIItem item7 = base.GetItem(7);
			if (item7 == null)
			{
				return;
			}
			item7.SetAlpha(MathUtils.Instance.RangeClamp(num2, -70f, -170f, 0f, 1f));
			return;
		}
		else
		{
			UUIItem item8 = base.GetItem(7);
			if (item8 == null)
			{
				return;
			}
			item8.SetUIActive(false);
			return;
		}
	}

	// Token: 0x040085FC RID: 34300
	public Action<int> OnSelectAlbumItem;

	// Token: 0x040085FD RID: 34301
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleAlbumItemGrid, int> OnClickAlbumItem;

	// Token: 0x040085FE RID: 34302
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleAlbumItemGrid, int> OnClickBtnPlay;

	// Token: 0x040085FF RID: 34303
	private IAlbumUiData AlbumData;

	// Token: 0x04008600 RID: 34304
	[Nullable(1)]
	protected global::Vector TmpVector = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04008601 RID: 34305
	[Nullable(1)]
	protected Rotator TmpRotate = Rotator.Create(0f, 0f, 0f);

	// Token: 0x04008602 RID: 34306
	public static UCurveFloat RotateCurve;

	// Token: 0x04008603 RID: 34307
	public static UCurveFloat ScaleCurve;

	// Token: 0x04008604 RID: 34308
	public static UCurveFloat AlphaCurve;

	// Token: 0x020079C5 RID: 31173
	[NullableContext(0)]
	private class EAlbumComponents
	{
		// Token: 0x04027755 RID: 161621
		public const int TogAlbum = 0;

		// Token: 0x04027756 RID: 161622
		public const int PanelLike = 1;

		// Token: 0x04027757 RID: 161623
		public const int TxtAlbumName = 2;

		// Token: 0x04027758 RID: 161624
		public const int TxtDiscNum = 3;

		// Token: 0x04027759 RID: 161625
		public const int BtnPlay = 4;

		// Token: 0x0402775A RID: 161626
		public const int PanelPlaying = 5;

		// Token: 0x0402775B RID: 161627
		public const int TexMaskL = 6;

		// Token: 0x0402775C RID: 161628
		public const int TexMaskR = 7;

		// Token: 0x0402775D RID: 161629
		public const int TexIcon = 8;

		// Token: 0x0402775E RID: 161630
		public const int PanelOffset = 9;

		// Token: 0x0402775F RID: 161631
		public const int ItemNew = 10;

		// Token: 0x04027760 RID: 161632
		public const int PanelPause = 11;

		// Token: 0x04027761 RID: 161633
		public const int PnlTimeLimit = 12;

		// Token: 0x04027762 RID: 161634
		public const int UITextActor = 13;
	}
}
