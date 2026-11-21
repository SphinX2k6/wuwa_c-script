using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200223D RID: 8765
	public class ITrapDefenseTip : ICommonTipType
	{
		// Token: 0x0600BF08 RID: 48904 RVA: 0x001B8FAC File Offset: 0x001B71AC
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

		// Token: 0x0600BF09 RID: 48905 RVA: 0x001B8FE4 File Offset: 0x001B71E4
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

		// Token: 0x0600BF0A RID: 48906 RVA: 0x001B8FF7 File Offset: 0x001B71F7
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

		// Token: 0x0600BF0B RID: 48907 RVA: 0x001B900A File Offset: 0x001B720A
		public new ITrapDefenseTip_SetValue ToSetValue()
		{
			return new ITrapDefenseTip_SetValue
			{
				Type = this.Type,
				MainText = this.MainText,
				TipType = this.TipType
			};
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0600BF0C RID: 48908 RVA: 0x001B9035 File Offset: 0x001B7235
		// (set) Token: 0x0600BF0D RID: 48909 RVA: 0x001B9060 File Offset: 0x001B7260
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

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0600BF0E RID: 48910 RVA: 0x001B906E File Offset: 0x001B726E
		// (set) Token: 0x0600BF0F RID: 48911 RVA: 0x001B9099 File Offset: 0x001B7299
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

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0600BF10 RID: 48912 RVA: 0x001B90A7 File Offset: 0x001B72A7
		// (set) Token: 0x0600BF11 RID: 48913 RVA: 0x001B90D2 File Offset: 0x001B72D2
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

		// Token: 0x04007281 RID: 29313
		[Nullable(2)]
		protected new ITrapDefenseTip FbInstance;

		// Token: 0x04007282 RID: 29314
		[Nullable(2)]
		protected new ITrapDefenseTip_SetValue PocoInterface;
	}
}
