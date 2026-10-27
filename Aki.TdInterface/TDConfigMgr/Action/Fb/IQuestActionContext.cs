using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020024C9 RID: 9417
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuestActionContext : IActionContextType
	{
		// Token: 0x0600D265 RID: 53861 RVA: 0x001F38A2 File Offset: 0x001F1AA2
		public static IQuestActionContext Create(IQuestActionContext? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuestActionContext
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x0600D266 RID: 53862 RVA: 0x001F38C1 File Offset: 0x001F1AC1
		public new virtual string Type
		{
			get
			{
				return this.Instance.Type;
			}
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x0600D267 RID: 53863 RVA: 0x001F38D0 File Offset: 0x001F1AD0
		public virtual bool? IsChildQuestOfDungeon
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsChildQuestOfDungeon);
			}
		}

		// Token: 0x04007371 RID: 29553
		private IQuestActionContext Instance;
	}
}
