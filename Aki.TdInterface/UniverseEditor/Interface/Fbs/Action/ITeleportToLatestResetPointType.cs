using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B78 RID: 31608
	public struct ITeleportToLatestResetPointType : IFlatbufferObject
	{
		// Token: 0x1700ECA5 RID: 60581
		// (get) Token: 0x06038ECC RID: 233164 RVA: 0x007B1E8D File Offset: 0x007B008D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038ECD RID: 233165 RVA: 0x007B1E9A File Offset: 0x007B009A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038ECE RID: 233166 RVA: 0x007B1EA4 File Offset: 0x007B00A4
		public static ITeleportToLatestResetPointType GetRootAsITeleportToLatestResetPointType(ByteBuffer _bb)
		{
			return ITeleportToLatestResetPointType.GetRootAsITeleportToLatestResetPointType(_bb, default(ITeleportToLatestResetPointType));
		}

		// Token: 0x06038ECF RID: 233167 RVA: 0x007B1EC0 File Offset: 0x007B00C0
		public static ITeleportToLatestResetPointType GetRootAsITeleportToLatestResetPointType(ByteBuffer _bb, ITeleportToLatestResetPointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038ED0 RID: 233168 RVA: 0x007B1EDD File Offset: 0x007B00DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038ED1 RID: 233169 RVA: 0x007B1EEC File Offset: 0x007B00EC
		public ITeleportToLatestResetPointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ECA6 RID: 60582
		// (get) Token: 0x06038ED2 RID: 233170 RVA: 0x007B1EFC File Offset: 0x007B00FC
		public ETeleportToLatestResetPointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportToLatestResetPointType.Directly;
				}
				return (ETeleportToLatestResetPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06038ED3 RID: 233171 RVA: 0x007B1F38 File Offset: 0x007B0138
		public static Offset<ITeleportToLatestResetPointType> CreateITeleportToLatestResetPointType(FlatBufferBuilder builder, ETeleportToLatestResetPointType Type = ETeleportToLatestResetPointType.Directly)
		{
			builder.StartTable(1);
			ITeleportToLatestResetPointType.AddType(builder, Type);
			return ITeleportToLatestResetPointType.EndITeleportToLatestResetPointType(builder);
		}

		// Token: 0x06038ED4 RID: 233172 RVA: 0x007B1F4E File Offset: 0x007B014E
		public static void StartITeleportToLatestResetPointType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06038ED5 RID: 233173 RVA: 0x007B1F57 File Offset: 0x007B0157
		public static void AddType(FlatBufferBuilder builder, ETeleportToLatestResetPointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06038ED6 RID: 233174 RVA: 0x007B1F62 File Offset: 0x007B0162
		public static Offset<ITeleportToLatestResetPointType> EndITeleportToLatestResetPointType(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportToLatestResetPointType>(builder.EndTable());
		}

		// Token: 0x06038ED7 RID: 233175 RVA: 0x007B1F70 File Offset: 0x007B0170
		public ITeleportToLatestResetPointTypeT UnPack()
		{
			ITeleportToLatestResetPointTypeT teleportToLatestResetPointTypeT = new ITeleportToLatestResetPointTypeT();
			this.UnPackTo(teleportToLatestResetPointTypeT);
			return teleportToLatestResetPointTypeT;
		}

		// Token: 0x06038ED8 RID: 233176 RVA: 0x007B1F8B File Offset: 0x007B018B
		public void UnPackTo(ITeleportToLatestResetPointTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06038ED9 RID: 233177 RVA: 0x007B1F9C File Offset: 0x007B019C
		public static Offset<ITeleportToLatestResetPointType> Pack(FlatBufferBuilder builder, ITeleportToLatestResetPointTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportToLatestResetPointType>);
			}
			return ITeleportToLatestResetPointType.CreateITeleportToLatestResetPointType(builder, _o.Type);
		}

		// Token: 0x040131C3 RID: 78275
		private Table __p;
	}
}
