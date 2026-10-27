using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001005 RID: 4101
	[NullableContext(1)]
	[Nullable(0)]
	public class ILowMemorySceneSwitch : ISpecialProcess
	{
		// Token: 0x06005B8C RID: 23436 RVA: 0x000DE368 File Offset: 0x000DC568
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

		// Token: 0x06005B8D RID: 23437 RVA: 0x000DE3A0 File Offset: 0x000DC5A0
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

		// Token: 0x06005B8E RID: 23438 RVA: 0x000DE3B3 File Offset: 0x000DC5B3
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

		// Token: 0x06005B8F RID: 23439 RVA: 0x000DE3C6 File Offset: 0x000DC5C6
		public new ILowMemorySceneSwitch_SetValue ToSetValue()
		{
			return new ILowMemorySceneSwitch_SetValue
			{
				Type = this.Type,
				Operations = this.Operations
			};
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06005B90 RID: 23440 RVA: 0x000DE3E5 File Offset: 0x000DC5E5
		// (set) Token: 0x06005B91 RID: 23441 RVA: 0x000DE410 File Offset: 0x000DC610
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

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06005B92 RID: 23442 RVA: 0x000DE41E File Offset: 0x000DC61E
		// (set) Token: 0x06005B93 RID: 23443 RVA: 0x000DE445 File Offset: 0x000DC645
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

		// Token: 0x04003729 RID: 14121
		[Nullable(2)]
		protected new ILowMemorySceneSwitch FbInstance;

		// Token: 0x0400372A RID: 14122
		[Nullable(2)]
		protected new ILowMemorySceneSwitch_SetValue PocoInterface;
	}
}
