using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFB RID: 7931
	[NullableContext(1)]
	[Nullable(0)]
	public class ISwitchDataLayersTransitionType
	{
		// Token: 0x0600A99A RID: 43418 RVA: 0x0017E4F8 File Offset: 0x0017C6F8
		private ISwitchDataLayersTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISwitchDataLayersTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISwitchDataLayersTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISwitchDataLayersTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x0017E530 File Offset: 0x0017C730
		public static ISwitchDataLayersTransitionType Create([Nullable(2)] ISwitchDataLayersTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A99C RID: 43420 RVA: 0x0017E543 File Offset: 0x0017C743
		public static ISwitchDataLayersTransitionType CreateFromSetValue([Nullable(2)] ISwitchDataLayersTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISwitchDataLayersTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x0017E556 File Offset: 0x0017C756
		public ISwitchDataLayersTransitionType_SetValue ToSetValue()
		{
			return new ISwitchDataLayersTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x0017E569 File Offset: 0x0017C769
		// (set) Token: 0x0600A99F RID: 43423 RVA: 0x0017E594 File Offset: 0x0017C794
		public virtual ESwitchDataLayersTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESwitchDataLayersTransitionType.Sequence;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064DF RID: 25823
		[Nullable(2)]
		protected ISwitchDataLayersTransitionType FbInstance;

		// Token: 0x040064E0 RID: 25824
		[Nullable(2)]
		protected ISwitchDataLayersTransitionType_SetValue PocoInterface;
	}
}
