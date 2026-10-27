using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E4 RID: 1508
	[NullableContext(1)]
	[Nullable(0)]
	public class IPatrolCycleLooply : ICycleModeType
	{
		// Token: 0x06001FF4 RID: 8180 RVA: 0x000593FC File Offset: 0x000575FC
		private IPatrolCycleLooply_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPatrolCycleLooply 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPatrolCycleLooply_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPatrolCycleLooply_SetValue());
			}
			return result;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x00059434 File Offset: 0x00057634
		public static IPatrolCycleLooply Create([Nullable(2)] IPatrolCycleLooply instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00059447 File Offset: 0x00057647
		public static IPatrolCycleLooply CreateFromSetValue([Nullable(2)] IPatrolCycleLooply_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPatrolCycleLooply
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0005945A File Offset: 0x0005765A
		public new IPatrolCycleLooply_SetValue ToSetValue()
		{
			return new IPatrolCycleLooply_SetValue
			{
				Type = this.Type,
				IsCircle = this.IsCircle
			};
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00059479 File Offset: 0x00057679
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x000594A4 File Offset: 0x000576A4
		public override EPatrolCycleMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPatrolCycleMode.Loop;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x000594B2 File Offset: 0x000576B2
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x000594DD File Offset: 0x000576DD
		public virtual bool IsCircle
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsCircle;
				}
				return this.PocoInterface != null && this.PocoInterface.IsCircle;
			}
			set
			{
				this.GetOrCreatePoco().IsCircle = value;
			}
		}

		// Token: 0x04001679 RID: 5753
		[Nullable(2)]
		protected new IPatrolCycleLooply FbInstance;

		// Token: 0x0400167A RID: 5754
		[Nullable(2)]
		protected new IPatrolCycleLooply_SetValue PocoInterface;
	}
}
