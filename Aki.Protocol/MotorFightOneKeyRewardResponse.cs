using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4D RID: 2637
	[NetMessage(EMessageId.MotorFightOneKeyRewardResponse)]
	public sealed class MotorFightOneKeyRewardResponse : IMessage<MotorFightOneKeyRewardResponse>, IMessage, IEquatable<MotorFightOneKeyRewardResponse>, IDeepCloneable<MotorFightOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E625 RID: 58917 RVA: 0x0021A201 File Offset: 0x00218401
		[NullableContext(1)]
		public static MotorFightOneKeyRewardResponse Create()
		{
			return new MotorFightOneKeyRewardResponse();
		}

		// Token: 0x17002EAB RID: 11947
		// (get) Token: 0x0600E626 RID: 58918 RVA: 0x0021A208 File Offset: 0x00218408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EAC RID: 11948
		// (get) Token: 0x0600E627 RID: 58919 RVA: 0x0021A20B File Offset: 0x0021840B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E628 RID: 58920 RVA: 0x0021A212 File Offset: 0x00218412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse()
		{
		}

		// Token: 0x0600E629 RID: 58921 RVA: 0x0021A21A File Offset: 0x0021841A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse(MotorFightOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E62A RID: 58922 RVA: 0x0021A23F File Offset: 0x0021843F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightOneKeyRewardResponse Clone()
		{
			return new MotorFightOneKeyRewardResponse(this);
		}

		// Token: 0x17002EAD RID: 11949
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x0021A247 File Offset: 0x00218447
		// (set) Token: 0x0600E62C RID: 58924 RVA: 0x0021A24F File Offset: 0x0021844F
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

		// Token: 0x0600E62D RID: 58925 RVA: 0x0021A258 File Offset: 0x00218458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightOneKeyRewardResponse);
		}

		// Token: 0x0600E62E RID: 58926 RVA: 0x0021A266 File Offset: 0x00218466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E62F RID: 58927 RVA: 0x0021A294 File Offset: 0x00218494
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

		// Token: 0x0600E630 RID: 58928 RVA: 0x0021A2D9 File Offset: 0x002184D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E631 RID: 58929 RVA: 0x0021A2E6 File Offset: 0x002184E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E632 RID: 58930 RVA: 0x0021A2EF File Offset: 0x002184EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E633 RID: 58931 RVA: 0x0021A324 File Offset: 0x00218524
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

		// Token: 0x0600E634 RID: 58932 RVA: 0x0021A362 File Offset: 0x00218562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightOneKeyRewardResponse other)
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

		// Token: 0x0600E635 RID: 58933 RVA: 0x0021A393 File Offset: 0x00218593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E636 RID: 58934 RVA: 0x0021A39C File Offset: 0x0021859C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DF2 RID: 24050
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DF3 RID: 24051
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04005DF4 RID: 24052
		private ErrorCode errorCode_;
	}
}
