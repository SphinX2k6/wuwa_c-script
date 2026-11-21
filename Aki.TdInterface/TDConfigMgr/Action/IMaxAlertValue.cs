using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA9 RID: 7593
	public class IMaxAlertValue : ISetAlertValueType
	{
		// Token: 0x0600A12F RID: 41263 RVA: 0x001717B8 File Offset: 0x0016F9B8
		private IMaxAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMaxAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMaxAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMaxAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x001717F0 File Offset: 0x0016F9F0
		public static IMaxAlertValue Create([Nullable(2)] IMaxAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x00171803 File Offset: 0x0016FA03
		public static IMaxAlertValue CreateFromSetValue([Nullable(2)] IMaxAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMaxAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x00171816 File Offset: 0x0016FA16
		public new IMaxAlertValue_SetValue ToSetValue()
		{
			return new IMaxAlertValue_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A133 RID: 41267 RVA: 0x00171829 File Offset: 0x0016FA29
		// (set) Token: 0x0600A134 RID: 41268 RVA: 0x00171854 File Offset: 0x0016FA54
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061ED RID: 25069
		[Nullable(2)]
		protected new IMaxAlertValue FbInstance;

		// Token: 0x040061EE RID: 25070
		[Nullable(2)]
		protected new IMaxAlertValue_SetValue PocoInterface;
	}
}
