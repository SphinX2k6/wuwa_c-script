using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC8 RID: 3272
	[NetMessage(EMessageId.PhantomCollectUpdateNotify)]
	public sealed class PhantomCollectUpdateNotify : IMessage<PhantomCollectUpdateNotify>, IMessage, IEquatable<PhantomCollectUpdateNotify>, IDeepCloneable<PhantomCollectUpdateNotify>, IBufferMessage
	{
		// Token: 0x06011B73 RID: 72563 RVA: 0x00297D93 File Offset: 0x00295F93
		[NullableContext(1)]
		public static PhantomCollectUpdateNotify Create()
		{
			return new PhantomCollectUpdateNotify();
		}

		// Token: 0x17003AB2 RID: 15026
		// (get) Token: 0x06011B74 RID: 72564 RVA: 0x00297D9A File Offset: 0x00295F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AB3 RID: 15027
		// (get) Token: 0x06011B75 RID: 72565 RVA: 0x00297D9D File Offset: 0x00295F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomCollectUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06011B76 RID: 72566 RVA: 0x00297DA4 File Offset: 0x00295FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify()
		{
		}

		// Token: 0x06011B77 RID: 72567 RVA: 0x00297DAC File Offset: 0x00295FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify(PhantomCollectUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.phantomCollectReward_ = ((other.phantomCollectReward_ != null) ? other.phantomCollectReward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B78 RID: 72568 RVA: 0x00297DF8 File Offset: 0x00295FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectUpdateNotify Clone()
		{
			return new PhantomCollectUpdateNotify(this);
		}

		// Token: 0x17003AB4 RID: 15028
		// (get) Token: 0x06011B79 RID: 72569 RVA: 0x00297E00 File Offset: 0x00296000
		// (set) Token: 0x06011B7A RID: 72570 RVA: 0x00297E08 File Offset: 0x00296008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17003AB5 RID: 15029
		// (get) Token: 0x06011B7B RID: 72571 RVA: 0x00297E11 File Offset: 0x00296011
		// (set) Token: 0x06011B7C RID: 72572 RVA: 0x00297E19 File Offset: 0x00296019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomCollectReward PhantomCollectReward
		{
			get
			{
				return this.phantomCollectReward_;
			}
			set
			{
				this.phantomCollectReward_ = value;
			}
		}

		// Token: 0x06011B7D RID: 72573 RVA: 0x00297E22 File Offset: 0x00296022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomCollectUpdateNotify);
		}

		// Token: 0x06011B7E RID: 72574 RVA: 0x00297E30 File Offset: 0x00296030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomCollectUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this.PhantomCollectReward, other.PhantomCollectReward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B7F RID: 72575 RVA: 0x00297E80 File Offset: 0x00296080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.phantomCollectReward_ != null)
			{
				num ^= this.PhantomCollectReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011B80 RID: 72576 RVA: 0x00297ED5 File Offset: 0x002960D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B81 RID: 72577 RVA: 0x00297EE2 File Offset: 0x002960E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B82 RID: 72578 RVA: 0x00297EEC File Offset: 0x002960EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomCollectReward_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.PhantomCollectReward);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B83 RID: 72579 RVA: 0x00297F48 File Offset: 0x00296148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.phantomCollectReward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomCollectReward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011B84 RID: 72580 RVA: 0x00297FA0 File Offset: 0x002961A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomCollectUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.phantomCollectReward_ != null)
			{
				if (this.phantomCollectReward_ == null)
				{
					this.PhantomCollectReward = new PhantomCollectReward();
				}
				this.PhantomCollectReward.MergeFrom(other.PhantomCollectReward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011B85 RID: 72581 RVA: 0x00298008 File Offset: 0x00296208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B86 RID: 72582 RVA: 0x00298014 File Offset: 0x00296214
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomCollectReward_ == null)
					{
						this.PhantomCollectReward = new PhantomCollectReward();
					}
					input.ReadMessage(this.PhantomCollectReward);
				}
			}
		}

		// Token: 0x04006F66 RID: 28518
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F67 RID: 28519
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04006F68 RID: 28520
		private int activityId_;

		// Token: 0x04006F69 RID: 28521
		public const int PhantomCollectRewardFieldNumber = 2;

		// Token: 0x04006F6A RID: 28522
		private PhantomCollectReward phantomCollectReward_;
	}
}
