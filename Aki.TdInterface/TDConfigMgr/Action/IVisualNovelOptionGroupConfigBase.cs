using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002075 RID: 8309
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelOptionGroupConfigBase
	{
		// Token: 0x0600B67E RID: 46718 RVA: 0x001A7088 File Offset: 0x001A5288
		private IVisualNovelOptionGroupConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelOptionGroupConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelOptionGroupConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelOptionGroupConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x001A70C0 File Offset: 0x001A52C0
		public static IVisualNovelOptionGroupConfigBase Create([Nullable(2)] IVisualNovelOptionGroupConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x001A70D3 File Offset: 0x001A52D3
		public static IVisualNovelOptionGroupConfigBase CreateFromSetValue([Nullable(2)] IVisualNovelOptionGroupConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelOptionGroupConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x001A70E6 File Offset: 0x001A52E6
		public IVisualNovelOptionGroupConfigBase_SetValue ToSetValue()
		{
			return new IVisualNovelOptionGroupConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600B682 RID: 46722 RVA: 0x001A70F9 File Offset: 0x001A52F9
		// (set) Token: 0x0600B683 RID: 46723 RVA: 0x001A7124 File Offset: 0x001A5324
		public virtual EVisualNovelOptionGroupType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelOptionGroupType.SolarSchoolExam;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D9B RID: 28059
		[Nullable(2)]
		protected IVisualNovelOptionGroupConfigBase FbInstance;

		// Token: 0x04006D9C RID: 28060
		[Nullable(2)]
		protected IVisualNovelOptionGroupConfigBase_SetValue PocoInterface;
	}
}
