using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281C RID: 10268
	public class IPostAkEventType
	{
		// Token: 0x0600E3C5 RID: 58309 RVA: 0x00218E48 File Offset: 0x00217048
		[NullableContext(1)]
		public static IPostAkEventType Create(IPostAkEventType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x0600E3C6 RID: 58310 RVA: 0x00218E67 File Offset: 0x00217067
		public virtual EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x04007E14 RID: 32276
		private IPostAkEventType Instance;
	}
}
