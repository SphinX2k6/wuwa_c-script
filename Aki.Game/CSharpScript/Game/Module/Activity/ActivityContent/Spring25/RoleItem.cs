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
	// Token: 0x0200501B RID: 20507
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleItem : UiPanelBase
	{
		// Token: 0x06033511 RID: 210193 RVA: 0x00E63494 File Offset: 0x00E61694
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

		// Token: 0x06033512 RID: 210194 RVA: 0x00E63540 File Offset: 0x00E61740
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

		// Token: 0x06033513 RID: 210195 RVA: 0x00E6358B File Offset: 0x00E6178B
		public void RefreshText(string textId)
		{
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(2), textId, Array.Empty<object>());
		}

		// Token: 0x06033514 RID: 210196 RVA: 0x00E635A4 File Offset: 0x00E617A4
		public void RefreshAnim(string animName)
		{
			base.GetSpine(0).SetAnimation(0, animName, true);
		}

		// Token: 0x0200ACDE RID: 44254
		[NullableContext(0)]
		private class ERoleComponent
		{
			// Token: 0x04035743 RID: 218947
			public const int RoleSpine = 0;

			// Token: 0x04035744 RID: 218948
			public const int ChatItem = 1;

			// Token: 0x04035745 RID: 218949
			public const int ChatText = 2;

			// Token: 0x04035746 RID: 218950
			public const int RoleSpinAnother = 3;
		}
	}
}
