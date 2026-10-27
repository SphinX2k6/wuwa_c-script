using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000493 RID: 1171
	[NullableContext(1)]
	[Nullable(0)]
	public class IInteractStyleEntityPart : IInteractStyleBase
	{
		// Token: 0x06001788 RID: 6024 RVA: 0x0004725C File Offset: 0x0004545C
		private IInteractStyleEntityPart_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInteractStyleEntityPart 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInteractStyleEntityPart_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInteractStyleEntityPart_SetValue());
			}
			return result;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x00047294 File Offset: 0x00045494
		public static IInteractStyleEntityPart Create([Nullable(2)] IInteractStyleEntityPart instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInteractStyleEntityPart
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000472A7 File Offset: 0x000454A7
		public static IInteractStyleEntityPart CreateFromSetValue([Nullable(2)] IInteractStyleEntityPart_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInteractStyleEntityPart
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x000472BA File Offset: 0x000454BA
		public new IInteractStyleEntityPart_SetValue ToSetValue()
		{
			return new IInteractStyleEntityPart_SetValue
			{
				Type = this.Type,
				Bind = this.Bind,
				ShowAngle = this.ShowAngle,
				TriggerAngle = this.TriggerAngle
			};
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000472F1 File Offset: 0x000454F1
		// (set) Token: 0x0600178D RID: 6029 RVA: 0x0004731C File Offset: 0x0004551C
		public override EInteractStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInteractStyleType.Panorama;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0004732A File Offset: 0x0004552A
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x00047351 File Offset: 0x00045551
		public virtual IInteractEntityPartBindBase Bind
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Bind;
				}
				IInteractStyleEntityPart_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Bind;
			}
			set
			{
				this.GetOrCreatePoco().Bind = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x0004735F File Offset: 0x0004555F
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x0004738E File Offset: 0x0004558E
		public virtual float ShowAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.ShowAngle;
			}
			set
			{
				this.GetOrCreatePoco().ShowAngle = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x0004739C File Offset: 0x0004559C
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x000473CB File Offset: 0x000455CB
		public virtual float TriggerAngle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TriggerAngle;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.TriggerAngle;
			}
			set
			{
				this.GetOrCreatePoco().TriggerAngle = value;
			}
		}

		// Token: 0x04001199 RID: 4505
		[Nullable(2)]
		protected new IInteractStyleEntityPart FbInstance;

		// Token: 0x0400119A RID: 4506
		[Nullable(2)]
		protected new IInteractStyleEntityPart_SetValue PocoInterface;
	}
}
