using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

// Token: 0x020022C5 RID: 8901
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class MotorcycleAlbumItemGrid : AutoAttachItem<IAlbumUiData>, IStaticVariableResetter
{
	// Token: 0x060117AB RID: 71595 RVA: 0x00449451 File Offset: 0x00447651
	static MotorcycleAlbumItemGrid()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorcycleAlbumItemGrid.CreateStaticDefaultValue), new Action(MotorcycleAlbumItemGrid.ResetStaticDefaultValue));
	}

	// Token: 0x060117AC RID: 71596 RVA: 0x00449470 File Offset: 0x00447670
	public static void CreateStaticDefaultValue()
	{
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x060117AD RID: 71597 RVA: 0x00449484 File Offset: 0x00447684
	public static void ResetStaticDefaultValue()
	{
		MotorcycleAlbumItemGrid.RotateCurve = null;
		MotorcycleAlbumItemGrid.ScaleCurve = null;
		MotorcycleAlbumItemGrid.AlphaCurve = null;
	}

	// Token: 0x060117AE RID: 71598 RVA: 0x00449498 File Offset: 0x00447698
	[NullableContext(1)]
	public MotorcycleAlbumItemGrid(AActor actor) : base(actor)
	{
	}

	// Token: 0x060117AF RID: 71599 RVA: 0x004494EC File Offset: 0x004476EC
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

	// Token: 0x060117B0 RID: 71600 RVA: 0x00449678 File Offset: 0x00447878
	public IAlbumUiData GetAlbumData()
	{
		return this.AlbumData;
	}

	// Token: 0x060117B1 RID: 71601 RVA: 0x00449680 File Offset: 0x00447880
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

	// Token: 0x060117B2 RID: 71602 RVA: 0x004496A6 File Offset: 0x004478A6
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

	// Token: 0x060117B3 RID: 71603 RVA: 0x004496CC File Offset: 0x004478CC
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

	// Token: 0x060117B4 RID: 71604 RVA: 0x0044970C File Offset: 0x0044790C
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

	// Token: 0x060117B5 RID: 71605 RVA: 0x00449804 File Offset: 0x00447A04
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

	// Token: 0x060117B6 RID: 71606 RVA: 0x00449955 File Offset: 0x00447B55
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

	// Token: 0x060117B7 RID: 71607 RVA: 0x0044998A File Offset: 0x00447B8A
	protected override void OnUnSelect()
	{
		base.GetExtendToggle(0).SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060117B8 RID: 71608 RVA: 0x0044999C File Offset: 0x00447B9C
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

	// Token: 0x040084BE RID: 33982
	public Action<int> OnSelectAlbumItem;

	// Token: 0x040084BF RID: 33983
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleAlbumItemGrid, int> OnClickAlbumItem;

	// Token: 0x040084C0 RID: 33984
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<MotorcycleAlbumItemGrid, int> OnClickBtnPlay;

	// Token: 0x040084C1 RID: 33985
	private IAlbumUiData AlbumData;

	// Token: 0x040084C2 RID: 33986
	[Nullable(1)]
	protected global::Vector TmpVector = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040084C3 RID: 33987
	[Nullable(1)]
	protected Rotator TmpRotate = Rotator.Create(0f, 0f, 0f);

	// Token: 0x040084C4 RID: 33988
	public static UCurveFloat RotateCurve;

	// Token: 0x040084C5 RID: 33989
	public static UCurveFloat ScaleCurve;

	// Token: 0x040084C6 RID: 33990
	public static UCurveFloat AlphaCurve;

	// Token: 0x02008841 RID: 34881
	[NullableContext(0)]
	private class EAlbumComponents
	{
		// Token: 0x0402C453 RID: 181331
		public const int TogAlbum = 0;

		// Token: 0x0402C454 RID: 181332
		public const int PanelLike = 1;

		// Token: 0x0402C455 RID: 181333
		public const int TxtAlbumName = 2;

		// Token: 0x0402C456 RID: 181334
		public const int TxtDiscNum = 3;

		// Token: 0x0402C457 RID: 181335
		public const int BtnPlay = 4;

		// Token: 0x0402C458 RID: 181336
		public const int PanelPlaying = 5;

		// Token: 0x0402C459 RID: 181337
		public const int TexMaskL = 6;

		// Token: 0x0402C45A RID: 181338
		public const int TexMaskR = 7;

		// Token: 0x0402C45B RID: 181339
		public const int TexIcon = 8;

		// Token: 0x0402C45C RID: 181340
		public const int PanelOffset = 9;

		// Token: 0x0402C45D RID: 181341
		public const int ItemNew = 10;

		// Token: 0x0402C45E RID: 181342
		public const int PanelPause = 11;

		// Token: 0x0402C45F RID: 181343
		public const int PnlTimeLimit = 12;

		// Token: 0x0402C460 RID: 181344
		public const int UITextActor = 13;
	}
}
