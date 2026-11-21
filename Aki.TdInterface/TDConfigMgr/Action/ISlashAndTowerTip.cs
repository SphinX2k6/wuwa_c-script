using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020B6 RID: 8374
	public class ISlashAndTowerTip : ICommonTipType
	{
		// Token: 0x0600B1D0 RID: 45520 RVA: 0x0018FA9C File Offset: 0x0018DC9C
		private ISlashAndTowerTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISlashAndTowerTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISlashAndTowerTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISlashAndTowerTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x0018FAD4 File Offset: 0x0018DCD4
		public static ISlashAndTowerTip Create([Nullable(2)] ISlashAndTowerTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlashAndTowerTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x0018FAE7 File Offset: 0x0018DCE7
		public static ISlashAndTowerTip CreateFromSetValue([Nullable(2)] ISlashAndTowerTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISlashAndTowerTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x0018FAFA File Offset: 0x0018DCFA
		public new ISlashAndTowerTip_SetValue ToSetValue()
		{
			return new ISlashAndTowerTip_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x0018FB19 File Offset: 0x0018DD19
		// (set) Token: 0x0600B1D5 RID: 45525 RVA: 0x0018FB44 File Offset: 0x0018DD44
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

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600B1D6 RID: 45526 RVA: 0x0018FB52 File Offset: 0x0018DD52
		// (set) Token: 0x0600B1D7 RID: 45527 RVA: 0x0018FB7D File Offset: 0x0018DD7D
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

		// Token: 0x0400699F RID: 27039
		[Nullable(2)]
		protected new ISlashAndTowerTip FbInstance;

		// Token: 0x040069A0 RID: 27040
		[Nullable(2)]
		protected new ISlashAndTowerTip_SetValue PocoInterface;
	}
}
