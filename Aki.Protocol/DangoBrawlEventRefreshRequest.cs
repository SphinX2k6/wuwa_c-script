using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000342 RID: 834
	[NetMessage(EMessageId.DangoBrawlEventRefreshRequest)]
	public sealed class DangoBrawlEventRefreshRequest : IMessage<DangoBrawlEventRefreshRequest>, IMessage, IEquatable<DangoBrawlEventRefreshRequest>, IDeepCloneable<DangoBrawlEventRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600538B RID: 21387 RVA: 0x000CBB58 File Offset: 0x000C9D58
		[NullableContext(1)]
		public static DangoBrawlEventRefreshRequest Create()
		{
			return new DangoBrawlEventRefreshRequest();
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x000CBB5F File Offset: 0x000C9D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x0600538D RID: 21389 RVA: 0x000CBB62 File Offset: 0x000C9D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600538E RID: 21390 RVA: 0x000CBB69 File Offset: 0x000C9D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest()
		{
		}

		// Token: 0x0600538F RID: 21391 RVA: 0x000CBB71 File Offset: 0x000C9D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest(DangoBrawlEventRefreshRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005390 RID: 21392 RVA: 0x000CBB96 File Offset: 0x000C9D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventRefreshRequest Clone()
		{
			return new DangoBrawlEventRefreshRequest(this);
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06005391 RID: 21393 RVA: 0x000CBB9E File Offset: 0x000C9D9E
		// (set) Token: 0x06005392 RID: 21394 RVA: 0x000CBBA6 File Offset: 0x000C9DA6
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

		// Token: 0x06005393 RID: 21395 RVA: 0x000CBBAF File Offset: 0x000C9DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventRefreshRequest);
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x000CBBBD File Offset: 0x000C9DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventRefreshRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x000CBBEC File Offset: 0x000C9DEC
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

		// Token: 0x06005396 RID: 21398 RVA: 0x000CBC2B File Offset: 0x000C9E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x000CBC38 File Offset: 0x000C9E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x000CBC41 File Offset: 0x000C9E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x000CBC74 File Offset: 0x000C9E74
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

		// Token: 0x0600539A RID: 21402 RVA: 0x000CBCB2 File Offset: 0x000C9EB2
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

		// Token: 0x0600539B RID: 21403 RVA: 0x000CBCE3 File Offset: 0x000C9EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x000CBCEC File Offset: 0x000C9EEC
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003385 RID: 13189
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003386 RID: 13190
		public const int SlotIndexFieldNumber = 3;

		// Token: 0x04003387 RID: 13191
		private int slotIndex_;
	}
}
