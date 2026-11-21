using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D09 RID: 15625
	public class RoleDevelopProjectOverviewPanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x06027FDD RID: 163805 RVA: 0x00B30D0C File Offset: 0x00B2EF0C
		[NullableContext(1)]
		public void SetSwitchCategoryCallback(Action<ERoleDevelopCategoryType> callback)
		{
			this.SwitchCategoryCallback = callback;
			foreach (RoleDevelopProjectOverviewBaseInfoPanel roleDevelopProjectOverviewBaseInfoPanel in this.InfoPanelMap.Values)
			{
				roleDevelopProjectOverviewBaseInfoPanel.SetSwitchCategoryCallback(callback);
			}
		}

		// Token: 0x06027FDE RID: 163806 RVA: 0x00B30D6C File Offset: 0x00B2EF6C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
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
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027FDF RID: 163807 RVA: 0x00B30E38 File Offset: 0x00B2F038
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectOverviewPanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectOverviewPanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FE0 RID: 163808 RVA: 0x00B30E7C File Offset: 0x00B2F07C
		protected override void OnRefreshView(bool forceRefresh)
		{
			foreach (RoleDevelopProjectOverviewBaseInfoPanel roleDevelopProjectOverviewBaseInfoPanel in this.InfoPanelMap.Values)
			{
				roleDevelopProjectOverviewBaseInfoPanel.RefreshPanel(this.Data, forceRefresh);
			}
		}

		// Token: 0x04015C69 RID: 89193
		[Nullable(1)]
		private Dictionary<ERoleDevelopOverviewInfoType, RoleDevelopProjectOverviewBaseInfoPanel> InfoPanelMap = new Dictionary<ERoleDevelopOverviewInfoType, RoleDevelopProjectOverviewBaseInfoPanel>();

		// Token: 0x04015C6A RID: 89194
		[Nullable(2)]
		private Action<ERoleDevelopCategoryType> SwitchCategoryCallback;

		// Token: 0x020098D3 RID: 39123
		private enum EComponentType
		{
			// Token: 0x0402FA80 RID: 195200
			RoleInfoPanel,
			// Token: 0x0402FA81 RID: 195201
			WeaponInfoPanel,
			// Token: 0x0402FA82 RID: 195202
			SkillInfoPanel,
			// Token: 0x0402FA83 RID: 195203
			PhantomInfoPanel,
			// Token: 0x0402FA84 RID: 195204
			FormationInfoPanel
		}
	}
}
