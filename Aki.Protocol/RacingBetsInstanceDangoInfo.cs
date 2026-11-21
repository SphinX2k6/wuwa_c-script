using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E52 RID: 3666
	public sealed class RacingBetsInstanceDangoInfo : IMessage<RacingBetsInstanceDangoInfo>, IMessage, IEquatable<RacingBetsInstanceDangoInfo>, IDeepCloneable<RacingBetsInstanceDangoInfo>, IBufferMessage
	{
		// Token: 0x06013B6F RID: 80751 RVA: 0x002DEB55 File Offset: 0x002DCD55
		[NullableContext(1)]
		public static RacingBetsInstanceDangoInfo Create()
		{
			return new RacingBetsInstanceDangoInfo();
		}

		// Token: 0x1700417F RID: 16767
		// (get) Token: 0x06013B70 RID: 80752 RVA: 0x002DEB5C File Offset: 0x002DCD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsInstanceDangoInfo> Parser
		{
			get
			{
				return RacingBetsInstanceDangoInfo._parser;
			}
		}

		// Token: 0x17004180 RID: 16768
		// (get) Token: 0x06013B71 RID: 80753 RVA: 0x002DEB63 File Offset: 0x002DCD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004181 RID: 16769
		// (get) Token: 0x06013B72 RID: 80754 RVA: 0x002DEB66 File Offset: 0x002DCD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsInstanceDangoInfo.Descriptor;
			}
		}

		// Token: 0x06013B73 RID: 80755 RVA: 0x002DEB6D File Offset: 0x002DCD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo()
		{
		}

		// Token: 0x06013B74 RID: 80756 RVA: 0x002DEB78 File Offset: 0x002DCD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo(RacingBetsInstanceDangoInfo other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.curPoint_ = other.curPoint_;
			this.diceId_ = other.diceId_;
			this.high_ = other.high_;
			this.entityId_ = other.entityId_;
			this.bpId_ = other.bpId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B75 RID: 80757 RVA: 0x002DEBE4 File Offset: 0x002DCDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsInstanceDangoInfo Clone()
		{
			return new RacingBetsInstanceDangoInfo(this);
		}

		// Token: 0x17004182 RID: 16770
		// (get) Token: 0x06013B76 RID: 80758 RVA: 0x002DEBEC File Offset: 0x002DCDEC
		// (set) Token: 0x06013B77 RID: 80759 RVA: 0x002DEBF4 File Offset: 0x002DCDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x17004183 RID: 16771
		// (get) Token: 0x06013B78 RID: 80760 RVA: 0x002DEBFD File Offset: 0x002DCDFD
		// (set) Token: 0x06013B79 RID: 80761 RVA: 0x002DEC05 File Offset: 0x002DCE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x06013B7A RID: 80762 RVA: 0x002DEC0E File Offset: 0x002DCE0E
		// (set) Token: 0x06013B7B RID: 80763 RVA: 0x002DEC16 File Offset: 0x002DCE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiceId
		{
			get
			{
				return this.diceId_;
			}
			set
			{
				this.diceId_ = value;
			}
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x06013B7C RID: 80764 RVA: 0x002DEC1F File Offset: 0x002DCE1F
		// (set) Token: 0x06013B7D RID: 80765 RVA: 0x002DEC27 File Offset: 0x002DCE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int High
		{
			get
			{
				return this.high_;
			}
			set
			{
				this.high_ = value;
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x06013B7E RID: 80766 RVA: 0x002DEC30 File Offset: 0x002DCE30
		// (set) Token: 0x06013B7F RID: 80767 RVA: 0x002DEC38 File Offset: 0x002DCE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x06013B80 RID: 80768 RVA: 0x002DEC41 File Offset: 0x002DCE41
		// (set) Token: 0x06013B81 RID: 80769 RVA: 0x002DEC49 File Offset: 0x002DCE49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BpId
		{
			get
			{
				return this.bpId_;
			}
			set
			{
				this.bpId_ = value;
			}
		}

		// Token: 0x06013B82 RID: 80770 RVA: 0x002DEC52 File Offset: 0x002DCE52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsInstanceDangoInfo);
		}

		// Token: 0x06013B83 RID: 80771 RVA: 0x002DEC60 File Offset: 0x002DCE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsInstanceDangoInfo other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.CurPoint == other.CurPoint && this.DiceId == other.DiceId && this.High == other.High && this.EntityId == other.EntityId && this.BpId == other.BpId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B84 RID: 80772 RVA: 0x002DECEC File Offset: 0x002DCEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.DiceId != 0)
			{
				num ^= this.DiceId.GetHashCode();
			}
			if (this.High != 0)
			{
				num ^= this.High.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.BpId != 0)
			{
				num ^= this.BpId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B85 RID: 80773 RVA: 0x002DEDA8 File Offset: 0x002DCFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B86 RID: 80774 RVA: 0x002DEDB5 File Offset: 0x002DCFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B87 RID: 80775 RVA: 0x002DEDC0 File Offset: 0x002DCFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurPoint);
			}
			if (this.DiceId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DiceId);
			}
			if (this.High != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.High);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.BpId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.BpId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B88 RID: 80776 RVA: 0x002DEE88 File Offset: 0x002DD088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.DiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiceId);
			}
			if (this.High != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.High);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.BpId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BpId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B89 RID: 80777 RVA: 0x002DEF40 File Offset: 0x002DD140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsInstanceDangoInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.DiceId != 0)
			{
				this.DiceId = other.DiceId;
			}
			if (other.High != 0)
			{
				this.High = other.High;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.BpId != 0)
			{
				this.BpId = other.BpId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B8A RID: 80778 RVA: 0x002DEFE0 File Offset: 0x002DD1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B8B RID: 80779 RVA: 0x002DEFEC File Offset: 0x002DD1EC
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
					if (num == 8U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.DiceId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.High = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.BpId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007912 RID: 30994
		private static readonly MessageParser<RacingBetsInstanceDangoInfo> _parser = new MessageParser<RacingBetsInstanceDangoInfo>(() => new RacingBetsInstanceDangoInfo());

		// Token: 0x04007913 RID: 30995
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007914 RID: 30996
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007915 RID: 30997
		private int dangoId_;

		// Token: 0x04007916 RID: 30998
		public const int CurPointFieldNumber = 2;

		// Token: 0x04007917 RID: 30999
		private int curPoint_;

		// Token: 0x04007918 RID: 31000
		public const int DiceIdFieldNumber = 3;

		// Token: 0x04007919 RID: 31001
		private int diceId_;

		// Token: 0x0400791A RID: 31002
		public const int HighFieldNumber = 4;

		// Token: 0x0400791B RID: 31003
		private int high_;

		// Token: 0x0400791C RID: 31004
		public const int EntityIdFieldNumber = 5;

		// Token: 0x0400791D RID: 31005
		private long entityId_;

		// Token: 0x0400791E RID: 31006
		public const int BpIdFieldNumber = 6;

		// Token: 0x0400791F RID: 31007
		private int bpId_;
	}
}
