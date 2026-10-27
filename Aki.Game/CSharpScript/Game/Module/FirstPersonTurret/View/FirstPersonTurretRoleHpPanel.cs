using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FirstPersonTurret.View
{
	// Token: 0x02005A83 RID: 23171
	public class FirstPersonTurretRoleHpPanel : UiPanelBase
	{
		// Token: 0x0603AAF7 RID: 240375 RVA: 0x00DF9BA4 File Offset: 0x00DF7DA4
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AAF8 RID: 240376 RVA: 0x00DF9CB4 File Offset: 0x00DF7EB4
		protected override UniTask OnBeforeStartAsync()
		{
			FirstPersonTurretRoleHpPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FirstPersonTurretRoleHpPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AAF9 RID: 240377 RVA: 0x00DF9CF8 File Offset: 0x00DF7EF8
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(4);
			if (item4 != null)
			{
				item4.SetUIActive(false);
			}
			UUIItem item5 = base.GetItem(5);
			if (item5 != null)
			{
				item5.SetUIActive(false);
			}
			UUIItem item6 = base.GetItem(6);
			if (item6 == null)
			{
				return;
			}
			item6.SetUIActive(false);
		}

		// Token: 0x0603AAFA RID: 240378 RVA: 0x00DF9D76 File Offset: 0x00DF7F76
		public void Refresh(float hp, float hpMax)
		{
			FirstPersonTurretRoleHpItem hpItem = this.HpItem;
			if (hpItem == null)
			{
				return;
			}
			hpItem.Refresh(hp, hpMax);
		}

		// Token: 0x0603AAFB RID: 240379 RVA: 0x00DF9D8A File Offset: 0x00DF7F8A
		public void Tick(float delta)
		{
			FirstPersonTurretRoleHpItem hpItem = this.HpItem;
			if (hpItem == null)
			{
				return;
			}
			hpItem.Tick(delta);
		}

		// Token: 0x0401EA1F RID: 125471
		[Nullable(2)]
		private FirstPersonTurretRoleHpItem HpItem;
	}
}
