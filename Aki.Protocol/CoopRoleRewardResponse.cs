using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000305 RID: 773
	[NetMessage(EMessageId.CoopRoleRewardResponse)]
	public sealed class CoopRoleRewardResponse : IMessage<CoopRoleRewardResponse>, IMessage, IEquatable<CoopRoleRewardResponse>, IDeepCloneable<CoopRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x06004E4E RID: 20046 RVA: 0x000BE9BD File Offset: 0x000BCBBD
		[NullableContext(1)]
		public static CoopRoleRewardResponse Create()
		{
			return new CoopRoleRewardResponse();
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x06004E4F RID: 20047 RVA: 0x000BE9C4 File Offset: 0x000BCBC4
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
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x000BE9C7 File Offset: 0x000BCBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CoopRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x000BE9CE File Offset: 0x000BCBCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse()
		{
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x000BE9D6 File Offset: 0x000BCBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse(CoopRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x000BE9FB File Offset: 0x000BCBFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CoopRoleRewardResponse Clone()
		{
			return new CoopRoleRewardResponse(this);
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x000BEA03 File Offset: 0x000BCC03
		// (set) Token: 0x06004E55 RID: 20053 RVA: 0x000BEA0B File Offset: 0x000BCC0B
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

		// Token: 0x06004E56 RID: 20054 RVA: 0x000BEA14 File Offset: 0x000BCC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CoopRoleRewardResponse);
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x000BEA22 File Offset: 0x000BCC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CoopRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x000BEA50 File Offset: 0x000BCC50
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

		// Token: 0x06004E59 RID: 20057 RVA: 0x000BEA95 File Offset: 0x000BCC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x000BEAA2 File Offset: 0x000BCCA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x000BEAAB File Offset: 0x000BCCAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x000BEAE0 File Offset: 0x000BCCE0
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

		// Token: 0x06004E5D RID: 20061 RVA: 0x000BEB1E File Offset: 0x000BCD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CoopRoleRewardResponse other)
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

		// Token: 0x06004E5E RID: 20062 RVA: 0x000BEB4F File Offset: 0x000BCD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x000BEB58 File Offset: 0x000BCD58
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040031E5 RID: 12773
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031E6 RID: 12774
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040031E7 RID: 12775
		private ErrorCode errorCode_;
	}
}
