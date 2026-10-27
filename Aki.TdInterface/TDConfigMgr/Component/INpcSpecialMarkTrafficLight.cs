using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000578 RID: 1400
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSpecialMarkTrafficLight : INpcSpecialMarkBase
	{
		// Token: 0x06001CAA RID: 7338 RVA: 0x00051B44 File Offset: 0x0004FD44
		private INpcSpecialMarkTrafficLight_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSpecialMarkTrafficLight 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSpecialMarkTrafficLight_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSpecialMarkTrafficLight_SetValue());
			}
			return result;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00051B7C File Offset: 0x0004FD7C
		public static INpcSpecialMarkTrafficLight Create([Nullable(2)] INpcSpecialMarkTrafficLight instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSpecialMarkTrafficLight
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00051B8F File Offset: 0x0004FD8F
		public static INpcSpecialMarkTrafficLight CreateFromSetValue([Nullable(2)] INpcSpecialMarkTrafficLight_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSpecialMarkTrafficLight
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00051BA2 File Offset: 0x0004FDA2
		public new INpcSpecialMarkTrafficLight_SetValue ToSetValue()
		{
			return new INpcSpecialMarkTrafficLight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00051BB5 File Offset: 0x0004FDB5
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00051BE0 File Offset: 0x0004FDE0
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

		// Token: 0x04001464 RID: 5220
		[Nullable(2)]
		protected new INpcSpecialMarkTrafficLight FbInstance;

		// Token: 0x04001465 RID: 5221
		[Nullable(2)]
		protected new INpcSpecialMarkTrafficLight_SetValue PocoInterface;
	}
}
