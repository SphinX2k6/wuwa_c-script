using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005132 RID: 20786
	[RequiredMember]
	public class MasterLevelData
	{
		// Token: 0x06035167 RID: 217447 RVA: 0x00C94252 File Offset: 0x00C92452
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MasterLevelData()
		{
		}

		// Token: 0x0401C4A9 RID: 115881
		[RequiredMember]
		public int Level;

		// Token: 0x0401C4AA RID: 115882
		[RequiredMember]
		public int ExpLevel;

		// Token: 0x0401C4AB RID: 115883
		[RequiredMember]
		public int ExpNext;

		// Token: 0x0401C4AC RID: 115884
		[RequiredMember]
		public bool IsMax;
	}
}
