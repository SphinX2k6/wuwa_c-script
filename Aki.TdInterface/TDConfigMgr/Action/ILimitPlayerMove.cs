using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B92 RID: 7058
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerMove : ILimitPlayerOption
	{
		// Token: 0x06009719 RID: 38681 RVA: 0x0015CA60 File Offset: 0x0015AC60
		private ILimitPlayerMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0015CA98 File Offset: 0x0015AC98
		public static ILimitPlayerMove Create([Nullable(2)] ILimitPlayerMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x0015CAAB File Offset: 0x0015ACAB
		public static ILimitPlayerMove CreateFromSetValue([Nullable(2)] ILimitPlayerMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x0015CABE File Offset: 0x0015ACBE
		public new ILimitPlayerMove_SetValue ToSetValue()
		{
			return new ILimitPlayerMove_SetValue
			{
				Type = this.Type,
				IsOnlyForward = this.IsOnlyForward
			};
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x0600971D RID: 38685 RVA: 0x0015CADD File Offset: 0x0015ACDD
		// (set) Token: 0x0600971E RID: 38686 RVA: 0x0015CB08 File Offset: 0x0015AD08
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x0600971F RID: 38687 RVA: 0x0015CB18 File Offset: 0x0015AD18
		// (set) Token: 0x06009720 RID: 38688 RVA: 0x0015CB52 File Offset: 0x0015AD52
		public virtual bool? IsOnlyForward
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsOnlyForward;
				}
				ILimitPlayerMove_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsOnlyForward;
			}
			set
			{
				this.GetOrCreatePoco().IsOnlyForward = value;
			}
		}

		// Token: 0x04005C45 RID: 23621
		[Nullable(2)]
		protected new ILimitPlayerMove FbInstance;

		// Token: 0x04005C46 RID: 23622
		[Nullable(2)]
		protected new ILimitPlayerMove_SetValue PocoInterface;
	}
}
