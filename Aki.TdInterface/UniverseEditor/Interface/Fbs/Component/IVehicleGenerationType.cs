using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1D RID: 23325
	public struct IVehicleGenerationType : IFlatbufferObject
	{
		// Token: 0x1700B011 RID: 45073
		// (get) Token: 0x06027DCA RID: 163274 RVA: 0x0057B943 File Offset: 0x00579B43
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027DCB RID: 163275 RVA: 0x0057B950 File Offset: 0x00579B50
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027DCC RID: 163276 RVA: 0x0057B958 File Offset: 0x00579B58
		public static IVehicleGenerationType GetRootAsIVehicleGenerationType(ByteBuffer _bb)
		{
			return IVehicleGenerationType.GetRootAsIVehicleGenerationType(_bb, default(IVehicleGenerationType));
		}

		// Token: 0x06027DCD RID: 163277 RVA: 0x0057B974 File Offset: 0x00579B74
		public static IVehicleGenerationType GetRootAsIVehicleGenerationType(ByteBuffer _bb, IVehicleGenerationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027DCE RID: 163278 RVA: 0x0057B991 File Offset: 0x00579B91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027DCF RID: 163279 RVA: 0x0057B9A0 File Offset: 0x00579BA0
		public IVehicleGenerationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B012 RID: 45074
		// (get) Token: 0x06027DD0 RID: 163280 RVA: 0x0057B9B0 File Offset: 0x00579BB0
		public EVehicleGenerationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleGenerationType.VehicleEntityTemplate;
				}
				return (EVehicleGenerationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B013 RID: 45075
		// (get) Token: 0x06027DD1 RID: 163281 RVA: 0x0057B9EC File Offset: 0x00579BEC
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B014 RID: 45076
		// (get) Token: 0x06027DD2 RID: 163282 RVA: 0x0057BA28 File Offset: 0x00579C28
		public int Weight
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027DD3 RID: 163283 RVA: 0x0057BA64 File Offset: 0x00579C64
		public static Offset<IVehicleGenerationType> CreateIVehicleGenerationType(FlatBufferBuilder builder, EVehicleGenerationType Type = EVehicleGenerationType.VehicleEntityTemplate, int Id = 0, int Weight = 0)
		{
			builder.StartTable(3);
			IVehicleGenerationType.AddWeight(builder, Weight);
			IVehicleGenerationType.AddId(builder, Id);
			IVehicleGenerationType.AddType(builder, Type);
			return IVehicleGenerationType.EndIVehicleGenerationType(builder);
		}

		// Token: 0x06027DD4 RID: 163284 RVA: 0x0057BA88 File Offset: 0x00579C88
		public static void StartIVehicleGenerationType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027DD5 RID: 163285 RVA: 0x0057BA91 File Offset: 0x00579C91
		public static void AddType(FlatBufferBuilder builder, EVehicleGenerationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027DD6 RID: 163286 RVA: 0x0057BA9C File Offset: 0x00579C9C
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06027DD7 RID: 163287 RVA: 0x0057BAA7 File Offset: 0x00579CA7
		public static void AddWeight(FlatBufferBuilder builder, int weight)
		{
			builder.AddInt(2, weight, 0);
		}

		// Token: 0x06027DD8 RID: 163288 RVA: 0x0057BAB2 File Offset: 0x00579CB2
		public static Offset<IVehicleGenerationType> EndIVehicleGenerationType(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleGenerationType>(builder.EndTable());
		}

		// Token: 0x06027DD9 RID: 163289 RVA: 0x0057BAC0 File Offset: 0x00579CC0
		public IVehicleGenerationTypeT UnPack()
		{
			IVehicleGenerationTypeT vehicleGenerationTypeT = new IVehicleGenerationTypeT();
			this.UnPackTo(vehicleGenerationTypeT);
			return vehicleGenerationTypeT;
		}

		// Token: 0x06027DDA RID: 163290 RVA: 0x0057BADB File Offset: 0x00579CDB
		public void UnPackTo(IVehicleGenerationTypeT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.Weight = this.Weight;
		}

		// Token: 0x06027DDB RID: 163291 RVA: 0x0057BB04 File Offset: 0x00579D04
		public static Offset<IVehicleGenerationType> Pack(FlatBufferBuilder builder, IVehicleGenerationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleGenerationType>);
			}
			return IVehicleGenerationType.CreateIVehicleGenerationType(builder, _o.Type, _o.Id, _o.Weight);
		}

		// Token: 0x0400F238 RID: 62008
		private Table __p;
	}
}
