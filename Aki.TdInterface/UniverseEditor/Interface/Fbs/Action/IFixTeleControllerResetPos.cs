using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E0 RID: 26592
	public struct IFixTeleControllerResetPos : IFlatbufferObject
	{
		// Token: 0x1700C55D RID: 50525
		// (get) Token: 0x0602E4AD RID: 189613 RVA: 0x00652196 File Offset: 0x00650396
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E4AE RID: 189614 RVA: 0x006521A3 File Offset: 0x006503A3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E4AF RID: 189615 RVA: 0x006521AC File Offset: 0x006503AC
		public static IFixTeleControllerResetPos GetRootAsIFixTeleControllerResetPos(ByteBuffer _bb)
		{
			return IFixTeleControllerResetPos.GetRootAsIFixTeleControllerResetPos(_bb, default(IFixTeleControllerResetPos));
		}

		// Token: 0x0602E4B0 RID: 189616 RVA: 0x006521C8 File Offset: 0x006503C8
		public static IFixTeleControllerResetPos GetRootAsIFixTeleControllerResetPos(ByteBuffer _bb, IFixTeleControllerResetPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E4B1 RID: 189617 RVA: 0x006521E5 File Offset: 0x006503E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E4B2 RID: 189618 RVA: 0x006521F4 File Offset: 0x006503F4
		public IFixTeleControllerResetPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C55E RID: 50526
		// (get) Token: 0x0602E4B3 RID: 189619 RVA: 0x00652204 File Offset: 0x00650404
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

		// Token: 0x0602E4B4 RID: 189620 RVA: 0x00652240 File Offset: 0x00650440
		public static Offset<IFixTeleControllerResetPos> CreateIFixTeleControllerResetPos(FlatBufferBuilder builder, int PositionEntityId = 0)
		{
			builder.StartTable(1);
			IFixTeleControllerResetPos.AddPositionEntityId(builder, PositionEntityId);
			return IFixTeleControllerResetPos.EndIFixTeleControllerResetPos(builder);
		}

		// Token: 0x0602E4B5 RID: 189621 RVA: 0x00652256 File Offset: 0x00650456
		public static void StartIFixTeleControllerResetPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E4B6 RID: 189622 RVA: 0x0065225F File Offset: 0x0065045F
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(0, positionEntityId, 0);
		}

		// Token: 0x0602E4B7 RID: 189623 RVA: 0x0065226A File Offset: 0x0065046A
		public static Offset<IFixTeleControllerResetPos> EndIFixTeleControllerResetPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixTeleControllerResetPos>(builder.EndTable());
		}

		// Token: 0x0602E4B8 RID: 189624 RVA: 0x00652278 File Offset: 0x00650478
		public IFixTeleControllerResetPosT UnPack()
		{
			IFixTeleControllerResetPosT fixTeleControllerResetPosT = new IFixTeleControllerResetPosT();
			this.UnPackTo(fixTeleControllerResetPosT);
			return fixTeleControllerResetPosT;
		}

		// Token: 0x0602E4B9 RID: 189625 RVA: 0x00652293 File Offset: 0x00650493
		public void UnPackTo(IFixTeleControllerResetPosT _o)
		{
			_o.PositionEntityId = this.PositionEntityId;
		}

		// Token: 0x0602E4BA RID: 189626 RVA: 0x006522A4 File Offset: 0x006504A4
		public static Offset<IFixTeleControllerResetPos> Pack(FlatBufferBuilder builder, IFixTeleControllerResetPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixTeleControllerResetPos>);
			}
			return IFixTeleControllerResetPos.CreateIFixTeleControllerResetPos(builder, _o.PositionEntityId);
		}

		// Token: 0x04010EF9 RID: 69369
		private Table __p;
	}
}
