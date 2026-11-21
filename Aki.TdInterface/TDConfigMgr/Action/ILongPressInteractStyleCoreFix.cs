using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D8F RID: 7567
	public class ILongPressInteractStyleCoreFix : ILongPressInteractStyleConfig
	{
		// Token: 0x0600A0A5 RID: 41125 RVA: 0x0017064C File Offset: 0x0016E84C
		private ILongPressInteractStyleCoreFix_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILongPressInteractStyleCoreFix 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILongPressInteractStyleCoreFix_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILongPressInteractStyleCoreFix_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00170684 File Offset: 0x0016E884
		public static ILongPressInteractStyleCoreFix Create([Nullable(2)] ILongPressInteractStyleCoreFix instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00170697 File Offset: 0x0016E897
		public static ILongPressInteractStyleCoreFix CreateFromSetValue([Nullable(2)] ILongPressInteractStyleCoreFix_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILongPressInteractStyleCoreFix
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x001706AA File Offset: 0x0016E8AA
		public new ILongPressInteractStyleCoreFix_SetValue ToSetValue()
		{
			return new ILongPressInteractStyleCoreFix_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600A0A9 RID: 41129 RVA: 0x001706BD File Offset: 0x0016E8BD
		// (set) Token: 0x0600A0AA RID: 41130 RVA: 0x001706E8 File Offset: 0x0016E8E8
		public override ELongPressInteractStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELongPressInteractStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061A1 RID: 24993
		[Nullable(2)]
		protected new ILongPressInteractStyleCoreFix FbInstance;

		// Token: 0x040061A2 RID: 24994
		[Nullable(2)]
		protected new ILongPressInteractStyleCoreFix_SetValue PocoInterface;
	}
}
