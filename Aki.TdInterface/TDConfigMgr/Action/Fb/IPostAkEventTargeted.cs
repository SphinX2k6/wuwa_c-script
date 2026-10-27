using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200281D RID: 10269
	[NullableContext(1)]
	[Nullable(0)]
	public class IPostAkEventTargeted : IPostAkEventType
	{
		// Token: 0x0600E3C8 RID: 58312 RVA: 0x00218E7C File Offset: 0x0021707C
		public static IPostAkEventTargeted Create(IPostAkEventTargeted? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPostAkEventTargeted
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x0600E3C9 RID: 58313 RVA: 0x00218E9B File Offset: 0x0021709B
		public override EPostAkEvent Type
		{
			get
			{
				return (EPostAkEvent)this.Instance.Type;
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x0600E3CA RID: 58314 RVA: 0x00218EA8 File Offset: 0x002170A8
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x0600E3CB RID: 58315 RVA: 0x00218EB5 File Offset: 0x002170B5
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04007E15 RID: 32277
		private IPostAkEventTargeted Instance;
	}
}
