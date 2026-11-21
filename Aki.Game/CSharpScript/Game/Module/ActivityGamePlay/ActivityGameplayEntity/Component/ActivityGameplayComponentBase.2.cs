using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ActivityGamePlay.ActivityGameplayEntity.Component
{
	// Token: 0x0200588F RID: 22671
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivityGameplayComponentBase<TParam> : ActivityGameplayComponentBase
	{
		// Token: 0x06037DC5 RID: 228805 RVA: 0x00F9F9F4 File Offset: 0x00F9DBF4
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

		// Token: 0x06037DC6 RID: 228806 RVA: 0x00F9FA2C File Offset: 0x00F9DC2C
		protected virtual void OnCreate(TParam args = default(TParam))
		{
		}
	}
}
