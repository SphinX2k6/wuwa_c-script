using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001511 RID: 5393
	[NetMessage(EMessageId.WellStreamingFinisRequest)]
	public sealed class WellStreamingFinisRequest : IMessage<WellStreamingFinisRequest>, IMessage, IEquatable<WellStreamingFinisRequest>, IDeepCloneable<WellStreamingFinisRequest>, IBufferMessage
	{
		// Token: 0x0601C809 RID: 116745 RVA: 0x0041DD4A File Offset: 0x0041BF4A
		[NullableContext(1)]
		public static WellStreamingFinisRequest Create()
		{
			return new WellStreamingFinisRequest();
		}

		// Token: 0x17006015 RID: 24597
		// (get) Token: 0x0601C80A RID: 116746 RVA: 0x0041DD51 File Offset: 0x0041BF51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006016 RID: 24598
		// (get) Token: 0x0601C80B RID: 116747 RVA: 0x0041DD54 File Offset: 0x0041BF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WellStreamingFinisRequest.Descriptor;
			}
		}

		// Token: 0x0601C80C RID: 116748 RVA: 0x0041DD5B File Offset: 0x0041BF5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest()
		{
		}

		// Token: 0x0601C80D RID: 116749 RVA: 0x0041DD63 File Offset: 0x0041BF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest(WellStreamingFinisRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C80E RID: 116750 RVA: 0x0041DD88 File Offset: 0x0041BF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WellStreamingFinisRequest Clone()
		{
			return new WellStreamingFinisRequest(this);
		}

		// Token: 0x17006017 RID: 24599
		// (get) Token: 0x0601C80F RID: 116751 RVA: 0x0041DD90 File Offset: 0x0041BF90
		// (set) Token: 0x0601C810 RID: 116752 RVA: 0x0041DD98 File Offset: 0x0041BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x0601C811 RID: 116753 RVA: 0x0041DDA1 File Offset: 0x0041BFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WellStreamingFinisRequest);
		}

		// Token: 0x0601C812 RID: 116754 RVA: 0x0041DDAF File Offset: 0x0041BFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WellStreamingFinisRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C813 RID: 116755 RVA: 0x0041DDE0 File Offset: 0x0041BFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C814 RID: 116756 RVA: 0x0041DE1F File Offset: 0x0041C01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C815 RID: 116757 RVA: 0x0041DE2C File Offset: 0x0041C02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C816 RID: 116758 RVA: 0x0041DE35 File Offset: 0x0041C035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C817 RID: 116759 RVA: 0x0041DE68 File Offset: 0x0041C068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C818 RID: 116760 RVA: 0x0041DEA6 File Offset: 0x0041C0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WellStreamingFinisRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C819 RID: 116761 RVA: 0x0041DED7 File Offset: 0x0041C0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C81A RID: 116762 RVA: 0x0041DEE0 File Offset: 0x0041C0E0
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
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A319 RID: 41753
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A31A RID: 41754
		public const int EntityIncIdFieldNumber = 6;

		// Token: 0x0400A31B RID: 41755
		private long entityIncId_;
	}
}
