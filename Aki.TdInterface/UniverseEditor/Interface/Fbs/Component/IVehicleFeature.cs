using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0E RID: 23310
	public struct IVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700AFF2 RID: 45042
		// (get) Token: 0x06027D36 RID: 163126 RVA: 0x0057A6A2 File Offset: 0x005788A2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027D37 RID: 163127 RVA: 0x0057A6AF File Offset: 0x005788AF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027D38 RID: 163128 RVA: 0x0057A6B8 File Offset: 0x005788B8
		public static IVehicleFeature GetRootAsIVehicleFeature(ByteBuffer _bb)
		{
			return IVehicleFeature.GetRootAsIVehicleFeature(_bb, default(IVehicleFeature));
		}

		// Token: 0x06027D39 RID: 163129 RVA: 0x0057A6D4 File Offset: 0x005788D4
		public static IVehicleFeature GetRootAsIVehicleFeature(ByteBuffer _bb, IVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027D3A RID: 163130 RVA: 0x0057A6F1 File Offset: 0x005788F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027D3B RID: 163131 RVA: 0x0057A700 File Offset: 0x00578900
		public IVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFF3 RID: 45043
		// (get) Token: 0x06027D3C RID: 163132 RVA: 0x0057A710 File Offset: 0x00578910
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

		// Token: 0x06027D3D RID: 163133 RVA: 0x0057A74C File Offset: 0x0057894C
		public static Offset<IVehicleFeature> CreateIVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None)
		{
			builder.StartTable(1);
			IVehicleFeature.AddType(builder, Type);
			return IVehicleFeature.EndIVehicleFeature(builder);
		}

		// Token: 0x06027D3E RID: 163134 RVA: 0x0057A762 File Offset: 0x00578962
		public static void StartIVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027D3F RID: 163135 RVA: 0x0057A76B File Offset: 0x0057896B
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027D40 RID: 163136 RVA: 0x0057A776 File Offset: 0x00578976
		public static Offset<IVehicleFeature> EndIVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleFeature>(builder.EndTable());
		}

		// Token: 0x06027D41 RID: 163137 RVA: 0x0057A784 File Offset: 0x00578984
		public IVehicleFeatureT UnPack()
		{
			IVehicleFeatureT vehicleFeatureT = new IVehicleFeatureT();
			this.UnPackTo(vehicleFeatureT);
			return vehicleFeatureT;
		}

		// Token: 0x06027D42 RID: 163138 RVA: 0x0057A79F File Offset: 0x0057899F
		public void UnPackTo(IVehicleFeatureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027D43 RID: 163139 RVA: 0x0057A7B0 File Offset: 0x005789B0
		public static Offset<IVehicleFeature> Pack(FlatBufferBuilder builder, IVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleFeature>);
			}
			return IVehicleFeature.CreateIVehicleFeature(builder, _o.Type);
		}

		// Token: 0x0400F21D RID: 61981
		private Table __p;
	}
}
