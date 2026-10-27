using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A32 RID: 2610
	[NetMessage(EMessageId.MotorDevelopTaskRewardResponse)]
	public sealed class MotorDevelopTaskRewardResponse : IMessage<MotorDevelopTaskRewardResponse>, IMessage, IEquatable<MotorDevelopTaskRewardResponse>, IDeepCloneable<MotorDevelopTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600E3F6 RID: 58358 RVA: 0x00215775 File Offset: 0x00213975
		[NullableContext(1)]
		public static MotorDevelopTaskRewardResponse Create()
		{
			return new MotorDevelopTaskRewardResponse();
		}

		// Token: 0x17002E34 RID: 11828
		// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x0021577C File Offset: 0x0021397C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600E3F8 RID: 58360 RVA: 0x0021577F File Offset: 0x0021397F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600E3F9 RID: 58361 RVA: 0x00215786 File Offset: 0x00213986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse()
		{
		}

		// Token: 0x0600E3FA RID: 58362 RVA: 0x0021578E File Offset: 0x0021398E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse(MotorDevelopTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3FB RID: 58363 RVA: 0x002157B3 File Offset: 0x002139B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskRewardResponse Clone()
		{
			return new MotorDevelopTaskRewardResponse(this);
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600E3FC RID: 58364 RVA: 0x002157BB File Offset: 0x002139BB
		// (set) Token: 0x0600E3FD RID: 58365 RVA: 0x002157C3 File Offset: 0x002139C3
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

		// Token: 0x0600E3FE RID: 58366 RVA: 0x002157CC File Offset: 0x002139CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskRewardResponse);
		}

		// Token: 0x0600E3FF RID: 58367 RVA: 0x002157DA File Offset: 0x002139DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E400 RID: 58368 RVA: 0x00215808 File Offset: 0x00213A08
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

		// Token: 0x0600E401 RID: 58369 RVA: 0x0021584D File Offset: 0x00213A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E402 RID: 58370 RVA: 0x0021585A File Offset: 0x00213A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E403 RID: 58371 RVA: 0x00215863 File Offset: 0x00213A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E404 RID: 58372 RVA: 0x00215898 File Offset: 0x00213A98
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

		// Token: 0x0600E405 RID: 58373 RVA: 0x002158D6 File Offset: 0x00213AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopTaskRewardResponse other)
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

		// Token: 0x0600E406 RID: 58374 RVA: 0x00215907 File Offset: 0x00213B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E407 RID: 58375 RVA: 0x00215910 File Offset: 0x00213B10
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005D4F RID: 23887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D50 RID: 23888
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005D51 RID: 23889
		private ErrorCode errorCode_;
	}
}
