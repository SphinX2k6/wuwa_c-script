using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EBF RID: 28351
	[RequiredMember]
	public class GrabItemData : IGrabItemData
	{
		// Token: 0x17009A9E RID: 39582
		// (get) Token: 0x06045099 RID: 282777 RVA: 0x0110EDA5 File Offset: 0x0110CFA5
		// (set) Token: 0x0604509A RID: 282778 RVA: 0x0110EDAD File Offset: 0x0110CFAD
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17009A9F RID: 39583
		// (get) Token: 0x0604509B RID: 282779 RVA: 0x0110EDB6 File Offset: 0x0110CFB6
		// (set) Token: 0x0604509C RID: 282780 RVA: 0x0110EDBE File Offset: 0x0110CFBE
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0604509D RID: 282781 RVA: 0x0110EDC7 File Offset: 0x0110CFC7
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GrabItemData()
		{
		}
	}
}
