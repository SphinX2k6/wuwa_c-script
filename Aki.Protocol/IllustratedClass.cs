using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B0 RID: 1968
	public sealed class IllustratedClass : IMessage<IllustratedClass>, IMessage, IEquatable<IllustratedClass>, IDeepCloneable<IllustratedClass>, IBufferMessage
	{
		// Token: 0x0600B182 RID: 45442 RVA: 0x001A9877 File Offset: 0x001A7A77
		[NullableContext(1)]
		public static IllustratedClass Create()
		{
			return new IllustratedClass();
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x0600B183 RID: 45443 RVA: 0x001A987E File Offset: 0x001A7A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IllustratedClass> Parser
		{
			get
			{
				return IllustratedClass._parser;
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x0600B184 RID: 45444 RVA: 0x001A9885 File Offset: 0x001A7A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x0600B185 RID: 45445 RVA: 0x001A9888 File Offset: 0x001A7A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedClass.Descriptor;
			}
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x001A988F File Offset: 0x001A7A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass()
		{
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x001A98A2 File Offset: 0x001A7AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass(IllustratedClass other) : this()
		{
			this.type_ = other.type_;
			this.illustratedEntryList_ = other.illustratedEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x001A98D8 File Offset: 0x001A7AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedClass Clone()
		{
			return new IllustratedClass(this);
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x0600B189 RID: 45449 RVA: 0x001A98E0 File Offset: 0x001A7AE0
		// (set) Token: 0x0600B18A RID: 45450 RVA: 0x001A98E8 File Offset: 0x001A7AE8
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

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x0600B18B RID: 45451 RVA: 0x001A98F1 File Offset: 0x001A7AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IllustratedEntry> IllustratedEntryList
		{
			get
			{
				return this.illustratedEntryList_;
			}
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x001A98F9 File Offset: 0x001A7AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedClass);
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x001A9908 File Offset: 0x001A7B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedClass other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.illustratedEntryList_.Equals(other.illustratedEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x001A9958 File Offset: 0x001A7B58
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

		// Token: 0x0600B18F RID: 45455 RVA: 0x001A99AB File Offset: 0x001A7BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x001A99B8 File Offset: 0x001A7BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x001A99C4 File Offset: 0x001A7BC4
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

		// Token: 0x0600B192 RID: 45458 RVA: 0x001A9A14 File Offset: 0x001A7C14
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

		// Token: 0x0600B193 RID: 45459 RVA: 0x001A9A68 File Offset: 0x001A7C68
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

		// Token: 0x0600B194 RID: 45460 RVA: 0x001A9AB5 File Offset: 0x001A7CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x001A9AC0 File Offset: 0x001A7CC0
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

		// Token: 0x04004FD7 RID: 20439
		private static readonly MessageParser<IllustratedClass> _parser = new MessageParser<IllustratedClass>(() => new IllustratedClass());

		// Token: 0x04004FD8 RID: 20440
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FD9 RID: 20441
		public const int TypeFieldNumber = 1;

		// Token: 0x04004FDA RID: 20442
		private IllustratedType type_;

		// Token: 0x04004FDB RID: 20443
		public const int IllustratedEntryListFieldNumber = 2;

		// Token: 0x04004FDC RID: 20444
		private static readonly FieldCodec<IllustratedEntry> _repeated_illustratedEntryList_codec = FieldCodec.ForMessage<IllustratedEntry>(18U, IllustratedEntry.Parser);

		// Token: 0x04004FDD RID: 20445
		private readonly RepeatedField<IllustratedEntry> illustratedEntryList_ = new RepeatedField<IllustratedEntry>();
	}
}
