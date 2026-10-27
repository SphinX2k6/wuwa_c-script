using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B12 RID: 23314
	public class IVehicleFeature_UnionUnion
	{
		// Token: 0x1700AFF5 RID: 45045
		// (get) Token: 0x06027D48 RID: 163144 RVA: 0x0057A819 File Offset: 0x00578A19
		// (set) Token: 0x06027D49 RID: 163145 RVA: 0x0057A821 File Offset: 0x00578A21
		public IVehicleFeature_Union Type { get; set; }

		// Token: 0x1700AFF6 RID: 45046
		// (get) Token: 0x06027D4A RID: 163146 RVA: 0x0057A82A File Offset: 0x00578A2A
		// (set) Token: 0x06027D4B RID: 163147 RVA: 0x0057A832 File Offset: 0x00578A32
		public object Value { get; set; }

		// Token: 0x06027D4C RID: 163148 RVA: 0x0057A83B File Offset: 0x00578A3B
		public IVehicleFeature_UnionUnion()
		{
			this.Type = IVehicleFeature_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027D4D RID: 163149 RVA: 0x0057A851 File Offset: 0x00578A51
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027D4E RID: 163150 RVA: 0x0057A863 File Offset: 0x00578A63
		public IVehicleFeatureT AsIVehicleFeature()
		{
			return this.As<IVehicleFeatureT>();
		}

		// Token: 0x06027D4F RID: 163151 RVA: 0x0057A86B File Offset: 0x00578A6B
		public static IVehicleFeature_UnionUnion FromIVehicleFeature(IVehicleFeatureT _ivehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IVehicleFeature,
				Value = _ivehiclefeature
			};
		}

		// Token: 0x06027D50 RID: 163152 RVA: 0x0057A880 File Offset: 0x00578A80
		public IMovementVehicleFeatureT AsIMovementVehicleFeature()
		{
			return this.As<IMovementVehicleFeatureT>();
		}

		// Token: 0x06027D51 RID: 163153 RVA: 0x0057A888 File Offset: 0x00578A88
		public static IVehicleFeature_UnionUnion FromIMovementVehicleFeature(IMovementVehicleFeatureT _imovementvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IMovementVehicleFeature,
				Value = _imovementvehiclefeature
			};
		}

		// Token: 0x06027D52 RID: 163154 RVA: 0x0057A89D File Offset: 0x00578A9D
		public IBattleVehicleFeatureT AsIBattleVehicleFeature()
		{
			return this.As<IBattleVehicleFeatureT>();
		}

		// Token: 0x06027D53 RID: 163155 RVA: 0x0057A8A5 File Offset: 0x00578AA5
		public static IVehicleFeature_UnionUnion FromIBattleVehicleFeature(IBattleVehicleFeatureT _ibattlevehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IBattleVehicleFeature,
				Value = _ibattlevehiclefeature
			};
		}

		// Token: 0x06027D54 RID: 163156 RVA: 0x0057A8BA File Offset: 0x00578ABA
		public IAudioVehicleFeatureT AsIAudioVehicleFeature()
		{
			return this.As<IAudioVehicleFeatureT>();
		}

		// Token: 0x06027D55 RID: 163157 RVA: 0x0057A8C2 File Offset: 0x00578AC2
		public static IVehicleFeature_UnionUnion FromIAudioVehicleFeature(IAudioVehicleFeatureT _iaudiovehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IAudioVehicleFeature,
				Value = _iaudiovehiclefeature
			};
		}

		// Token: 0x06027D56 RID: 163158 RVA: 0x0057A8D7 File Offset: 0x00578AD7
		public IMovablePlatformVehicleFeatureT AsIMovablePlatformVehicleFeature()
		{
			return this.As<IMovablePlatformVehicleFeatureT>();
		}

		// Token: 0x06027D57 RID: 163159 RVA: 0x0057A8DF File Offset: 0x00578ADF
		public static IVehicleFeature_UnionUnion FromIMovablePlatformVehicleFeature(IMovablePlatformVehicleFeatureT _imovableplatformvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IMovablePlatformVehicleFeature,
				Value = _imovableplatformvehiclefeature
			};
		}

		// Token: 0x06027D58 RID: 163160 RVA: 0x0057A8F4 File Offset: 0x00578AF4
		public ISharingVehicleFeatureT AsISharingVehicleFeature()
		{
			return this.As<ISharingVehicleFeatureT>();
		}

		// Token: 0x06027D59 RID: 163161 RVA: 0x0057A8FC File Offset: 0x00578AFC
		public static IVehicleFeature_UnionUnion FromISharingVehicleFeature(ISharingVehicleFeatureT _isharingvehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.ISharingVehicleFeature,
				Value = _isharingvehiclefeature
			};
		}

		// Token: 0x06027D5A RID: 163162 RVA: 0x0057A911 File Offset: 0x00578B11
		public IPerformanceVehicleFeatureT AsIPerformanceVehicleFeature()
		{
			return this.As<IPerformanceVehicleFeatureT>();
		}

		// Token: 0x06027D5B RID: 163163 RVA: 0x0057A919 File Offset: 0x00578B19
		public static IVehicleFeature_UnionUnion FromIPerformanceVehicleFeature(IPerformanceVehicleFeatureT _iperformancevehiclefeature)
		{
			return new IVehicleFeature_UnionUnion
			{
				Type = IVehicleFeature_Union.IPerformanceVehicleFeature,
				Value = _iperformancevehiclefeature
			};
		}

		// Token: 0x06027D5C RID: 163164 RVA: 0x0057A930 File Offset: 0x00578B30
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
