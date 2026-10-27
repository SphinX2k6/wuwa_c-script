using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001992 RID: 6546
	[NullableContext(1)]
	[Nullable(0)]
	public class IDestroyVisionDisplay : IDestroyDynamicEntitiesType
	{
		// Token: 0x06008C21 RID: 35873 RVA: 0x00148FE4 File Offset: 0x001471E4
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

		// Token: 0x06008C22 RID: 35874 RVA: 0x0014901C File Offset: 0x0014721C
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

		// Token: 0x06008C23 RID: 35875 RVA: 0x0014902F File Offset: 0x0014722F
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

		// Token: 0x06008C24 RID: 35876 RVA: 0x00149042 File Offset: 0x00147242
		public new IDestroyVisionDisplay_SetValue ToSetValue()
		{
			return new IDestroyVisionDisplay_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x06008C25 RID: 35877 RVA: 0x00149055 File Offset: 0x00147255
		// (set) Token: 0x06008C26 RID: 35878 RVA: 0x00149080 File Offset: 0x00147280
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

		// Token: 0x04005749 RID: 22345
		[Nullable(2)]
		protected new IDestroyVisionDisplay FbInstance;

		// Token: 0x0400574A RID: 22346
		[Nullable(2)]
		protected new IDestroyVisionDisplay_SetValue PocoInterface;
	}
}
