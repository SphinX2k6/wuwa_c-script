using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8A RID: 7050
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerAction : ILimitPlayerOption
	{
		// Token: 0x060096F9 RID: 38649 RVA: 0x0015C770 File Offset: 0x0015A970
		private ILimitPlayerAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerAction_SetValue());
			}
			return result;
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x0015C7A8 File Offset: 0x0015A9A8
		public static ILimitPlayerAction Create([Nullable(2)] ILimitPlayerAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x0015C7BB File Offset: 0x0015A9BB
		public static ILimitPlayerAction CreateFromSetValue([Nullable(2)] ILimitPlayerAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x0015C7CE File Offset: 0x0015A9CE
		public new ILimitPlayerAction_SetValue ToSetValue()
		{
			return new ILimitPlayerAction_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x0015C7E1 File Offset: 0x0015A9E1
		// (set) Token: 0x060096FE RID: 38654 RVA: 0x0015C80C File Offset: 0x0015AA0C
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

		// Token: 0x04005C39 RID: 23609
		[Nullable(2)]
		protected new ILimitPlayerAction FbInstance;

		// Token: 0x04005C3A RID: 23610
		[Nullable(2)]
		protected new ILimitPlayerAction_SetValue PocoInterface;
	}
}
