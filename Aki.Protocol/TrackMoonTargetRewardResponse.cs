using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001461 RID: 5217
	[NetMessage(EMessageId.TrackMoonTargetRewardResponse)]
	public sealed class TrackMoonTargetRewardResponse : IMessage<TrackMoonTargetRewardResponse>, IMessage, IEquatable<TrackMoonTargetRewardResponse>, IDeepCloneable<TrackMoonTargetRewardResponse>, IBufferMessage
	{
		// Token: 0x0601BB2A RID: 113450 RVA: 0x00405989 File Offset: 0x00403B89
		[NullableContext(1)]
		public static TrackMoonTargetRewardResponse Create()
		{
			return new TrackMoonTargetRewardResponse();
		}

		// Token: 0x17005DB5 RID: 23989
		// (get) Token: 0x0601BB2B RID: 113451 RVA: 0x00405990 File Offset: 0x00403B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DB6 RID: 23990
		// (get) Token: 0x0601BB2C RID: 113452 RVA: 0x00405993 File Offset: 0x00403B93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601BB2D RID: 113453 RVA: 0x0040599A File Offset: 0x00403B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse()
		{
		}

		// Token: 0x0601BB2E RID: 113454 RVA: 0x004059A2 File Offset: 0x00403BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse(TrackMoonTargetRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BB2F RID: 113455 RVA: 0x004059C7 File Offset: 0x00403BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse Clone()
		{
			return new TrackMoonTargetRewardResponse(this);
		}

		// Token: 0x17005DB7 RID: 23991
		// (get) Token: 0x0601BB30 RID: 113456 RVA: 0x004059CF File Offset: 0x00403BCF
		// (set) Token: 0x0601BB31 RID: 113457 RVA: 0x004059D7 File Offset: 0x00403BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601BB32 RID: 113458 RVA: 0x004059E0 File Offset: 0x00403BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetRewardResponse);
		}

		// Token: 0x0601BB33 RID: 113459 RVA: 0x004059EE File Offset: 0x00403BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BB34 RID: 113460 RVA: 0x00405A1C File Offset: 0x00403C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BB35 RID: 113461 RVA: 0x00405A61 File Offset: 0x00403C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BB36 RID: 113462 RVA: 0x00405A6E File Offset: 0x00403C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BB37 RID: 113463 RVA: 0x00405A77 File Offset: 0x00403C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BB38 RID: 113464 RVA: 0x00405AAC File Offset: 0x00403CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BB39 RID: 113465 RVA: 0x00405AEA File Offset: 0x00403CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTargetRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BB3A RID: 113466 RVA: 0x00405B1B File Offset: 0x00403D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BB3B RID: 113467 RVA: 0x00405B24 File Offset: 0x00403D24
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A0C8 RID: 41160
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0C9 RID: 41161
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400A0CA RID: 41162
		private ErrorCode errorCode_;
	}
}
