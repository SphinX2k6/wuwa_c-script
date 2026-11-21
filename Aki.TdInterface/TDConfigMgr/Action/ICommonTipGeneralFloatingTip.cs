using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA3 RID: 6819
	public class ICommonTipGeneralFloatingTip : ICommonTipType
	{
		// Token: 0x060090EB RID: 37099 RVA: 0x00154884 File Offset: 0x00152A84
		private ICommonTipGeneralFloatingTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipGeneralFloatingTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipGeneralFloatingTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipGeneralFloatingTip_SetValue());
			}
			return result;
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x001548BC File Offset: 0x00152ABC
		public static ICommonTipGeneralFloatingTip Create([Nullable(2)] ICommonTipGeneralFloatingTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x001548CF File Offset: 0x00152ACF
		public static ICommonTipGeneralFloatingTip CreateFromSetValue([Nullable(2)] ICommonTipGeneralFloatingTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x001548E2 File Offset: 0x00152AE2
		public new ICommonTipGeneralFloatingTip_SetValue ToSetValue()
		{
			return new ICommonTipGeneralFloatingTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x060090EF RID: 37103 RVA: 0x0015490D File Offset: 0x00152B0D
		// (set) Token: 0x060090F0 RID: 37104 RVA: 0x00154938 File Offset: 0x00152B38
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

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x060090F1 RID: 37105 RVA: 0x00154946 File Offset: 0x00152B46
		// (set) Token: 0x060090F2 RID: 37106 RVA: 0x00154971 File Offset: 0x00152B71
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

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x060090F3 RID: 37107 RVA: 0x0015497F File Offset: 0x00152B7F
		// (set) Token: 0x060090F4 RID: 37108 RVA: 0x00154996 File Offset: 0x00152B96
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

		// Token: 0x04005A8E RID: 23182
		[Nullable(2)]
		protected new ICommonTipGeneralFloatingTip FbInstance;

		// Token: 0x04005A8F RID: 23183
		[Nullable(2)]
		protected new ICommonTipGeneralFloatingTip_SetValue PocoInterface;
	}
}
