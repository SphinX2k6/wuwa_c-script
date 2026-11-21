using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E9D RID: 7837
	public class IOpenGravity : ISetTeleControlConfig
	{
		// Token: 0x0600A6AF RID: 42671 RVA: 0x0017B968 File Offset: 0x00179B68
		private IOpenGravity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenGravity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenGravity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenGravity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x0017B9A0 File Offset: 0x00179BA0
		public static IOpenGravity Create([Nullable(2)] IOpenGravity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x0017B9B3 File Offset: 0x00179BB3
		public static IOpenGravity CreateFromSetValue([Nullable(2)] IOpenGravity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenGravity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x0017B9C6 File Offset: 0x00179BC6
		public new IOpenGravity_SetValue ToSetValue()
		{
			return new IOpenGravity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600A6B3 RID: 42675 RVA: 0x0017B9F1 File Offset: 0x00179BF1
		// (set) Token: 0x0600A6B4 RID: 42676 RVA: 0x0017BA1C File Offset: 0x00179C1C
		public override ESetTeleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600A6B5 RID: 42677 RVA: 0x0017BA2A File Offset: 0x00179C2A
		// (set) Token: 0x0600A6B6 RID: 42678 RVA: 0x0017BA55 File Offset: 0x00179C55
		public override int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A6B7 RID: 42679 RVA: 0x0017BA64 File Offset: 0x00179C64
		// (set) Token: 0x0600A6B8 RID: 42680 RVA: 0x0017BA9E File Offset: 0x00179C9E
		public virtual int? PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				IOpenGravity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x04006479 RID: 25721
		[Nullable(2)]
		protected new IOpenGravity FbInstance;

		// Token: 0x0400647A RID: 25722
		[Nullable(2)]
		protected new IOpenGravity_SetValue PocoInterface;
	}
}
