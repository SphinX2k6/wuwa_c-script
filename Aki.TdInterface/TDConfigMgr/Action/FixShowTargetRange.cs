using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200172C RID: 5932
	[NullableContext(1)]
	[Nullable(0)]
	public class FixShowTargetRange : ActionParams
	{
		// Token: 0x06007D99 RID: 32153 RVA: 0x0012D3EC File Offset: 0x0012B5EC
		private FixShowTargetRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("FixShowTargetRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			FixShowTargetRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new FixShowTargetRange_SetValue());
			}
			return result;
		}

		// Token: 0x06007D9A RID: 32154 RVA: 0x0012D424 File Offset: 0x0012B624
		public static FixShowTargetRange Create([Nullable(2)] FixShowTargetRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007D9B RID: 32155 RVA: 0x0012D437 File Offset: 0x0012B637
		public static FixShowTargetRange CreateFromSetValue([Nullable(2)] FixShowTargetRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new FixShowTargetRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007D9C RID: 32156 RVA: 0x0012D44A File Offset: 0x0012B64A
		public FixShowTargetRange_SetValue ToSetValue()
		{
			return new FixShowTargetRange_SetValue
			{
				RangeEntities = this.RangeEntities,
				DelayShow = this.DelayShow
			};
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x06007D9D RID: 32157 RVA: 0x0012D469 File Offset: 0x0012B669
		// (set) Token: 0x06007D9E RID: 32158 RVA: 0x0012D490 File Offset: 0x0012B690
		public virtual List<int> RangeEntities
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.RangeEntities;
				}
				FixShowTargetRange_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x06007D9F RID: 32159 RVA: 0x0012D49E File Offset: 0x0012B69E
		// (set) Token: 0x06007DA0 RID: 32160 RVA: 0x0012D4C9 File Offset: 0x0012B6C9
		public virtual bool DelayShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayShow;
				}
				return this.PocoInterface != null && this.PocoInterface.DelayShow;
			}
			set
			{
				this.GetOrCreatePoco().DelayShow = value;
			}
		}

		// Token: 0x04005022 RID: 20514
		[Nullable(2)]
		protected new FixShowTargetRange FbInstance;

		// Token: 0x04005023 RID: 20515
		[Nullable(2)]
		protected FixShowTargetRange_SetValue PocoInterface;
	}
}
