using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001153 RID: 4435
	public sealed class RoverRogueResourcesItem : IMessage<RoverRogueResourcesItem>, IMessage, IEquatable<RoverRogueResourcesItem>, IDeepCloneable<RoverRogueResourcesItem>, IBufferMessage
	{
		// Token: 0x06017B17 RID: 97047 RVA: 0x00372A27 File Offset: 0x00370C27
		[NullableContext(1)]
		public static RoverRogueResourcesItem Create()
		{
			return new RoverRogueResourcesItem();
		}

		// Token: 0x17004FB2 RID: 20402
		// (get) Token: 0x06017B18 RID: 97048 RVA: 0x00372A2E File Offset: 0x00370C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueResourcesItem> Parser
		{
			get
			{
				return RoverRogueResourcesItem._parser;
			}
		}

		// Token: 0x17004FB3 RID: 20403
		// (get) Token: 0x06017B19 RID: 97049 RVA: 0x00372A35 File Offset: 0x00370C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FB4 RID: 20404
		// (get) Token: 0x06017B1A RID: 97050 RVA: 0x00372A38 File Offset: 0x00370C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResourcesItem.Descriptor;
			}
		}

		// Token: 0x06017B1B RID: 97051 RVA: 0x00372A3F File Offset: 0x00370C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem()
		{
		}

		// Token: 0x06017B1C RID: 97052 RVA: 0x00372A47 File Offset: 0x00370C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem(RoverRogueResourcesItem other) : this()
		{
			this.confId_ = other.confId_;
			this.roundNum_ = other.roundNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017B1D RID: 97053 RVA: 0x00372A78 File Offset: 0x00370C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesItem Clone()
		{
			return new RoverRogueResourcesItem(this);
		}

		// Token: 0x17004FB5 RID: 20405
		// (get) Token: 0x06017B1E RID: 97054 RVA: 0x00372A80 File Offset: 0x00370C80
		// (set) Token: 0x06017B1F RID: 97055 RVA: 0x00372A88 File Offset: 0x00370C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfId
		{
			get
			{
				return this.confId_;
			}
			set
			{
				this.confId_ = value;
			}
		}

		// Token: 0x17004FB6 RID: 20406
		// (get) Token: 0x06017B20 RID: 97056 RVA: 0x00372A91 File Offset: 0x00370C91
		// (set) Token: 0x06017B21 RID: 97057 RVA: 0x00372A99 File Offset: 0x00370C99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x06017B22 RID: 97058 RVA: 0x00372AA2 File Offset: 0x00370CA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResourcesItem);
		}

		// Token: 0x06017B23 RID: 97059 RVA: 0x00372AB0 File Offset: 0x00370CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResourcesItem other)
		{
			return other != null && (other == this || (this.ConfId == other.ConfId && this.RoundNum == other.RoundNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B24 RID: 97060 RVA: 0x00372AF0 File Offset: 0x00370CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfId != 0)
			{
				num ^= this.ConfId.GetHashCode();
			}
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017B25 RID: 97061 RVA: 0x00372B48 File Offset: 0x00370D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B26 RID: 97062 RVA: 0x00372B55 File Offset: 0x00370D55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B27 RID: 97063 RVA: 0x00372B60 File Offset: 0x00370D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfId);
			}
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B28 RID: 97064 RVA: 0x00372BB8 File Offset: 0x00370DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfId);
			}
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017B29 RID: 97065 RVA: 0x00372C10 File Offset: 0x00370E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResourcesItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfId != 0)
			{
				this.ConfId = other.ConfId;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017B2A RID: 97066 RVA: 0x00372C60 File Offset: 0x00370E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B2B RID: 97067 RVA: 0x00372C6C File Offset: 0x00370E6C
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
						this.RoundNum = input.ReadInt32();
					}
				}
				else
				{
					this.ConfId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008D55 RID: 36181
		private static readonly MessageParser<RoverRogueResourcesItem> _parser = new MessageParser<RoverRogueResourcesItem>(() => new RoverRogueResourcesItem());

		// Token: 0x04008D56 RID: 36182
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D57 RID: 36183
		public const int ConfIdFieldNumber = 1;

		// Token: 0x04008D58 RID: 36184
		private int confId_;

		// Token: 0x04008D59 RID: 36185
		public const int RoundNumFieldNumber = 2;

		// Token: 0x04008D5A RID: 36186
		private int roundNum_;
	}
}
