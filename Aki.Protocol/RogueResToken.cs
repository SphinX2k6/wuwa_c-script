using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001001 RID: 4097
	public sealed class RogueResToken : IMessage<RogueResToken>, IMessage, IEquatable<RogueResToken>, IDeepCloneable<RogueResToken>, IBufferMessage
	{
		// Token: 0x06015EF4 RID: 89844 RVA: 0x00330F5B File Offset: 0x0032F15B
		[NullableContext(1)]
		public static RogueResToken Create()
		{
			return new RogueResToken();
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06015EF5 RID: 89845 RVA: 0x00330F62 File Offset: 0x0032F162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x06015EF6 RID: 89846 RVA: 0x00330F65 File Offset: 0x0032F165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResToken.Descriptor;
			}
		}

		// Token: 0x06015EF7 RID: 89847 RVA: 0x00330F6C File Offset: 0x0032F16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken()
		{
		}

		// Token: 0x06015EF8 RID: 89848 RVA: 0x00330F80 File Offset: 0x0032F180
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

		// Token: 0x06015EF9 RID: 89849 RVA: 0x00330FD9 File Offset: 0x0032F1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResToken Clone()
		{
			return new RogueResToken(this);
		}

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x06015EFA RID: 89850 RVA: 0x00330FE1 File Offset: 0x0032F1E1
		// (set) Token: 0x06015EFB RID: 89851 RVA: 0x00330FE9 File Offset: 0x0032F1E9
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

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x06015EFC RID: 89852 RVA: 0x00330FF2 File Offset: 0x0032F1F2
		// (set) Token: 0x06015EFD RID: 89853 RVA: 0x00330FFA File Offset: 0x0032F1FA
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

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x06015EFE RID: 89854 RVA: 0x00331003 File Offset: 0x0032F203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ElementUnit> ElementUnits
		{
			get
			{
				return this.elementUnits_;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x06015EFF RID: 89855 RVA: 0x0033100B File Offset: 0x0032F20B
		// (set) Token: 0x06015F00 RID: 89856 RVA: 0x00331013 File Offset: 0x0032F213
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

		// Token: 0x06015F01 RID: 89857 RVA: 0x0033101C File Offset: 0x0032F21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResToken);
		}

		// Token: 0x06015F02 RID: 89858 RVA: 0x0033102C File Offset: 0x0032F22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResToken other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.elementUnits_.Equals(other.elementUnits_) && this.IsSelect == other.IsSelect && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F03 RID: 89859 RVA: 0x0033109C File Offset: 0x0032F29C
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

		// Token: 0x06015F04 RID: 89860 RVA: 0x0033111B File Offset: 0x0032F31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F05 RID: 89861 RVA: 0x00331128 File Offset: 0x0032F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F06 RID: 89862 RVA: 0x00331134 File Offset: 0x0032F334
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

		// Token: 0x06015F07 RID: 89863 RVA: 0x003311BC File Offset: 0x0032F3BC
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

		// Token: 0x06015F08 RID: 89864 RVA: 0x00331228 File Offset: 0x0032F428
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

		// Token: 0x06015F09 RID: 89865 RVA: 0x0033129D File Offset: 0x0032F49D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F0A RID: 89866 RVA: 0x003312A8 File Offset: 0x0032F4A8
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

		// Token: 0x04008410 RID: 33808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008411 RID: 33809
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008412 RID: 33810
		private int configId_;

		// Token: 0x04008413 RID: 33811
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008414 RID: 33812
		private bool isNew_;

		// Token: 0x04008415 RID: 33813
		public const int ElementUnitsFieldNumber = 3;

		// Token: 0x04008416 RID: 33814
		private static readonly FieldCodec<ElementUnit> _repeated_elementUnits_codec = FieldCodec.ForMessage<ElementUnit>(26U, ElementUnit.Parser);

		// Token: 0x04008417 RID: 33815
		private readonly RepeatedField<ElementUnit> elementUnits_ = new RepeatedField<ElementUnit>();

		// Token: 0x04008418 RID: 33816
		public const int IsSelectFieldNumber = 4;

		// Token: 0x04008419 RID: 33817
		private bool isSelect_;
	}
}
