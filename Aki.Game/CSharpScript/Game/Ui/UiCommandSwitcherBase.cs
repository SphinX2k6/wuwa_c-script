using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003563 RID: 13667
	public abstract class UiCommandSwitcherBase<T> : UiCommandSwitcher where T : struct, IEquatable<T>
	{
		// Token: 0x170048A3 RID: 18595
		// (get) Token: 0x06022CC9 RID: 142537 RVA: 0x009E36BC File Offset: 0x009E18BC
		internal T RestoreValue
		{
			get
			{
				T? endValue = this.EndValue;
				if (endValue == null)
				{
					return this.OriginalValue;
				}
				return endValue.GetValueOrDefault();
			}
		}

		// Token: 0x06022CCA RID: 142538 RVA: 0x009E36E7 File Offset: 0x009E18E7
		protected UiCommandSwitcherBase([Nullable(1)] string commandName, T value, T? restoreValue, [Nullable(new byte[]
		{
			2,
			1
		})] Action<string> executeCommand) : base(commandName, executeCommand)
		{
			this.StartValue = value;
			this.EndValue = restoreValue;
		}

		// Token: 0x06022CCB RID: 142539 RVA: 0x009E3700 File Offset: 0x009E1900
		protected override void ApplyInternal()
		{
			if (this.EndValue == null)
			{
				this.OriginalValue = this.GetCurrentValue();
			}
			base.ApplyInternal();
		}

		// Token: 0x06022CCC RID: 142540 RVA: 0x009E3724 File Offset: 0x009E1924
		[NullableContext(1)]
		internal override bool IsSameRequest(UiCommandSwitcher other)
		{
			UiCommandSwitcherBase<T> uiCommandSwitcherBase = other as UiCommandSwitcherBase<T>;
			if (uiCommandSwitcherBase != null && base.IsSameRequest(other))
			{
				T startValue = this.StartValue;
				if (startValue.Equals(uiCommandSwitcherBase.StartValue))
				{
					return Nullable.Equals<T>(this.EndValue, uiCommandSwitcherBase.EndValue);
				}
			}
			return false;
		}

		// Token: 0x06022CCD RID: 142541 RVA: 0x009E3773 File Offset: 0x009E1973
		internal override void RunStartCommand()
		{
			this.SetValue(this.StartValue);
		}

		// Token: 0x06022CCE RID: 142542 RVA: 0x009E3781 File Offset: 0x009E1981
		[NullableContext(1)]
		internal override Action CreateRestoreCommand()
		{
			T restoreValue = this.RestoreValue;
			return delegate()
			{
				this.SetValue(restoreValue);
			};
		}

		// Token: 0x06022CCF RID: 142543 RVA: 0x009E37A6 File Offset: 0x009E19A6
		private void SetValue(T value)
		{
			if (value.Equals(this.GetCurrentValue()))
			{
				return;
			}
			base.RunCommand(this.CommandName + " " + this.FormatValue(value));
		}

		// Token: 0x06022CD0 RID: 142544
		protected abstract T GetCurrentValue();

		// Token: 0x06022CD1 RID: 142545
		[return: Nullable(1)]
		protected abstract string FormatValue(T value);

		// Token: 0x040133E7 RID: 78823
		private readonly T StartValue;

		// Token: 0x040133E8 RID: 78824
		private readonly T? EndValue;

		// Token: 0x040133E9 RID: 78825
		private T OriginalValue;
	}
}
