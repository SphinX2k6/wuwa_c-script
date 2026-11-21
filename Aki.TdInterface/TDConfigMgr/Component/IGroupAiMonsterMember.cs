using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200044F RID: 1103
	public class IGroupAiMonsterMember
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x000450D8 File Offset: 0x000432D8
		private IGroupAiMonsterMember_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGroupAiMonsterMember 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGroupAiMonsterMember_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGroupAiMonsterMember_SetValue());
			}
			return result;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00045110 File Offset: 0x00043310
		public static IGroupAiMonsterMember Create([Nullable(2)] IGroupAiMonsterMember instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupAiMonsterMember
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00045123 File Offset: 0x00043323
		public static IGroupAiMonsterMember CreateFromSetValue([Nullable(2)] IGroupAiMonsterMember_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGroupAiMonsterMember
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00045136 File Offset: 0x00043336
		public IGroupAiMonsterMember_SetValue ToSetValue()
		{
			return new IGroupAiMonsterMember_SetValue
			{
				EntityId = this.EntityId,
				RelativeTransform = this.RelativeTransform,
				ActionTagAttach = this.ActionTagAttach
			};
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00045161 File Offset: 0x00043361
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x0004518C File Offset: 0x0004338C
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0004519C File Offset: 0x0004339C
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x000451FD File Offset: 0x000433FD
		public virtual PosAndRot RelativeTransform
		{
			get
			{
				if (this._RelativeTransformInited)
				{
					return this._RelativeTransformCache;
				}
				this._RelativeTransformInited = true;
				if (this.FbInstance != null)
				{
					this._RelativeTransformCache = PosAndRot.Create(this.FbInstance.RelativeTransform);
				}
				else
				{
					IGroupAiMonsterMember_SetValue pocoInterface = this.PocoInterface;
					this._RelativeTransformCache = ((pocoInterface != null) ? pocoInterface.RelativeTransform : null);
				}
				return this._RelativeTransformCache;
			}
			set
			{
				this.GetOrCreatePoco().RelativeTransform = value;
				this._RelativeTransformInited = false;
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x00045214 File Offset: 0x00043414
		// (set) Token: 0x0600160C RID: 5644 RVA: 0x00045275 File Offset: 0x00043475
		[Nullable(2)]
		public virtual IGroupAiMonsterMemberActionTagAttach ActionTagAttach
		{
			[NullableContext(2)]
			get
			{
				if (this._ActionTagAttachInited)
				{
					return this._ActionTagAttachCache;
				}
				this._ActionTagAttachInited = true;
				if (this.FbInstance != null)
				{
					this._ActionTagAttachCache = IGroupAiMonsterMemberActionTagAttach.Create(this.FbInstance.ActionTagAttach);
				}
				else
				{
					IGroupAiMonsterMember_SetValue pocoInterface = this.PocoInterface;
					this._ActionTagAttachCache = ((pocoInterface != null) ? pocoInterface.ActionTagAttach : null);
				}
				return this._ActionTagAttachCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ActionTagAttach = value;
				this._ActionTagAttachInited = false;
			}
		}

		// Token: 0x0400112E RID: 4398
		[Nullable(2)]
		protected IGroupAiMonsterMember FbInstance;

		// Token: 0x0400112F RID: 4399
		[Nullable(2)]
		protected IGroupAiMonsterMember_SetValue PocoInterface;

		// Token: 0x04001130 RID: 4400
		private PosAndRot _RelativeTransformCache;

		// Token: 0x04001131 RID: 4401
		private bool _RelativeTransformInited;

		// Token: 0x04001132 RID: 4402
		private IGroupAiMonsterMemberActionTagAttach _ActionTagAttachCache;

		// Token: 0x04001133 RID: 4403
		private bool _ActionTagAttachInited;
	}
}
