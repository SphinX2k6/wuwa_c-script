using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CEE RID: 7406
	[NullableContext(1)]
	[Nullable(0)]
	public class IPhotographicTip : ICommonTipType
	{
		// Token: 0x06009EF1 RID: 40689 RVA: 0x0016B500 File Offset: 0x00169700
		private IPhotographicTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographicTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographicTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographicTip_SetValue());
			}
			return result;
		}

		// Token: 0x06009EF2 RID: 40690 RVA: 0x0016B538 File Offset: 0x00169738
		public static IPhotographicTip Create([Nullable(2)] IPhotographicTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EF3 RID: 40691 RVA: 0x0016B54B File Offset: 0x0016974B
		public static IPhotographicTip CreateFromSetValue([Nullable(2)] IPhotographicTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EF4 RID: 40692 RVA: 0x0016B55E File Offset: 0x0016975E
		public new IPhotographicTip_SetValue ToSetValue()
		{
			return new IPhotographicTip_SetValue
			{
				Type = this.Type,
				MainText = this.MainText
			};
		}

		// Token: 0x1700316A RID: 12650
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x0016B57D File Offset: 0x0016977D
		// (set) Token: 0x06009EF6 RID: 40694 RVA: 0x0016B5A8 File Offset: 0x001697A8
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

		// Token: 0x1700316B RID: 12651
		// (get) Token: 0x06009EF7 RID: 40695 RVA: 0x0016B5B6 File Offset: 0x001697B6
		// (set) Token: 0x06009EF8 RID: 40696 RVA: 0x0016B5E1 File Offset: 0x001697E1
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

		// Token: 0x04006001 RID: 24577
		[Nullable(2)]
		protected new IPhotographicTip FbInstance;

		// Token: 0x04006002 RID: 24578
		[Nullable(2)]
		protected new IPhotographicTip_SetValue PocoInterface;
	}
}
