using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006329 RID: 25385
	public struct IChangeTeamPosition : IFlatbufferObject
	{
		// Token: 0x1700BD7A RID: 48506
		// (get) Token: 0x0602BE8B RID: 179851 RVA: 0x0060948A File Offset: 0x0060768A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE8C RID: 179852 RVA: 0x00609497 File Offset: 0x00607697
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE8D RID: 179853 RVA: 0x006094A0 File Offset: 0x006076A0
		public static IChangeTeamPosition GetRootAsIChangeTeamPosition(ByteBuffer _bb)
		{
			return IChangeTeamPosition.GetRootAsIChangeTeamPosition(_bb, default(IChangeTeamPosition));
		}

		// Token: 0x0602BE8E RID: 179854 RVA: 0x006094BC File Offset: 0x006076BC
		public static IChangeTeamPosition GetRootAsIChangeTeamPosition(ByteBuffer _bb, IChangeTeamPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE8F RID: 179855 RVA: 0x006094D9 File Offset: 0x006076D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE90 RID: 179856 RVA: 0x006094E8 File Offset: 0x006076E8
		public IChangeTeamPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BD7B RID: 48507
		// (get) Token: 0x0602BE91 RID: 179857 RVA: 0x006094F8 File Offset: 0x006076F8
		public int PositionId
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

		// Token: 0x1700BD7C RID: 48508
		// (get) Token: 0x0602BE92 RID: 179858 RVA: 0x00609534 File Offset: 0x00607734
		public bool RestoreToPrevious
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BD7D RID: 48509
		// (get) Token: 0x0602BE93 RID: 179859 RVA: 0x00609574 File Offset: 0x00607774
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BE94 RID: 179860 RVA: 0x006095B0 File Offset: 0x006077B0
		public static Offset<IChangeTeamPosition> CreateIChangeTeamPosition(FlatBufferBuilder builder, int PositionId = 0, bool RestoreToPrevious = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IChangeTeamPosition.AddPositionId(builder, PositionId);
			IChangeTeamPosition.AddNullMask(builder, NullMask);
			IChangeTeamPosition.AddRestoreToPrevious(builder, RestoreToPrevious);
			return IChangeTeamPosition.EndIChangeTeamPosition(builder);
		}

		// Token: 0x0602BE95 RID: 179861 RVA: 0x006095D4 File Offset: 0x006077D4
		public static void StartIChangeTeamPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602BE96 RID: 179862 RVA: 0x006095DD File Offset: 0x006077DD
		public static void AddPositionId(FlatBufferBuilder builder, int positionId)
		{
			builder.AddInt(0, positionId, 0);
		}

		// Token: 0x0602BE97 RID: 179863 RVA: 0x006095E8 File Offset: 0x006077E8
		public static void AddRestoreToPrevious(FlatBufferBuilder builder, bool restoreToPrevious)
		{
			builder.AddBool(1, restoreToPrevious, false);
		}

		// Token: 0x0602BE98 RID: 179864 RVA: 0x006095F3 File Offset: 0x006077F3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602BE99 RID: 179865 RVA: 0x006095FE File Offset: 0x006077FE
		public static Offset<IChangeTeamPosition> EndIChangeTeamPosition(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTeamPosition>(builder.EndTable());
		}

		// Token: 0x0602BE9A RID: 179866 RVA: 0x0060960C File Offset: 0x0060780C
		public IChangeTeamPositionT UnPack()
		{
			IChangeTeamPositionT changeTeamPositionT = new IChangeTeamPositionT();
			this.UnPackTo(changeTeamPositionT);
			return changeTeamPositionT;
		}

		// Token: 0x0602BE9B RID: 179867 RVA: 0x00609627 File Offset: 0x00607827
		public void UnPackTo(IChangeTeamPositionT _o)
		{
			_o.PositionId = this.PositionId;
			_o.RestoreToPrevious = this.RestoreToPrevious;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602BE9C RID: 179868 RVA: 0x00609650 File Offset: 0x00607850
		public static Offset<IChangeTeamPosition> Pack(FlatBufferBuilder builder, IChangeTeamPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTeamPosition>);
			}
			return IChangeTeamPosition.CreateIChangeTeamPosition(builder, _o.PositionId, _o.RestoreToPrevious, _o.NullMask);
		}

		// Token: 0x040108EB RID: 67819
		private Table __p;
	}
}
