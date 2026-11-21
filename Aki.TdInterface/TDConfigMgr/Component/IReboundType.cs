using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000701 RID: 1793
	public class IReboundType
	{
		// Token: 0x06002608 RID: 9736 RVA: 0x00066CB0 File Offset: 0x00064EB0
		private IReboundType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IReboundType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IReboundType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IReboundType_SetValue());
			}
			return result;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00066CE8 File Offset: 0x00064EE8
		public static IReboundType Create([Nullable(2)] IReboundType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReboundType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00066CFB File Offset: 0x00064EFB
		public static IReboundType CreateFromSetValue([Nullable(2)] IReboundType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IReboundType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00066D0E File Offset: 0x00064F0E
		public IReboundType_SetValue ToSetValue()
		{
			return new IReboundType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00066D21 File Offset: 0x00064F21
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x00066D4C File Offset: 0x00064F4C
		public virtual EReboundOptionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EReboundOptionType.ForwardFront;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001A38 RID: 6712
		[Nullable(2)]
		protected IReboundType FbInstance;

		// Token: 0x04001A39 RID: 6713
		[Nullable(2)]
		protected IReboundType_SetValue PocoInterface;
	}
}
