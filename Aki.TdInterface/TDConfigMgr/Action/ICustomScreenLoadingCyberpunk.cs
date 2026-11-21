using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AD9 RID: 6873
	public class ICustomScreenLoadingCyberpunk : ICustomScreenLoadingTypeBase
	{
		// Token: 0x06009203 RID: 37379 RVA: 0x0015658C File Offset: 0x0015478C
		private ICustomScreenLoadingCyberpunk_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomScreenLoadingCyberpunk 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomScreenLoadingCyberpunk_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomScreenLoadingCyberpunk_SetValue());
			}
			return result;
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x001565C4 File Offset: 0x001547C4
		public static ICustomScreenLoadingCyberpunk Create([Nullable(2)] ICustomScreenLoadingCyberpunk instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x001565D7 File Offset: 0x001547D7
		public static ICustomScreenLoadingCyberpunk CreateFromSetValue([Nullable(2)] ICustomScreenLoadingCyberpunk_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomScreenLoadingCyberpunk
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x001565EA File Offset: 0x001547EA
		public new ICustomScreenLoadingCyberpunk_SetValue ToSetValue()
		{
			return new ICustomScreenLoadingCyberpunk_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EC8 RID: 11976
		// (get) Token: 0x06009207 RID: 37383 RVA: 0x001565FD File Offset: 0x001547FD
		// (set) Token: 0x06009208 RID: 37384 RVA: 0x00156628 File Offset: 0x00154828
		public override ECustomScreenLoading Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECustomScreenLoading.Cyberpunk;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B05 RID: 23301
		[Nullable(2)]
		protected new ICustomScreenLoadingCyberpunk FbInstance;

		// Token: 0x04005B06 RID: 23302
		[Nullable(2)]
		protected new ICustomScreenLoadingCyberpunk_SetValue PocoInterface;
	}
}
