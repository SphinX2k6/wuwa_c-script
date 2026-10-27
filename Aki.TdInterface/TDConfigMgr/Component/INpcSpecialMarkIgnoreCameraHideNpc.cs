using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000576 RID: 1398
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSpecialMarkIgnoreCameraHideNpc : INpcSpecialMarkBase
	{
		// Token: 0x06001CA2 RID: 7330 RVA: 0x00051A88 File Offset: 0x0004FC88
		private INpcSpecialMarkIgnoreCameraHideNpc_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkIgnoreCameraHideNpc 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkIgnoreCameraHideNpc_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkIgnoreCameraHideNpc_SetValue());
			}
			return result;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x00051AC0 File Offset: 0x0004FCC0
		public static INpcSpecialMarkIgnoreCameraHideNpc Create([Nullable(2)] INpcSpecialMarkIgnoreCameraHideNpc instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkIgnoreCameraHideNpc
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x00051AD3 File Offset: 0x0004FCD3
		public static INpcSpecialMarkIgnoreCameraHideNpc CreateFromSetValue([Nullable(2)] INpcSpecialMarkIgnoreCameraHideNpc_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkIgnoreCameraHideNpc
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00051AE6 File Offset: 0x0004FCE6
		public new INpcSpecialMarkIgnoreCameraHideNpc_SetValue ToSetValue()
		{
			return new INpcSpecialMarkIgnoreCameraHideNpc_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00051AF9 File Offset: 0x0004FCF9
		// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00051B24 File Offset: 0x0004FD24
		public override ESpecialNpcMarkType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialNpcMarkType.TrafficLight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001461 RID: 5217
		[Nullable(2)]
		protected new INpcSpecialMarkIgnoreCameraHideNpc FbInstance;

		// Token: 0x04001462 RID: 5218
		[Nullable(2)]
		protected new INpcSpecialMarkIgnoreCameraHideNpc_SetValue PocoInterface;
	}
}
