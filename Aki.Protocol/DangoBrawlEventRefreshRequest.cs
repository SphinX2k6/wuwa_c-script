using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034A RID: 842
	[NetMessage(EMessageId.DangoBrawlEventRefreshRequest)]
	public sealed class DangoBrawlEventRefreshRequest : IMessage<DangoBrawlEventRefreshRequest>, IMessage, IEquatable<DangoBrawlEventRefreshRequest>, IDeepCloneable<DangoBrawlEventRefreshRequest>, IBufferMessage
	{
		// Token: 0x06005478 RID: 21624 RVA: 0x000CE1DC File Offset: 0x000CC3DC
		[NullableContext(1)]
		public static DangoBrawlEventRefreshRequest Create()
		{
			return new DangoBrawlEventRefreshRequest();
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06005479 RID: 21625 RVA: 0x000CE1E3 File Offset: 0x000CC3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x000CE1E6 File Offset: 0x000CC3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x000CE1ED File Offset: 0x000CC3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest()
		{
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x000CE1F5 File Offset: 0x000CC3F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest(DangoBrawlEventRefreshRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x000CE21A File Offset: 0x000CC41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest Clone()
		{
			return new DangoBrawlEventRefreshRequest(this);
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x0600547E RID: 21630 RVA: 0x000CE222 File Offset: 0x000CC422
		// (set) Token: 0x0600547F RID: 21631 RVA: 0x000CE22A File Offset: 0x000CC42A
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

		// Token: 0x06005480 RID: 21632 RVA: 0x000CE233 File Offset: 0x000CC433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventRefreshRequest);
		}

		// Token: 0x06005481 RID: 21633 RVA: 0x000CE241 File Offset: 0x000CC441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventRefreshRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005482 RID: 21634 RVA: 0x000CE270 File Offset: 0x000CC470
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

		// Token: 0x06005483 RID: 21635 RVA: 0x000CE2AF File Offset: 0x000CC4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x000CE2BC File Offset: 0x000CC4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x000CE2C5 File Offset: 0x000CC4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x000CE2F8 File Offset: 0x000CC4F8
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

		// Token: 0x06005487 RID: 21639 RVA: 0x000CE336 File Offset: 0x000CC536
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventRefreshRequest other)
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

		// Token: 0x06005488 RID: 21640 RVA: 0x000CE367 File Offset: 0x000CC567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x000CE370 File Offset: 0x000CC570
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003421 RID: 13345
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003422 RID: 13346
		public const int SlotIndexFieldNumber = 11;

		// Token: 0x04003423 RID: 13347
		private int slotIndex_;
	}
}
