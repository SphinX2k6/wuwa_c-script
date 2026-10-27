using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BD6 RID: 7126
	[NullableContext(1)]
	[Nullable(0)]
	public class IMechStuntHighSpeed : IMechStuntConfigType
	{
		// Token: 0x060098A9 RID: 39081 RVA: 0x0015FC1C File Offset: 0x0015DE1C
		private IMechStuntHighSpeed_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMechStuntHighSpeed 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMechStuntHighSpeed_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMechStuntHighSpeed_SetValue());
			}
			return result;
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x0015FC54 File Offset: 0x0015DE54
		public static IMechStuntHighSpeed Create([Nullable(2)] IMechStuntHighSpeed instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMechStuntHighSpeed
			{
				FbInstance = instance
			};
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x0015FC67 File Offset: 0x0015DE67
		public static IMechStuntHighSpeed CreateFromSetValue([Nullable(2)] IMechStuntHighSpeed_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMechStuntHighSpeed
			{
				PocoInterface = value
			};
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x0015FC7A File Offset: 0x0015DE7A
		public new IMechStuntHighSpeed_SetValue ToSetValue()
		{
			return new IMechStuntHighSpeed_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x0015FC8D File Offset: 0x0015DE8D
		// (set) Token: 0x060098AE RID: 39086 RVA: 0x0015FCB8 File Offset: 0x0015DEB8
		public override EMechStuntType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMechStuntType.Dive;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005D13 RID: 23827
		[Nullable(2)]
		protected new IMechStuntHighSpeed FbInstance;

		// Token: 0x04005D14 RID: 23828
		[Nullable(2)]
		protected new IMechStuntHighSpeed_SetValue PocoInterface;
	}
}
