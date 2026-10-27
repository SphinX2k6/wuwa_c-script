using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000671 RID: 1649
	[NetMessage(EMessageId.FsmStateBehaviorRequest)]
	public sealed class FsmStateBehaviorRequest : IMessage<FsmStateBehaviorRequest>, IMessage, IEquatable<FsmStateBehaviorRequest>, IDeepCloneable<FsmStateBehaviorRequest>, IBufferMessage
	{
		// Token: 0x06009735 RID: 38709 RVA: 0x0016CB50 File Offset: 0x0016AD50
		[NullableContext(1)]
		public static FsmStateBehaviorRequest Create()
		{
			return new FsmStateBehaviorRequest();
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06009736 RID: 38710 RVA: 0x0016CB57 File Offset: 0x0016AD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06009737 RID: 38711 RVA: 0x0016CB5A File Offset: 0x0016AD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmStateBehaviorRequest.Descriptor;
			}
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x0016CB61 File Offset: 0x0016AD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest()
		{
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x0016CB6C File Offset: 0x0016AD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest(FsmStateBehaviorRequest other) : this()
		{
			this.fsmId_ = other.fsmId_;
			this.state_ = other.state_;
			this.index_ = other.index_;
			this.behaviorType_ = other.behaviorType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x0016CBC0 File Offset: 0x0016ADC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorRequest Clone()
		{
			return new FsmStateBehaviorRequest(this);
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600973B RID: 38715 RVA: 0x0016CBC8 File Offset: 0x0016ADC8
		// (set) Token: 0x0600973C RID: 38716 RVA: 0x0016CBD0 File Offset: 0x0016ADD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FsmId
		{
			get
			{
				return this.fsmId_;
			}
			set
			{
				this.fsmId_ = value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600973D RID: 38717 RVA: 0x0016CBD9 File Offset: 0x0016ADD9
		// (set) Token: 0x0600973E RID: 38718 RVA: 0x0016CBE1 File Offset: 0x0016ADE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600973F RID: 38719 RVA: 0x0016CBEA File Offset: 0x0016ADEA
		// (set) Token: 0x06009740 RID: 38720 RVA: 0x0016CBF2 File Offset: 0x0016ADF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06009741 RID: 38721 RVA: 0x0016CBFB File Offset: 0x0016ADFB
		// (set) Token: 0x06009742 RID: 38722 RVA: 0x0016CC03 File Offset: 0x0016AE03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmStateBehaviorType BehaviorType
		{
			get
			{
				return this.behaviorType_;
			}
			set
			{
				this.behaviorType_ = value;
			}
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x0016CC0C File Offset: 0x0016AE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmStateBehaviorRequest);
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0016CC1C File Offset: 0x0016AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmStateBehaviorRequest other)
		{
			return other != null && (other == this || (this.FsmId == other.FsmId && this.State == other.State && this.Index == other.Index && this.BehaviorType == other.BehaviorType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x0016CC88 File Offset: 0x0016AE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FsmId != 0)
			{
				num ^= this.FsmId.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				num ^= this.BehaviorType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0016CD18 File Offset: 0x0016AF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x0016CD25 File Offset: 0x0016AF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x0016CD30 File Offset: 0x0016AF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FsmId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.FsmId);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.State);
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.BehaviorType);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0016CDC4 File Offset: 0x0016AFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FsmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FsmId);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BehaviorType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x0016CE4C File Offset: 0x0016B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmStateBehaviorRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FsmId != 0)
			{
				this.FsmId = other.FsmId;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.BehaviorType != FsmStateBehaviorType.BtEnter)
			{
				this.BehaviorType = other.BehaviorType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x0016CEC4 File Offset: 0x0016B0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0016CED0 File Offset: 0x0016B0D0
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
				if (num <= 80U)
				{
					if (num == 40U)
					{
						this.FsmId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.BehaviorType = (FsmStateBehaviorType)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040047EA RID: 18410
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047EB RID: 18411
		public const int FsmIdFieldNumber = 5;

		// Token: 0x040047EC RID: 18412
		private int fsmId_;

		// Token: 0x040047ED RID: 18413
		public const int StateFieldNumber = 10;

		// Token: 0x040047EE RID: 18414
		private int state_;

		// Token: 0x040047EF RID: 18415
		public const int IndexFieldNumber = 15;

		// Token: 0x040047F0 RID: 18416
		private int index_;

		// Token: 0x040047F1 RID: 18417
		public const int BehaviorTypeFieldNumber = 13;

		// Token: 0x040047F2 RID: 18418
		private FsmStateBehaviorType behaviorType_;
	}
}
