using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002B7 RID: 695
	public sealed class CombinationAxis : IMessage<CombinationAxis>, IMessage, IEquatable<CombinationAxis>, IDeepCloneable<CombinationAxis>, IBufferMessage
	{
		// Token: 0x06004817 RID: 18455 RVA: 0x000B1547 File Offset: 0x000AF747
		[NullableContext(1)]
		public static CombinationAxis Create()
		{
			return new CombinationAxis();
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06004818 RID: 18456 RVA: 0x000B154E File Offset: 0x000AF74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CombinationAxis> Parser
		{
			get
			{
				return CombinationAxis._parser;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x000B1555 File Offset: 0x000AF755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x000B1558 File Offset: 0x000AF758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombinationAxis.Descriptor;
			}
		}

		// Token: 0x0600481B RID: 18459 RVA: 0x000B155F File Offset: 0x000AF75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAxis()
		{
		}

		// Token: 0x0600481C RID: 18460 RVA: 0x000B1580 File Offset: 0x000AF780
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

		// Token: 0x0600481D RID: 18461 RVA: 0x000B15D9 File Offset: 0x000AF7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombinationAxis Clone()
		{
			return new CombinationAxis(this);
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x000B15E1 File Offset: 0x000AF7E1
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x000B15E9 File Offset: 0x000AF7E9
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

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x000B15FC File Offset: 0x000AF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CombinationKey> CombinationKeyList
		{
			get
			{
				return this.combinationKeyList_;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06004821 RID: 18465 RVA: 0x000B1604 File Offset: 0x000AF804
		// (set) Token: 0x06004822 RID: 18466 RVA: 0x000B160C File Offset: 0x000AF80C
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06004823 RID: 18467 RVA: 0x000B1615 File Offset: 0x000AF815
		// (set) Token: 0x06004824 RID: 18468 RVA: 0x000B161D File Offset: 0x000AF81D
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

		// Token: 0x06004825 RID: 18469 RVA: 0x000B1626 File Offset: 0x000AF826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombinationAxis);
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x000B1634 File Offset: 0x000AF834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombinationAxis other)
		{
			return other != null && (other == this || (!(this.AxisName != other.AxisName) && this.combinationKeyList_.Equals(other.combinationKeyList_) && this.Version == other.Version && this.InputType == other.InputType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x000B16A8 File Offset: 0x000AF8A8
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

		// Token: 0x06004828 RID: 18472 RVA: 0x000B172F File Offset: 0x000AF92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x000B173C File Offset: 0x000AF93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x000B1748 File Offset: 0x000AF948
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

		// Token: 0x0600482B RID: 18475 RVA: 0x000B17D4 File Offset: 0x000AF9D4
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

		// Token: 0x0600482C RID: 18476 RVA: 0x000B185C File Offset: 0x000AFA5C
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

		// Token: 0x0600482D RID: 18477 RVA: 0x000B18D6 File Offset: 0x000AFAD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x000B18E0 File Offset: 0x000AFAE0
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

		// Token: 0x04003029 RID: 12329
		private static readonly MessageParser<CombinationAxis> _parser = new MessageParser<CombinationAxis>(() => new CombinationAxis());

		// Token: 0x0400302A RID: 12330
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400302B RID: 12331
		public const int AxisNameFieldNumber = 1;

		// Token: 0x0400302C RID: 12332
		private string axisName_ = "";

		// Token: 0x0400302D RID: 12333
		public const int CombinationKeyListFieldNumber = 2;

		// Token: 0x0400302E RID: 12334
		private static readonly FieldCodec<CombinationKey> _repeated_combinationKeyList_codec = FieldCodec.ForMessage<CombinationKey>(18U, CombinationKey.Parser);

		// Token: 0x0400302F RID: 12335
		private readonly RepeatedField<CombinationKey> combinationKeyList_ = new RepeatedField<CombinationKey>();

		// Token: 0x04003030 RID: 12336
		public const int VersionFieldNumber = 3;

		// Token: 0x04003031 RID: 12337
		private int version_;

		// Token: 0x04003032 RID: 12338
		public const int InputTypeFieldNumber = 4;

		// Token: 0x04003033 RID: 12339
		private SettingInputType inputType_;
	}
}
