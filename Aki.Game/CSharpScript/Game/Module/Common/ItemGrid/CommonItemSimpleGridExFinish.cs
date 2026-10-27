using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.ItemGrid
{
	// Token: 0x02005B71 RID: 23409
	public class CommonItemSimpleGridExFinish : CommonItemSimpleGrid
	{
		// Token: 0x0603B3AF RID: 242607 RVA: 0x00E1F20B File Offset: 0x00E1D40B
		[NullableContext(1)]
		public CommonItemSimpleGridExFinish(AActor commonItemActor)
		{
			if (commonItemActor == null)
			{
				this.CreateThenShowByActor(commonItemActor);
			}
		}

		// Token: 0x0603B3B0 RID: 242608 RVA: 0x00E1F21D File Offset: 0x00E1D41D
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
		}

		// Token: 0x0603B3B1 RID: 242609 RVA: 0x00E1F240 File Offset: 0x00E1D440
		public void SetReceived(bool received)
		{
			base.GetItem(5).SetUIActive(received);
		}

		// Token: 0x0200BD82 RID: 48514
		private enum EChildComponentType
		{
			// Token: 0x040392A9 RID: 234153
			FinishedItem = 5
		}
	}
}
