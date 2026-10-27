using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001118 RID: 4376
	[NetMessage(EMessageId.RoverRogueRefreshGainResponse)]
	public sealed class RoverRogueRefreshGainResponse : IMessage<RoverRogueRefreshGainResponse>, IMessage, IEquatable<RoverRogueRefreshGainResponse>, IDeepCloneable<RoverRogueRefreshGainResponse>, IBufferMessage
	{
		// Token: 0x06017562 RID: 95586 RVA: 0x003633E1 File Offset: 0x003615E1
		[NullableContext(1)]
		public static RoverRogueRefreshGainResponse Create()
		{
			return new RoverRogueRefreshGainResponse();
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x06017563 RID: 95587 RVA: 0x003633E8 File Offset: 0x003615E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x06017564 RID: 95588 RVA: 0x003633EB File Offset: 0x003615EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueRefreshGainResponse.Descriptor;
			}
		}

		// Token: 0x06017565 RID: 95589 RVA: 0x003633F2 File Offset: 0x003615F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse()
		{
		}

		// Token: 0x06017566 RID: 95590 RVA: 0x003633FC File Offset: 0x003615FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse(RoverRogueRefreshGainResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.chooseData_ = ((other.chooseData_ != null) ? other.chooseData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017567 RID: 95591 RVA: 0x00363448 File Offset: 0x00361648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueRefreshGainResponse Clone()
		{
			return new RoverRogueRefreshGainResponse(this);
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x06017568 RID: 95592 RVA: 0x00363450 File Offset: 0x00361650
		// (set) Token: 0x06017569 RID: 95593 RVA: 0x00363458 File Offset: 0x00361658
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

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x0601756A RID: 95594 RVA: 0x00363461 File Offset: 0x00361661
		// (set) Token: 0x0601756B RID: 95595 RVA: 0x00363469 File Offset: 0x00361669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueChooseData ChooseData
		{
			get
			{
				return this.chooseData_;
			}
			set
			{
				this.chooseData_ = value;
			}
		}

		// Token: 0x0601756C RID: 95596 RVA: 0x00363472 File Offset: 0x00361672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueRefreshGainResponse);
		}

		// Token: 0x0601756D RID: 95597 RVA: 0x00363480 File Offset: 0x00361680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueRefreshGainResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.ChooseData, other.ChooseData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601756E RID: 95598 RVA: 0x003634D0 File Offset: 0x003616D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.chooseData_ != null)
			{
				num ^= this.ChooseData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601756F RID: 95599 RVA: 0x0036352B File Offset: 0x0036172B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017570 RID: 95600 RVA: 0x00363538 File Offset: 0x00361738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017571 RID: 95601 RVA: 0x00363544 File Offset: 0x00361744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.chooseData_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017572 RID: 95602 RVA: 0x003635A0 File Offset: 0x003617A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.chooseData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChooseData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017573 RID: 95603 RVA: 0x003635F8 File Offset: 0x003617F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueRefreshGainResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.chooseData_ != null)
			{
				if (this.chooseData_ == null)
				{
					this.ChooseData = new RoverRogueChooseData();
				}
				this.ChooseData.MergeFrom(other.ChooseData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017574 RID: 95604 RVA: 0x00363660 File Offset: 0x00361860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017575 RID: 95605 RVA: 0x0036366C File Offset: 0x0036186C
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.chooseData_ == null)
						{
							this.ChooseData = new RoverRogueChooseData();
						}
						input.ReadMessage(this.ChooseData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008ABD RID: 35517
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ABE RID: 35518
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04008ABF RID: 35519
		private ErrorCode errorCode_;

		// Token: 0x04008AC0 RID: 35520
		public const int ChooseDataFieldNumber = 9;

		// Token: 0x04008AC1 RID: 35521
		private RoverRogueChooseData chooseData_;
	}
}
