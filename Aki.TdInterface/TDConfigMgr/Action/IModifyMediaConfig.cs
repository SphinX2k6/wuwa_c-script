using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DD9 RID: 7641
	public class IModifyMediaConfig
	{
		// Token: 0x0600A237 RID: 41527 RVA: 0x00173538 File Offset: 0x00171738
		private IModifyMediaConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IModifyMediaConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IModifyMediaConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IModifyMediaConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A238 RID: 41528 RVA: 0x00173570 File Offset: 0x00171770
		public static IModifyMediaConfig Create([Nullable(2)] IModifyMediaConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x00173583 File Offset: 0x00171783
		public static IModifyMediaConfig CreateFromSetValue([Nullable(2)] IModifyMediaConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IModifyMediaConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x00173596 File Offset: 0x00171796
		public IModifyMediaConfig_SetValue ToSetValue()
		{
			return new IModifyMediaConfig_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A23B RID: 41531 RVA: 0x001735A9 File Offset: 0x001717A9
		// (set) Token: 0x0600A23C RID: 41532 RVA: 0x001735D4 File Offset: 0x001717D4
		public virtual EModifyActorMediaType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModifyActorMediaType.ChangeMediaPlayDA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006263 RID: 25187
		[Nullable(2)]
		protected IModifyMediaConfig FbInstance;

		// Token: 0x04006264 RID: 25188
		[Nullable(2)]
		protected IModifyMediaConfig_SetValue PocoInterface;
	}
}
