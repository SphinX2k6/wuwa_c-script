using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C5 RID: 453
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalEmotionBubbleEntry
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x000248CC File Offset: 0x00022ACC
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

		// Token: 0x06000737 RID: 1847 RVA: 0x00024904 File Offset: 0x00022B04
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

		// Token: 0x06000738 RID: 1848 RVA: 0x00024917 File Offset: 0x00022B17
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

		// Token: 0x06000739 RID: 1849 RVA: 0x0002492A File Offset: 0x00022B2A
		public IAnimalEmotionBubbleEntry_SetValue ToSetValue()
		{
			return new IAnimalEmotionBubbleEntry_SetValue
			{
				MontagePath = this.MontagePath,
				EmotionName = this.EmotionName
			};
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x00024949 File Offset: 0x00022B49
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x00024974 File Offset: 0x00022B74
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00024982 File Offset: 0x00022B82
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x000249AD File Offset: 0x00022BAD
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

		// Token: 0x04000887 RID: 2183
		[Nullable(2)]
		protected IAnimalEmotionBubbleEntry FbInstance;

		// Token: 0x04000888 RID: 2184
		[Nullable(2)]
		protected IAnimalEmotionBubbleEntry_SetValue PocoInterface;
	}
}
