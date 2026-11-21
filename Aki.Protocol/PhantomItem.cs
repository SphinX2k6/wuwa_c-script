using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CCD RID: 3277
	public sealed class PhantomItem : IMessage<PhantomItem>, IMessage, IEquatable<PhantomItem>, IDeepCloneable<PhantomItem>, IBufferMessage
	{
		// Token: 0x06011C12 RID: 72722 RVA: 0x0029957A File Offset: 0x0029777A
		[NullableContext(1)]
		public static PhantomItem Create()
		{
			return new PhantomItem();
		}

		// Token: 0x17003ACF RID: 15055
		// (get) Token: 0x06011C13 RID: 72723 RVA: 0x00299581 File Offset: 0x00297781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomItem> Parser
		{
			get
			{
				return PhantomItem._parser;
			}
		}

		// Token: 0x17003AD0 RID: 15056
		// (get) Token: 0x06011C14 RID: 72724 RVA: 0x00299588 File Offset: 0x00297788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003AD1 RID: 15057
		// (get) Token: 0x06011C15 RID: 72725 RVA: 0x0029958B File Offset: 0x0029778B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomItem.Descriptor;
			}
		}

		// Token: 0x06011C16 RID: 72726 RVA: 0x00299592 File Offset: 0x00297792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem()
		{
		}

		// Token: 0x06011C17 RID: 72727 RVA: 0x002995C8 File Offset: 0x002977C8
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

		// Token: 0x06011C18 RID: 72728 RVA: 0x0029969C File Offset: 0x0029789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem Clone()
		{
			return new PhantomItem(this);
		}

		// Token: 0x17003AD2 RID: 15058
		// (get) Token: 0x06011C19 RID: 72729 RVA: 0x002996A4 File Offset: 0x002978A4
		// (set) Token: 0x06011C1A RID: 72730 RVA: 0x002996AC File Offset: 0x002978AC
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

		// Token: 0x17003AD3 RID: 15059
		// (get) Token: 0x06011C1B RID: 72731 RVA: 0x002996B5 File Offset: 0x002978B5
		// (set) Token: 0x06011C1C RID: 72732 RVA: 0x002996BD File Offset: 0x002978BD
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

		// Token: 0x17003AD4 RID: 15060
		// (get) Token: 0x06011C1D RID: 72733 RVA: 0x002996C6 File Offset: 0x002978C6
		// (set) Token: 0x06011C1E RID: 72734 RVA: 0x002996CE File Offset: 0x002978CE
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

		// Token: 0x17003AD5 RID: 15061
		// (get) Token: 0x06011C1F RID: 72735 RVA: 0x002996D7 File Offset: 0x002978D7
		// (set) Token: 0x06011C20 RID: 72736 RVA: 0x002996DF File Offset: 0x002978DF
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

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x06011C21 RID: 72737 RVA: 0x002996E8 File Offset: 0x002978E8
		// (set) Token: 0x06011C22 RID: 72738 RVA: 0x002996F0 File Offset: 0x002978F0
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

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x06011C23 RID: 72739 RVA: 0x002996F9 File Offset: 0x002978F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomMainProp
		{
			get
			{
				return this.phantomMainProp_;
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x06011C24 RID: 72740 RVA: 0x00299701 File Offset: 0x00297901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomSubProp
		{
			get
			{
				return this.phantomSubProp_;
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x06011C25 RID: 72741 RVA: 0x00299709 File Offset: 0x00297909
		// (set) Token: 0x06011C26 RID: 72742 RVA: 0x00299711 File Offset: 0x00297911
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

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x06011C27 RID: 72743 RVA: 0x0029971A File Offset: 0x0029791A
		// (set) Token: 0x06011C28 RID: 72744 RVA: 0x00299722 File Offset: 0x00297922
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

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x06011C29 RID: 72745 RVA: 0x0029972B File Offset: 0x0029792B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> UnAckSubProp
		{
			get
			{
				return this.unAckSubProp_;
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x06011C2A RID: 72746 RVA: 0x00299733 File Offset: 0x00297933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockPropIndex
		{
			get
			{
				return this.lockPropIndex_;
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x06011C2B RID: 72747 RVA: 0x0029973B File Offset: 0x0029793B
		// (set) Token: 0x06011C2C RID: 72748 RVA: 0x00299743 File Offset: 0x00297943
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

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x06011C2D RID: 72749 RVA: 0x0029974C File Offset: 0x0029794C
		// (set) Token: 0x06011C2E RID: 72750 RVA: 0x00299754 File Offset: 0x00297954
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

		// Token: 0x06011C2F RID: 72751 RVA: 0x0029975D File Offset: 0x0029795D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomItem);
		}

		// Token: 0x06011C30 RID: 72752 RVA: 0x0029976C File Offset: 0x0029796C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.PhantomLevel == other.PhantomLevel && this.PhantomExp == other.PhantomExp && this.phantomMainProp_.Equals(other.phantomMainProp_) && this.phantomSubProp_.Equals(other.phantomSubProp_) && this.FetterGroupId == other.FetterGroupId && this.SkinId == other.SkinId && this.unAckSubProp_.Equals(other.unAckSubProp_) && this.lockPropIndex_.Equals(other.lockPropIndex_) && this.StackCount == other.StackCount && this.AddTime == other.AddTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011C31 RID: 72753 RVA: 0x0029987C File Offset: 0x00297A7C
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

		// Token: 0x06011C32 RID: 72754 RVA: 0x002999BB File Offset: 0x00297BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011C33 RID: 72755 RVA: 0x002999C8 File Offset: 0x00297BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011C34 RID: 72756 RVA: 0x002999D4 File Offset: 0x00297BD4
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

		// Token: 0x06011C35 RID: 72757 RVA: 0x00299B34 File Offset: 0x00297D34
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

		// Token: 0x06011C36 RID: 72758 RVA: 0x00299C80 File Offset: 0x00297E80
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

		// Token: 0x06011C37 RID: 72759 RVA: 0x00299DA0 File Offset: 0x00297FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011C38 RID: 72760 RVA: 0x00299DAC File Offset: 0x00297FAC
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

		// Token: 0x04006FEC RID: 28652
		private static readonly MessageParser<PhantomItem> _parser = new MessageParser<PhantomItem>(() => new PhantomItem());

		// Token: 0x04006FED RID: 28653
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006FEE RID: 28654
		public const int IdFieldNumber = 1;

		// Token: 0x04006FEF RID: 28655
		private int id_;

		// Token: 0x04006FF0 RID: 28656
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04006FF1 RID: 28657
		private int incrId_;

		// Token: 0x04006FF2 RID: 28658
		public const int FuncValueFieldNumber = 3;

		// Token: 0x04006FF3 RID: 28659
		private int funcValue_;

		// Token: 0x04006FF4 RID: 28660
		public const int PhantomLevelFieldNumber = 4;

		// Token: 0x04006FF5 RID: 28661
		private int phantomLevel_;

		// Token: 0x04006FF6 RID: 28662
		public const int PhantomExpFieldNumber = 5;

		// Token: 0x04006FF7 RID: 28663
		private int phantomExp_;

		// Token: 0x04006FF8 RID: 28664
		public const int PhantomMainPropFieldNumber = 6;

		// Token: 0x04006FF9 RID: 28665
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomMainProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(50U, PhantomPropInfo.Parser);

		// Token: 0x04006FFA RID: 28666
		private readonly RepeatedField<PhantomPropInfo> phantomMainProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04006FFB RID: 28667
		public const int PhantomSubPropFieldNumber = 7;

		// Token: 0x04006FFC RID: 28668
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(58U, PhantomPropInfo.Parser);

		// Token: 0x04006FFD RID: 28669
		private readonly RepeatedField<PhantomPropInfo> phantomSubProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04006FFE RID: 28670
		public const int FetterGroupIdFieldNumber = 8;

		// Token: 0x04006FFF RID: 28671
		private int fetterGroupId_;

		// Token: 0x04007000 RID: 28672
		public const int SkinIdFieldNumber = 9;

		// Token: 0x04007001 RID: 28673
		private int skinId_;

		// Token: 0x04007002 RID: 28674
		public const int UnAckSubPropFieldNumber = 10;

		// Token: 0x04007003 RID: 28675
		private static readonly FieldCodec<PhantomPropInfo> _repeated_unAckSubProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(82U, PhantomPropInfo.Parser);

		// Token: 0x04007004 RID: 28676
		private readonly RepeatedField<PhantomPropInfo> unAckSubProp_ = new RepeatedField<PhantomPropInfo>();

		// Token: 0x04007005 RID: 28677
		public const int LockPropIndexFieldNumber = 11;

		// Token: 0x04007006 RID: 28678
		private static readonly FieldCodec<int> _repeated_lockPropIndex_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04007007 RID: 28679
		private readonly RepeatedField<int> lockPropIndex_ = new RepeatedField<int>();

		// Token: 0x04007008 RID: 28680
		public const int StackCountFieldNumber = 12;

		// Token: 0x04007009 RID: 28681
		private int stackCount_;

		// Token: 0x0400700A RID: 28682
		public const int AddTimeFieldNumber = 13;

		// Token: 0x0400700B RID: 28683
		private long addTime_;
	}
}
