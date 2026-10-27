using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF3 RID: 28147
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectEffectDefine
	{
		// Token: 0x06044ABA RID: 281274 RVA: 0x010F357B File Offset: 0x010F177B
		public void Init(Func<ItemInspectEffectBase> effectClass, bool repeatable)
		{
			this.EffectClass = effectClass;
			this.Repeatable = repeatable;
		}

		// Token: 0x06044ABB RID: 281275 RVA: 0x010F358B File Offset: 0x010F178B
		public ItemInspectEffectBase GetEffect()
		{
			return this.EffectClass();
		}

		// Token: 0x06044ABC RID: 281276 RVA: 0x010F3598 File Offset: 0x010F1798
		public bool IsRepeatable()
		{
			return this.Repeatable;
		}

		// Token: 0x04023B9E RID: 146334
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<ItemInspectEffectBase> EffectClass;

		// Token: 0x04023B9F RID: 146335
		private bool Repeatable;
	}
}
