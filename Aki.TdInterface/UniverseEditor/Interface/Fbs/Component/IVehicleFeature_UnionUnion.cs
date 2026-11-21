using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006128 RID: 24872
	public class IVehicleFeature_UnionUnion
	{
		// Token: 0x1700B93D RID: 47421
		// (get) Token: 0x0602A30C RID: 172812 RVA: 0x005C226D File Offset: 0x005C046D
		// (set) Token: 0x0602A30D RID: 172813 RVA: 0x005C2275 File Offset: 0x005C0475
		public IVehicleFeature_Union Type { get; set; }

		// Token: 0x1700B93E RID: 47422
		// (get) Token: 0x0602A30E RID: 172814 RVA: 0x005C227E File Offset: 0x005C047E
		// (set) Token: 0x0602A30F RID: 172815 RVA: 0x005C2286 File Offset: 0x005C0486
		public object Value { get; set; }

		// Token: 0x0602A310 RID: 172816 RVA: 0x005C228F File Offset: 0x005C048F
		public IVehicleFeature_UnionUnion()
		{
			this.Type = IVehicleFeature_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A311 RID: 172817 RVA: 0x005C22A5 File Offset: 0x005C04A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A312 RID: 172818 RVA: 0x005C22B7 File Offset: 0x005C04B7
		public IVehicleFeatureT AsIVehicleFeature()
		{
			return this.As<IVehicleFeatureT>();
		}

		// Token: 0x0602A313 RID: 172819 RVA: 0x005C22BF File Offset: 0x005C04BF
		public static IVehicleFeature_UnionUnion FromIVehicleFeature(IVehicleFeatureT _ivehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IVehicleFeature,
				Value = _ivehiclefeature
			};
		}

		// Token: 0x0602A314 RID: 172820 RVA: 0x005C22D4 File Offset: 0x005C04D4
		public IMovementVehicleFeatureT AsIMovementVehicleFeature()
		{
			return this.As<IMovementVehicleFeatureT>();
		}

		// Token: 0x0602A315 RID: 172821 RVA: 0x005C22DC File Offset: 0x005C04DC
		public static IVehicleFeature_UnionUnion FromIMovementVehicleFeature(IMovementVehicleFeatureT _imovementvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IMovementVehicleFeature,
				Value = _imovementvehiclefeature
			};
		}

		// Token: 0x0602A316 RID: 172822 RVA: 0x005C22F1 File Offset: 0x005C04F1
		public IBattleVehicleFeatureT AsIBattleVehicleFeature()
		{
			return this.As<IBattleVehicleFeatureT>();
		}

		// Token: 0x0602A317 RID: 172823 RVA: 0x005C22F9 File Offset: 0x005C04F9
		public static IVehicleFeature_UnionUnion FromIBattleVehicleFeature(IBattleVehicleFeatureT _ibattlevehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IBattleVehicleFeature,
				Value = _ibattlevehiclefeature
			};
		}

		// Token: 0x0602A318 RID: 172824 RVA: 0x005C230E File Offset: 0x005C050E
		public IAudioVehicleFeatureT AsIAudioVehicleFeature()
		{
			return this.As<IAudioVehicleFeatureT>();
		}

		// Token: 0x0602A319 RID: 172825 RVA: 0x005C2316 File Offset: 0x005C0516
		public static IVehicleFeature_UnionUnion FromIAudioVehicleFeature(IAudioVehicleFeatureT _iaudiovehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IAudioVehicleFeature,
				Value = _iaudiovehiclefeature
			};
		}

		// Token: 0x0602A31A RID: 172826 RVA: 0x005C232B File Offset: 0x005C052B
		public IMovablePlatformVehicleFeatureT AsIMovablePlatformVehicleFeature()
		{
			return this.As<IMovablePlatformVehicleFeatureT>();
		}

		// Token: 0x0602A31B RID: 172827 RVA: 0x005C2333 File Offset: 0x005C0533
		public static IVehicleFeature_UnionUnion FromIMovablePlatformVehicleFeature(IMovablePlatformVehicleFeatureT _imovableplatformvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IMovablePlatformVehicleFeature,
				Value = _imovableplatformvehiclefeature
			};
		}

		// Token: 0x0602A31C RID: 172828 RVA: 0x005C2348 File Offset: 0x005C0548
		public ISharingVehicleFeatureT AsISharingVehicleFeature()
		{
			return this.As<ISharingVehicleFeatureT>();
		}

		// Token: 0x0602A31D RID: 172829 RVA: 0x005C2350 File Offset: 0x005C0550
		public static IVehicleFeature_UnionUnion FromISharingVehicleFeature(ISharingVehicleFeatureT _isharingvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.ISharingVehicleFeature,
				Value = _isharingvehiclefeature
			};
		}

		// Token: 0x0602A31E RID: 172830 RVA: 0x005C2365 File Offset: 0x005C0565
		public IPerformanceVehicleFeatureT AsIPerformanceVehicleFeature()
		{
			return this.As<IPerformanceVehicleFeatureT>();
		}

		// Token: 0x0602A31F RID: 172831 RVA: 0x005C236D File Offset: 0x005C056D
		public static IVehicleFeature_UnionUnion FromIPerformanceVehicleFeature(IPerformanceVehicleFeatureT _iperformancevehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IPerformanceVehicleFeature,
				Value = _iperformancevehiclefeature
			};
		}

		// Token: 0x0602A320 RID: 172832 RVA: 0x005C2384 File Offset: 0x005C0584
		public static int Pack(FlatBufferBuilder builder, IVehicleFeature_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVehicleFeature_Union.IVehicleFeature:
				return IVehicleFeature.Pack(builder, _o.AsIVehicleFeature()).Value;
			case IVehicleFeature_Union.IMovementVehicleFeature:
				return IMovementVehicleFeature.Pack(builder, _o.AsIMovementVehicleFeature()).Value;
			case IVehicleFeature_Union.IBattleVehicleFeature:
				return IBattleVehicleFeature.Pack(builder, _o.AsIBattleVehicleFeature()).Value;
			case IVehicleFeature_Union.IAudioVehicleFeature:
				return IAudioVehicleFeature.Pack(builder, _o.AsIAudioVehicleFeature()).Value;
			case IVehicleFeature_Union.IMovablePlatformVehicleFeature:
				return IMovablePlatformVehicleFeature.Pack(builder, _o.AsIMovablePlatformVehicleFeature()).Value;
			case IVehicleFeature_Union.ISharingVehicleFeature:
				return ISharingVehicleFeature.Pack(builder, _o.AsISharingVehicleFeature()).Value;
			case IVehicleFeature_Union.IPerformanceVehicleFeature:
				return IPerformanceVehicleFeature.Pack(builder, _o.AsIPerformanceVehicleFeature()).Value;
			default:
				return 0;
			}
		}
	}
}
