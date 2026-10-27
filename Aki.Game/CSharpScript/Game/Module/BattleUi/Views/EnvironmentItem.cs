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
	// Token: 0x02005D1D RID: 23837
	public class EnvironmentItem : UiPanelBase
	{
		// Token: 0x0603C6AA RID: 247466 RVA: 0x00E7C538 File Offset: 0x00E7A738
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

		// Token: 0x0603C6AB RID: 247467 RVA: 0x00E7C6EF File Offset: 0x00E7A8EF
		public void InitPropertyId(int propertyId)
		{
			this.PropertyConfig = BattleUiModel.Instance.FormationData.GetUiEnvironmentProperty(propertyId);
			this.WarningPercent = this.PropertyConfig.WarningPercent;
		}

		// Token: 0x0603C6AC RID: 247468 RVA: 0x00E7C718 File Offset: 0x00E7A918
		protected override UniTask OnCreateAsync()
		{
			EnvironmentItem.<OnCreateAsync>d__17 <OnCreateAsync>d__;
			<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnCreateAsync>d__.<>4__this = this;
			<OnCreateAsync>d__.<>1__state = -1;
			<OnCreateAsync>d__.<>t__builder.Start<EnvironmentItem.<OnCreateAsync>d__17>(ref <OnCreateAsync>d__);
			return <OnCreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C6AD RID: 247469 RVA: 0x00E7C75C File Offset: 0x00E7A95C
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

		// Token: 0x0603C6AE RID: 247470 RVA: 0x00E7C7B0 File Offset: 0x00E7A9B0
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

		// Token: 0x0603C6AF RID: 247471 RVA: 0x00E7C89C File Offset: 0x00E7AA9C
		private void SetSpriteData(EnvironmentItem.EChildType childIndex, EnvironmentItem.ESprite spriteIndex)
		{
			UUISprite sprite = base.GetSprite((int)childIndex);
			ULGUISpriteData_BaseObject valueOrDefault = this.SpriteDataList.GetValueOrDefault((int)spriteIndex);
			if (valueOrDefault != null && sprite != null)
			{
				sprite.SetSprite(valueOrDefault, false);
			}
		}

		// Token: 0x0603C6B0 RID: 247472 RVA: 0x00E7C8CC File Offset: 0x00E7AACC
		protected override void OnBeforeShow()
		{
			this.SetPercentInner(this.CurrentValue, this.MaxValue);
		}

		// Token: 0x0603C6B1 RID: 247473 RVA: 0x00E7C8E0 File Offset: 0x00E7AAE0
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

		// Token: 0x0603C6B2 RID: 247474 RVA: 0x00E7C904 File Offset: 0x00E7AB04
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

		// Token: 0x0603C6B3 RID: 247475 RVA: 0x00E7CAE0 File Offset: 0x00E7ACE0
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

		// Token: 0x0603C6B4 RID: 247476 RVA: 0x00E7CB7C File Offset: 0x00E7AD7C
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

		// Token: 0x0603C6B5 RID: 247477 RVA: 0x00E7CBE3 File Offset: 0x00E7ADE3
		private void UpdateSceneEffect()
		{
			if (this.EffectData != null)
			{
				ScreenEffectSystem.GetInstance().UpdateSEEnvironmentFactor(this.EffectData, this.Percent);
			}
		}

		// Token: 0x0603C6B6 RID: 247478 RVA: 0x00E7CC04 File Offset: 0x00E7AE04
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

		// Token: 0x0603C6B7 RID: 247479 RVA: 0x00E7CC57 File Offset: 0x00E7AE57
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.DestroyCurSceneEffect();
		}

		// Token: 0x0603C6B8 RID: 247480 RVA: 0x00E7CC68 File Offset: 0x00E7AE68
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

		// Token: 0x0603C6B9 RID: 247481 RVA: 0x00E7CCCC File Offset: 0x00E7AECC
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

		// Token: 0x0603C6BA RID: 247482 RVA: 0x00E7CD28 File Offset: 0x00E7AF28
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

		// Token: 0x0401F7B5 RID: 128949
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly List<ULGUISpriteData_BaseObject> SpriteDataList = new List<ULGUISpriteData_BaseObject>();

		// Token: 0x0401F7B6 RID: 128950
		[Nullable(1)]
		private readonly Dictionary<int, List<ULGUIPlayTweenComponent>> TweenAnimMap = new Dictionary<int, List<ULGUIPlayTweenComponent>>();

		// Token: 0x0401F7B7 RID: 128951
		[Nullable(2)]
		private SUiEnvironmentProperty PropertyConfig;

		// Token: 0x0401F7B8 RID: 128952
		private float Percent;

		// Token: 0x0401F7B9 RID: 128953
		private int Stage = -1;

		// Token: 0x0401F7BA RID: 128954
		private bool IsActive;

		// Token: 0x0401F7BB RID: 128955
		[Nullable(2)]
		private EffectScreenPlayData_C EffectData;

		// Token: 0x0401F7BC RID: 128956
		[Nullable(2)]
		private string EffectPath;

		// Token: 0x0401F7BD RID: 128957
		private int LoadingEffectId;

		// Token: 0x0401F7BE RID: 128958
		private int CurWarningAnim = -1;

		// Token: 0x0401F7BF RID: 128959
		private float WarningPercent = 0.8f;

		// Token: 0x0401F7C0 RID: 128960
		private float CurrentValue;

		// Token: 0x0401F7C1 RID: 128961
		private float MaxValue;

		// Token: 0x0200BF95 RID: 49045
		private enum EChildType
		{
			// Token: 0x04039CCE RID: 236750
			Bg,
			// Token: 0x04039CCF RID: 236751
			Frame,
			// Token: 0x04039CD0 RID: 236752
			OutLine,
			// Token: 0x04039CD1 RID: 236753
			Bar,
			// Token: 0x04039CD2 RID: 236754
			Icon,
			// Token: 0x04039CD3 RID: 236755
			IconFull,
			// Token: 0x04039CD4 RID: 236756
			AnimStart,
			// Token: 0x04039CD5 RID: 236757
			AnimWarningA,
			// Token: 0x04039CD6 RID: 236758
			AnimWarningB,
			// Token: 0x04039CD7 RID: 236759
			AnimBurst,
			// Token: 0x04039CD8 RID: 236760
			AnimClose,
			// Token: 0x04039CD9 RID: 236761
			AnimBurstSprite
		}

		// Token: 0x0200BF96 RID: 49046
		private enum ESprite
		{
			// Token: 0x04039CDB RID: 236763
			Frame,
			// Token: 0x04039CDC RID: 236764
			Icon,
			// Token: 0x04039CDD RID: 236765
			IconFull
		}
	}
}
