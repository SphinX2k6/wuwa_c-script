using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A8 RID: 8872
	public class IVisualNovelCgBase
	{
		// Token: 0x0600C138 RID: 49464 RVA: 0x001BCCAC File Offset: 0x001BAEAC
		private IVisualNovelCgBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelCgBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelCgBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelCgBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x001BCCE4 File Offset: 0x001BAEE4
		public static IVisualNovelCgBase Create([Nullable(2)] IVisualNovelCgBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x001BCCF7 File Offset: 0x001BAEF7
		public static IVisualNovelCgBase CreateFromSetValue([Nullable(2)] IVisualNovelCgBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelCgBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x001BCD0A File Offset: 0x001BAF0A
		public IVisualNovelCgBase_SetValue ToSetValue()
		{
			return new IVisualNovelCgBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AB0 RID: 15024
		// (get) Token: 0x0600C13C RID: 49468 RVA: 0x001BCD1D File Offset: 0x001BAF1D
		// (set) Token: 0x0600C13D RID: 49469 RVA: 0x001BCD48 File Offset: 0x001BAF48
		public virtual EVisualNovelCgType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelCgType.LoadPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007377 RID: 29559
		[Nullable(2)]
		protected IVisualNovelCgBase FbInstance;

		// Token: 0x04007378 RID: 29560
		[Nullable(2)]
		protected IVisualNovelCgBase_SetValue PocoInterface;
	}
}
