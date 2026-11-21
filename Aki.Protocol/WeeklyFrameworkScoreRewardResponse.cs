using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001585 RID: 5509
	[NetMessage(EMessageId.WeeklyFrameworkScoreRewardResponse)]
	public sealed class WeeklyFrameworkScoreRewardResponse : IMessage<WeeklyFrameworkScoreRewardResponse>, IMessage, IEquatable<WeeklyFrameworkScoreRewardResponse>, IDeepCloneable<WeeklyFrameworkScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601D2A2 RID: 119458 RVA: 0x004390B1 File Offset: 0x004372B1
		[NullableContext(1)]
		public static WeeklyFrameworkScoreRewardResponse Create()
		{
			return new WeeklyFrameworkScoreRewardResponse();
		}

		// Token: 0x170062AB RID: 25259
		// (get) Token: 0x0601D2A3 RID: 119459 RVA: 0x004390B8 File Offset: 0x004372B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062AC RID: 25260
		// (get) Token: 0x0601D2A4 RID: 119460 RVA: 0x004390BB File Offset: 0x004372BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601D2A5 RID: 119461 RVA: 0x004390C2 File Offset: 0x004372C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse()
		{
		}

		// Token: 0x0601D2A6 RID: 119462 RVA: 0x004390CA File Offset: 0x004372CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse(WeeklyFrameworkScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D2A7 RID: 119463 RVA: 0x004390EF File Offset: 0x004372EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse Clone()
		{
			return new WeeklyFrameworkScoreRewardResponse(this);
		}

		// Token: 0x170062AD RID: 25261
		// (get) Token: 0x0601D2A8 RID: 119464 RVA: 0x004390F7 File Offset: 0x004372F7
		// (set) Token: 0x0601D2A9 RID: 119465 RVA: 0x004390FF File Offset: 0x004372FF
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

		// Token: 0x0601D2AA RID: 119466 RVA: 0x00439108 File Offset: 0x00437308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkScoreRewardResponse);
		}

		// Token: 0x0601D2AB RID: 119467 RVA: 0x00439116 File Offset: 0x00437316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D2AC RID: 119468 RVA: 0x00439144 File Offset: 0x00437344
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

		// Token: 0x0601D2AD RID: 119469 RVA: 0x00439189 File Offset: 0x00437389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D2AE RID: 119470 RVA: 0x00439196 File Offset: 0x00437396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D2AF RID: 119471 RVA: 0x0043919F File Offset: 0x0043739F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D2B0 RID: 119472 RVA: 0x004391D4 File Offset: 0x004373D4
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

		// Token: 0x0601D2B1 RID: 119473 RVA: 0x00439212 File Offset: 0x00437412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkScoreRewardResponse other)
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

		// Token: 0x0601D2B2 RID: 119474 RVA: 0x00439243 File Offset: 0x00437443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D2B3 RID: 119475 RVA: 0x0043924C File Offset: 0x0043744C
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A765 RID: 42853
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A766 RID: 42854
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400A767 RID: 42855
		private ErrorCode errorCode_;
	}
}
