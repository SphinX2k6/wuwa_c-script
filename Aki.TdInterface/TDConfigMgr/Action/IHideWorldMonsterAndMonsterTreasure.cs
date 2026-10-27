using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B0F RID: 6927
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideWorldMonsterAndMonsterTreasure : IHideRangeType
	{
		// Token: 0x06009458 RID: 37976 RVA: 0x001579A0 File Offset: 0x00155BA0
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

		// Token: 0x06009459 RID: 37977 RVA: 0x001579D8 File Offset: 0x00155BD8
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

		// Token: 0x0600945A RID: 37978 RVA: 0x001579EB File Offset: 0x00155BEB
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

		// Token: 0x0600945B RID: 37979 RVA: 0x001579FE File Offset: 0x00155BFE
		public new IHideWorldMonsterAndMonsterTreasure_SetValue ToSetValue()
		{
			return new IHideWorldMonsterAndMonsterTreasure_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600945C RID: 37980 RVA: 0x00157A11 File Offset: 0x00155C11
		// (set) Token: 0x0600945D RID: 37981 RVA: 0x00157A3C File Offset: 0x00155C3C
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

		// Token: 0x04005AF8 RID: 23288
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasure FbInstance;

		// Token: 0x04005AF9 RID: 23289
		[Nullable(2)]
		protected new IHideWorldMonsterAndMonsterTreasure_SetValue PocoInterface;
	}
}
