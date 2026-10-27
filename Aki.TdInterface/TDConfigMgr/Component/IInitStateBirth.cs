using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000468 RID: 1128
	[NullableContext(1)]
	[Nullable(0)]
	public class IInitStateBirth : IInitState
	{
		// Token: 0x060016BF RID: 5823 RVA: 0x00045C10 File Offset: 0x00043E10
		private IInitStateBirth_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInitStateBirth 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInitStateBirth_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInitStateBirth_SetValue());
			}
			return result;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00045C48 File Offset: 0x00043E48
		public static IInitStateBirth Create([Nullable(2)] IInitStateBirth instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				FbInstance = instance
			};
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00045C5B File Offset: 0x00043E5B
		public static IInitStateBirth CreateFromSetValue([Nullable(2)] IInitStateBirth_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInitStateBirth
			{
				PocoInterface = value
			};
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00045C6E File Offset: 0x00043E6E
		public new IInitStateBirth_SetValue ToSetValue()
		{
			return new IInitStateBirth_SetValue
			{
				Type = this.Type,
				BirthTag = this.BirthTag
			};
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x00045C8D File Offset: 0x00043E8D
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00045CB8 File Offset: 0x00043EB8
		public override EInitStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInitStateType.Birth;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00045CC6 File Offset: 0x00043EC6
		// (set) Token: 0x060016C6 RID: 5830 RVA: 0x00045CF1 File Offset: 0x00043EF1
		public virtual string BirthTag
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BirthTag;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BirthTag;
			}
			set
			{
				this.GetOrCreatePoco().BirthTag = value;
			}
		}

		// Token: 0x04001140 RID: 4416
		[Nullable(2)]
		protected new IInitStateBirth FbInstance;

		// Token: 0x04001141 RID: 4417
		[Nullable(2)]
		protected new IInitStateBirth_SetValue PocoInterface;
	}
}
