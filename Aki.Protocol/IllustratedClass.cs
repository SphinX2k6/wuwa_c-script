using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007C4 RID: 1988
	public sealed class IllustratedClass : IMessage<IllustratedClass>, IMessage, IEquatable<IllustratedClass>, IDeepCloneable<IllustratedClass>, IBufferMessage
	{
		// Token: 0x0600B2D8 RID: 45784 RVA: 0x001AC2A7 File Offset: 0x001AA4A7
		[NullableContext(1)]
		public static IllustratedClass Create()
		{
			return new IllustratedClass();
		}

		// Token: 0x17002415 RID: 9237
		// (get) Token: 0x0600B2D9 RID: 45785 RVA: 0x001AC2AE File Offset: 0x001AA4AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IllustratedClass> Parser
		{
			get
			{
				return IllustratedClass._parser;
			}
		}

		// Token: 0x17002416 RID: 9238
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x001AC2B5 File Offset: 0x001AA4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002417 RID: 9239
		// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x001AC2B8 File Offset: 0x001AA4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedClass.Descriptor;
			}
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x001AC2BF File Offset: 0x001AA4BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass()
		{
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x001AC2D2 File Offset: 0x001AA4D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass(IllustratedClass other) : this()
		{
			this.type_ = other.type_;
			this.illustratedEntryList_ = other.illustratedEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x001AC308 File Offset: 0x001AA508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass Clone()
		{
			return new IllustratedClass(this);
		}

		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x0600B2DF RID: 45791 RVA: 0x001AC310 File Offset: 0x001AA510
		// (set) Token: 0x0600B2E0 RID: 45792 RVA: 0x001AC318 File Offset: 0x001AA518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedType Type
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

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x0600B2E1 RID: 45793 RVA: 0x001AC321 File Offset: 0x001AA521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedEntry> IllustratedEntryList
		{
			get
			{
				return this.illustratedEntryList_;
			}
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x001AC329 File Offset: 0x001AA529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedClass);
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x001AC338 File Offset: 0x001AA538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedClass other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.illustratedEntryList_.Equals(other.illustratedEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x001AC388 File Offset: 0x001AA588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != IllustratedType.Monster)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.illustratedEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x001AC3DB File Offset: 0x001AA5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x001AC3E8 File Offset: 0x001AA5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x001AC3F4 File Offset: 0x001AA5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			this.illustratedEntryList_.WriteTo(ref output, IllustratedClass._repeated_illustratedEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x001AC444 File Offset: 0x001AA644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != IllustratedType.Monster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			num += this.illustratedEntryList_.CalculateSize(IllustratedClass._repeated_illustratedEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x001AC498 File Offset: 0x001AA698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedClass other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != IllustratedType.Monster)
			{
				this.Type = other.Type;
			}
			this.illustratedEntryList_.Add(other.illustratedEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x001AC4E5 File Offset: 0x001AA6E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x001AC4F0 File Offset: 0x001AA6F0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.illustratedEntryList_.AddEntriesFrom(ref input, IllustratedClass._repeated_illustratedEntryList_codec);
					}
				}
				else
				{
					this.Type = (IllustratedType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FDE RID: 20446
		private static readonly MessageParser<IllustratedClass> _parser = new MessageParser<IllustratedClass>(() => new IllustratedClass());

		// Token: 0x04004FDF RID: 20447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FE0 RID: 20448
		public const int TypeFieldNumber = 1;

		// Token: 0x04004FE1 RID: 20449
		private IllustratedType type_;

		// Token: 0x04004FE2 RID: 20450
		public const int IllustratedEntryListFieldNumber = 2;

		// Token: 0x04004FE3 RID: 20451
		private static readonly FieldCodec<IllustratedEntry> _repeated_illustratedEntryList_codec = FieldCodec.ForMessage<IllustratedEntry>(18U, IllustratedEntry.Parser);

		// Token: 0x04004FE4 RID: 20452
		private readonly RepeatedField<IllustratedEntry> illustratedEntryList_ = new RepeatedField<IllustratedEntry>();
	}
}
