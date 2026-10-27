using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F6D RID: 3949
public class DrinksRoleStateItem : UiPanelBase
{
	// Token: 0x060064FE RID: 25854 RVA: 0x00140E34 File Offset: 0x0013F034
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUITexture)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
	}

	// Token: 0x060064FF RID: 25855 RVA: 0x00140F40 File Offset: 0x0013F140
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksRoleStateItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksRoleStateItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006500 RID: 25856 RVA: 0x00140F84 File Offset: 0x0013F184
	protected override void OnStart()
	{
		this.LevelSequence = new LevelSequencePlayer(base.GetItem(4));
		this.Layout = new GenericLayout<DrinksRoleRequireItem, IDrinksRequireInfo>(base.GetVerticalLayout(2), new Func<DrinksRoleRequireItem>(this.CreateRequestItem), null, false, true);
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			sprite.SetFillAmount(0f);
		}
		UUISprite sprite2 = base.GetSprite(7);
		if (sprite2 != null)
		{
			sprite2.SetFillAmount(0f);
		}
		int roleId = DrinksModel.Instance.GetRoleId();
		base.SetRoleIcon("", base.GetTexture(0), roleId, null, null);
		this.MaxScore = (float)DrinksModel.Instance.GetLikenessMax();
		this.InitCurState();
		this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenFloatSetterDynamic>(new Action<float>(this.UpdateProgress));
	}

	// Token: 0x06006501 RID: 25857 RVA: 0x00141048 File Offset: 0x0013F248
	protected override void OnBeforeDestroy()
	{
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateProgress));
			this.Delegate = null;
		}
	}

	// Token: 0x06006502 RID: 25858 RVA: 0x0014106C File Offset: 0x0013F26C
	public void RefreshCurState()
	{
		ValueTuple<int, List<IDrinksRequireInfo>> roleState = DrinksModel.Instance.GetRoleState();
		int item = roleState.Item1;
		List<IDrinksRequireInfo> item2 = roleState.Item2;
		GenericLayout<DrinksRoleRequireItem, IDrinksRequireInfo> layout = this.Layout;
		if (layout != null)
		{
			layout.RefreshByData(item2, null, false);
		}
		if ((float)item == this.EndLikeness)
		{
			return;
		}
		this.EndLikeness = (float)item;
		if (this.Tweener != null)
		{
			this.Tweener.Kill(false);
			this.Tweener = null;
		}
		this.Tweener = ULTweenBPLibrary.FloatTo(GlobalData.World, this.Delegate, this.CurLikeness, (float)item, 0.5f, 0f, LTweenEase.OutCubic);
		if (this.Tweener != null)
		{
			this.Tweener.OnCompleteCallBack.Bind(new Action(this.OnTweenerEnd));
			this.Tweener.SetCurveFloat(this.Curve);
		}
	}

	// Token: 0x06006503 RID: 25859 RVA: 0x00141134 File Offset: 0x0013F334
	protected void InitCurState()
	{
		List<IDrinksRequireInfo> item = DrinksModel.Instance.GetRoleState().Item2;
		GenericLayout<DrinksRoleRequireItem, IDrinksRequireInfo> layout = this.Layout;
		if (layout != null)
		{
			layout.RefreshByData(item, null, false);
		}
		this.EndLikeness = 0f;
		this.RefreshLikeTxt(0f, true);
		UUISprite sprite = base.GetSprite(6);
		if (sprite != null)
		{
			sprite.SetFillAmount(0f);
		}
		UUISprite sprite2 = base.GetSprite(7);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetFillAmount(0f);
	}

	// Token: 0x06006504 RID: 25860 RVA: 0x001411AC File Offset: 0x0013F3AC
	protected void RefreshLikeTxt(float value, bool isInit)
	{
		int num;
		if (value < 0f)
		{
			num = 0;
		}
		else if (value == 0f)
		{
			num = 1;
		}
		else
		{
			num = ((value >= this.MaxScore) ? 3 : 2);
		}
		if (num == this.CurLikenessState && !isInit)
		{
			return;
		}
		this.CurLikenessState = num;
		float alpha = (value < 0f) ? 1f : 0.5f;
		UUITexture texture = base.GetTexture(8);
		if (texture != null)
		{
			texture.SetAlpha(alpha);
		}
		float alpha2 = (value > 0f) ? 1f : 0.5f;
		UUITexture texture2 = base.GetTexture(9);
		if (texture2 != null)
		{
			texture2.SetAlpha(alpha2);
		}
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(value >= this.MaxScore);
		}
		string resourceId = (value >= this.MaxScore) ? "T_TiaoJiuIconLikeLevel03" : "T_TiaoJiuIconLikeLevel02";
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
		base.SetTextureByPath(resourcePath, base.GetTexture(9), null, null);
		string textStringId;
		if (value < 0f)
		{
			textStringId = "DRINKS_Drinklist_likeStr_Dislike";
		}
		else if (value == 0f)
		{
			textStringId = "DRINKS_Drinklist_likeStr_Justlike";
		}
		else if (value < this.MaxScore)
		{
			textStringId = "DRINKS_Drinklist_likeStr_like";
		}
		else
		{
			textStringId = "DRINKS_Drinklist_likeStr_Perferlike";
		}
		if (value >= this.MaxScore)
		{
			LevelSequencePlayer levelSequence = this.LevelSequence;
			if (levelSequence != null)
			{
				levelSequence.PlayLevelSequenceByName("Max", false, null, false);
			}
		}
		else
		{
			LevelSequencePlayer levelSequence2 = this.LevelSequence;
			if (levelSequence2 != null && levelSequence2.IsPlayingSequence("Max"))
			{
				LevelSequencePlayer levelSequence3 = this.LevelSequence;
				if (levelSequence3 != null)
				{
					levelSequence3.StopPlayingSequence(false, true);
				}
			}
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), textStringId, Array.Empty<object>());
	}

	// Token: 0x06006505 RID: 25861 RVA: 0x0014134C File Offset: 0x0013F54C
	[NullableContext(1)]
	private DrinksRoleRequireItem CreateRequestItem()
	{
		return new DrinksRoleRequireItem();
	}

	// Token: 0x06006506 RID: 25862 RVA: 0x00141354 File Offset: 0x0013F554
	private void UpdateProgress(float value)
	{
		this.RefreshLikeTxt(value, false);
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(value >= this.MaxScore);
		}
		if (value >= 0f)
		{
			UUISprite sprite = base.GetSprite(6);
			if (sprite != null)
			{
				sprite.SetFillAmount(0f);
			}
			UUISprite sprite2 = base.GetSprite(7);
			if (sprite2 != null)
			{
				sprite2.SetFillAmount(value / this.MaxScore);
			}
		}
		else
		{
			UUISprite sprite3 = base.GetSprite(6);
			if (sprite3 != null)
			{
				sprite3.SetFillAmount(-value / this.MaxScore);
			}
			UUISprite sprite4 = base.GetSprite(7);
			if (sprite4 != null)
			{
				sprite4.SetFillAmount(0f);
			}
		}
		this.CurLikeness = value;
	}

	// Token: 0x06006507 RID: 25863 RVA: 0x001413FC File Offset: 0x0013F5FC
	private void OnTweenerEnd()
	{
		this.CurLikeness = this.EndLikeness;
		if (this.Tweener != null)
		{
			this.Tweener = null;
		}
	}

	// Token: 0x04002DE5 RID: 11749
	[Nullable(2)]
	protected ULTweener Tweener;

	// Token: 0x04002DE6 RID: 11750
	[Nullable(2)]
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04002DE7 RID: 11751
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DrinksRoleRequireItem, IDrinksRequireInfo> Layout;

	// Token: 0x04002DE8 RID: 11752
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04002DE9 RID: 11753
	protected float CurLikeness;

	// Token: 0x04002DEA RID: 11754
	protected float EndLikeness;

	// Token: 0x04002DEB RID: 11755
	protected int CurLikenessState = 1;

	// Token: 0x04002DEC RID: 11756
	protected float MaxScore;

	// Token: 0x04002DED RID: 11757
	[Nullable(1)]
	protected UCurveFloat Curve;

	// Token: 0x020075B6 RID: 30134
	private static class ECurFavorState
	{
		// Token: 0x04026E77 RID: 159351
		public const int Dislike = 0;

		// Token: 0x04026E78 RID: 159352
		public const int Zero = 1;

		// Token: 0x04026E79 RID: 159353
		public const int Like = 2;

		// Token: 0x04026E7A RID: 159354
		public const int VeryLike = 3;
	}

	// Token: 0x020075B7 RID: 30135
	private static class EDefine
	{
		// Token: 0x04026E7B RID: 159355
		public const int TexHeadIcon = 0;

		// Token: 0x04026E7C RID: 159356
		public const int TxtTitle = 1;

		// Token: 0x04026E7D RID: 159357
		public const int Content = 2;

		// Token: 0x04026E7E RID: 159358
		public const int RequestItem = 3;

		// Token: 0x04026E7F RID: 159359
		public const int PanelLikeness = 4;

		// Token: 0x04026E80 RID: 159360
		public const int TxtLikeState = 5;

		// Token: 0x04026E81 RID: 159361
		public const int SpriteNotLike = 6;

		// Token: 0x04026E82 RID: 159362
		public const int SpriteLike = 7;

		// Token: 0x04026E83 RID: 159363
		public const int TexNotLike = 8;

		// Token: 0x04026E84 RID: 159364
		public const int TexLike = 9;

		// Token: 0x04026E85 RID: 159365
		public const int PanelFxLike = 10;
	}
}
