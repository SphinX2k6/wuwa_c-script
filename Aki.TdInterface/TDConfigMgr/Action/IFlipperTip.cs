using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A75 RID: 6773
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperTip : ICommonTipType
	{
		// Token: 0x06009106 RID: 37126 RVA: 0x00151CB4 File Offset: 0x0014FEB4
		private IFlipperTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlipperTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlipperTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlipperTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x00151CEC File Offset: 0x0014FEEC
		public static IFlipperTip Create([Nullable(2)] IFlipperTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00151CFF File Offset: 0x0014FEFF
		public static IFlipperTip CreateFromSetValue([Nullable(2)] IFlipperTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlipperTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x00151D14 File Offset: 0x0014FF14
		public new IFlipperTip_SetValue ToSetValue()
		{
			return new IFlipperTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002E29 RID: 11817
		// (get) Token: 0x0600910A RID: 37130 RVA: 0x00151D62 File Offset: 0x0014FF62
		// (set) Token: 0x0600910B RID: 37131 RVA: 0x00151D8D File Offset: 0x0014FF8D
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E2A RID: 11818
		// (get) Token: 0x0600910C RID: 37132 RVA: 0x00151D9B File Offset: 0x0014FF9B
		// (set) Token: 0x0600910D RID: 37133 RVA: 0x00151DC6 File Offset: 0x0014FFC6
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17002E2B RID: 11819
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x00151DD4 File Offset: 0x0014FFD4
		// (set) Token: 0x0600910F RID: 37135 RVA: 0x00151DFF File Offset: 0x0014FFFF
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17002E2C RID: 11820
		// (get) Token: 0x06009110 RID: 37136 RVA: 0x00151E0D File Offset: 0x0015000D
		// (set) Token: 0x06009111 RID: 37137 RVA: 0x00151E24 File Offset: 0x00150024
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17002E2D RID: 11821
		// (get) Token: 0x06009112 RID: 37138 RVA: 0x00151E32 File Offset: 0x00150032
		// (set) Token: 0x06009113 RID: 37139 RVA: 0x00151E49 File Offset: 0x00150049
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x0400597E RID: 22910
		[Nullable(2)]
		protected new IFlipperTip FbInstance;

		// Token: 0x0400597F RID: 22911
		[Nullable(2)]
		protected new IFlipperTip_SetValue PocoInterface;
	}
}
