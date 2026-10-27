using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013B3 RID: 5043
	[NullableContext(1)]
	[Nullable(0)]
	public class ITakePhoto2SequenceCondition
	{
		// Token: 0x06007329 RID: 29481 RVA: 0x001148D4 File Offset: 0x00112AD4
		public static ITakePhoto2SequenceCondition Create(ITakePhoto2SequenceCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITakePhoto2SequenceCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x0600732A RID: 29482 RVA: 0x001148F3 File Offset: 0x00112AF3
		public virtual string SequencePath
		{
			get
			{
				return this.Instance.SequencePath;
			}
		}

		// Token: 0x04004299 RID: 17049
		private ITakePhoto2SequenceCondition Instance;
	}
}
