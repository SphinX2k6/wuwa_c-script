using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001131 RID: 4401
	[NetMessage(EMessageId.RoverRogueTaskRewardTakeResponse)]
	public sealed class RoverRogueTaskRewardTakeResponse : IMessage<RoverRogueTaskRewardTakeResponse>, IMessage, IEquatable<RoverRogueTaskRewardTakeResponse>, IDeepCloneable<RoverRogueTaskRewardTakeResponse>, IBufferMessage
	{
		// Token: 0x0601779C RID: 96156 RVA: 0x00368F9C File Offset: 0x0036719C
		[NullableContext(1)]
		public static RoverRogueTaskRewardTakeResponse Create()
		{
			return new RoverRogueTaskRewardTakeResponse();
		}

		// Token: 0x17004ECD RID: 20173
		// (get) Token: 0x0601779D RID: 96157 RVA: 0x00368FA3 File Offset: 0x003671A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ECE RID: 20174
		// (get) Token: 0x0601779E RID: 96158 RVA: 0x00368FA6 File Offset: 0x003671A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskRewardTakeResponse.Descriptor;
			}
		}

		// Token: 0x0601779F RID: 96159 RVA: 0x00368FAD File Offset: 0x003671AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse()
		{
		}

		// Token: 0x060177A0 RID: 96160 RVA: 0x00368FC0 File Offset: 0x003671C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse(RoverRogueTaskRewardTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.successRewardIds_ = other.successRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177A1 RID: 96161 RVA: 0x00368FF6 File Offset: 0x003671F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskRewardTakeResponse Clone()
		{
			return new RoverRogueTaskRewardTakeResponse(this);
		}

		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x060177A2 RID: 96162 RVA: 0x00368FFE File Offset: 0x003671FE
		// (set) Token: 0x060177A3 RID: 96163 RVA: 0x00369006 File Offset: 0x00367206
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

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x060177A4 RID: 96164 RVA: 0x0036900F File Offset: 0x0036720F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SuccessRewardIds
		{
			get
			{
				return this.successRewardIds_;
			}
		}

		// Token: 0x060177A5 RID: 96165 RVA: 0x00369017 File Offset: 0x00367217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskRewardTakeResponse);
		}

		// Token: 0x060177A6 RID: 96166 RVA: 0x00369028 File Offset: 0x00367228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskRewardTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.successRewardIds_.Equals(other.successRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177A7 RID: 96167 RVA: 0x00369078 File Offset: 0x00367278
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

		// Token: 0x060177A8 RID: 96168 RVA: 0x003690CB File Offset: 0x003672CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177A9 RID: 96169 RVA: 0x003690D8 File Offset: 0x003672D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177AA RID: 96170 RVA: 0x003690E4 File Offset: 0x003672E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.successRewardIds_.WriteTo(ref output, RoverRogueTaskRewardTakeResponse._repeated_successRewardIds_codec);
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

		// Token: 0x060177AB RID: 96171 RVA: 0x00369134 File Offset: 0x00367334
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

		// Token: 0x060177AC RID: 96172 RVA: 0x00369188 File Offset: 0x00367388
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

		// Token: 0x060177AD RID: 96173 RVA: 0x003691D5 File Offset: 0x003673D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177AE RID: 96174 RVA: 0x003691E0 File Offset: 0x003673E0
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
				if (num != 8U && num != 10U)
				{
					if (num != 88U)
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
					this.successRewardIds_.AddEntriesFrom(ref input, RoverRogueTaskRewardTakeResponse._repeated_successRewardIds_codec);
				}
			}
		}

		// Token: 0x04008B95 RID: 35733
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B96 RID: 35734
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008B97 RID: 35735
		private ErrorCode errorCode_;

		// Token: 0x04008B98 RID: 35736
		public const int SuccessRewardIdsFieldNumber = 1;

		// Token: 0x04008B99 RID: 35737
		private static readonly FieldCodec<int> _repeated_successRewardIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04008B9A RID: 35738
		private readonly RepeatedField<int> successRewardIds_ = new RepeatedField<int>();
	}
}
