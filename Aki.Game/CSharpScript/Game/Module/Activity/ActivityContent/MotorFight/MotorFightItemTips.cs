using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x020053A5 RID: 21413
	public class MotorFightItemTips : UiViewBase
	{
		// Token: 0x0603543A RID: 218170 RVA: 0x00EE0AA0 File Offset: 0x00EDECA0
		[NullableContext(1)]
		public MotorFightItemTips(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603543B RID: 218171 RVA: 0x00EE0AAC File Offset: 0x00EDECAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603543C RID: 218172 RVA: 0x00EE0B54 File Offset: 0x00EDED54
		protected override UniTask OnBeforeStartAsync()
		{
			MotorFightItemTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorFightItemTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603543D RID: 218173 RVA: 0x00EE0B97 File Offset: 0x00EDED97
		private void OnClickBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401C16E RID: 115054
		[Nullable(2)]
		protected MotorFightItemDetailPanel CollectionItem;

		// Token: 0x0401C16F RID: 115055
		[Nullable(2)]
		protected MotorFightItemData Data;

		// Token: 0x0200B043 RID: 45123
		private class EComponentDefine
		{
			// Token: 0x04036778 RID: 223096
			public const int ButtonClose = 0;

			// Token: 0x04036779 RID: 223097
			public const int ItemTopCollection = 1;
		}
	}
}
