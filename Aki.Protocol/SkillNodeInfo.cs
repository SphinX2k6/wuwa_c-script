using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200123C RID: 4668
	public sealed class SkillNodeInfo : IMessage<SkillNodeInfo>, IMessage, IEquatable<SkillNodeInfo>, IDeepCloneable<SkillNodeInfo>, IBufferMessage
	{
		// Token: 0x06018E07 RID: 101895 RVA: 0x0039EB9E File Offset: 0x0039CD9E
		[NullableContext(1)]
		public static SkillNodeInfo Create()
		{
			return new SkillNodeInfo();
		}

		// Token: 0x170053E2 RID: 21474
		// (get) Token: 0x06018E08 RID: 101896 RVA: 0x0039EBA5 File Offset: 0x0039CDA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053E3 RID: 21475
		// (get) Token: 0x06018E09 RID: 101897 RVA: 0x0039EBA8 File Offset: 0x0039CDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillNodeInfo.Descriptor;
			}
		}

		// Token: 0x06018E0A RID: 101898 RVA: 0x0039EBAF File Offset: 0x0039CDAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo()
		{
		}

		// Token: 0x06018E0B RID: 101899 RVA: 0x0039EBC4 File Offset: 0x0039CDC4
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

		// Token: 0x06018E0C RID: 101900 RVA: 0x0039EC3C File Offset: 0x0039CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillNodeInfo Clone()
		{
			return new SkillNodeInfo(this);
		}

		// Token: 0x170053E4 RID: 21476
		// (get) Token: 0x06018E0D RID: 101901 RVA: 0x0039EC44 File Offset: 0x0039CE44
		// (set) Token: 0x06018E0E RID: 101902 RVA: 0x0039EC4C File Offset: 0x0039CE4C
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

		// Token: 0x170053E5 RID: 21477
		// (get) Token: 0x06018E0F RID: 101903 RVA: 0x0039EC55 File Offset: 0x0039CE55
		// (set) Token: 0x06018E10 RID: 101904 RVA: 0x0039EC5D File Offset: 0x0039CE5D
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

		// Token: 0x170053E6 RID: 21478
		// (get) Token: 0x06018E11 RID: 101905 RVA: 0x0039EC66 File Offset: 0x0039CE66
		// (set) Token: 0x06018E12 RID: 101906 RVA: 0x0039EC6E File Offset: 0x0039CE6E
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

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x06018E13 RID: 101907 RVA: 0x0039EC77 File Offset: 0x0039CE77
		// (set) Token: 0x06018E14 RID: 101908 RVA: 0x0039EC7F File Offset: 0x0039CE7F
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

		// Token: 0x170053E8 RID: 21480
		// (get) Token: 0x06018E15 RID: 101909 RVA: 0x0039EC88 File Offset: 0x0039CE88
		// (set) Token: 0x06018E16 RID: 101910 RVA: 0x0039EC90 File Offset: 0x0039CE90
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

		// Token: 0x170053E9 RID: 21481
		// (get) Token: 0x06018E17 RID: 101911 RVA: 0x0039EC99 File Offset: 0x0039CE99
		// (set) Token: 0x06018E18 RID: 101912 RVA: 0x0039ECA1 File Offset: 0x0039CEA1
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

		// Token: 0x170053EA RID: 21482
		// (get) Token: 0x06018E19 RID: 101913 RVA: 0x0039ECB4 File Offset: 0x0039CEB4
		// (set) Token: 0x06018E1A RID: 101914 RVA: 0x0039ECBC File Offset: 0x0039CEBC
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

		// Token: 0x06018E1B RID: 101915 RVA: 0x0039ECC5 File Offset: 0x0039CEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillNodeInfo);
		}

		// Token: 0x06018E1C RID: 101916 RVA: 0x0039ECD4 File Offset: 0x0039CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillNodeInfo other)
		{
			return other != null && (other == this || (this.SubProtocol == other.SubProtocol && this.MontageIndex == other.MontageIndex && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.SpeedRatio, other.SpeedRatio) && this.SkillSingleId == other.SkillSingleId && this.SkillIndex == other.SkillIndex && !(this.StartSection != other.StartSection) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.StartTimeSeconds, other.StartTimeSeconds) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E1D RID: 101917 RVA: 0x0039ED88 File Offset: 0x0039CF88
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

		// Token: 0x06018E1E RID: 101918 RVA: 0x0039EE6D File Offset: 0x0039D06D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E1F RID: 101919 RVA: 0x0039EE7A File Offset: 0x0039D07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E20 RID: 101920 RVA: 0x0039EE84 File Offset: 0x0039D084
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

		// Token: 0x06018E21 RID: 101921 RVA: 0x0039EF78 File Offset: 0x0039D178
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

		// Token: 0x06018E22 RID: 101922 RVA: 0x0039F040 File Offset: 0x0039D240
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

		// Token: 0x06018E23 RID: 101923 RVA: 0x0039F103 File Offset: 0x0039D303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E24 RID: 101924 RVA: 0x0039F10C File Offset: 0x0039D30C
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

		// Token: 0x040092BD RID: 37565
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092BE RID: 37566
		public const int SubProtocolFieldNumber = 1;

		// Token: 0x040092BF RID: 37567
		private int subProtocol_;

		// Token: 0x040092C0 RID: 37568
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x040092C1 RID: 37569
		private int montageIndex_;

		// Token: 0x040092C2 RID: 37570
		public const int SpeedRatioFieldNumber = 3;

		// Token: 0x040092C3 RID: 37571
		private float speedRatio_;

		// Token: 0x040092C4 RID: 37572
		public const int SkillSingleIdFieldNumber = 4;

		// Token: 0x040092C5 RID: 37573
		private int skillSingleId_;

		// Token: 0x040092C6 RID: 37574
		public const int SkillIndexFieldNumber = 5;

		// Token: 0x040092C7 RID: 37575
		private int skillIndex_;

		// Token: 0x040092C8 RID: 37576
		public const int StartSectionFieldNumber = 6;

		// Token: 0x040092C9 RID: 37577
		private string startSection_ = "";

		// Token: 0x040092CA RID: 37578
		public const int StartTimeSecondsFieldNumber = 7;

		// Token: 0x040092CB RID: 37579
		private float startTimeSeconds_;
	}
}
