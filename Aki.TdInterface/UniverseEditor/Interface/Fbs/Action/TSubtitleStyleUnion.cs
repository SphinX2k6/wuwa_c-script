using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FEC RID: 32748
	public class TSubtitleStyleUnion
	{
		// Token: 0x1700F315 RID: 62229
		// (get) Token: 0x0603AF29 RID: 241449 RVA: 0x007EADA0 File Offset: 0x007E8FA0
		// (set) Token: 0x0603AF2A RID: 241450 RVA: 0x007EADA8 File Offset: 0x007E8FA8
		public TSubtitleStyle Type { get; set; }

		// Token: 0x1700F316 RID: 62230
		// (get) Token: 0x0603AF2B RID: 241451 RVA: 0x007EADB1 File Offset: 0x007E8FB1
		// (set) Token: 0x0603AF2C RID: 241452 RVA: 0x007EADB9 File Offset: 0x007E8FB9
		public object Value { get; set; }

		// Token: 0x0603AF2D RID: 241453 RVA: 0x007EADC2 File Offset: 0x007E8FC2
		public TSubtitleStyleUnion()
		{
			this.Type = TSubtitleStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF2E RID: 241454 RVA: 0x007EADD8 File Offset: 0x007E8FD8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF2F RID: 241455 RVA: 0x007EADEA File Offset: 0x007E8FEA
		public ISubtitleStyleLevelAT AsISubtitleStyleLevelA()
		{
			return this.As<ISubtitleStyleLevelAT>();
		}

		// Token: 0x0603AF30 RID: 241456 RVA: 0x007EADF2 File Offset: 0x007E8FF2
		public static TSubtitleStyleUnion FromISubtitleStyleLevelA(ISubtitleStyleLevelAT _isubtitlestylelevela)
		{
			return new TSubtitleStyleUnion
			{
				Type = TSubtitleStyle.ISubtitleStyleLevelA,
				Value = _isubtitlestylelevela
			};
		}

		// Token: 0x0603AF31 RID: 241457 RVA: 0x007EAE07 File Offset: 0x007E9007
		public ISubtitleStyleNewLevelBT AsISubtitleStyleNewLevelB()
		{
			return this.As<ISubtitleStyleNewLevelBT>();
		}

		// Token: 0x0603AF32 RID: 241458 RVA: 0x007EAE0F File Offset: 0x007E900F
		public static TSubtitleStyleUnion FromISubtitleStyleNewLevelB(ISubtitleStyleNewLevelBT _isubtitlestylenewlevelb)
		{
			return new TSubtitleStyleUnion
			{
				Type = TSubtitleStyle.ISubtitleStyleNewLevelB,
				Value = _isubtitlestylenewlevelb
			};
		}

		// Token: 0x0603AF33 RID: 241459 RVA: 0x007EAE24 File Offset: 0x007E9024
		public static int Pack(FlatBufferBuilder builder, TSubtitleStyleUnion _o)
		{
			TSubtitleStyle type = _o.Type;
			if (type == TSubtitleStyle.ISubtitleStyleLevelA)
			{
				return ISubtitleStyleLevelA.Pack(builder, _o.AsISubtitleStyleLevelA()).Value;
			}
			if (type != TSubtitleStyle.ISubtitleStyleNewLevelB)
			{
				return 0;
			}
			return ISubtitleStyleNewLevelB.Pack(builder, _o.AsISubtitleStyleNewLevelB()).Value;
		}
	}
}
