using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200182A RID: 6186
	[NullableContext(1)]
	[Nullable(0)]
	public class IBvbEndTurn : IBvbPlayerOperationType
	{
		// Token: 0x060084C3 RID: 33987 RVA: 0x0013C194 File Offset: 0x0013A394
		private IBvbEndTurn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBvbEndTurn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBvbEndTurn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBvbEndTurn_SetValue());
			}
			return result;
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x0013C1CC File Offset: 0x0013A3CC
		public static IBvbEndTurn Create([Nullable(2)] IBvbEndTurn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				FbInstance = instance
			};
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x0013C1DF File Offset: 0x0013A3DF
		public static IBvbEndTurn CreateFromSetValue([Nullable(2)] IBvbEndTurn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBvbEndTurn
			{
				PocoInterface = value
			};
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x0013C1F2 File Offset: 0x0013A3F2
		public new IBvbEndTurn_SetValue ToSetValue()
		{
			return new IBvbEndTurn_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x0013C205 File Offset: 0x0013A405
		// (set) Token: 0x060084C8 RID: 33992 RVA: 0x0013C230 File Offset: 0x0013A430
		public override EBvbPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040053F8 RID: 21496
		[Nullable(2)]
		protected new IBvbEndTurn FbInstance;

		// Token: 0x040053F9 RID: 21497
		[Nullable(2)]
		protected new IBvbEndTurn_SetValue PocoInterface;
	}
}
