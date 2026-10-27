using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000ADF RID: 2783
	public class IAudioControlType
	{
		// Token: 0x06004018 RID: 16408 RVA: 0x000A3C09 File Offset: 0x000A1E09
		[NullableContext(1)]
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

		// Token: 0x17001017 RID: 4119
		// (get) Token: 0x06004019 RID: 16409 RVA: 0x000A3C28 File Offset: 0x000A1E28
		public virtual EAudioControlType Type
		{
			get
			{
				return (EAudioControlType)this.Instance.Type;
			}
		}

		// Token: 0x040023AC RID: 9132
		private IAudioControlType Instance;
	}
}
