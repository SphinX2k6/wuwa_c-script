using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E45 RID: 28229
	public struct IFishingBoatVehicle : IFlatbufferObject
	{
		// Token: 0x1700CEE8 RID: 52968
		// (get) Token: 0x06030C25 RID: 199717 RVA: 0x0069E29E File Offset: 0x0069C49E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C26 RID: 199718 RVA: 0x0069E2AB File Offset: 0x0069C4AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C27 RID: 199719 RVA: 0x0069E2B4 File Offset: 0x0069C4B4
		public static IFishingBoatVehicle GetRootAsIFishingBoatVehicle(ByteBuffer _bb)
		{
			return IFishingBoatVehicle.GetRootAsIFishingBoatVehicle(_bb, default(IFishingBoatVehicle));
		}

		// Token: 0x06030C28 RID: 199720 RVA: 0x0069E2D0 File Offset: 0x0069C4D0
		public static IFishingBoatVehicle GetRootAsIFishingBoatVehicle(ByteBuffer _bb, IFishingBoatVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C29 RID: 199721 RVA: 0x0069E2ED File Offset: 0x0069C4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C2A RID: 199722 RVA: 0x0069E2FC File Offset: 0x0069C4FC
		public IFishingBoatVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CEE9 RID: 52969
		// (get) Token: 0x06030C2B RID: 199723 RVA: 0x0069E30C File Offset: 0x0069C50C
		public ETargetVehicle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETargetVehicle.Current;
				}
				return (ETargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030C2C RID: 199724 RVA: 0x0069E348 File Offset: 0x0069C548
		public static Offset<IFishingBoatVehicle> CreateIFishingBoatVehicle(FlatBufferBuilder builder, ETargetVehicle Type = ETargetVehicle.Current)
		{
			builder.StartTable(1);
			IFishingBoatVehicle.AddType(builder, Type);
			return IFishingBoatVehicle.EndIFishingBoatVehicle(builder);
		}

		// Token: 0x06030C2D RID: 199725 RVA: 0x0069E35E File Offset: 0x0069C55E
		public static void StartIFishingBoatVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030C2E RID: 199726 RVA: 0x0069E367 File Offset: 0x0069C567
		public static void AddType(FlatBufferBuilder builder, ETargetVehicle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030C2F RID: 199727 RVA: 0x0069E372 File Offset: 0x0069C572
		public static Offset<IFishingBoatVehicle> EndIFishingBoatVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IFishingBoatVehicle>(builder.EndTable());
		}

		// Token: 0x06030C30 RID: 199728 RVA: 0x0069E380 File Offset: 0x0069C580
		public IFishingBoatVehicleT UnPack()
		{
			IFishingBoatVehicleT fishingBoatVehicleT = new IFishingBoatVehicleT();
			this.UnPackTo(fishingBoatVehicleT);
			return fishingBoatVehicleT;
		}

		// Token: 0x06030C31 RID: 199729 RVA: 0x0069E39B File Offset: 0x0069C59B
		public void UnPackTo(IFishingBoatVehicleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030C32 RID: 199730 RVA: 0x0069E3AC File Offset: 0x0069C5AC
		public static Offset<IFishingBoatVehicle> Pack(FlatBufferBuilder builder, IFishingBoatVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFishingBoatVehicle>);
			}
			return IFishingBoatVehicle.CreateIFishingBoatVehicle(builder, _o.Type);
		}

		// Token: 0x04011D11 RID: 72977
		private Table __p;
	}
}
