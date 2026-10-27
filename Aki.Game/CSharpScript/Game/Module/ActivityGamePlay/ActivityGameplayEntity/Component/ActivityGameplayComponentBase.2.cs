using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200693E RID: 26942
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityGameplayComponentBase<TParam> : ActivityGameplayComponentBase
	{
		// Token: 0x06043268 RID: 275048 RVA: 0x0105E384 File Offset: 0x0105C584
		[NullableContext(1)]
		public override void Create(ActivityGameplayEntity ownerEntity, [Nullable(2)] object args = null)
		{
			base.Create(ownerEntity, args);
			TParam args2;
			if (args is TParam)
			{
				TParam tparam = (TParam)((object)args);
				args2 = tparam;
			}
			else
			{
				args2 = default(TParam);
			}
			this.OnCreate(args2);
		}

		// Token: 0x06043269 RID: 275049 RVA: 0x0105E3BC File Offset: 0x0105C5BC
		protected virtual void OnCreate(TParam args = default(TParam))
		{
		}
	}
}
