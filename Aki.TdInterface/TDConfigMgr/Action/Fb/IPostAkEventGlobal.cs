using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281E RID: 10270
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventGlobal : IPostAkEventType
	{
		// Token: 0x0600E3CD RID: 58317 RVA: 0x00218ECA File Offset: 0x002170CA
		public static IPostAkEventGlobal Create(IPostAkEventGlobal? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventGlobal
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x00218EE9 File Offset: 0x002170E9
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x00218EF6 File Offset: 0x002170F6
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04007E16 RID: 32278
		private IPostAkEventGlobal Instance;
	}
}
