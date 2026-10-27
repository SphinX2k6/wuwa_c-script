using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DAC RID: 7596
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetPlayerFocusType
	{
		// Token: 0x0600A2C3 RID: 41667 RVA: 0x00172028 File Offset: 0x00170228
		private IResetPlayerFocusType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPlayerFocusType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPlayerFocusType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPlayerFocusType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x00172060 File Offset: 0x00170260
		public static IResetPlayerFocusType Create([Nullable(2)] IResetPlayerFocusType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2C5 RID: 41669 RVA: 0x00172073 File Offset: 0x00170273
		public static IResetPlayerFocusType CreateFromSetValue([Nullable(2)] IResetPlayerFocusType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPlayerFocusType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x00172086 File Offset: 0x00170286
		public IResetPlayerFocusType_SetValue ToSetValue()
		{
			return new IResetPlayerFocusType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A2C7 RID: 41671 RVA: 0x00172099 File Offset: 0x00170299
		// (set) Token: 0x0600A2C8 RID: 41672 RVA: 0x001720C4 File Offset: 0x001702C4
		public virtual EResetPlayerFocusType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061B7 RID: 25015
		[Nullable(2)]
		protected IResetPlayerFocusType FbInstance;

		// Token: 0x040061B8 RID: 25016
		[Nullable(2)]
		protected IResetPlayerFocusType_SetValue PocoInterface;
	}
}
