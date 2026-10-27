using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000066 RID: 102
	[NullableContext(1)]
	[Nullable(0)]
	public class DynamicTeleportComponent : IComponentBase
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0001B758 File Offset: 0x00019958
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

		// Token: 0x06000347 RID: 839 RVA: 0x0001B790 File Offset: 0x00019990
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

		// Token: 0x06000348 RID: 840 RVA: 0x0001B7A3 File Offset: 0x000199A3
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

		// Token: 0x06000349 RID: 841 RVA: 0x0001B7B6 File Offset: 0x000199B6
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

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001B7F0 File Offset: 0x000199F0
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0001B82A File Offset: 0x00019A2A
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

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001B838 File Offset: 0x00019A38
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0001B862 File Offset: 0x00019A62
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001B870 File Offset: 0x00019A70
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0001B8D1 File Offset: 0x00019AD1
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

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001B8E6 File Offset: 0x00019AE6
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0001B911 File Offset: 0x00019B11
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

		// Token: 0x0400020F RID: 527
		[Nullable(2)]
		protected new DynamicTeleportComponent FbInstance;

		// Token: 0x04000210 RID: 528
		[Nullable(2)]
		protected new DynamicTeleportComponent_SetValue PocoInterface;

		// Token: 0x04000211 RID: 529
		private PosA _OffsetCache;

		// Token: 0x04000212 RID: 530
		private bool _OffsetInited;
	}
}
