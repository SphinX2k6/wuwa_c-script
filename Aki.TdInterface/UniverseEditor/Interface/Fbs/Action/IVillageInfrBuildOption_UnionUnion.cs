using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D38 RID: 32056
	public class IVillageInfrBuildOption_UnionUnion
	{
		// Token: 0x1700EFEC RID: 61420
		// (get) Token: 0x06039DE6 RID: 237030 RVA: 0x007CE91D File Offset: 0x007CCB1D
		// (set) Token: 0x06039DE7 RID: 237031 RVA: 0x007CE925 File Offset: 0x007CCB25
		public IVillageInfrBuildOption_Union Type { get; set; }

		// Token: 0x1700EFED RID: 61421
		// (get) Token: 0x06039DE8 RID: 237032 RVA: 0x007CE92E File Offset: 0x007CCB2E
		// (set) Token: 0x06039DE9 RID: 237033 RVA: 0x007CE936 File Offset: 0x007CCB36
		public object Value { get; set; }

		// Token: 0x06039DEA RID: 237034 RVA: 0x007CE93F File Offset: 0x007CCB3F
		public IVillageInfrBuildOption_UnionUnion()
		{
			this.Type = IVillageInfrBuildOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06039DEB RID: 237035 RVA: 0x007CE955 File Offset: 0x007CCB55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06039DEC RID: 237036 RVA: 0x007CE967 File Offset: 0x007CCB67
		public IVillageInfrBuildOptionT AsIVillageInfrBuildOption()
		{
			return this.As<IVillageInfrBuildOptionT>();
		}

		// Token: 0x06039DED RID: 237037 RVA: 0x007CE96F File Offset: 0x007CCB6F
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrBuildOption(IVillageInfrBuildOptionT _ivillageinfrbuildoption)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrBuildOption,
				Value = _ivillageinfrbuildoption
			};
		}

		// Token: 0x06039DEE RID: 237038 RVA: 0x007CE984 File Offset: 0x007CCB84
		public IVillageInfrVillageLevelT AsIVillageInfrVillageLevel()
		{
			return this.As<IVillageInfrVillageLevelT>();
		}

		// Token: 0x06039DEF RID: 237039 RVA: 0x007CE98C File Offset: 0x007CCB8C
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrVillageLevel(IVillageInfrVillageLevelT _ivillageinfrvillagelevel)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrVillageLevel,
				Value = _ivillageinfrvillagelevel
			};
		}

		// Token: 0x06039DF0 RID: 237040 RVA: 0x007CE9A1 File Offset: 0x007CCBA1
		public IVillageInfrTreeProcessT AsIVillageInfrTreeProcess()
		{
			return this.As<IVillageInfrTreeProcessT>();
		}

		// Token: 0x06039DF1 RID: 237041 RVA: 0x007CE9A9 File Offset: 0x007CCBA9
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrTreeProcess(IVillageInfrTreeProcessT _ivillageinfrtreeprocess)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrTreeProcess,
				Value = _ivillageinfrtreeprocess
			};
		}

		// Token: 0x06039DF2 RID: 237042 RVA: 0x007CE9C0 File Offset: 0x007CCBC0
		public static int Pack(FlatBufferBuilder builder, IVillageInfrBuildOption_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVillageInfrBuildOption_Union.IVillageInfrBuildOption:
				return IVillageInfrBuildOption.Pack(builder, _o.AsIVillageInfrBuildOption()).Value;
			case IVillageInfrBuildOption_Union.IVillageInfrVillageLevel:
				return IVillageInfrVillageLevel.Pack(builder, _o.AsIVillageInfrVillageLevel()).Value;
			case IVillageInfrBuildOption_Union.IVillageInfrTreeProcess:
				return IVillageInfrTreeProcess.Pack(builder, _o.AsIVillageInfrTreeProcess()).Value;
			default:
				return 0;
			}
		}
	}
}
