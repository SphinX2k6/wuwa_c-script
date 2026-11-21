using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001277 RID: 4727
	public sealed class SkillExecuteInfoPb : IMessage<SkillExecuteInfoPb>, IMessage, IEquatable<SkillExecuteInfoPb>, IDeepCloneable<SkillExecuteInfoPb>, IBufferMessage
	{
		// Token: 0x060193BE RID: 103358 RVA: 0x003AE1E9 File Offset: 0x003AC3E9
		[NullableContext(1)]
		public static SkillExecuteInfoPb Create()
		{
			return new SkillExecuteInfoPb();
		}

		// Token: 0x17005553 RID: 21843
		// (get) Token: 0x060193BF RID: 103359 RVA: 0x003AE1F0 File Offset: 0x003AC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SkillExecuteInfoPb> Parser
		{
			get
			{
				return SkillExecuteInfoPb._parser;
			}
		}

		// Token: 0x17005554 RID: 21844
		// (get) Token: 0x060193C0 RID: 103360 RVA: 0x003AE1F7 File Offset: 0x003AC3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005555 RID: 21845
		// (get) Token: 0x060193C1 RID: 103361 RVA: 0x003AE1FA File Offset: 0x003AC3FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillExecuteInfoPb.Descriptor;
			}
		}

		// Token: 0x060193C2 RID: 103362 RVA: 0x003AE201 File Offset: 0x003AC401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillExecuteInfoPb()
		{
		}

		// Token: 0x060193C3 RID: 103363 RVA: 0x003AE214 File Offset: 0x003AC414
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

		// Token: 0x060193C4 RID: 103364 RVA: 0x003AE29C File Offset: 0x003AC49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillExecuteInfoPb Clone()
		{
			return new SkillExecuteInfoPb(this);
		}

		// Token: 0x17005556 RID: 21846
		// (get) Token: 0x060193C5 RID: 103365 RVA: 0x003AE2A4 File Offset: 0x003AC4A4
		// (set) Token: 0x060193C6 RID: 103366 RVA: 0x003AE2AC File Offset: 0x003AC4AC
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

		// Token: 0x17005557 RID: 21847
		// (get) Token: 0x060193C7 RID: 103367 RVA: 0x003AE2B5 File Offset: 0x003AC4B5
		// (set) Token: 0x060193C8 RID: 103368 RVA: 0x003AE2BD File Offset: 0x003AC4BD
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

		// Token: 0x17005558 RID: 21848
		// (get) Token: 0x060193C9 RID: 103369 RVA: 0x003AE2C6 File Offset: 0x003AC4C6
		// (set) Token: 0x060193CA RID: 103370 RVA: 0x003AE2CE File Offset: 0x003AC4CE
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

		// Token: 0x17005559 RID: 21849
		// (get) Token: 0x060193CB RID: 103371 RVA: 0x003AE2D7 File Offset: 0x003AC4D7
		// (set) Token: 0x060193CC RID: 103372 RVA: 0x003AE2DF File Offset: 0x003AC4DF
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

		// Token: 0x1700555A RID: 21850
		// (get) Token: 0x060193CD RID: 103373 RVA: 0x003AE2F2 File Offset: 0x003AC4F2
		// (set) Token: 0x060193CE RID: 103374 RVA: 0x003AE2FA File Offset: 0x003AC4FA
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

		// Token: 0x1700555B RID: 21851
		// (get) Token: 0x060193CF RID: 103375 RVA: 0x003AE303 File Offset: 0x003AC503
		// (set) Token: 0x060193D0 RID: 103376 RVA: 0x003AE30B File Offset: 0x003AC50B
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

		// Token: 0x1700555C RID: 21852
		// (get) Token: 0x060193D1 RID: 103377 RVA: 0x003AE314 File Offset: 0x003AC514
		// (set) Token: 0x060193D2 RID: 103378 RVA: 0x003AE31C File Offset: 0x003AC51C
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

		// Token: 0x060193D3 RID: 103379 RVA: 0x003AE325 File Offset: 0x003AC525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillExecuteInfoPb);
		}

		// Token: 0x060193D4 RID: 103380 RVA: 0x003AE334 File Offset: 0x003AC534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillExecuteInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.MontageIndex == other.MontageIndex && this.MontagePlayTime == other.MontagePlayTime && !(this.Section != other.Section) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && this.MessageId == other.MessageId && this.MontageContext == other.MontageContext && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193D5 RID: 103381 RVA: 0x003AE3E4 File Offset: 0x003AC5E4
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

		// Token: 0x060193D6 RID: 103382 RVA: 0x003AE4BF File Offset: 0x003AC6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193D7 RID: 103383 RVA: 0x003AE4CC File Offset: 0x003AC6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193D8 RID: 103384 RVA: 0x003AE4D8 File Offset: 0x003AC6D8
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

		// Token: 0x060193D9 RID: 103385 RVA: 0x003AE5C8 File Offset: 0x003AC7C8
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

		// Token: 0x060193DA RID: 103386 RVA: 0x003AE694 File Offset: 0x003AC894
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

		// Token: 0x060193DB RID: 103387 RVA: 0x003AE76A File Offset: 0x003AC96A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193DC RID: 103388 RVA: 0x003AE774 File Offset: 0x003AC974
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

		// Token: 0x04009558 RID: 38232
		private static readonly MessageParser<SkillExecuteInfoPb> _parser = new MessageParser<SkillExecuteInfoPb>(() => new SkillExecuteInfoPb());

		// Token: 0x04009559 RID: 38233
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400955A RID: 38234
		public const int UseSkillInfoFieldNumber = 1;

		// Token: 0x0400955B RID: 38235
		private UseSkillInformation useSkillInfo_;

		// Token: 0x0400955C RID: 38236
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x0400955D RID: 38237
		private int montageIndex_;

		// Token: 0x0400955E RID: 38238
		public const int MontagePlayTimeFieldNumber = 3;

		// Token: 0x0400955F RID: 38239
		private int montagePlayTime_;

		// Token: 0x04009560 RID: 38240
		public const int SectionFieldNumber = 4;

		// Token: 0x04009561 RID: 38241
		private string section_ = "";

		// Token: 0x04009562 RID: 38242
		public const int SpeedRatioFieldNumber = 5;

		// Token: 0x04009563 RID: 38243
		private float speedRatio_;

		// Token: 0x04009564 RID: 38244
		public const int MessageIdFieldNumber = 6;

		// Token: 0x04009565 RID: 38245
		private long messageId_;

		// Token: 0x04009566 RID: 38246
		public const int MontageContextFieldNumber = 7;

		// Token: 0x04009567 RID: 38247
		private long montageContext_;
	}
}
