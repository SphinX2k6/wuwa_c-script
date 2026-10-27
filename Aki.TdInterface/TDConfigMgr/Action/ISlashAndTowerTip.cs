using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E81 RID: 7809
	[NullableContext(1)]
	[Nullable(0)]
	public class ISlashAndTowerTip : ICommonTipType
	{
		// Token: 0x0600A718 RID: 42776 RVA: 0x00179D9C File Offset: 0x00177F9C
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

		// Token: 0x0600A719 RID: 42777 RVA: 0x00179DD4 File Offset: 0x00177FD4
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

		// Token: 0x0600A71A RID: 42778 RVA: 0x00179DE7 File Offset: 0x00177FE7
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

		// Token: 0x0600A71B RID: 42779 RVA: 0x00179DFA File Offset: 0x00177FFA
		public new ISlashAndTowerTip_SetValue ToSetValue()
		{
			return new ISlashAndTowerTip_SetValue
			{
				Type = this.Type,
				WarningText = this.WarningText
			};
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A71C RID: 42780 RVA: 0x00179E19 File Offset: 0x00178019
		// (set) Token: 0x0600A71D RID: 42781 RVA: 0x00179E44 File Offset: 0x00178044
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

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A71E RID: 42782 RVA: 0x00179E52 File Offset: 0x00178052
		// (set) Token: 0x0600A71F RID: 42783 RVA: 0x00179E7D File Offset: 0x0017807D
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

		// Token: 0x040063BB RID: 25531
		[Nullable(2)]
		protected new ISlashAndTowerTip FbInstance;

		// Token: 0x040063BC RID: 25532
		[Nullable(2)]
		protected new ISlashAndTowerTip_SetValue PocoInterface;
	}
}
