using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200060A RID: 1546
	[NetMessage(EMessageId.ForgeFormulaUnlockResponse)]
	public sealed class ForgeFormulaUnlockResponse : IMessage<ForgeFormulaUnlockResponse>, IMessage, IEquatable<ForgeFormulaUnlockResponse>, IDeepCloneable<ForgeFormulaUnlockResponse>, IBufferMessage
	{
		// Token: 0x06008F2F RID: 36655 RVA: 0x0015B305 File Offset: 0x00159505
		[NullableContext(1)]
		public static ForgeFormulaUnlockResponse Create()
		{
			return new ForgeFormulaUnlockResponse();
		}

		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x06008F30 RID: 36656 RVA: 0x0015B30C File Offset: 0x0015950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x06008F31 RID: 36657 RVA: 0x0015B30F File Offset: 0x0015950F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ForgeFormulaUnlockResponse.Descriptor;
			}
		}

		// Token: 0x06008F32 RID: 36658 RVA: 0x0015B316 File Offset: 0x00159516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse()
		{
		}

		// Token: 0x06008F33 RID: 36659 RVA: 0x0015B31E File Offset: 0x0015951E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse(ForgeFormulaUnlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F34 RID: 36660 RVA: 0x0015B34F File Offset: 0x0015954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ForgeFormulaUnlockResponse Clone()
		{
			return new ForgeFormulaUnlockResponse(this);
		}

		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x06008F35 RID: 36661 RVA: 0x0015B357 File Offset: 0x00159557
		// (set) Token: 0x06008F36 RID: 36662 RVA: 0x0015B35F File Offset: 0x0015955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x06008F37 RID: 36663 RVA: 0x0015B368 File Offset: 0x00159568
		// (set) Token: 0x06008F38 RID: 36664 RVA: 0x0015B370 File Offset: 0x00159570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06008F39 RID: 36665 RVA: 0x0015B379 File Offset: 0x00159579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ForgeFormulaUnlockResponse);
		}

		// Token: 0x06008F3A RID: 36666 RVA: 0x0015B387 File Offset: 0x00159587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ForgeFormulaUnlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F3B RID: 36667 RVA: 0x0015B3C8 File Offset: 0x001595C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F3C RID: 36668 RVA: 0x0015B426 File Offset: 0x00159626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F3D RID: 36669 RVA: 0x0015B433 File Offset: 0x00159633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F3E RID: 36670 RVA: 0x0015B43C File Offset: 0x0015963C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F3F RID: 36671 RVA: 0x0015B498 File Offset: 0x00159698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F40 RID: 36672 RVA: 0x0015B4F0 File Offset: 0x001596F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ForgeFormulaUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F41 RID: 36673 RVA: 0x0015B540 File Offset: 0x00159740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F42 RID: 36674 RVA: 0x0015B54C File Offset: 0x0015974C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 32U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040045EC RID: 17900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045ED RID: 17901
		public const int CodeFieldNumber = 4;

		// Token: 0x040045EE RID: 17902
		private ErrorCode code_;

		// Token: 0x040045EF RID: 17903
		public const int IdFieldNumber = 12;

		// Token: 0x040045F0 RID: 17904
		private int id_;
	}
}
