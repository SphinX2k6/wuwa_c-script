using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200609D RID: 24733
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleItem : UiPanelBase
	{
		// Token: 0x0603E84D RID: 256077 RVA: 0x00F1C6D0 File Offset: 0x00F1A8D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E84E RID: 256078 RVA: 0x00F1C77C File Offset: 0x00F1A97C
		public UniTask RefreshExternalByDataAsync(Spring25DialogueSpineData data)
		{
			RoleItem.<RefreshExternalByDataAsync>d__2 <RefreshExternalByDataAsync>d__;
			<RefreshExternalByDataAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshExternalByDataAsync>d__.<>4__this = this;
			<RefreshExternalByDataAsync>d__.data = data;
			<RefreshExternalByDataAsync>d__.<>1__state = -1;
			<RefreshExternalByDataAsync>d__.<>t__builder.Start<RoleItem.<RefreshExternalByDataAsync>d__2>(ref <RefreshExternalByDataAsync>d__);
			return <RefreshExternalByDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E84F RID: 256079 RVA: 0x00F1C7C7 File Offset: 0x00F1A9C7
		public void RefreshText(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
		}

		// Token: 0x0603E850 RID: 256080 RVA: 0x00F1C7E0 File Offset: 0x00F1A9E0
		public void RefreshAnim(string animName)
		{
			base.GetSpine(0).SetAnimation(0, animName, true);
		}

		// Token: 0x0200C2F3 RID: 49907
		[NullableContext(0)]
		private class ERoleComponent
		{
			// Token: 0x0403ADDB RID: 241115
			public const int RoleSpine = 0;

			// Token: 0x0403ADDC RID: 241116
			public const int ChatItem = 1;

			// Token: 0x0403ADDD RID: 241117
			public const int ChatText = 2;

			// Token: 0x0403ADDE RID: 241118
			public const int RoleSpinAnother = 3;
		}
	}
}
