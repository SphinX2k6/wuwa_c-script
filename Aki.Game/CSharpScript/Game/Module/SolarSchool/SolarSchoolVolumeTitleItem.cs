using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Menu;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A5B RID: 23131
	public class SolarSchoolVolumeTitleItem : SyncGridProxyAbstract<EFunction>
	{
		// Token: 0x06038FDC RID: 233436 RVA: 0x00FF6654 File Offset: 0x00FF4854
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038FDD RID: 233437 RVA: 0x00FF66C0 File Offset: 0x00FF48C0
		public override void Refresh(EFunction functionId)
		{
			MenuConfig? menuConfigByFunctionId = MenuBaseConfig.Instance.GetMenuConfigByFunctionId(1);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			if (menuConfigByFunctionId != null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), new MenuData(menuConfigByFunctionId.Value).SubName, Array.Empty<object>());
			}
		}

		// Token: 0x0401DFF5 RID: 122869
		private const int Title = 1;

		// Token: 0x0401DFF6 RID: 122870
		private const int HelpButton = 2;
	}
}
