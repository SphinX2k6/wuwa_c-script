using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013EE RID: 5102
	[NetMessage(EMessageId.TrackMoonTargetRewardResponse)]
	public sealed class TrackMoonTargetRewardResponse : IMessage<TrackMoonTargetRewardResponse>, IMessage, IEquatable<TrackMoonTargetRewardResponse>, IDeepCloneable<TrackMoonTargetRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B09F RID: 110751 RVA: 0x003EA6B5 File Offset: 0x003E88B5
		[NullableContext(1)]
		public static TrackMoonTargetRewardResponse Create()
		{
			return new TrackMoonTargetRewardResponse();
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x0601B0A0 RID: 110752 RVA: 0x003EA6BC File Offset: 0x003E88BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x0601B0A1 RID: 110753 RVA: 0x003EA6BF File Offset: 0x003E88BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonTargetRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B0A2 RID: 110754 RVA: 0x003EA6C6 File Offset: 0x003E88C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse()
		{
		}

		// Token: 0x0601B0A3 RID: 110755 RVA: 0x003EA6CE File Offset: 0x003E88CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse(TrackMoonTargetRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0A4 RID: 110756 RVA: 0x003EA6F3 File Offset: 0x003E88F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonTargetRewardResponse Clone()
		{
			return new TrackMoonTargetRewardResponse(this);
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x0601B0A5 RID: 110757 RVA: 0x003EA6FB File Offset: 0x003E88FB
		// (set) Token: 0x0601B0A6 RID: 110758 RVA: 0x003EA703 File Offset: 0x003E8903
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

		// Token: 0x0601B0A7 RID: 110759 RVA: 0x003EA70C File Offset: 0x003E890C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonTargetRewardResponse);
		}

		// Token: 0x0601B0A8 RID: 110760 RVA: 0x003EA71A File Offset: 0x003E891A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonTargetRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0A9 RID: 110761 RVA: 0x003EA748 File Offset: 0x003E8948
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

		// Token: 0x0601B0AA RID: 110762 RVA: 0x003EA78D File Offset: 0x003E898D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0AB RID: 110763 RVA: 0x003EA79A File Offset: 0x003E899A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0AC RID: 110764 RVA: 0x003EA7A3 File Offset: 0x003E89A3
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

		// Token: 0x0601B0AD RID: 110765 RVA: 0x003EA7D8 File Offset: 0x003E89D8
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

		// Token: 0x0601B0AE RID: 110766 RVA: 0x003EA816 File Offset: 0x003E8A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonTargetRewardResponse other)
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

		// Token: 0x0601B0AF RID: 110767 RVA: 0x003EA847 File Offset: 0x003E8A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0B0 RID: 110768 RVA: 0x003EA850 File Offset: 0x003E8A50
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

		// Token: 0x04009C81 RID: 40065
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C82 RID: 40066
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04009C83 RID: 40067
		private ErrorCode errorCode_;
	}
}
