using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229E RID: 8862
	public class IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600C10C RID: 49420 RVA: 0x001BC878 File Offset: 0x001BAA78
		private IVisualNovelActivityActionConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelActivityActionConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelActivityActionConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelActivityActionConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600C10D RID: 49421 RVA: 0x001BC8B0 File Offset: 0x001BAAB0
		public static IVisualNovelActivityActionConfigBase Create([Nullable(2)] IVisualNovelActivityActionConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C10E RID: 49422 RVA: 0x001BC8C3 File Offset: 0x001BAAC3
		public static IVisualNovelActivityActionConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelActivityActionConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C10F RID: 49423 RVA: 0x001BC8D6 File Offset: 0x001BAAD6
		public IVisualNovelActivityActionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelActivityActionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003AA9 RID: 15017
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x001BC8E9 File Offset: 0x001BAAE9
		// (set) Token: 0x0600C111 RID: 49425 RVA: 0x001BC914 File Offset: 0x001BAB14
		public virtual EVisualNovelSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007366 RID: 29542
		[Nullable(2)]
		protected IVisualNovelActivityActionConfigBase FbInstance;

		// Token: 0x04007367 RID: 29543
		[Nullable(2)]
		protected IVisualNovelActivityActionConfigBase_SetValue PocoInterface;
	}
}
