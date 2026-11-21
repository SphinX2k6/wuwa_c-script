using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000422 RID: 1058
public class DrinksRoleStateItem : UiPanelBase
{
	// Token: 0x06003896 RID: 14486 RVA: 0x001496D0 File Offset: 0x001478D0
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

	// Token: 0x06003897 RID: 14487 RVA: 0x001497DC File Offset: 0x001479DC
	protected override UniTask OnBeforeStartAsync()
	{
		DrinksRoleStateItem.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DrinksRoleStateItem.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06003898 RID: 14488 RVA: 0x00149820 File Offset: 0x00147A20
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

	// Token: 0x06003899 RID: 14489 RVA: 0x001498E4 File Offset: 0x00147AE4
	protected override void OnBeforeDestroy()
	{
		if (this.Delegate != null)
		{
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<float>(this.UpdateProgress));
			this.Delegate = null;
		}
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x00149908 File Offset: 0x00147B08
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

	// Token: 0x0600389B RID: 14491 RVA: 0x001499D0 File Offset: 0x00147BD0
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

	// Token: 0x0600389C RID: 14492 RVA: 0x00149A48 File Offset: 0x00147C48
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

	// Token: 0x0600389D RID: 14493 RVA: 0x00149BE8 File Offset: 0x00147DE8
	[NullableContext(1)]
	private DrinksRoleRequireItem CreateRequestItem()
	{
		return new DrinksRoleRequireItem();
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x00149BF0 File Offset: 0x00147DF0
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

	// Token: 0x0600389F RID: 14495 RVA: 0x00149C98 File Offset: 0x00147E98
	private void OnTweenerEnd()
	{
		this.CurLikeness = this.EndLikeness;
		if (this.Tweener != null)
		{
			this.Tweener = null;
		}
	}

	// Token: 0x04002E7E RID: 11902
	[Nullable(2)]
	protected ULTweener Tweener;

	// Token: 0x04002E7F RID: 11903
	[Nullable(2)]
	protected FLTweenFloatSetterDynamic Delegate;

	// Token: 0x04002E80 RID: 11904
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected GenericLayout<DrinksRoleRequireItem, IDrinksRequireInfo> Layout;

	// Token: 0x04002E81 RID: 11905
	[Nullable(2)]
	protected LevelSequencePlayer LevelSequence;

	// Token: 0x04002E82 RID: 11906
	protected float CurLikeness;

	// Token: 0x04002E83 RID: 11907
	protected float EndLikeness;

	// Token: 0x04002E84 RID: 11908
	protected int CurLikenessState = 1;

	// Token: 0x04002E85 RID: 11909
	protected float MaxScore;

	// Token: 0x04002E86 RID: 11910
	[Nullable(1)]
	protected UCurveFloat Curve;

	// Token: 0x0200674A RID: 26442
	private static class ECurFavorState
	{
		// Token: 0x040221C2 RID: 139714
		public const int Dislike = 0;

		// Token: 0x040221C3 RID: 139715
		public const int Zero = 1;

		// Token: 0x040221C4 RID: 139716
		public const int Like = 2;

		// Token: 0x040221C5 RID: 139717
		public const int VeryLike = 3;
	}

	// Token: 0x0200674B RID: 26443
	private static class EDefine
	{
		// Token: 0x040221C6 RID: 139718
		public const int TexHeadIcon = 0;

		// Token: 0x040221C7 RID: 139719
		public const int TxtTitle = 1;

		// Token: 0x040221C8 RID: 139720
		public const int Content = 2;

		// Token: 0x040221C9 RID: 139721
		public const int RequestItem = 3;

		// Token: 0x040221CA RID: 139722
		public const int PanelLikeness = 4;

		// Token: 0x040221CB RID: 139723
		public const int TxtLikeState = 5;

		// Token: 0x040221CC RID: 139724
		public const int SpriteNotLike = 6;

		// Token: 0x040221CD RID: 139725
		public const int SpriteLike = 7;

		// Token: 0x040221CE RID: 139726
		public const int TexNotLike = 8;

		// Token: 0x040221CF RID: 139727
		public const int TexLike = 9;

		// Token: 0x040221D0 RID: 139728
		public const int PanelFxLike = 10;
	}
}
