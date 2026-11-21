using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006304 RID: 25348
	public class TVehicleFeatureUnion
	{
		// Token: 0x1700BBC4 RID: 48068
		// (get) Token: 0x0602B0E7 RID: 176359 RVA: 0x005DE932 File Offset: 0x005DCB32
		// (set) Token: 0x0602B0E8 RID: 176360 RVA: 0x005DE93A File Offset: 0x005DCB3A
		public TVehicleFeature Type { get; set; }

		// Token: 0x1700BBC5 RID: 48069
		// (get) Token: 0x0602B0E9 RID: 176361 RVA: 0x005DE943 File Offset: 0x005DCB43
		// (set) Token: 0x0602B0EA RID: 176362 RVA: 0x005DE94B File Offset: 0x005DCB4B
		public object Value { get; set; }

		// Token: 0x0602B0EB RID: 176363 RVA: 0x005DE954 File Offset: 0x005DCB54
		public TVehicleFeatureUnion()
		{
			this.Type = TVehicleFeature.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0EC RID: 176364 RVA: 0x005DE96A File Offset: 0x005DCB6A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0ED RID: 176365 RVA: 0x005DE97C File Offset: 0x005DCB7C
		public IAudioVehicleFeatureT AsIAudioVehicleFeature()
		{
			return this.As<IAudioVehicleFeatureT>();
		}

		// Token: 0x0602B0EE RID: 176366 RVA: 0x005DE984 File Offset: 0x005DCB84
		public static TVehicleFeatureUnion FromIAudioVehicleFeature(IAudioVehicleFeatureT _iaudiovehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IAudioVehicleFeature,
				Value = _iaudiovehiclefeature
			};
		}

		// Token: 0x0602B0EF RID: 176367 RVA: 0x005DE999 File Offset: 0x005DCB99
		public IBattleVehicleFeatureT AsIBattleVehicleFeature()
		{
			return this.As<IBattleVehicleFeatureT>();
		}

		// Token: 0x0602B0F0 RID: 176368 RVA: 0x005DE9A1 File Offset: 0x005DCBA1
		public static TVehicleFeatureUnion FromIBattleVehicleFeature(IBattleVehicleFeatureT _ibattlevehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IBattleVehicleFeature,
				Value = _ibattlevehiclefeature
			};
		}

		// Token: 0x0602B0F1 RID: 176369 RVA: 0x005DE9B6 File Offset: 0x005DCBB6
		public IMovablePlatformVehicleFeatureT AsIMovablePlatformVehicleFeature()
		{
			return this.As<IMovablePlatformVehicleFeatureT>();
		}

		// Token: 0x0602B0F2 RID: 176370 RVA: 0x005DE9BE File Offset: 0x005DCBBE
		public static TVehicleFeatureUnion FromIMovablePlatformVehicleFeature(IMovablePlatformVehicleFeatureT _imovableplatformvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IMovablePlatformVehicleFeature,
				Value = _imovableplatformvehiclefeature
			};
		}

		// Token: 0x0602B0F3 RID: 176371 RVA: 0x005DE9D3 File Offset: 0x005DCBD3
		public IMovementVehicleFeatureT AsIMovementVehicleFeature()
		{
			return this.As<IMovementVehicleFeatureT>();
		}

		// Token: 0x0602B0F4 RID: 176372 RVA: 0x005DE9DB File Offset: 0x005DCBDB
		public static TVehicleFeatureUnion FromIMovementVehicleFeature(IMovementVehicleFeatureT _imovementvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IMovementVehicleFeature,
				Value = _imovementvehiclefeature
			};
		}

		// Token: 0x0602B0F5 RID: 176373 RVA: 0x005DE9F0 File Offset: 0x005DCBF0
		public IPerformanceVehicleFeatureT AsIPerformanceVehicleFeature()
		{
			return this.As<IPerformanceVehicleFeatureT>();
		}

		// Token: 0x0602B0F6 RID: 176374 RVA: 0x005DE9F8 File Offset: 0x005DCBF8
		public static TVehicleFeatureUnion FromIPerformanceVehicleFeature(IPerformanceVehicleFeatureT _iperformancevehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.IPerformanceVehicleFeature,
				Value = _iperformancevehiclefeature
			};
		}

		// Token: 0x0602B0F7 RID: 176375 RVA: 0x005DEA0D File Offset: 0x005DCC0D
		public ISharingVehicleFeatureT AsISharingVehicleFeature()
		{
			return this.As<ISharingVehicleFeatureT>();
		}

		// Token: 0x0602B0F8 RID: 176376 RVA: 0x005DEA15 File Offset: 0x005DCC15
		public static TVehicleFeatureUnion FromISharingVehicleFeature(ISharingVehicleFeatureT _isharingvehiclefeature)
		{
			return new TVehicleFeatureUnion
			{
				Type = TVehicleFeature.ISharingVehicleFeature,
				Value = _isharingvehiclefeature
			};
		}

		// Token: 0x0602B0F9 RID: 176377 RVA: 0x005DEA2C File Offset: 0x005DCC2C
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
