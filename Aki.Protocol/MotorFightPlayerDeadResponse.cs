using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A4F RID: 2639
	[NetMessage(EMessageId.MotorFightPlayerDeadResponse)]
	public sealed class MotorFightPlayerDeadResponse : IMessage<MotorFightPlayerDeadResponse>, IMessage, IEquatable<MotorFightPlayerDeadResponse>, IDeepCloneable<MotorFightPlayerDeadResponse>, IBufferMessage
	{
		// Token: 0x0600E647 RID: 58951 RVA: 0x0021A51A File Offset: 0x0021871A
		[NullableContext(1)]
		public static MotorFightPlayerDeadResponse Create()
		{
			return new MotorFightPlayerDeadResponse();
		}

		// Token: 0x17002EB0 RID: 11952
		// (get) Token: 0x0600E648 RID: 58952 RVA: 0x0021A521 File Offset: 0x00218721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EB1 RID: 11953
		// (get) Token: 0x0600E649 RID: 58953 RVA: 0x0021A524 File Offset: 0x00218724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerDeadResponse.Descriptor;
			}
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x0021A52B File Offset: 0x0021872B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse()
		{
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x0021A533 File Offset: 0x00218733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse(MotorFightPlayerDeadResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E64C RID: 58956 RVA: 0x0021A558 File Offset: 0x00218758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse Clone()
		{
			return new MotorFightPlayerDeadResponse(this);
		}

		// Token: 0x17002EB2 RID: 11954
		// (get) Token: 0x0600E64D RID: 58957 RVA: 0x0021A560 File Offset: 0x00218760
		// (set) Token: 0x0600E64E RID: 58958 RVA: 0x0021A568 File Offset: 0x00218768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E64F RID: 58959 RVA: 0x0021A571 File Offset: 0x00218771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerDeadResponse);
		}

		// Token: 0x0600E650 RID: 58960 RVA: 0x0021A57F File Offset: 0x0021877F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerDeadResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E651 RID: 58961 RVA: 0x0021A5B0 File Offset: 0x002187B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E652 RID: 58962 RVA: 0x0021A5F5 File Offset: 0x002187F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E653 RID: 58963 RVA: 0x0021A602 File Offset: 0x00218802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E654 RID: 58964 RVA: 0x0021A60B File Offset: 0x0021880B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E655 RID: 58965 RVA: 0x0021A640 File Offset: 0x00218840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E656 RID: 58966 RVA: 0x0021A67E File Offset: 0x0021887E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightPlayerDeadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E657 RID: 58967 RVA: 0x0021A6AF File Offset: 0x002188AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E658 RID: 58968 RVA: 0x0021A6B8 File Offset: 0x002188B8
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DF6 RID: 24054
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DF7 RID: 24055
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04005DF8 RID: 24056
		private ErrorCode errCode_;
	}
}
