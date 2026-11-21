using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Fight.UI;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CFF RID: 19711
	public class EnvironmentItem : UiPanelBase
	{
		// Token: 0x06031603 RID: 202243 RVA: 0x00DCCBB8 File Offset: 0x00DCADB8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031604 RID: 202244 RVA: 0x00DCCD6F File Offset: 0x00DCAF6F
		public void InitPropertyId(int propertyId)
		{
			this.PropertyConfig = BattleUiModel.Instance.FormationData.GetUiEnvironmentProperty(propertyId);
			this.WarningPercent = this.PropertyConfig.WarningPercent;
		}

		// Token: 0x06031605 RID: 202245 RVA: 0x00DCCD98 File Offset: 0x00DCAF98
		protected override UniTask OnCreateAsync()
		{
			EnvironmentItem.<OnCreateAsync>d__17 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<EnvironmentItem.<OnCreateAsync>d__17>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031606 RID: 202246 RVA: 0x00DCCDDC File Offset: 0x00DCAFDC
		[NullableContext(1)]
		private UniTask LoadSprite(string path, int index)
		{
			EnvironmentItem.<LoadSprite>d__18 <LoadSprite>d__;
			<LoadSprite>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadSprite>d__.<>4__this = this;
			<LoadSprite>d__.path = path;
			<LoadSprite>d__.index = index;
			<LoadSprite>d__.<>1__state = -1;
			<LoadSprite>d__.<>t__builder.Start<EnvironmentItem.<LoadSprite>d__18>(ref <LoadSprite>d__);
			return <LoadSprite>d__.<>t__builder.Task;
		}

		// Token: 0x06031607 RID: 202247 RVA: 0x00DCCE30 File Offset: 0x00DCB030
		protected override void OnStart()
		{
			this.SetSpriteData(EnvironmentItem.EChildType.Frame, EnvironmentItem.ESprite.Frame);
			this.SetSpriteData(EnvironmentItem.EChildType.Icon, EnvironmentItem.ESprite.Icon);
			this.SetSpriteData(EnvironmentItem.EChildType.IconFull, EnvironmentItem.ESprite.IconFull);
			this.SpriteDataList.Clear();
			SUiEnvironmentProperty propertyConfig = this.PropertyConfig;
			string text = (propertyConfig != null) ? propertyConfig.SceneEffect.ToAssetPathName() : null;
			if (this.EffectPath != text)
			{
				this.DestroyCurSceneEffect();
				this.EffectPath = text;
				this.LoadSceneEffect();
			}
			UUISprite sprite = base.GetSprite(2);
			UUISprite sprite2 = base.GetSprite(11);
			if (this.PropertyConfig != null)
			{
				TArray<FColor> colors = this.PropertyConfig.Colors;
				if (colors.Num() >= 2)
				{
					if (sprite != null)
					{
						sprite.SetColor(colors.Get(0));
					}
					if (sprite2 != null)
					{
						sprite2.SetColor(colors.Get(1));
					}
				}
			}
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			this.InitTweenAnim(EnvironmentItem.EChildType.AnimStart);
			this.InitTweenAnim(EnvironmentItem.EChildType.AnimWarningA);
			this.InitTweenAnim(EnvironmentItem.EChildType.AnimWarningB);
			this.InitTweenAnim(EnvironmentItem.EChildType.AnimBurst);
			this.InitTweenAnim(EnvironmentItem.EChildType.AnimClose);
		}

		// Token: 0x06031608 RID: 202248 RVA: 0x00DCCF1C File Offset: 0x00DCB11C
		private void SetSpriteData(EnvironmentItem.EChildType childIndex, EnvironmentItem.ESprite spriteIndex)
		{
			UUISprite sprite = base.GetSprite((int)childIndex);
			ULGUISpriteData_BaseObject valueOrDefault = this.SpriteDataList.GetValueOrDefault((int)spriteIndex);
			if (valueOrDefault != null && sprite != null)
			{
				sprite.SetSprite(valueOrDefault, false);
			}
		}

		// Token: 0x06031609 RID: 202249 RVA: 0x00DCCF4C File Offset: 0x00DCB14C
		protected override void OnBeforeShow()
		{
			this.SetPercentInner(this.CurrentValue, this.MaxValue);
		}

		// Token: 0x0603160A RID: 202250 RVA: 0x00DCCF60 File Offset: 0x00DCB160
		public void SetPercent(float currentValue, float maxValue)
		{
			this.CurrentValue = currentValue;
			this.MaxValue = maxValue;
			if (!base.IsShowOrShowing)
			{
				return;
			}
			this.SetPercentInner(currentValue, maxValue);
		}

		// Token: 0x0603160B RID: 202251 RVA: 0x00DCCF84 File Offset: 0x00DCB184
		private void SetPercentInner(float currentValue, float maxValue)
		{
			if (currentValue <= 0f || maxValue <= 0f)
			{
				this.Percent = 0f;
				this.TrySetActive(false);
				return;
			}
			if (this.PropertyConfig == null)
			{
				return;
			}
			float num = Math.Min(1f, Math.Max(0f, currentValue / maxValue));
			if (this.Percent == num)
			{
				return;
			}
			this.Percent = num;
			this.TrySetActive(true);
			int num2 = -1;
			int num3;
			if (num < this.WarningPercent)
			{
				num3 = 0;
			}
			else if (num < 1f)
			{
				num3 = 1;
				num2 = 7;
			}
			else
			{
				num3 = 2;
				num2 = 8;
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetFillAmount(num);
			}
			if (this.Stage != num3)
			{
				this.Stage = num3;
				TArray<FColor> bgColors = this.PropertyConfig.BgColors;
				if (bgColors.Num() > num3)
				{
					UUISprite sprite2 = base.GetSprite(0);
					if (sprite2 != null)
					{
						sprite2.SetColor(bgColors.Get(num3));
					}
				}
				TArray<FColor> barColors = this.PropertyConfig.BarColors;
				if (barColors.Num() > num3 && sprite != null)
				{
					sprite.SetColor(barColors.Get(num3));
				}
				UUISprite sprite3 = base.GetSprite(4);
				UUISprite sprite4 = base.GetSprite(5);
				if (num3 == 2)
				{
					if (sprite3 != null)
					{
						sprite3.SetUIActive(false);
					}
					if (sprite4 != null)
					{
						sprite4.SetUIActive(true);
					}
				}
				else
				{
					if (sprite3 != null)
					{
						sprite3.SetUIActive(true);
					}
					if (sprite4 != null)
					{
						sprite4.SetUIActive(false);
					}
				}
			}
			if (this.CurWarningAnim != num2)
			{
				if (this.CurWarningAnim >= 0)
				{
					this.StopTweenAnim((EnvironmentItem.EChildType)this.CurWarningAnim);
				}
				this.CurWarningAnim = num2;
				if (num2 >= 0)
				{
					this.PlayTweenAnim((EnvironmentItem.EChildType)this.CurWarningAnim);
					UUISprite sprite5 = base.GetSprite(2);
					if (sprite5 != null)
					{
						sprite5.SetAlpha(0f);
					}
					UUISprite sprite6 = base.GetSprite(2);
					if (sprite6 != null)
					{
						sprite6.SetUIActive(true);
					}
				}
				else
				{
					UUISprite sprite7 = base.GetSprite(2);
					if (sprite7 != null)
					{
						sprite7.SetUIActive(false);
					}
				}
				if (num3 == 2)
				{
					this.PlayTweenAnim(EnvironmentItem.EChildType.AnimBurst);
				}
			}
			this.UpdateSceneEffect();
		}

		// Token: 0x0603160C RID: 202252 RVA: 0x00DCD160 File Offset: 0x00DCB360
		private void TrySetActive(bool visibility)
		{
			if (visibility == this.IsActive)
			{
				return;
			}
			this.IsActive = visibility;
			if (this.EffectData != null)
			{
				if (this.IsActive)
				{
					ScreenEffectSystem.GetInstance().PlayScreenEffect(this.EffectData);
					this.StopTweenAnim(EnvironmentItem.EChildType.AnimClose);
					this.PlayTweenAnim(EnvironmentItem.EChildType.AnimStart);
					return;
				}
				ScreenEffectSystem.GetInstance().EndScreenEffect(this.EffectData);
				this.StopTweenAnim(EnvironmentItem.EChildType.AnimStart);
				if (this.CurWarningAnim >= 0)
				{
					this.StopTweenAnim((EnvironmentItem.EChildType)this.CurWarningAnim);
					UUISprite sprite = base.GetSprite(2);
					if (sprite != null)
					{
						sprite.SetUIActive(false);
					}
					this.CurWarningAnim = -1;
				}
				this.PlayTweenAnim(EnvironmentItem.EChildType.AnimClose);
			}
		}

		// Token: 0x0603160D RID: 202253 RVA: 0x00DCD1FC File Offset: 0x00DCB3FC
		private void LoadSceneEffect()
		{
			if (string.IsNullOrEmpty(this.EffectPath))
			{
				return;
			}
			bool isLoading = true;
			this.LoadingEffectId = ResourceSystem.Instance.LoadAsync<EffectScreenPlayData_C>(this.EffectPath, delegate([Nullable(2)] EffectScreenPlayData_C res, string _)
			{
				this.LoadingEffectId = 0;
				isLoading = false;
				this.EffectData = res;
				if (this.IsActive)
				{
					ScreenEffectSystem.GetInstance().PlayScreenEffect(this.EffectData);
					this.UpdateSceneEffect();
				}
			}, 102, "js_undefined");
			if (!isLoading)
			{
				this.LoadingEffectId = 0;
			}
		}

		// Token: 0x0603160E RID: 202254 RVA: 0x00DCD263 File Offset: 0x00DCB463
		private void UpdateSceneEffect()
		{
			if (this.EffectData != null)
			{
				ScreenEffectSystem.GetInstance().UpdateSEEnvironmentFactor(this.EffectData, this.Percent);
			}
		}

		// Token: 0x0603160F RID: 202255 RVA: 0x00DCD284 File Offset: 0x00DCB484
		private void DestroyCurSceneEffect()
		{
			if (this.LoadingEffectId > 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadingEffectId);
				this.LoadingEffectId = 0;
			}
			if (this.EffectData != null)
			{
				ScreenEffectSystem.GetInstance().EndScreenEffect(this.EffectData);
				this.EffectData = null;
			}
			this.EffectPath = null;
		}

		// Token: 0x06031610 RID: 202256 RVA: 0x00DCD2D7 File Offset: 0x00DCB4D7
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.DestroyCurSceneEffect();
		}

		// Token: 0x06031611 RID: 202257 RVA: 0x00DCD2E8 File Offset: 0x00DCB4E8
		private void InitTweenAnim(EnvironmentItem.EChildType componentType)
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

		// Token: 0x06031612 RID: 202258 RVA: 0x00DCD34C File Offset: 0x00DCB54C
		private void PlayTweenAnim(EnvironmentItem.EChildType componentType)
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

		// Token: 0x06031613 RID: 202259 RVA: 0x00DCD3A8 File Offset: 0x00DCB5A8
		private void StopTweenAnim(EnvironmentItem.EChildType componentType)
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

		// Token: 0x0401A26E RID: 107118
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<ULGUISpriteData_BaseObject> SpriteDataList = new List<ULGUISpriteData_BaseObject>();

		// Token: 0x0401A26F RID: 107119
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401A270 RID: 107120
		[Nullable(2)]
		private SUiEnvironmentProperty PropertyConfig;

		// Token: 0x0401A271 RID: 107121
		private float Percent;

		// Token: 0x0401A272 RID: 107122
		private int Stage = -1;

		// Token: 0x0401A273 RID: 107123
		private bool IsActive;

		// Token: 0x0401A274 RID: 107124
		[Nullable(2)]
		private EffectScreenPlayData_C EffectData;

		// Token: 0x0401A275 RID: 107125
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x0401A276 RID: 107126
		private int LoadingEffectId;

		// Token: 0x0401A277 RID: 107127
		private int CurWarningAnim = -1;

		// Token: 0x0401A278 RID: 107128
		private float WarningPercent = 0.8f;

		// Token: 0x0401A279 RID: 107129
		private float CurrentValue;

		// Token: 0x0401A27A RID: 107130
		private float MaxValue;

		// Token: 0x0200A99B RID: 43419
		private enum EChildType
		{
			// Token: 0x04034690 RID: 214672
			Bg,
			// Token: 0x04034691 RID: 214673
			Frame,
			// Token: 0x04034692 RID: 214674
			OutLine,
			// Token: 0x04034693 RID: 214675
			Bar,
			// Token: 0x04034694 RID: 214676
			Icon,
			// Token: 0x04034695 RID: 214677
			IconFull,
			// Token: 0x04034696 RID: 214678
			AnimStart,
			// Token: 0x04034697 RID: 214679
			AnimWarningA,
			// Token: 0x04034698 RID: 214680
			AnimWarningB,
			// Token: 0x04034699 RID: 214681
			AnimBurst,
			// Token: 0x0403469A RID: 214682
			AnimClose,
			// Token: 0x0403469B RID: 214683
			AnimBurstSprite
		}

		// Token: 0x0200A99C RID: 43420
		private enum ESprite
		{
			// Token: 0x0403469D RID: 214685
			Frame,
			// Token: 0x0403469E RID: 214686
			Icon,
			// Token: 0x0403469F RID: 214687
			IconFull
		}
	}
}
