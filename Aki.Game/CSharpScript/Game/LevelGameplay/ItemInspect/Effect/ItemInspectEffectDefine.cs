using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F72 RID: 24434
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemInspectEffectDefine
	{
		// Token: 0x0603AC1E RID: 240670 RVA: 0x0109D843 File Offset: 0x0109BA43
		public void Init(Func<ItemInspectEffectBase> effectClass, bool repeatable)
		{
			this.EffectClass = effectClass;
			this.Repeatable = repeatable;
		}

		// Token: 0x0603AC1F RID: 240671 RVA: 0x0109D853 File Offset: 0x0109BA53
		public ItemInspectEffectBase GetEffect()
		{
			return this.EffectClass();
		}

		// Token: 0x0603AC20 RID: 240672 RVA: 0x0109D860 File Offset: 0x0109BA60
		public bool IsRepeatable()
		{
			return this.Repeatable;
		}

		// Token: 0x0401EE40 RID: 126528
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<ItemInspectEffectBase> EffectClass;

		// Token: 0x0401EE41 RID: 126529
		private bool Repeatable;
	}
}
