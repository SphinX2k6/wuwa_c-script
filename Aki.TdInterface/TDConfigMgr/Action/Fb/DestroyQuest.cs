using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B7 RID: 10167
	public class DestroyQuest : ActionParams
	{
		// Token: 0x0600E236 RID: 57910 RVA: 0x00216BA6 File Offset: 0x00214DA6
		[NullableContext(1)]
		public static DestroyQuest Create(IDestroyQuest? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuest
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x0600E237 RID: 57911 RVA: 0x00216BC5 File Offset: 0x00214DC5
		public virtual int QuestId
		{
			get
			{
				return this.Instance.QuestId;
			}
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00216BD4 File Offset: 0x00214DD4
		public virtual bool? IsDestroy
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsDestroy);
			}
		}

		// Token: 0x04007D77 RID: 32119
		private IDestroyQuest Instance;
	}
}
