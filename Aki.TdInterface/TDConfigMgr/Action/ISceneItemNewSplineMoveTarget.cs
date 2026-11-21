using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFD RID: 8189
	public class ISceneItemNewSplineMoveTarget : INewSplineMoveTarget
	{
		// Token: 0x0600ADE1 RID: 44513 RVA: 0x001884B4 File Offset: 0x001866B4
		private ISceneItemNewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemNewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemNewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemNewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600ADE2 RID: 44514 RVA: 0x001884EC File Offset: 0x001866EC
		public static ISceneItemNewSplineMoveTarget Create([Nullable(2)] ISceneItemNewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600ADE3 RID: 44515 RVA: 0x001884FF File Offset: 0x001866FF
		public static ISceneItemNewSplineMoveTarget CreateFromSetValue([Nullable(2)] ISceneItemNewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemNewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600ADE4 RID: 44516 RVA: 0x00188512 File Offset: 0x00186712
		public new ISceneItemNewSplineMoveTarget_SetValue ToSetValue()
		{
			return new ISceneItemNewSplineMoveTarget_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				IsLookDir = this.IsLookDir
			};
		}

		// Token: 0x17003503 RID: 13571
		// (get) Token: 0x0600ADE5 RID: 44517 RVA: 0x0018853D File Offset: 0x0018673D
		// (set) Token: 0x0600ADE6 RID: 44518 RVA: 0x00188568 File Offset: 0x00186768
		public override ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003504 RID: 13572
		// (get) Token: 0x0600ADE7 RID: 44519 RVA: 0x00188576 File Offset: 0x00186776
		// (set) Token: 0x0600ADE8 RID: 44520 RVA: 0x001885A1 File Offset: 0x001867A1
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

		// Token: 0x17003505 RID: 13573
		// (get) Token: 0x0600ADE9 RID: 44521 RVA: 0x001885B0 File Offset: 0x001867B0
		// (set) Token: 0x0600ADEA RID: 44522 RVA: 0x001885EA File Offset: 0x001867EA
		public virtual bool? IsLookDir
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLookDir;
				}
				ISceneItemNewSplineMoveTarget_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsLookDir;
			}
			set
			{
				this.GetOrCreatePoco().IsLookDir = value;
			}
		}

		// Token: 0x040067B8 RID: 26552
		[Nullable(2)]
		protected new ISceneItemNewSplineMoveTarget FbInstance;

		// Token: 0x040067B9 RID: 26553
		[Nullable(2)]
		protected new ISceneItemNewSplineMoveTarget_SetValue PocoInterface;
	}
}
