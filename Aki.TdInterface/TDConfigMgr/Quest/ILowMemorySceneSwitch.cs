using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001131 RID: 4401
	public class ILowMemorySceneSwitch : ISpecialProcess
	{
		// Token: 0x0600616C RID: 24940 RVA: 0x000EAFA8 File Offset: 0x000E91A8
		private ILowMemorySceneSwitch_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILowMemorySceneSwitch 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILowMemorySceneSwitch_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILowMemorySceneSwitch_SetValue());
			}
			return result;
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x000EAFE0 File Offset: 0x000E91E0
		public static ILowMemorySceneSwitch Create([Nullable(2)] ILowMemorySceneSwitch instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILowMemorySceneSwitch
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x000EAFF3 File Offset: 0x000E91F3
		public static ILowMemorySceneSwitch CreateFromSetValue([Nullable(2)] ILowMemorySceneSwitch_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILowMemorySceneSwitch
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x000EB006 File Offset: 0x000E9206
		public new ILowMemorySceneSwitch_SetValue ToSetValue()
		{
			return new ILowMemorySceneSwitch_SetValue
			{
				Type = this.Type,
				Operations = this.Operations
			};
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x000EB025 File Offset: 0x000E9225
		// (set) Token: 0x06006171 RID: 24945 RVA: 0x000EB050 File Offset: 0x000E9250
		public override ESpecialProcess Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESpecialProcess.LowMemorySceneSwitch;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x000EB05E File Offset: 0x000E925E
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x000EB085 File Offset: 0x000E9285
		public virtual List<IOperation> Operations
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Operations;
				}
				ILowMemorySceneSwitch_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Operations;
			}
			set
			{
				this.GetOrCreatePoco().Operations = value;
			}
		}

		// Token: 0x04003A61 RID: 14945
		[Nullable(2)]
		protected new ILowMemorySceneSwitch FbInstance;

		// Token: 0x04003A62 RID: 14946
		[Nullable(2)]
		protected new ILowMemorySceneSwitch_SetValue PocoInterface;
	}
}
