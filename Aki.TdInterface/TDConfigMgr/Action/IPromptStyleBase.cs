using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6F RID: 8047
	public class IPromptStyleBase
	{
		// Token: 0x0600AB2F RID: 43823 RVA: 0x00183BB4 File Offset: 0x00181DB4
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

		// Token: 0x0600AB30 RID: 43824 RVA: 0x00183BEC File Offset: 0x00181DEC
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

		// Token: 0x0600AB31 RID: 43825 RVA: 0x00183BFF File Offset: 0x00181DFF
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

		// Token: 0x0600AB32 RID: 43826 RVA: 0x00183C12 File Offset: 0x00181E12
		public IPromptStyleBase_SetValue ToSetValue()
		{
			return new IPromptStyleBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600AB33 RID: 43827 RVA: 0x00183C25 File Offset: 0x00181E25
		// (set) Token: 0x0600AB34 RID: 43828 RVA: 0x00183C50 File Offset: 0x00181E50
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

		// Token: 0x0400668E RID: 26254
		[Nullable(2)]
		protected IPromptStyleBase FbInstance;

		// Token: 0x0400668F RID: 26255
		[Nullable(2)]
		protected IPromptStyleBase_SetValue PocoInterface;
	}
}
