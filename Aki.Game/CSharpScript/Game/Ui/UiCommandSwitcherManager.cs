using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003564 RID: 13668
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class UiCommandSwitcherManager
	{
		// Token: 0x06022CD2 RID: 142546 RVA: 0x009E37DC File Offset: 0x009E19DC
		internal void Apply(UiCommandSwitcher switcher)
		{
			UiCommandSwitcherManager.CommandState commandState;
			if (!this.CommandStates.TryGetValue(switcher.CommandName, out commandState))
			{
				commandState = new UiCommandSwitcherManager.CommandState(switcher);
				this.CommandStates.Add(switcher.CommandName, commandState);
			}
			commandState.Switchers.Add(switcher);
			switcher.RunStartCommand();
		}

		// Token: 0x06022CD3 RID: 142547 RVA: 0x009E382C File Offset: 0x009E1A2C
		internal bool Reapply(UiCommandSwitcher switcher)
		{
			UiCommandSwitcherManager.CommandState commandState;
			if (!this.CommandStates.TryGetValue(switcher.CommandName, out commandState) || !commandState.Switchers.Remove(switcher))
			{
				return false;
			}
			commandState.Switchers.Add(switcher);
			switcher.RunStartCommand();
			return true;
		}

		// Token: 0x06022CD4 RID: 142548 RVA: 0x009E3874 File Offset: 0x009E1A74
		internal void Restore(UiCommandSwitcher switcher)
		{
			UiCommandSwitcherManager.CommandState commandState;
			if (!this.CommandStates.TryGetValue(switcher.CommandName, out commandState))
			{
				return;
			}
			int num = commandState.Switchers.IndexOf(switcher);
			if (num < 0)
			{
				return;
			}
			if (num == commandState.Switchers.Count - 1)
			{
				if (num > 0)
				{
					commandState.Switchers[num - 1].RunStartCommand();
				}
				else
				{
					commandState.RestoreCommand();
				}
			}
			commandState.Switchers.RemoveAt(num);
			if (commandState.Switchers.Count == 0)
			{
				this.CommandStates.Remove(switcher.CommandName);
			}
		}

		// Token: 0x040133EA RID: 78826
		private readonly Dictionary<string, UiCommandSwitcherManager.CommandState> CommandStates = new Dictionary<string, UiCommandSwitcherManager.CommandState>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x02009249 RID: 37449
		[Nullable(0)]
		private sealed class CommandState
		{
			// Token: 0x060439F5 RID: 276981 RVA: 0x013F9DD1 File Offset: 0x013F7FD1
			public CommandState(UiCommandSwitcher firstSwitcher)
			{
			}

			// Token: 0x0402DCAA RID: 187562
			public readonly List<UiCommandSwitcher> Switchers = new List<UiCommandSwitcher>();

			// Token: 0x0402DCAB RID: 187563
			public readonly Action RestoreCommand = firstSwitcher.CreateRestoreCommand();
		}
	}
}
