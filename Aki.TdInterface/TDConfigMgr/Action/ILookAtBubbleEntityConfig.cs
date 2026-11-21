using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D97 RID: 7575
	public class ILookAtBubbleEntityConfig
	{
		// Token: 0x0600A0C9 RID: 41161 RVA: 0x00170AA8 File Offset: 0x0016ECA8
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

		// Token: 0x0600A0CA RID: 41162 RVA: 0x00170AE0 File Offset: 0x0016ECE0
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

		// Token: 0x0600A0CB RID: 41163 RVA: 0x00170AF3 File Offset: 0x0016ECF3
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

		// Token: 0x0600A0CC RID: 41164 RVA: 0x00170B06 File Offset: 0x0016ED06
		public ILookAtBubbleEntityConfig_SetValue ToSetValue()
		{
			return new ILookAtBubbleEntityConfig_SetValue
			{
				BubbleEntity = this.BubbleEntity,
				RangeEntities = this.RangeEntities,
				EntityLookAtPerform = this.EntityLookAtPerform
			};
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600A0CD RID: 41165 RVA: 0x00170B31 File Offset: 0x0016ED31
		// (set) Token: 0x0600A0CE RID: 41166 RVA: 0x00170B5C File Offset: 0x0016ED5C
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

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600A0CF RID: 41167 RVA: 0x00170B6A File Offset: 0x0016ED6A
		// (set) Token: 0x0600A0D0 RID: 41168 RVA: 0x00170B91 File Offset: 0x0016ED91
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

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600A0D1 RID: 41169 RVA: 0x00170BA0 File Offset: 0x0016EDA0
		// (set) Token: 0x0600A0D2 RID: 41170 RVA: 0x00170C01 File Offset: 0x0016EE01
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

		// Token: 0x040061B3 RID: 25011
		[Nullable(2)]
		protected ILookAtBubbleEntityConfig FbInstance;

		// Token: 0x040061B4 RID: 25012
		[Nullable(2)]
		protected ILookAtBubbleEntityConfig_SetValue PocoInterface;

		// Token: 0x040061B5 RID: 25013
		private IEntityLookAtPerform _EntityLookAtPerformCache;

		// Token: 0x040061B6 RID: 25014
		private bool _EntityLookAtPerformInited;
	}
}
