using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000226 RID: 550
	public class IBoxAkEvent : IAkEventTypeConfig
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00028550 File Offset: 0x00026750
		private IBoxAkEvent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBoxAkEvent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBoxAkEvent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBoxAkEvent_SetValue());
			}
			return result;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00028588 File Offset: 0x00026788
		public static IBoxAkEvent Create([Nullable(2)] IBoxAkEvent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				FbInstance = instance
			};
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x0002859B File Offset: 0x0002679B
		public static IBoxAkEvent CreateFromSetValue([Nullable(2)] IBoxAkEvent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBoxAkEvent
			{
				PocoInterface = value
			};
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000285AE File Offset: 0x000267AE
		public new IBoxAkEvent_SetValue ToSetValue()
		{
			return new IBoxAkEvent_SetValue
			{
				Type = this.Type,
				AudioType = this.AudioType,
				Priority = this.Priority
			};
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x000285D9 File Offset: 0x000267D9
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00028604 File Offset: 0x00026804
		public override EAkEventType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAkEventType.Point;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x00028612 File Offset: 0x00026812
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0002863D File Offset: 0x0002683D
		public virtual EAudioType AudioType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AudioType;
				}
				if (this.PocoInterface == null)
				{
					return EAudioType.AudioAMB;
				}
				return this.PocoInterface.AudioType;
			}
			set
			{
				this.GetOrCreatePoco().AudioType = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002864B File Offset: 0x0002684B
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00028676 File Offset: 0x00026876
		public virtual int Priority
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Priority;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Priority;
			}
			set
			{
				this.GetOrCreatePoco().Priority = value;
			}
		}

		// Token: 0x040009B0 RID: 2480
		[Nullable(2)]
		protected new IBoxAkEvent FbInstance;

		// Token: 0x040009B1 RID: 2481
		[Nullable(2)]
		protected new IBoxAkEvent_SetValue PocoInterface;
	}
}
