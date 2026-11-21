using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F23 RID: 3875
	public sealed class RewardItem : IMessage<RewardItem>, IMessage, IEquatable<RewardItem>, IDeepCloneable<RewardItem>, IBufferMessage
	{
		// Token: 0x06014C3F RID: 85055 RVA: 0x00303EE8 File Offset: 0x003020E8
		[NullableContext(1)]
		public static RewardItem Create()
		{
			return new RewardItem();
		}

		// Token: 0x1700450D RID: 17677
		// (get) Token: 0x06014C40 RID: 85056 RVA: 0x00303EEF File Offset: 0x003020EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItem> Parser
		{
			get
			{
				return RewardItem._parser;
			}
		}

		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x06014C41 RID: 85057 RVA: 0x00303EF6 File Offset: 0x003020F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700450F RID: 17679
		// (get) Token: 0x06014C42 RID: 85058 RVA: 0x00303EF9 File Offset: 0x003020F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItem.Descriptor;
			}
		}

		// Token: 0x06014C43 RID: 85059 RVA: 0x00303F00 File Offset: 0x00302100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem()
		{
		}

		// Token: 0x06014C44 RID: 85060 RVA: 0x00303F08 File Offset: 0x00302108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem(RewardItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C45 RID: 85061 RVA: 0x00303F45 File Offset: 0x00302145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItem Clone()
		{
			return new RewardItem(this);
		}

		// Token: 0x17004510 RID: 17680
		// (get) Token: 0x06014C46 RID: 85062 RVA: 0x00303F4D File Offset: 0x0030214D
		// (set) Token: 0x06014C47 RID: 85063 RVA: 0x00303F55 File Offset: 0x00302155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17004511 RID: 17681
		// (get) Token: 0x06014C48 RID: 85064 RVA: 0x00303F5E File Offset: 0x0030215E
		// (set) Token: 0x06014C49 RID: 85065 RVA: 0x00303F66 File Offset: 0x00302166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17004512 RID: 17682
		// (get) Token: 0x06014C4A RID: 85066 RVA: 0x00303F6F File Offset: 0x0030216F
		// (set) Token: 0x06014C4B RID: 85067 RVA: 0x00303F77 File Offset: 0x00302177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x06014C4C RID: 85068 RVA: 0x00303F80 File Offset: 0x00302180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItem);
		}

		// Token: 0x06014C4D RID: 85069 RVA: 0x00303F90 File Offset: 0x00302190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C4E RID: 85070 RVA: 0x00303FEC File Offset: 0x003021EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C4F RID: 85071 RVA: 0x0030405D File Offset: 0x0030225D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C50 RID: 85072 RVA: 0x0030406A File Offset: 0x0030226A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C51 RID: 85073 RVA: 0x00304074 File Offset: 0x00302274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x003040E8 File Offset: 0x003022E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x00304158 File Offset: 0x00302358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x003041BC File Offset: 0x003023BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C55 RID: 85077 RVA: 0x003041C8 File Offset: 0x003023C8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IncrId = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007DD1 RID: 32209
		private static readonly MessageParser<RewardItem> _parser = new MessageParser<RewardItem>(() => new RewardItem());

		// Token: 0x04007DD2 RID: 32210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DD3 RID: 32211
		public const int IdFieldNumber = 1;

		// Token: 0x04007DD4 RID: 32212
		private int id_;

		// Token: 0x04007DD5 RID: 32213
		public const int CountFieldNumber = 2;

		// Token: 0x04007DD6 RID: 32214
		private int count_;

		// Token: 0x04007DD7 RID: 32215
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04007DD8 RID: 32216
		private int incrId_;
	}
}
