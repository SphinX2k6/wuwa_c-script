using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D66 RID: 7526
	[NullableContext(1)]
	[Nullable(0)]
	public class IPromptStylePhoto : IPromptStyleBase
	{
		// Token: 0x0600A163 RID: 41315 RVA: 0x0016FA80 File Offset: 0x0016DC80
		private IPromptStylePhoto_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStylePhoto 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStylePhoto_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStylePhoto_SetValue());
			}
			return result;
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x0016FAB8 File Offset: 0x0016DCB8
		public static IPromptStylePhoto Create([Nullable(2)] IPromptStylePhoto instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStylePhoto
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x0016FACB File Offset: 0x0016DCCB
		public static IPromptStylePhoto CreateFromSetValue([Nullable(2)] IPromptStylePhoto_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStylePhoto
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x0016FADE File Offset: 0x0016DCDE
		public new IPromptStylePhoto_SetValue ToSetValue()
		{
			return new IPromptStylePhoto_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EF RID: 12783
		// (get) Token: 0x0600A167 RID: 41319 RVA: 0x0016FAF1 File Offset: 0x0016DCF1
		// (set) Token: 0x0600A168 RID: 41320 RVA: 0x0016FB1C File Offset: 0x0016DD1C
		public override EPromptStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPromptStyle.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400611E RID: 24862
		[Nullable(2)]
		protected new IPromptStylePhoto FbInstance;

		// Token: 0x0400611F RID: 24863
		[Nullable(2)]
		protected new IPromptStylePhoto_SetValue PocoInterface;
	}
}
