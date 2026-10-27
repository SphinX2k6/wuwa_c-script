using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F70 RID: 8048
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkOptionFirstSelect : ITalkOptionPreConditionBase
	{
		// Token: 0x0600B11E RID: 45342 RVA: 0x0019D8EC File Offset: 0x0019BAEC
		private ITalkOptionFirstSelect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkOptionFirstSelect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkOptionFirstSelect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkOptionFirstSelect_SetValue());
			}
			return result;
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x0019D924 File Offset: 0x0019BB24
		public static ITalkOptionFirstSelect Create([Nullable(2)] ITalkOptionFirstSelect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x0019D937 File Offset: 0x0019BB37
		public static ITalkOptionFirstSelect CreateFromSetValue([Nullable(2)] ITalkOptionFirstSelect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkOptionFirstSelect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x0019D94A File Offset: 0x0019BB4A
		public new ITalkOptionFirstSelect_SetValue ToSetValue()
		{
			return new ITalkOptionFirstSelect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600B122 RID: 45346 RVA: 0x0019D95D File Offset: 0x0019BB5D
		// (set) Token: 0x0600B123 RID: 45347 RVA: 0x0019D988 File Offset: 0x0019BB88
		public override ETalkOptionPreConditionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkOptionPreConditionType.PreOption;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B2C RID: 27436
		[Nullable(2)]
		protected new ITalkOptionFirstSelect FbInstance;

		// Token: 0x04006B2D RID: 27437
		[Nullable(2)]
		protected new ITalkOptionFirstSelect_SetValue PocoInterface;
	}
}
