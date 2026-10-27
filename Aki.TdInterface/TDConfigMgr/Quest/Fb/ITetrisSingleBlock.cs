using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146B RID: 5227
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisSingleBlock
	{
		// Token: 0x060076F0 RID: 30448 RVA: 0x0011C496 File Offset: 0x0011A696
		public static ITetrisSingleBlock Create(ITetrisSingleBlock? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisSingleBlock
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027ED RID: 10221
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x0011C4B5 File Offset: 0x0011A6B5
		public virtual string StyleName
		{
			get
			{
				return this.Instance.StyleName;
			}
		}

		// Token: 0x04004521 RID: 17697
		private ITetrisSingleBlock Instance;
	}
}
