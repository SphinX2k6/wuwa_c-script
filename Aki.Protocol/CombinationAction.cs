using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B6 RID: 694
	public sealed class CombinationAction : IMessage<CombinationAction>, IMessage, IEquatable<CombinationAction>, IDeepCloneable<CombinationAction>, IBufferMessage
	{
		// Token: 0x060047FE RID: 18430 RVA: 0x000B10F8 File Offset: 0x000AF2F8
		[NullableContext(1)]
		public static CombinationAction Create()
		{
			return new CombinationAction();
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x000B10FF File Offset: 0x000AF2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationAction> Parser
		{
			get
			{
				return CombinationAction._parser;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06004800 RID: 18432 RVA: 0x000B1106 File Offset: 0x000AF306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x000B1109 File Offset: 0x000AF309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationAction.Descriptor;
			}
		}

		// Token: 0x06004802 RID: 18434 RVA: 0x000B1110 File Offset: 0x000AF310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAction()
		{
		}

		// Token: 0x06004803 RID: 18435 RVA: 0x000B1130 File Offset: 0x000AF330
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

		// Token: 0x06004804 RID: 18436 RVA: 0x000B1189 File Offset: 0x000AF389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAction Clone()
		{
			return new CombinationAction(this);
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x000B1191 File Offset: 0x000AF391
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x000B1199 File Offset: 0x000AF399
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x000B11AC File Offset: 0x000AF3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationKey> CombinationKeyList
		{
			get
			{
				return this.combinationKeyList_;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06004808 RID: 18440 RVA: 0x000B11B4 File Offset: 0x000AF3B4
		// (set) Token: 0x06004809 RID: 18441 RVA: 0x000B11BC File Offset: 0x000AF3BC
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

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600480A RID: 18442 RVA: 0x000B11C5 File Offset: 0x000AF3C5
		// (set) Token: 0x0600480B RID: 18443 RVA: 0x000B11CD File Offset: 0x000AF3CD
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

		// Token: 0x0600480C RID: 18444 RVA: 0x000B11D6 File Offset: 0x000AF3D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationAction);
		}

		// Token: 0x0600480D RID: 18445 RVA: 0x000B11E4 File Offset: 0x000AF3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationAction other)
		{
			return other != null && (other == this || (!(this.ActionName != other.ActionName) && this.combinationKeyList_.Equals(other.combinationKeyList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600480E RID: 18446 RVA: 0x000B1258 File Offset: 0x000AF458
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

		// Token: 0x0600480F RID: 18447 RVA: 0x000B12DF File Offset: 0x000AF4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004810 RID: 18448 RVA: 0x000B12EC File Offset: 0x000AF4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x000B12F8 File Offset: 0x000AF4F8
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

		// Token: 0x06004812 RID: 18450 RVA: 0x000B1384 File Offset: 0x000AF584
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

		// Token: 0x06004813 RID: 18451 RVA: 0x000B140C File Offset: 0x000AF60C
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

		// Token: 0x06004814 RID: 18452 RVA: 0x000B1486 File Offset: 0x000AF686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x000B1490 File Offset: 0x000AF690
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

		// Token: 0x0400301E RID: 12318
		private static readonly MessageParser<CombinationAction> _parser = new MessageParser<CombinationAction>(() => new CombinationAction());

		// Token: 0x0400301F RID: 12319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003020 RID: 12320
		public const int ActionNameFieldNumber = 1;

		// Token: 0x04003021 RID: 12321
		private string actionName_ = "";

		// Token: 0x04003022 RID: 12322
		public const int CombinationKeyListFieldNumber = 2;

		// Token: 0x04003023 RID: 12323
		private static readonly FieldCodec<CombinationKey> _repeated_combinationKeyList_codec = FieldCodec.ForMessage<CombinationKey>(18U, CombinationKey.Parser);

		// Token: 0x04003024 RID: 12324
		private readonly RepeatedField<CombinationKey> combinationKeyList_ = new RepeatedField<CombinationKey>();

		// Token: 0x04003025 RID: 12325
		public const int VersionFieldNumber = 3;

		// Token: 0x04003026 RID: 12326
		private int version_;

		// Token: 0x04003027 RID: 12327
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04003028 RID: 12328
		private SettingInputType inputType_;
	}
}
