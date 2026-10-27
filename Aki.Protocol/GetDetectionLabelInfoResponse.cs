using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006C4 RID: 1732
	[NetMessage(EMessageId.GetDetectionLabelInfoResponse)]
	public sealed class GetDetectionLabelInfoResponse : IMessage<GetDetectionLabelInfoResponse>, IMessage, IEquatable<GetDetectionLabelInfoResponse>, IDeepCloneable<GetDetectionLabelInfoResponse>, IBufferMessage
	{
		// Token: 0x06009E7B RID: 40571 RVA: 0x0018094A File Offset: 0x0017EB4A
		[NullableContext(1)]
		public static GetDetectionLabelInfoResponse Create()
		{
			return new GetDetectionLabelInfoResponse();
		}

		// Token: 0x17001FD8 RID: 8152
		// (get) Token: 0x06009E7C RID: 40572 RVA: 0x00180951 File Offset: 0x0017EB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FD9 RID: 8153
		// (get) Token: 0x06009E7D RID: 40573 RVA: 0x00180954 File Offset: 0x0017EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionLabelInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x0018095B File Offset: 0x0017EB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse()
		{
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x00180963 File Offset: 0x0017EB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse(GetDetectionLabelInfoResponse other) : this()
		{
			this.unlockLabelInfo_ = ((other.unlockLabelInfo_ != null) ? other.unlockLabelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x00180998 File Offset: 0x0017EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse Clone()
		{
			return new GetDetectionLabelInfoResponse(this);
		}

		// Token: 0x17001FDA RID: 8154
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x001809A0 File Offset: 0x0017EBA0
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x001809A8 File Offset: 0x0017EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo UnlockLabelInfo
		{
			get
			{
				return this.unlockLabelInfo_;
			}
			set
			{
				this.unlockLabelInfo_ = value;
			}
		}

		// Token: 0x06009E83 RID: 40579 RVA: 0x001809B1 File Offset: 0x0017EBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionLabelInfoResponse);
		}

		// Token: 0x06009E84 RID: 40580 RVA: 0x001809BF File Offset: 0x0017EBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionLabelInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockLabelInfo, other.UnlockLabelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E85 RID: 40581 RVA: 0x001809F4 File Offset: 0x0017EBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.unlockLabelInfo_ != null)
			{
				num ^= this.UnlockLabelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E86 RID: 40582 RVA: 0x00180A30 File Offset: 0x0017EC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x00180A3D File Offset: 0x0017EC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x00180A46 File Offset: 0x0017EC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockLabelInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UnlockLabelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x00180A78 File Offset: 0x0017EC78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.unlockLabelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockLabelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x00180AB8 File Offset: 0x0017ECB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionLabelInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.unlockLabelInfo_ != null)
			{
				if (this.unlockLabelInfo_ == null)
				{
					this.UnlockLabelInfo = new UnlockDetectionLabelInfo();
				}
				this.UnlockLabelInfo.MergeFrom(other.UnlockLabelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x00180B0C File Offset: 0x0017ED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x00180B18 File Offset: 0x0017ED18
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.unlockLabelInfo_ == null)
					{
						this.UnlockLabelInfo = new UnlockDetectionLabelInfo();
					}
					input.ReadMessage(this.UnlockLabelInfo);
				}
			}
		}

		// Token: 0x04004A32 RID: 18994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A33 RID: 18995
		public const int UnlockLabelInfoFieldNumber = 14;

		// Token: 0x04004A34 RID: 18996
		private UnlockDetectionLabelInfo unlockLabelInfo_;
	}
}
