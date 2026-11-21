using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014FD RID: 5373
	[NetMessage(EMessageId.UnlockInstEntranceRequest)]
	public sealed class UnlockInstEntranceRequest : IMessage<UnlockInstEntranceRequest>, IMessage, IEquatable<UnlockInstEntranceRequest>, IDeepCloneable<UnlockInstEntranceRequest>, IBufferMessage
	{
		// Token: 0x0601C7B6 RID: 116662 RVA: 0x0042155F File Offset: 0x0041F75F
		[NullableContext(1)]
		public static UnlockInstEntranceRequest Create()
		{
			return new UnlockInstEntranceRequest();
		}

		// Token: 0x17006062 RID: 24674
		// (get) Token: 0x0601C7B7 RID: 116663 RVA: 0x00421566 File Offset: 0x0041F766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006063 RID: 24675
		// (get) Token: 0x0601C7B8 RID: 116664 RVA: 0x00421569 File Offset: 0x0041F769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockInstEntranceRequest.Descriptor;
			}
		}

		// Token: 0x0601C7B9 RID: 116665 RVA: 0x00421570 File Offset: 0x0041F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest()
		{
		}

		// Token: 0x0601C7BA RID: 116666 RVA: 0x00421578 File Offset: 0x0041F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest(UnlockInstEntranceRequest other) : this()
		{
			this.entranceId_ = other.entranceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7BB RID: 116667 RVA: 0x0042159D File Offset: 0x0041F79D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockInstEntranceRequest Clone()
		{
			return new UnlockInstEntranceRequest(this);
		}

		// Token: 0x17006064 RID: 24676
		// (get) Token: 0x0601C7BC RID: 116668 RVA: 0x004215A5 File Offset: 0x0041F7A5
		// (set) Token: 0x0601C7BD RID: 116669 RVA: 0x004215AD File Offset: 0x0041F7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x0601C7BE RID: 116670 RVA: 0x004215B6 File Offset: 0x0041F7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockInstEntranceRequest);
		}

		// Token: 0x0601C7BF RID: 116671 RVA: 0x004215C4 File Offset: 0x0041F7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockInstEntranceRequest other)
		{
			return other != null && (other == this || (this.EntranceId == other.EntranceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7C0 RID: 116672 RVA: 0x004215F4 File Offset: 0x0041F7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7C1 RID: 116673 RVA: 0x00421633 File Offset: 0x0041F833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7C2 RID: 116674 RVA: 0x00421640 File Offset: 0x0041F840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7C3 RID: 116675 RVA: 0x00421649 File Offset: 0x0041F849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7C4 RID: 116676 RVA: 0x0042167C File Offset: 0x0041F87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7C5 RID: 116677 RVA: 0x004216BA File Offset: 0x0041F8BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockInstEntranceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7C6 RID: 116678 RVA: 0x004216EB File Offset: 0x0041F8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7C7 RID: 116679 RVA: 0x004216F4 File Offset: 0x0041F8F4
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntranceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A45A RID: 42074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A45B RID: 42075
		public const int EntranceIdFieldNumber = 5;

		// Token: 0x0400A45C RID: 42076
		private int entranceId_;
	}
}
