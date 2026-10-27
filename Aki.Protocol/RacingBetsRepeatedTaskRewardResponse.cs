using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E75 RID: 3701
	[NetMessage(EMessageId.RacingBetsRepeatedTaskRewardResponse)]
	public sealed class RacingBetsRepeatedTaskRewardResponse : IMessage<RacingBetsRepeatedTaskRewardResponse>, IMessage, IEquatable<RacingBetsRepeatedTaskRewardResponse>, IDeepCloneable<RacingBetsRepeatedTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06013E19 RID: 81433 RVA: 0x002E5361 File Offset: 0x002E3561
		[NullableContext(1)]
		public static RacingBetsRepeatedTaskRewardResponse Create()
		{
			return new RacingBetsRepeatedTaskRewardResponse();
		}

		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x06013E1A RID: 81434 RVA: 0x002E5368 File Offset: 0x002E3568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x06013E1B RID: 81435 RVA: 0x002E536B File Offset: 0x002E356B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRepeatedTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06013E1C RID: 81436 RVA: 0x002E5372 File Offset: 0x002E3572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse()
		{
		}

		// Token: 0x06013E1D RID: 81437 RVA: 0x002E537A File Offset: 0x002E357A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse(RacingBetsRepeatedTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E1E RID: 81438 RVA: 0x002E539F File Offset: 0x002E359F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRepeatedTaskRewardResponse Clone()
		{
			return new RacingBetsRepeatedTaskRewardResponse(this);
		}

		// Token: 0x17004220 RID: 16928
		// (get) Token: 0x06013E1F RID: 81439 RVA: 0x002E53A7 File Offset: 0x002E35A7
		// (set) Token: 0x06013E20 RID: 81440 RVA: 0x002E53AF File Offset: 0x002E35AF
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

		// Token: 0x06013E21 RID: 81441 RVA: 0x002E53B8 File Offset: 0x002E35B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRepeatedTaskRewardResponse);
		}

		// Token: 0x06013E22 RID: 81442 RVA: 0x002E53C6 File Offset: 0x002E35C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRepeatedTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E23 RID: 81443 RVA: 0x002E53F4 File Offset: 0x002E35F4
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

		// Token: 0x06013E24 RID: 81444 RVA: 0x002E5439 File Offset: 0x002E3639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E25 RID: 81445 RVA: 0x002E5446 File Offset: 0x002E3646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E26 RID: 81446 RVA: 0x002E544F File Offset: 0x002E364F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E27 RID: 81447 RVA: 0x002E5484 File Offset: 0x002E3684
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

		// Token: 0x06013E28 RID: 81448 RVA: 0x002E54C2 File Offset: 0x002E36C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRepeatedTaskRewardResponse other)
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

		// Token: 0x06013E29 RID: 81449 RVA: 0x002E54F3 File Offset: 0x002E36F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E2A RID: 81450 RVA: 0x002E54FC File Offset: 0x002E36FC
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007992 RID: 31122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007993 RID: 31123
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04007994 RID: 31124
		private ErrorCode errorCode_;
	}
}
