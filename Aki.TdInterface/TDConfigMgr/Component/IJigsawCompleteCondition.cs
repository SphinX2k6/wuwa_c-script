using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004FB RID: 1275
	public class IJigsawCompleteCondition
	{
		// Token: 0x0600197E RID: 6526 RVA: 0x0004BB0C File Offset: 0x00049D0C
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

		// Token: 0x0600197F RID: 6527 RVA: 0x0004BB44 File Offset: 0x00049D44
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

		// Token: 0x06001980 RID: 6528 RVA: 0x0004BB57 File Offset: 0x00049D57
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

		// Token: 0x06001981 RID: 6529 RVA: 0x0004BB6A File Offset: 0x00049D6A
		public IJigsawCompleteCondition_SetValue ToSetValue()
		{
			return new IJigsawCompleteCondition_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x0004BB7D File Offset: 0x00049D7D
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x0004BBA8 File Offset: 0x00049DA8
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

		// Token: 0x040012EC RID: 4844
		[Nullable(2)]
		protected IJigsawCompleteCondition FbInstance;

		// Token: 0x040012ED RID: 4845
		[Nullable(2)]
		protected IJigsawCompleteCondition_SetValue PocoInterface;
	}
}
