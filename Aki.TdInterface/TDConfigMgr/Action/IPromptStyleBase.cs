using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5E RID: 7518
	[NullableContext(1)]
	[Nullable(0)]
	public class IPromptStyleBase
	{
		// Token: 0x0600A143 RID: 41283 RVA: 0x0016F790 File Offset: 0x0016D990
		private IPromptStyleBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPromptStyleBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPromptStyleBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPromptStyleBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x0016F7C8 File Offset: 0x0016D9C8
		public static IPromptStyleBase Create([Nullable(2)] IPromptStyleBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPromptStyleBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x0016F7DB File Offset: 0x0016D9DB
		public static IPromptStyleBase CreateFromSetValue([Nullable(2)] IPromptStyleBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPromptStyleBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x0016F7EE File Offset: 0x0016D9EE
		public IPromptStyleBase_SetValue ToSetValue()
		{
			return new IPromptStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A147 RID: 41287 RVA: 0x0016F801 File Offset: 0x0016DA01
		// (set) Token: 0x0600A148 RID: 41288 RVA: 0x0016F82C File Offset: 0x0016DA2C
		public virtual EPromptStyle Type
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

		// Token: 0x04006112 RID: 24850
		[Nullable(2)]
		protected IPromptStyleBase FbInstance;

		// Token: 0x04006113 RID: 24851
		[Nullable(2)]
		protected IPromptStyleBase_SetValue PocoInterface;
	}
}
