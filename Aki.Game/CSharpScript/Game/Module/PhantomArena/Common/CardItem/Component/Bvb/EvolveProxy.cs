using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020051FB RID: 20987
	[NullableContext(1)]
	[Nullable(0)]
	public class EvolveProxy
	{
		// Token: 0x06035B1A RID: 219930 RVA: 0x00CB6F88 File Offset: 0x00CB5188
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

		// Token: 0x06035B1B RID: 219931 RVA: 0x00CB6FDC File Offset: 0x00CB51DC
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

		// Token: 0x0401C797 RID: 116631
		protected EvolveItem EffectItem;

		// Token: 0x0401C798 RID: 116632
		protected int EvolveNum;
	}
}
