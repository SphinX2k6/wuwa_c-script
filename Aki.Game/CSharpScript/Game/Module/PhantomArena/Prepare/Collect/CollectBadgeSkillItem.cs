using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x020051AE RID: 20910
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectBadgeSkillItem : GridProxyAbstract<BadgeGroupSkillData>
	{
		// Token: 0x060358A6 RID: 219302 RVA: 0x00CAEC70 File Offset: 0x00CACE70
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x060358A7 RID: 219303 RVA: 0x00CAECCC File Offset: 0x00CACECC
		[NullableContext(1)]
		public override void Refresh(BadgeGroupSkillData data, bool isSelected, int gridIndex)
		{
			int groupId = data.GroupId;
			int skillId = data.SkillId;
			BadgeGroupCollectCountData badgeCollectCountByGroupId = PhantomArenaModel.Instance.GetBadgeCollectCountByGroupId(groupId);
			bool flag = badgeCollectCountByGroupId.Now >= badgeCollectCountByGroupId.Need;
			PhantomBattleSkill phantomBattleSkillConfig = PhantomArenaConfig.Instance.GetPhantomBattleSkillConfig(skillId);
			UUIText text = base.GetText(1);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomBattleSkillConfig.Name, Array.Empty<object>());
			UUIItem uuiitem = text;
			bool bUseChangeColor = !flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUIText text2 = base.GetText(2);
			UUIItem uuiitem2 = text2;
			bool bUseChangeColor2 = !flag;
			fcolor = new FColor?(text.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			LguiUtil.Instance.SetLocalTextNew(text2, phantomBattleSkillConfig.Desc, phantomBattleSkillConfig.DescParams());
			base.GetSprite(0).SetUIActive(flag);
		}

		// Token: 0x060358A8 RID: 219304 RVA: 0x00CAED9E File Offset: 0x00CACF9E
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060358A9 RID: 219305 RVA: 0x00CAEDA0 File Offset: 0x00CACFA0
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0200B335 RID: 45877
		private static class EComponents
		{
			// Token: 0x04036503 RID: 222467
			public const int SpriteAll = 0;

			// Token: 0x04036504 RID: 222468
			public const int TextName = 1;

			// Token: 0x04036505 RID: 222469
			public const int TextDesc = 2;
		}
	}
}
