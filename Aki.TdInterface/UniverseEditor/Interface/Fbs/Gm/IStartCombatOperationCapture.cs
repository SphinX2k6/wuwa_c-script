using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046A8 RID: 18088
	public struct IStartCombatOperationCapture : IFlatbufferObject
	{
		// Token: 0x1700807B RID: 32891
		// (get) Token: 0x0601B7AF RID: 112559 RVA: 0x003E6DBF File Offset: 0x003E4FBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B7B0 RID: 112560 RVA: 0x003E6DCC File Offset: 0x003E4FCC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B7B1 RID: 112561 RVA: 0x003E6DD4 File Offset: 0x003E4FD4
		public static IStartCombatOperationCapture GetRootAsIStartCombatOperationCapture(ByteBuffer _bb)
		{
			return IStartCombatOperationCapture.GetRootAsIStartCombatOperationCapture(_bb, default(IStartCombatOperationCapture));
		}

		// Token: 0x0601B7B2 RID: 112562 RVA: 0x003E6DF0 File Offset: 0x003E4FF0
		public static IStartCombatOperationCapture GetRootAsIStartCombatOperationCapture(ByteBuffer _bb, IStartCombatOperationCapture obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B7B3 RID: 112563 RVA: 0x003E6E0D File Offset: 0x003E500D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B7B4 RID: 112564 RVA: 0x003E6E1C File Offset: 0x003E501C
		public IStartCombatOperationCapture __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700807C RID: 32892
		// (get) Token: 0x0601B7B5 RID: 112565 RVA: 0x003E6E2C File Offset: 0x003E502C
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

		// Token: 0x1700807D RID: 32893
		// (get) Token: 0x0601B7B6 RID: 112566 RVA: 0x003E6E68 File Offset: 0x003E5068
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

		// Token: 0x0601B7B7 RID: 112567 RVA: 0x003E6E9F File Offset: 0x003E509F
		public Span<byte> GetFileIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601B7B8 RID: 112568 RVA: 0x003E6EAE File Offset: 0x003E50AE
		public byte[] GetFileIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601B7B9 RID: 112569 RVA: 0x003E6EBC File Offset: 0x003E50BC
		public static Offset<IStartCombatOperationCapture> CreateIStartCombatOperationCapture(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode, StringOffset FileIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IStartCombatOperationCapture.AddFileId(builder, FileIdOffset);
			IStartCombatOperationCapture.AddType(builder, Type);
			return IStartCombatOperationCapture.EndIStartCombatOperationCapture(builder);
		}

		// Token: 0x0601B7BA RID: 112570 RVA: 0x003E6ED9 File Offset: 0x003E50D9
		public static void StartIStartCombatOperationCapture(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601B7BB RID: 112571 RVA: 0x003E6EE2 File Offset: 0x003E50E2
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B7BC RID: 112572 RVA: 0x003E6EED File Offset: 0x003E50ED
		public static void AddFileId(FlatBufferBuilder builder, StringOffset fileIdOffset)
		{
			builder.AddOffset(1, fileIdOffset.Value, 0);
		}

		// Token: 0x0601B7BD RID: 112573 RVA: 0x003E6EFD File Offset: 0x003E50FD
		public static Offset<IStartCombatOperationCapture> EndIStartCombatOperationCapture(FlatBufferBuilder builder)
		{
			return new Offset<IStartCombatOperationCapture>(builder.EndTable());
		}

		// Token: 0x0601B7BE RID: 112574 RVA: 0x003E6F0C File Offset: 0x003E510C
		public IStartCombatOperationCaptureT UnPack()
		{
			IStartCombatOperationCaptureT startCombatOperationCaptureT = new IStartCombatOperationCaptureT();
			this.UnPackTo(startCombatOperationCaptureT);
			return startCombatOperationCaptureT;
		}

		// Token: 0x0601B7BF RID: 112575 RVA: 0x003E6F27 File Offset: 0x003E5127
		public void UnPackTo(IStartCombatOperationCaptureT _o)
		{
			_o.Type = this.Type;
			_o.FileId = this.FileId;
		}

		// Token: 0x0601B7C0 RID: 112576 RVA: 0x003E6F44 File Offset: 0x003E5144
		public static Offset<IStartCombatOperationCapture> Pack(FlatBufferBuilder builder, IStartCombatOperationCaptureT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartCombatOperationCapture>);
			}
			StringOffset fileIdOffset = (_o.FileId == null) ? default(StringOffset) : builder.CreateString(_o.FileId);
			return IStartCombatOperationCapture.CreateIStartCombatOperationCapture(builder, _o.Type, fileIdOffset);
		}

		// Token: 0x0400C873 RID: 51315
		private Table __p;
	}
}
