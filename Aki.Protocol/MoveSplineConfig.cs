using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB4 RID: 2740
	public sealed class MoveSplineConfig : IMessage<MoveSplineConfig>, IMessage, IEquatable<MoveSplineConfig>, IDeepCloneable<MoveSplineConfig>, IBufferMessage
	{
		// Token: 0x0600EEE1 RID: 61153 RVA: 0x0022EBD5 File Offset: 0x0022CDD5
		[NullableContext(1)]
		public static MoveSplineConfig Create()
		{
			return new MoveSplineConfig();
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600EEE2 RID: 61154 RVA: 0x0022EBDC File Offset: 0x0022CDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600EEE3 RID: 61155 RVA: 0x0022EBDF File Offset: 0x0022CDDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoveSplineConfig.Descriptor;
			}
		}

		// Token: 0x0600EEE4 RID: 61156 RVA: 0x0022EBE6 File Offset: 0x0022CDE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig()
		{
		}

		// Token: 0x0600EEE5 RID: 61157 RVA: 0x0022EBF0 File Offset: 0x0022CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig(MoveSplineConfig other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.startPointIndex_ = other.startPointIndex_;
			this.endPointIndex_ = other.endPointIndex_;
			this.isLookDir_ = other.isLookDir_;
			this.cycleCount_ = other.cycleCount_;
			this.isCircle_ = other.isCircle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EEE6 RID: 61158 RVA: 0x0022EC5C File Offset: 0x0022CE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveSplineConfig Clone()
		{
			return new MoveSplineConfig(this);
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600EEE7 RID: 61159 RVA: 0x0022EC64 File Offset: 0x0022CE64
		// (set) Token: 0x0600EEE8 RID: 61160 RVA: 0x0022EC7C File Offset: 0x0022CE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartPointIndex
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.startPointIndex_;
				}
				return MoveSplineConfig.StartPointIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.startPointIndex_ = value;
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600EEE9 RID: 61161 RVA: 0x0022EC93 File Offset: 0x0022CE93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasStartPointIndex
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600EEEA RID: 61162 RVA: 0x0022ECA0 File Offset: 0x0022CEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearStartPointIndex()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600EEEB RID: 61163 RVA: 0x0022ECB1 File Offset: 0x0022CEB1
		// (set) Token: 0x0600EEEC RID: 61164 RVA: 0x0022ECC9 File Offset: 0x0022CEC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EndPointIndex
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.endPointIndex_;
				}
				return MoveSplineConfig.EndPointIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.endPointIndex_ = value;
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600EEED RID: 61165 RVA: 0x0022ECE0 File Offset: 0x0022CEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasEndPointIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600EEEE RID: 61166 RVA: 0x0022ECED File Offset: 0x0022CEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEndPointIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600EEEF RID: 61167 RVA: 0x0022ECFE File Offset: 0x0022CEFE
		// (set) Token: 0x0600EEF0 RID: 61168 RVA: 0x0022ED16 File Offset: 0x0022CF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsLookDir
		{
			get
			{
				if ((this._hasBits0 & 4) != 0)
				{
					return this.isLookDir_;
				}
				return MoveSplineConfig.IsLookDirDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isLookDir_ = value;
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600EEF1 RID: 61169 RVA: 0x0022ED2D File Offset: 0x0022CF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsLookDir
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x0600EEF2 RID: 61170 RVA: 0x0022ED3A File Offset: 0x0022CF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsLookDir()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600EEF3 RID: 61171 RVA: 0x0022ED4B File Offset: 0x0022CF4B
		// (set) Token: 0x0600EEF4 RID: 61172 RVA: 0x0022ED63 File Offset: 0x0022CF63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleCount
		{
			get
			{
				if ((this._hasBits0 & 8) != 0)
				{
					return this.cycleCount_;
				}
				return MoveSplineConfig.CycleCountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.cycleCount_ = value;
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600EEF5 RID: 61173 RVA: 0x0022ED7A File Offset: 0x0022CF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasCycleCount
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x0600EEF6 RID: 61174 RVA: 0x0022ED87 File Offset: 0x0022CF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearCycleCount()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x1700309F RID: 12447
		// (get) Token: 0x0600EEF7 RID: 61175 RVA: 0x0022ED98 File Offset: 0x0022CF98
		// (set) Token: 0x0600EEF8 RID: 61176 RVA: 0x0022EDB1 File Offset: 0x0022CFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCircle
		{
			get
			{
				if ((this._hasBits0 & 16) != 0)
				{
					return this.isCircle_;
				}
				return MoveSplineConfig.IsCircleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.isCircle_ = value;
			}
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x0600EEF9 RID: 61177 RVA: 0x0022EDC9 File Offset: 0x0022CFC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsCircle
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x0600EEFA RID: 61178 RVA: 0x0022EDD7 File Offset: 0x0022CFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsCircle()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x0600EEFB RID: 61179 RVA: 0x0022EDE8 File Offset: 0x0022CFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoveSplineConfig);
		}

		// Token: 0x0600EEFC RID: 61180 RVA: 0x0022EDF8 File Offset: 0x0022CFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoveSplineConfig other)
		{
			return other != null && (other == this || (this.StartPointIndex == other.StartPointIndex && this.EndPointIndex == other.EndPointIndex && this.IsLookDir == other.IsLookDir && this.CycleCount == other.CycleCount && this.IsCircle == other.IsCircle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EEFD RID: 61181 RVA: 0x0022EE74 File Offset: 0x0022D074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasStartPointIndex)
			{
				num ^= this.StartPointIndex.GetHashCode();
			}
			if (this.HasEndPointIndex)
			{
				num ^= this.EndPointIndex.GetHashCode();
			}
			if (this.HasIsLookDir)
			{
				num ^= this.IsLookDir.GetHashCode();
			}
			if (this.HasCycleCount)
			{
				num ^= this.CycleCount.GetHashCode();
			}
			if (this.HasIsCircle)
			{
				num ^= this.IsCircle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EEFE RID: 61182 RVA: 0x0022EF17 File Offset: 0x0022D117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EEFF RID: 61183 RVA: 0x0022EF24 File Offset: 0x0022D124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF00 RID: 61184 RVA: 0x0022EF30 File Offset: 0x0022D130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasStartPointIndex)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.StartPointIndex);
			}
			if (this.HasEndPointIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EndPointIndex);
			}
			if (this.HasIsLookDir)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsLookDir);
			}
			if (this.HasCycleCount)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CycleCount);
			}
			if (this.HasIsCircle)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsCircle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EF01 RID: 61185 RVA: 0x0022EFDC File Offset: 0x0022D1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasStartPointIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartPointIndex);
			}
			if (this.HasEndPointIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EndPointIndex);
			}
			if (this.HasIsLookDir)
			{
				num += 2;
			}
			if (this.HasCycleCount)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleCount);
			}
			if (this.HasIsCircle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EF02 RID: 61186 RVA: 0x0022F064 File Offset: 0x0022D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoveSplineConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasStartPointIndex)
			{
				this.StartPointIndex = other.StartPointIndex;
			}
			if (other.HasEndPointIndex)
			{
				this.EndPointIndex = other.EndPointIndex;
			}
			if (other.HasIsLookDir)
			{
				this.IsLookDir = other.IsLookDir;
			}
			if (other.HasCycleCount)
			{
				this.CycleCount = other.CycleCount;
			}
			if (other.HasIsCircle)
			{
				this.IsCircle = other.IsCircle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x0022F0F0 File Offset: 0x0022D2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF04 RID: 61188 RVA: 0x0022F0FC File Offset: 0x0022D2FC
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.StartPointIndex = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.EndPointIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsLookDir = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.CycleCount = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.IsCircle = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400610D RID: 24845
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400610E RID: 24846
		private int _hasBits0;

		// Token: 0x0400610F RID: 24847
		public const int StartPointIndexFieldNumber = 1;

		// Token: 0x04006110 RID: 24848
		private static readonly int StartPointIndexDefaultValue;

		// Token: 0x04006111 RID: 24849
		private int startPointIndex_;

		// Token: 0x04006112 RID: 24850
		public const int EndPointIndexFieldNumber = 2;

		// Token: 0x04006113 RID: 24851
		private static readonly int EndPointIndexDefaultValue;

		// Token: 0x04006114 RID: 24852
		private int endPointIndex_;

		// Token: 0x04006115 RID: 24853
		public const int IsLookDirFieldNumber = 3;

		// Token: 0x04006116 RID: 24854
		private static readonly bool IsLookDirDefaultValue;

		// Token: 0x04006117 RID: 24855
		private bool isLookDir_;

		// Token: 0x04006118 RID: 24856
		public const int CycleCountFieldNumber = 4;

		// Token: 0x04006119 RID: 24857
		private static readonly int CycleCountDefaultValue;

		// Token: 0x0400611A RID: 24858
		private int cycleCount_;

		// Token: 0x0400611B RID: 24859
		public const int IsCircleFieldNumber = 5;

		// Token: 0x0400611C RID: 24860
		private static readonly bool IsCircleDefaultValue;

		// Token: 0x0400611D RID: 24861
		private bool isCircle_;
	}
}
