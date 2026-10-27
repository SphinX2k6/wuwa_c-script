using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EA RID: 1514
	public sealed class FloroRanchSubInsSettleReward : IMessage<FloroRanchSubInsSettleReward>, IMessage, IEquatable<FloroRanchSubInsSettleReward>, IDeepCloneable<FloroRanchSubInsSettleReward>, IBufferMessage
	{
		// Token: 0x06008C18 RID: 35864 RVA: 0x00152F82 File Offset: 0x00151182
		[NullableContext(1)]
		public static FloroRanchSubInsSettleReward Create()
		{
			return new FloroRanchSubInsSettleReward();
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06008C19 RID: 35865 RVA: 0x00152F89 File Offset: 0x00151189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FloroRanchSubInsSettleReward> Parser
		{
			get
			{
				return FloroRanchSubInsSettleReward._parser;
			}
		}

		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06008C1A RID: 35866 RVA: 0x00152F90 File Offset: 0x00151190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06008C1B RID: 35867 RVA: 0x00152F93 File Offset: 0x00151193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchSubInsSettleReward.Descriptor;
			}
		}

		// Token: 0x06008C1C RID: 35868 RVA: 0x00152F9A File Offset: 0x0015119A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward()
		{
		}

		// Token: 0x06008C1D RID: 35869 RVA: 0x00152FA2 File Offset: 0x001511A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward(FloroRanchSubInsSettleReward other) : this()
		{
			this.type_ = other.type_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008C1E RID: 35870 RVA: 0x00152FD3 File Offset: 0x001511D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchSubInsSettleReward Clone()
		{
			return new FloroRanchSubInsSettleReward(this);
		}

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06008C1F RID: 35871 RVA: 0x00152FDB File Offset: 0x001511DB
		// (set) Token: 0x06008C20 RID: 35872 RVA: 0x00152FE3 File Offset: 0x001511E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SubInsSettleRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06008C21 RID: 35873 RVA: 0x00152FEC File Offset: 0x001511EC
		// (set) Token: 0x06008C22 RID: 35874 RVA: 0x00152FF4 File Offset: 0x001511F4
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

		// Token: 0x06008C23 RID: 35875 RVA: 0x00152FFD File Offset: 0x001511FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchSubInsSettleReward);
		}

		// Token: 0x06008C24 RID: 35876 RVA: 0x0015300B File Offset: 0x0015120B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchSubInsSettleReward other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008C25 RID: 35877 RVA: 0x0015304C File Offset: 0x0015124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008C26 RID: 35878 RVA: 0x001530AA File Offset: 0x001512AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008C27 RID: 35879 RVA: 0x001530B7 File Offset: 0x001512B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008C28 RID: 35880 RVA: 0x001530C0 File Offset: 0x001512C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008C29 RID: 35881 RVA: 0x00153118 File Offset: 0x00151318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008C2A RID: 35882 RVA: 0x00153170 File Offset: 0x00151370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchSubInsSettleReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != SubInsSettleRewardType.FloroRanchSkill)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008C2B RID: 35883 RVA: 0x001531C0 File Offset: 0x001513C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008C2C RID: 35884 RVA: 0x001531CC File Offset: 0x001513CC
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.Type = (SubInsSettleRewardType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040044A1 RID: 17569
		private static readonly MessageParser<FloroRanchSubInsSettleReward> _parser = new MessageParser<FloroRanchSubInsSettleReward>(() => new FloroRanchSubInsSettleReward());

		// Token: 0x040044A2 RID: 17570
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044A3 RID: 17571
		public const int TypeFieldNumber = 1;

		// Token: 0x040044A4 RID: 17572
		private SubInsSettleRewardType type_;

		// Token: 0x040044A5 RID: 17573
		public const int IdFieldNumber = 2;

		// Token: 0x040044A6 RID: 17574
		private int id_;
	}
}
