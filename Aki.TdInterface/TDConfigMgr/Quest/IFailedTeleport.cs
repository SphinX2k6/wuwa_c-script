using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F65 RID: 3941
	[NullableContext(1)]
	[Nullable(0)]
	public class IFailedTeleport
	{
		// Token: 0x06005792 RID: 22418 RVA: 0x000D6054 File Offset: 0x000D4254
		private IFailedTeleport_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFailedTeleport 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFailedTeleport_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFailedTeleport_SetValue());
			}
			return result;
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x000D608C File Offset: 0x000D428C
		public static IFailedTeleport Create([Nullable(2)] IFailedTeleport instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFailedTeleport
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x000D609F File Offset: 0x000D429F
		public static IFailedTeleport CreateFromSetValue([Nullable(2)] IFailedTeleport_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFailedTeleport
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x000D60B4 File Offset: 0x000D42B4
		public IFailedTeleport_SetValue ToSetValue()
		{
			return new IFailedTeleport_SetValue
			{
				Position = this.Position,
				PositionEntityId = this.PositionEntityId,
				IsConfirm = this.IsConfirm,
				ConfirmId = this.ConfirmId,
				TransitionOption = this.TransitionOption,
				GravityFlip = this.GravityFlip
			};
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x000D6110 File Offset: 0x000D4310
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x000D6171 File Offset: 0x000D4371
		public virtual PosA Position
		{
			get
			{
				if (this._PositionInited)
				{
					return this._PositionCache;
				}
				this._PositionInited = true;
				if (this.FbInstance != null)
				{
					this._PositionCache = PosA.Create(this.FbInstance.Position);
				}
				else
				{
					IFailedTeleport_SetValue pocoInterface = this.PocoInterface;
					this._PositionCache = ((pocoInterface != null) ? pocoInterface.Position : null);
				}
				return this._PositionCache;
			}
			set
			{
				this.GetOrCreatePoco().Position = value;
				this._PositionInited = false;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x000D6188 File Offset: 0x000D4388
		// (set) Token: 0x06005799 RID: 22425 RVA: 0x000D61C2 File Offset: 0x000D43C2
		public virtual int? PositionEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PositionEntityId;
				}
				IFailedTeleport_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x000D61D0 File Offset: 0x000D43D0
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x000D61FB File Offset: 0x000D43FB
		public virtual bool IsConfirm
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsConfirm;
				}
				return this.PocoInterface != null && this.PocoInterface.IsConfirm;
			}
			set
			{
				this.GetOrCreatePoco().IsConfirm = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x000D6209 File Offset: 0x000D4409
		// (set) Token: 0x0600579D RID: 22429 RVA: 0x000D6234 File Offset: 0x000D4434
		public virtual int ConfirmId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfirmId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ConfirmId;
			}
			set
			{
				this.GetOrCreatePoco().ConfirmId = value;
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x0600579E RID: 22430 RVA: 0x000D6242 File Offset: 0x000D4442
		// (set) Token: 0x0600579F RID: 22431 RVA: 0x000D6269 File Offset: 0x000D4469
		[Nullable(2)]
		public virtual ITeleportTransitionType TransitionOption
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TransitionOption;
				}
				IFailedTeleport_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TransitionOption;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TransitionOption = value;
			}
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x000D6278 File Offset: 0x000D4478
		// (set) Token: 0x060057A1 RID: 22433 RVA: 0x000D62B2 File Offset: 0x000D44B2
		public virtual bool? GravityFlip
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.GravityFlip;
				}
				IFailedTeleport_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.GravityFlip;
			}
			set
			{
				this.GetOrCreatePoco().GravityFlip = value;
			}
		}

		// Token: 0x040034F0 RID: 13552
		[Nullable(2)]
		protected IFailedTeleport FbInstance;

		// Token: 0x040034F1 RID: 13553
		[Nullable(2)]
		protected IFailedTeleport_SetValue PocoInterface;

		// Token: 0x040034F2 RID: 13554
		private PosA _PositionCache;

		// Token: 0x040034F3 RID: 13555
		private bool _PositionInited;
	}
}
