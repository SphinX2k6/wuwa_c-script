using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281F RID: 10271
	public class IAkEventMapType
	{
		// Token: 0x0600E3D1 RID: 58321 RVA: 0x00218F0B File Offset: 0x0021710B
		[NullableContext(1)]
		public static IAkEventMapType Create(IAkEventMapType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAkEventMapType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x00218F2A File Offset: 0x0021712A
		public virtual EAkEventMap Type
		{
			get
			{
				return (EAkEventMap)this.Instance.Type;
			}
		}

		// Token: 0x04007E17 RID: 32279
		private IAkEventMapType Instance;
	}
}
