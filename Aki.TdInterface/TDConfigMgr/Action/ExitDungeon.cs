using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001890 RID: 6288
	public class ExitDungeon : ActionParams
	{
		// Token: 0x06008405 RID: 33797 RVA: 0x0013B75C File Offset: 0x0013995C
		private ExitDungeon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ExitDungeon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ExitDungeon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ExitDungeon_SetValue());
			}
			return result;
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x0013B794 File Offset: 0x00139994
		public static ExitDungeon Create([Nullable(2)] ExitDungeon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ExitDungeon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x0013B7A7 File Offset: 0x001399A7
		public static ExitDungeon CreateFromSetValue([Nullable(2)] ExitDungeon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ExitDungeon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x0013B7BA File Offset: 0x001399BA
		public ExitDungeon_SetValue ToSetValue()
		{
			return new ExitDungeon_SetValue
			{
				IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation
			};
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x06008409 RID: 33801 RVA: 0x0013B7D0 File Offset: 0x001399D0
		// (set) Token: 0x0600840A RID: 33802 RVA: 0x0013B80A File Offset: 0x00139A0A
		public virtual bool? IsNeedSecondaryConfirmation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsNeedSecondaryConfirmation;
				}
				ExitDungeon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsNeedSecondaryConfirmation;
			}
			set
			{
				this.GetOrCreatePoco().IsNeedSecondaryConfirmation = value;
			}
		}

		// Token: 0x04005417 RID: 21527
		[Nullable(2)]
		protected new ExitDungeon FbInstance;

		// Token: 0x04005418 RID: 21528
		[Nullable(2)]
		protected ExitDungeon_SetValue PocoInterface;
	}
}
