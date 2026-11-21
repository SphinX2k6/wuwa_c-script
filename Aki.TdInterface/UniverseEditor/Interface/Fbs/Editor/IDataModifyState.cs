using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB5 RID: 19637
	public struct IDataModifyState : IFlatbufferObject
	{
		// Token: 0x17008B2B RID: 35627
		// (get) Token: 0x0601E223 RID: 123427 RVA: 0x00438D8C File Offset: 0x00436F8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E224 RID: 123428 RVA: 0x00438D99 File Offset: 0x00436F99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E225 RID: 123429 RVA: 0x00438DA0 File Offset: 0x00436FA0
		public static IDataModifyState GetRootAsIDataModifyState(ByteBuffer _bb)
		{
			return IDataModifyState.GetRootAsIDataModifyState(_bb, default(IDataModifyState));
		}

		// Token: 0x0601E226 RID: 123430 RVA: 0x00438DBC File Offset: 0x00436FBC
		public static IDataModifyState GetRootAsIDataModifyState(ByteBuffer _bb, IDataModifyState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E227 RID: 123431 RVA: 0x00438DD9 File Offset: 0x00436FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E228 RID: 123432 RVA: 0x00438DE8 File Offset: 0x00436FE8
		public IDataModifyState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B2C RID: 35628
		// (get) Token: 0x0601E229 RID: 123433 RVA: 0x00438DF8 File Offset: 0x00436FF8
		public string Uid
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E22A RID: 123434 RVA: 0x00438E2F File Offset: 0x0043702F
		public Span<byte> GetUidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E22B RID: 123435 RVA: 0x00438E3E File Offset: 0x0043703E
		public byte[] GetUidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008B2D RID: 35629
		// (get) Token: 0x0601E22C RID: 123436 RVA: 0x00438E4C File Offset: 0x0043704C
		public EDataChangeType UpdateType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EDataChangeType.None;
				}
				return (EDataChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E22D RID: 123437 RVA: 0x00438E88 File Offset: 0x00437088
		public static Offset<IDataModifyState> CreateIDataModifyState(FlatBufferBuilder builder, StringOffset UidOffset = default(StringOffset), EDataChangeType UpdateType = EDataChangeType.None)
		{
			builder.StartTable(2);
			IDataModifyState.AddUid(builder, UidOffset);
			IDataModifyState.AddUpdateType(builder, UpdateType);
			return IDataModifyState.EndIDataModifyState(builder);
		}

		// Token: 0x0601E22E RID: 123438 RVA: 0x00438EA5 File Offset: 0x004370A5
		public static void StartIDataModifyState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E22F RID: 123439 RVA: 0x00438EAE File Offset: 0x004370AE
		public static void AddUid(FlatBufferBuilder builder, StringOffset uidOffset)
		{
			builder.AddOffset(0, uidOffset.Value, 0);
		}

		// Token: 0x0601E230 RID: 123440 RVA: 0x00438EBE File Offset: 0x004370BE
		public static void AddUpdateType(FlatBufferBuilder builder, EDataChangeType updateType)
		{
			builder.AddByte(1, (byte)updateType, 0);
		}

		// Token: 0x0601E231 RID: 123441 RVA: 0x00438EC9 File Offset: 0x004370C9
		public static Offset<IDataModifyState> EndIDataModifyState(FlatBufferBuilder builder)
		{
			return new Offset<IDataModifyState>(builder.EndTable());
		}

		// Token: 0x0601E232 RID: 123442 RVA: 0x00438ED8 File Offset: 0x004370D8
		public IDataModifyStateT UnPack()
		{
			IDataModifyStateT dataModifyStateT = new IDataModifyStateT();
			this.UnPackTo(dataModifyStateT);
			return dataModifyStateT;
		}

		// Token: 0x0601E233 RID: 123443 RVA: 0x00438EF3 File Offset: 0x004370F3
		public void UnPackTo(IDataModifyStateT _o)
		{
			_o.Uid = this.Uid;
			_o.UpdateType = this.UpdateType;
		}

		// Token: 0x0601E234 RID: 123444 RVA: 0x00438F10 File Offset: 0x00437110
		public static Offset<IDataModifyState> Pack(FlatBufferBuilder builder, IDataModifyStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDataModifyState>);
			}
			StringOffset uidOffset = (_o.Uid == null) ? default(StringOffset) : builder.CreateString(_o.Uid);
			return IDataModifyState.CreateIDataModifyState(builder, uidOffset, _o.UpdateType);
		}

		// Token: 0x0400D7BC RID: 55228
		private Table __p;
	}
}
