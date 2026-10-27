using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000308 RID: 776
	[NetMessage(EMessageId.CorniceMeetingRewardResponse)]
	public sealed class CorniceMeetingRewardResponse : IMessage<CorniceMeetingRewardResponse>, IMessage, IEquatable<CorniceMeetingRewardResponse>, IDeepCloneable<CorniceMeetingRewardResponse>, IBufferMessage
	{
		// Token: 0x06004E46 RID: 20038 RVA: 0x000BE210 File Offset: 0x000BC410
		[NullableContext(1)]
		public static CorniceMeetingRewardResponse Create()
		{
			return new CorniceMeetingRewardResponse();
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x000BE217 File Offset: 0x000BC417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x000BE21A File Offset: 0x000BC41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceMeetingRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x000BE221 File Offset: 0x000BC421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse()
		{
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x000BE229 File Offset: 0x000BC429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse(CorniceMeetingRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x000BE24E File Offset: 0x000BC44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceMeetingRewardResponse Clone()
		{
			return new CorniceMeetingRewardResponse(this);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004E4C RID: 20044 RVA: 0x000BE256 File Offset: 0x000BC456
		// (set) Token: 0x06004E4D RID: 20045 RVA: 0x000BE25E File Offset: 0x000BC45E
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

		// Token: 0x06004E4E RID: 20046 RVA: 0x000BE267 File Offset: 0x000BC467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceMeetingRewardResponse);
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x000BE275 File Offset: 0x000BC475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceMeetingRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x000BE2A4 File Offset: 0x000BC4A4
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

		// Token: 0x06004E51 RID: 20049 RVA: 0x000BE2E9 File Offset: 0x000BC4E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x000BE2F6 File Offset: 0x000BC4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x000BE2FF File Offset: 0x000BC4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x000BE334 File Offset: 0x000BC534
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

		// Token: 0x06004E55 RID: 20053 RVA: 0x000BE372 File Offset: 0x000BC572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceMeetingRewardResponse other)
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

		// Token: 0x06004E56 RID: 20054 RVA: 0x000BE3A3 File Offset: 0x000BC5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x000BE3AC File Offset: 0x000BC5AC
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400318B RID: 12683
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400318C RID: 12684
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400318D RID: 12685
		private ErrorCode errorCode_;
	}
}
