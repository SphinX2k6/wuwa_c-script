using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B19 RID: 6937
	public class IDestroyVisionDisplay : IDestroyDynamicEntitiesType
	{
		// Token: 0x06009345 RID: 37701 RVA: 0x001587F4 File Offset: 0x001569F4
		private IDestroyVisionDisplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDestroyVisionDisplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDestroyVisionDisplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDestroyVisionDisplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009346 RID: 37702 RVA: 0x0015882C File Offset: 0x00156A2C
		public static IDestroyVisionDisplay Create([Nullable(2)] IDestroyVisionDisplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDestroyVisionDisplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009347 RID: 37703 RVA: 0x0015883F File Offset: 0x00156A3F
		public static IDestroyVisionDisplay CreateFromSetValue([Nullable(2)] IDestroyVisionDisplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDestroyVisionDisplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009348 RID: 37704 RVA: 0x00158852 File Offset: 0x00156A52
		public new IDestroyVisionDisplay_SetValue ToSetValue()
		{
			return new IDestroyVisionDisplay_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F09 RID: 12041
		// (get) Token: 0x06009349 RID: 37705 RVA: 0x00158865 File Offset: 0x00156A65
		// (set) Token: 0x0600934A RID: 37706 RVA: 0x00158890 File Offset: 0x00156A90
		public override EDynamicEntityType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDynamicEntityType.VisionDisplay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B92 RID: 23442
		[Nullable(2)]
		protected new IDestroyVisionDisplay FbInstance;

		// Token: 0x04005B93 RID: 23443
		[Nullable(2)]
		protected new IDestroyVisionDisplay_SetValue PocoInterface;
	}
}
