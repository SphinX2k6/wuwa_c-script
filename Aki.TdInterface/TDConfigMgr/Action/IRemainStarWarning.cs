using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FA5 RID: 8101
	public class IRemainStarWarning : ICommonTipType
	{
		// Token: 0x0600AC3B RID: 44091 RVA: 0x001857DC File Offset: 0x001839DC
		private IRemainStarWarning_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemainStarWarning 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemainStarWarning_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemainStarWarning_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x00185814 File Offset: 0x00183A14
		public static IRemainStarWarning Create([Nullable(2)] IRemainStarWarning instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x00185827 File Offset: 0x00183A27
		public static IRemainStarWarning CreateFromSetValue([Nullable(2)] IRemainStarWarning_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemainStarWarning
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x0018583A File Offset: 0x00183A3A
		public new IRemainStarWarning_SetValue ToSetValue()
		{
			return new IRemainStarWarning_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x170034B4 RID: 13492
		// (get) Token: 0x0600AC3F RID: 44095 RVA: 0x00185859 File Offset: 0x00183A59
		// (set) Token: 0x0600AC40 RID: 44096 RVA: 0x00185884 File Offset: 0x00183A84
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

		// Token: 0x170034B5 RID: 13493
		// (get) Token: 0x0600AC41 RID: 44097 RVA: 0x00185892 File Offset: 0x00183A92
		// (set) Token: 0x0600AC42 RID: 44098 RVA: 0x001858BD File Offset: 0x00183ABD
		public virtual string WarningText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.WarningText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.WarningText;
			}
			set
			{
				this.GetOrCreatePoco().WarningText = value;
			}
		}

		// Token: 0x040066FD RID: 26365
		[Nullable(2)]
		protected new IRemainStarWarning FbInstance;

		// Token: 0x040066FE RID: 26366
		[Nullable(2)]
		protected new IRemainStarWarning_SetValue PocoInterface;
	}
}
