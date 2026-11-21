using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E81 RID: 7809
	public class INpcSitDown : INpcLeisureInteractType
	{
		// Token: 0x0600A5F5 RID: 42485 RVA: 0x0017A3A4 File Offset: 0x001785A4
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

		// Token: 0x0600A5F6 RID: 42486 RVA: 0x0017A3DC File Offset: 0x001785DC
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

		// Token: 0x0600A5F7 RID: 42487 RVA: 0x0017A3EF File Offset: 0x001785EF
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

		// Token: 0x0600A5F8 RID: 42488 RVA: 0x0017A404 File Offset: 0x00178604
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

		// Token: 0x17003347 RID: 13127
		// (get) Token: 0x0600A5F9 RID: 42489 RVA: 0x0017A452 File Offset: 0x00178652
		// (set) Token: 0x0600A5FA RID: 42490 RVA: 0x0017A47D File Offset: 0x0017867D
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

		// Token: 0x17003348 RID: 13128
		// (get) Token: 0x0600A5FB RID: 42491 RVA: 0x0017A48C File Offset: 0x0017868C
		// (set) Token: 0x0600A5FC RID: 42492 RVA: 0x0017A4C6 File Offset: 0x001786C6
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

		// Token: 0x17003349 RID: 13129
		// (get) Token: 0x0600A5FD RID: 42493 RVA: 0x0017A4D4 File Offset: 0x001786D4
		// (set) Token: 0x0600A5FE RID: 42494 RVA: 0x0017A535 File Offset: 0x00178735
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

		// Token: 0x1700334A RID: 13130
		// (get) Token: 0x0600A5FF RID: 42495 RVA: 0x0017A54A File Offset: 0x0017874A
		// (set) Token: 0x0600A600 RID: 42496 RVA: 0x0017A575 File Offset: 0x00178775
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

		// Token: 0x1700334B RID: 13131
		// (get) Token: 0x0600A601 RID: 42497 RVA: 0x0017A583 File Offset: 0x00178783
		// (set) Token: 0x0600A602 RID: 42498 RVA: 0x0017A5B2 File Offset: 0x001787B2
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

		// Token: 0x04006424 RID: 25636
		[Nullable(2)]
		protected new INpcSitDown FbInstance;

		// Token: 0x04006425 RID: 25637
		[Nullable(2)]
		protected new INpcSitDown_SetValue PocoInterface;

		// Token: 0x04006426 RID: 25638
		private IMontageId _MontageIdCache;

		// Token: 0x04006427 RID: 25639
		private bool _MontageIdInited;
	}
}
