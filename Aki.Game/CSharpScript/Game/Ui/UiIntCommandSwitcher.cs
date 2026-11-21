using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003566 RID: 13670
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class UiIntCommandSwitcher : UiCommandSwitcherBase<int>
	{
		// Token: 0x06022CD9 RID: 142553 RVA: 0x009E394D File Offset: 0x009E1B4D
		public UiIntCommandSwitcher(string commandName, int value, int? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null) : base(commandName, value, restoreValue, executeCommand)
		{
		}

		// Token: 0x06022CDA RID: 142554 RVA: 0x009E395A File Offset: 0x009E1B5A
		protected override int GetCurrentValue()
		{
			return UKismetSystemLibrary.GetConsoleVariableIntValue(this.CommandName);
		}

		// Token: 0x06022CDB RID: 142555 RVA: 0x009E3967 File Offset: 0x009E1B67
		protected override string FormatValue(int value)
		{
			return value.ToString(CultureInfo.InvariantCulture);
		}
	}
}
