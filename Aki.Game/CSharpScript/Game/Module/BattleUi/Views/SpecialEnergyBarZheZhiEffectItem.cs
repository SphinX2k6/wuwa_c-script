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
	// Token: 0x02004DFD RID: 19965
	public class SpecialEnergyBarZheZhiEffectItem : UiPanelBase
	{
		// Token: 0x060323A8 RID: 205736 RVA: 0x00E14708 File Offset: 0x00E12908
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

		// Token: 0x060323A9 RID: 205737 RVA: 0x00E14754 File Offset: 0x00E12954
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

		// Token: 0x060323AA RID: 205738 RVA: 0x00E14862 File Offset: 0x00E12A62
		protected override void OnStart()
		{
			base.OnStart();
			base.GetUiNiagara(3).SetUIActive(false);
			base.GetUiNiagara(4).SetUIActive(false);
			this.InitTweenAnim(5);
			this.InitTweenAnim(6);
		}

		// Token: 0x060323AB RID: 205739 RVA: 0x00E14892 File Offset: 0x00E12A92
		[NullableContext(1)]
		public void SetNiagaraParam(string varName, float value)
		{
			base.GetUiNiagara(2).SetNiagaraVarFloat(varName, value);
		}

		// Token: 0x060323AC RID: 205740 RVA: 0x00E148A4 File Offset: 0x00E12AA4
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

		// Token: 0x060323AD RID: 205741 RVA: 0x00E148FC File Offset: 0x00E12AFC
		protected override void OnBeforeHide()
		{
			this.TweenAnimMap = null;
		}

		// Token: 0x060323AE RID: 205742 RVA: 0x00E14908 File Offset: 0x00E12B08
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

		// Token: 0x060323AF RID: 205743 RVA: 0x00E1497C File Offset: 0x00E12B7C
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

		// Token: 0x060323B0 RID: 205744 RVA: 0x00E149BC File Offset: 0x00E12BBC
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

		// Token: 0x0401A9E3 RID: 109027
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<int, ULGUIPlayTweenComponent[]> TweenAnimMap;

		// Token: 0x0401A9E4 RID: 109028
		private bool Visible;

		// Token: 0x0200AB99 RID: 43929
		private enum EChildType
		{
			// Token: 0x040351AE RID: 217518
			EnergyItem,
			// Token: 0x040351AF RID: 217519
			IconItem,
			// Token: 0x040351B0 RID: 217520
			EnergyEffect,
			// Token: 0x040351B1 RID: 217521
			StartEffect,
			// Token: 0x040351B2 RID: 217522
			CloseEffect,
			// Token: 0x040351B3 RID: 217523
			AnimStart,
			// Token: 0x040351B4 RID: 217524
			AnimClose
		}
	}
}
