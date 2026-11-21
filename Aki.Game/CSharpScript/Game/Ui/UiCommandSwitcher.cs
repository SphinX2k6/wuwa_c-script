using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003562 RID: 13666
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCommandSwitcher : UiSwitcherBase
	{
		// Token: 0x06022CBF RID: 142527 RVA: 0x009E358D File Offset: 0x009E178D
		protected UiCommandSwitcher(string commandName, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand) : base(commandName)
		{
			this.CommandName = commandName;
			this.ExecuteCommand = executeCommand;
		}

		// Token: 0x06022CC0 RID: 142528 RVA: 0x009E35A4 File Offset: 0x009E17A4
		public UiCommandSwitcher(string startCommand, string endCommand, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand = null) : base(startCommand)
		{
			this.CommandName = startCommand.Split(' ', StringSplitOptions.None)[0];
			this.StartCommand = startCommand;
			this.EndCommand = endCommand;
			this.ExecuteCommand = executeCommand;
		}

		// Token: 0x06022CC1 RID: 142529 RVA: 0x009E35D3 File Offset: 0x009E17D3
		protected override void ApplyInternal()
		{
			UiManager.Instance.CommandSwitcherManager.Apply(this);
		}

		// Token: 0x06022CC2 RID: 142530 RVA: 0x009E35E5 File Offset: 0x009E17E5
		protected override void RestoreInternal()
		{
			UiManager.Instance.CommandSwitcherManager.Restore(this);
		}

		// Token: 0x06022CC3 RID: 142531 RVA: 0x009E35F7 File Offset: 0x009E17F7
		internal void Reapply()
		{
			if (!UiManager.Instance.CommandSwitcherManager.Reapply(this))
			{
				this.ApplyInternal();
			}
		}

		// Token: 0x06022CC4 RID: 142532 RVA: 0x009E3614 File Offset: 0x009E1814
		internal virtual bool IsSameRequest(UiCommandSwitcher other)
		{
			return base.GetType() == other.GetType() && this.ExecuteCommand == other.ExecuteCommand && this.StartCommand == other.StartCommand && this.EndCommand == other.EndCommand;
		}

		// Token: 0x06022CC5 RID: 142533 RVA: 0x009E366D File Offset: 0x009E186D
		internal virtual void RunStartCommand()
		{
			this.RunCommand(this.StartCommand);
		}

		// Token: 0x06022CC6 RID: 142534 RVA: 0x009E367B File Offset: 0x009E187B
		internal virtual Action CreateRestoreCommand()
		{
			return delegate()
			{
				this.RunCommand(this.EndCommand);
			};
		}

		// Token: 0x06022CC7 RID: 142535 RVA: 0x009E3689 File Offset: 0x009E1889
		protected void RunCommand(string command)
		{
			if (this.ExecuteCommand != null)
			{
				this.ExecuteCommand(command);
				return;
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, command, null);
		}

		// Token: 0x040133E3 RID: 78819
		internal readonly string CommandName;

		// Token: 0x040133E4 RID: 78820
		[Nullable(2)]
		private readonly string StartCommand;

		// Token: 0x040133E5 RID: 78821
		[Nullable(2)]
		private readonly string EndCommand;

		// Token: 0x040133E6 RID: 78822
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly Action<string> ExecuteCommand;
	}
}
