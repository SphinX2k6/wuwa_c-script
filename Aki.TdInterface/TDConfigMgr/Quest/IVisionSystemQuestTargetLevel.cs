using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200133E RID: 4926
	public class IVisionSystemQuestTargetLevel : IVisionSystemQuestBase
	{
		// Token: 0x06006EDD RID: 28381 RVA: 0x001073F8 File Offset: 0x001055F8
		private IVisionSystemQuestTargetLevel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisionSystemQuestTargetLevel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisionSystemQuestTargetLevel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisionSystemQuestTargetLevel_SetValue());
			}
			return result;
		}

		// Token: 0x06006EDE RID: 28382 RVA: 0x00107430 File Offset: 0x00105630
		public static IVisionSystemQuestTargetLevel Create([Nullable(2)] IVisionSystemQuestTargetLevel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisionSystemQuestTargetLevel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006EDF RID: 28383 RVA: 0x00107443 File Offset: 0x00105643
		public static IVisionSystemQuestTargetLevel CreateFromSetValue([Nullable(2)] IVisionSystemQuestTargetLevel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisionSystemQuestTargetLevel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00107456 File Offset: 0x00105656
		public new IVisionSystemQuestTargetLevel_SetValue ToSetValue()
		{
			return new IVisionSystemQuestTargetLevel_SetValue
			{
				Type = this.Type,
				TargetLevel = this.TargetLevel
			};
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x06006EE1 RID: 28385 RVA: 0x00107475 File Offset: 0x00105675
		// (set) Token: 0x06006EE2 RID: 28386 RVA: 0x001074A0 File Offset: 0x001056A0
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

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06006EE3 RID: 28387 RVA: 0x001074AE File Offset: 0x001056AE
		// (set) Token: 0x06006EE4 RID: 28388 RVA: 0x001074D9 File Offset: 0x001056D9
		public virtual int TargetLevel
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetLevel;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TargetLevel;
			}
			set
			{
				this.GetOrCreatePoco().TargetLevel = value;
			}
		}

		// Token: 0x0400420B RID: 16907
		[Nullable(2)]
		protected new IVisionSystemQuestTargetLevel FbInstance;

		// Token: 0x0400420C RID: 16908
		[Nullable(2)]
		protected new IVisionSystemQuestTargetLevel_SetValue PocoInterface;
	}
}
