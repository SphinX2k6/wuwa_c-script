using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B1 RID: 689
	public sealed class CombinationAxis : IMessage<CombinationAxis>, IMessage, IEquatable<CombinationAxis>, IDeepCloneable<CombinationAxis>, IBufferMessage
	{
		// Token: 0x06004750 RID: 18256 RVA: 0x000AF343 File Offset: 0x000AD543
		[NullableContext(1)]
		public static CombinationAxis Create()
		{
			return new CombinationAxis();
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06004751 RID: 18257 RVA: 0x000AF34A File Offset: 0x000AD54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationAxis> Parser
		{
			get
			{
				return CombinationAxis._parser;
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x000AF351 File Offset: 0x000AD551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06004753 RID: 18259 RVA: 0x000AF354 File Offset: 0x000AD554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationAxis.Descriptor;
			}
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x000AF35B File Offset: 0x000AD55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAxis()
		{
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x000AF37C File Offset: 0x000AD57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAxis(CombinationAxis other) : this()
		{
			this.axisName_ = other.axisName_;
			this.combinationKeyList_ = other.combinationKeyList_.Clone();
			this.version_ = other.version_;
			this.inputType_ = other.inputType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x000AF3D5 File Offset: 0x000AD5D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAxis Clone()
		{
			return new CombinationAxis(this);
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06004757 RID: 18263 RVA: 0x000AF3DD File Offset: 0x000AD5DD
		// (set) Token: 0x06004758 RID: 18264 RVA: 0x000AF3E5 File Offset: 0x000AD5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AxisName
		{
			get
			{
				return this.axisName_;
			}
			set
			{
				this.axisName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06004759 RID: 18265 RVA: 0x000AF3F8 File Offset: 0x000AD5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationKey> CombinationKeyList
		{
			get
			{
				return this.combinationKeyList_;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x000AF400 File Offset: 0x000AD600
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x000AF408 File Offset: 0x000AD608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x000AF411 File Offset: 0x000AD611
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x000AF419 File Offset: 0x000AD619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SettingInputType InputType
		{
			get
			{
				return this.inputType_;
			}
			set
			{
				this.inputType_ = value;
			}
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x000AF422 File Offset: 0x000AD622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationAxis);
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x000AF430 File Offset: 0x000AD630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationAxis other)
		{
			return other != null && (other == this || (!(this.AxisName != other.AxisName) && this.combinationKeyList_.Equals(other.combinationKeyList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x000AF4A4 File Offset: 0x000AD6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AxisName.Length != 0)
			{
				num ^= this.AxisName.GetHashCode();
			}
			num ^= this.combinationKeyList_.GetHashCode();
			if (this.Version != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this.InputType != SettingInputType.Normal)
			{
				num ^= this.InputType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x000AF52B File Offset: 0x000AD72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x000AF538 File Offset: 0x000AD738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x000AF544 File Offset: 0x000AD744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AxisName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AxisName);
			}
			this.combinationKeyList_.WriteTo(ref output, CombinationAxis._repeated_combinationKeyList_codec);
			if (this.Version != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Version);
			}
			if (this.InputType != SettingInputType.Normal)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.InputType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x000AF5D0 File Offset: 0x000AD7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AxisName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AxisName);
			}
			num += this.combinationKeyList_.CalculateSize(CombinationAxis._repeated_combinationKeyList_codec);
			if (this.Version != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Version);
			}
			if (this.InputType != SettingInputType.Normal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.InputType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x000AF658 File Offset: 0x000AD858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombinationAxis other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AxisName.Length != 0)
			{
				this.AxisName = other.AxisName;
			}
			this.combinationKeyList_.Add(other.combinationKeyList_);
			if (other.Version != 0)
			{
				this.Version = other.Version;
			}
			if (other.InputType != SettingInputType.Normal)
			{
				this.InputType = other.InputType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x000AF6D2 File Offset: 0x000AD8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x000AF6DC File Offset: 0x000AD8DC
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						this.AxisName = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.combinationKeyList_.AddEntriesFrom(ref input, CombinationAxis._repeated_combinationKeyList_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Version = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.InputType = (SettingInputType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F96 RID: 12182
		private static readonly MessageParser<CombinationAxis> _parser = new MessageParser<CombinationAxis>(() => new CombinationAxis());

		// Token: 0x04002F97 RID: 12183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F98 RID: 12184
		public const int AxisNameFieldNumber = 1;

		// Token: 0x04002F99 RID: 12185
		private string axisName_ = "";

		// Token: 0x04002F9A RID: 12186
		public const int CombinationKeyListFieldNumber = 2;

		// Token: 0x04002F9B RID: 12187
		private static readonly FieldCodec<CombinationKey> _repeated_combinationKeyList_codec = FieldCodec.ForMessage<CombinationKey>(18U, CombinationKey.Parser);

		// Token: 0x04002F9C RID: 12188
		private readonly RepeatedField<CombinationKey> combinationKeyList_ = new RepeatedField<CombinationKey>();

		// Token: 0x04002F9D RID: 12189
		public const int VersionFieldNumber = 3;

		// Token: 0x04002F9E RID: 12190
		private int version_;

		// Token: 0x04002F9F RID: 12191
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04002FA0 RID: 12192
		private SettingInputType inputType_;
	}
}
