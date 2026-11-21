using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005DF RID: 1503
	public class INpcSpecialMarkTrafficLight : INpcSpecialMarkBase
	{
		// Token: 0x06001EA6 RID: 7846 RVA: 0x00056900 File Offset: 0x00054B00
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

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00056938 File Offset: 0x00054B38
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

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0005694B File Offset: 0x00054B4B
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

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0005695E File Offset: 0x00054B5E
		public new INpcSpecialMarkTrafficLight_SetValue ToSetValue()
		{
			return new INpcSpecialMarkTrafficLight_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00056971 File Offset: 0x00054B71
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x0005699C File Offset: 0x00054B9C
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

		// Token: 0x040015CE RID: 5582
		[Nullable(2)]
		protected new INpcSpecialMarkTrafficLight FbInstance;

		// Token: 0x040015CF RID: 5583
		[Nullable(2)]
		protected new INpcSpecialMarkTrafficLight_SetValue PocoInterface;
	}
}
