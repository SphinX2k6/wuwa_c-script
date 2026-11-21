using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001315 RID: 4885
	[NetMessage(EMessageId.SubmitPhotoNodeResponse)]
	public sealed class SubmitPhotoNodeResponse : IMessage<SubmitPhotoNodeResponse>, IMessage, IEquatable<SubmitPhotoNodeResponse>, IDeepCloneable<SubmitPhotoNodeResponse>, IBufferMessage
	{
		// Token: 0x0601A0C2 RID: 106690 RVA: 0x003CBF24 File Offset: 0x003CA124
		[NullableContext(1)]
		public static SubmitPhotoNodeResponse Create()
		{
			return new SubmitPhotoNodeResponse();
		}

		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x0601A0C3 RID: 106691 RVA: 0x003CBF2B File Offset: 0x003CA12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x0601A0C4 RID: 106692 RVA: 0x003CBF2E File Offset: 0x003CA12E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubmitPhotoNodeResponse.Descriptor;
			}
		}

		// Token: 0x0601A0C5 RID: 106693 RVA: 0x003CBF35 File Offset: 0x003CA135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse()
		{
		}

		// Token: 0x0601A0C6 RID: 106694 RVA: 0x003CBF3D File Offset: 0x003CA13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse(SubmitPhotoNodeResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A0C7 RID: 106695 RVA: 0x003CBF62 File Offset: 0x003CA162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubmitPhotoNodeResponse Clone()
		{
			return new SubmitPhotoNodeResponse(this);
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0601A0C8 RID: 106696 RVA: 0x003CBF6A File Offset: 0x003CA16A
		// (set) Token: 0x0601A0C9 RID: 106697 RVA: 0x003CBF72 File Offset: 0x003CA172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x0601A0CA RID: 106698 RVA: 0x003CBF7B File Offset: 0x003CA17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubmitPhotoNodeResponse);
		}

		// Token: 0x0601A0CB RID: 106699 RVA: 0x003CBF89 File Offset: 0x003CA189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SubmitPhotoNodeResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A0CC RID: 106700 RVA: 0x003CBFB8 File Offset: 0x003CA1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A0CD RID: 106701 RVA: 0x003CBFFD File Offset: 0x003CA1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A0CE RID: 106702 RVA: 0x003CC00A File Offset: 0x003CA20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A0CF RID: 106703 RVA: 0x003CC013 File Offset: 0x003CA213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A0D0 RID: 106704 RVA: 0x003CC048 File Offset: 0x003CA248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A0D1 RID: 106705 RVA: 0x003CC086 File Offset: 0x003CA286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SubmitPhotoNodeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A0D2 RID: 106706 RVA: 0x003CC0B7 File Offset: 0x003CA2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A0D3 RID: 106707 RVA: 0x003CC0C0 File Offset: 0x003CA2C0
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400995F RID: 39263
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009960 RID: 39264
		public const int ErrorIdFieldNumber = 14;

		// Token: 0x04009961 RID: 39265
		private ErrorCode errorId_;
	}
}
