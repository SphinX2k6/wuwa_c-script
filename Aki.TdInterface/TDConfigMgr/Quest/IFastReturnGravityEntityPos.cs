using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F69 RID: 3945
	[NullableContext(2)]
	[Nullable(0)]
	public class IFastReturnGravityEntityPos : IFastReturnPosBase
	{
		// Token: 0x060057B0 RID: 22448 RVA: 0x000D6410 File Offset: 0x000D4610
		[NullableContext(1)]
		private IFastReturnGravityEntityPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFastReturnGravityEntityPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFastReturnGravityEntityPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFastReturnGravityEntityPos_SetValue());
			}
			return result;
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x000D6448 File Offset: 0x000D4648
		[NullableContext(1)]
		public static IFastReturnGravityEntityPos Create([Nullable(2)] IFastReturnGravityEntityPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFastReturnGravityEntityPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x000D645B File Offset: 0x000D465B
		[NullableContext(1)]
		public static IFastReturnGravityEntityPos CreateFromSetValue([Nullable(2)] IFastReturnGravityEntityPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFastReturnGravityEntityPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x000D646E File Offset: 0x000D466E
		[NullableContext(1)]
		public new IFastReturnGravityEntityPos_SetValue ToSetValue()
		{
			return new IFastReturnGravityEntityPos_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				TransitionOption = this.TransitionOption
			};
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x060057B4 RID: 22452 RVA: 0x000D6499 File Offset: 0x000D4699
		// (set) Token: 0x060057B5 RID: 22453 RVA: 0x000D64C4 File Offset: 0x000D46C4
		public override EFastReturnPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFastReturnPosType.EntityPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x060057B6 RID: 22454 RVA: 0x000D64D2 File Offset: 0x000D46D2
		// (set) Token: 0x060057B7 RID: 22455 RVA: 0x000D64FD File Offset: 0x000D46FD
		public virtual int EntityId
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x060057B8 RID: 22456 RVA: 0x000D650B File Offset: 0x000D470B
		// (set) Token: 0x060057B9 RID: 22457 RVA: 0x000D6532 File Offset: 0x000D4732
		public virtual ITeleportTransitionType TransitionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				IFastReturnGravityEntityPos_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x040034FF RID: 13567
		protected new IFastReturnGravityEntityPos FbInstance;

		// Token: 0x04003500 RID: 13568
		protected new IFastReturnGravityEntityPos_SetValue PocoInterface;
	}
}
