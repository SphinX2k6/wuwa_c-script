using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003561 RID: 13665
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class UiBoolCommandSwitcher : UiCommandSwitcherBase<bool>
	{
		// Token: 0x06022CBC RID: 142524 RVA: 0x009E3563 File Offset: 0x009E1763
		public UiBoolCommandSwitcher(string commandName, bool value, bool? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null) : base(commandName, value, restoreValue, executeCommand)
		{
		}

		// Token: 0x06022CBD RID: 142525 RVA: 0x009E3570 File Offset: 0x009E1770
		protected override bool GetCurrentValue()
		{
			return UKismetSystemLibrary.GetConsoleVariableBoolValue(this.CommandName);
		}

		// Token: 0x06022CBE RID: 142526 RVA: 0x009E357D File Offset: 0x009E177D
		protected override string FormatValue(bool value)
		{
			if (!value)
			{
				return "0";
			}
			return "1";
		}
	}
}
