using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x0200417E RID: 16766
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CollectBadgeSkillItem : GridProxyAbstract<BadgeGroupSkillData>
	{
		// Token: 0x0602A7A1 RID: 173985 RVA: 0x00BFC2AC File Offset: 0x00BFA4AC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUISprite)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x0602A7A2 RID: 173986 RVA: 0x00BFC308 File Offset: 0x00BFA508
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

		// Token: 0x0602A7A3 RID: 173987 RVA: 0x00BFC3DA File Offset: 0x00BFA5DA
		public override void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0602A7A4 RID: 173988 RVA: 0x00BFC3DC File Offset: 0x00BFA5DC
		public override void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x02009D6D RID: 40301
		private static class EComponents
		{
			// Token: 0x04030F56 RID: 200534
			public const int SpriteAll = 0;

			// Token: 0x04030F57 RID: 200535
			public const int TextName = 1;

			// Token: 0x04030F58 RID: 200536
			public const int TextDesc = 2;
		}
	}
}
