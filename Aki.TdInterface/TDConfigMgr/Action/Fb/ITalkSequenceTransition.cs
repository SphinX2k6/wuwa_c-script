using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020025AF RID: 9647
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkSequenceTransition
	{
		// Token: 0x0600D904 RID: 55556 RVA: 0x0020616E File Offset: 0x0020436E
		public static ITalkSequenceTransition Create(ITalkSequenceTransition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkSequenceTransition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x0600D905 RID: 55557 RVA: 0x0020618D File Offset: 0x0020438D
		public virtual string OptionText
		{
			get
			{
				return this.Instance.OptionText;
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x0600D906 RID: 55558 RVA: 0x0020619A File Offset: 0x0020439A
		public virtual string OptionTextKey
		{
			get
			{
				return this.Instance.OptionTextKey;
			}
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x0600D907 RID: 55559 RVA: 0x002061A7 File Offset: 0x002043A7
		public virtual int NextSequenceIndex
		{
			get
			{
				return this.Instance.NextSequenceIndex;
			}
		}

		// Token: 0x0400788D RID: 30861
		private ITalkSequenceTransition Instance;
	}
}
