using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005083 RID: 20611
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionStack
	{
		// Token: 0x06033964 RID: 211300 RVA: 0x00E70A8F File Offset: 0x00E6EC8F
		public void Push(UiPanelBase panel)
		{
			this.Stack.Add(panel);
		}

		// Token: 0x06033965 RID: 211301 RVA: 0x00E70AA0 File Offset: 0x00E6ECA0
		public unsafe void Pop(UiPanelBase panel)
		{
			int num = -1;
			for (int i = this.Stack.Count - 1; i >= 0; i--)
			{
				if (this.Stack[i] == panel)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] ActionStack Pop: 未找到目标";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Panel", panel.GetType().Name);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Stack.RemoveAt(num);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Roverlike;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[俯视角肉鸽] ActionStack Pop";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Panel", panel.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StackSize", this.Stack.Count);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06033966 RID: 211302 RVA: 0x00E70B90 File Offset: 0x00E6ED90
		public bool IsTop(UiPanelBase panel)
		{
			if (this.Stack.Count == 0)
			{
				return false;
			}
			this.CleanupDestroyed();
			return this.Stack.Count > 0 && this.Stack[this.Stack.Count - 1] == panel;
		}

		// Token: 0x06033967 RID: 211303 RVA: 0x00E70BDD File Offset: 0x00E6EDDD
		public bool TryAction(UiPanelBase owner, Action action)
		{
			if (!this.IsTop(owner))
			{
				return false;
			}
			action();
			return true;
		}

		// Token: 0x06033968 RID: 211304 RVA: 0x00E70BF1 File Offset: 0x00E6EDF1
		public void Clear()
		{
			this.Stack.Clear();
		}

		// Token: 0x06033969 RID: 211305 RVA: 0x00E70C00 File Offset: 0x00E6EE00
		private void CleanupDestroyed()
		{
			while (this.Stack.Count > 0)
			{
				UiPanelBase uiPanelBase = this.Stack[this.Stack.Count - 1];
				AActor rootActor = uiPanelBase.GetRootActor();
				if (rootActor != null && rootActor.IsValid())
				{
					break;
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Roverlike;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[俯视角肉鸽] ActionStack 自动清理已销毁的栈顶";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Panel", uiPanelBase.GetType().Name);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.Stack.RemoveAt(this.Stack.Count - 1);
			}
		}

		// Token: 0x0401B617 RID: 112151
		private readonly List<UiPanelBase> Stack = new List<UiPanelBase>();
	}
}
