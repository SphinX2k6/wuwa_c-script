using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA9 RID: 7081
	public class IEntitySplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x06009673 RID: 38515 RVA: 0x0015E354 File Offset: 0x0015C554
		private IEntitySplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntitySplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntitySplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntitySplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x0015E38C File Offset: 0x0015C58C
		public static IEntitySplineMoveTarget Create([Nullable(2)] IEntitySplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009675 RID: 38517 RVA: 0x0015E39F File Offset: 0x0015C59F
		public static IEntitySplineMoveTarget CreateFromSetValue([Nullable(2)] IEntitySplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntitySplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009676 RID: 38518 RVA: 0x0015E3B2 File Offset: 0x0015C5B2
		public new IEntitySplineMoveTarget_SetValue ToSetValue()
		{
			return new IEntitySplineMoveTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				MoveDriveMode = this.MoveDriveMode
			};
		}

		// Token: 0x17002FC8 RID: 12232
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x0015E3DD File Offset: 0x0015C5DD
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x0015E408 File Offset: 0x0015C608
		public override ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002FC9 RID: 12233
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x0015E416 File Offset: 0x0015C616
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x0015E441 File Offset: 0x0015C641
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

		// Token: 0x17002FCA RID: 12234
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x0015E44F File Offset: 0x0015C64F
		// (set) Token: 0x0600967C RID: 38524 RVA: 0x0015E476 File Offset: 0x0015C676
		[Nullable(2)]
		public virtual ISplineMoveDriveMode MoveDriveMode
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveDriveMode;
				}
				IEntitySplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveDriveMode;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveDriveMode = value;
			}
		}

		// Token: 0x04005CF7 RID: 23799
		[Nullable(2)]
		protected new IEntitySplineMoveTarget FbInstance;

		// Token: 0x04005CF8 RID: 23800
		[Nullable(2)]
		protected new IEntitySplineMoveTarget_SetValue PocoInterface;
	}
}
