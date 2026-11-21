using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034C RID: 844
	[NetMessage(EMessageId.DangoBrawlEventSelectRequest)]
	public sealed class DangoBrawlEventSelectRequest : IMessage<DangoBrawlEventSelectRequest>, IMessage, IEquatable<DangoBrawlEventSelectRequest>, IDeepCloneable<DangoBrawlEventSelectRequest>, IBufferMessage
	{
		// Token: 0x060054A0 RID: 21664 RVA: 0x000CE74E File Offset: 0x000CC94E
		[NullableContext(1)]
		public static DangoBrawlEventSelectRequest Create()
		{
			return new DangoBrawlEventSelectRequest();
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060054A1 RID: 21665 RVA: 0x000CE755 File Offset: 0x000CC955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060054A2 RID: 21666 RVA: 0x000CE758 File Offset: 0x000CC958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSelectRequest.Descriptor;
			}
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x000CE75F File Offset: 0x000CC95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest()
		{
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x000CE767 File Offset: 0x000CC967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest(DangoBrawlEventSelectRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x000CE78C File Offset: 0x000CC98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSelectRequest Clone()
		{
			return new DangoBrawlEventSelectRequest(this);
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060054A6 RID: 21670 RVA: 0x000CE794 File Offset: 0x000CC994
		// (set) Token: 0x060054A7 RID: 21671 RVA: 0x000CE79C File Offset: 0x000CC99C
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

		// Token: 0x060054A8 RID: 21672 RVA: 0x000CE7A5 File Offset: 0x000CC9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSelectRequest);
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x000CE7B3 File Offset: 0x000CC9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSelectRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x000CE7E4 File Offset: 0x000CC9E4
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

		// Token: 0x060054AB RID: 21675 RVA: 0x000CE823 File Offset: 0x000CCA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x000CE830 File Offset: 0x000CCA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x000CE839 File Offset: 0x000CCA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054AE RID: 21678 RVA: 0x000CE86C File Offset: 0x000CCA6C
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

		// Token: 0x060054AF RID: 21679 RVA: 0x000CE8AA File Offset: 0x000CCAAA
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

		// Token: 0x060054B0 RID: 21680 RVA: 0x000CE8DB File Offset: 0x000CCADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x000CE8E4 File Offset: 0x000CCAE4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400342B RID: 13355
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400342C RID: 13356
		public const int SlotIndexFieldNumber = 13;

		// Token: 0x0400342D RID: 13357
		private int slotIndex_;
	}
}
