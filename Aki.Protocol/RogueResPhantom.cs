using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFF RID: 4095
	public sealed class RogueResPhantom : IMessage<RogueResPhantom>, IMessage, IEquatable<RogueResPhantom>, IDeepCloneable<RogueResPhantom>, IBufferMessage
	{
		// Token: 0x06015E4F RID: 89679 RVA: 0x0032EA96 File Offset: 0x0032CC96
		[NullableContext(1)]
		public static RogueResPhantom Create()
		{
			return new RogueResPhantom();
		}

		// Token: 0x17004923 RID: 18723
		// (get) Token: 0x06015E50 RID: 89680 RVA: 0x0032EA9D File Offset: 0x0032CC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004924 RID: 18724
		// (get) Token: 0x06015E51 RID: 89681 RVA: 0x0032EAA0 File Offset: 0x0032CCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResPhantom.Descriptor;
			}
		}

		// Token: 0x06015E52 RID: 89682 RVA: 0x0032EAA7 File Offset: 0x0032CCA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom()
		{
		}

		// Token: 0x06015E53 RID: 89683 RVA: 0x0032EABC File Offset: 0x0032CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom(RogueResPhantom other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this.phantomAffixInfos_ = other.phantomAffixInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E54 RID: 89684 RVA: 0x0032EB09 File Offset: 0x0032CD09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom Clone()
		{
			return new RogueResPhantom(this);
		}

		// Token: 0x17004925 RID: 18725
		// (get) Token: 0x06015E55 RID: 89685 RVA: 0x0032EB11 File Offset: 0x0032CD11
		// (set) Token: 0x06015E56 RID: 89686 RVA: 0x0032EB19 File Offset: 0x0032CD19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x06015E57 RID: 89687 RVA: 0x0032EB22 File Offset: 0x0032CD22
		// (set) Token: 0x06015E58 RID: 89688 RVA: 0x0032EB2A File Offset: 0x0032CD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x17004927 RID: 18727
		// (get) Token: 0x06015E59 RID: 89689 RVA: 0x0032EB33 File Offset: 0x0032CD33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAffixInfo> PhantomAffixInfos
		{
			get
			{
				return this.phantomAffixInfos_;
			}
		}

		// Token: 0x06015E5A RID: 89690 RVA: 0x0032EB3B File Offset: 0x0032CD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResPhantom);
		}

		// Token: 0x06015E5B RID: 89691 RVA: 0x0032EB4C File Offset: 0x0032CD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResPhantom other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.phantomAffixInfos_.Equals(other.phantomAffixInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E5C RID: 89692 RVA: 0x0032EBAC File Offset: 0x0032CDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			num ^= this.phantomAffixInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E5D RID: 89693 RVA: 0x0032EC12 File Offset: 0x0032CE12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E5E RID: 89694 RVA: 0x0032EC1F File Offset: 0x0032CE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E5F RID: 89695 RVA: 0x0032EC28 File Offset: 0x0032CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			this.phantomAffixInfos_.WriteTo(ref output, RogueResPhantom._repeated_phantomAffixInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E60 RID: 89696 RVA: 0x0032EC94 File Offset: 0x0032CE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			num += this.phantomAffixInfos_.CalculateSize(RogueResPhantom._repeated_phantomAffixInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E61 RID: 89697 RVA: 0x0032ECF4 File Offset: 0x0032CEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResPhantom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this.phantomAffixInfos_.Add(other.phantomAffixInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E62 RID: 89698 RVA: 0x0032ED55 File Offset: 0x0032CF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E63 RID: 89699 RVA: 0x0032ED60 File Offset: 0x0032CF60
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomAffixInfos_.AddEntriesFrom(ref input, RogueResPhantom._repeated_phantomAffixInfos_codec);
						}
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400835A RID: 33626
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400835B RID: 33627
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400835C RID: 33628
		private int configId_;

		// Token: 0x0400835D RID: 33629
		public const int IsNewFieldNumber = 2;

		// Token: 0x0400835E RID: 33630
		private bool isNew_;

		// Token: 0x0400835F RID: 33631
		public const int PhantomAffixInfosFieldNumber = 3;

		// Token: 0x04008360 RID: 33632
		private static readonly FieldCodec<PhantomAffixInfo> _repeated_phantomAffixInfos_codec = FieldCodec.ForMessage<PhantomAffixInfo>(26U, PhantomAffixInfo.Parser);

		// Token: 0x04008361 RID: 33633
		private readonly RepeatedField<PhantomAffixInfo> phantomAffixInfos_ = new RepeatedField<PhantomAffixInfo>();
	}
}
