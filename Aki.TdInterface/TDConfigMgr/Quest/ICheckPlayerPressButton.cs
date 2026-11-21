using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200100C RID: 4108
	public class ICheckPlayerPressButton : ICheckPlayerInputBase
	{
		// Token: 0x060059FC RID: 23036 RVA: 0x000DB8C4 File Offset: 0x000D9AC4
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

		// Token: 0x060059FD RID: 23037 RVA: 0x000DB8FC File Offset: 0x000D9AFC
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

		// Token: 0x060059FE RID: 23038 RVA: 0x000DB90F File Offset: 0x000D9B0F
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

		// Token: 0x060059FF RID: 23039 RVA: 0x000DB922 File Offset: 0x000D9B22
		public new ICheckPlayerPressButton_SetValue ToSetValue()
		{
			return new ICheckPlayerPressButton_SetValue
			{
				Type = this.Type,
				ButtonType = this.ButtonType
			};
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06005A00 RID: 23040 RVA: 0x000DB941 File Offset: 0x000D9B41
		// (set) Token: 0x06005A01 RID: 23041 RVA: 0x000DB96C File Offset: 0x000D9B6C
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

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06005A02 RID: 23042 RVA: 0x000DB97A File Offset: 0x000D9B7A
		// (set) Token: 0x06005A03 RID: 23043 RVA: 0x000DB9A5 File Offset: 0x000D9BA5
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

		// Token: 0x0400363E RID: 13886
		[Nullable(2)]
		protected new ICheckPlayerPressButton FbInstance;

		// Token: 0x0400363F RID: 13887
		[Nullable(2)]
		protected new ICheckPlayerPressButton_SetValue PocoInterface;
	}
}
