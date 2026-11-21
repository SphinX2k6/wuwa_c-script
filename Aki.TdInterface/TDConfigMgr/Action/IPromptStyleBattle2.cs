using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F73 RID: 8051
	public class IPromptStyleBattle2 : IPromptStyleBase
	{
		// Token: 0x0600AB3F RID: 43839 RVA: 0x00183D2C File Offset: 0x00181F2C
		private IPromptStyleBattle2_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStyleBattle2 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStyleBattle2_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStyleBattle2_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x00183D64 File Offset: 0x00181F64
		public static IPromptStyleBattle2 Create([Nullable(2)] IPromptStyleBattle2 instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x00183D77 File Offset: 0x00181F77
		public static IPromptStyleBattle2 CreateFromSetValue([Nullable(2)] IPromptStyleBattle2_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStyleBattle2
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x00183D8A File Offset: 0x00181F8A
		public new IPromptStyleBattle2_SetValue ToSetValue()
		{
			return new IPromptStyleBattle2_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600AB43 RID: 43843 RVA: 0x00183D9D File Offset: 0x00181F9D
		// (set) Token: 0x0600AB44 RID: 43844 RVA: 0x00183DC8 File Offset: 0x00181FC8
		public override EPromptStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPromptStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006694 RID: 26260
		[Nullable(2)]
		protected new IPromptStyleBattle2 FbInstance;

		// Token: 0x04006695 RID: 26261
		[Nullable(2)]
		protected new IPromptStyleBattle2_SetValue PocoInterface;
	}
}
