using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CA RID: 5322
	[NetMessage(EMessageId.TrapDefenseTechPointUpdateNotify)]
	public sealed class TrapDefenseTechPointUpdateNotify : IMessage<TrapDefenseTechPointUpdateNotify>, IMessage, IEquatable<TrapDefenseTechPointUpdateNotify>, IDeepCloneable<TrapDefenseTechPointUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601C3B7 RID: 115639 RVA: 0x0041907F File Offset: 0x0041727F
		[NullableContext(1)]
		public static TrapDefenseTechPointUpdateNotify Create()
		{
			return new TrapDefenseTechPointUpdateNotify();
		}

		// Token: 0x17005F8F RID: 24463
		// (get) Token: 0x0601C3B8 RID: 115640 RVA: 0x00419086 File Offset: 0x00417286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F90 RID: 24464
		// (get) Token: 0x0601C3B9 RID: 115641 RVA: 0x00419089 File Offset: 0x00417289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechPointUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601C3BA RID: 115642 RVA: 0x00419090 File Offset: 0x00417290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechPointUpdateNotify()
		{
		}

		// Token: 0x0601C3BB RID: 115643 RVA: 0x00419098 File Offset: 0x00417298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechPointUpdateNotify(TrapDefenseTechPointUpdateNotify other) : this()
		{
			this.totalTechPoint_ = other.totalTechPoint_;
			this.leftTechPoint_ = other.leftTechPoint_;
			this.leftLevelUpPoint_ = other.leftLevelUpPoint_;
			this.totalLevelUpPoint_ = other.totalLevelUpPoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C3BC RID: 115644 RVA: 0x004190EC File Offset: 0x004172EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechPointUpdateNotify Clone()
		{
			return new TrapDefenseTechPointUpdateNotify(this);
		}

		// Token: 0x17005F91 RID: 24465
		// (get) Token: 0x0601C3BD RID: 115645 RVA: 0x004190F4 File Offset: 0x004172F4
		// (set) Token: 0x0601C3BE RID: 115646 RVA: 0x004190FC File Offset: 0x004172FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalTechPoint
		{
			get
			{
				return this.totalTechPoint_;
			}
			set
			{
				this.totalTechPoint_ = value;
			}
		}

		// Token: 0x17005F92 RID: 24466
		// (get) Token: 0x0601C3BF RID: 115647 RVA: 0x00419105 File Offset: 0x00417305
		// (set) Token: 0x0601C3C0 RID: 115648 RVA: 0x0041910D File Offset: 0x0041730D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeftTechPoint
		{
			get
			{
				return this.leftTechPoint_;
			}
			set
			{
				this.leftTechPoint_ = value;
			}
		}

		// Token: 0x17005F93 RID: 24467
		// (get) Token: 0x0601C3C1 RID: 115649 RVA: 0x00419116 File Offset: 0x00417316
		// (set) Token: 0x0601C3C2 RID: 115650 RVA: 0x0041911E File Offset: 0x0041731E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LeftLevelUpPoint
		{
			get
			{
				return this.leftLevelUpPoint_;
			}
			set
			{
				this.leftLevelUpPoint_ = value;
			}
		}

		// Token: 0x17005F94 RID: 24468
		// (get) Token: 0x0601C3C3 RID: 115651 RVA: 0x00419127 File Offset: 0x00417327
		// (set) Token: 0x0601C3C4 RID: 115652 RVA: 0x0041912F File Offset: 0x0041732F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalLevelUpPoint
		{
			get
			{
				return this.totalLevelUpPoint_;
			}
			set
			{
				this.totalLevelUpPoint_ = value;
			}
		}

		// Token: 0x0601C3C5 RID: 115653 RVA: 0x00419138 File Offset: 0x00417338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechPointUpdateNotify);
		}

		// Token: 0x0601C3C6 RID: 115654 RVA: 0x00419148 File Offset: 0x00417348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechPointUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalTechPoint == other.TotalTechPoint && this.LeftTechPoint == other.LeftTechPoint && this.LeftLevelUpPoint == other.LeftLevelUpPoint && this.TotalLevelUpPoint == other.TotalLevelUpPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C3C7 RID: 115655 RVA: 0x004191B4 File Offset: 0x004173B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TotalTechPoint != 0)
			{
				num ^= this.TotalTechPoint.GetHashCode();
			}
			if (this.LeftTechPoint != 0)
			{
				num ^= this.LeftTechPoint.GetHashCode();
			}
			if (this.LeftLevelUpPoint != 0)
			{
				num ^= this.LeftLevelUpPoint.GetHashCode();
			}
			if (this.TotalLevelUpPoint != 0)
			{
				num ^= this.TotalLevelUpPoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C3C8 RID: 115656 RVA: 0x0041923E File Offset: 0x0041743E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C3C9 RID: 115657 RVA: 0x0041924B File Offset: 0x0041744B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C3CA RID: 115658 RVA: 0x00419254 File Offset: 0x00417454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TotalLevelUpPoint != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TotalLevelUpPoint);
			}
			if (this.TotalTechPoint != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalTechPoint);
			}
			if (this.LeftLevelUpPoint != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.LeftLevelUpPoint);
			}
			if (this.LeftTechPoint != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LeftTechPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C3CB RID: 115659 RVA: 0x004192E4 File Offset: 0x004174E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TotalTechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalTechPoint);
			}
			if (this.LeftTechPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeftTechPoint);
			}
			if (this.LeftLevelUpPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LeftLevelUpPoint);
			}
			if (this.TotalLevelUpPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalLevelUpPoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C3CC RID: 115660 RVA: 0x0041936C File Offset: 0x0041756C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTechPointUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TotalTechPoint != 0)
			{
				this.TotalTechPoint = other.TotalTechPoint;
			}
			if (other.LeftTechPoint != 0)
			{
				this.LeftTechPoint = other.LeftTechPoint;
			}
			if (other.LeftLevelUpPoint != 0)
			{
				this.LeftLevelUpPoint = other.LeftLevelUpPoint;
			}
			if (other.TotalLevelUpPoint != 0)
			{
				this.TotalLevelUpPoint = other.TotalLevelUpPoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C3CD RID: 115661 RVA: 0x004193E4 File Offset: 0x004175E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C3CE RID: 115662 RVA: 0x004193F0 File Offset: 0x004175F0
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
				if (num <= 48U)
				{
					if (num == 8U)
					{
						this.TotalLevelUpPoint = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.TotalTechPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.LeftLevelUpPoint = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LeftTechPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A33D RID: 41789
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A33E RID: 41790
		public const int TotalTechPointFieldNumber = 6;

		// Token: 0x0400A33F RID: 41791
		private int totalTechPoint_;

		// Token: 0x0400A340 RID: 41792
		public const int LeftTechPointFieldNumber = 14;

		// Token: 0x0400A341 RID: 41793
		private int leftTechPoint_;

		// Token: 0x0400A342 RID: 41794
		public const int LeftLevelUpPointFieldNumber = 9;

		// Token: 0x0400A343 RID: 41795
		private int leftLevelUpPoint_;

		// Token: 0x0400A344 RID: 41796
		public const int TotalLevelUpPointFieldNumber = 1;

		// Token: 0x0400A345 RID: 41797
		private int totalLevelUpPoint_;
	}
}
