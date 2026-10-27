using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000041 RID: 65
	[NetMessage(EMessageId.AbyssRewardResponse)]
	public sealed class AbyssRewardResponse : IMessage<AbyssRewardResponse>, IMessage, IEquatable<AbyssRewardResponse>, IDeepCloneable<AbyssRewardResponse>, IBufferMessage
	{
		// Token: 0x060013AA RID: 5034 RVA: 0x00035457 File Offset: 0x00033657
		[NullableContext(1)]
		public static AbyssRewardResponse Create()
		{
			return new AbyssRewardResponse();
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0003545E File Offset: 0x0003365E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x00035461 File Offset: 0x00033661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardResponse.Descriptor;
			}
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00035468 File Offset: 0x00033668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse()
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00035470 File Offset: 0x00033670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse(AbyssRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00035495 File Offset: 0x00033695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse Clone()
		{
			return new AbyssRewardResponse(this);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0003549D File Offset: 0x0003369D
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x000354A5 File Offset: 0x000336A5
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

		// Token: 0x060013B2 RID: 5042 RVA: 0x000354AE File Offset: 0x000336AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardResponse);
		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000354BC File Offset: 0x000336BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x000354EC File Offset: 0x000336EC
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

		// Token: 0x060013B5 RID: 5045 RVA: 0x00035531 File Offset: 0x00033731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0003553E File Offset: 0x0003373E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00035547 File Offset: 0x00033747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00035578 File Offset: 0x00033778
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

		// Token: 0x060013B9 RID: 5049 RVA: 0x000355B6 File Offset: 0x000337B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRewardResponse other)
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

		// Token: 0x060013BA RID: 5050 RVA: 0x000355E7 File Offset: 0x000337E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x000355F0 File Offset: 0x000337F0
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002024 RID: 8228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002025 RID: 8229
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04002026 RID: 8230
		private ErrorCode errorCode_;
	}
}
