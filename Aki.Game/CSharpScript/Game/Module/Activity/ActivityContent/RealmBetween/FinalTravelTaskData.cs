using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E9 RID: 20969
	public class FinalTravelTaskData
	{
		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x060343EA RID: 213994 RVA: 0x00E9D7E3 File Offset: 0x00E9B9E3
		public int Current
		{
			get
			{
				return this.FinishedIdSet.Count;
			}
		}

		// Token: 0x060343EB RID: 213995 RVA: 0x00E9D7F0 File Offset: 0x00E9B9F0
		public bool CanReceive()
		{
			return !this.IsReceived && this.Current == this.Target;
		}

		// Token: 0x0401BB77 RID: 113527
		public int Target = 1;

		// Token: 0x0401BB78 RID: 113528
		[Nullable(1)]
		public HashSet<int> FinishedIdSet = new HashSet<int>();

		// Token: 0x0401BB79 RID: 113529
		public bool IsReceived;
	}
}
