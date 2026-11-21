using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115A RID: 4442
	public sealed class RoverRogueSettleReward : IMessage<RoverRogueSettleReward>, IMessage, IEquatable<RoverRogueSettleReward>, IDeepCloneable<RoverRogueSettleReward>, IBufferMessage
	{
		// Token: 0x06017BD3 RID: 97235 RVA: 0x00374EE5 File Offset: 0x003730E5
		[NullableContext(1)]
		public static RoverRogueSettleReward Create()
		{
			return new RoverRogueSettleReward();
		}

		// Token: 0x17004FE9 RID: 20457
		// (get) Token: 0x06017BD4 RID: 97236 RVA: 0x00374EEC File Offset: 0x003730EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueSettleReward> Parser
		{
			get
			{
				return RoverRogueSettleReward._parser;
			}
		}

		// Token: 0x17004FEA RID: 20458
		// (get) Token: 0x06017BD5 RID: 97237 RVA: 0x00374EF3 File Offset: 0x003730F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEB RID: 20459
		// (get) Token: 0x06017BD6 RID: 97238 RVA: 0x00374EF6 File Offset: 0x003730F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueSettleReward.Descriptor;
			}
		}

		// Token: 0x06017BD7 RID: 97239 RVA: 0x00374EFD File Offset: 0x003730FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward()
		{
		}

		// Token: 0x06017BD8 RID: 97240 RVA: 0x00374F05 File Offset: 0x00373105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward(RoverRogueSettleReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BD9 RID: 97241 RVA: 0x00374F36 File Offset: 0x00373136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueSettleReward Clone()
		{
			return new RoverRogueSettleReward(this);
		}

		// Token: 0x17004FEC RID: 20460
		// (get) Token: 0x06017BDA RID: 97242 RVA: 0x00374F3E File Offset: 0x0037313E
		// (set) Token: 0x06017BDB RID: 97243 RVA: 0x00374F46 File Offset: 0x00373146
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

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x06017BDC RID: 97244 RVA: 0x00374F4F File Offset: 0x0037314F
		// (set) Token: 0x06017BDD RID: 97245 RVA: 0x00374F57 File Offset: 0x00373157
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

		// Token: 0x06017BDE RID: 97246 RVA: 0x00374F60 File Offset: 0x00373160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueSettleReward);
		}

		// Token: 0x06017BDF RID: 97247 RVA: 0x00374F6E File Offset: 0x0037316E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueSettleReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BE0 RID: 97248 RVA: 0x00374FAC File Offset: 0x003731AC
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

		// Token: 0x06017BE1 RID: 97249 RVA: 0x00375004 File Offset: 0x00373204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BE2 RID: 97250 RVA: 0x00375011 File Offset: 0x00373211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BE3 RID: 97251 RVA: 0x0037501C File Offset: 0x0037321C
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

		// Token: 0x06017BE4 RID: 97252 RVA: 0x00375074 File Offset: 0x00373274
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

		// Token: 0x06017BE5 RID: 97253 RVA: 0x003750CC File Offset: 0x003732CC
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

		// Token: 0x06017BE6 RID: 97254 RVA: 0x0037511C File Offset: 0x0037331C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BE7 RID: 97255 RVA: 0x00375128 File Offset: 0x00373328
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

		// Token: 0x04008DB6 RID: 36278
		private static readonly MessageParser<RoverRogueSettleReward> _parser = new MessageParser<RoverRogueSettleReward>(() => new RoverRogueSettleReward());

		// Token: 0x04008DB7 RID: 36279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DB8 RID: 36280
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04008DB9 RID: 36281
		private int itemId_;

		// Token: 0x04008DBA RID: 36282
		public const int NumFieldNumber = 2;

		// Token: 0x04008DBB RID: 36283
		private int num_;
	}
}
