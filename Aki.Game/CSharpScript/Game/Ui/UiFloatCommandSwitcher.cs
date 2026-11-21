using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003565 RID: 13669
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class UiFloatCommandSwitcher : UiCommandSwitcherBase<float>
	{
		// Token: 0x06022CD6 RID: 142550 RVA: 0x009E3920 File Offset: 0x009E1B20
		public UiFloatCommandSwitcher(string commandName, float value, float? restoreValue = null, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null) : base(commandName, value, restoreValue, executeCommand)
		{
		}

		// Token: 0x06022CD7 RID: 142551 RVA: 0x009E392D File Offset: 0x009E1B2D
		protected override float GetCurrentValue()
		{
			return UKismetSystemLibrary.GetConsoleVariableFloatValue(this.CommandName);
		}

		// Token: 0x06022CD8 RID: 142552 RVA: 0x009E393A File Offset: 0x009E1B3A
		protected override string FormatValue(float value)
		{
			return value.ToString("R", CultureInfo.InvariantCulture);
		}
	}
}
