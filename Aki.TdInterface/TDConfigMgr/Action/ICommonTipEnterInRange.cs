using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A9F RID: 6815
	public class ICommonTipEnterInRange : ICommonTipType
	{
		// Token: 0x060090D3 RID: 37075 RVA: 0x00154624 File Offset: 0x00152824
		private ICommonTipEnterInRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipEnterInRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipEnterInRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipEnterInRange_SetValue());
			}
			return result;
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x0015465C File Offset: 0x0015285C
		public static ICommonTipEnterInRange Create([Nullable(2)] ICommonTipEnterInRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x0015466F File Offset: 0x0015286F
		public static ICommonTipEnterInRange CreateFromSetValue([Nullable(2)] ICommonTipEnterInRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipEnterInRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x00154682 File Offset: 0x00152882
		public new ICommonTipEnterInRange_SetValue ToSetValue()
		{
			return new ICommonTipEnterInRange_SetValue
			{
				Type = this.Type,
				TidText = this.TidText,
				EdTidText = this.EdTidText
			};
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x060090D7 RID: 37079 RVA: 0x001546AD File Offset: 0x001528AD
		// (set) Token: 0x060090D8 RID: 37080 RVA: 0x001546D8 File Offset: 0x001528D8
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

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x060090D9 RID: 37081 RVA: 0x001546E6 File Offset: 0x001528E6
		// (set) Token: 0x060090DA RID: 37082 RVA: 0x00154711 File Offset: 0x00152911
		public virtual string TidText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidText;
			}
			set
			{
				this.GetOrCreatePoco().TidText = value;
			}
		}

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x060090DB RID: 37083 RVA: 0x0015471F File Offset: 0x0015291F
		// (set) Token: 0x060090DC RID: 37084 RVA: 0x00154736 File Offset: 0x00152936
		[Nullable(2)]
		public virtual string EdTidText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidText = value;
			}
		}

		// Token: 0x04005A84 RID: 23172
		[Nullable(2)]
		protected new ICommonTipEnterInRange FbInstance;

		// Token: 0x04005A85 RID: 23173
		[Nullable(2)]
		protected new ICommonTipEnterInRange_SetValue PocoInterface;
	}
}
