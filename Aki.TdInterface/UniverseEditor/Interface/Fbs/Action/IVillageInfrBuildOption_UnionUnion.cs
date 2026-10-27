using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007542 RID: 30018
	public class IVillageInfrBuildOption_UnionUnion
	{
		// Token: 0x1700E3C2 RID: 58306
		// (get) Token: 0x060369D0 RID: 223696 RVA: 0x0076B675 File Offset: 0x00769875
		// (set) Token: 0x060369D1 RID: 223697 RVA: 0x0076B67D File Offset: 0x0076987D
		public IVillageInfrBuildOption_Union Type { get; set; }

		// Token: 0x1700E3C3 RID: 58307
		// (get) Token: 0x060369D2 RID: 223698 RVA: 0x0076B686 File Offset: 0x00769886
		// (set) Token: 0x060369D3 RID: 223699 RVA: 0x0076B68E File Offset: 0x0076988E
		public object Value { get; set; }

		// Token: 0x060369D4 RID: 223700 RVA: 0x0076B697 File Offset: 0x00769897
		public IVillageInfrBuildOption_UnionUnion()
		{
			this.Type = IVillageInfrBuildOption_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060369D5 RID: 223701 RVA: 0x0076B6AD File Offset: 0x007698AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060369D6 RID: 223702 RVA: 0x0076B6BF File Offset: 0x007698BF
		public IVillageInfrBuildOptionT AsIVillageInfrBuildOption()
		{
			return this.As<IVillageInfrBuildOptionT>();
		}

		// Token: 0x060369D7 RID: 223703 RVA: 0x0076B6C7 File Offset: 0x007698C7
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrBuildOption(IVillageInfrBuildOptionT _ivillageinfrbuildoption)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrBuildOption,
				Value = _ivillageinfrbuildoption
			};
		}

		// Token: 0x060369D8 RID: 223704 RVA: 0x0076B6DC File Offset: 0x007698DC
		public IVillageInfrVillageLevelT AsIVillageInfrVillageLevel()
		{
			return this.As<IVillageInfrVillageLevelT>();
		}

		// Token: 0x060369D9 RID: 223705 RVA: 0x0076B6E4 File Offset: 0x007698E4
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrVillageLevel(IVillageInfrVillageLevelT _ivillageinfrvillagelevel)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrVillageLevel,
				Value = _ivillageinfrvillagelevel
			};
		}

		// Token: 0x060369DA RID: 223706 RVA: 0x0076B6F9 File Offset: 0x007698F9
		public IVillageInfrTreeProcessT AsIVillageInfrTreeProcess()
		{
			return this.As<IVillageInfrTreeProcessT>();
		}

		// Token: 0x060369DB RID: 223707 RVA: 0x0076B701 File Offset: 0x00769901
		public static IVillageInfrBuildOption_UnionUnion FromIVillageInfrTreeProcess(IVillageInfrTreeProcessT _ivillageinfrtreeprocess)
		{
			return new IVillageInfrBuildOption_UnionUnion
			{
				Type = IVillageInfrBuildOption_Union.IVillageInfrTreeProcess,
				Value = _ivillageinfrtreeprocess
			};
		}

		// Token: 0x060369DC RID: 223708 RVA: 0x0076B718 File Offset: 0x00769918
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
