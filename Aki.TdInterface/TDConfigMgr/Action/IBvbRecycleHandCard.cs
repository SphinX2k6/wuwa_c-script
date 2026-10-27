using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001832 RID: 6194
	[NullableContext(1)]
	[Nullable(0)]
	public class IBvbRecycleHandCard : IBvbPlayerOperationType
	{
		// Token: 0x060084ED RID: 34029 RVA: 0x0013C608 File Offset: 0x0013A808
		private IBvbRecycleHandCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbRecycleHandCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbRecycleHandCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbRecycleHandCard_SetValue());
			}
			return result;
		}

		// Token: 0x060084EE RID: 34030 RVA: 0x0013C640 File Offset: 0x0013A840
		public static IBvbRecycleHandCard Create([Nullable(2)] IBvbRecycleHandCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbRecycleHandCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x0013C653 File Offset: 0x0013A853
		public static IBvbRecycleHandCard CreateFromSetValue([Nullable(2)] IBvbRecycleHandCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbRecycleHandCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084F0 RID: 34032 RVA: 0x0013C666 File Offset: 0x0013A866
		public new IBvbRecycleHandCard_SetValue ToSetValue()
		{
			return new IBvbRecycleHandCard_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex
			};
		}

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x0013C685 File Offset: 0x0013A885
		// (set) Token: 0x060084F2 RID: 34034 RVA: 0x0013C6B0 File Offset: 0x0013A8B0
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x0013C6C0 File Offset: 0x0013A8C0
		// (set) Token: 0x060084F4 RID: 34036 RVA: 0x0013C6FA File Offset: 0x0013A8FA
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbRecycleHandCard_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HandCardIndex;
			}
			set
			{
				this.GetOrCreatePoco().HandCardIndex = value;
			}
		}

		// Token: 0x04005409 RID: 21513
		[Nullable(2)]
		protected new IBvbRecycleHandCard FbInstance;

		// Token: 0x0400540A RID: 21514
		[Nullable(2)]
		protected new IBvbRecycleHandCard_SetValue PocoInterface;
	}
}
