using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A01 RID: 6657
	public class IChangeSelfEntityPrefabPerformance : ChangeEntityPrefabPerformance
	{
		// Token: 0x06008DB9 RID: 36281 RVA: 0x0014F1D8 File Offset: 0x0014D3D8
		private IChangeSelfEntityPrefabPerformance_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeSelfEntityPrefabPerformance 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeSelfEntityPrefabPerformance_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeSelfEntityPrefabPerformance_SetValue());
			}
			return result;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x0014F210 File Offset: 0x0014D410
		public static IChangeSelfEntityPrefabPerformance Create([Nullable(2)] IChangeSelfEntityPrefabPerformance instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeSelfEntityPrefabPerformance
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x0014F223 File Offset: 0x0014D423
		public static IChangeSelfEntityPrefabPerformance CreateFromSetValue([Nullable(2)] IChangeSelfEntityPrefabPerformance_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeSelfEntityPrefabPerformance
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x0014F236 File Offset: 0x0014D436
		public new IChangeSelfEntityPrefabPerformance_SetValue ToSetValue()
		{
			return new IChangeSelfEntityPrefabPerformance_SetValue
			{
				Type = this.Type,
				PerformanceTag = this.PerformanceTag
			};
		}

		// Token: 0x17002DE7 RID: 11751
		// (get) Token: 0x06008DBD RID: 36285 RVA: 0x0014F255 File Offset: 0x0014D455
		// (set) Token: 0x06008DBE RID: 36286 RVA: 0x0014F280 File Offset: 0x0014D480
		public override EChangeEntityPrefabPerformanceType Type
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

		// Token: 0x17002DE8 RID: 11752
		// (get) Token: 0x06008DBF RID: 36287 RVA: 0x0014F28E File Offset: 0x0014D48E
		// (set) Token: 0x06008DC0 RID: 36288 RVA: 0x0014F2B9 File Offset: 0x0014D4B9
		public virtual string PerformanceTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PerformanceTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PerformanceTag;
			}
			set
			{
				this.GetOrCreatePoco().PerformanceTag = value;
			}
		}

		// Token: 0x04005928 RID: 22824
		[Nullable(2)]
		protected new IChangeSelfEntityPrefabPerformance FbInstance;

		// Token: 0x04005929 RID: 22825
		[Nullable(2)]
		protected new IChangeSelfEntityPrefabPerformance_SetValue PocoInterface;
	}
}
