using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x020052D9 RID: 21209
	public class PinballItemGridRoleHeadComponent : PinballItemGridComponentBase
	{
		// Token: 0x06034CC7 RID: 216263 RVA: 0x00EC29C4 File Offset: 0x00EC0BC4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034CC8 RID: 216264 RVA: 0x00EC2A0C File Offset: 0x00EC0C0C
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRole";
		}

		// Token: 0x06034CC9 RID: 216265 RVA: 0x00EC2A14 File Offset: 0x00EC0C14
		[NullableContext(1)]
		protected override void OnRefresh(params object[] args)
		{
			int num = (int)args[0];
			if (num == 0)
			{
				this.SetActive(false);
				return;
			}
			PinballConfig instance = PinballConfig.Instance;
			PinballRoleConfig? pinballRoleConfig = (instance != null) ? instance.GetPinballRoleConfigById(num) : null;
			if (pinballRoleConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.PinballBattle;
				ELogAuthor author = ELogAuthor.CB;
				string message = "星弹奇游角色配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", num);
				instance2.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.SetActive(false);
				return;
			}
			this.SetActive(true);
			base.TrySetTextureByPath(pinballRoleConfig.Value.SmallIcon, base.GetTexture(0), null, null);
		}

		// Token: 0x0200AF64 RID: 44900
		private enum EComponent
		{
			// Token: 0x04036318 RID: 221976
			TexRoleIcon
		}
	}
}
