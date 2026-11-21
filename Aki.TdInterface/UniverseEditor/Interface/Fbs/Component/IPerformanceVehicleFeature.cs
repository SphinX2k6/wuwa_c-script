using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D28 RID: 23848
	public struct IPerformanceVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700AF4C RID: 44876
		// (get) Token: 0x06027A21 RID: 162337 RVA: 0x0056C0A4 File Offset: 0x0056A2A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027A22 RID: 162338 RVA: 0x0056C0B1 File Offset: 0x0056A2B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027A23 RID: 162339 RVA: 0x0056C0B8 File Offset: 0x0056A2B8
		public static IPerformanceVehicleFeature GetRootAsIPerformanceVehicleFeature(ByteBuffer _bb)
		{
			return IPerformanceVehicleFeature.GetRootAsIPerformanceVehicleFeature(_bb, default(IPerformanceVehicleFeature));
		}

		// Token: 0x06027A24 RID: 162340 RVA: 0x0056C0D4 File Offset: 0x0056A2D4
		public static IPerformanceVehicleFeature GetRootAsIPerformanceVehicleFeature(ByteBuffer _bb, IPerformanceVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027A25 RID: 162341 RVA: 0x0056C0F1 File Offset: 0x0056A2F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027A26 RID: 162342 RVA: 0x0056C100 File Offset: 0x0056A300
		public IPerformanceVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF4D RID: 44877
		// (get) Token: 0x06027A27 RID: 162343 RVA: 0x0056C110 File Offset: 0x0056A310
		public EVehicleFeatureFlag Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleFeatureFlag.None;
				}
				return (EVehicleFeatureFlag)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF4E RID: 44878
		// (get) Token: 0x06027A28 RID: 162344 RVA: 0x0056C14C File Offset: 0x0056A34C
		public string PerformConfig
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027A29 RID: 162345 RVA: 0x0056C183 File Offset: 0x0056A383
		public Span<byte> GetPerformConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027A2A RID: 162346 RVA: 0x0056C192 File Offset: 0x0056A392
		public byte[] GetPerformConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06027A2B RID: 162347 RVA: 0x0056C1A0 File Offset: 0x0056A3A0
		public static Offset<IPerformanceVehicleFeature> CreateIPerformanceVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, StringOffset PerformConfigOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPerformanceVehicleFeature.AddPerformConfig(builder, PerformConfigOffset);
			IPerformanceVehicleFeature.AddType(builder, Type);
			return IPerformanceVehicleFeature.EndIPerformanceVehicleFeature(builder);
		}

		// Token: 0x06027A2C RID: 162348 RVA: 0x0056C1BD File Offset: 0x0056A3BD
		public static void StartIPerformanceVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06027A2D RID: 162349 RVA: 0x0056C1C6 File Offset: 0x0056A3C6
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027A2E RID: 162350 RVA: 0x0056C1D1 File Offset: 0x0056A3D1
		public static void AddPerformConfig(FlatBufferBuilder builder, StringOffset performConfigOffset)
		{
			builder.AddOffset(1, performConfigOffset.Value, 0);
		}

		// Token: 0x06027A2F RID: 162351 RVA: 0x0056C1E1 File Offset: 0x0056A3E1
		public static Offset<IPerformanceVehicleFeature> EndIPerformanceVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06027A30 RID: 162352 RVA: 0x0056C1F0 File Offset: 0x0056A3F0
		public IPerformanceVehicleFeatureT UnPack()
		{
			IPerformanceVehicleFeatureT performanceVehicleFeatureT = new IPerformanceVehicleFeatureT();
			this.UnPackTo(performanceVehicleFeatureT);
			return performanceVehicleFeatureT;
		}

		// Token: 0x06027A31 RID: 162353 RVA: 0x0056C20B File Offset: 0x0056A40B
		public void UnPackTo(IPerformanceVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.PerformConfig = this.PerformConfig;
		}

		// Token: 0x06027A32 RID: 162354 RVA: 0x0056C228 File Offset: 0x0056A428
		public static Offset<IPerformanceVehicleFeature> Pack(FlatBufferBuilder builder, IPerformanceVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceVehicleFeature>);
			}
			StringOffset performConfigOffset = (_o.PerformConfig == null) ? default(StringOffset) : builder.CreateString(_o.PerformConfig);
			return IPerformanceVehicleFeature.CreateIPerformanceVehicleFeature(builder, _o.Type, performConfigOffset);
		}

		// Token: 0x0400F87F RID: 63615
		private Table __p;
	}
}
