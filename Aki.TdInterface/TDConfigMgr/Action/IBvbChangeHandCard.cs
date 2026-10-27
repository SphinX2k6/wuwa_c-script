using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001826 RID: 6182
	[NullableContext(1)]
	[Nullable(0)]
	public class IBvbChangeHandCard : IBvbPlayerOperationType
	{
		// Token: 0x060084AB RID: 33963 RVA: 0x0013BEDC File Offset: 0x0013A0DC
		private IBvbChangeHandCard_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbChangeHandCard 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbChangeHandCard_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbChangeHandCard_SetValue());
			}
			return result;
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x0013BF14 File Offset: 0x0013A114
		public static IBvbChangeHandCard Create([Nullable(2)] IBvbChangeHandCard instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbChangeHandCard
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x0013BF27 File Offset: 0x0013A127
		public static IBvbChangeHandCard CreateFromSetValue([Nullable(2)] IBvbChangeHandCard_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbChangeHandCard
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x0013BF3A File Offset: 0x0013A13A
		public new IBvbChangeHandCard_SetValue ToSetValue()
		{
			return new IBvbChangeHandCard_SetValue
			{
				Type = this.Type,
				HandCardIndex = this.HandCardIndex
			};
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x0013BF59 File Offset: 0x0013A159
		// (set) Token: 0x060084B0 RID: 33968 RVA: 0x0013BF84 File Offset: 0x0013A184
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

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x060084B1 RID: 33969 RVA: 0x0013BF94 File Offset: 0x0013A194
		// (set) Token: 0x060084B2 RID: 33970 RVA: 0x0013BFCE File Offset: 0x0013A1CE
		public virtual int? HandCardIndex
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HandCardIndex;
				}
				IBvbChangeHandCard_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040053EE RID: 21486
		[Nullable(2)]
		protected new IBvbChangeHandCard FbInstance;

		// Token: 0x040053EF RID: 21487
		[Nullable(2)]
		protected new IBvbChangeHandCard_SetValue PocoInterface;
	}
}
