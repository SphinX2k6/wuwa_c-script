using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E18 RID: 24088
	public class SpecialEnergyBarZheZhiEffectItem : UiPanelBase
	{
		// Token: 0x0603D419 RID: 250905 RVA: 0x00EC31A8 File Offset: 0x00EC13A8
		[NullableContext(1)]
		public UniTask InitAsync(UUIItem parentItem)
		{
			SpecialEnergyBarZheZhiEffectItem.<InitAsync>d__3 <InitAsync>d__;
			<InitAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitAsync>d__.<>4__this = this;
			<InitAsync>d__.parentItem = parentItem;
			<InitAsync>d__.<>1__state = -1;
			<InitAsync>d__.<>t__builder.Start<SpecialEnergyBarZheZhiEffectItem.<InitAsync>d__3>(ref <InitAsync>d__);
			return <InitAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603D41A RID: 250906 RVA: 0x00EC31F4 File Offset: 0x00EC13F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603D41B RID: 250907 RVA: 0x00EC3302 File Offset: 0x00EC1502
		protected override void OnStart()
		{
			base.OnStart();
			base.GetUiNiagara(3).SetUIActive(false);
			base.GetUiNiagara(4).SetUIActive(false);
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
		}

		// Token: 0x0603D41C RID: 250908 RVA: 0x00EC3332 File Offset: 0x00EC1532
		[NullableContext(1)]
		public void SetNiagaraParam(string varName, float value)
		{
			base.GetUiNiagara(2).SetNiagaraVarFloat(varName, value);
		}

		// Token: 0x0603D41D RID: 250909 RVA: 0x00EC3344 File Offset: 0x00EC1544
		public void SetVisible(bool value)
		{
			if (this.Visible == value)
			{
				return;
			}
			this.Visible = value;
			if (value)
			{
				this.StopTweenAnim(6);
				base.GetUiNiagara(4).SetUIActive(false);
				this.PlayTweenAnim(5);
				return;
			}
			this.StopTweenAnim(5);
			base.GetUiNiagara(3).SetUIActive(false);
			this.PlayTweenAnim(6);
		}

		// Token: 0x0603D41E RID: 250910 RVA: 0x00EC339C File Offset: 0x00EC159C
		protected override void OnBeforeHide()
		{
			this.TweenAnimMap = null;
		}

		// Token: 0x0603D41F RID: 250911 RVA: 0x00EC33A8 File Offset: 0x00EC15A8
		private void InitTweenAnim(int componentType)
		{
			TArray<UActorComponent> tarray = base.GetItem(componentType).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			ULGUIPlayTweenComponent[] array = new ULGUIPlayTweenComponent[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (ULGUIPlayTweenComponent)tarray.Get(i);
			}
			if (this.TweenAnimMap == null)
			{
				this.TweenAnimMap = new Dictionary<int, ULGUIPlayTweenComponent[]>();
			}
			this.TweenAnimMap[componentType] = array;
		}

		// Token: 0x0603D420 RID: 250912 RVA: 0x00EC341C File Offset: 0x00EC161C
		private void PlayTweenAnim(int componentType)
		{
			ULGUIPlayTweenComponent[] array;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out array))
			{
				ULGUIPlayTweenComponent[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].Play();
				}
			}
		}

		// Token: 0x0603D421 RID: 250913 RVA: 0x00EC345C File Offset: 0x00EC165C
		private void StopTweenAnim(int componentType)
		{
			ULGUIPlayTweenComponent[] array;
			if (this.TweenAnimMap != null && this.TweenAnimMap.TryGetValue(componentType, out array))
			{
				ULGUIPlayTweenComponent[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].Stop();
				}
			}
		}

		// Token: 0x0401FF1C RID: 130844
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, ULGUIPlayTweenComponent[]> TweenAnimMap;

		// Token: 0x0401FF1D RID: 130845
		private bool Visible;

		// Token: 0x0200C18A RID: 49546
		private enum EChildType
		{
			// Token: 0x0403A7BC RID: 239548
			EnergyItem,
			// Token: 0x0403A7BD RID: 239549
			IconItem,
			// Token: 0x0403A7BE RID: 239550
			EnergyEffect,
			// Token: 0x0403A7BF RID: 239551
			StartEffect,
			// Token: 0x0403A7C0 RID: 239552
			CloseEffect,
			// Token: 0x0403A7C1 RID: 239553
			AnimStart,
			// Token: 0x0403A7C2 RID: 239554
			AnimClose
		}
	}
}
