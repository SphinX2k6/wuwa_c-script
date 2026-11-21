using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200108F RID: 4239
	public class IFailedTeleport
	{
		// Token: 0x06005D66 RID: 23910 RVA: 0x000E2AC0 File Offset: 0x000E0CC0
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

		// Token: 0x06005D67 RID: 23911 RVA: 0x000E2AF8 File Offset: 0x000E0CF8
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

		// Token: 0x06005D68 RID: 23912 RVA: 0x000E2B0B File Offset: 0x000E0D0B
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

		// Token: 0x06005D69 RID: 23913 RVA: 0x000E2B20 File Offset: 0x000E0D20
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

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x000E2B7C File Offset: 0x000E0D7C
		// (set) Token: 0x06005D6B RID: 23915 RVA: 0x000E2BDD File Offset: 0x000E0DDD
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

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x000E2BF4 File Offset: 0x000E0DF4
		// (set) Token: 0x06005D6D RID: 23917 RVA: 0x000E2C2E File Offset: 0x000E0E2E
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x000E2C3C File Offset: 0x000E0E3C
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x000E2C67 File Offset: 0x000E0E67
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

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x000E2C75 File Offset: 0x000E0E75
		// (set) Token: 0x06005D71 RID: 23921 RVA: 0x000E2CA0 File Offset: 0x000E0EA0
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

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x000E2CAE File Offset: 0x000E0EAE
		// (set) Token: 0x06005D73 RID: 23923 RVA: 0x000E2CD5 File Offset: 0x000E0ED5
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

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x000E2CE4 File Offset: 0x000E0EE4
		// (set) Token: 0x06005D75 RID: 23925 RVA: 0x000E2D1E File Offset: 0x000E0F1E
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

		// Token: 0x04003821 RID: 14369
		[Nullable(2)]
		protected IFailedTeleport FbInstance;

		// Token: 0x04003822 RID: 14370
		[Nullable(2)]
		protected IFailedTeleport_SetValue PocoInterface;

		// Token: 0x04003823 RID: 14371
		private PosA _PositionCache;

		// Token: 0x04003824 RID: 14372
		private bool _PositionInited;
	}
}
