using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001279 RID: 4729
	public sealed class SkillNodeInfo : IMessage<SkillNodeInfo>, IMessage, IEquatable<SkillNodeInfo>, IDeepCloneable<SkillNodeInfo>, IBufferMessage
	{
		// Token: 0x060193F1 RID: 103409 RVA: 0x003AEAFE File Offset: 0x003ACCFE
		[NullableContext(1)]
		public static SkillNodeInfo Create()
		{
			return new SkillNodeInfo();
		}

		// Token: 0x17005561 RID: 21857
		// (get) Token: 0x060193F2 RID: 103410 RVA: 0x003AEB05 File Offset: 0x003ACD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005562 RID: 21858
		// (get) Token: 0x060193F3 RID: 103411 RVA: 0x003AEB08 File Offset: 0x003ACD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillNodeInfo.Descriptor;
			}
		}

		// Token: 0x060193F4 RID: 103412 RVA: 0x003AEB0F File Offset: 0x003ACD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo()
		{
		}

		// Token: 0x060193F5 RID: 103413 RVA: 0x003AEB24 File Offset: 0x003ACD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo(SkillNodeInfo other) : this()
		{
			this.subProtocol_ = other.subProtocol_;
			this.montageIndex_ = other.montageIndex_;
			this.speedRatio_ = other.speedRatio_;
			this.skillSingleId_ = other.skillSingleId_;
			this.skillIndex_ = other.skillIndex_;
			this.startSection_ = other.startSection_;
			this.startTimeSeconds_ = other.startTimeSeconds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060193F6 RID: 103414 RVA: 0x003AEB9C File Offset: 0x003ACD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo Clone()
		{
			return new SkillNodeInfo(this);
		}

		// Token: 0x17005563 RID: 21859
		// (get) Token: 0x060193F7 RID: 103415 RVA: 0x003AEBA4 File Offset: 0x003ACDA4
		// (set) Token: 0x060193F8 RID: 103416 RVA: 0x003AEBAC File Offset: 0x003ACDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubProtocol
		{
			get
			{
				return this.subProtocol_;
			}
			set
			{
				this.subProtocol_ = value;
			}
		}

		// Token: 0x17005564 RID: 21860
		// (get) Token: 0x060193F9 RID: 103417 RVA: 0x003AEBB5 File Offset: 0x003ACDB5
		// (set) Token: 0x060193FA RID: 103418 RVA: 0x003AEBBD File Offset: 0x003ACDBD
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

		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x060193FB RID: 103419 RVA: 0x003AEBC6 File Offset: 0x003ACDC6
		// (set) Token: 0x060193FC RID: 103420 RVA: 0x003AEBCE File Offset: 0x003ACDCE
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

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x060193FD RID: 103421 RVA: 0x003AEBD7 File Offset: 0x003ACDD7
		// (set) Token: 0x060193FE RID: 103422 RVA: 0x003AEBDF File Offset: 0x003ACDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x060193FF RID: 103423 RVA: 0x003AEBE8 File Offset: 0x003ACDE8
		// (set) Token: 0x06019400 RID: 103424 RVA: 0x003AEBF0 File Offset: 0x003ACDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillIndex
		{
			get
			{
				return this.skillIndex_;
			}
			set
			{
				this.skillIndex_ = value;
			}
		}

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x06019401 RID: 103425 RVA: 0x003AEBF9 File Offset: 0x003ACDF9
		// (set) Token: 0x06019402 RID: 103426 RVA: 0x003AEC01 File Offset: 0x003ACE01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string StartSection
		{
			get
			{
				return this.startSection_;
			}
			set
			{
				this.startSection_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x06019403 RID: 103427 RVA: 0x003AEC14 File Offset: 0x003ACE14
		// (set) Token: 0x06019404 RID: 103428 RVA: 0x003AEC1C File Offset: 0x003ACE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float StartTimeSeconds
		{
			get
			{
				return this.startTimeSeconds_;
			}
			set
			{
				this.startTimeSeconds_ = value;
			}
		}

		// Token: 0x06019405 RID: 103429 RVA: 0x003AEC25 File Offset: 0x003ACE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillNodeInfo);
		}

		// Token: 0x06019406 RID: 103430 RVA: 0x003AEC34 File Offset: 0x003ACE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillNodeInfo other)
		{
			return other != null && (other == this || (this.SubProtocol == other.SubProtocol && this.MontageIndex == other.MontageIndex && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && this.SkillSingleId == other.SkillSingleId && this.SkillIndex == other.SkillIndex && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019407 RID: 103431 RVA: 0x003AECE8 File Offset: 0x003ACEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubProtocol != 0)
			{
				num ^= this.SubProtocol.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this.SpeedRatio != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.SpeedRatio);
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
			if (this.SkillIndex != 0)
			{
				num ^= this.SkillIndex.GetHashCode();
			}
			if (this.StartSection.Length != 0)
			{
				num ^= this.StartSection.GetHashCode();
			}
			if (this.StartTimeSeconds != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.StartTimeSeconds);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019408 RID: 103432 RVA: 0x003AEDCD File Offset: 0x003ACFCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019409 RID: 103433 RVA: 0x003AEDDA File Offset: 0x003ACFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601940A RID: 103434 RVA: 0x003AEDE4 File Offset: 0x003ACFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubProtocol != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubProtocol);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.SpeedRatio != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.SpeedRatio);
			}
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.SkillIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillIndex);
			}
			if (this.StartSection.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.StartSection);
			}
			if (this.StartTimeSeconds != 0f)
			{
				output.WriteRawTag(61);
				output.WriteFloat(this.StartTimeSeconds);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601940B RID: 103435 RVA: 0x003AEED8 File Offset: 0x003AD0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubProtocol != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubProtocol);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this.SpeedRatio != 0f)
			{
				num += 5;
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
			if (this.SkillIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillIndex);
			}
			if (this.StartSection.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.StartSection);
			}
			if (this.StartTimeSeconds != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601940C RID: 103436 RVA: 0x003AEFA0 File Offset: 0x003AD1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubProtocol != 0)
			{
				this.SubProtocol = other.SubProtocol;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			if (other.SpeedRatio != 0f)
			{
				this.SpeedRatio = other.SpeedRatio;
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.SkillIndex != 0)
			{
				this.SkillIndex = other.SkillIndex;
			}
			if (other.StartSection.Length != 0)
			{
				this.StartSection = other.StartSection;
			}
			if (other.StartTimeSeconds != 0f)
			{
				this.StartTimeSeconds = other.StartTimeSeconds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601940D RID: 103437 RVA: 0x003AF063 File Offset: 0x003AD263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601940E RID: 103438 RVA: 0x003AF06C File Offset: 0x003AD26C
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
				if (num <= 29U)
				{
					if (num == 8U)
					{
						this.SubProtocol = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.MontageIndex = input.ReadInt32();
						continue;
					}
					if (num == 29U)
					{
						this.SpeedRatio = input.ReadFloat();
						continue;
					}
				}
				else if (num <= 40U)
				{
					if (num == 32U)
					{
						this.SkillSingleId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.SkillIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.StartSection = input.ReadString();
						continue;
					}
					if (num == 61U)
					{
						this.StartTimeSeconds = input.ReadFloat();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400956F RID: 38255
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009570 RID: 38256
		public const int SubProtocolFieldNumber = 1;

		// Token: 0x04009571 RID: 38257
		private int subProtocol_;

		// Token: 0x04009572 RID: 38258
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x04009573 RID: 38259
		private int montageIndex_;

		// Token: 0x04009574 RID: 38260
		public const int SpeedRatioFieldNumber = 3;

		// Token: 0x04009575 RID: 38261
		private float speedRatio_;

		// Token: 0x04009576 RID: 38262
		public const int SkillSingleIdFieldNumber = 4;

		// Token: 0x04009577 RID: 38263
		private int skillSingleId_;

		// Token: 0x04009578 RID: 38264
		public const int SkillIndexFieldNumber = 5;

		// Token: 0x04009579 RID: 38265
		private int skillIndex_;

		// Token: 0x0400957A RID: 38266
		public const int StartSectionFieldNumber = 6;

		// Token: 0x0400957B RID: 38267
		private string startSection_ = "";

		// Token: 0x0400957C RID: 38268
		public const int StartTimeSecondsFieldNumber = 7;

		// Token: 0x0400957D RID: 38269
		private float startTimeSeconds_;
	}
}
