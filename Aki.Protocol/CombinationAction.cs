using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B0 RID: 688
	public sealed class CombinationAction : IMessage<CombinationAction>, IMessage, IEquatable<CombinationAction>, IDeepCloneable<CombinationAction>, IBufferMessage
	{
		// Token: 0x06004737 RID: 18231 RVA: 0x000AEEF4 File Offset: 0x000AD0F4
		[NullableContext(1)]
		public static CombinationAction Create()
		{
			return new CombinationAction();
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06004738 RID: 18232 RVA: 0x000AEEFB File Offset: 0x000AD0FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationAction> Parser
		{
			get
			{
				return CombinationAction._parser;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x000AEF02 File Offset: 0x000AD102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x0600473A RID: 18234 RVA: 0x000AEF05 File Offset: 0x000AD105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationAction.Descriptor;
			}
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x000AEF0C File Offset: 0x000AD10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAction()
		{
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x000AEF2C File Offset: 0x000AD12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAction(CombinationAction other) : this()
		{
			this.actionName_ = other.actionName_;
			this.combinationKeyList_ = other.combinationKeyList_.Clone();
			this.version_ = other.version_;
			this.inputType_ = other.inputType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x000AEF85 File Offset: 0x000AD185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAction Clone()
		{
			return new CombinationAction(this);
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x000AEF8D File Offset: 0x000AD18D
		// (set) Token: 0x0600473F RID: 18239 RVA: 0x000AEF95 File Offset: 0x000AD195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ActionName
		{
			get
			{
				return this.actionName_;
			}
			set
			{
				this.actionName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x000AEFA8 File Offset: 0x000AD1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationKey> CombinationKeyList
		{
			get
			{
				return this.combinationKeyList_;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06004741 RID: 18241 RVA: 0x000AEFB0 File Offset: 0x000AD1B0
		// (set) Token: 0x06004742 RID: 18242 RVA: 0x000AEFB8 File Offset: 0x000AD1B8
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06004743 RID: 18243 RVA: 0x000AEFC1 File Offset: 0x000AD1C1
		// (set) Token: 0x06004744 RID: 18244 RVA: 0x000AEFC9 File Offset: 0x000AD1C9
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

		// Token: 0x06004745 RID: 18245 RVA: 0x000AEFD2 File Offset: 0x000AD1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationAction);
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationAction other)
		{
			return other != null && (other == this || (!(this.ActionName != other.ActionName) && this.combinationKeyList_.Equals(other.combinationKeyList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x000AF054 File Offset: 0x000AD254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActionName.Length != 0)
			{
				num ^= this.ActionName.GetHashCode();
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

		// Token: 0x06004748 RID: 18248 RVA: 0x000AF0DB File Offset: 0x000AD2DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x000AF0E8 File Offset: 0x000AD2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x000AF0F4 File Offset: 0x000AD2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionName.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ActionName);
			}
			this.combinationKeyList_.WriteTo(ref output, CombinationAction._repeated_combinationKeyList_codec);
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

		// Token: 0x0600474B RID: 18251 RVA: 0x000AF180 File Offset: 0x000AD380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActionName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ActionName);
			}
			num += this.combinationKeyList_.CalculateSize(CombinationAction._repeated_combinationKeyList_codec);
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

		// Token: 0x0600474C RID: 18252 RVA: 0x000AF208 File Offset: 0x000AD408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombinationAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActionName.Length != 0)
			{
				this.ActionName = other.ActionName;
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

		// Token: 0x0600474D RID: 18253 RVA: 0x000AF282 File Offset: 0x000AD482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x000AF28C File Offset: 0x000AD48C
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
						this.ActionName = input.ReadString();
						continue;
					}
					if (num == 18U)
					{
						this.combinationKeyList_.AddEntriesFrom(ref input, CombinationAction._repeated_combinationKeyList_codec);
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

		// Token: 0x04002F8B RID: 12171
		private static readonly MessageParser<CombinationAction> _parser = new MessageParser<CombinationAction>(() => new CombinationAction());

		// Token: 0x04002F8C RID: 12172
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F8D RID: 12173
		public const int ActionNameFieldNumber = 1;

		// Token: 0x04002F8E RID: 12174
		private string actionName_ = "";

		// Token: 0x04002F8F RID: 12175
		public const int CombinationKeyListFieldNumber = 2;

		// Token: 0x04002F90 RID: 12176
		private static readonly FieldCodec<CombinationKey> _repeated_combinationKeyList_codec = FieldCodec.ForMessage<CombinationKey>(18U, CombinationKey.Parser);

		// Token: 0x04002F91 RID: 12177
		private readonly RepeatedField<CombinationKey> combinationKeyList_ = new RepeatedField<CombinationKey>();

		// Token: 0x04002F92 RID: 12178
		public const int VersionFieldNumber = 3;

		// Token: 0x04002F93 RID: 12179
		private int version_;

		// Token: 0x04002F94 RID: 12180
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04002F95 RID: 12181
		private SettingInputType inputType_;
	}
}
