using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052E8 RID: 21224
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleTagItem : GridProxyAbstract<IRoleTagItemData>
	{
		// Token: 0x06034D21 RID: 216353 RVA: 0x00EC3F08 File Offset: 0x00EC2108
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034D22 RID: 216354 RVA: 0x00EC3F74 File Offset: 0x00EC2174
		protected override UniTask OnBeforeStartAsync()
		{
			RoleTagItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTagItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034D23 RID: 216355 RVA: 0x00EC3FB8 File Offset: 0x00EC21B8
		[NullableContext(1)]
		public override void Refresh(IRoleTagItemData data, bool isSelected, int gridIndex)
		{
			if (data.Type != ETagType.BD)
			{
				if (data.Type == ETagType.Class)
				{
					PinballClassConfig? pinballClassConfigById = PinballConfig.Instance.GetPinballClassConfigById(data.ConfigId);
					LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pinballClassConfigById.Value.PinballClassName, Array.Empty<object>());
					TagIconItem tagIconItemIns = this.TagIconItemIns;
					if (tagIconItemIns == null)
					{
						return;
					}
					tagIconItemIns.RefreshPanel(pinballClassConfigById.Value.Icon, pinballClassConfigById.Value.BgColor);
				}
				return;
			}
			PinballBdConfig? pinballBdConfigById = PinballConfig.Instance.GetPinballBdConfigById(data.ConfigId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pinballBdConfigById.Value.BdName, Array.Empty<object>());
			TagIconItem tagIconItemIns2 = this.TagIconItemIns;
			if (tagIconItemIns2 == null)
			{
				return;
			}
			tagIconItemIns2.RefreshPanel(pinballBdConfigById.Value.Icon, pinballBdConfigById.Value.BgColor);
		}

		// Token: 0x0401BF1F RID: 114463
		[Nullable(2)]
		private TagIconItem TagIconItemIns;

		// Token: 0x0200AF6B RID: 44907
		private enum ERoleTagItem
		{
			// Token: 0x04036347 RID: 222023
			IconItem,
			// Token: 0x04036348 RID: 222024
			NameText
		}
	}
}
