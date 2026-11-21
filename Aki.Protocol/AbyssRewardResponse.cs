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
		// Token: 0x060013D5 RID: 5077 RVA: 0x00035A0C File Offset: 0x00033C0C
		[NullableContext(1)]
		public static AbyssRewardResponse Create()
		{
			return new AbyssRewardResponse();
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00035A13 File Offset: 0x00033C13
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
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00035A16 File Offset: 0x00033C16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRewardResponse.Descriptor;
			}
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00035A1D File Offset: 0x00033C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse()
		{
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00035A25 File Offset: 0x00033C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse(AbyssRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00035A4A File Offset: 0x00033C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRewardResponse Clone()
		{
			return new AbyssRewardResponse(this);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00035A52 File Offset: 0x00033C52
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x00035A5A File Offset: 0x00033C5A
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

		// Token: 0x060013DD RID: 5085 RVA: 0x00035A63 File Offset: 0x00033C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRewardResponse);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x00035A71 File Offset: 0x00033C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x00035AA0 File Offset: 0x00033CA0
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

		// Token: 0x060013E0 RID: 5088 RVA: 0x00035AE5 File Offset: 0x00033CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x00035AF2 File Offset: 0x00033CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00035AFB File Offset: 0x00033CFB
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

		// Token: 0x060013E3 RID: 5091 RVA: 0x00035B30 File Offset: 0x00033D30
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

		// Token: 0x060013E4 RID: 5092 RVA: 0x00035B6E File Offset: 0x00033D6E
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

		// Token: 0x060013E5 RID: 5093 RVA: 0x00035B9F File Offset: 0x00033D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00035BA8 File Offset: 0x00033DA8
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

		// Token: 0x0400207A RID: 8314
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400207B RID: 8315
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400207C RID: 8316
		private ErrorCode errorCode_;
	}
}
