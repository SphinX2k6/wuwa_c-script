using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002ABE RID: 10942
	public class IAudioTypeBase
	{
		// Token: 0x0600F024 RID: 61476 RVA: 0x0022E19C File Offset: 0x0022C39C
		[NullableContext(1)]
		public static IAudioTypeBase Create(IAudioTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAudioTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C6A RID: 19562
		// (get) Token: 0x0600F025 RID: 61477 RVA: 0x0022E1BB File Offset: 0x0022C3BB
		public virtual EAudioType Type
		{
			get
			{
				return (EAudioType)this.Instance.Type;
			}
		}

		// Token: 0x04008418 RID: 33816
		private IAudioTypeBase Instance;
	}
}
