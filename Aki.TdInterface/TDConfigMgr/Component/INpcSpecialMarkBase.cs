using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000574 RID: 1396
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSpecialMarkBase
	{
		// Token: 0x06001C9A RID: 7322 RVA: 0x000519CC File Offset: 0x0004FBCC
		private INpcSpecialMarkBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00051A04 File Offset: 0x0004FC04
		public static INpcSpecialMarkBase Create([Nullable(2)] INpcSpecialMarkBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00051A17 File Offset: 0x0004FC17
		public static INpcSpecialMarkBase CreateFromSetValue([Nullable(2)] INpcSpecialMarkBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00051A2A File Offset: 0x0004FC2A
		public INpcSpecialMarkBase_SetValue ToSetValue()
		{
			return new INpcSpecialMarkBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00051A3D File Offset: 0x0004FC3D
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x00051A68 File Offset: 0x0004FC68
		public virtual ESpecialNpcMarkType Type
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

		// Token: 0x0400145E RID: 5214
		[Nullable(2)]
		protected INpcSpecialMarkBase FbInstance;

		// Token: 0x0400145F RID: 5215
		[Nullable(2)]
		protected INpcSpecialMarkBase_SetValue PocoInterface;
	}
}
