using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200484D RID: 18509
	public struct IDataModifyState : IFlatbufferObject
	{
		// Token: 0x170084E0 RID: 34016
		// (get) Token: 0x0601CA26 RID: 117286 RVA: 0x0040C43C File Offset: 0x0040A63C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CA27 RID: 117287 RVA: 0x0040C449 File Offset: 0x0040A649
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CA28 RID: 117288 RVA: 0x0040C450 File Offset: 0x0040A650
		public static IDataModifyState GetRootAsIDataModifyState(ByteBuffer _bb)
		{
			return IDataModifyState.GetRootAsIDataModifyState(_bb, default(IDataModifyState));
		}

		// Token: 0x0601CA29 RID: 117289 RVA: 0x0040C46C File Offset: 0x0040A66C
		public static IDataModifyState GetRootAsIDataModifyState(ByteBuffer _bb, IDataModifyState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CA2A RID: 117290 RVA: 0x0040C489 File Offset: 0x0040A689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CA2B RID: 117291 RVA: 0x0040C498 File Offset: 0x0040A698
		public IDataModifyState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084E1 RID: 34017
		// (get) Token: 0x0601CA2C RID: 117292 RVA: 0x0040C4A8 File Offset: 0x0040A6A8
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

		// Token: 0x0601CA2D RID: 117293 RVA: 0x0040C4DF File Offset: 0x0040A6DF
		public Span<byte> GetUidBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CA2E RID: 117294 RVA: 0x0040C4EE File Offset: 0x0040A6EE
		public byte[] GetUidArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170084E2 RID: 34018
		// (get) Token: 0x0601CA2F RID: 117295 RVA: 0x0040C4FC File Offset: 0x0040A6FC
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

		// Token: 0x0601CA30 RID: 117296 RVA: 0x0040C538 File Offset: 0x0040A738
		public static Offset<IDataModifyState> CreateIDataModifyState(FlatBufferBuilder builder, StringOffset UidOffset = default(StringOffset), EDataChangeType UpdateType = EDataChangeType.None)
		{
			builder.StartTable(2);
			IDataModifyState.AddUid(builder, UidOffset);
			IDataModifyState.AddUpdateType(builder, UpdateType);
			return IDataModifyState.EndIDataModifyState(builder);
		}

		// Token: 0x0601CA31 RID: 117297 RVA: 0x0040C555 File Offset: 0x0040A755
		public static void StartIDataModifyState(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CA32 RID: 117298 RVA: 0x0040C55E File Offset: 0x0040A75E
		public static void AddUid(FlatBufferBuilder builder, StringOffset uidOffset)
		{
			builder.AddOffset(0, uidOffset.Value, 0);
		}

		// Token: 0x0601CA33 RID: 117299 RVA: 0x0040C56E File Offset: 0x0040A76E
		public static void AddUpdateType(FlatBufferBuilder builder, EDataChangeType updateType)
		{
			builder.AddByte(1, (byte)updateType, 0);
		}

		// Token: 0x0601CA34 RID: 117300 RVA: 0x0040C579 File Offset: 0x0040A779
		public static Offset<IDataModifyState> EndIDataModifyState(FlatBufferBuilder builder)
		{
			return new Offset<IDataModifyState>(builder.EndTable());
		}

		// Token: 0x0601CA35 RID: 117301 RVA: 0x0040C588 File Offset: 0x0040A788
		public IDataModifyStateT UnPack()
		{
			IDataModifyStateT dataModifyStateT = new IDataModifyStateT();
			this.UnPackTo(dataModifyStateT);
			return dataModifyStateT;
		}

		// Token: 0x0601CA36 RID: 117302 RVA: 0x0040C5A3 File Offset: 0x0040A7A3
		public void UnPackTo(IDataModifyStateT _o)
		{
			_o.Uid = this.Uid;
			_o.UpdateType = this.UpdateType;
		}

		// Token: 0x0601CA37 RID: 117303 RVA: 0x0040C5C0 File Offset: 0x0040A7C0
		public static Offset<IDataModifyState> Pack(FlatBufferBuilder builder, IDataModifyStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDataModifyState>);
			}
			StringOffset uidOffset = (_o.Uid == null) ? default(StringOffset) : builder.CreateString(_o.Uid);
			return IDataModifyState.CreateIDataModifyState(builder, uidOffset, _o.UpdateType);
		}

		// Token: 0x0400CD81 RID: 52609
		private Table __p;
	}
}
