using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000EF6 RID: 3830
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckPlayerPressButton : ICheckPlayerInputBase
	{
		// Token: 0x06005480 RID: 21632 RVA: 0x000CF71C File Offset: 0x000CD91C
		private ICheckPlayerPressButton_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckPlayerPressButton 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckPlayerPressButton_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckPlayerPressButton_SetValue());
			}
			return result;
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x000CF754 File Offset: 0x000CD954
		public static ICheckPlayerPressButton Create([Nullable(2)] ICheckPlayerPressButton instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerPressButton
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x000CF767 File Offset: 0x000CD967
		public static ICheckPlayerPressButton CreateFromSetValue([Nullable(2)] ICheckPlayerPressButton_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckPlayerPressButton
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005483 RID: 21635 RVA: 0x000CF77A File Offset: 0x000CD97A
		public new ICheckPlayerPressButton_SetValue ToSetValue()
		{
			return new ICheckPlayerPressButton_SetValue
			{
				Type = this.Type,
				ButtonType = this.ButtonType
			};
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005484 RID: 21636 RVA: 0x000CF799 File Offset: 0x000CD999
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x000CF7C4 File Offset: 0x000CD9C4
		public override ECheckPlayerInputType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckPlayerInputType.PressButton;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005486 RID: 21638 RVA: 0x000CF7D2 File Offset: 0x000CD9D2
		// (set) Token: 0x06005487 RID: 21639 RVA: 0x000CF7FD File Offset: 0x000CD9FD
		public virtual EPlayerButtonType ButtonType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ButtonType;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerButtonType.ChallengeAgain;
				}
				return this.PocoInterface.ButtonType;
			}
			set
			{
				this.GetOrCreatePoco().ButtonType = value;
			}
		}

		// Token: 0x04003331 RID: 13105
		[Nullable(2)]
		protected new ICheckPlayerPressButton FbInstance;

		// Token: 0x04003332 RID: 13106
		[Nullable(2)]
		protected new ICheckPlayerPressButton_SetValue PocoInterface;
	}
}
