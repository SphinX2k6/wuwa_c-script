using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200630E RID: 25358
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballRoleClassItem : GridProxyAbstract<IPinballRoleClassItemData>
	{
		// Token: 0x0603FCCB RID: 261323 RVA: 0x00F6F9C4 File Offset: 0x00F6DBC4
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

		// Token: 0x0603FCCC RID: 261324 RVA: 0x00F6FA30 File Offset: 0x00F6DC30
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleClassItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleClassItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FCCD RID: 261325 RVA: 0x00F6FA74 File Offset: 0x00F6DC74
		[NullableContext(1)]
		public override void Refresh(IPinballRoleClassItemData data, bool isSelected, int gridIndex)
		{
			PinballRoleClassIconItemData data2 = new PinballRoleClassIconItemData
			{
				IconPath = data.IconPath,
				BgColor = data.BgColor
			};
			this.ClassIconItem.Refresh(data2);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Name, Array.Empty<object>());
		}

		// Token: 0x040214BD RID: 136381
		[Nullable(2)]
		private PinballRoleClassIconItem ClassIconItem;

		// Token: 0x0200C503 RID: 50435
		private enum EComponent
		{
			// Token: 0x0403B756 RID: 243542
			ClassIconItem,
			// Token: 0x0403B757 RID: 243543
			NameText
		}
	}
}
