using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0E RID: 6670
	[NullableContext(1)]
	[Nullable(0)]
	public class IEntityLookAtPerform
	{
		// Token: 0x06008EE1 RID: 36577 RVA: 0x0014DEA4 File Offset: 0x0014C0A4
		private IEntityLookAtPerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEntityLookAtPerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEntityLookAtPerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEntityLookAtPerform_SetValue());
			}
			return result;
		}

		// Token: 0x06008EE2 RID: 36578 RVA: 0x0014DEDC File Offset: 0x0014C0DC
		public static IEntityLookAtPerform Create([Nullable(2)] IEntityLookAtPerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008EE3 RID: 36579 RVA: 0x0014DEEF File Offset: 0x0014C0EF
		public static IEntityLookAtPerform CreateFromSetValue([Nullable(2)] IEntityLookAtPerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEntityLookAtPerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008EE4 RID: 36580 RVA: 0x0014DF02 File Offset: 0x0014C102
		public IEntityLookAtPerform_SetValue ToSetValue()
		{
			return new IEntityLookAtPerform_SetValue
			{
				EntityId = this.EntityId,
				FaceExpressionId = this.FaceExpressionId,
				OverlapMontageId = this.OverlapMontageId,
				OverlapMontageConfig = this.OverlapMontageConfig
			};
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x0014DF39 File Offset: 0x0014C139
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x0014DF64 File Offset: 0x0014C164
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

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0014DF74 File Offset: 0x0014C174
		// (set) Token: 0x06008EE8 RID: 36584 RVA: 0x0014DFAE File Offset: 0x0014C1AE
		public virtual int? FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x0014DFBC File Offset: 0x0014C1BC
		// (set) Token: 0x06008EEA RID: 36586 RVA: 0x0014DFF6 File Offset: 0x0014C1F6
		public virtual int? OverlapMontageId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OverlapMontageId;
				}
				IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OverlapMontageId;
			}
			set
			{
				this.GetOrCreatePoco().OverlapMontageId = value;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x0014E004 File Offset: 0x0014C204
		// (set) Token: 0x06008EEC RID: 36588 RVA: 0x0014E065 File Offset: 0x0014C265
		[Nullable(2)]
		public virtual ILookAtPerformOverlapMontageConfig OverlapMontageConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._OverlapMontageConfigInited)
				{
					return this._OverlapMontageConfigCache;
				}
				this._OverlapMontageConfigInited = true;
				if (this.FbInstance != null)
				{
					this._OverlapMontageConfigCache = ILookAtPerformOverlapMontageConfig.Create(this.FbInstance.OverlapMontageConfig);
				}
				else
				{
					IEntityLookAtPerform_SetValue pocoInterface = this.PocoInterface;
					this._OverlapMontageConfigCache = ((pocoInterface != null) ? pocoInterface.OverlapMontageConfig : null);
				}
				return this._OverlapMontageConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().OverlapMontageConfig = value;
				this._OverlapMontageConfigInited = false;
			}
		}

		// Token: 0x04005879 RID: 22649
		[Nullable(2)]
		protected IEntityLookAtPerform FbInstance;

		// Token: 0x0400587A RID: 22650
		[Nullable(2)]
		protected IEntityLookAtPerform_SetValue PocoInterface;

		// Token: 0x0400587B RID: 22651
		private ILookAtPerformOverlapMontageConfig _OverlapMontageConfigCache;

		// Token: 0x0400587C RID: 22652
		private bool _OverlapMontageConfigInited;
	}
}
