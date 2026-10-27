using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000344 RID: 836
	[NetMessage(EMessageId.DangoBrawlEventSelectRequest)]
	public sealed class DangoBrawlEventSelectRequest : IMessage<DangoBrawlEventSelectRequest>, IMessage, IEquatable<DangoBrawlEventSelectRequest>, IDeepCloneable<DangoBrawlEventSelectRequest>, IBufferMessage
	{
		// Token: 0x060053B3 RID: 21427 RVA: 0x000CC0C5 File Offset: 0x000CA2C5
		[NullableContext(1)]
		public static DangoBrawlEventSelectRequest Create()
		{
			return new DangoBrawlEventSelectRequest();
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060053B4 RID: 21428 RVA: 0x000CC0CC File Offset: 0x000CA2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060053B5 RID: 21429 RVA: 0x000CC0CF File Offset: 0x000CA2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSelectRequest.Descriptor;
			}
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x000CC0D6 File Offset: 0x000CA2D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest()
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x000CC0DE File Offset: 0x000CA2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest(DangoBrawlEventSelectRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x000CC103 File Offset: 0x000CA303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest Clone()
		{
			return new DangoBrawlEventSelectRequest(this);
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x000CC10B File Offset: 0x000CA30B
		// (set) Token: 0x060053BA RID: 21434 RVA: 0x000CC113 File Offset: 0x000CA313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x000CC11C File Offset: 0x000CA31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSelectRequest);
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x000CC12A File Offset: 0x000CA32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSelectRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x000CC158 File Offset: 0x000CA358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x000CC197 File Offset: 0x000CA397
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x000CC1A4 File Offset: 0x000CA3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x000CC1AD File Offset: 0x000CA3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x000CC1E0 File Offset: 0x000CA3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x000CC21E File Offset: 0x000CA41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x000CC24F File Offset: 0x000CA44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x000CC258 File Offset: 0x000CA458
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400338F RID: 13199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003390 RID: 13200
		public const int SlotIndexFieldNumber = 6;

		// Token: 0x04003391 RID: 13201
		private int slotIndex_;
	}
}
