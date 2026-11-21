using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Utils;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CF1 RID: 19697
	[NullableContext(2)]
	[Nullable(0)]
	public class BuffItem : BuffItemBase
	{
		// Token: 0x06031574 RID: 202100 RVA: 0x00DC8E98 File Offset: 0x00DC7098
		[NullableContext(1)]
		public BuffItem(USceneComponent parentItem)
		{
			AActor buffItem = BattleUiControl.Instance.Pool.GetBuffItem(parentItem);
			base.CreateThenShowByActor(buffItem, null);
		}

		// Token: 0x06031575 RID: 202101 RVA: 0x00DC8EDC File Offset: 0x00DC70DC
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

		// Token: 0x06031576 RID: 202102 RVA: 0x00DC90FC File Offset: 0x00DC72FC
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

		// Token: 0x06031577 RID: 202103 RVA: 0x00DC9194 File Offset: 0x00DC7394
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

		// Token: 0x06031578 RID: 202104 RVA: 0x00DC9338 File Offset: 0x00DC7538
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

		// Token: 0x06031579 RID: 202105 RVA: 0x00DC939C File Offset: 0x00DC759C
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

		// Token: 0x0603157A RID: 202106 RVA: 0x00DC9504 File Offset: 0x00DC7704
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

		// Token: 0x0603157B RID: 202107 RVA: 0x00DC9559 File Offset: 0x00DC7759
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

		// Token: 0x0603157C RID: 202108 RVA: 0x00DC958F File Offset: 0x00DC778F
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

		// Token: 0x0603157D RID: 202109 RVA: 0x00DC95CC File Offset: 0x00DC77CC
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

		// Token: 0x0603157E RID: 202110 RVA: 0x00DC9643 File Offset: 0x00DC7843
		private void SetIconColor(string colorStr = null)
		{
			if (colorStr == this.IconColorStr)
			{
				return;
			}
			this.IconColorStr = colorStr;
			this.BuffTexture.SetColor((!string.IsNullOrEmpty(colorStr)) ? FColor.FromHex(colorStr) : ColorUtils.ColorWhile);
		}

		// Token: 0x0603157F RID: 202111 RVA: 0x00DC967C File Offset: 0x00DC787C
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

		// Token: 0x06031580 RID: 202112 RVA: 0x00DC96DA File Offset: 0x00DC78DA
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

		// Token: 0x06031581 RID: 202113 RVA: 0x00DC96FF File Offset: 0x00DC78FF
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

		// Token: 0x06031582 RID: 202114 RVA: 0x00DC9734 File Offset: 0x00DC7934
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

		// Token: 0x06031583 RID: 202115 RVA: 0x00DC9786 File Offset: 0x00DC7986
		public override void PlayAddBuffAnim()
		{
			this.PlayTweenAnim(BuffItem.EChildType.AnimAddBuff);
		}

		// Token: 0x06031584 RID: 202116 RVA: 0x00DC9790 File Offset: 0x00DC7990
		protected override void OnBeforeHide()
		{
			this.PlayFadeAnim(false);
		}

		// Token: 0x06031585 RID: 202117 RVA: 0x00DC979C File Offset: 0x00DC799C
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

		// Token: 0x06031586 RID: 202118 RVA: 0x00DC97F4 File Offset: 0x00DC79F4
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

		// Token: 0x06031587 RID: 202119 RVA: 0x00DC9858 File Offset: 0x00DC7A58
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

		// Token: 0x06031588 RID: 202120 RVA: 0x00DC98B4 File Offset: 0x00DC7AB4
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

		// Token: 0x0401A20D RID: 107021
		private const double CLOSE_ANIM_TIME = 200.0;

		// Token: 0x0401A20E RID: 107022
		private const float FADE_ANIM_PERCENT = 0.2f;

		// Token: 0x0401A20F RID: 107023
		[Nullable(1)]
		private const string BUFF = "1";

		// Token: 0x0401A210 RID: 107024
		[Nullable(1)]
		private const string DEBUFF = "2";

		// Token: 0x0401A211 RID: 107025
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401A212 RID: 107026
		private UUITexture BuffTexture;

		// Token: 0x0401A213 RID: 107027
		private UUITexture LargeBuffTexture;

		// Token: 0x0401A214 RID: 107028
		private UUIText NumText;

		// Token: 0x0401A215 RID: 107029
		private UUISprite BarSprite;

		// Token: 0x0401A216 RID: 107030
		private UUISprite BgSprite;

		// Token: 0x0401A217 RID: 107031
		private UUISprite BarRoundSprite;

		// Token: 0x0401A218 RID: 107032
		private UUISprite BgRoundSprite;

		// Token: 0x0401A219 RID: 107033
		private UUISprite CurBarSprite;

		// Token: 0x0401A21A RID: 107034
		private UUIItem ColorfulFrame;

		// Token: 0x0401A21B RID: 107035
		private bool AlwaysFullPercent;

		// Token: 0x0401A21C RID: 107036
		[Nullable(1)]
		private string IconPath = string.Empty;

		// Token: 0x0401A21D RID: 107037
		private int IconType;

		// Token: 0x0401A21E RID: 107038
		private bool MergeBuffItem;

		// Token: 0x0401A21F RID: 107039
		private int Num;

		// Token: 0x0401A220 RID: 107040
		private float Percent;

		// Token: 0x0401A221 RID: 107041
		private IActiveBuff Buff;

		// Token: 0x0401A222 RID: 107042
		private FColor? DefaultBarColor;

		// Token: 0x0401A223 RID: 107043
		private string IconColorStr;

		// Token: 0x0401A224 RID: 107044
		private double AnimCloseEndTime;

		// Token: 0x0401A225 RID: 107045
		private bool IsPlayingFadeAnim;

		// Token: 0x0200A98F RID: 43407
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403464D RID: 214605
			BuffCtrlItem,
			// Token: 0x0403464E RID: 214606
			BuffTexture,
			// Token: 0x0403464F RID: 214607
			BarSprite,
			// Token: 0x04034650 RID: 214608
			NumText,
			// Token: 0x04034651 RID: 214609
			DownSprite,
			// Token: 0x04034652 RID: 214610
			AnimStart,
			// Token: 0x04034653 RID: 214611
			AnimClose,
			// Token: 0x04034654 RID: 214612
			AnimFade,
			// Token: 0x04034655 RID: 214613
			UpSprite,
			// Token: 0x04034656 RID: 214614
			BgSprite,
			// Token: 0x04034657 RID: 214615
			LargeBuffTexture,
			// Token: 0x04034658 RID: 214616
			BgRoundSprite,
			// Token: 0x04034659 RID: 214617
			BarRoundSprite,
			// Token: 0x0403465A RID: 214618
			AnimAddBuff,
			// Token: 0x0403465B RID: 214619
			ColorfulFrame
		}
	}
}
