using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E9B RID: 7835
	public class IOpenGlobalTimeScale : ISetGlobalTimeScaleType
	{
		// Token: 0x0600A6A3 RID: 42659 RVA: 0x0017B81C File Offset: 0x00179A1C
		private IOpenGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x0017B854 File Offset: 0x00179A54
		public static IOpenGlobalTimeScale Create([Nullable(2)] IOpenGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x0017B867 File Offset: 0x00179A67
		public static IOpenGlobalTimeScale CreateFromSetValue([Nullable(2)] IOpenGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x0017B87A File Offset: 0x00179A7A
		public new IOpenGlobalTimeScale_SetValue ToSetValue()
		{
			return new IOpenGlobalTimeScale_SetValue
			{
				Type = this.Type,
				TimeScale = this.TimeScale,
				Duration = this.Duration
			};
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A6A7 RID: 42663 RVA: 0x0017B8A5 File Offset: 0x00179AA5
		// (set) Token: 0x0600A6A8 RID: 42664 RVA: 0x0017B8D0 File Offset: 0x00179AD0
		public override ESetTimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTimeScaleType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003378 RID: 13176
		// (get) Token: 0x0600A6A9 RID: 42665 RVA: 0x0017B8DE File Offset: 0x00179ADE
		// (set) Token: 0x0600A6AA RID: 42666 RVA: 0x0017B90D File Offset: 0x00179B0D
		public virtual float TimeScale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TimeScale;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TimeScale;
			}
			set
			{
				this.GetOrCreatePoco().TimeScale = value;
			}
		}

		// Token: 0x17003379 RID: 13177
		// (get) Token: 0x0600A6AB RID: 42667 RVA: 0x0017B91B File Offset: 0x00179B1B
		// (set) Token: 0x0600A6AC RID: 42668 RVA: 0x0017B94A File Offset: 0x00179B4A
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04006474 RID: 25716
		[Nullable(2)]
		protected new IOpenGlobalTimeScale FbInstance;

		// Token: 0x04006475 RID: 25717
		[Nullable(2)]
		protected new IOpenGlobalTimeScale_SetValue PocoInterface;
	}
}
