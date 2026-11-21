using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000417 RID: 1047
	public class IFrequencyPaintConnectLine : IFrequencyPaintLineBase
	{
		// Token: 0x060014D5 RID: 5333 RVA: 0x00042A70 File Offset: 0x00040C70
		private IFrequencyPaintConnectLine_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFrequencyPaintConnectLine 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFrequencyPaintConnectLine_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFrequencyPaintConnectLine_SetValue());
			}
			return result;
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00042AA8 File Offset: 0x00040CA8
		public static IFrequencyPaintConnectLine Create([Nullable(2)] IFrequencyPaintConnectLine instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFrequencyPaintConnectLine
			{
				FbInstance = instance
			};
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00042ABB File Offset: 0x00040CBB
		public static IFrequencyPaintConnectLine CreateFromSetValue([Nullable(2)] IFrequencyPaintConnectLine_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFrequencyPaintConnectLine
			{
				PocoInterface = value
			};
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00042ACE File Offset: 0x00040CCE
		public new IFrequencyPaintConnectLine_SetValue ToSetValue()
		{
			return new IFrequencyPaintConnectLine_SetValue
			{
				Type = this.Type,
				EntityTarget = this.EntityTarget,
				EntityState = this.EntityState
			};
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x060014D9 RID: 5337 RVA: 0x00042AF9 File Offset: 0x00040CF9
		// (set) Token: 0x060014DA RID: 5338 RVA: 0x00042B24 File Offset: 0x00040D24
		public override EFrequencyPaintLineType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFrequencyPaintLineType.Straight;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x00042B32 File Offset: 0x00040D32
		// (set) Token: 0x060014DC RID: 5340 RVA: 0x00042B5D File Offset: 0x00040D5D
		public virtual int EntityTarget
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityTarget;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityTarget;
			}
			set
			{
				this.GetOrCreatePoco().EntityTarget = value;
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x00042B6B File Offset: 0x00040D6B
		// (set) Token: 0x060014DE RID: 5342 RVA: 0x00042B92 File Offset: 0x00040D92
		[Nullable(2)]
		public virtual string EntityState
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityState;
				}
				IFrequencyPaintConnectLine_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EntityState;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityState = value;
			}
		}

		// Token: 0x04001087 RID: 4231
		[Nullable(2)]
		protected new IFrequencyPaintConnectLine FbInstance;

		// Token: 0x04001088 RID: 4232
		[Nullable(2)]
		protected new IFrequencyPaintConnectLine_SetValue PocoInterface;
	}
}
