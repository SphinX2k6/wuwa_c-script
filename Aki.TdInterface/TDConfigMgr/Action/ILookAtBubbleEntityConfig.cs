using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BB0 RID: 7088
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtBubbleEntityConfig
	{
		// Token: 0x060097C5 RID: 38853 RVA: 0x0015DFE8 File Offset: 0x0015C1E8
		private ILookAtBubbleEntityConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtBubbleEntityConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtBubbleEntityConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtBubbleEntityConfig_SetValue());
			}
			return result;
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x0015E020 File Offset: 0x0015C220
		public static ILookAtBubbleEntityConfig Create([Nullable(2)] ILookAtBubbleEntityConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtBubbleEntityConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x0015E033 File Offset: 0x0015C233
		public static ILookAtBubbleEntityConfig CreateFromSetValue([Nullable(2)] ILookAtBubbleEntityConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtBubbleEntityConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x0015E046 File Offset: 0x0015C246
		public ILookAtBubbleEntityConfig_SetValue ToSetValue()
		{
			return new ILookAtBubbleEntityConfig_SetValue
			{
				BubbleEntity = this.BubbleEntity,
				RangeEntities = this.RangeEntities,
				EntityLookAtPerform = this.EntityLookAtPerform
			};
		}

		// Token: 0x17002FB1 RID: 12209
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x0015E071 File Offset: 0x0015C271
		// (set) Token: 0x060097CA RID: 38858 RVA: 0x0015E09C File Offset: 0x0015C29C
		public virtual int BubbleEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BubbleEntity;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BubbleEntity;
			}
			set
			{
				this.GetOrCreatePoco().BubbleEntity = value;
			}
		}

		// Token: 0x17002FB2 RID: 12210
		// (get) Token: 0x060097CB RID: 38859 RVA: 0x0015E0AA File Offset: 0x0015C2AA
		// (set) Token: 0x060097CC RID: 38860 RVA: 0x0015E0D1 File Offset: 0x0015C2D1
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntities;
				}
				ILookAtBubbleEntityConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.RangeEntities;
			}
			set
			{
				this.GetOrCreatePoco().RangeEntities = value;
			}
		}

		// Token: 0x17002FB3 RID: 12211
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x0015E0E0 File Offset: 0x0015C2E0
		// (set) Token: 0x060097CE RID: 38862 RVA: 0x0015E141 File Offset: 0x0015C341
		[Nullable(2)]
		public virtual IEntityLookAtPerform EntityLookAtPerform
		{
			[NullableContext(2)]
			get
			{
				if (this._EntityLookAtPerformInited)
				{
					return this._EntityLookAtPerformCache;
				}
				this._EntityLookAtPerformInited = true;
				if (this.FbInstance != null)
				{
					this._EntityLookAtPerformCache = IEntityLookAtPerform.Create(this.FbInstance.EntityLookAtPerform);
				}
				else
				{
					ILookAtBubbleEntityConfig_SetValue pocoInterface = this.PocoInterface;
					this._EntityLookAtPerformCache = ((pocoInterface != null) ? pocoInterface.EntityLookAtPerform : null);
				}
				return this._EntityLookAtPerformCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EntityLookAtPerform = value;
				this._EntityLookAtPerformInited = false;
			}
		}

		// Token: 0x04005C9E RID: 23710
		[Nullable(2)]
		protected ILookAtBubbleEntityConfig FbInstance;

		// Token: 0x04005C9F RID: 23711
		[Nullable(2)]
		protected ILookAtBubbleEntityConfig_SetValue PocoInterface;

		// Token: 0x04005CA0 RID: 23712
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x04005CA1 RID: 23713
		private bool _EntityLookAtPerformInited;
	}
}
