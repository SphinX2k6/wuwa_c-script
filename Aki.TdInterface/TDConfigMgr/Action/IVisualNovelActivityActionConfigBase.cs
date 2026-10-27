using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002055 RID: 8277
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600B5E6 RID: 46566 RVA: 0x001A610C File Offset: 0x001A430C
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

		// Token: 0x0600B5E7 RID: 46567 RVA: 0x001A6144 File Offset: 0x001A4344
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

		// Token: 0x0600B5E8 RID: 46568 RVA: 0x001A6157 File Offset: 0x001A4357
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

		// Token: 0x0600B5E9 RID: 46569 RVA: 0x001A616A File Offset: 0x001A436A
		public IVisualNovelActivityActionConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelActivityActionConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600B5EA RID: 46570 RVA: 0x001A617D File Offset: 0x001A437D
		// (set) Token: 0x0600B5EB RID: 46571 RVA: 0x001A61A8 File Offset: 0x001A43A8
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

		// Token: 0x04006D5D RID: 27997
		[Nullable(2)]
		protected IVisualNovelActivityActionConfigBase FbInstance;

		// Token: 0x04006D5E RID: 27998
		[Nullable(2)]
		protected IVisualNovelActivityActionConfigBase_SetValue PocoInterface;
	}
}
