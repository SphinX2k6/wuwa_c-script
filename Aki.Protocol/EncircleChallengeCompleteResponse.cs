using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000439 RID: 1081
	[NetMessage(EMessageId.EncircleChallengeCompleteResponse)]
	public sealed class EncircleChallengeCompleteResponse : IMessage<EncircleChallengeCompleteResponse>, IMessage, IEquatable<EncircleChallengeCompleteResponse>, IDeepCloneable<EncircleChallengeCompleteResponse>, IBufferMessage
	{
		// Token: 0x06006795 RID: 26517 RVA: 0x000F8C93 File Offset: 0x000F6E93
		[NullableContext(1)]
		public static EncircleChallengeCompleteResponse Create()
		{
			return new EncircleChallengeCompleteResponse();
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06006796 RID: 26518 RVA: 0x000F8C9A File Offset: 0x000F6E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06006797 RID: 26519 RVA: 0x000F8C9D File Offset: 0x000F6E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeCompleteResponse.Descriptor;
			}
		}

		// Token: 0x06006798 RID: 26520 RVA: 0x000F8CA4 File Offset: 0x000F6EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse()
		{
		}

		// Token: 0x06006799 RID: 26521 RVA: 0x000F8CAC File Offset: 0x000F6EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse(EncircleChallengeCompleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600679A RID: 26522 RVA: 0x000F8CD1 File Offset: 0x000F6ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse Clone()
		{
			return new EncircleChallengeCompleteResponse(this);
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600679B RID: 26523 RVA: 0x000F8CD9 File Offset: 0x000F6ED9
		// (set) Token: 0x0600679C RID: 26524 RVA: 0x000F8CE1 File Offset: 0x000F6EE1
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

		// Token: 0x0600679D RID: 26525 RVA: 0x000F8CEA File Offset: 0x000F6EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeCompleteResponse);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x000F8CF8 File Offset: 0x000F6EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600679F RID: 26527 RVA: 0x000F8D28 File Offset: 0x000F6F28
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

		// Token: 0x060067A0 RID: 26528 RVA: 0x000F8D6D File Offset: 0x000F6F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067A1 RID: 26529 RVA: 0x000F8D7A File Offset: 0x000F6F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067A2 RID: 26530 RVA: 0x000F8D83 File Offset: 0x000F6F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067A3 RID: 26531 RVA: 0x000F8DB8 File Offset: 0x000F6FB8
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

		// Token: 0x060067A4 RID: 26532 RVA: 0x000F8DF6 File Offset: 0x000F6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EncircleChallengeCompleteResponse other)
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

		// Token: 0x060067A5 RID: 26533 RVA: 0x000F8E27 File Offset: 0x000F7027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067A6 RID: 26534 RVA: 0x000F8E30 File Offset: 0x000F7030
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003974 RID: 14708
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003975 RID: 14709
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003976 RID: 14710
		private ErrorCode errorCode_;
	}
}
