using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A33 RID: 2611
	[NetMessage(EMessageId.MotorFightKillResponse)]
	public sealed class MotorFightKillResponse : IMessage<MotorFightKillResponse>, IMessage, IEquatable<MotorFightKillResponse>, IDeepCloneable<MotorFightKillResponse>, IBufferMessage
	{
		// Token: 0x0600E44F RID: 58447 RVA: 0x002166FC File Offset: 0x002148FC
		[NullableContext(1)]
		public static MotorFightKillResponse Create()
		{
			return new MotorFightKillResponse();
		}

		// Token: 0x17002E45 RID: 11845
		// (get) Token: 0x0600E450 RID: 58448 RVA: 0x00216703 File Offset: 0x00214903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x0600E451 RID: 58449 RVA: 0x00216706 File Offset: 0x00214906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightKillResponse.Descriptor;
			}
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x0021670D File Offset: 0x0021490D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse()
		{
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x00216715 File Offset: 0x00214915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse(MotorFightKillResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E454 RID: 58452 RVA: 0x0021673A File Offset: 0x0021493A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightKillResponse Clone()
		{
			return new MotorFightKillResponse(this);
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x00216742 File Offset: 0x00214942
		// (set) Token: 0x0600E456 RID: 58454 RVA: 0x0021674A File Offset: 0x0021494A
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

		// Token: 0x0600E457 RID: 58455 RVA: 0x00216753 File Offset: 0x00214953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightKillResponse);
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x00216761 File Offset: 0x00214961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightKillResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E459 RID: 58457 RVA: 0x00216790 File Offset: 0x00214990
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

		// Token: 0x0600E45A RID: 58458 RVA: 0x002167D5 File Offset: 0x002149D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E45B RID: 58459 RVA: 0x002167E2 File Offset: 0x002149E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E45C RID: 58460 RVA: 0x002167EB File Offset: 0x002149EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E45D RID: 58461 RVA: 0x00216820 File Offset: 0x00214A20
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

		// Token: 0x0600E45E RID: 58462 RVA: 0x0021685E File Offset: 0x00214A5E
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

		// Token: 0x0600E45F RID: 58463 RVA: 0x0021688F File Offset: 0x00214A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E460 RID: 58464 RVA: 0x00216898 File Offset: 0x00214A98
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DC6 RID: 24006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005DC7 RID: 24007
		public const int ErrCodeFieldNumber = 6;

		// Token: 0x04005DC8 RID: 24008
		private ErrorCode errCode_;
	}
}
