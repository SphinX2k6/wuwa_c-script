using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5D RID: 2653
	[NetMessage(EMessageId.MotorFightTalentUpResponse)]
	public sealed class MotorFightTalentUpResponse : IMessage<MotorFightTalentUpResponse>, IMessage, IEquatable<MotorFightTalentUpResponse>, IDeepCloneable<MotorFightTalentUpResponse>, IBufferMessage
	{
		// Token: 0x0600E7C0 RID: 59328 RVA: 0x0021E101 File Offset: 0x0021C301
		[NullableContext(1)]
		public static MotorFightTalentUpResponse Create()
		{
			return new MotorFightTalentUpResponse();
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x0021E108 File Offset: 0x0021C308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F04 RID: 12036
		// (get) Token: 0x0600E7C2 RID: 59330 RVA: 0x0021E10B File Offset: 0x0021C30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentUpResponse.Descriptor;
			}
		}

		// Token: 0x0600E7C3 RID: 59331 RVA: 0x0021E112 File Offset: 0x0021C312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse()
		{
		}

		// Token: 0x0600E7C4 RID: 59332 RVA: 0x0021E11A File Offset: 0x0021C31A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse(MotorFightTalentUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7C5 RID: 59333 RVA: 0x0021E13F File Offset: 0x0021C33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse Clone()
		{
			return new MotorFightTalentUpResponse(this);
		}

		// Token: 0x17002F05 RID: 12037
		// (get) Token: 0x0600E7C6 RID: 59334 RVA: 0x0021E147 File Offset: 0x0021C347
		// (set) Token: 0x0600E7C7 RID: 59335 RVA: 0x0021E14F File Offset: 0x0021C34F
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

		// Token: 0x0600E7C8 RID: 59336 RVA: 0x0021E158 File Offset: 0x0021C358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentUpResponse);
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x0021E166 File Offset: 0x0021C366
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7CA RID: 59338 RVA: 0x0021E194 File Offset: 0x0021C394
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

		// Token: 0x0600E7CB RID: 59339 RVA: 0x0021E1D9 File Offset: 0x0021C3D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x0021E1E6 File Offset: 0x0021C3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7CD RID: 59341 RVA: 0x0021E1EF File Offset: 0x0021C3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x0021E224 File Offset: 0x0021C424
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

		// Token: 0x0600E7CF RID: 59343 RVA: 0x0021E262 File Offset: 0x0021C462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentUpResponse other)
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

		// Token: 0x0600E7D0 RID: 59344 RVA: 0x0021E293 File Offset: 0x0021C493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x0021E29C File Offset: 0x0021C49C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005ECD RID: 24269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ECE RID: 24270
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005ECF RID: 24271
		private ErrorCode errorCode_;
	}
}
