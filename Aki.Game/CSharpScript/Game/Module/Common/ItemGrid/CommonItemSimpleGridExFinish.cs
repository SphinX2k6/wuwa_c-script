using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Common.ItemGrid
{
	// Token: 0x02004B51 RID: 19281
	public class CommonItemSimpleGridExFinish : CommonItemSimpleGrid
	{
		// Token: 0x060302FC RID: 197372 RVA: 0x00D6F77F File Offset: 0x00D6D97F
		[NullableContext(1)]
		public CommonItemSimpleGridExFinish(AActor commonItemActor)
		{
			if (commonItemActor == null)
			{
				this.CreateThenShowByActor(commonItemActor);
			}
		}

		// Token: 0x060302FD RID: 197373 RVA: 0x00D6F791 File Offset: 0x00D6D991
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(5, typeof(UUIItem)));
		}

		// Token: 0x060302FE RID: 197374 RVA: 0x00D6F7B4 File Offset: 0x00D6D9B4
		public void SetReceived(bool received)
		{
			base.GetItem(5).SetUIActive(received);
		}

		// Token: 0x0200A78C RID: 42892
		private enum EChildComponentType
		{
			// Token: 0x04033C77 RID: 212087
			FinishedItem = 5
		}
	}
}
