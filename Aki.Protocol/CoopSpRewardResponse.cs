using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000307 RID: 775
	[NetMessage(EMessageId.CoopSpRewardResponse)]
	public sealed class CoopSpRewardResponse : IMessage<CoopSpRewardResponse>, IMessage, IEquatable<CoopSpRewardResponse>, IDeepCloneable<CoopSpRewardResponse>, IBufferMessage
	{
		// Token: 0x06004E72 RID: 20082 RVA: 0x000BED7D File Offset: 0x000BCF7D
		[NullableContext(1)]
		public static CoopSpRewardResponse Create()
		{
			return new CoopSpRewardResponse();
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06004E73 RID: 20083 RVA: 0x000BED84 File Offset: 0x000BCF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06004E74 RID: 20084 RVA: 0x000BED87 File Offset: 0x000BCF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopSpRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x000BED8E File Offset: 0x000BCF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse()
		{
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x000BED96 File Offset: 0x000BCF96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse(CoopSpRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x000BEDBB File Offset: 0x000BCFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopSpRewardResponse Clone()
		{
			return new CoopSpRewardResponse(this);
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x000BEDC3 File Offset: 0x000BCFC3
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x000BEDCB File Offset: 0x000BCFCB
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

		// Token: 0x06004E7A RID: 20090 RVA: 0x000BEDD4 File Offset: 0x000BCFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopSpRewardResponse);
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x000BEDE2 File Offset: 0x000BCFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopSpRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x000BEE10 File Offset: 0x000BD010
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

		// Token: 0x06004E7D RID: 20093 RVA: 0x000BEE55 File Offset: 0x000BD055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x000BEE62 File Offset: 0x000BD062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x000BEE6B File Offset: 0x000BD06B
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

		// Token: 0x06004E80 RID: 20096 RVA: 0x000BEEA0 File Offset: 0x000BD0A0
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

		// Token: 0x06004E81 RID: 20097 RVA: 0x000BEEDE File Offset: 0x000BD0DE
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

		// Token: 0x06004E82 RID: 20098 RVA: 0x000BEF0F File Offset: 0x000BD10F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x000BEF18 File Offset: 0x000BD118
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

		// Token: 0x040031EC RID: 12780
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031ED RID: 12781
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040031EE RID: 12782
		private ErrorCode errorCode_;
	}
}
