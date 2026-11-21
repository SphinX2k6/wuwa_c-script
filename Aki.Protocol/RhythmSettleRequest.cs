using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F38 RID: 3896
	[NetMessage(EMessageId.RhythmSettleRequest)]
	public sealed class RhythmSettleRequest : IMessage<RhythmSettleRequest>, IMessage, IEquatable<RhythmSettleRequest>, IDeepCloneable<RhythmSettleRequest>, IBufferMessage
	{
		// Token: 0x06014DFA RID: 85498 RVA: 0x00307EB7 File Offset: 0x003060B7
		[NullableContext(1)]
		public static RhythmSettleRequest Create()
		{
			return new RhythmSettleRequest();
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x06014DFB RID: 85499 RVA: 0x00307EBE File Offset: 0x003060BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x06014DFC RID: 85500 RVA: 0x00307EC1 File Offset: 0x003060C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSettleRequest.Descriptor;
			}
		}

		// Token: 0x06014DFD RID: 85501 RVA: 0x00307EC8 File Offset: 0x003060C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest()
		{
		}

		// Token: 0x06014DFE RID: 85502 RVA: 0x00307ED0 File Offset: 0x003060D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest(RhythmSettleRequest other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.settleReason_ = other.settleReason_;
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014DFF RID: 85503 RVA: 0x00307F28 File Offset: 0x00306128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleRequest Clone()
		{
			return new RhythmSettleRequest(this);
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x06014E00 RID: 85504 RVA: 0x00307F30 File Offset: 0x00306130
		// (set) Token: 0x06014E01 RID: 85505 RVA: 0x00307F38 File Offset: 0x00306138
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

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x06014E02 RID: 85506 RVA: 0x00307F41 File Offset: 0x00306141
		// (set) Token: 0x06014E03 RID: 85507 RVA: 0x00307F49 File Offset: 0x00306149
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

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x06014E04 RID: 85508 RVA: 0x00307F52 File Offset: 0x00306152
		// (set) Token: 0x06014E05 RID: 85509 RVA: 0x00307F5A File Offset: 0x0030615A
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

		// Token: 0x06014E06 RID: 85510 RVA: 0x00307F63 File Offset: 0x00306163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSettleRequest);
		}

		// Token: 0x06014E07 RID: 85511 RVA: 0x00307F74 File Offset: 0x00306174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSettleRequest other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.SettleReason == other.SettleReason && object.Equals(this.Payload, other.Payload) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E08 RID: 85512 RVA: 0x00307FD4 File Offset: 0x003061D4
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

		// Token: 0x06014E09 RID: 85513 RVA: 0x00308048 File Offset: 0x00306248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E0A RID: 85514 RVA: 0x00308055 File Offset: 0x00306255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E0B RID: 85515 RVA: 0x00308060 File Offset: 0x00306260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SettleReason != RhythmSettleReasonPb.Complete)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.SettleReason);
			}
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.payload_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E0C RID: 85516 RVA: 0x003080D8 File Offset: 0x003062D8
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

		// Token: 0x06014E0D RID: 85517 RVA: 0x00308148 File Offset: 0x00306348
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

		// Token: 0x06014E0E RID: 85518 RVA: 0x003081C4 File Offset: 0x003063C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E0F RID: 85519 RVA: 0x003081D0 File Offset: 0x003063D0
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
				if (num != 24U)
				{
					if (num != 48U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.SettleReason = (RhythmSettleReasonPb)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007E5E RID: 32350
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E5F RID: 32351
		public const int SubLevelIdFieldNumber = 6;

		// Token: 0x04007E60 RID: 32352
		private int subLevelId_;

		// Token: 0x04007E61 RID: 32353
		public const int SettleReasonFieldNumber = 3;

		// Token: 0x04007E62 RID: 32354
		private RhythmSettleReasonPb settleReason_;

		// Token: 0x04007E63 RID: 32355
		public const int PayloadFieldNumber = 15;

		// Token: 0x04007E64 RID: 32356
		private RhythmResultPayload payload_;
	}
}
