using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102F RID: 4143
	public sealed class RogueWeeklyOption : IMessage<RogueWeeklyOption>, IMessage, IEquatable<RogueWeeklyOption>, IDeepCloneable<RogueWeeklyOption>, IBufferMessage
	{
		// Token: 0x060162B5 RID: 90805 RVA: 0x00339293 File Offset: 0x00337493
		[NullableContext(1)]
		public static RogueWeeklyOption Create()
		{
			return new RogueWeeklyOption();
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x060162B6 RID: 90806 RVA: 0x0033929A File Offset: 0x0033749A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyOption> Parser
		{
			get
			{
				return RogueWeeklyOption._parser;
			}
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x060162B7 RID: 90807 RVA: 0x003392A1 File Offset: 0x003374A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x060162B8 RID: 90808 RVA: 0x003392A4 File Offset: 0x003374A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOption.Descriptor;
			}
		}

		// Token: 0x060162B9 RID: 90809 RVA: 0x003392AB File Offset: 0x003374AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption()
		{
		}

		// Token: 0x060162BA RID: 90810 RVA: 0x003392BE File Offset: 0x003374BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption(RogueWeeklyOption other) : this()
		{
			this.rogueWeeklyEntrys_ = other.rogueWeeklyEntrys_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060162BB RID: 90811 RVA: 0x003392F4 File Offset: 0x003374F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption Clone()
		{
			return new RogueWeeklyOption(this);
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x060162BC RID: 90812 RVA: 0x003392FC File Offset: 0x003374FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyEntry> RogueWeeklyEntrys
		{
			get
			{
				return this.rogueWeeklyEntrys_;
			}
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x060162BD RID: 90813 RVA: 0x00339304 File Offset: 0x00337504
		// (set) Token: 0x060162BE RID: 90814 RVA: 0x0033930C File Offset: 0x0033750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyEntryType Type
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

		// Token: 0x060162BF RID: 90815 RVA: 0x00339315 File Offset: 0x00337515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOption);
		}

		// Token: 0x060162C0 RID: 90816 RVA: 0x00339324 File Offset: 0x00337524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOption other)
		{
			return other != null && (other == this || (this.rogueWeeklyEntrys_.Equals(other.rogueWeeklyEntrys_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060162C1 RID: 90817 RVA: 0x00339374 File Offset: 0x00337574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueWeeklyEntrys_.GetHashCode();
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060162C2 RID: 90818 RVA: 0x003393C7 File Offset: 0x003375C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060162C3 RID: 90819 RVA: 0x003393D4 File Offset: 0x003375D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060162C4 RID: 90820 RVA: 0x003393E0 File Offset: 0x003375E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueWeeklyEntrys_.WriteTo(ref output, RogueWeeklyOption._repeated_rogueWeeklyEntrys_codec);
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060162C5 RID: 90821 RVA: 0x00339430 File Offset: 0x00337630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueWeeklyEntrys_.CalculateSize(RogueWeeklyOption._repeated_rogueWeeklyEntrys_codec);
			if (this.Type != RogueWeeklyEntryType.Unknow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060162C6 RID: 90822 RVA: 0x00339484 File Offset: 0x00337684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyOption other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueWeeklyEntrys_.Add(other.rogueWeeklyEntrys_);
			if (other.Type != RogueWeeklyEntryType.Unknow)
			{
				this.Type = other.Type;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060162C7 RID: 90823 RVA: 0x003394D1 File Offset: 0x003376D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060162C8 RID: 90824 RVA: 0x003394DC File Offset: 0x003376DC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Type = (RogueWeeklyEntryType)input.ReadEnum();
					}
				}
				else
				{
					this.rogueWeeklyEntrys_.AddEntriesFrom(ref input, RogueWeeklyOption._repeated_rogueWeeklyEntrys_codec);
				}
			}
		}

		// Token: 0x04008525 RID: 34085
		private static readonly MessageParser<RogueWeeklyOption> _parser = new MessageParser<RogueWeeklyOption>(() => new RogueWeeklyOption());

		// Token: 0x04008526 RID: 34086
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008527 RID: 34087
		public const int RogueWeeklyEntrysFieldNumber = 1;

		// Token: 0x04008528 RID: 34088
		private static readonly FieldCodec<RogueWeeklyEntry> _repeated_rogueWeeklyEntrys_codec = FieldCodec.ForMessage<RogueWeeklyEntry>(10U, RogueWeeklyEntry.Parser);

		// Token: 0x04008529 RID: 34089
		private readonly RepeatedField<RogueWeeklyEntry> rogueWeeklyEntrys_ = new RepeatedField<RogueWeeklyEntry>();

		// Token: 0x0400852A RID: 34090
		public const int TypeFieldNumber = 2;

		// Token: 0x0400852B RID: 34091
		private RogueWeeklyEntryType type_;
	}
}
