using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006124 RID: 24868
	public struct IVehicleFeature : IFlatbufferObject
	{
		// Token: 0x1700B93A RID: 47418
		// (get) Token: 0x0602A2FA RID: 172794 RVA: 0x005C20F6 File Offset: 0x005C02F6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A2FB RID: 172795 RVA: 0x005C2103 File Offset: 0x005C0303
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A2FC RID: 172796 RVA: 0x005C210C File Offset: 0x005C030C
		public static IVehicleFeature GetRootAsIVehicleFeature(ByteBuffer _bb)
		{
			return IVehicleFeature.GetRootAsIVehicleFeature(_bb, default(IVehicleFeature));
		}

		// Token: 0x0602A2FD RID: 172797 RVA: 0x005C2128 File Offset: 0x005C0328
		public static IVehicleFeature GetRootAsIVehicleFeature(ByteBuffer _bb, IVehicleFeature obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A2FE RID: 172798 RVA: 0x005C2145 File Offset: 0x005C0345
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A2FF RID: 172799 RVA: 0x005C2154 File Offset: 0x005C0354
		public IVehicleFeature __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B93B RID: 47419
		// (get) Token: 0x0602A300 RID: 172800 RVA: 0x005C2164 File Offset: 0x005C0364
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

		// Token: 0x0602A301 RID: 172801 RVA: 0x005C21A0 File Offset: 0x005C03A0
		public static Offset<IVehicleFeature> CreateIVehicleFeature(FlatBufferBuilder builder, EVehicleFeatureFlag Type = EVehicleFeatureFlag.None)
		{
			builder.StartTable(1);
			IVehicleFeature.AddType(builder, Type);
			return IVehicleFeature.EndIVehicleFeature(builder);
		}

		// Token: 0x0602A302 RID: 172802 RVA: 0x005C21B6 File Offset: 0x005C03B6
		public static void StartIVehicleFeature(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A303 RID: 172803 RVA: 0x005C21BF File Offset: 0x005C03BF
		public static void AddType(FlatBufferBuilder builder, EVehicleFeatureFlag type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A304 RID: 172804 RVA: 0x005C21CA File Offset: 0x005C03CA
		public static Offset<IVehicleFeature> EndIVehicleFeature(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleFeature>(builder.EndTable());
		}

		// Token: 0x0602A305 RID: 172805 RVA: 0x005C21D8 File Offset: 0x005C03D8
		public IVehicleFeatureT UnPack()
		{
			IVehicleFeatureT vehicleFeatureT = new IVehicleFeatureT();
			this.UnPackTo(vehicleFeatureT);
			return vehicleFeatureT;
		}

		// Token: 0x0602A306 RID: 172806 RVA: 0x005C21F3 File Offset: 0x005C03F3
		public void UnPackTo(IVehicleFeatureT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A307 RID: 172807 RVA: 0x005C2204 File Offset: 0x005C0404
		public static Offset<IVehicleFeature> Pack(FlatBufferBuilder builder, IVehicleFeatureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleFeature>);
			}
			return IVehicleFeature.CreateIVehicleFeature(builder, _o.Type);
		}

		// Token: 0x0400FF23 RID: 65315
		private Table __p;
	}
}
