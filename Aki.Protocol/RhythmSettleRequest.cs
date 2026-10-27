using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F48 RID: 3912
	[NetMessage(EMessageId.RhythmSettleRequest)]
	public sealed class RhythmSettleRequest : IMessage<RhythmSettleRequest>, IMessage, IEquatable<RhythmSettleRequest>, IDeepCloneable<RhythmSettleRequest>, IBufferMessage
	{
		// Token: 0x06014EDF RID: 85727 RVA: 0x00309573 File Offset: 0x00307773
		[NullableContext(1)]
		public static RhythmSettleRequest Create()
		{
			return new RhythmSettleRequest();
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06014EE0 RID: 85728 RVA: 0x0030957A File Offset: 0x0030777A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06014EE1 RID: 85729 RVA: 0x0030957D File Offset: 0x0030777D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSettleRequest.Descriptor;
			}
		}

		// Token: 0x06014EE2 RID: 85730 RVA: 0x00309584 File Offset: 0x00307784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest()
		{
		}

		// Token: 0x06014EE3 RID: 85731 RVA: 0x0030958C File Offset: 0x0030778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest(RhythmSettleRequest other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.settleReason_ = other.settleReason_;
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EE4 RID: 85732 RVA: 0x003095E4 File Offset: 0x003077E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest Clone()
		{
			return new RhythmSettleRequest(this);
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x06014EE5 RID: 85733 RVA: 0x003095EC File Offset: 0x003077EC
		// (set) Token: 0x06014EE6 RID: 85734 RVA: 0x003095F4 File Offset: 0x003077F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x06014EE7 RID: 85735 RVA: 0x003095FD File Offset: 0x003077FD
		// (set) Token: 0x06014EE8 RID: 85736 RVA: 0x00309605 File Offset: 0x00307805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleReasonPb SettleReason
		{
			get
			{
				return this.settleReason_;
			}
			set
			{
				this.settleReason_ = value;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x06014EE9 RID: 85737 RVA: 0x0030960E File Offset: 0x0030780E
		// (set) Token: 0x06014EEA RID: 85738 RVA: 0x00309616 File Offset: 0x00307816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = value;
			}
		}

		// Token: 0x06014EEB RID: 85739 RVA: 0x0030961F File Offset: 0x0030781F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSettleRequest);
		}

		// Token: 0x06014EEC RID: 85740 RVA: 0x00309630 File Offset: 0x00307830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSettleRequest other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.SettleReason == other.SettleReason && object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EED RID: 85741 RVA: 0x00309690 File Offset: 0x00307890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.SettleReason != RhythmSettleReasonPb.Complete)
			{
				num ^= this.SettleReason.GetHashCode();
			}
			if (this.payload_ != null)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014EEE RID: 85742 RVA: 0x00309704 File Offset: 0x00307904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EEF RID: 85743 RVA: 0x00309711 File Offset: 0x00307911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EF0 RID: 85744 RVA: 0x0030971C File Offset: 0x0030791C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.payload_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Payload);
			}
			if (this.SettleReason != RhythmSettleReasonPb.Complete)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.SettleReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014EF1 RID: 85745 RVA: 0x00309794 File Offset: 0x00307994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.SettleReason != RhythmSettleReasonPb.Complete)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SettleReason);
			}
			if (this.payload_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Payload);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014EF2 RID: 85746 RVA: 0x00309804 File Offset: 0x00307A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.SettleReason != RhythmSettleReasonPb.Complete)
			{
				this.SettleReason = other.SettleReason;
			}
			if (other.payload_ != null)
			{
				if (this.payload_ == null)
				{
					this.Payload = new RhythmResultPayload();
				}
				this.Payload.MergeFrom(other.Payload);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014EF3 RID: 85747 RVA: 0x00309880 File Offset: 0x00307A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EF4 RID: 85748 RVA: 0x0030988C File Offset: 0x00307A8C
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
				if (num != 16U)
				{
					if (num != 106U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SettleReason = (RhythmSettleReasonPb)input.ReadEnum();
						}
					}
					else
					{
						if (this.payload_ == null)
						{
							this.Payload = new RhythmResultPayload();
						}
						input.ReadMessage(this.Payload);
					}
				}
				else
				{
					this.SubLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E34 RID: 32308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E35 RID: 32309
		public const int SubLevelIdFieldNumber = 2;

		// Token: 0x04007E36 RID: 32310
		private int subLevelId_;

		// Token: 0x04007E37 RID: 32311
		public const int SettleReasonFieldNumber = 14;

		// Token: 0x04007E38 RID: 32312
		private RhythmSettleReasonPb settleReason_;

		// Token: 0x04007E39 RID: 32313
		public const int PayloadFieldNumber = 13;

		// Token: 0x04007E3A RID: 32314
		private RhythmResultPayload payload_;
	}
}
