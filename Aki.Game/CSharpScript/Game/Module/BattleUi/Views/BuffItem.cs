using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D0F RID: 23823
	[NullableContext(2)]
	[Nullable(0)]
	public class BuffItem : BuffItemBase
	{
		// Token: 0x0603C61B RID: 247323 RVA: 0x00E78818 File Offset: 0x00E76A18
		[NullableContext(1)]
		public BuffItem(USceneComponent parentItem)
		{
			AActor buffItem = BattleUiControl.Instance.Pool.GetBuffItem(parentItem);
			base.CreateThenShowByActor(buffItem, null);
		}

		// Token: 0x0603C61C RID: 247324 RVA: 0x00E7885C File Offset: 0x00E76A5C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C61D RID: 247325 RVA: 0x00E78A7C File Offset: 0x00E76C7C
		protected override void OnStart()
		{
			this.BuffTexture = base.GetTexture(1);
			this.LargeBuffTexture = base.GetTexture(10);
			this.NumText = base.GetText(3);
			this.BarSprite = base.GetSprite(2);
			this.BgSprite = base.GetSprite(9);
			this.BarRoundSprite = base.GetSprite(12);
			this.BgRoundSprite = base.GetSprite(11);
			this.ColorfulFrame = base.GetItem(14);
			this.InitTweenAnim(BuffItem.EChildType.AnimStart);
			this.InitTweenAnim(BuffItem.EChildType.AnimClose);
			this.InitTweenAnim(BuffItem.EChildType.AnimFade);
			this.InitTweenAnim(BuffItem.EChildType.AnimAddBuff);
		}

		// Token: 0x0603C61E RID: 247326 RVA: 0x00E78B14 File Offset: 0x00E76D14
		public override void Activate(GameplayCue buffCueConfig, IActiveBuff buff, bool playAnim = false, int buffNum = 0)
		{
			this.Buff = buff;
			int parametersLength = buffCueConfig.ParametersLength;
			int iconType = 0;
			if (parametersLength > 3 && buffCueConfig.Parameters(3).Length != 0)
			{
				iconType = int.Parse(buffCueConfig.Parameters(3));
			}
			this.SetIcon(buffCueConfig.Path, iconType, buff == null);
			if (buff != null)
			{
				this.SetNum(buff.StackCount);
				if (buff.Duration <= 0f || this.AlwaysFullPercent)
				{
					this.SetPercent(1f);
				}
				else
				{
					this.SetPercent(buff.GetRemainDuration() / buff.Duration);
				}
			}
			else if (buffNum > 1)
			{
				this.SetNum(buffNum);
				this.SetPercent(1f);
			}
			else
			{
				this.SetNum(1);
				this.SetPercent(1f);
			}
			string a = null;
			if (parametersLength > 0)
			{
				a = buffCueConfig.Parameters(0);
			}
			UUISprite sprite = base.GetSprite(8);
			if (sprite != null)
			{
				sprite.SetUIActive(a == "1");
			}
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(a == "2");
			}
			if (parametersLength > 1 && buffCueConfig.Parameters(1).Length != 0)
			{
				this.SetBarColor(buffCueConfig.Parameters(1));
			}
			else
			{
				this.SetBarColor(null);
			}
			if (parametersLength > 2 && buffCueConfig.Parameters(2).Length != 0)
			{
				this.SetIconColor(buffCueConfig.Parameters(2));
			}
			else
			{
				this.SetIconColor(null);
			}
			base.SetUiActive(true);
			this.StopTweenAnim(BuffItem.EChildType.AnimClose);
			if (playAnim)
			{
				this.PlayTweenAnim(BuffItem.EChildType.AnimStart);
				return;
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAlpha(1f);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetUIItemScale(global::Vector.OneVector);
		}

		// Token: 0x0603C61F RID: 247327 RVA: 0x00E78CB8 File Offset: 0x00E76EB8
		public void ActivateExceedTip()
		{
			this.BuffTexture.SetUIActive(false);
			this.LargeBuffTexture.SetUIActive(false);
			this.NumText.SetText(string.Empty, true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_IconpropertyEllipses_UI");
			this.SetIcon(resourcePath, -1, false);
			UUISprite curBarSprite = this.CurBarSprite;
			if (curBarSprite == null)
			{
				return;
			}
			curBarSprite.SetFillAmount(0f);
		}

		// Token: 0x0603C620 RID: 247328 RVA: 0x00E78D1C File Offset: 0x00E76F1C
		[NullableContext(1)]
		private void SetIcon(string iconPath, int iconType, bool bMergeBuffItem)
		{
			if (this.IconPath == iconPath && this.IconType == iconType && this.MergeBuffItem == bMergeBuffItem)
			{
				return;
			}
			this.IconPath = iconPath;
			this.IconType = iconType;
			this.MergeBuffItem = bMergeBuffItem;
			bool flag = iconType == 3 || iconType == 4;
			this.AlwaysFullPercent = (iconType == 2 || iconType == 4);
			this.ColorfulFrame.SetUIActive(flag);
			this.BuffTexture.SetUIActive(false);
			this.LargeBuffTexture.SetUIActive(false);
			if (iconType == 1)
			{
				this.BgSprite.SetUIActive(false);
				this.BarSprite.SetUIActive(false);
				this.BgRoundSprite.SetUIActive(false);
				this.BarRoundSprite.SetUIActive(false);
				base.SetTextureByPath(iconPath, this.LargeBuffTexture, null, delegate(bool result)
				{
					if (result)
					{
						UUITexture largeBuffTexture = this.LargeBuffTexture;
						if (largeBuffTexture == null)
						{
							return;
						}
						largeBuffTexture.SetUIActive(true);
					}
				});
				return;
			}
			bool flag2 = flag;
			this.BgSprite.SetUIActive(!bMergeBuffItem && !flag2);
			this.BarSprite.SetUIActive(!bMergeBuffItem);
			this.BgRoundSprite.SetUIActive(bMergeBuffItem && !flag2);
			this.BarRoundSprite.SetUIActive(bMergeBuffItem);
			base.SetTextureByPath(iconPath, this.BuffTexture, null, delegate(bool result)
			{
				if (result)
				{
					UUITexture buffTexture = this.BuffTexture;
					if (buffTexture == null)
					{
						return;
					}
					buffTexture.SetUIActive(true);
				}
			});
			this.CurBarSprite = (bMergeBuffItem ? this.BarRoundSprite : this.BarSprite);
			this.Percent = -1f;
		}

		// Token: 0x0603C621 RID: 247329 RVA: 0x00E78E84 File Offset: 0x00E77084
		public override void SetNum(int num)
		{
			if (num == this.Num)
			{
				return;
			}
			if (num > this.Num && this.Num > 0)
			{
				this.PlayTweenAnim(BuffItem.EChildType.AnimStart);
			}
			this.Num = num;
			this.NumText.SetText((num <= 1) ? string.Empty : num.ToString(), true);
		}

		// Token: 0x0603C622 RID: 247330 RVA: 0x00E78ED9 File Offset: 0x00E770D9
		private void SetPercent(float percent)
		{
			if (percent == this.Percent)
			{
				return;
			}
			this.Percent = percent;
			UUISprite curBarSprite = this.CurBarSprite;
			if (curBarSprite != null)
			{
				curBarSprite.SetFillAmount(percent);
			}
			this.PlayFadeAnim(percent <= 0.2f);
		}

		// Token: 0x0603C623 RID: 247331 RVA: 0x00E78F0F File Offset: 0x00E7710F
		private void PlayFadeAnim(bool bPlay)
		{
			if (this.IsPlayingFadeAnim != bPlay)
			{
				this.IsPlayingFadeAnim = bPlay;
				if (bPlay)
				{
					this.PlayTweenAnim(BuffItem.EChildType.AnimFade);
					return;
				}
				this.StopTweenAnim(BuffItem.EChildType.AnimFade);
				UUIItem item = base.GetItem(0);
				if (item == null)
				{
					return;
				}
				item.SetAlpha(1f);
			}
		}

		// Token: 0x0603C624 RID: 247332 RVA: 0x00E78F4C File Offset: 0x00E7714C
		private void SetBarColor(string colorStr = null)
		{
			if (!string.IsNullOrEmpty(colorStr))
			{
				UUISprite curBarSprite = this.CurBarSprite;
				if (curBarSprite == null)
				{
					return;
				}
				curBarSprite.SetColor(FColor.FromHex(colorStr));
				return;
			}
			else
			{
				FColor value = this.DefaultBarColor.GetValueOrDefault();
				if (this.DefaultBarColor == null)
				{
					value = FColor.FromHex("FFFFFF7F");
					this.DefaultBarColor = new FColor?(value);
				}
				UUISprite curBarSprite2 = this.CurBarSprite;
				if (curBarSprite2 == null)
				{
					return;
				}
				curBarSprite2.SetColor(this.DefaultBarColor.Value);
				return;
			}
		}

		// Token: 0x0603C625 RID: 247333 RVA: 0x00E78FC3 File Offset: 0x00E771C3
		private void SetIconColor(string colorStr = null)
		{
			if (colorStr == this.IconColorStr)
			{
				return;
			}
			this.IconColorStr = colorStr;
			this.BuffTexture.SetColor((!string.IsNullOrEmpty(colorStr)) ? FColor.FromHex(colorStr) : ColorUtils.ColorWhile);
		}

		// Token: 0x0603C626 RID: 247334 RVA: 0x00E78FFC File Offset: 0x00E771FC
		public override void Tick(float delta)
		{
			if (this.Buff == null)
			{
				return;
			}
			if (this.Buff.Duration > 0f && !this.AlwaysFullPercent)
			{
				this.SetPercent(this.Buff.GetRemainDuration() / this.Buff.Duration);
			}
			this.SetNum(this.Buff.StackCount);
		}

		// Token: 0x0603C627 RID: 247335 RVA: 0x00E7905A File Offset: 0x00E7725A
		public override bool TickHiding(float delta)
		{
			if (this.AnimCloseEndTime > Time.Instance.Now)
			{
				return true;
			}
			this.StopTweenAnim(BuffItem.EChildType.AnimClose);
			base.SetUiActive(false);
			return false;
		}

		// Token: 0x0603C628 RID: 247336 RVA: 0x00E7907F File Offset: 0x00E7727F
		public override void Deactivate()
		{
			this.StopTweenAnim(BuffItem.EChildType.AnimStart);
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIItemScale(global::Vector.OneVector);
			}
			this.StopTweenAnim(BuffItem.EChildType.AnimClose);
			this.PlayFadeAnim(false);
			base.SetUiActive(false);
		}

		// Token: 0x0603C629 RID: 247337 RVA: 0x00E790B4 File Offset: 0x00E772B4
		public override void DeactivateWithCloseAnim()
		{
			this.StopTweenAnim(BuffItem.EChildType.AnimStart);
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIItemScale(global::Vector.OneVector);
			}
			this.PlayFadeAnim(false);
			this.PlayTweenAnim(BuffItem.EChildType.AnimClose);
			this.AnimCloseEndTime = Time.Instance.Now + 200.0;
		}

		// Token: 0x0603C62A RID: 247338 RVA: 0x00E79106 File Offset: 0x00E77306
		public override void PlayAddBuffAnim()
		{
			this.PlayTweenAnim(BuffItem.EChildType.AnimAddBuff);
		}

		// Token: 0x0603C62B RID: 247339 RVA: 0x00E79110 File Offset: 0x00E77310
		protected override void OnBeforeHide()
		{
			this.PlayFadeAnim(false);
		}

		// Token: 0x0603C62C RID: 247340 RVA: 0x00E7911C File Offset: 0x00E7731C
		protected override bool DestroyOverride()
		{
			if (this.RootActor != null)
			{
				if (!string.IsNullOrEmpty(this.IconColorStr) && this.BuffTexture != null)
				{
					this.BuffTexture.SetColor(ColorUtils.ColorWhile);
					this.IconColorStr = null;
				}
				BattleUiControl.Instance.Pool.RecycleBuffItem(this.RootActor);
			}
			return true;
		}

		// Token: 0x0603C62D RID: 247341 RVA: 0x00E79174 File Offset: 0x00E77374
		private void InitTweenAnim(BuffItem.EChildType componentType)
		{
			List<ULGUIPlayTweenComponent> list = new List<ULGUIPlayTweenComponent>();
			TArray<UActorComponent> tarray = base.GetItem((int)componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				list.Add((ULGUIPlayTweenComponent)tarray.Get(i));
			}
			this.TweenAnimMap[(int)componentType] = list;
		}

		// Token: 0x0603C62E RID: 247342 RVA: 0x00E791D8 File Offset: 0x00E773D8
		private void PlayTweenAnim(BuffItem.EChildType componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue((int)componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0603C62F RID: 247343 RVA: 0x00E79234 File Offset: 0x00E77434
		private void StopTweenAnim(BuffItem.EChildType componentType)
		{
			List<ULGUIPlayTweenComponent> list;
			if (this.TweenAnimMap.TryGetValue((int)componentType, out list))
			{
				foreach (ULGUIPlayTweenComponent ulguiplayTweenComponent in list)
				{
					ulguiplayTweenComponent.Stop();
				}
			}
		}

		// Token: 0x0401F754 RID: 128852
		private const double CLOSE_ANIM_TIME = 200.0;

		// Token: 0x0401F755 RID: 128853
		private const float FADE_ANIM_PERCENT = 0.2f;

		// Token: 0x0401F756 RID: 128854
		[Nullable(1)]
		private const string BUFF = "1";

		// Token: 0x0401F757 RID: 128855
		[Nullable(1)]
		private const string DEBUFF = "2";

		// Token: 0x0401F758 RID: 128856
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401F759 RID: 128857
		private UUITexture BuffTexture;

		// Token: 0x0401F75A RID: 128858
		private UUITexture LargeBuffTexture;

		// Token: 0x0401F75B RID: 128859
		private UUIText NumText;

		// Token: 0x0401F75C RID: 128860
		private UUISprite BarSprite;

		// Token: 0x0401F75D RID: 128861
		private UUISprite BgSprite;

		// Token: 0x0401F75E RID: 128862
		private UUISprite BarRoundSprite;

		// Token: 0x0401F75F RID: 128863
		private UUISprite BgRoundSprite;

		// Token: 0x0401F760 RID: 128864
		private UUISprite CurBarSprite;

		// Token: 0x0401F761 RID: 128865
		private UUIItem ColorfulFrame;

		// Token: 0x0401F762 RID: 128866
		private bool AlwaysFullPercent;

		// Token: 0x0401F763 RID: 128867
		[Nullable(1)]
		private string IconPath = string.Empty;

		// Token: 0x0401F764 RID: 128868
		private int IconType;

		// Token: 0x0401F765 RID: 128869
		private bool MergeBuffItem;

		// Token: 0x0401F766 RID: 128870
		private int Num;

		// Token: 0x0401F767 RID: 128871
		private float Percent;

		// Token: 0x0401F768 RID: 128872
		private IActiveBuff Buff;

		// Token: 0x0401F769 RID: 128873
		private FColor? DefaultBarColor;

		// Token: 0x0401F76A RID: 128874
		private string IconColorStr;

		// Token: 0x0401F76B RID: 128875
		private double AnimCloseEndTime;

		// Token: 0x0401F76C RID: 128876
		private bool IsPlayingFadeAnim;

		// Token: 0x0200BF89 RID: 49033
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04039C8B RID: 236683
			BuffCtrlItem,
			// Token: 0x04039C8C RID: 236684
			BuffTexture,
			// Token: 0x04039C8D RID: 236685
			BarSprite,
			// Token: 0x04039C8E RID: 236686
			NumText,
			// Token: 0x04039C8F RID: 236687
			DownSprite,
			// Token: 0x04039C90 RID: 236688
			AnimStart,
			// Token: 0x04039C91 RID: 236689
			AnimClose,
			// Token: 0x04039C92 RID: 236690
			AnimFade,
			// Token: 0x04039C93 RID: 236691
			UpSprite,
			// Token: 0x04039C94 RID: 236692
			BgSprite,
			// Token: 0x04039C95 RID: 236693
			LargeBuffTexture,
			// Token: 0x04039C96 RID: 236694
			BgRoundSprite,
			// Token: 0x04039C97 RID: 236695
			BarRoundSprite,
			// Token: 0x04039C98 RID: 236696
			AnimAddBuff,
			// Token: 0x04039C99 RID: 236697
			ColorfulFrame
		}
	}
}
