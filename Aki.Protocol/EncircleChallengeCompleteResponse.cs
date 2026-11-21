using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000422 RID: 1058
	[NetMessage(EMessageId.EncircleChallengeCompleteResponse)]
	public sealed class EncircleChallengeCompleteResponse : IMessage<EncircleChallengeCompleteResponse>, IMessage, IEquatable<EncircleChallengeCompleteResponse>, IDeepCloneable<EncircleChallengeCompleteResponse>, IBufferMessage
	{
		// Token: 0x06006605 RID: 26117 RVA: 0x000F5B17 File Offset: 0x000F3D17
		[NullableContext(1)]
		public static EncircleChallengeCompleteResponse Create()
		{
			return new EncircleChallengeCompleteResponse();
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x06006606 RID: 26118 RVA: 0x000F5B1E File Offset: 0x000F3D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06006607 RID: 26119 RVA: 0x000F5B21 File Offset: 0x000F3D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncircleChallengeCompleteResponse.Descriptor;
			}
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x000F5B28 File Offset: 0x000F3D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse()
		{
		}

		// Token: 0x06006609 RID: 26121 RVA: 0x000F5B30 File Offset: 0x000F3D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse(EncircleChallengeCompleteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x000F5B55 File Offset: 0x000F3D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EncircleChallengeCompleteResponse Clone()
		{
			return new EncircleChallengeCompleteResponse(this);
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x000F5B5D File Offset: 0x000F3D5D
		// (set) Token: 0x0600660C RID: 26124 RVA: 0x000F5B65 File Offset: 0x000F3D65
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

		// Token: 0x0600660D RID: 26125 RVA: 0x000F5B6E File Offset: 0x000F3D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncircleChallengeCompleteResponse);
		}

		// Token: 0x0600660E RID: 26126 RVA: 0x000F5B7C File Offset: 0x000F3D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EncircleChallengeCompleteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600660F RID: 26127 RVA: 0x000F5BAC File Offset: 0x000F3DAC
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

		// Token: 0x06006610 RID: 26128 RVA: 0x000F5BF1 File Offset: 0x000F3DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006611 RID: 26129 RVA: 0x000F5BFE File Offset: 0x000F3DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006612 RID: 26130 RVA: 0x000F5C07 File Offset: 0x000F3E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006613 RID: 26131 RVA: 0x000F5C3C File Offset: 0x000F3E3C
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

		// Token: 0x06006614 RID: 26132 RVA: 0x000F5C7A File Offset: 0x000F3E7A
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

		// Token: 0x06006615 RID: 26133 RVA: 0x000F5CAB File Offset: 0x000F3EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006616 RID: 26134 RVA: 0x000F5CB4 File Offset: 0x000F3EB4
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003961 RID: 14689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003962 RID: 14690
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003963 RID: 14691
		private ErrorCode errorCode_;
	}
}
