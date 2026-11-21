using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116B RID: 4459
	[NetMessage(EMessageId.RoverRogueTaskRewardTakeResponse)]
	public sealed class RoverRogueTaskRewardTakeResponse : IMessage<RoverRogueTaskRewardTakeResponse>, IMessage, IEquatable<RoverRogueTaskRewardTakeResponse>, IDeepCloneable<RoverRogueTaskRewardTakeResponse>, IBufferMessage
	{
		// Token: 0x06017D3D RID: 97597 RVA: 0x003782EC File Offset: 0x003764EC
		[NullableContext(1)]
		public static RoverRogueTaskRewardTakeResponse Create()
		{
			return new RoverRogueTaskRewardTakeResponse();
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x06017D3E RID: 97598 RVA: 0x003782F3 File Offset: 0x003764F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06017D3F RID: 97599 RVA: 0x003782F6 File Offset: 0x003764F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskRewardTakeResponse.Descriptor;
			}
		}

		// Token: 0x06017D40 RID: 97600 RVA: 0x003782FD File Offset: 0x003764FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse()
		{
		}

		// Token: 0x06017D41 RID: 97601 RVA: 0x00378310 File Offset: 0x00376510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse(RoverRogueTaskRewardTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.successRewardIds_ = other.successRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D42 RID: 97602 RVA: 0x00378346 File Offset: 0x00376546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse Clone()
		{
			return new RoverRogueTaskRewardTakeResponse(this);
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x06017D43 RID: 97603 RVA: 0x0037834E File Offset: 0x0037654E
		// (set) Token: 0x06017D44 RID: 97604 RVA: 0x00378356 File Offset: 0x00376556
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

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x06017D45 RID: 97605 RVA: 0x0037835F File Offset: 0x0037655F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessRewardIds
		{
			get
			{
				return this.successRewardIds_;
			}
		}

		// Token: 0x06017D46 RID: 97606 RVA: 0x00378367 File Offset: 0x00376567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskRewardTakeResponse);
		}

		// Token: 0x06017D47 RID: 97607 RVA: 0x00378378 File Offset: 0x00376578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskRewardTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.successRewardIds_.Equals(other.successRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D48 RID: 97608 RVA: 0x003783C8 File Offset: 0x003765C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.successRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017D49 RID: 97609 RVA: 0x0037841B File Offset: 0x0037661B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D4A RID: 97610 RVA: 0x00378428 File Offset: 0x00376628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D4B RID: 97611 RVA: 0x00378434 File Offset: 0x00376634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.successRewardIds_.WriteTo(ref output, RoverRogueTaskRewardTakeResponse._repeated_successRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D4C RID: 97612 RVA: 0x00378484 File Offset: 0x00376684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.successRewardIds_.CalculateSize(RoverRogueTaskRewardTakeResponse._repeated_successRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D4D RID: 97613 RVA: 0x003784D8 File Offset: 0x003766D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTaskRewardTakeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.successRewardIds_.Add(other.successRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D4E RID: 97614 RVA: 0x00378525 File Offset: 0x00376725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D4F RID: 97615 RVA: 0x00378530 File Offset: 0x00376730
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
				if (num != 40U)
				{
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.successRewardIds_.AddEntriesFrom(ref input, RoverRogueTaskRewardTakeResponse._repeated_successRewardIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008E28 RID: 36392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E29 RID: 36393
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008E2A RID: 36394
		private ErrorCode errorCode_;

		// Token: 0x04008E2B RID: 36395
		public const int SuccessRewardIdsFieldNumber = 10;

		// Token: 0x04008E2C RID: 36396
		private static readonly FieldCodec<int> _repeated_successRewardIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008E2D RID: 36397
		private readonly RepeatedField<int> successRewardIds_ = new RepeatedField<int>();
	}
}
