using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041CB RID: 16843
	[NullableContext(1)]
	[Nullable(0)]
	public class EvolveProxy
	{
		// Token: 0x0602AA15 RID: 174613 RVA: 0x00C045C4 File Offset: 0x00C027C4
		public UniTask CreateEffectItem(string resourceId, UUIItem attachItem)
		{
			EvolveProxy.<CreateEffectItem>d__2 <CreateEffectItem>d__;
			<CreateEffectItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateEffectItem>d__.<>4__this = this;
			<CreateEffectItem>d__.resourceId = resourceId;
			<CreateEffectItem>d__.attachItem = attachItem;
			<CreateEffectItem>d__.<>1__state = -1;
			<CreateEffectItem>d__.<>t__builder.Start<EvolveProxy.<CreateEffectItem>d__2>(ref <CreateEffectItem>d__);
			return <CreateEffectItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA16 RID: 174614 RVA: 0x00C04618 File Offset: 0x00C02818
		public void SetEvolveNum(int evolveNum)
		{
			this.EvolveNum = evolveNum;
			if (this.EffectItem == null)
			{
				return;
			}
			EvolveItem effectItem = this.EffectItem;
			if (effectItem != null)
			{
				effectItem.SetActive(this.EvolveNum != 0);
			}
			EvolveItem effectItem2 = this.EffectItem;
			if (effectItem2 == null)
			{
				return;
			}
			effectItem2.SetEffectActive(this.EvolveNum > 1);
		}

		// Token: 0x040171CC RID: 94668
		protected EvolveItem EffectItem;

		// Token: 0x040171CD RID: 94669
		protected int EvolveNum;
	}
}
