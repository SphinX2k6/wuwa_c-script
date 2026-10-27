using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014CE RID: 5326
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeEntityPrefabPerformance : ActionParams
	{
		// Token: 0x06007946 RID: 31046 RVA: 0x001225E8 File Offset: 0x001207E8
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

		// Token: 0x06007947 RID: 31047 RVA: 0x00122620 File Offset: 0x00120820
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

		// Token: 0x06007948 RID: 31048 RVA: 0x00122633 File Offset: 0x00120833
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

		// Token: 0x06007949 RID: 31049 RVA: 0x00122646 File Offset: 0x00120846
		public ChangeEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new ChangeEntityPrefabPerformance_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170028A4 RID: 10404
		// (get) Token: 0x0600794A RID: 31050 RVA: 0x00122659 File Offset: 0x00120859
		// (set) Token: 0x0600794B RID: 31051 RVA: 0x00122684 File Offset: 0x00120884
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

		// Token: 0x04004665 RID: 18021
		[Nullable(2)]
		protected new ChangeEntityPrefabPerformance FbInstance;

		// Token: 0x04004666 RID: 18022
		[Nullable(2)]
		protected ChangeEntityPrefabPerformance_SetValue PocoInterface;
	}
}
