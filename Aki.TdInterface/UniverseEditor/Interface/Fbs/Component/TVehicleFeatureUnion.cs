using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD0 RID: 23760
	public class TVehicleFeatureUnion
	{
		// Token: 0x1700B268 RID: 45672
		// (get) Token: 0x06028A93 RID: 166547 RVA: 0x005960C2 File Offset: 0x005942C2
		// (set) Token: 0x06028A94 RID: 166548 RVA: 0x005960CA File Offset: 0x005942CA
		public TVehicleFeature Type { get; set; }

		// Token: 0x1700B269 RID: 45673
		// (get) Token: 0x06028A95 RID: 166549 RVA: 0x005960D3 File Offset: 0x005942D3
		// (set) Token: 0x06028A96 RID: 166550 RVA: 0x005960DB File Offset: 0x005942DB
		public object Value { get; set; }

		// Token: 0x06028A97 RID: 166551 RVA: 0x005960E4 File Offset: 0x005942E4
		public TVehicleFeatureUnion()
		{
			this.Type = TVehicleFeature.NONE;
			this.Value = null;
		}

		// Token: 0x06028A98 RID: 166552 RVA: 0x005960FA File Offset: 0x005942FA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A99 RID: 166553 RVA: 0x0059610C File Offset: 0x0059430C
		public IAudioVehicleFeatureT AsIAudioVehicleFeature()
		{
			return this.As<IAudioVehicleFeatureT>();
		}

		// Token: 0x06028A9A RID: 166554 RVA: 0x00596114 File Offset: 0x00594314
		public static TVehicleFeatureUnion FromIAudioVehicleFeature(IAudioVehicleFeatureT _iaudiovehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IAudioVehicleFeature,
				Value = _iaudiovehiclefeature
			};
		}

		// Token: 0x06028A9B RID: 166555 RVA: 0x00596129 File Offset: 0x00594329
		public IBattleVehicleFeatureT AsIBattleVehicleFeature()
		{
			return this.As<IBattleVehicleFeatureT>();
		}

		// Token: 0x06028A9C RID: 166556 RVA: 0x00596131 File Offset: 0x00594331
		public static TVehicleFeatureUnion FromIBattleVehicleFeature(IBattleVehicleFeatureT _ibattlevehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IBattleVehicleFeature,
				Value = _ibattlevehiclefeature
			};
		}

		// Token: 0x06028A9D RID: 166557 RVA: 0x00596146 File Offset: 0x00594346
		public IMovablePlatformVehicleFeatureT AsIMovablePlatformVehicleFeature()
		{
			return this.As<IMovablePlatformVehicleFeatureT>();
		}

		// Token: 0x06028A9E RID: 166558 RVA: 0x0059614E File Offset: 0x0059434E
		public static TVehicleFeatureUnion FromIMovablePlatformVehicleFeature(IMovablePlatformVehicleFeatureT _imovableplatformvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IMovablePlatformVehicleFeature,
				Value = _imovableplatformvehiclefeature
			};
		}

		// Token: 0x06028A9F RID: 166559 RVA: 0x00596163 File Offset: 0x00594363
		public IMovementVehicleFeatureT AsIMovementVehicleFeature()
		{
			return this.As<IMovementVehicleFeatureT>();
		}

		// Token: 0x06028AA0 RID: 166560 RVA: 0x0059616B File Offset: 0x0059436B
		public static TVehicleFeatureUnion FromIMovementVehicleFeature(IMovementVehicleFeatureT _imovementvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IMovementVehicleFeature,
				Value = _imovementvehiclefeature
			};
		}

		// Token: 0x06028AA1 RID: 166561 RVA: 0x00596180 File Offset: 0x00594380
		public IPerformanceVehicleFeatureT AsIPerformanceVehicleFeature()
		{
			return this.As<IPerformanceVehicleFeatureT>();
		}

		// Token: 0x06028AA2 RID: 166562 RVA: 0x00596188 File Offset: 0x00594388
		public static TVehicleFeatureUnion FromIPerformanceVehicleFeature(IPerformanceVehicleFeatureT _iperformancevehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IPerformanceVehicleFeature,
				Value = _iperformancevehiclefeature
			};
		}

		// Token: 0x06028AA3 RID: 166563 RVA: 0x0059619D File Offset: 0x0059439D
		public ISharingVehicleFeatureT AsISharingVehicleFeature()
		{
			return this.As<ISharingVehicleFeatureT>();
		}

		// Token: 0x06028AA4 RID: 166564 RVA: 0x005961A5 File Offset: 0x005943A5
		public static TVehicleFeatureUnion FromISharingVehicleFeature(ISharingVehicleFeatureT _isharingvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.ISharingVehicleFeature,
				Value = _isharingvehiclefeature
			};
		}

		// Token: 0x06028AA5 RID: 166565 RVA: 0x005961BC File Offset: 0x005943BC
		public static int Pack(FlatBufferBuilder builder, TVehicleFeatureUnion _o)
		{
			switch (_o.Type)
			{
			case TVehicleFeature.IAudioVehicleFeature:
				return IAudioVehicleFeature.Pack(builder, _o.AsIAudioVehicleFeature()).Value;
			case TVehicleFeature.IBattleVehicleFeature:
				return IBattleVehicleFeature.Pack(builder, _o.AsIBattleVehicleFeature()).Value;
			case TVehicleFeature.IMovablePlatformVehicleFeature:
				return IMovablePlatformVehicleFeature.Pack(builder, _o.AsIMovablePlatformVehicleFeature()).Value;
			case TVehicleFeature.IMovementVehicleFeature:
				return IMovementVehicleFeature.Pack(builder, _o.AsIMovementVehicleFeature()).Value;
			case TVehicleFeature.IPerformanceVehicleFeature:
				return IPerformanceVehicleFeature.Pack(builder, _o.AsIPerformanceVehicleFeature()).Value;
			case TVehicleFeature.ISharingVehicleFeature:
				return ISharingVehicleFeature.Pack(builder, _o.AsISharingVehicleFeature()).Value;
			default:
				return 0;
			}
		}
	}
}
