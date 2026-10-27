using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200120C RID: 4620
	[NullableContext(1)]
	[Nullable(0)]
	public class IWarningPreformFadeInScreen : IWarningPreformType
	{
		// Token: 0x060068DA RID: 26842 RVA: 0x000FA218 File Offset: 0x000F8418
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

		// Token: 0x060068DB RID: 26843 RVA: 0x000FA250 File Offset: 0x000F8450
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

		// Token: 0x060068DC RID: 26844 RVA: 0x000FA263 File Offset: 0x000F8463
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

		// Token: 0x060068DD RID: 26845 RVA: 0x000FA276 File Offset: 0x000F8476
		public new IWarningPreformFadeInScreen_SetValue ToSetValue()
		{
			return new IWarningPreformFadeInScreen_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x000FA289 File Offset: 0x000F8489
		// (set) Token: 0x060068DF RID: 26847 RVA: 0x000FA2B4 File Offset: 0x000F84B4
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

		// Token: 0x04003EBB RID: 16059
		[Nullable(2)]
		protected new IWarningPreformFadeInScreen FbInstance;

		// Token: 0x04003EBC RID: 16060
		[Nullable(2)]
		protected new IWarningPreformFadeInScreen_SetValue PocoInterface;
	}
}
