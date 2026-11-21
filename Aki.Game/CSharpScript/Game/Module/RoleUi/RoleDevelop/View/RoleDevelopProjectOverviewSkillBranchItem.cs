using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D06 RID: 15622
	public class RoleDevelopProjectOverviewSkillBranchItem : CommonRoleSkillBranchSwitchItem
	{
		// Token: 0x06027FCC RID: 163788 RVA: 0x00B30680 File Offset: 0x00B2E880
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06027FCD RID: 163789 RVA: 0x00B3076D File Offset: 0x00B2E96D
		protected override void OnStart()
		{
			base.OnStart();
			base.SetToggleInteractive(false);
		}

		// Token: 0x06027FCE RID: 163790 RVA: 0x00B3077C File Offset: 0x00B2E97C
		[NullableContext(1)]
		protected override SkillBranchSwitchItemGroup[] CollectBranchItems()
		{
			return new SkillBranchSwitchItemGroup[]
			{
				new SkillBranchSwitchItemGroup
				{
					SpriteTagIcon = base.GetSprite(2),
					ActiveIndexHandler = delegate(bool active)
					{
						base.GetItem(3).SetUIActive(active);
						if (active)
						{
							this.SetTagFlipped(true);
						}
					}
				},
				new SkillBranchSwitchItemGroup
				{
					SpriteTagIcon = base.GetSprite(4),
					ActiveIndexHandler = delegate(bool active)
					{
						base.GetItem(5).SetUIActive(active);
						if (active)
						{
							this.SetTagFlipped(false);
						}
					}
				}
			};
		}

		// Token: 0x06027FCF RID: 163791 RVA: 0x00B307DD File Offset: 0x00B2E9DD
		[NullableContext(1)]
		protected override UUIExtendToggle GetBranchToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06027FD0 RID: 163792 RVA: 0x00B307E8 File Offset: 0x00B2E9E8
		private void SetTagFlipped(bool isLeft)
		{
			UUIItem sprite = base.GetSprite(1);
			FVector fvector = new FVector((float)(isLeft ? -1 : 1), 1f, 1f);
			sprite.SetUIRelativeScale3D(fvector);
		}

		// Token: 0x020098CE RID: 39118
		private enum EComponentType
		{
			// Token: 0x0402FA65 RID: 195173
			SkillBranchToggle,
			// Token: 0x0402FA66 RID: 195174
			TagSprite,
			// Token: 0x0402FA67 RID: 195175
			LeftTagIconSprite,
			// Token: 0x0402FA68 RID: 195176
			LeftSelectItem,
			// Token: 0x0402FA69 RID: 195177
			RightTagIconSprite,
			// Token: 0x0402FA6A RID: 195178
			RightSelectItem
		}
	}
}
