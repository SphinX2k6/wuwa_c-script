using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA4 RID: 7588
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetEntityConfig
	{
		// Token: 0x0600A29F RID: 41631 RVA: 0x00171C2C File Offset: 0x0016FE2C
		private IResetEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x00171C64 File Offset: 0x0016FE64
		public static IResetEntityConfig Create([Nullable(2)] IResetEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x00171C77 File Offset: 0x0016FE77
		public static IResetEntityConfig CreateFromSetValue([Nullable(2)] IResetEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x00171C8A File Offset: 0x0016FE8A
		public IResetEntityConfig_SetValue ToSetValue()
		{
			return new IResetEntityConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x00171C9D File Offset: 0x0016FE9D
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x00171CC8 File Offset: 0x0016FEC8
		public virtual EResetEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetEntityType.TeleControl;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061A5 RID: 24997
		[Nullable(2)]
		protected IResetEntityConfig FbInstance;

		// Token: 0x040061A6 RID: 24998
		[Nullable(2)]
		protected IResetEntityConfig_SetValue PocoInterface;
	}
}
