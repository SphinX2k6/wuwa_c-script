using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001457 RID: 5207
	[NetMessage(EMessageId.TrapDefenseTechPointUpdateNotify)]
	public sealed class TrapDefenseTechPointUpdateNotify : IMessage<TrapDefenseTechPointUpdateNotify>, IMessage, IEquatable<TrapDefenseTechPointUpdateNotify>, IDeepCloneable<TrapDefenseTechPointUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B92C RID: 112940 RVA: 0x003FDDAB File Offset: 0x003FBFAB
		[NullableContext(1)]
		public static TrapDefenseTechPointUpdateNotify Create()
		{
			return new TrapDefenseTechPointUpdateNotify();
		}

		// Token: 0x17005CFA RID: 23802
		// (get) Token: 0x0601B92D RID: 112941 RVA: 0x003FDDB2 File Offset: 0x003FBFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CFB RID: 23803
		// (get) Token: 0x0601B92E RID: 112942 RVA: 0x003FDDB5 File Offset: 0x003FBFB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTechPointUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B92F RID: 112943 RVA: 0x003FDDBC File Offset: 0x003FBFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechPointUpdateNotify()
		{
		}

		// Token: 0x0601B930 RID: 112944 RVA: 0x003FDDC4 File Offset: 0x003FBFC4
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

		// Token: 0x0601B931 RID: 112945 RVA: 0x003FDE18 File Offset: 0x003FC018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTechPointUpdateNotify Clone()
		{
			return new TrapDefenseTechPointUpdateNotify(this);
		}

		// Token: 0x17005CFC RID: 23804
		// (get) Token: 0x0601B932 RID: 112946 RVA: 0x003FDE20 File Offset: 0x003FC020
		// (set) Token: 0x0601B933 RID: 112947 RVA: 0x003FDE28 File Offset: 0x003FC028
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

		// Token: 0x17005CFD RID: 23805
		// (get) Token: 0x0601B934 RID: 112948 RVA: 0x003FDE31 File Offset: 0x003FC031
		// (set) Token: 0x0601B935 RID: 112949 RVA: 0x003FDE39 File Offset: 0x003FC039
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

		// Token: 0x17005CFE RID: 23806
		// (get) Token: 0x0601B936 RID: 112950 RVA: 0x003FDE42 File Offset: 0x003FC042
		// (set) Token: 0x0601B937 RID: 112951 RVA: 0x003FDE4A File Offset: 0x003FC04A
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

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x0601B938 RID: 112952 RVA: 0x003FDE53 File Offset: 0x003FC053
		// (set) Token: 0x0601B939 RID: 112953 RVA: 0x003FDE5B File Offset: 0x003FC05B
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

		// Token: 0x0601B93A RID: 112954 RVA: 0x003FDE64 File Offset: 0x003FC064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTechPointUpdateNotify);
		}

		// Token: 0x0601B93B RID: 112955 RVA: 0x003FDE74 File Offset: 0x003FC074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTechPointUpdateNotify other)
		{
			return other != null && (other == this || (this.TotalTechPoint == other.TotalTechPoint && this.LeftTechPoint == other.LeftTechPoint && this.LeftLevelUpPoint == other.LeftLevelUpPoint && this.TotalLevelUpPoint == other.TotalLevelUpPoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B93C RID: 112956 RVA: 0x003FDEE0 File Offset: 0x003FC0E0
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

		// Token: 0x0601B93D RID: 112957 RVA: 0x003FDF6A File Offset: 0x003FC16A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B93E RID: 112958 RVA: 0x003FDF77 File Offset: 0x003FC177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B93F RID: 112959 RVA: 0x003FDF80 File Offset: 0x003FC180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LeftLevelUpPoint != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LeftLevelUpPoint);
			}
			if (this.LeftTechPoint != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LeftTechPoint);
			}
			if (this.TotalLevelUpPoint != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TotalLevelUpPoint);
			}
			if (this.TotalTechPoint != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TotalTechPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B940 RID: 112960 RVA: 0x003FE010 File Offset: 0x003FC210
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

		// Token: 0x0601B941 RID: 112961 RVA: 0x003FE098 File Offset: 0x003FC298
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

		// Token: 0x0601B942 RID: 112962 RVA: 0x003FE110 File Offset: 0x003FC310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B943 RID: 112963 RVA: 0x003FE11C File Offset: 0x003FC31C
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.LeftLevelUpPoint = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LeftTechPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.TotalLevelUpPoint = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.TotalTechPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009EF6 RID: 40694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EF7 RID: 40695
		public const int TotalTechPointFieldNumber = 11;

		// Token: 0x04009EF8 RID: 40696
		private int totalTechPoint_;

		// Token: 0x04009EF9 RID: 40697
		public const int LeftTechPointFieldNumber = 5;

		// Token: 0x04009EFA RID: 40698
		private int leftTechPoint_;

		// Token: 0x04009EFB RID: 40699
		public const int LeftLevelUpPointFieldNumber = 1;

		// Token: 0x04009EFC RID: 40700
		private int leftLevelUpPoint_;

		// Token: 0x04009EFD RID: 40701
		public const int TotalLevelUpPointFieldNumber = 6;

		// Token: 0x04009EFE RID: 40702
		private int totalLevelUpPoint_;
	}
}
