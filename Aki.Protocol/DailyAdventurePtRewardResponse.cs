using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200031F RID: 799
	[NetMessage(EMessageId.DailyAdventurePtRewardResponse)]
	public sealed class DailyAdventurePtRewardResponse : IMessage<DailyAdventurePtRewardResponse>, IMessage, IEquatable<DailyAdventurePtRewardResponse>, IDeepCloneable<DailyAdventurePtRewardResponse>, IBufferMessage
	{
		// Token: 0x06005074 RID: 20596 RVA: 0x000C42C9 File Offset: 0x000C24C9
		[NullableContext(1)]
		public static DailyAdventurePtRewardResponse Create()
		{
			return new DailyAdventurePtRewardResponse();
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06005075 RID: 20597 RVA: 0x000C42D0 File Offset: 0x000C24D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06005076 RID: 20598 RVA: 0x000C42D3 File Offset: 0x000C24D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyAdventurePtRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x000C42DA File Offset: 0x000C24DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse()
		{
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x000C42E2 File Offset: 0x000C24E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse(DailyAdventurePtRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x000C4307 File Offset: 0x000C2507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyAdventurePtRewardResponse Clone()
		{
			return new DailyAdventurePtRewardResponse(this);
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600507A RID: 20602 RVA: 0x000C430F File Offset: 0x000C250F
		// (set) Token: 0x0600507B RID: 20603 RVA: 0x000C4317 File Offset: 0x000C2517
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

		// Token: 0x0600507C RID: 20604 RVA: 0x000C4320 File Offset: 0x000C2520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyAdventurePtRewardResponse);
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x000C432E File Offset: 0x000C252E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyAdventurePtRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x000C435C File Offset: 0x000C255C
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

		// Token: 0x0600507F RID: 20607 RVA: 0x000C43A1 File Offset: 0x000C25A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x000C43AE File Offset: 0x000C25AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x000C43B7 File Offset: 0x000C25B7
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

		// Token: 0x06005082 RID: 20610 RVA: 0x000C43EC File Offset: 0x000C25EC
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

		// Token: 0x06005083 RID: 20611 RVA: 0x000C442A File Offset: 0x000C262A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyAdventurePtRewardResponse other)
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

		// Token: 0x06005084 RID: 20612 RVA: 0x000C445B File Offset: 0x000C265B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x000C4464 File Offset: 0x000C2664
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

		// Token: 0x04003268 RID: 12904
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003269 RID: 12905
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400326A RID: 12906
		private ErrorCode errorCode_;
	}
}
