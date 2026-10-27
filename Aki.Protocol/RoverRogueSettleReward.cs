using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001120 RID: 4384
	public sealed class RoverRogueSettleReward : IMessage<RoverRogueSettleReward>, IMessage, IEquatable<RoverRogueSettleReward>, IDeepCloneable<RoverRogueSettleReward>, IBufferMessage
	{
		// Token: 0x06017632 RID: 95794 RVA: 0x00365B99 File Offset: 0x00363D99
		[NullableContext(1)]
		public static RoverRogueSettleReward Create()
		{
			return new RoverRogueSettleReward();
		}

		// Token: 0x17004E7D RID: 20093
		// (get) Token: 0x06017633 RID: 95795 RVA: 0x00365BA0 File Offset: 0x00363DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueSettleReward> Parser
		{
			get
			{
				return RoverRogueSettleReward._parser;
			}
		}

		// Token: 0x17004E7E RID: 20094
		// (get) Token: 0x06017634 RID: 95796 RVA: 0x00365BA7 File Offset: 0x00363DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E7F RID: 20095
		// (get) Token: 0x06017635 RID: 95797 RVA: 0x00365BAA File Offset: 0x00363DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueSettleReward.Descriptor;
			}
		}

		// Token: 0x06017636 RID: 95798 RVA: 0x00365BB1 File Offset: 0x00363DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward()
		{
		}

		// Token: 0x06017637 RID: 95799 RVA: 0x00365BB9 File Offset: 0x00363DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward(RoverRogueSettleReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017638 RID: 95800 RVA: 0x00365BEA File Offset: 0x00363DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward Clone()
		{
			return new RoverRogueSettleReward(this);
		}

		// Token: 0x17004E80 RID: 20096
		// (get) Token: 0x06017639 RID: 95801 RVA: 0x00365BF2 File Offset: 0x00363DF2
		// (set) Token: 0x0601763A RID: 95802 RVA: 0x00365BFA File Offset: 0x00363DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004E81 RID: 20097
		// (get) Token: 0x0601763B RID: 95803 RVA: 0x00365C03 File Offset: 0x00363E03
		// (set) Token: 0x0601763C RID: 95804 RVA: 0x00365C0B File Offset: 0x00363E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x0601763D RID: 95805 RVA: 0x00365C14 File Offset: 0x00363E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueSettleReward);
		}

		// Token: 0x0601763E RID: 95806 RVA: 0x00365C22 File Offset: 0x00363E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueSettleReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601763F RID: 95807 RVA: 0x00365C60 File Offset: 0x00363E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Num != 0)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017640 RID: 95808 RVA: 0x00365CB8 File Offset: 0x00363EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017641 RID: 95809 RVA: 0x00365CC5 File Offset: 0x00363EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017642 RID: 95810 RVA: 0x00365CD0 File Offset: 0x00363ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Num != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017643 RID: 95811 RVA: 0x00365D28 File Offset: 0x00363F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Num != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017644 RID: 95812 RVA: 0x00365D80 File Offset: 0x00363F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueSettleReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Num != 0)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017645 RID: 95813 RVA: 0x00365DD0 File Offset: 0x00363FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017646 RID: 95814 RVA: 0x00365DDC File Offset: 0x00363FDC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008B23 RID: 35619
		private static readonly MessageParser<RoverRogueSettleReward> _parser = new MessageParser<RoverRogueSettleReward>(() => new RoverRogueSettleReward());

		// Token: 0x04008B24 RID: 35620
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B25 RID: 35621
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04008B26 RID: 35622
		private int itemId_;

		// Token: 0x04008B27 RID: 35623
		public const int NumFieldNumber = 2;

		// Token: 0x04008B28 RID: 35624
		private int num_;
	}
}
