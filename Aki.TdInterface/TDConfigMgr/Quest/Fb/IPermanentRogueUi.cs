using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013A1 RID: 5025
	public class IPermanentRogueUi : IShowUi
	{
		// Token: 0x060072D5 RID: 29397 RVA: 0x00113D7A File Offset: 0x00111F7A
		[NullableContext(1)]
		public static IPermanentRogueUi Create(IPermanentRogueUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPermanentRogueUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x060072D6 RID: 29398 RVA: 0x00113D99 File Offset: 0x00111F99
		public override EShowUiType Type
		{
			get
			{
				return (EShowUiType)this.Instance.Type;
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x060072D7 RID: 29399 RVA: 0x00113DA6 File Offset: 0x00111FA6
		public virtual ERogueUiType UiType
		{
			get
			{
				return (ERogueUiType)this.Instance.UiType;
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x060072D8 RID: 29400 RVA: 0x00113DB3 File Offset: 0x00111FB3
		public virtual int BindId
		{
			get
			{
				return this.Instance.BindId;
			}
		}

		// Token: 0x0400425F RID: 16991
		private IPermanentRogueUi Instance;
	}
}
