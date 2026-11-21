using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7D RID: 2941
	public sealed class OnePhantomSetting : IMessage<OnePhantomSetting>, IMessage, IEquatable<OnePhantomSetting>, IDeepCloneable<OnePhantomSetting>, IBufferMessage
	{
		// Token: 0x0600FF6D RID: 65389 RVA: 0x00254C89 File Offset: 0x00252E89
		[NullableContext(1)]
		public static OnePhantomSetting Create()
		{
			return new OnePhantomSetting();
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600FF6E RID: 65390 RVA: 0x00254C90 File Offset: 0x00252E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OnePhantomSetting> Parser
		{
			get
			{
				return OnePhantomSetting._parser;
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600FF6F RID: 65391 RVA: 0x00254C97 File Offset: 0x00252E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600FF70 RID: 65392 RVA: 0x00254C9A File Offset: 0x00252E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnePhantomSetting.Descriptor;
			}
		}

		// Token: 0x0600FF71 RID: 65393 RVA: 0x00254CA1 File Offset: 0x00252EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting()
		{
		}

		// Token: 0x0600FF72 RID: 65394 RVA: 0x00254CC0 File Offset: 0x00252EC0
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

		// Token: 0x0600FF73 RID: 65395 RVA: 0x00254D19 File Offset: 0x00252F19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnePhantomSetting Clone()
		{
			return new OnePhantomSetting(this);
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600FF74 RID: 65396 RVA: 0x00254D21 File Offset: 0x00252F21
		// (set) Token: 0x0600FF75 RID: 65397 RVA: 0x00254D29 File Offset: 0x00252F29
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

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600FF76 RID: 65398 RVA: 0x00254D32 File Offset: 0x00252F32
		// (set) Token: 0x0600FF77 RID: 65399 RVA: 0x00254D3A File Offset: 0x00252F3A
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

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600FF78 RID: 65400 RVA: 0x00254D43 File Offset: 0x00252F43
		// (set) Token: 0x0600FF79 RID: 65401 RVA: 0x00254D4B File Offset: 0x00252F4B
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

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600FF7A RID: 65402 RVA: 0x00254D5E File Offset: 0x00252F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneItemFilterRule> RuleList
		{
			get
			{
				return this.ruleList_;
			}
		}

		// Token: 0x0600FF7B RID: 65403 RVA: 0x00254D66 File Offset: 0x00252F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnePhantomSetting);
		}

		// Token: 0x0600FF7C RID: 65404 RVA: 0x00254D74 File Offset: 0x00252F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnePhantomSetting other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.On == other.On && !(this.Name != other.Name) && this.ruleList_.Equals(other.ruleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF7D RID: 65405 RVA: 0x00254DE8 File Offset: 0x00252FE8
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

		// Token: 0x0600FF7E RID: 65406 RVA: 0x00254E69 File Offset: 0x00253069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF7F RID: 65407 RVA: 0x00254E76 File Offset: 0x00253076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF80 RID: 65408 RVA: 0x00254E80 File Offset: 0x00253080
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

		// Token: 0x0600FF81 RID: 65409 RVA: 0x00254F0C File Offset: 0x0025310C
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

		// Token: 0x0600FF82 RID: 65410 RVA: 0x00254F88 File Offset: 0x00253188
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

		// Token: 0x0600FF83 RID: 65411 RVA: 0x00255002 File Offset: 0x00253202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF84 RID: 65412 RVA: 0x0025500C File Offset: 0x0025320C
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

		// Token: 0x0400663D RID: 26173
		private static readonly MessageParser<OnePhantomSetting> _parser = new MessageParser<OnePhantomSetting>(() => new OnePhantomSetting());

		// Token: 0x0400663E RID: 26174
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400663F RID: 26175
		public const int IndexFieldNumber = 1;

		// Token: 0x04006640 RID: 26176
		private int index_;

		// Token: 0x04006641 RID: 26177
		public const int OnFieldNumber = 2;

		// Token: 0x04006642 RID: 26178
		private bool on_;

		// Token: 0x04006643 RID: 26179
		public const int NameFieldNumber = 3;

		// Token: 0x04006644 RID: 26180
		private string name_ = "";

		// Token: 0x04006645 RID: 26181
		public const int RuleListFieldNumber = 4;

		// Token: 0x04006646 RID: 26182
		private static readonly FieldCodec<OneItemFilterRule> _repeated_ruleList_codec = FieldCodec.ForMessage<OneItemFilterRule>(34U, OneItemFilterRule.Parser);

		// Token: 0x04006647 RID: 26183
		private readonly RepeatedField<OneItemFilterRule> ruleList_ = new RepeatedField<OneItemFilterRule>();
	}
}
