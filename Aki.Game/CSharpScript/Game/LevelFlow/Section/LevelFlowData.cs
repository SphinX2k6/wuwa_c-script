using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelFlow.Section
{
	// Token: 0x020060F2 RID: 24818
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelFlowData
	{
		// Token: 0x0603B819 RID: 243737 RVA: 0x010DDD95 File Offset: 0x010DBF95
		public virtual void Init()
		{
		}

		// Token: 0x0603B81A RID: 243738 RVA: 0x010DDD97 File Offset: 0x010DBF97
		protected void Register(TSectionCreator creator)
		{
			this.SectionMap.Add(this.Capacity, creator);
			this.Capacity++;
		}

		// Token: 0x0603B81B RID: 243739 RVA: 0x010DDDBC File Offset: 0x010DBFBC
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

		// Token: 0x0603B81C RID: 243740 RVA: 0x010DDE2C File Offset: 0x010DC02C
		public int GetCapacity()
		{
			return this.Capacity;
		}

		// Token: 0x0401F629 RID: 128553
		private readonly Dictionary<int, TSectionCreator> SectionMap = new Dictionary<int, TSectionCreator>();

		// Token: 0x0401F62A RID: 128554
		private int Capacity;
	}
}
