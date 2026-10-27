using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000651 RID: 1617
	[NetMessage(EMessageId.FriendApplySendResponse)]
	public sealed class FriendApplySendResponse : IMessage<FriendApplySendResponse>, IMessage, IEquatable<FriendApplySendResponse>, IDeepCloneable<FriendApplySendResponse>, IBufferMessage
	{
		// Token: 0x060094AC RID: 38060 RVA: 0x001673A0 File Offset: 0x001655A0
		[NullableContext(1)]
		public static FriendApplySendResponse Create()
		{
			return new FriendApplySendResponse();
		}

		// Token: 0x17001D98 RID: 7576
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x001673A7 File Offset: 0x001655A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x060094AE RID: 38062 RVA: 0x001673AA File Offset: 0x001655AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplySendResponse.Descriptor;
			}
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x001673B1 File Offset: 0x001655B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse()
		{
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x001673B9 File Offset: 0x001655B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse(FriendApplySendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x001673DE File Offset: 0x001655DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplySendResponse Clone()
		{
			return new FriendApplySendResponse(this);
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x001673E6 File Offset: 0x001655E6
		// (set) Token: 0x060094B3 RID: 38067 RVA: 0x001673EE File Offset: 0x001655EE
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

		// Token: 0x060094B4 RID: 38068 RVA: 0x001673F7 File Offset: 0x001655F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplySendResponse);
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00167405 File Offset: 0x00165605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplySendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00167434 File Offset: 0x00165634
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

		// Token: 0x060094B7 RID: 38071 RVA: 0x00167479 File Offset: 0x00165679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x00167486 File Offset: 0x00165686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x0016748F File Offset: 0x0016568F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x001674C4 File Offset: 0x001656C4
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

		// Token: 0x060094BB RID: 38075 RVA: 0x00167502 File Offset: 0x00165702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplySendResponse other)
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

		// Token: 0x060094BC RID: 38076 RVA: 0x00167533 File Offset: 0x00165733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x0016753C File Offset: 0x0016573C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004736 RID: 18230
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004737 RID: 18231
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04004738 RID: 18232
		private ErrorCode errorCode_;
	}
}
