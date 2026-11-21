using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB0 RID: 7344
	public class IHideRangeType
	{
		// Token: 0x06009BF4 RID: 39924 RVA: 0x00167E74 File Offset: 0x00166074
		private IHideRangeType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideRangeType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideRangeType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideRangeType_SetValue());
			}
			return result;
		}

		// Token: 0x06009BF5 RID: 39925 RVA: 0x00167EAC File Offset: 0x001660AC
		public static IHideRangeType Create([Nullable(2)] IHideRangeType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BF6 RID: 39926 RVA: 0x00167EBF File Offset: 0x001660BF
		public static IHideRangeType CreateFromSetValue([Nullable(2)] IHideRangeType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideRangeType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BF7 RID: 39927 RVA: 0x00167ED2 File Offset: 0x001660D2
		public IHideRangeType_SetValue ToSetValue()
		{
			return new IHideRangeType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030FF RID: 12543
		// (get) Token: 0x06009BF8 RID: 39928 RVA: 0x00167EE5 File Offset: 0x001660E5
		// (set) Token: 0x06009BF9 RID: 39929 RVA: 0x00167F10 File Offset: 0x00166110
		public virtual EHideType Type
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

		// Token: 0x04005F76 RID: 24438
		[Nullable(2)]
		protected IHideRangeType FbInstance;

		// Token: 0x04005F77 RID: 24439
		[Nullable(2)]
		protected IHideRangeType_SetValue PocoInterface;
	}
}
