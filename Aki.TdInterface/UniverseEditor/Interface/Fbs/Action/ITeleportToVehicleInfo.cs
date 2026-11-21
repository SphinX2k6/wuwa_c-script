using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B7E RID: 31614
	public struct ITeleportToVehicleInfo : IFlatbufferObject
	{
		// Token: 0x1700ECAA RID: 60586
		// (get) Token: 0x06038EEA RID: 233194 RVA: 0x007B2102 File Offset: 0x007B0302
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038EEB RID: 233195 RVA: 0x007B210F File Offset: 0x007B030F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038EEC RID: 233196 RVA: 0x007B2118 File Offset: 0x007B0318
		public static ITeleportToVehicleInfo GetRootAsITeleportToVehicleInfo(ByteBuffer _bb)
		{
			return ITeleportToVehicleInfo.GetRootAsITeleportToVehicleInfo(_bb, default(ITeleportToVehicleInfo));
		}

		// Token: 0x06038EED RID: 233197 RVA: 0x007B2134 File Offset: 0x007B0334
		public static ITeleportToVehicleInfo GetRootAsITeleportToVehicleInfo(ByteBuffer _bb, ITeleportToVehicleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038EEE RID: 233198 RVA: 0x007B2151 File Offset: 0x007B0351
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038EEF RID: 233199 RVA: 0x007B2160 File Offset: 0x007B0360
		public ITeleportToVehicleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECAB RID: 60587
		// (get) Token: 0x06038EF0 RID: 233200 RVA: 0x007B2170 File Offset: 0x007B0370
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

		// Token: 0x06038EF1 RID: 233201 RVA: 0x007B21AC File Offset: 0x007B03AC
		public static Offset<ITeleportToVehicleInfo> CreateITeleportToVehicleInfo(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			ITeleportToVehicleInfo.AddType(builder, Type);
			return ITeleportToVehicleInfo.EndITeleportToVehicleInfo(builder);
		}

		// Token: 0x06038EF2 RID: 233202 RVA: 0x007B21C2 File Offset: 0x007B03C2
		public static void StartITeleportToVehicleInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038EF3 RID: 233203 RVA: 0x007B21CB File Offset: 0x007B03CB
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038EF4 RID: 233204 RVA: 0x007B21D6 File Offset: 0x007B03D6
		public static Offset<ITeleportToVehicleInfo> EndITeleportToVehicleInfo(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToVehicleInfo>(builder.EndTable());
		}

		// Token: 0x06038EF5 RID: 233205 RVA: 0x007B21E4 File Offset: 0x007B03E4
		public ITeleportToVehicleInfoT UnPack()
		{
			ITeleportToVehicleInfoT teleportToVehicleInfoT = new ITeleportToVehicleInfoT();
			this.UnPackTo(teleportToVehicleInfoT);
			return teleportToVehicleInfoT;
		}

		// Token: 0x06038EF6 RID: 233206 RVA: 0x007B21FF File Offset: 0x007B03FF
		public void UnPackTo(ITeleportToVehicleInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038EF7 RID: 233207 RVA: 0x007B2210 File Offset: 0x007B0410
		public static Offset<ITeleportToVehicleInfo> Pack(FlatBufferBuilder builder, ITeleportToVehicleInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToVehicleInfo>);
			}
			return ITeleportToVehicleInfo.CreateITeleportToVehicleInfo(builder, _o.Type);
		}

		// Token: 0x040131CB RID: 78283
		private Table __p;
	}
}
