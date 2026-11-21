using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E60 RID: 28256
	public struct IFixTeleControllerResetPos : IFlatbufferObject
	{
		// Token: 0x1700CF13 RID: 53011
		// (get) Token: 0x06030CF3 RID: 199923 RVA: 0x0069F8DA File Offset: 0x0069DADA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CF4 RID: 199924 RVA: 0x0069F8E7 File Offset: 0x0069DAE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CF5 RID: 199925 RVA: 0x0069F8F0 File Offset: 0x0069DAF0
		public static IFixTeleControllerResetPos GetRootAsIFixTeleControllerResetPos(ByteBuffer _bb)
		{
			return IFixTeleControllerResetPos.GetRootAsIFixTeleControllerResetPos(_bb, default(IFixTeleControllerResetPos));
		}

		// Token: 0x06030CF6 RID: 199926 RVA: 0x0069F90C File Offset: 0x0069DB0C
		public static IFixTeleControllerResetPos GetRootAsIFixTeleControllerResetPos(ByteBuffer _bb, IFixTeleControllerResetPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CF7 RID: 199927 RVA: 0x0069F929 File Offset: 0x0069DB29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CF8 RID: 199928 RVA: 0x0069F938 File Offset: 0x0069DB38
		public IFixTeleControllerResetPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF14 RID: 53012
		// (get) Token: 0x06030CF9 RID: 199929 RVA: 0x0069F948 File Offset: 0x0069DB48
		public int PositionEntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030CFA RID: 199930 RVA: 0x0069F984 File Offset: 0x0069DB84
		public static Offset<IFixTeleControllerResetPos> CreateIFixTeleControllerResetPos(FlatBufferBuilder builder, int PositionEntityId = 0)
		{
			builder.StartTable(1);
			IFixTeleControllerResetPos.AddPositionEntityId(builder, PositionEntityId);
			return IFixTeleControllerResetPos.EndIFixTeleControllerResetPos(builder);
		}

		// Token: 0x06030CFB RID: 199931 RVA: 0x0069F99A File Offset: 0x0069DB9A
		public static void StartIFixTeleControllerResetPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030CFC RID: 199932 RVA: 0x0069F9A3 File Offset: 0x0069DBA3
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(0, positionEntityId, 0);
		}

		// Token: 0x06030CFD RID: 199933 RVA: 0x0069F9AE File Offset: 0x0069DBAE
		public static Offset<IFixTeleControllerResetPos> EndIFixTeleControllerResetPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixTeleControllerResetPos>(builder.EndTable());
		}

		// Token: 0x06030CFE RID: 199934 RVA: 0x0069F9BC File Offset: 0x0069DBBC
		public IFixTeleControllerResetPosT UnPack()
		{
			IFixTeleControllerResetPosT fixTeleControllerResetPosT = new IFixTeleControllerResetPosT();
			this.UnPackTo(fixTeleControllerResetPosT);
			return fixTeleControllerResetPosT;
		}

		// Token: 0x06030CFF RID: 199935 RVA: 0x0069F9D7 File Offset: 0x0069DBD7
		public void UnPackTo(IFixTeleControllerResetPosT _o)
		{
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x06030D00 RID: 199936 RVA: 0x0069F9E8 File Offset: 0x0069DBE8
		public static Offset<IFixTeleControllerResetPos> Pack(FlatBufferBuilder builder, IFixTeleControllerResetPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixTeleControllerResetPos>);
			}
			return IFixTeleControllerResetPos.CreateIFixTeleControllerResetPos(builder, _o.PositionEntityId);
		}

		// Token: 0x04011D2B RID: 73003
		private Table __p;
	}
}
