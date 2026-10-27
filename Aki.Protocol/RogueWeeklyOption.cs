using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103F RID: 4159
	public sealed class RogueWeeklyOption : IMessage<RogueWeeklyOption>, IMessage, IEquatable<RogueWeeklyOption>, IDeepCloneable<RogueWeeklyOption>, IBufferMessage
	{
		// Token: 0x0601639A RID: 91034 RVA: 0x0033A963 File Offset: 0x00338B63
		[NullableContext(1)]
		public static RogueWeeklyOption Create()
		{
			return new RogueWeeklyOption();
		}

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x0601639B RID: 91035 RVA: 0x0033A96A File Offset: 0x00338B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueWeeklyOption> Parser
		{
			get
			{
				return RogueWeeklyOption._parser;
			}
		}

		// Token: 0x17004A4E RID: 19022
		// (get) Token: 0x0601639C RID: 91036 RVA: 0x0033A971 File Offset: 0x00338B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A4F RID: 19023
		// (get) Token: 0x0601639D RID: 91037 RVA: 0x0033A974 File Offset: 0x00338B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyOption.Descriptor;
			}
		}

		// Token: 0x0601639E RID: 91038 RVA: 0x0033A97B File Offset: 0x00338B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption()
		{
		}

		// Token: 0x0601639F RID: 91039 RVA: 0x0033A98E File Offset: 0x00338B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption(RogueWeeklyOption other) : this()
		{
			this.rogueWeeklyEntrys_ = other.rogueWeeklyEntrys_.Clone();
			this.type_ = other.type_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060163A0 RID: 91040 RVA: 0x0033A9C4 File Offset: 0x00338BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyOption Clone()
		{
			return new RogueWeeklyOption(this);
		}

		// Token: 0x17004A50 RID: 19024
		// (get) Token: 0x060163A1 RID: 91041 RVA: 0x0033A9CC File Offset: 0x00338BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueWeeklyEntry> RogueWeeklyEntrys
		{
			get
			{
				return this.rogueWeeklyEntrys_;
			}
		}

		// Token: 0x17004A51 RID: 19025
		// (get) Token: 0x060163A2 RID: 91042 RVA: 0x0033A9D4 File Offset: 0x00338BD4
		// (set) Token: 0x060163A3 RID: 91043 RVA: 0x0033A9DC File Offset: 0x00338BDC
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

		// Token: 0x060163A4 RID: 91044 RVA: 0x0033A9E5 File Offset: 0x00338BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyOption);
		}

		// Token: 0x060163A5 RID: 91045 RVA: 0x0033A9F4 File Offset: 0x00338BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyOption other)
		{
			return other != null && (other == this || (this.rogueWeeklyEntrys_.Equals(other.rogueWeeklyEntrys_) && this.Type == other.Type && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060163A6 RID: 91046 RVA: 0x0033AA44 File Offset: 0x00338C44
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

		// Token: 0x060163A7 RID: 91047 RVA: 0x0033AA97 File Offset: 0x00338C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060163A8 RID: 91048 RVA: 0x0033AAA4 File Offset: 0x00338CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060163A9 RID: 91049 RVA: 0x0033AAB0 File Offset: 0x00338CB0
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

		// Token: 0x060163AA RID: 91050 RVA: 0x0033AB00 File Offset: 0x00338D00
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

		// Token: 0x060163AB RID: 91051 RVA: 0x0033AB54 File Offset: 0x00338D54
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

		// Token: 0x060163AC RID: 91052 RVA: 0x0033ABA1 File Offset: 0x00338DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060163AD RID: 91053 RVA: 0x0033ABAC File Offset: 0x00338DAC
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

		// Token: 0x040084FB RID: 34043
		private static readonly MessageParser<RogueWeeklyOption> _parser = new MessageParser<RogueWeeklyOption>(() => new RogueWeeklyOption());

		// Token: 0x040084FC RID: 34044
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084FD RID: 34045
		public const int RogueWeeklyEntrysFieldNumber = 1;

		// Token: 0x040084FE RID: 34046
		private static readonly FieldCodec<RogueWeeklyEntry> _repeated_rogueWeeklyEntrys_codec = FieldCodec.ForMessage<RogueWeeklyEntry>(10U, RogueWeeklyEntry.Parser);

		// Token: 0x040084FF RID: 34047
		private readonly RepeatedField<RogueWeeklyEntry> rogueWeeklyEntrys_ = new RepeatedField<RogueWeeklyEntry>();

		// Token: 0x04008500 RID: 34048
		public const int TypeFieldNumber = 2;

		// Token: 0x04008501 RID: 34049
		private RogueWeeklyEntryType type_;
	}
}
