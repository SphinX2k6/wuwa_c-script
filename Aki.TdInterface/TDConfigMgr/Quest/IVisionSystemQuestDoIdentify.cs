using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200133A RID: 4922
	public class IVisionSystemQuestDoIdentify : IVisionSystemQuestBase
	{
		// Token: 0x06006ECB RID: 28363 RVA: 0x0010723C File Offset: 0x0010543C
		private IVisionSystemQuestDoIdentify_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestDoIdentify 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestDoIdentify_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestDoIdentify_SetValue());
			}
			return result;
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00107274 File Offset: 0x00105474
		public static IVisionSystemQuestDoIdentify Create([Nullable(2)] IVisionSystemQuestDoIdentify instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestDoIdentify
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00107287 File Offset: 0x00105487
		public static IVisionSystemQuestDoIdentify CreateFromSetValue([Nullable(2)] IVisionSystemQuestDoIdentify_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestDoIdentify
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x0010729A File Offset: 0x0010549A
		public new IVisionSystemQuestDoIdentify_SetValue ToSetValue()
		{
			return new IVisionSystemQuestDoIdentify_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06006ECF RID: 28367 RVA: 0x001072AD File Offset: 0x001054AD
		// (set) Token: 0x06006ED0 RID: 28368 RVA: 0x001072D8 File Offset: 0x001054D8
		public override EVisionSystemQuestType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisionSystemQuestType.HasVisionGetTargetLevel;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04004204 RID: 16900
		[Nullable(2)]
		protected new IVisionSystemQuestDoIdentify FbInstance;

		// Token: 0x04004205 RID: 16901
		[Nullable(2)]
		protected new IVisionSystemQuestDoIdentify_SetValue PocoInterface;
	}
}
