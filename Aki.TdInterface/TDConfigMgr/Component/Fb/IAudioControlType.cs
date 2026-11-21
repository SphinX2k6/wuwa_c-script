using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA9 RID: 2985
	public class IAudioControlType
	{
		// Token: 0x06004442 RID: 17474 RVA: 0x000AD1FD File Offset: 0x000AB3FD
		public static IAudioControlType Create(IAudioControlType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioControlType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170010EB RID: 4331
		// (get) Token: 0x06004443 RID: 17475 RVA: 0x000AD21C File Offset: 0x000AB41C
		public virtual EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x040025C8 RID: 9672
		private IAudioControlType Instance;
	}
}
