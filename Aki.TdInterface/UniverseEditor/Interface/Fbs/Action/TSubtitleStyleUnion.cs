using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077B4 RID: 30644
	public class TSubtitleStyleUnion
	{
		// Token: 0x1700E6BB RID: 59067
		// (get) Token: 0x060379A8 RID: 227752 RVA: 0x007857D0 File Offset: 0x007839D0
		// (set) Token: 0x060379A9 RID: 227753 RVA: 0x007857D8 File Offset: 0x007839D8
		public TSubtitleStyle Type { get; set; }

		// Token: 0x1700E6BC RID: 59068
		// (get) Token: 0x060379AA RID: 227754 RVA: 0x007857E1 File Offset: 0x007839E1
		// (set) Token: 0x060379AB RID: 227755 RVA: 0x007857E9 File Offset: 0x007839E9
		public object Value { get; set; }

		// Token: 0x060379AC RID: 227756 RVA: 0x007857F2 File Offset: 0x007839F2
		public TSubtitleStyleUnion()
		{
			this.Type = TSubtitleStyle.NONE;
			this.Value = null;
		}

		// Token: 0x060379AD RID: 227757 RVA: 0x00785808 File Offset: 0x00783A08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379AE RID: 227758 RVA: 0x0078581A File Offset: 0x00783A1A
		public ISubtitleStyleLevelAT AsISubtitleStyleLevelA()
		{
			return this.As<ISubtitleStyleLevelAT>();
		}

		// Token: 0x060379AF RID: 227759 RVA: 0x00785822 File Offset: 0x00783A22
		public static TSubtitleStyleUnion FromISubtitleStyleLevelA(ISubtitleStyleLevelAT _isubtitlestylelevela)
		{
			return new TSubtitleStyleUnion
			{
				Type = TSubtitleStyle.ISubtitleStyleLevelA,
				Value = _isubtitlestylelevela
			};
		}

		// Token: 0x060379B0 RID: 227760 RVA: 0x00785837 File Offset: 0x00783A37
		public ISubtitleStyleNewLevelBT AsISubtitleStyleNewLevelB()
		{
			return this.As<ISubtitleStyleNewLevelBT>();
		}

		// Token: 0x060379B1 RID: 227761 RVA: 0x0078583F File Offset: 0x00783A3F
		public static TSubtitleStyleUnion FromISubtitleStyleNewLevelB(ISubtitleStyleNewLevelBT _isubtitlestylenewlevelb)
		{
			return new TSubtitleStyleUnion
			{
				Type = TSubtitleStyle.ISubtitleStyleNewLevelB,
				Value = _isubtitlestylenewlevelb
			};
		}

		// Token: 0x060379B2 RID: 227762 RVA: 0x00785854 File Offset: 0x00783A54
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
