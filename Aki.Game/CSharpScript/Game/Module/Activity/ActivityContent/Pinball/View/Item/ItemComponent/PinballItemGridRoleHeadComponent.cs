using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item.ItemComponent
{
	// Token: 0x0200635B RID: 25435
	public class PinballItemGridRoleHeadComponent : PinballItemGridComponentBase
	{
		// Token: 0x06040006 RID: 262150 RVA: 0x00F7BA64 File Offset: 0x00F79C64
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

		// Token: 0x06040007 RID: 262151 RVA: 0x00F7BAAC File Offset: 0x00F79CAC
		[NullableContext(2)]
		protected override string OnGetResourceId()
		{
			return "UiItem_ItemBaseRole";
		}

		// Token: 0x06040008 RID: 262152 RVA: 0x00F7BAB4 File Offset: 0x00F79CB4
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

		// Token: 0x0200C57D RID: 50557
		private enum EComponent
		{
			// Token: 0x0403B9B6 RID: 244150
			TexRoleIcon
		}
	}
}
