using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007397 RID: 29591
	public struct ITeleportToVehicleInfo : IFlatbufferObject
	{
		// Token: 0x1700E09A RID: 57498
		// (get) Token: 0x06035B4F RID: 219983 RVA: 0x0074FBC2 File Offset: 0x0074DDC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035B50 RID: 219984 RVA: 0x0074FBCF File Offset: 0x0074DDCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035B51 RID: 219985 RVA: 0x0074FBD8 File Offset: 0x0074DDD8
		public static ITeleportToVehicleInfo GetRootAsITeleportToVehicleInfo(ByteBuffer _bb)
		{
			return ITeleportToVehicleInfo.GetRootAsITeleportToVehicleInfo(_bb, default(ITeleportToVehicleInfo));
		}

		// Token: 0x06035B52 RID: 219986 RVA: 0x0074FBF4 File Offset: 0x0074DDF4
		public static ITeleportToVehicleInfo GetRootAsITeleportToVehicleInfo(ByteBuffer _bb, ITeleportToVehicleInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035B53 RID: 219987 RVA: 0x0074FC11 File Offset: 0x0074DE11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035B54 RID: 219988 RVA: 0x0074FC20 File Offset: 0x0074DE20
		public ITeleportToVehicleInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E09B RID: 57499
		// (get) Token: 0x06035B55 RID: 219989 RVA: 0x0074FC30 File Offset: 0x0074DE30
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

		// Token: 0x06035B56 RID: 219990 RVA: 0x0074FC6C File Offset: 0x0074DE6C
		public static Offset<ITeleportToVehicleInfo> CreateITeleportToVehicleInfo(FlatBufferBuilder builder, EVehicleType Type = EVehicleType.Gongduola)
		{
			builder.StartTable(1);
			ITeleportToVehicleInfo.AddType(builder, Type);
			return ITeleportToVehicleInfo.EndITeleportToVehicleInfo(builder);
		}

		// Token: 0x06035B57 RID: 219991 RVA: 0x0074FC82 File Offset: 0x0074DE82
		public static void StartITeleportToVehicleInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035B58 RID: 219992 RVA: 0x0074FC8B File Offset: 0x0074DE8B
		public static void AddType(FlatBufferBuilder builder, EVehicleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035B59 RID: 219993 RVA: 0x0074FC96 File Offset: 0x0074DE96
		public static Offset<ITeleportToVehicleInfo> EndITeleportToVehicleInfo(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToVehicleInfo>(builder.EndTable());
		}

		// Token: 0x06035B5A RID: 219994 RVA: 0x0074FCA4 File Offset: 0x0074DEA4
		public ITeleportToVehicleInfoT UnPack()
		{
			ITeleportToVehicleInfoT teleportToVehicleInfoT = new ITeleportToVehicleInfoT();
			this.UnPackTo(teleportToVehicleInfoT);
			return teleportToVehicleInfoT;
		}

		// Token: 0x06035B5B RID: 219995 RVA: 0x0074FCBF File Offset: 0x0074DEBF
		public void UnPackTo(ITeleportToVehicleInfoT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035B5C RID: 219996 RVA: 0x0074FCD0 File Offset: 0x0074DED0
		public static Offset<ITeleportToVehicleInfo> Pack(FlatBufferBuilder builder, ITeleportToVehicleInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToVehicleInfo>);
			}
			return ITeleportToVehicleInfo.CreateITeleportToVehicleInfo(builder, _o.Type);
		}

		// Token: 0x040121B2 RID: 74162
		private Table __p;
	}
}
