using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007385 RID: 29573
	public struct ITeleportToAndEnterFishingBoat : IFlatbufferObject
	{
		// Token: 0x1700E089 RID: 57481
		// (get) Token: 0x06035AE9 RID: 219881 RVA: 0x0074F268 File Offset: 0x0074D468
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AEA RID: 219882 RVA: 0x0074F275 File Offset: 0x0074D475
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AEB RID: 219883 RVA: 0x0074F27C File Offset: 0x0074D47C
		public static ITeleportToAndEnterFishingBoat GetRootAsITeleportToAndEnterFishingBoat(ByteBuffer _bb)
		{
			return ITeleportToAndEnterFishingBoat.GetRootAsITeleportToAndEnterFishingBoat(_bb, default(ITeleportToAndEnterFishingBoat));
		}

		// Token: 0x06035AEC RID: 219884 RVA: 0x0074F298 File Offset: 0x0074D498
		public static ITeleportToAndEnterFishingBoat GetRootAsITeleportToAndEnterFishingBoat(ByteBuffer _bb, ITeleportToAndEnterFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AED RID: 219885 RVA: 0x0074F2B5 File Offset: 0x0074D4B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AEE RID: 219886 RVA: 0x0074F2C4 File Offset: 0x0074D4C4
		public ITeleportToAndEnterFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E08A RID: 57482
		// (get) Token: 0x06035AEF RID: 219887 RVA: 0x0074F2D4 File Offset: 0x0074D4D4
		public EVehicleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EVehicleType.Gongduola;
				}
				return (EVehicleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035AF0 RID: 219888 RVA: 0x0074F310 File Offset: 0x0074D510
		public static Offset<ITeleportToAndEnterFishingBoat> CreateITeleportToAndEnterFishingBoat(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			ITeleportToAndEnterFishingBoat.AddType(builder, Type);
			return ITeleportToAndEnterFishingBoat.EndITeleportToAndEnterFishingBoat(builder);
		}

		// Token: 0x06035AF1 RID: 219889 RVA: 0x0074F326 File Offset: 0x0074D526
		public static void StartITeleportToAndEnterFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035AF2 RID: 219890 RVA: 0x0074F32F File Offset: 0x0074D52F
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035AF3 RID: 219891 RVA: 0x0074F33A File Offset: 0x0074D53A
		public static Offset<ITeleportToAndEnterFishingBoat> EndITeleportToAndEnterFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToAndEnterFishingBoat>(builder.EndTable());
		}

		// Token: 0x06035AF4 RID: 219892 RVA: 0x0074F348 File Offset: 0x0074D548
		public ITeleportToAndEnterFishingBoatT UnPack()
		{
			ITeleportToAndEnterFishingBoatT teleportToAndEnterFishingBoatT = new ITeleportToAndEnterFishingBoatT();
			this.UnPackTo(teleportToAndEnterFishingBoatT);
			return teleportToAndEnterFishingBoatT;
		}

		// Token: 0x06035AF5 RID: 219893 RVA: 0x0074F363 File Offset: 0x0074D563
		public void UnPackTo(ITeleportToAndEnterFishingBoatT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035AF6 RID: 219894 RVA: 0x0074F374 File Offset: 0x0074D574
		public static Offset<ITeleportToAndEnterFishingBoat> Pack(FlatBufferBuilder builder, ITeleportToAndEnterFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToAndEnterFishingBoat>);
			}
			return ITeleportToAndEnterFishingBoat.CreateITeleportToAndEnterFishingBoat(builder, _o.Type);
		}

		// Token: 0x040121A2 RID: 74146
		private Table __p;
	}
}
