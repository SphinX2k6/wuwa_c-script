using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C7C RID: 7292
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcSitDown : INpcLeisureInteractType
	{
		// Token: 0x06009C5B RID: 40027 RVA: 0x001669B0 File Offset: 0x00164BB0
		private INpcSitDown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcSitDown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcSitDown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcSitDown_SetValue());
			}
			return result;
		}

		// Token: 0x06009C5C RID: 40028 RVA: 0x001669E8 File Offset: 0x00164BE8
		public static INpcSitDown Create([Nullable(2)] INpcSitDown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcSitDown
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C5D RID: 40029 RVA: 0x001669FB File Offset: 0x00164BFB
		public static INpcSitDown CreateFromSetValue([Nullable(2)] INpcSitDown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcSitDown
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C5E RID: 40030 RVA: 0x00166A10 File Offset: 0x00164C10
		public new INpcSitDown_SetValue ToSetValue()
		{
			return new INpcSitDown_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState,
				MontageId = this.MontageId,
				PosEntityId = this.PosEntityId,
				Duration = this.Duration
			};
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x06009C5F RID: 40031 RVA: 0x00166A5E File Offset: 0x00164C5E
		// (set) Token: 0x06009C60 RID: 40032 RVA: 0x00166A89 File Offset: 0x00164C89
		public override ENpcLeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x06009C61 RID: 40033 RVA: 0x00166A98 File Offset: 0x00164C98
		// (set) Token: 0x06009C62 RID: 40034 RVA: 0x00166AD2 File Offset: 0x00164CD2
		public override bool? KeepState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepState;
				}
				INpcSitDown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepState;
			}
			set
			{
				this.GetOrCreatePoco().KeepState = value;
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x06009C63 RID: 40035 RVA: 0x00166AE0 File Offset: 0x00164CE0
		// (set) Token: 0x06009C64 RID: 40036 RVA: 0x00166B41 File Offset: 0x00164D41
		public virtual IMontageId MontageId
		{
			get
			{
				if (this._MontageIdInited)
				{
					return this._MontageIdCache;
				}
				this._MontageIdInited = true;
				if (this.FbInstance != null)
				{
					this._MontageIdCache = IMontageId.Create(this.FbInstance.MontageId);
				}
				else
				{
					INpcSitDown_SetValue pocoInterface = this.PocoInterface;
					this._MontageIdCache = ((pocoInterface != null) ? pocoInterface.MontageId : null);
				}
				return this._MontageIdCache;
			}
			set
			{
				this.GetOrCreatePoco().MontageId = value;
				this._MontageIdInited = false;
			}
		}

		// Token: 0x170030CD RID: 12493
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x00166B56 File Offset: 0x00164D56
		// (set) Token: 0x06009C66 RID: 40038 RVA: 0x00166B81 File Offset: 0x00164D81
		public virtual int PosEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PosEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PosEntityId;
			}
			set
			{
				this.GetOrCreatePoco().PosEntityId = value;
			}
		}

		// Token: 0x170030CE RID: 12494
		// (get) Token: 0x06009C67 RID: 40039 RVA: 0x00166B8F File Offset: 0x00164D8F
		// (set) Token: 0x06009C68 RID: 40040 RVA: 0x00166BBE File Offset: 0x00164DBE
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x04005ED1 RID: 24273
		[Nullable(2)]
		protected new INpcSitDown FbInstance;

		// Token: 0x04005ED2 RID: 24274
		[Nullable(2)]
		protected new INpcSitDown_SetValue PocoInterface;

		// Token: 0x04005ED3 RID: 24275
		private IMontageId _MontageIdCache;

		// Token: 0x04005ED4 RID: 24276
		private bool _MontageIdInited;
	}
}
