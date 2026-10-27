using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ABB RID: 6843
	[NullableContext(2)]
	[Nullable(0)]
	public class IFoxPushBox : ILeisureInteractType
	{
		// Token: 0x060092BC RID: 37564 RVA: 0x00154F6C File Offset: 0x0015316C
		[NullableContext(1)]
		private IFoxPushBox_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoxPushBox 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoxPushBox_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoxPushBox_SetValue());
			}
			return result;
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x00154FA4 File Offset: 0x001531A4
		[NullableContext(1)]
		public static IFoxPushBox Create([Nullable(2)] IFoxPushBox instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoxPushBox
			{
				FbInstance = instance
			};
		}

		// Token: 0x060092BE RID: 37566 RVA: 0x00154FB7 File Offset: 0x001531B7
		[NullableContext(1)]
		public static IFoxPushBox CreateFromSetValue([Nullable(2)] IFoxPushBox_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoxPushBox
			{
				PocoInterface = value
			};
		}

		// Token: 0x060092BF RID: 37567 RVA: 0x00154FCC File Offset: 0x001531CC
		[NullableContext(1)]
		public new IFoxPushBox_SetValue ToSetValue()
		{
			return new IFoxPushBox_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				CollisionRadius = this.CollisionRadius,
				SplineEntityId = this.SplineEntityId,
				SendEntityEventOnSplineFinish = this.SendEntityEventOnSplineFinish
			};
		}

		// Token: 0x17002E9B RID: 11931
		// (get) Token: 0x060092C0 RID: 37568 RVA: 0x0015501A File Offset: 0x0015321A
		// (set) Token: 0x060092C1 RID: 37569 RVA: 0x00155045 File Offset: 0x00153245
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E9C RID: 11932
		// (get) Token: 0x060092C2 RID: 37570 RVA: 0x00155053 File Offset: 0x00153253
		// (set) Token: 0x060092C3 RID: 37571 RVA: 0x0015507E File Offset: 0x0015327E
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

		// Token: 0x17002E9D RID: 11933
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x0015508C File Offset: 0x0015328C
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x001550B7 File Offset: 0x001532B7
		public virtual int CollisionRadius
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CollisionRadius;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CollisionRadius;
			}
			set
			{
				this.GetOrCreatePoco().CollisionRadius = value;
			}
		}

		// Token: 0x17002E9E RID: 11934
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x001550C5 File Offset: 0x001532C5
		// (set) Token: 0x060092C7 RID: 37575 RVA: 0x001550F0 File Offset: 0x001532F0
		public virtual int SplineEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineEntityId;
			}
			set
			{
				this.GetOrCreatePoco().SplineEntityId = value;
			}
		}

		// Token: 0x17002E9F RID: 11935
		// (get) Token: 0x060092C8 RID: 37576 RVA: 0x001550FE File Offset: 0x001532FE
		// (set) Token: 0x060092C9 RID: 37577 RVA: 0x00155125 File Offset: 0x00153325
		public virtual string SendEntityEventOnSplineFinish
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SendEntityEventOnSplineFinish;
				}
				IFoxPushBox_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SendEntityEventOnSplineFinish;
			}
			set
			{
				this.GetOrCreatePoco().SendEntityEventOnSplineFinish = value;
			}
		}

		// Token: 0x04005A4E RID: 23118
		protected new IFoxPushBox FbInstance;

		// Token: 0x04005A4F RID: 23119
		protected new IFoxPushBox_SetValue PocoInterface;
	}
}
