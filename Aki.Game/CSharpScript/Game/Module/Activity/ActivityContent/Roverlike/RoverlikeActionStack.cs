using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006105 RID: 24837
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeActionStack
	{
		// Token: 0x0603ECA2 RID: 257186 RVA: 0x00F29C7B File Offset: 0x00F27E7B
		public void Push(UiPanelBase panel)
		{
			this.Stack.Add(panel);
		}

		// Token: 0x0603ECA3 RID: 257187 RVA: 0x00F29C8C File Offset: 0x00F27E8C
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

		// Token: 0x0603ECA4 RID: 257188 RVA: 0x00F29D7C File Offset: 0x00F27F7C
		public bool IsTop(UiPanelBase panel)
		{
			if (this.Stack.Count == 0)
			{
				return false;
			}
			this.CleanupDestroyed();
			return this.Stack.Count > 0 && this.Stack[this.Stack.Count - 1] == panel;
		}

		// Token: 0x0603ECA5 RID: 257189 RVA: 0x00F29DC9 File Offset: 0x00F27FC9
		public bool TryAction(UiPanelBase owner, Action action)
		{
			if (!this.IsTop(owner))
			{
				return false;
			}
			action();
			return true;
		}

		// Token: 0x0603ECA6 RID: 257190 RVA: 0x00F29DDD File Offset: 0x00F27FDD
		public void Clear()
		{
			this.Stack.Clear();
		}

		// Token: 0x0603ECA7 RID: 257191 RVA: 0x00F29DEC File Offset: 0x00F27FEC
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

		// Token: 0x04020CEA RID: 134378
		private readonly List<UiPanelBase> Stack = new List<UiPanelBase>();
	}
}
