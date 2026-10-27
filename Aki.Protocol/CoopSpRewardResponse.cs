using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000300 RID: 768
	[NetMessage(EMessageId.CoopSpRewardResponse)]
	public sealed class CoopSpRewardResponse : IMessage<CoopSpRewardResponse>, IMessage, IEquatable<CoopSpRewardResponse>, IDeepCloneable<CoopSpRewardResponse>, IBufferMessage
	{
		// Token: 0x06004D99 RID: 19865 RVA: 0x000BC990 File Offset: 0x000BAB90
		[NullableContext(1)]
		public static CoopSpRewardResponse Create()
		{
			return new CoopSpRewardResponse();
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x000BC997 File Offset: 0x000BAB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x000BC99A File Offset: 0x000BAB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopSpRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x000BC9A1 File Offset: 0x000BABA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse()
		{
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x000BC9A9 File Offset: 0x000BABA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse(CoopSpRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x000BC9CE File Offset: 0x000BABCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse Clone()
		{
			return new CoopSpRewardResponse(this);
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x000BC9D6 File Offset: 0x000BABD6
		// (set) Token: 0x06004DA0 RID: 19872 RVA: 0x000BC9DE File Offset: 0x000BABDE
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

		// Token: 0x06004DA1 RID: 19873 RVA: 0x000BC9E7 File Offset: 0x000BABE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopSpRewardResponse);
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x000BC9F5 File Offset: 0x000BABF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopSpRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x000BCA24 File Offset: 0x000BAC24
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

		// Token: 0x06004DA4 RID: 19876 RVA: 0x000BCA69 File Offset: 0x000BAC69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x000BCA76 File Offset: 0x000BAC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x000BCA7F File Offset: 0x000BAC7F
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

		// Token: 0x06004DA7 RID: 19879 RVA: 0x000BCAB4 File Offset: 0x000BACB4
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

		// Token: 0x06004DA8 RID: 19880 RVA: 0x000BCAF2 File Offset: 0x000BACF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopSpRewardResponse other)
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

		// Token: 0x06004DA9 RID: 19881 RVA: 0x000BCB23 File Offset: 0x000BAD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x000BCB2C File Offset: 0x000BAD2C
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

		// Token: 0x04003155 RID: 12629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003156 RID: 12630
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003157 RID: 12631
		private ErrorCode errorCode_;
	}
}
