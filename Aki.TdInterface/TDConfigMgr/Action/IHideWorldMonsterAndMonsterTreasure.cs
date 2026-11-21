using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CBE RID: 7358
	public class IHideWorldMonsterAndMonsterTreasure : IHideRangeType
	{
		// Token: 0x06009C42 RID: 40002 RVA: 0x0016867C File Offset: 0x0016687C
		private IHideWorldMonsterAndMonsterTreasure_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideWorldMonsterAndMonsterTreasure 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideWorldMonsterAndMonsterTreasure_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideWorldMonsterAndMonsterTreasure_SetValue());
			}
			return result;
		}

		// Token: 0x06009C43 RID: 40003 RVA: 0x001686B4 File Offset: 0x001668B4
		public static IHideWorldMonsterAndMonsterTreasure Create([Nullable(2)] IHideWorldMonsterAndMonsterTreasure instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasure
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C44 RID: 40004 RVA: 0x001686C7 File Offset: 0x001668C7
		public static IHideWorldMonsterAndMonsterTreasure CreateFromSetValue([Nullable(2)] IHideWorldMonsterAndMonsterTreasure_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideWorldMonsterAndMonsterTreasure
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C45 RID: 40005 RVA: 0x001686DA File Offset: 0x001668DA
		public new IHideWorldMonsterAndMonsterTreasure_SetValue ToSetValue()
		{
			return new IHideWorldMonsterAndMonsterTreasure_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x06009C46 RID: 40006 RVA: 0x001686ED File Offset: 0x001668ED
		// (set) Token: 0x06009C47 RID: 40007 RVA: 0x00168718 File Offset: 0x00166918
		public override EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005F96 RID: 24470
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasure FbInstance;

		// Token: 0x04005F97 RID: 24471
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasure_SetValue PocoInterface;
	}
}
