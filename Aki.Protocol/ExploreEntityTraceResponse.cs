using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F6 RID: 1270
	[NetMessage(EMessageId.ExploreEntityTraceResponse)]
	public sealed class ExploreEntityTraceResponse : IMessage<ExploreEntityTraceResponse>, IMessage, IEquatable<ExploreEntityTraceResponse>, IDeepCloneable<ExploreEntityTraceResponse>, IBufferMessage
	{
		// Token: 0x060077F0 RID: 30704 RVA: 0x00124588 File Offset: 0x00122788
		[NullableContext(1)]
		public static ExploreEntityTraceResponse Create()
		{
			return new ExploreEntityTraceResponse();
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x060077F1 RID: 30705 RVA: 0x0012458F File Offset: 0x0012278F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x060077F2 RID: 30706 RVA: 0x00124592 File Offset: 0x00122792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreEntityTraceResponse.Descriptor;
			}
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00124599 File Offset: 0x00122799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse()
		{
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x001245AC File Offset: 0x001227AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse(ExploreEntityTraceResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x001245E2 File Offset: 0x001227E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreEntityTraceResponse Clone()
		{
			return new ExploreEntityTraceResponse(this);
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x060077F6 RID: 30710 RVA: 0x001245EA File Offset: 0x001227EA
		// (set) Token: 0x060077F7 RID: 30711 RVA: 0x001245F2 File Offset: 0x001227F2
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

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x001245FB File Offset: 0x001227FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00124603 File Offset: 0x00122803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreEntityTraceResponse);
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00124614 File Offset: 0x00122814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreEntityTraceResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00124664 File Offset: 0x00122864
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

		// Token: 0x060077FC RID: 30716 RVA: 0x001246B7 File Offset: 0x001228B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x001246C4 File Offset: 0x001228C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x001246D0 File Offset: 0x001228D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, ExploreEntityTraceResponse._repeated_entityIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00124720 File Offset: 0x00122920
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

		// Token: 0x06007800 RID: 30720 RVA: 0x00124774 File Offset: 0x00122974
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

		// Token: 0x06007801 RID: 30721 RVA: 0x001247C1 File Offset: 0x001229C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x001247CC File Offset: 0x001229CC
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
				if (num != 16U && num != 18U)
				{
					if (num != 88U)
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

		// Token: 0x04003E4A RID: 15946
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E4B RID: 15947
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003E4C RID: 15948
		private ErrorCode errorCode_;

		// Token: 0x04003E4D RID: 15949
		public const int EntityIdsFieldNumber = 2;

		// Token: 0x04003E4E RID: 15950
		private static readonly FieldCodec<int> _repeated_entityIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003E4F RID: 15951
		private readonly RepeatedField<int> entityIds_ = new RepeatedField<int>();
	}
}
