using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000066 RID: 102
	public class DynamicTeleportComponent : IComponentBase
	{
		// Token: 0x0600034A RID: 842 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		private DynamicTeleportComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DynamicTeleportComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DynamicTeleportComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DynamicTeleportComponent_SetValue());
			}
			return result;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001C104 File Offset: 0x0001A304
		public static DynamicTeleportComponent Create([Nullable(2)] DynamicTeleportComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicTeleportComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0001C117 File Offset: 0x0001A317
		public static DynamicTeleportComponent CreateFromSetValue([Nullable(2)] DynamicTeleportComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DynamicTeleportComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001C12A File Offset: 0x0001A32A
		public new DynamicTeleportComponent_SetValue ToSetValue()
		{
			return new DynamicTeleportComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				Offset = this.Offset,
				PhantomSkillId = this.PhantomSkillId
			};
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001C164 File Offset: 0x0001A364
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0001C19E File Offset: 0x0001A39E
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				DynamicTeleportComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0001C1D6 File Offset: 0x0001A3D6
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0001C1E4 File Offset: 0x0001A3E4
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0001C245 File Offset: 0x0001A445
		public virtual PosA Offset
		{
			get
			{
				if (this._OffsetInited)
				{
					return this._OffsetCache;
				}
				this._OffsetInited = true;
				if (this.FbInstance != null)
				{
					this._OffsetCache = PosA.Create(this.FbInstance.Offset);
				}
				else
				{
					DynamicTeleportComponent_SetValue pocoInterface = this.PocoInterface;
					this._OffsetCache = ((pocoInterface != null) ? pocoInterface.Offset : null);
				}
				return this._OffsetCache;
			}
			set
			{
				this.GetOrCreatePoco().Offset = value;
				this._OffsetInited = false;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001C25A File Offset: 0x0001A45A
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0001C285 File Offset: 0x0001A485
		public virtual int PhantomSkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PhantomSkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PhantomSkillId;
			}
			set
			{
				this.GetOrCreatePoco().PhantomSkillId = value;
			}
		}

		// Token: 0x04000214 RID: 532
		[Nullable(2)]
		protected new DynamicTeleportComponent FbInstance;

		// Token: 0x04000215 RID: 533
		[Nullable(2)]
		protected new DynamicTeleportComponent_SetValue PocoInterface;

		// Token: 0x04000216 RID: 534
		private PosA _OffsetCache;

		// Token: 0x04000217 RID: 535
		private bool _OffsetInited;
	}
}
