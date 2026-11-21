using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B6C RID: 31596
	public struct ITeleportToAndEnterFishingBoat : IFlatbufferObject
	{
		// Token: 0x1700EC99 RID: 60569
		// (get) Token: 0x06038E84 RID: 233092 RVA: 0x007B17A8 File Offset: 0x007AF9A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038E85 RID: 233093 RVA: 0x007B17B5 File Offset: 0x007AF9B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038E86 RID: 233094 RVA: 0x007B17BC File Offset: 0x007AF9BC
		public static ITeleportToAndEnterFishingBoat GetRootAsITeleportToAndEnterFishingBoat(ByteBuffer _bb)
		{
			return ITeleportToAndEnterFishingBoat.GetRootAsITeleportToAndEnterFishingBoat(_bb, default(ITeleportToAndEnterFishingBoat));
		}

		// Token: 0x06038E87 RID: 233095 RVA: 0x007B17D8 File Offset: 0x007AF9D8
		public static ITeleportToAndEnterFishingBoat GetRootAsITeleportToAndEnterFishingBoat(ByteBuffer _bb, ITeleportToAndEnterFishingBoat obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038E88 RID: 233096 RVA: 0x007B17F5 File Offset: 0x007AF9F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038E89 RID: 233097 RVA: 0x007B1804 File Offset: 0x007AFA04
		public ITeleportToAndEnterFishingBoat __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC9A RID: 60570
		// (get) Token: 0x06038E8A RID: 233098 RVA: 0x007B1814 File Offset: 0x007AFA14
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

		// Token: 0x06038E8B RID: 233099 RVA: 0x007B1850 File Offset: 0x007AFA50
		public static Offset<ITeleportToAndEnterFishingBoat> CreateITeleportToAndEnterFishingBoat(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			ITeleportToAndEnterFishingBoat.AddType(builder, Type);
			return ITeleportToAndEnterFishingBoat.EndITeleportToAndEnterFishingBoat(builder);
		}

		// Token: 0x06038E8C RID: 233100 RVA: 0x007B1866 File Offset: 0x007AFA66
		public static void StartITeleportToAndEnterFishingBoat(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038E8D RID: 233101 RVA: 0x007B186F File Offset: 0x007AFA6F
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038E8E RID: 233102 RVA: 0x007B187A File Offset: 0x007AFA7A
		public static Offset<ITeleportToAndEnterFishingBoat> EndITeleportToAndEnterFishingBoat(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToAndEnterFishingBoat>(builder.EndTable());
		}

		// Token: 0x06038E8F RID: 233103 RVA: 0x007B1888 File Offset: 0x007AFA88
		public ITeleportToAndEnterFishingBoatT UnPack()
		{
			ITeleportToAndEnterFishingBoatT teleportToAndEnterFishingBoatT = new ITeleportToAndEnterFishingBoatT();
			this.UnPackTo(teleportToAndEnterFishingBoatT);
			return teleportToAndEnterFishingBoatT;
		}

		// Token: 0x06038E90 RID: 233104 RVA: 0x007B18A3 File Offset: 0x007AFAA3
		public void UnPackTo(ITeleportToAndEnterFishingBoatT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038E91 RID: 233105 RVA: 0x007B18B4 File Offset: 0x007AFAB4
		public static Offset<ITeleportToAndEnterFishingBoat> Pack(FlatBufferBuilder builder, ITeleportToAndEnterFishingBoatT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToAndEnterFishingBoat>);
			}
			return ITeleportToAndEnterFishingBoat.CreateITeleportToAndEnterFishingBoat(builder, _o.Type);
		}

		// Token: 0x040131BB RID: 78267
		private Table __p;
	}
}
