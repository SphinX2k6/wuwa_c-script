using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8D RID: 2957
	public sealed class OnePhantomSetting : IMessage<OnePhantomSetting>, IMessage, IEquatable<OnePhantomSetting>, IDeepCloneable<OnePhantomSetting>, IBufferMessage
	{
		// Token: 0x06010071 RID: 65649 RVA: 0x00256B59 File Offset: 0x00254D59
		[NullableContext(1)]
		public static OnePhantomSetting Create()
		{
			return new OnePhantomSetting();
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x06010072 RID: 65650 RVA: 0x00256B60 File Offset: 0x00254D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnePhantomSetting> Parser
		{
			get
			{
				return OnePhantomSetting._parser;
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x06010073 RID: 65651 RVA: 0x00256B67 File Offset: 0x00254D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x06010074 RID: 65652 RVA: 0x00256B6A File Offset: 0x00254D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnePhantomSetting.Descriptor;
			}
		}

		// Token: 0x06010075 RID: 65653 RVA: 0x00256B71 File Offset: 0x00254D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting()
		{
		}

		// Token: 0x06010076 RID: 65654 RVA: 0x00256B90 File Offset: 0x00254D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting(OnePhantomSetting other) : this()
		{
			this.index_ = other.index_;
			this.on_ = other.on_;
			this.name_ = other.name_;
			this.ruleList_ = other.ruleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010077 RID: 65655 RVA: 0x00256BE9 File Offset: 0x00254DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting Clone()
		{
			return new OnePhantomSetting(this);
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x06010078 RID: 65656 RVA: 0x00256BF1 File Offset: 0x00254DF1
		// (set) Token: 0x06010079 RID: 65657 RVA: 0x00256BF9 File Offset: 0x00254DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0601007A RID: 65658 RVA: 0x00256C02 File Offset: 0x00254E02
		// (set) Token: 0x0601007B RID: 65659 RVA: 0x00256C0A File Offset: 0x00254E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool On
		{
			get
			{
				return this.on_;
			}
			set
			{
				this.on_ = value;
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0601007C RID: 65660 RVA: 0x00256C13 File Offset: 0x00254E13
		// (set) Token: 0x0601007D RID: 65661 RVA: 0x00256C1B File Offset: 0x00254E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0601007E RID: 65662 RVA: 0x00256C2E File Offset: 0x00254E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneItemFilterRule> RuleList
		{
			get
			{
				return this.ruleList_;
			}
		}

		// Token: 0x0601007F RID: 65663 RVA: 0x00256C36 File Offset: 0x00254E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnePhantomSetting);
		}

		// Token: 0x06010080 RID: 65664 RVA: 0x00256C44 File Offset: 0x00254E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnePhantomSetting other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.On == other.On && !(this.Name != other.Name) && this.ruleList_.Equals(other.ruleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010081 RID: 65665 RVA: 0x00256CB8 File Offset: 0x00254EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.On)
			{
				num ^= this.On.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			num ^= this.ruleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010082 RID: 65666 RVA: 0x00256D39 File Offset: 0x00254F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010083 RID: 65667 RVA: 0x00256D46 File Offset: 0x00254F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010084 RID: 65668 RVA: 0x00256D50 File Offset: 0x00254F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			if (this.On)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.On);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Name);
			}
			this.ruleList_.WriteTo(ref output, OnePhantomSetting._repeated_ruleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010085 RID: 65669 RVA: 0x00256DDC File Offset: 0x00254FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.On)
			{
				num += 2;
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			num += this.ruleList_.CalculateSize(OnePhantomSetting._repeated_ruleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010086 RID: 65670 RVA: 0x00256E58 File Offset: 0x00255058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnePhantomSetting other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.On)
			{
				this.On = other.On;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this.ruleList_.Add(other.ruleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010087 RID: 65671 RVA: 0x00256ED2 File Offset: 0x002550D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010088 RID: 65672 RVA: 0x00256EDC File Offset: 0x002550DC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.On = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.ruleList_.AddEntriesFrom(ref input, OnePhantomSetting._repeated_ruleList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400662D RID: 26157
		private static readonly MessageParser<OnePhantomSetting> _parser = new MessageParser<OnePhantomSetting>(() => new OnePhantomSetting());

		// Token: 0x0400662E RID: 26158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400662F RID: 26159
		public const int IndexFieldNumber = 1;

		// Token: 0x04006630 RID: 26160
		private int index_;

		// Token: 0x04006631 RID: 26161
		public const int OnFieldNumber = 2;

		// Token: 0x04006632 RID: 26162
		private bool on_;

		// Token: 0x04006633 RID: 26163
		public const int NameFieldNumber = 3;

		// Token: 0x04006634 RID: 26164
		private string name_ = "";

		// Token: 0x04006635 RID: 26165
		public const int RuleListFieldNumber = 4;

		// Token: 0x04006636 RID: 26166
		private static readonly FieldCodec<OneItemFilterRule> _repeated_ruleList_codec = FieldCodec.ForMessage<OneItemFilterRule>(34U, OneItemFilterRule.Parser);

		// Token: 0x04006637 RID: 26167
		private readonly RepeatedField<OneItemFilterRule> ruleList_ = new RepeatedField<OneItemFilterRule>();
	}
}
