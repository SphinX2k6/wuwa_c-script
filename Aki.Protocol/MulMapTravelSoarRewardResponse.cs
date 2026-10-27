using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE1 RID: 2785
	[NetMessage(EMessageId.MulMapTravelSoarRewardResponse)]
	public sealed class MulMapTravelSoarRewardResponse : IMessage<MulMapTravelSoarRewardResponse>, IMessage, IEquatable<MulMapTravelSoarRewardResponse>, IDeepCloneable<MulMapTravelSoarRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F243 RID: 62019 RVA: 0x00235F0D File Offset: 0x0023410D
		[NullableContext(1)]
		public static MulMapTravelSoarRewardResponse Create()
		{
			return new MulMapTravelSoarRewardResponse();
		}

		// Token: 0x17003153 RID: 12627
		// (get) Token: 0x0600F244 RID: 62020 RVA: 0x00235F14 File Offset: 0x00234114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003154 RID: 12628
		// (get) Token: 0x0600F245 RID: 62021 RVA: 0x00235F17 File Offset: 0x00234117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MulMapTravelSoarRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F246 RID: 62022 RVA: 0x00235F1E File Offset: 0x0023411E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse()
		{
		}

		// Token: 0x0600F247 RID: 62023 RVA: 0x00235F31 File Offset: 0x00234131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse(MulMapTravelSoarRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F248 RID: 62024 RVA: 0x00235F67 File Offset: 0x00234167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MulMapTravelSoarRewardResponse Clone()
		{
			return new MulMapTravelSoarRewardResponse(this);
		}

		// Token: 0x17003155 RID: 12629
		// (get) Token: 0x0600F249 RID: 62025 RVA: 0x00235F6F File Offset: 0x0023416F
		// (set) Token: 0x0600F24A RID: 62026 RVA: 0x00235F77 File Offset: 0x00234177
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

		// Token: 0x17003156 RID: 12630
		// (get) Token: 0x0600F24B RID: 62027 RVA: 0x00235F80 File Offset: 0x00234180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x00235F88 File Offset: 0x00234188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MulMapTravelSoarRewardResponse);
		}

		// Token: 0x0600F24D RID: 62029 RVA: 0x00235F98 File Offset: 0x00234198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MulMapTravelSoarRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F24E RID: 62030 RVA: 0x00235FE8 File Offset: 0x002341E8
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

		// Token: 0x0600F24F RID: 62031 RVA: 0x0023603B File Offset: 0x0023423B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x00236048 File Offset: 0x00234248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F251 RID: 62033 RVA: 0x00236054 File Offset: 0x00234254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, MulMapTravelSoarRewardResponse._repeated_taskIds_codec);
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

		// Token: 0x0600F252 RID: 62034 RVA: 0x002360A4 File Offset: 0x002342A4
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

		// Token: 0x0600F253 RID: 62035 RVA: 0x002360F8 File Offset: 0x002342F8
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

		// Token: 0x0600F254 RID: 62036 RVA: 0x00236145 File Offset: 0x00234345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x00236150 File Offset: 0x00234350
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
				if (num != 24U && num != 26U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, MulMapTravelSoarRewardResponse._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x040061C0 RID: 25024
		private UnknownFieldSet _unknownFields;

		// Token: 0x040061C1 RID: 25025
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040061C2 RID: 25026
		private ErrorCode errorCode_;

		// Token: 0x040061C3 RID: 25027
		public const int TaskIdsFieldNumber = 3;

		// Token: 0x040061C4 RID: 25028
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040061C5 RID: 25029
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
