using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001336 RID: 4918
	public class IVisionSystemQuestBase
	{
		// Token: 0x06006EB7 RID: 28343 RVA: 0x00107000 File Offset: 0x00105200
		private IVisionSystemQuestBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestBase_SetValue());
			}
			return result;
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00107038 File Offset: 0x00105238
		public static IVisionSystemQuestBase Create([Nullable(2)] IVisionSystemQuestBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0010704B File Offset: 0x0010524B
		public static IVisionSystemQuestBase CreateFromSetValue([Nullable(2)] IVisionSystemQuestBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0010705E File Offset: 0x0010525E
		public IVisionSystemQuestBase_SetValue ToSetValue()
		{
			return new IVisionSystemQuestBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06006EBB RID: 28347 RVA: 0x00107071 File Offset: 0x00105271
		// (set) Token: 0x06006EBC RID: 28348 RVA: 0x0010709C File Offset: 0x0010529C
		public virtual EVisionSystemQuestType Type
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

		// Token: 0x040041FA RID: 16890
		[Nullable(2)]
		protected IVisionSystemQuestBase FbInstance;

		// Token: 0x040041FB RID: 16891
		[Nullable(2)]
		protected IVisionSystemQuestBase_SetValue PocoInterface;
	}
}
