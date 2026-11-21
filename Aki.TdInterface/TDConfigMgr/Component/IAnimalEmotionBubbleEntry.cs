using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001E8 RID: 488
	public class IAnimalEmotionBubbleEntry
	{
		// Token: 0x0600078A RID: 1930 RVA: 0x00025BD0 File Offset: 0x00023DD0
		private IAnimalEmotionBubbleEntry_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnimalEmotionBubbleEntry 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnimalEmotionBubbleEntry_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnimalEmotionBubbleEntry_SetValue());
			}
			return result;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00025C08 File Offset: 0x00023E08
		public static IAnimalEmotionBubbleEntry Create([Nullable(2)] IAnimalEmotionBubbleEntry instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalEmotionBubbleEntry
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00025C1B File Offset: 0x00023E1B
		public static IAnimalEmotionBubbleEntry CreateFromSetValue([Nullable(2)] IAnimalEmotionBubbleEntry_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnimalEmotionBubbleEntry
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00025C2E File Offset: 0x00023E2E
		public IAnimalEmotionBubbleEntry_SetValue ToSetValue()
		{
			return new IAnimalEmotionBubbleEntry_SetValue
			{
				MontagePath = this.MontagePath,
				EmotionName = this.EmotionName
			};
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00025C4D File Offset: 0x00023E4D
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00025C78 File Offset: 0x00023E78
		public virtual string MontagePath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MontagePath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MontagePath;
			}
			set
			{
				this.GetOrCreatePoco().MontagePath = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00025C86 File Offset: 0x00023E86
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00025CB1 File Offset: 0x00023EB1
		public virtual string EmotionName
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmotionName;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.EmotionName;
			}
			set
			{
				this.GetOrCreatePoco().EmotionName = value;
			}
		}

		// Token: 0x040008FB RID: 2299
		[Nullable(2)]
		protected IAnimalEmotionBubbleEntry FbInstance;

		// Token: 0x040008FC RID: 2300
		[Nullable(2)]
		protected IAnimalEmotionBubbleEntry_SetValue PocoInterface;
	}
}
