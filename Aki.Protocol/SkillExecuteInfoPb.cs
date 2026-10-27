using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123A RID: 4666
	public sealed class SkillExecuteInfoPb : IMessage<SkillExecuteInfoPb>, IMessage, IEquatable<SkillExecuteInfoPb>, IDeepCloneable<SkillExecuteInfoPb>, IBufferMessage
	{
		// Token: 0x06018DD4 RID: 101844 RVA: 0x0039E289 File Offset: 0x0039C489
		[NullableContext(1)]
		public static SkillExecuteInfoPb Create()
		{
			return new SkillExecuteInfoPb();
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x06018DD5 RID: 101845 RVA: 0x0039E290 File Offset: 0x0039C490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillExecuteInfoPb> Parser
		{
			get
			{
				return SkillExecuteInfoPb._parser;
			}
		}

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x06018DD6 RID: 101846 RVA: 0x0039E297 File Offset: 0x0039C497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x06018DD7 RID: 101847 RVA: 0x0039E29A File Offset: 0x0039C49A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillExecuteInfoPb.Descriptor;
			}
		}

		// Token: 0x06018DD8 RID: 101848 RVA: 0x0039E2A1 File Offset: 0x0039C4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillExecuteInfoPb()
		{
		}

		// Token: 0x06018DD9 RID: 101849 RVA: 0x0039E2B4 File Offset: 0x0039C4B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillExecuteInfoPb(SkillExecuteInfoPb other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.montageIndex_ = other.montageIndex_;
			this.montagePlayTime_ = other.montagePlayTime_;
			this.section_ = other.section_;
			this.speedRatio_ = other.speedRatio_;
			this.messageId_ = other.messageId_;
			this.montageContext_ = other.montageContext_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DDA RID: 101850 RVA: 0x0039E33C File Offset: 0x0039C53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillExecuteInfoPb Clone()
		{
			return new SkillExecuteInfoPb(this);
		}

		// Token: 0x170053D7 RID: 21463
		// (get) Token: 0x06018DDB RID: 101851 RVA: 0x0039E344 File Offset: 0x0039C544
		// (set) Token: 0x06018DDC RID: 101852 RVA: 0x0039E34C File Offset: 0x0039C54C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x170053D8 RID: 21464
		// (get) Token: 0x06018DDD RID: 101853 RVA: 0x0039E355 File Offset: 0x0039C555
		// (set) Token: 0x06018DDE RID: 101854 RVA: 0x0039E35D File Offset: 0x0039C55D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x170053D9 RID: 21465
		// (get) Token: 0x06018DDF RID: 101855 RVA: 0x0039E366 File Offset: 0x0039C566
		// (set) Token: 0x06018DE0 RID: 101856 RVA: 0x0039E36E File Offset: 0x0039C56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontagePlayTime
		{
			get
			{
				return this.montagePlayTime_;
			}
			set
			{
				this.montagePlayTime_ = value;
			}
		}

		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x06018DE1 RID: 101857 RVA: 0x0039E377 File Offset: 0x0039C577
		// (set) Token: 0x06018DE2 RID: 101858 RVA: 0x0039E37F File Offset: 0x0039C57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Section
		{
			get
			{
				return this.section_;
			}
			set
			{
				this.section_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06018DE3 RID: 101859 RVA: 0x0039E392 File Offset: 0x0039C592
		// (set) Token: 0x06018DE4 RID: 101860 RVA: 0x0039E39A File Offset: 0x0039C59A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float SpeedRatio
		{
			get
			{
				return this.speedRatio_;
			}
			set
			{
				this.speedRatio_ = value;
			}
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06018DE5 RID: 101861 RVA: 0x0039E3A3 File Offset: 0x0039C5A3
		// (set) Token: 0x06018DE6 RID: 101862 RVA: 0x0039E3AB File Offset: 0x0039C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MessageId
		{
			get
			{
				return this.messageId_;
			}
			set
			{
				this.messageId_ = value;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x06018DE7 RID: 101863 RVA: 0x0039E3B4 File Offset: 0x0039C5B4
		// (set) Token: 0x06018DE8 RID: 101864 RVA: 0x0039E3BC File Offset: 0x0039C5BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long MontageContext
		{
			get
			{
				return this.montageContext_;
			}
			set
			{
				this.montageContext_ = value;
			}
		}

		// Token: 0x06018DE9 RID: 101865 RVA: 0x0039E3C5 File Offset: 0x0039C5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillExecuteInfoPb);
		}

		// Token: 0x06018DEA RID: 101866 RVA: 0x0039E3D4 File Offset: 0x0039C5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillExecuteInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.MontageIndex == other.MontageIndex && this.MontagePlayTime == other.MontagePlayTime && !(this.Section != other.Section) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && this.MessageId == other.MessageId && this.MontageContext == other.MontageContext && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DEB RID: 101867 RVA: 0x0039E484 File Offset: 0x0039C684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this.MontagePlayTime != 0)
			{
				num ^= this.MontagePlayTime.GetHashCode();
			}
			if (this.Section.Length != 0)
			{
				num ^= this.Section.GetHashCode();
			}
			if (this.SpeedRatio != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SpeedRatio);
			}
			if (this.MessageId != 0L)
			{
				num ^= this.MessageId.GetHashCode();
			}
			if (this.MontageContext != 0L)
			{
				num ^= this.MontageContext.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018DEC RID: 101868 RVA: 0x0039E55F File Offset: 0x0039C75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DED RID: 101869 RVA: 0x0039E56C File Offset: 0x0039C76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DEE RID: 101870 RVA: 0x0039E578 File Offset: 0x0039C778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.MontagePlayTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MontagePlayTime);
			}
			if (this.Section.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Section);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(45);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.MessageId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.MessageId);
			}
			if (this.MontageContext != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.MontageContext);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DEF RID: 101871 RVA: 0x0039E668 File Offset: 0x0039C868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this.MontagePlayTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontagePlayTime);
			}
			if (this.Section.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Section);
			}
			if (this.SpeedRatio != 0f)
			{
				num += 5;
			}
			if (this.MessageId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MessageId);
			}
			if (this.MontageContext != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.MontageContext);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018DF0 RID: 101872 RVA: 0x0039E734 File Offset: 0x0039C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillExecuteInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			if (other.MontagePlayTime != 0)
			{
				this.MontagePlayTime = other.MontagePlayTime;
			}
			if (other.Section.Length != 0)
			{
				this.Section = other.Section;
			}
			if (other.SpeedRatio != 0f)
			{
				this.SpeedRatio = other.SpeedRatio;
			}
			if (other.MessageId != 0L)
			{
				this.MessageId = other.MessageId;
			}
			if (other.MontageContext != 0L)
			{
				this.MontageContext = other.MontageContext;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DF1 RID: 101873 RVA: 0x0039E80A File Offset: 0x0039CA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DF2 RID: 101874 RVA: 0x0039E814 File Offset: 0x0039CA14
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
				if (num <= 24U)
				{
					if (num == 10U)
					{
						if (this.useSkillInfo_ == null)
						{
							this.UseSkillInfo = new UseSkillInformation();
						}
						input.ReadMessage(this.UseSkillInfo);
						continue;
					}
					if (num == 16U)
					{
						this.MontageIndex = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MontagePlayTime = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 45U)
				{
					if (num == 34U)
					{
						this.Section = input.ReadString();
						continue;
					}
					if (num == 45U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.MessageId = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.MontageContext = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040092A6 RID: 37542
		private static readonly MessageParser<SkillExecuteInfoPb> _parser = new MessageParser<SkillExecuteInfoPb>(() => new SkillExecuteInfoPb());

		// Token: 0x040092A7 RID: 37543
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092A8 RID: 37544
		public const int UseSkillInfoFieldNumber = 1;

		// Token: 0x040092A9 RID: 37545
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040092AA RID: 37546
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x040092AB RID: 37547
		private int montageIndex_;

		// Token: 0x040092AC RID: 37548
		public const int MontagePlayTimeFieldNumber = 3;

		// Token: 0x040092AD RID: 37549
		private int montagePlayTime_;

		// Token: 0x040092AE RID: 37550
		public const int SectionFieldNumber = 4;

		// Token: 0x040092AF RID: 37551
		private string section_ = "";

		// Token: 0x040092B0 RID: 37552
		public const int SpeedRatioFieldNumber = 5;

		// Token: 0x040092B1 RID: 37553
		private float speedRatio_;

		// Token: 0x040092B2 RID: 37554
		public const int MessageIdFieldNumber = 6;

		// Token: 0x040092B3 RID: 37555
		private long messageId_;

		// Token: 0x040092B4 RID: 37556
		public const int MontageContextFieldNumber = 7;

		// Token: 0x040092B5 RID: 37557
		private long montageContext_;
	}
}
