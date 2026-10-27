using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011FA RID: 4602
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisionSystemQuestBase
	{
		// Token: 0x06006876 RID: 26742 RVA: 0x000F96F4 File Offset: 0x000F78F4
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

		// Token: 0x06006877 RID: 26743 RVA: 0x000F972C File Offset: 0x000F792C
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

		// Token: 0x06006878 RID: 26744 RVA: 0x000F973F File Offset: 0x000F793F
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

		// Token: 0x06006879 RID: 26745 RVA: 0x000F9752 File Offset: 0x000F7952
		public IVisionSystemQuestBase_SetValue ToSetValue()
		{
			return new IVisionSystemQuestBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600687A RID: 26746 RVA: 0x000F9765 File Offset: 0x000F7965
		// (set) Token: 0x0600687B RID: 26747 RVA: 0x000F9790 File Offset: 0x000F7990
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

		// Token: 0x04003E8C RID: 16012
		[Nullable(2)]
		protected IVisionSystemQuestBase FbInstance;

		// Token: 0x04003E8D RID: 16013
		[Nullable(2)]
		protected IVisionSystemQuestBase_SetValue PocoInterface;
	}
}
