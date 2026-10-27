using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003F6 RID: 1014
	[NullableContext(1)]
	[Nullable(0)]
	public class IGroupAiMonsterMember
	{
		// Token: 0x06001469 RID: 5225 RVA: 0x00041390 File Offset: 0x0003F590
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

		// Token: 0x0600146A RID: 5226 RVA: 0x000413C8 File Offset: 0x0003F5C8
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

		// Token: 0x0600146B RID: 5227 RVA: 0x000413DB File Offset: 0x0003F5DB
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

		// Token: 0x0600146C RID: 5228 RVA: 0x000413EE File Offset: 0x0003F5EE
		public IGroupAiMonsterMember_SetValue ToSetValue()
		{
			return new IGroupAiMonsterMember_SetValue
			{
				EntityId = this.EntityId,
				RelativeTransform = this.RelativeTransform,
				ActionTagAttach = this.ActionTagAttach
			};
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00041419 File Offset: 0x0003F619
		// (set) Token: 0x0600146E RID: 5230 RVA: 0x00041444 File Offset: 0x0003F644
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00041454 File Offset: 0x0003F654
		// (set) Token: 0x06001470 RID: 5232 RVA: 0x000414B5 File Offset: 0x0003F6B5
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

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001471 RID: 5233 RVA: 0x000414CC File Offset: 0x0003F6CC
		// (set) Token: 0x06001472 RID: 5234 RVA: 0x0004152D File Offset: 0x0003F72D
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

		// Token: 0x0400100C RID: 4108
		[Nullable(2)]
		protected IGroupAiMonsterMember FbInstance;

		// Token: 0x0400100D RID: 4109
		[Nullable(2)]
		protected IGroupAiMonsterMember_SetValue PocoInterface;

		// Token: 0x0400100E RID: 4110
		private PosAndRot _RelativeTransformCache;

		// Token: 0x0400100F RID: 4111
		private bool _RelativeTransformInited;

		// Token: 0x04001010 RID: 4112
		private IGroupAiMonsterMemberActionTagAttach _ActionTagAttachCache;

		// Token: 0x04001011 RID: 4113
		private bool _ActionTagAttachInited;
	}
}
