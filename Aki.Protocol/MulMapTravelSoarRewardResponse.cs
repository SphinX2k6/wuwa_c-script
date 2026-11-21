using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AD0 RID: 2768
	[NetMessage(EMessageId.MulMapTravelSoarRewardResponse)]
	public sealed class MulMapTravelSoarRewardResponse : IMessage<MulMapTravelSoarRewardResponse>, IMessage, IEquatable<MulMapTravelSoarRewardResponse>, IDeepCloneable<MulMapTravelSoarRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F129 RID: 61737 RVA: 0x00233D01 File Offset: 0x00231F01
		[NullableContext(1)]
		public static MulMapTravelSoarRewardResponse Create()
		{
			return new MulMapTravelSoarRewardResponse();
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600F12A RID: 61738 RVA: 0x00233D08 File Offset: 0x00231F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600F12B RID: 61739 RVA: 0x00233D0B File Offset: 0x00231F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelSoarRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F12C RID: 61740 RVA: 0x00233D12 File Offset: 0x00231F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse()
		{
		}

		// Token: 0x0600F12D RID: 61741 RVA: 0x00233D25 File Offset: 0x00231F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse(MulMapTravelSoarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F12E RID: 61742 RVA: 0x00233D5B File Offset: 0x00231F5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse Clone()
		{
			return new MulMapTravelSoarRewardResponse(this);
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600F12F RID: 61743 RVA: 0x00233D63 File Offset: 0x00231F63
		// (set) Token: 0x0600F130 RID: 61744 RVA: 0x00233D6B File Offset: 0x00231F6B
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

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600F131 RID: 61745 RVA: 0x00233D74 File Offset: 0x00231F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F132 RID: 61746 RVA: 0x00233D7C File Offset: 0x00231F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelSoarRewardResponse);
		}

		// Token: 0x0600F133 RID: 61747 RVA: 0x00233D8C File Offset: 0x00231F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelSoarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F134 RID: 61748 RVA: 0x00233DDC File Offset: 0x00231FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F135 RID: 61749 RVA: 0x00233E2F File Offset: 0x0023202F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F136 RID: 61750 RVA: 0x00233E3C File Offset: 0x0023203C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F137 RID: 61751 RVA: 0x00233E48 File Offset: 0x00232048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.taskIds_.WriteTo(ref output, MulMapTravelSoarRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F138 RID: 61752 RVA: 0x00233E98 File Offset: 0x00232098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.taskIds_.CalculateSize(MulMapTravelSoarRewardResponse._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F139 RID: 61753 RVA: 0x00233EEC File Offset: 0x002320EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MulMapTravelSoarRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F13A RID: 61754 RVA: 0x00233F39 File Offset: 0x00232139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F13B RID: 61755 RVA: 0x00233F44 File Offset: 0x00232144
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
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, MulMapTravelSoarRewardResponse._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040061C9 RID: 25033
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061CA RID: 25034
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040061CB RID: 25035
		private ErrorCode errorCode_;

		// Token: 0x040061CC RID: 25036
		public const int TaskIdsFieldNumber = 13;

		// Token: 0x040061CD RID: 25037
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040061CE RID: 25038
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
