using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A2 RID: 1186
	[NullableContext(1)]
	[Nullable(0)]
	public class IJigsawCompleteCondition
	{
		// Token: 0x060017E4 RID: 6116 RVA: 0x00047DC4 File Offset: 0x00045FC4
		private IJigsawCompleteCondition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IJigsawCompleteCondition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IJigsawCompleteCondition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IJigsawCompleteCondition_SetValue());
			}
			return result;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00047DFC File Offset: 0x00045FFC
		public static IJigsawCompleteCondition Create([Nullable(2)] IJigsawCompleteCondition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IJigsawCompleteCondition
			{
				FbInstance = instance
			};
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00047E0F File Offset: 0x0004600F
		public static IJigsawCompleteCondition CreateFromSetValue([Nullable(2)] IJigsawCompleteCondition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IJigsawCompleteCondition
			{
				PocoInterface = value
			};
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00047E22 File Offset: 0x00046022
		public IJigsawCompleteCondition_SetValue ToSetValue()
		{
			return new IJigsawCompleteCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00047E35 File Offset: 0x00046035
		// (set) Token: 0x060017E9 RID: 6121 RVA: 0x00047E60 File Offset: 0x00046060
		public virtual EJigsawCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040011CA RID: 4554
		[Nullable(2)]
		protected IJigsawCompleteCondition FbInstance;

		// Token: 0x040011CB RID: 4555
		[Nullable(2)]
		protected IJigsawCompleteCondition_SetValue PocoInterface;
	}
}
