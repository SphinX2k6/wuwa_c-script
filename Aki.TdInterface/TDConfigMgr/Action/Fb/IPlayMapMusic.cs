using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002820 RID: 10272
	public class IPlayMapMusic : IAkEventMapType
	{
		// Token: 0x0600E3D4 RID: 58324 RVA: 0x00218F3F File Offset: 0x0021713F
		[NullableContext(1)]
		public static IPlayMapMusic Create(IPlayMapMusic? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMapMusic
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x00218F5E File Offset: 0x0021715E
		public override EAkEventMap Type
		{
			get
			{
				return (EAkEventMap)this.Instance.Type;
			}
		}

		// Token: 0x04007E18 RID: 32280
		private IPlayMapMusic Instance;
	}
}
