using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E40 RID: 7744
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetResetPosition : ISetTeleControlConfig
	{
		// Token: 0x0600A5B3 RID: 42419 RVA: 0x001774B8 File Offset: 0x001756B8
		private ISetResetPosition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetResetPosition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetResetPosition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetResetPosition_SetValue());
			}
			return result;
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x001774F0 File Offset: 0x001756F0
		public static ISetResetPosition Create([Nullable(2)] ISetResetPosition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x00177503 File Offset: 0x00175703
		public static ISetResetPosition CreateFromSetValue([Nullable(2)] ISetResetPosition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetResetPosition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x00177516 File Offset: 0x00175716
		public new ISetResetPosition_SetValue ToSetValue()
		{
			return new ISetResetPosition_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				PositionEntityId = this.PositionEntityId
			};
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600A5B7 RID: 42423 RVA: 0x00177541 File Offset: 0x00175741
		// (set) Token: 0x0600A5B8 RID: 42424 RVA: 0x0017756C File Offset: 0x0017576C
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

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600A5B9 RID: 42425 RVA: 0x0017757A File Offset: 0x0017577A
		// (set) Token: 0x0600A5BA RID: 42426 RVA: 0x001775A5 File Offset: 0x001757A5
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

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600A5BB RID: 42427 RVA: 0x001775B3 File Offset: 0x001757B3
		// (set) Token: 0x0600A5BC RID: 42428 RVA: 0x001775DE File Offset: 0x001757DE
		public virtual int PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PositionEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PositionEntityId = value;
			}
		}

		// Token: 0x04006311 RID: 25361
		[Nullable(2)]
		protected new ISetResetPosition FbInstance;

		// Token: 0x04006312 RID: 25362
		[Nullable(2)]
		protected new ISetResetPosition_SetValue PocoInterface;
	}
}
