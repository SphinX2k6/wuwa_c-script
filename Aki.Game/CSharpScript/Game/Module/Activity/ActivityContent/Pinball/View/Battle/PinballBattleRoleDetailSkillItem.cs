using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x020052F7 RID: 21239
	public class PinballBattleRoleDetailSkillItem : GridProxyAbstract<int>
	{
		// Token: 0x06034D98 RID: 216472 RVA: 0x00EC6944 File Offset: 0x00EC4B44
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034D99 RID: 216473 RVA: 0x00EC69CE File Offset: 0x00EC4BCE
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x06034D9A RID: 216474 RVA: 0x00EC69D8 File Offset: 0x00EC4BD8
		public void Refresh(int data)
		{
			PinballSkillDisplayConfig? pinballSkillDisplayConfigById = PinballConfig.Instance.GetPinballSkillDisplayConfigById(data);
			if (pinballSkillDisplayConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Pinball;
				ELogAuthor author = ELogAuthor.CB;
				string message = "技能配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", data);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), pinballSkillDisplayConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pinballSkillDisplayConfigById.Value.Desc, pinballSkillDisplayConfigById.Value.ValueList());
		}

		// Token: 0x0200AF7B RID: 44923
		private enum EPinballBattleRoleDetailSkillItemComp
		{
			// Token: 0x040363B0 RID: 222128
			NameText,
			// Token: 0x040363B1 RID: 222129
			DescriptionText,
			// Token: 0x040363B2 RID: 222130
			SpriteIcon
		}
	}
}
