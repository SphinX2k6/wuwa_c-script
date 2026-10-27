using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AB RID: 4523
	public sealed class SeasonReward : IMessage<SeasonReward>, IMessage, IEquatable<SeasonReward>, IDeepCloneable<SeasonReward>, IBufferMessage
	{
		// Token: 0x0601819D RID: 98717 RVA: 0x0038012A File Offset: 0x0037E32A
		[NullableContext(1)]
		public static SeasonReward Create()
		{
			return new SeasonReward();
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x0601819E RID: 98718 RVA: 0x00380131 File Offset: 0x0037E331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SeasonReward> Parser
		{
			get
			{
				return SeasonReward._parser;
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x0601819F RID: 98719 RVA: 0x00380138 File Offset: 0x0037E338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x060181A0 RID: 98720 RVA: 0x0038013B File Offset: 0x0037E33B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SeasonReward.Descriptor;
			}
		}

		// Token: 0x060181A1 RID: 98721 RVA: 0x00380142 File Offset: 0x0037E342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward()
		{
		}

		// Token: 0x060181A2 RID: 98722 RVA: 0x0038014A File Offset: 0x0037E34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward(SeasonReward other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060181A3 RID: 98723 RVA: 0x0038017B File Offset: 0x0037E37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SeasonReward Clone()
		{
			return new SeasonReward(this);
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x060181A4 RID: 98724 RVA: 0x00380183 File Offset: 0x0037E383
		// (set) Token: 0x060181A5 RID: 98725 RVA: 0x0038018B File Offset: 0x0037E38B
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

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x060181A6 RID: 98726 RVA: 0x00380194 File Offset: 0x0037E394
		// (set) Token: 0x060181A7 RID: 98727 RVA: 0x0038019C File Offset: 0x0037E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x060181A8 RID: 98728 RVA: 0x003801A5 File Offset: 0x0037E3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SeasonReward);
		}

		// Token: 0x060181A9 RID: 98729 RVA: 0x003801B3 File Offset: 0x0037E3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SeasonReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060181AA RID: 98730 RVA: 0x003801F4 File Offset: 0x0037E3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060181AB RID: 98731 RVA: 0x0038024C File Offset: 0x0037E44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060181AC RID: 98732 RVA: 0x00380259 File Offset: 0x0037E459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060181AD RID: 98733 RVA: 0x00380264 File Offset: 0x0037E464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReceive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060181AE RID: 98734 RVA: 0x003802BC File Offset: 0x0037E4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060181AF RID: 98735 RVA: 0x00380308 File Offset: 0x0037E508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SeasonReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060181B0 RID: 98736 RVA: 0x00380358 File Offset: 0x0037E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060181B1 RID: 98737 RVA: 0x00380364 File Offset: 0x0037E564
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
						this.IsReceive = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008EA6 RID: 36518
		private static readonly MessageParser<SeasonReward> _parser = new MessageParser<SeasonReward>(() => new SeasonReward());

		// Token: 0x04008EA7 RID: 36519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008EA8 RID: 36520
		public const int IdFieldNumber = 1;

		// Token: 0x04008EA9 RID: 36521
		private int id_;

		// Token: 0x04008EAA RID: 36522
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x04008EAB RID: 36523
		private bool isReceive_;
	}
}
