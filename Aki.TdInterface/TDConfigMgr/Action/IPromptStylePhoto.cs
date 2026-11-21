using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F77 RID: 8055
	public class IPromptStylePhoto : IPromptStyleBase
	{
		// Token: 0x0600AB4F RID: 43855 RVA: 0x00183EA4 File Offset: 0x001820A4
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

		// Token: 0x0600AB50 RID: 43856 RVA: 0x00183EDC File Offset: 0x001820DC
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

		// Token: 0x0600AB51 RID: 43857 RVA: 0x00183EEF File Offset: 0x001820EF
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

		// Token: 0x0600AB52 RID: 43858 RVA: 0x00183F02 File Offset: 0x00182102
		public new IPromptStylePhoto_SetValue ToSetValue()
		{
			return new IPromptStylePhoto_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600AB53 RID: 43859 RVA: 0x00183F15 File Offset: 0x00182115
		// (set) Token: 0x0600AB54 RID: 43860 RVA: 0x00183F40 File Offset: 0x00182140
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

		// Token: 0x0400669A RID: 26266
		[Nullable(2)]
		protected new IPromptStylePhoto FbInstance;

		// Token: 0x0400669B RID: 26267
		[Nullable(2)]
		protected new IPromptStylePhoto_SetValue PocoInterface;
	}
}
