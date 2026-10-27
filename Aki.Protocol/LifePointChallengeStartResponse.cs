using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000918 RID: 2328
	[NetMessage(EMessageId.LifePointChallengeStartResponse)]
	public sealed class LifePointChallengeStartResponse : IMessage<LifePointChallengeStartResponse>, IMessage, IEquatable<LifePointChallengeStartResponse>, IDeepCloneable<LifePointChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x0600CD74 RID: 52596 RVA: 0x001E45E5 File Offset: 0x001E27E5
		[NullableContext(1)]
		public static LifePointChallengeStartResponse Create()
		{
			return new LifePointChallengeStartResponse();
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600CD75 RID: 52597 RVA: 0x001E45EC File Offset: 0x001E27EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x001E45EF File Offset: 0x001E27EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LifePointChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x0600CD77 RID: 52599 RVA: 0x001E45F6 File Offset: 0x001E27F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse()
		{
		}

		// Token: 0x0600CD78 RID: 52600 RVA: 0x001E45FE File Offset: 0x001E27FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse(LifePointChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x001E4623 File Offset: 0x001E2823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LifePointChallengeStartResponse Clone()
		{
			return new LifePointChallengeStartResponse(this);
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600CD7A RID: 52602 RVA: 0x001E462B File Offset: 0x001E282B
		// (set) Token: 0x0600CD7B RID: 52603 RVA: 0x001E4633 File Offset: 0x001E2833
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

		// Token: 0x0600CD7C RID: 52604 RVA: 0x001E463C File Offset: 0x001E283C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LifePointChallengeStartResponse);
		}

		// Token: 0x0600CD7D RID: 52605 RVA: 0x001E464A File Offset: 0x001E284A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LifePointChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x001E4678 File Offset: 0x001E2878
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

		// Token: 0x0600CD7F RID: 52607 RVA: 0x001E46BD File Offset: 0x001E28BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD80 RID: 52608 RVA: 0x001E46CA File Offset: 0x001E28CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD81 RID: 52609 RVA: 0x001E46D3 File Offset: 0x001E28D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x001E4708 File Offset: 0x001E2908
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

		// Token: 0x0600CD83 RID: 52611 RVA: 0x001E4746 File Offset: 0x001E2946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LifePointChallengeStartResponse other)
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

		// Token: 0x0600CD84 RID: 52612 RVA: 0x001E4777 File Offset: 0x001E2977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x001E4780 File Offset: 0x001E2980
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040056F8 RID: 22264
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056F9 RID: 22265
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040056FA RID: 22266
		private ErrorCode errorCode_;
	}
}
