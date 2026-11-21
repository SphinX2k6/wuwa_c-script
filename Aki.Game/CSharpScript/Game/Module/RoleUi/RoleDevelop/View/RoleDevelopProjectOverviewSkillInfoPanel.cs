using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D03 RID: 15619
	public class RoleDevelopProjectOverviewSkillInfoPanel : RoleDevelopProjectOverviewBaseInfoPanel
	{
		// Token: 0x06027FB6 RID: 163766 RVA: 0x00B2FC10 File Offset: 0x00B2DE10
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickJumpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FB7 RID: 163767 RVA: 0x00B2FD3C File Offset: 0x00B2DF3C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectOverviewSkillInfoPanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectOverviewSkillInfoPanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FB8 RID: 163768 RVA: 0x00B2FD80 File Offset: 0x00B2DF80
		protected override void OnRefreshPanel(bool forceRefresh)
		{
			List<RoleDevelopSkillData> skillDevelopData = this.Data.GetProjectData().GetSkillDevelopData();
			for (int i = 0; i < this.SkillSlotItems.Count; i++)
			{
				this.SkillSlotItems[i].Refresh(skillDevelopData[i], false);
			}
		}

		// Token: 0x06027FB9 RID: 163769 RVA: 0x00B2FDD0 File Offset: 0x00B2DFD0
		private void OnClickJumpButton()
		{
			base.SwitchCategory(ERoleDevelopCategoryType.Skill);
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Overview, ERoleDevelopLogSubPage.OverviewSkillPageJump, null);
		}

		// Token: 0x04015C5F RID: 89183
		[Nullable(1)]
		private readonly List<RoleDevelopProjectSkillSlotItem> SkillSlotItems = new List<RoleDevelopProjectSkillSlotItem>();

		// Token: 0x020098C5 RID: 39109
		private enum EComponentType
		{
			// Token: 0x0402FA3B RID: 195131
			JumpButton,
			// Token: 0x0402FA3C RID: 195132
			SkillSlot0,
			// Token: 0x0402FA3D RID: 195133
			SkillSlot1,
			// Token: 0x0402FA3E RID: 195134
			SkillSlot2,
			// Token: 0x0402FA3F RID: 195135
			SkillSlot3,
			// Token: 0x0402FA40 RID: 195136
			SkillSlot4
		}
	}
}
