using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B10 RID: 19216
	public struct IStartCombatOperationCapture : IFlatbufferObject
	{
		// Token: 0x170086BC RID: 34492
		// (get) Token: 0x0601CF84 RID: 118660 RVA: 0x0041305B File Offset: 0x0041125B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CF85 RID: 118661 RVA: 0x00413068 File Offset: 0x00411268
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CF86 RID: 118662 RVA: 0x00413070 File Offset: 0x00411270
		public static IStartCombatOperationCapture GetRootAsIStartCombatOperationCapture(ByteBuffer _bb)
		{
			return IStartCombatOperationCapture.GetRootAsIStartCombatOperationCapture(_bb, default(IStartCombatOperationCapture));
		}

		// Token: 0x0601CF87 RID: 118663 RVA: 0x0041308C File Offset: 0x0041128C
		public static IStartCombatOperationCapture GetRootAsIStartCombatOperationCapture(ByteBuffer _bb, IStartCombatOperationCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CF88 RID: 118664 RVA: 0x004130A9 File Offset: 0x004112A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CF89 RID: 118665 RVA: 0x004130B8 File Offset: 0x004112B8
		public IStartCombatOperationCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086BD RID: 34493
		// (get) Token: 0x0601CF8A RID: 118666 RVA: 0x004130C8 File Offset: 0x004112C8
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170086BE RID: 34494
		// (get) Token: 0x0601CF8B RID: 118667 RVA: 0x00413104 File Offset: 0x00411304
		public string FileId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CF8C RID: 118668 RVA: 0x0041313B File Offset: 0x0041133B
		public Span<byte> GetFileIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CF8D RID: 118669 RVA: 0x0041314A File Offset: 0x0041134A
		public byte[] GetFileIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x00413158 File Offset: 0x00411358
		public static Offset<IStartCombatOperationCapture> CreateIStartCombatOperationCapture(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset FileIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStartCombatOperationCapture.AddFileId(builder, FileIdOffset);
			IStartCombatOperationCapture.AddType(builder, Type);
			return IStartCombatOperationCapture.EndIStartCombatOperationCapture(builder);
		}

		// Token: 0x0601CF8F RID: 118671 RVA: 0x00413175 File Offset: 0x00411375
		public static void StartIStartCombatOperationCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601CF90 RID: 118672 RVA: 0x0041317E File Offset: 0x0041137E
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CF91 RID: 118673 RVA: 0x00413189 File Offset: 0x00411389
		public static void AddFileId(FlatBufferBuilder builder, StringOffset fileIdOffset)
		{
			builder.AddOffset(1, fileIdOffset.Value, 0);
		}

		// Token: 0x0601CF92 RID: 118674 RVA: 0x00413199 File Offset: 0x00411399
		public static Offset<IStartCombatOperationCapture> EndIStartCombatOperationCapture(FlatBufferBuilder builder)
		{
			return new Offset<IStartCombatOperationCapture>(builder.EndTable());
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x004131A8 File Offset: 0x004113A8
		public IStartCombatOperationCaptureT UnPack()
		{
			IStartCombatOperationCaptureT startCombatOperationCaptureT = new IStartCombatOperationCaptureT();
			this.UnPackTo(startCombatOperationCaptureT);
			return startCombatOperationCaptureT;
		}

		// Token: 0x0601CF94 RID: 118676 RVA: 0x004131C3 File Offset: 0x004113C3
		public void UnPackTo(IStartCombatOperationCaptureT _o)
		{
			_o.Type = this.Type;
			_o.FileId = this.FileId;
		}

		// Token: 0x0601CF95 RID: 118677 RVA: 0x004131E0 File Offset: 0x004113E0
		public static Offset<IStartCombatOperationCapture> Pack(FlatBufferBuilder builder, IStartCombatOperationCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartCombatOperationCapture>);
			}
			StringOffset fileIdOffset = (_o.FileId == null) ? default(StringOffset) : builder.CreateString(_o.FileId);
			return IStartCombatOperationCapture.CreateIStartCombatOperationCapture(builder, _o.Type, fileIdOffset);
		}

		// Token: 0x0400D2A2 RID: 53922
		private Table __p;
	}
}
