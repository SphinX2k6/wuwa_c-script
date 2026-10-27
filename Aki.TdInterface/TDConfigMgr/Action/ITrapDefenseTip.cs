using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FF6 RID: 8182
	[NullableContext(1)]
	[Nullable(0)]
	public class ITrapDefenseTip : ICommonTipType
	{
		// Token: 0x0600B3F2 RID: 46066 RVA: 0x001A2A40 File Offset: 0x001A0C40
		private ITrapDefenseTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITrapDefenseTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITrapDefenseTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITrapDefenseTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3F3 RID: 46067 RVA: 0x001A2A78 File Offset: 0x001A0C78
		public static ITrapDefenseTip Create([Nullable(2)] ITrapDefenseTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITrapDefenseTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3F4 RID: 46068 RVA: 0x001A2A8B File Offset: 0x001A0C8B
		public static ITrapDefenseTip CreateFromSetValue([Nullable(2)] ITrapDefenseTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITrapDefenseTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3F5 RID: 46069 RVA: 0x001A2A9E File Offset: 0x001A0C9E
		public new ITrapDefenseTip_SetValue ToSetValue()
		{
			return new ITrapDefenseTip_SetValue
			{
				Type = this.Type,
				MainText = this.MainText,
				TipType = this.TipType
			};
		}

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600B3F6 RID: 46070 RVA: 0x001A2AC9 File Offset: 0x001A0CC9
		// (set) Token: 0x0600B3F7 RID: 46071 RVA: 0x001A2AF4 File Offset: 0x001A0CF4
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

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600B3F8 RID: 46072 RVA: 0x001A2B02 File Offset: 0x001A0D02
		// (set) Token: 0x0600B3F9 RID: 46073 RVA: 0x001A2B2D File Offset: 0x001A0D2D
		public virtual string MainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MainText;
			}
			set
			{
				this.GetOrCreatePoco().MainText = value;
			}
		}

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x001A2B3B File Offset: 0x001A0D3B
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x001A2B66 File Offset: 0x001A0D66
		public virtual ETrapDefenseTipType TipType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TipType;
				}
				if (this.PocoInterface == null)
				{
					return ETrapDefenseTipType.OpenNewAreaTip;
				}
				return this.PocoInterface.TipType;
			}
			set
			{
				this.GetOrCreatePoco().TipType = value;
			}
		}

		// Token: 0x04006C7F RID: 27775
		[Nullable(2)]
		protected new ITrapDefenseTip FbInstance;

		// Token: 0x04006C80 RID: 27776
		[Nullable(2)]
		protected new ITrapDefenseTip_SetValue PocoInterface;
	}
}
