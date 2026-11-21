using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E0 RID: 1248
	[NetMessage(EMessageId.ExploreEntityTraceResponse)]
	public sealed class ExploreEntityTraceResponse : IMessage<ExploreEntityTraceResponse>, IMessage, IEquatable<ExploreEntityTraceResponse>, IDeepCloneable<ExploreEntityTraceResponse>, IBufferMessage
	{
		// Token: 0x06007674 RID: 30324 RVA: 0x001216F7 File Offset: 0x0011F8F7
		[NullableContext(1)]
		public static ExploreEntityTraceResponse Create()
		{
			return new ExploreEntityTraceResponse();
		}

		// Token: 0x170016EF RID: 5871
		// (get) Token: 0x06007675 RID: 30325 RVA: 0x001216FE File Offset: 0x0011F8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016F0 RID: 5872
		// (get) Token: 0x06007676 RID: 30326 RVA: 0x00121701 File Offset: 0x0011F901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreEntityTraceResponse.Descriptor;
			}
		}

		// Token: 0x06007677 RID: 30327 RVA: 0x00121708 File Offset: 0x0011F908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse()
		{
		}

		// Token: 0x06007678 RID: 30328 RVA: 0x0012171B File Offset: 0x0011F91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse(ExploreEntityTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007679 RID: 30329 RVA: 0x00121751 File Offset: 0x0011F951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse Clone()
		{
			return new ExploreEntityTraceResponse(this);
		}

		// Token: 0x170016F1 RID: 5873
		// (get) Token: 0x0600767A RID: 30330 RVA: 0x00121759 File Offset: 0x0011F959
		// (set) Token: 0x0600767B RID: 30331 RVA: 0x00121761 File Offset: 0x0011F961
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

		// Token: 0x170016F2 RID: 5874
		// (get) Token: 0x0600767C RID: 30332 RVA: 0x0012176A File Offset: 0x0011F96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600767D RID: 30333 RVA: 0x00121772 File Offset: 0x0011F972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreEntityTraceResponse);
		}

		// Token: 0x0600767E RID: 30334 RVA: 0x00121780 File Offset: 0x0011F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreEntityTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600767F RID: 30335 RVA: 0x001217D0 File Offset: 0x0011F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007680 RID: 30336 RVA: 0x00121823 File Offset: 0x0011FA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007681 RID: 30337 RVA: 0x00121830 File Offset: 0x0011FA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007682 RID: 30338 RVA: 0x0012183C File Offset: 0x0011FA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, ExploreEntityTraceResponse._repeated_entityIds_codec);
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

		// Token: 0x06007683 RID: 30339 RVA: 0x0012188C File Offset: 0x0011FA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.entityIds_.CalculateSize(ExploreEntityTraceResponse._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007684 RID: 30340 RVA: 0x001218E0 File Offset: 0x0011FAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreEntityTraceResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007685 RID: 30341 RVA: 0x0012192D File Offset: 0x0011FB2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007686 RID: 30342 RVA: 0x00121938 File Offset: 0x0011FB38
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
				if (num != 80U && num != 82U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.entityIds_.AddEntriesFrom(ref input, ExploreEntityTraceResponse._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04003E3B RID: 15931
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E3C RID: 15932
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003E3D RID: 15933
		private ErrorCode errorCode_;

		// Token: 0x04003E3E RID: 15934
		public const int EntityIdsFieldNumber = 10;

		// Token: 0x04003E3F RID: 15935
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04003E40 RID: 15936
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
