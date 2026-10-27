using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CDD RID: 3293
	public sealed class PhantomItem : IMessage<PhantomItem>, IMessage, IEquatable<PhantomItem>, IDeepCloneable<PhantomItem>, IBufferMessage
	{
		// Token: 0x06011D0E RID: 72974 RVA: 0x0029B196 File Offset: 0x00299396
		[NullableContext(1)]
		public static PhantomItem Create()
		{
			return new PhantomItem();
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x06011D0F RID: 72975 RVA: 0x0029B19D File Offset: 0x0029939D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomItem> Parser
		{
			get
			{
				return PhantomItem._parser;
			}
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x06011D10 RID: 72976 RVA: 0x0029B1A4 File Offset: 0x002993A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B06 RID: 15110
		// (get) Token: 0x06011D11 RID: 72977 RVA: 0x0029B1A7 File Offset: 0x002993A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItem.Descriptor;
			}
		}

		// Token: 0x06011D12 RID: 72978 RVA: 0x0029B1AE File Offset: 0x002993AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem()
		{
		}

		// Token: 0x06011D13 RID: 72979 RVA: 0x0029B1E4 File Offset: 0x002993E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem(PhantomItem other) : this()
		{
			this.id_ = other.id_;
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this.phantomLevel_ = other.phantomLevel_;
			this.phantomExp_ = other.phantomExp_;
			this.phantomMainProp_ = other.phantomMainProp_.Clone();
			this.phantomSubProp_ = other.phantomSubProp_.Clone();
			this.fetterGroupId_ = other.fetterGroupId_;
			this.skinId_ = other.skinId_;
			this.unAckSubProp_ = other.unAckSubProp_.Clone();
			this.lockPropIndex_ = other.lockPropIndex_.Clone();
			this.stackCount_ = other.stackCount_;
			this.addTime_ = other.addTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011D14 RID: 72980 RVA: 0x0029B2B8 File Offset: 0x002994B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem Clone()
		{
			return new PhantomItem(this);
		}

		// Token: 0x17003B07 RID: 15111
		// (get) Token: 0x06011D15 RID: 72981 RVA: 0x0029B2C0 File Offset: 0x002994C0
		// (set) Token: 0x06011D16 RID: 72982 RVA: 0x0029B2C8 File Offset: 0x002994C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003B08 RID: 15112
		// (get) Token: 0x06011D17 RID: 72983 RVA: 0x0029B2D1 File Offset: 0x002994D1
		// (set) Token: 0x06011D18 RID: 72984 RVA: 0x0029B2D9 File Offset: 0x002994D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003B09 RID: 15113
		// (get) Token: 0x06011D19 RID: 72985 RVA: 0x0029B2E2 File Offset: 0x002994E2
		// (set) Token: 0x06011D1A RID: 72986 RVA: 0x0029B2EA File Offset: 0x002994EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x17003B0A RID: 15114
		// (get) Token: 0x06011D1B RID: 72987 RVA: 0x0029B2F3 File Offset: 0x002994F3
		// (set) Token: 0x06011D1C RID: 72988 RVA: 0x0029B2FB File Offset: 0x002994FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomLevel
		{
			get
			{
				return this.phantomLevel_;
			}
			set
			{
				this.phantomLevel_ = value;
			}
		}

		// Token: 0x17003B0B RID: 15115
		// (get) Token: 0x06011D1D RID: 72989 RVA: 0x0029B304 File Offset: 0x00299504
		// (set) Token: 0x06011D1E RID: 72990 RVA: 0x0029B30C File Offset: 0x0029950C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomExp
		{
			get
			{
				return this.phantomExp_;
			}
			set
			{
				this.phantomExp_ = value;
			}
		}

		// Token: 0x17003B0C RID: 15116
		// (get) Token: 0x06011D1F RID: 72991 RVA: 0x0029B315 File Offset: 0x00299515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomMainProp
		{
			get
			{
				return this.phantomMainProp_;
			}
		}

		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x06011D20 RID: 72992 RVA: 0x0029B31D File Offset: 0x0029951D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomSubProp
		{
			get
			{
				return this.phantomSubProp_;
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x06011D21 RID: 72993 RVA: 0x0029B325 File Offset: 0x00299525
		// (set) Token: 0x06011D22 RID: 72994 RVA: 0x0029B32D File Offset: 0x0029952D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FetterGroupId
		{
			get
			{
				return this.fetterGroupId_;
			}
			set
			{
				this.fetterGroupId_ = value;
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x06011D23 RID: 72995 RVA: 0x0029B336 File Offset: 0x00299536
		// (set) Token: 0x06011D24 RID: 72996 RVA: 0x0029B33E File Offset: 0x0029953E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x06011D25 RID: 72997 RVA: 0x0029B347 File Offset: 0x00299547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> UnAckSubProp
		{
			get
			{
				return this.unAckSubProp_;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x06011D26 RID: 72998 RVA: 0x0029B34F File Offset: 0x0029954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockPropIndex
		{
			get
			{
				return this.lockPropIndex_;
			}
		}

		// Token: 0x17003B12 RID: 15122
		// (get) Token: 0x06011D27 RID: 72999 RVA: 0x0029B357 File Offset: 0x00299557
		// (set) Token: 0x06011D28 RID: 73000 RVA: 0x0029B35F File Offset: 0x0029955F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StackCount
		{
			get
			{
				return this.stackCount_;
			}
			set
			{
				this.stackCount_ = value;
			}
		}

		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x06011D29 RID: 73001 RVA: 0x0029B368 File Offset: 0x00299568
		// (set) Token: 0x06011D2A RID: 73002 RVA: 0x0029B370 File Offset: 0x00299570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AddTime
		{
			get
			{
				return this.addTime_;
			}
			set
			{
				this.addTime_ = value;
			}
		}

		// Token: 0x06011D2B RID: 73003 RVA: 0x0029B379 File Offset: 0x00299579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItem);
		}

		// Token: 0x06011D2C RID: 73004 RVA: 0x0029B388 File Offset: 0x00299588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.PhantomLevel == other.PhantomLevel && this.PhantomExp == other.PhantomExp && this.phantomMainProp_.Equals(other.phantomMainProp_) && this.phantomSubProp_.Equals(other.phantomSubProp_) && this.FetterGroupId == other.FetterGroupId && this.SkinId == other.SkinId && this.unAckSubProp_.Equals(other.unAckSubProp_) && this.lockPropIndex_.Equals(other.lockPropIndex_) && this.StackCount == other.StackCount && this.AddTime == other.AddTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011D2D RID: 73005 RVA: 0x0029B498 File Offset: 0x00299698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this.PhantomLevel != 0)
			{
				num ^= this.PhantomLevel.GetHashCode();
			}
			if (this.PhantomExp != 0)
			{
				num ^= this.PhantomExp.GetHashCode();
			}
			num ^= this.phantomMainProp_.GetHashCode();
			num ^= this.phantomSubProp_.GetHashCode();
			if (this.FetterGroupId != 0)
			{
				num ^= this.FetterGroupId.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			num ^= this.unAckSubProp_.GetHashCode();
			num ^= this.lockPropIndex_.GetHashCode();
			if (this.StackCount != 0)
			{
				num ^= this.StackCount.GetHashCode();
			}
			if (this.AddTime != 0L)
			{
				num ^= this.AddTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011D2E RID: 73006 RVA: 0x0029B5D7 File Offset: 0x002997D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011D2F RID: 73007 RVA: 0x0029B5E4 File Offset: 0x002997E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011D30 RID: 73008 RVA: 0x0029B5F0 File Offset: 0x002997F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FuncValue);
			}
			if (this.PhantomLevel != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PhantomLevel);
			}
			if (this.PhantomExp != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PhantomExp);
			}
			this.phantomMainProp_.WriteTo(ref output, PhantomItem._repeated_phantomMainProp_codec);
			this.phantomSubProp_.WriteTo(ref output, PhantomItem._repeated_phantomSubProp_codec);
			if (this.FetterGroupId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FetterGroupId);
			}
			if (this.SkinId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.SkinId);
			}
			this.unAckSubProp_.WriteTo(ref output, PhantomItem._repeated_unAckSubProp_codec);
			this.lockPropIndex_.WriteTo(ref output, PhantomItem._repeated_lockPropIndex_codec);
			if (this.StackCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.StackCount);
			}
			if (this.AddTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011D31 RID: 73009 RVA: 0x0029B750 File Offset: 0x00299950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this.PhantomLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomLevel);
			}
			if (this.PhantomExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomExp);
			}
			num += this.phantomMainProp_.CalculateSize(PhantomItem._repeated_phantomMainProp_codec);
			num += this.phantomSubProp_.CalculateSize(PhantomItem._repeated_phantomSubProp_codec);
			if (this.FetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FetterGroupId);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			num += this.unAckSubProp_.CalculateSize(PhantomItem._repeated_unAckSubProp_codec);
			num += this.lockPropIndex_.CalculateSize(PhantomItem._repeated_lockPropIndex_codec);
			if (this.StackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StackCount);
			}
			if (this.AddTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AddTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011D32 RID: 73010 RVA: 0x0029B89C File Offset: 0x00299A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			if (other.PhantomLevel != 0)
			{
				this.PhantomLevel = other.PhantomLevel;
			}
			if (other.PhantomExp != 0)
			{
				this.PhantomExp = other.PhantomExp;
			}
			this.phantomMainProp_.Add(other.phantomMainProp_);
			this.phantomSubProp_.Add(other.phantomSubProp_);
			if (other.FetterGroupId != 0)
			{
				this.FetterGroupId = other.FetterGroupId;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this.unAckSubProp_.Add(other.unAckSubProp_);
			this.lockPropIndex_.Add(other.lockPropIndex_);
			if (other.StackCount != 0)
			{
				this.StackCount = other.StackCount;
			}
			if (other.AddTime != 0L)
			{
				this.AddTime = other.AddTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011D33 RID: 73011 RVA: 0x0029B9BC File Offset: 0x00299BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011D34 RID: 73012 RVA: 0x0029B9C8 File Offset: 0x00299BC8
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
				if (num <= 58U)
				{
					if (num <= 24U)
					{
						if (num == 8U)
						{
							this.Id = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.IncrId = input.ReadInt32();
							continue;
						}
						if (num == 24U)
						{
							this.FuncValue = input.ReadInt32();
							continue;
						}
					}
					else if (num <= 40U)
					{
						if (num == 32U)
						{
							this.PhantomLevel = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.PhantomExp = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 50U)
						{
							this.phantomMainProp_.AddEntriesFrom(ref input, PhantomItem._repeated_phantomMainProp_codec);
							continue;
						}
						if (num == 58U)
						{
							this.phantomSubProp_.AddEntriesFrom(ref input, PhantomItem._repeated_phantomSubProp_codec);
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 64U)
					{
						this.FetterGroupId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.SkinId = input.ReadInt32();
						continue;
					}
					if (num == 82U)
					{
						this.unAckSubProp_.AddEntriesFrom(ref input, PhantomItem._repeated_unAckSubProp_codec);
						continue;
					}
				}
				else if (num <= 90U)
				{
					if (num == 88U || num == 90U)
					{
						this.lockPropIndex_.AddEntriesFrom(ref input, PhantomItem._repeated_lockPropIndex_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.StackCount = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.AddTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006FD4 RID: 28628
		private static readonly MessageParser<PhantomItem> _parser = new MessageParser<PhantomItem>(() => new PhantomItem());

		// Token: 0x04006FD5 RID: 28629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FD6 RID: 28630
		public const int IdFieldNumber = 1;

		// Token: 0x04006FD7 RID: 28631
		private int id_;

		// Token: 0x04006FD8 RID: 28632
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04006FD9 RID: 28633
		private int incrId_;

		// Token: 0x04006FDA RID: 28634
		public const int FuncValueFieldNumber = 3;

		// Token: 0x04006FDB RID: 28635
		private int funcValue_;

		// Token: 0x04006FDC RID: 28636
		public const int PhantomLevelFieldNumber = 4;

		// Token: 0x04006FDD RID: 28637
		private int phantomLevel_;

		// Token: 0x04006FDE RID: 28638
		public const int PhantomExpFieldNumber = 5;

		// Token: 0x04006FDF RID: 28639
		private int phantomExp_;

		// Token: 0x04006FE0 RID: 28640
		public const int PhantomMainPropFieldNumber = 6;

		// Token: 0x04006FE1 RID: 28641
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomMainProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(50U, PhantomPropInfo.Parser);

		// Token: 0x04006FE2 RID: 28642
		private readonly RepeatedField<PhantomPropInfo> phantomMainProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04006FE3 RID: 28643
		public const int PhantomSubPropFieldNumber = 7;

		// Token: 0x04006FE4 RID: 28644
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(58U, PhantomPropInfo.Parser);

		// Token: 0x04006FE5 RID: 28645
		private readonly RepeatedField<PhantomPropInfo> phantomSubProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04006FE6 RID: 28646
		public const int FetterGroupIdFieldNumber = 8;

		// Token: 0x04006FE7 RID: 28647
		private int fetterGroupId_;

		// Token: 0x04006FE8 RID: 28648
		public const int SkinIdFieldNumber = 9;

		// Token: 0x04006FE9 RID: 28649
		private int skinId_;

		// Token: 0x04006FEA RID: 28650
		public const int UnAckSubPropFieldNumber = 10;

		// Token: 0x04006FEB RID: 28651
		private static readonly FieldCodec<PhantomPropInfo> _repeated_unAckSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(82U, PhantomPropInfo.Parser);

		// Token: 0x04006FEC RID: 28652
		private readonly RepeatedField<PhantomPropInfo> unAckSubProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04006FED RID: 28653
		public const int LockPropIndexFieldNumber = 11;

		// Token: 0x04006FEE RID: 28654
		private static readonly FieldCodec<int> _repeated_lockPropIndex_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04006FEF RID: 28655
		private readonly RepeatedField<int> lockPropIndex_ = new RepeatedField<int>();

		// Token: 0x04006FF0 RID: 28656
		public const int StackCountFieldNumber = 12;

		// Token: 0x04006FF1 RID: 28657
		private int stackCount_;

		// Token: 0x04006FF2 RID: 28658
		public const int AddTimeFieldNumber = 13;

		// Token: 0x04006FF3 RID: 28659
		private long addTime_;
	}
}
