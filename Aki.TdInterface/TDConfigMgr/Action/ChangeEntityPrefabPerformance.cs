using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001627 RID: 5671
	public class ChangeEntityPrefabPerformance : ActionParams
	{
		// Token: 0x06008013 RID: 32787 RVA: 0x00131234 File Offset: 0x0012F434
		private ChangeEntityPrefabPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ChangeEntityPrefabPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ChangeEntityPrefabPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ChangeEntityPrefabPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x06008014 RID: 32788 RVA: 0x0013126C File Offset: 0x0012F46C
		public static ChangeEntityPrefabPerformance Create([Nullable(2)] ChangeEntityPrefabPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ChangeEntityPrefabPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x0013127F File Offset: 0x0012F47F
		public static ChangeEntityPrefabPerformance CreateFromSetValue([Nullable(2)] ChangeEntityPrefabPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ChangeEntityPrefabPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00131292 File Offset: 0x0012F492
		public ChangeEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new ChangeEntityPrefabPerformance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x06008017 RID: 32791 RVA: 0x001312A5 File Offset: 0x0012F4A5
		// (set) Token: 0x06008018 RID: 32792 RVA: 0x001312D0 File Offset: 0x0012F4D0
		public virtual EChangeEntityPrefabPerformanceType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityPrefabPerformanceType.Target;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004A00 RID: 18944
		[Nullable(2)]
		protected new ChangeEntityPrefabPerformance FbInstance;

		// Token: 0x04004A01 RID: 18945
		[Nullable(2)]
		protected ChangeEntityPrefabPerformance_SetValue PocoInterface;
	}
}
