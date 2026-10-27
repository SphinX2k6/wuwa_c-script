using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E33 RID: 3635
	public class IStreamingSourceConfig
	{
		// Token: 0x0600522E RID: 21038 RVA: 0x000CA7CD File Offset: 0x000C89CD
		[NullableContext(1)]
		public static IStreamingSourceConfig Create(IStreamingSourceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStreamingSourceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x0600522F RID: 21039 RVA: 0x000CA7EC File Offset: 0x000C89EC
		public virtual int StreamingSourceTargetEntityId
		{
			get
			{
				return this.Instance.StreamingSourceTargetEntityId;
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x000CA7FC File Offset: 0x000C89FC
		public virtual bool? IsNoRenderStreaming
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsNoRenderStreaming);
			}
		}

		// Token: 0x04002F5A RID: 12122
		private IStreamingSourceConfig Instance;
	}
}
