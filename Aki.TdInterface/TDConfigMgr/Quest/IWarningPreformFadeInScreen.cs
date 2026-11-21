using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001348 RID: 4936
	public class IWarningPreformFadeInScreen : IWarningPreformType
	{
		// Token: 0x06006F1B RID: 28443 RVA: 0x00107B24 File Offset: 0x00105D24
		private IWarningPreformFadeInScreen_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IWarningPreformFadeInScreen 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IWarningPreformFadeInScreen_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IWarningPreformFadeInScreen_SetValue());
			}
			return result;
		}

		// Token: 0x06006F1C RID: 28444 RVA: 0x00107B5C File Offset: 0x00105D5C
		public static IWarningPreformFadeInScreen Create([Nullable(2)] IWarningPreformFadeInScreen instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWarningPreformFadeInScreen
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00107B6F File Offset: 0x00105D6F
		public static IWarningPreformFadeInScreen CreateFromSetValue([Nullable(2)] IWarningPreformFadeInScreen_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IWarningPreformFadeInScreen
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00107B82 File Offset: 0x00105D82
		public new IWarningPreformFadeInScreen_SetValue ToSetValue()
		{
			return new IWarningPreformFadeInScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x06006F1F RID: 28447 RVA: 0x00107B95 File Offset: 0x00105D95
		// (set) Token: 0x06006F20 RID: 28448 RVA: 0x00107BC0 File Offset: 0x00105DC0
		public override EWarningPreformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EWarningPreformType.FadeInScreen;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004229 RID: 16937
		[Nullable(2)]
		protected new IWarningPreformFadeInScreen FbInstance;

		// Token: 0x0400422A RID: 16938
		[Nullable(2)]
		protected new IWarningPreformFadeInScreen_SetValue PocoInterface;
	}
}
