using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A44 RID: 2628
	[NetMessage(EMessageId.MotorFightKillResponse)]
	public sealed class MotorFightKillResponse : IMessage<MotorFightKillResponse>, IMessage, IEquatable<MotorFightKillResponse>, IDeepCloneable<MotorFightKillResponse>, IBufferMessage
	{
		// Token: 0x0600E569 RID: 58729 RVA: 0x002188F1 File Offset: 0x00216AF1
		[NullableContext(1)]
		public static MotorFightKillResponse Create()
		{
			return new MotorFightKillResponse();
		}

		// Token: 0x17002E83 RID: 11907
		// (get) Token: 0x0600E56A RID: 58730 RVA: 0x002188F8 File Offset: 0x00216AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x0600E56B RID: 58731 RVA: 0x002188FB File Offset: 0x00216AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightKillResponse.Descriptor;
			}
		}

		// Token: 0x0600E56C RID: 58732 RVA: 0x00218902 File Offset: 0x00216B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse()
		{
		}

		// Token: 0x0600E56D RID: 58733 RVA: 0x0021890A File Offset: 0x00216B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse(MotorFightKillResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E56E RID: 58734 RVA: 0x0021892F File Offset: 0x00216B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse Clone()
		{
			return new MotorFightKillResponse(this);
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x0600E56F RID: 58735 RVA: 0x00218937 File Offset: 0x00216B37
		// (set) Token: 0x0600E570 RID: 58736 RVA: 0x0021893F File Offset: 0x00216B3F
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

		// Token: 0x0600E571 RID: 58737 RVA: 0x00218948 File Offset: 0x00216B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightKillResponse);
		}

		// Token: 0x0600E572 RID: 58738 RVA: 0x00218956 File Offset: 0x00216B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightKillResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E573 RID: 58739 RVA: 0x00218984 File Offset: 0x00216B84
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

		// Token: 0x0600E574 RID: 58740 RVA: 0x002189C9 File Offset: 0x00216BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E575 RID: 58741 RVA: 0x002189D6 File Offset: 0x00216BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E576 RID: 58742 RVA: 0x002189DF File Offset: 0x00216BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E577 RID: 58743 RVA: 0x00218A14 File Offset: 0x00216C14
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

		// Token: 0x0600E578 RID: 58744 RVA: 0x00218A52 File Offset: 0x00216C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightKillResponse other)
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

		// Token: 0x0600E579 RID: 58745 RVA: 0x00218A83 File Offset: 0x00216C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E57A RID: 58746 RVA: 0x00218A8C File Offset: 0x00216C8C
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DBD RID: 23997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DBE RID: 23998
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04005DBF RID: 23999
		private ErrorCode errCode_;
	}
}
