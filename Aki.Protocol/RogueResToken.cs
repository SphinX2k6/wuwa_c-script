using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001011 RID: 4113
	public sealed class RogueResToken : IMessage<RogueResToken>, IMessage, IEquatable<RogueResToken>, IDeepCloneable<RogueResToken>, IBufferMessage
	{
		// Token: 0x06015FD9 RID: 90073 RVA: 0x00332617 File Offset: 0x00330817
		[NullableContext(1)]
		public static RogueResToken Create()
		{
			return new RogueResToken();
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x06015FDA RID: 90074 RVA: 0x0033261E File Offset: 0x0033081E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x06015FDB RID: 90075 RVA: 0x00332621 File Offset: 0x00330821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResToken.Descriptor;
			}
		}

		// Token: 0x06015FDC RID: 90076 RVA: 0x00332628 File Offset: 0x00330828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken()
		{
		}

		// Token: 0x06015FDD RID: 90077 RVA: 0x0033263C File Offset: 0x0033083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken(RogueResToken other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this.elementUnits_ = other.elementUnits_.Clone();
			this.isSelect_ = other.isSelect_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015FDE RID: 90078 RVA: 0x00332695 File Offset: 0x00330895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken Clone()
		{
			return new RogueResToken(this);
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x06015FDF RID: 90079 RVA: 0x0033269D File Offset: 0x0033089D
		// (set) Token: 0x06015FE0 RID: 90080 RVA: 0x003326A5 File Offset: 0x003308A5
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

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x06015FE1 RID: 90081 RVA: 0x003326AE File Offset: 0x003308AE
		// (set) Token: 0x06015FE2 RID: 90082 RVA: 0x003326B6 File Offset: 0x003308B6
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

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x06015FE3 RID: 90083 RVA: 0x003326BF File Offset: 0x003308BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x06015FE4 RID: 90084 RVA: 0x003326C7 File Offset: 0x003308C7
		// (set) Token: 0x06015FE5 RID: 90085 RVA: 0x003326CF File Offset: 0x003308CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSelect
		{
			get
			{
				return this.isSelect_;
			}
			set
			{
				this.isSelect_ = value;
			}
		}

		// Token: 0x06015FE6 RID: 90086 RVA: 0x003326D8 File Offset: 0x003308D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResToken);
		}

		// Token: 0x06015FE7 RID: 90087 RVA: 0x003326E8 File Offset: 0x003308E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResToken other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.elementUnits_.Equals(other.elementUnits_) && this.IsSelect == other.IsSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015FE8 RID: 90088 RVA: 0x00332758 File Offset: 0x00330958
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
			num ^= this.elementUnits_.GetHashCode();
			if (this.IsSelect)
			{
				num ^= this.IsSelect.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015FE9 RID: 90089 RVA: 0x003327D7 File Offset: 0x003309D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015FEA RID: 90090 RVA: 0x003327E4 File Offset: 0x003309E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015FEB RID: 90091 RVA: 0x003327F0 File Offset: 0x003309F0
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
			this.elementUnits_.WriteTo(ref output, RogueResToken._repeated_elementUnits_codec);
			if (this.IsSelect)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSelect);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015FEC RID: 90092 RVA: 0x00332878 File Offset: 0x00330A78
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
			num += this.elementUnits_.CalculateSize(RogueResToken._repeated_elementUnits_codec);
			if (this.IsSelect)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015FED RID: 90093 RVA: 0x003328E4 File Offset: 0x00330AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResToken other)
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
			this.elementUnits_.Add(other.elementUnits_);
			if (other.IsSelect)
			{
				this.IsSelect = other.IsSelect;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015FEE RID: 90094 RVA: 0x00332959 File Offset: 0x00330B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015FEF RID: 90095 RVA: 0x00332964 File Offset: 0x00330B64
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsNew = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.elementUnits_.AddEntriesFrom(ref input, RogueResToken._repeated_elementUnits_codec);
						continue;
					}
					if (num == 32U)
					{
						this.IsSelect = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040083E6 RID: 33766
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083E7 RID: 33767
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x040083E8 RID: 33768
		private int configId_;

		// Token: 0x040083E9 RID: 33769
		public const int IsNewFieldNumber = 2;

		// Token: 0x040083EA RID: 33770
		private bool isNew_;

		// Token: 0x040083EB RID: 33771
		public const int ElementUnitsFieldNumber = 3;

		// Token: 0x040083EC RID: 33772
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(26U, ElementUnit.Parser);

		// Token: 0x040083ED RID: 33773
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x040083EE RID: 33774
		public const int IsSelectFieldNumber = 4;

		// Token: 0x040083EF RID: 33775
		private bool isSelect_;
	}
}
