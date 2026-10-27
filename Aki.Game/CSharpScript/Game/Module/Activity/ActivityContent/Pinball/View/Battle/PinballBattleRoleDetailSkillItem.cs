using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x02006379 RID: 25465
	public class PinballBattleRoleDetailSkillItem : GridProxyAbstract<int>
	{
		// Token: 0x060400D7 RID: 262359 RVA: 0x00F7F9E0 File Offset: 0x00F7DBE0
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

		// Token: 0x060400D8 RID: 262360 RVA: 0x00F7FA6A File Offset: 0x00F7DC6A
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Refresh(data);
		}

		// Token: 0x060400D9 RID: 262361 RVA: 0x00F7FA74 File Offset: 0x00F7DC74
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

		// Token: 0x0200C594 RID: 50580
		private enum EPinballBattleRoleDetailSkillItemComp
		{
			// Token: 0x0403BA4E RID: 244302
			NameText,
			// Token: 0x0403BA4F RID: 244303
			DescriptionText,
			// Token: 0x0403BA50 RID: 244304
			SpriteIcon
		}
	}
}
