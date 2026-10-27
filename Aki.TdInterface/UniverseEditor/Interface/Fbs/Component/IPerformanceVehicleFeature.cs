using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005721 RID: 22305
	public struct IPerformanceVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700A62C RID: 42540
		// (get) Token: 0x06025512 RID: 152850 RVA: 0x0052639C File Offset: 0x0052459C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025513 RID: 152851 RVA: 0x005263A9 File Offset: 0x005245A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025514 RID: 152852 RVA: 0x005263B0 File Offset: 0x005245B0
		public static IPerformanceVehicleFeature GetRootAsIPerformanceVehicleFeature(ByteBuffer _bb)
		{
			return IPerformanceVehicleFeature.GetRootAsIPerformanceVehicleFeature(_bb, default(IPerformanceVehicleFeature));
		}

		// Token: 0x06025515 RID: 152853 RVA: 0x005263CC File Offset: 0x005245CC
		public static IPerformanceVehicleFeature GetRootAsIPerformanceVehicleFeature(ByteBuffer _bb, IPerformanceVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025516 RID: 152854 RVA: 0x005263E9 File Offset: 0x005245E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025517 RID: 152855 RVA: 0x005263F8 File Offset: 0x005245F8
		public IPerformanceVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A62D RID: 42541
		// (get) Token: 0x06025518 RID: 152856 RVA: 0x00526408 File Offset: 0x00524608
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

		// Token: 0x1700A62E RID: 42542
		// (get) Token: 0x06025519 RID: 152857 RVA: 0x00526444 File Offset: 0x00524644
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

		// Token: 0x0602551A RID: 152858 RVA: 0x0052647B File Offset: 0x0052467B
		public Span<byte> GetPerformConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602551B RID: 152859 RVA: 0x0052648A File Offset: 0x0052468A
		public byte[] GetPerformConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602551C RID: 152860 RVA: 0x00526498 File Offset: 0x00524698
		public static Offset<IPerformanceVehicleFeature> CreateIPerformanceVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None, StringOffset PerformConfigOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IPerformanceVehicleFeature.AddPerformConfig(builder, PerformConfigOffset);
			IPerformanceVehicleFeature.AddType(builder, Type);
			return IPerformanceVehicleFeature.EndIPerformanceVehicleFeature(builder);
		}

		// Token: 0x0602551D RID: 152861 RVA: 0x005264B5 File Offset: 0x005246B5
		public static void StartIPerformanceVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602551E RID: 152862 RVA: 0x005264BE File Offset: 0x005246BE
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602551F RID: 152863 RVA: 0x005264C9 File Offset: 0x005246C9
		public static void AddPerformConfig(FlatBufferBuilder builder, StringOffset performConfigOffset)
		{
			builder.AddOffset(1, performConfigOffset.Value, 0);
		}

		// Token: 0x06025520 RID: 152864 RVA: 0x005264D9 File Offset: 0x005246D9
		public static Offset<IPerformanceVehicleFeature> EndIPerformanceVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06025521 RID: 152865 RVA: 0x005264E8 File Offset: 0x005246E8
		public IPerformanceVehicleFeatureT UnPack()
		{
			IPerformanceVehicleFeatureT performanceVehicleFeatureT = new IPerformanceVehicleFeatureT();
			this.UnPackTo(performanceVehicleFeatureT);
			return performanceVehicleFeatureT;
		}

		// Token: 0x06025522 RID: 152866 RVA: 0x00526503 File Offset: 0x00524703
		public void UnPackTo(IPerformanceVehicleFeatureT _o)
		{
			_o.Type = this.Type;
			_o.PerformConfig = this.PerformConfig;
		}

		// Token: 0x06025523 RID: 152867 RVA: 0x00526520 File Offset: 0x00524720
		public static Offset<IPerformanceVehicleFeature> Pack(FlatBufferBuilder builder, IPerformanceVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceVehicleFeature>);
			}
			StringOffset performConfigOffset = (_o.PerformConfig == null) ? default(StringOffset) : builder.CreateString(_o.PerformConfig);
			return IPerformanceVehicleFeature.CreateIPerformanceVehicleFeature(builder, _o.Type, performConfigOffset);
		}

		// Token: 0x0400EB96 RID: 60310
		private Table __p;
	}
}
