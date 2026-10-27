using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Section
{
	// Token: 0x02006F71 RID: 28529
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowData
	{
		// Token: 0x0604566B RID: 284267 RVA: 0x01133F91 File Offset: 0x01132191
		public virtual void Init()
		{
		}

		// Token: 0x0604566C RID: 284268 RVA: 0x01133F93 File Offset: 0x01132193
		protected void Register(TSectionCreator creator)
		{
			this.SectionMap.Add(this.Capacity, creator);
			this.Capacity++;
		}

		// Token: 0x0604566D RID: 284269 RVA: 0x01133FB8 File Offset: 0x011321B8
		[NullableContext(2)]
		public LevelFlowSection GetSection(int index)
		{
			TSectionCreator tsectionCreator;
			if (!this.SectionMap.TryGetValue(index, out tsectionCreator))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelFlow;
				ELogAuthor author = ELogAuthor.BB;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(39, 1);
				defaultInterpolatedStringHandler.AppendLiteral("LevelFlowSection index=");
				defaultInterpolatedStringHandler.AppendFormatted<int>(index);
				defaultInterpolatedStringHandler.AppendLiteral(" not registered.");
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			return tsectionCreator();
		}

		// Token: 0x0604566E RID: 284270 RVA: 0x01134028 File Offset: 0x01132228
		public int GetCapacity()
		{
			return this.Capacity;
		}

		// Token: 0x04024374 RID: 148340
		private readonly Dictionary<int, TSectionCreator> SectionMap = new Dictionary<int, TSectionCreator>();

		// Token: 0x04024375 RID: 148341
		private int Capacity;
	}
}
