using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4D RID: 3917
	public sealed class RhythmSubLevelPb : IMessage<RhythmSubLevelPb>, IMessage, IEquatable<RhythmSubLevelPb>, IDeepCloneable<RhythmSubLevelPb>, IBufferMessage
	{
		// Token: 0x06014F4D RID: 85837 RVA: 0x0030A618 File Offset: 0x00308818
		[NullableContext(1)]
		public static RhythmSubLevelPb Create()
		{
			return new RhythmSubLevelPb();
		}

		// Token: 0x170045B4 RID: 17844
		// (get) Token: 0x06014F4E RID: 85838 RVA: 0x0030A61F File Offset: 0x0030881F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RhythmSubLevelPb> Parser
		{
			get
			{
				return RhythmSubLevelPb._parser;
			}
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x06014F4F RID: 85839 RVA: 0x0030A626 File Offset: 0x00308826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x06014F50 RID: 85840 RVA: 0x0030A629 File Offset: 0x00308829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSubLevelPb.Descriptor;
			}
		}

		// Token: 0x06014F51 RID: 85841 RVA: 0x0030A630 File Offset: 0x00308830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb()
		{
		}

		// Token: 0x06014F52 RID: 85842 RVA: 0x0030A638 File Offset: 0x00308838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb(RhythmSubLevelPb other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.cleared_ = other.cleared_;
			this.bestScore_ = other.bestScore_;
			this.bestAccuracy_ = other.bestAccuracy_;
			this.bestRank_ = other.bestRank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F53 RID: 85843 RVA: 0x0030A698 File Offset: 0x00308898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSubLevelPb Clone()
		{
			return new RhythmSubLevelPb(this);
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x06014F54 RID: 85844 RVA: 0x0030A6A0 File Offset: 0x003088A0
		// (set) Token: 0x06014F55 RID: 85845 RVA: 0x0030A6A8 File Offset: 0x003088A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x170045B8 RID: 17848
		// (get) Token: 0x06014F56 RID: 85846 RVA: 0x0030A6B1 File Offset: 0x003088B1
		// (set) Token: 0x06014F57 RID: 85847 RVA: 0x0030A6B9 File Offset: 0x003088B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Cleared
		{
			get
			{
				return this.cleared_;
			}
			set
			{
				this.cleared_ = value;
			}
		}

		// Token: 0x170045B9 RID: 17849
		// (get) Token: 0x06014F58 RID: 85848 RVA: 0x0030A6C2 File Offset: 0x003088C2
		// (set) Token: 0x06014F59 RID: 85849 RVA: 0x0030A6CA File Offset: 0x003088CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestScore
		{
			get
			{
				return this.bestScore_;
			}
			set
			{
				this.bestScore_ = value;
			}
		}

		// Token: 0x170045BA RID: 17850
		// (get) Token: 0x06014F5A RID: 85850 RVA: 0x0030A6D3 File Offset: 0x003088D3
		// (set) Token: 0x06014F5B RID: 85851 RVA: 0x0030A6DB File Offset: 0x003088DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestAccuracy
		{
			get
			{
				return this.bestAccuracy_;
			}
			set
			{
				this.bestAccuracy_ = value;
			}
		}

		// Token: 0x170045BB RID: 17851
		// (get) Token: 0x06014F5C RID: 85852 RVA: 0x0030A6E4 File Offset: 0x003088E4
		// (set) Token: 0x06014F5D RID: 85853 RVA: 0x0030A6EC File Offset: 0x003088EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipRank BestRank
		{
			get
			{
				return this.bestRank_;
			}
			set
			{
				this.bestRank_ = value;
			}
		}

		// Token: 0x06014F5E RID: 85854 RVA: 0x0030A6F5 File Offset: 0x003088F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSubLevelPb);
		}

		// Token: 0x06014F5F RID: 85855 RVA: 0x0030A704 File Offset: 0x00308904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSubLevelPb other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.Cleared == other.Cleared && this.BestScore == other.BestScore && this.BestAccuracy == other.BestAccuracy && this.BestRank == other.BestRank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F60 RID: 85856 RVA: 0x0030A780 File Offset: 0x00308980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.Cleared)
			{
				num ^= this.Cleared.GetHashCode();
			}
			if (this.BestScore != 0)
			{
				num ^= this.BestScore.GetHashCode();
			}
			if (this.BestAccuracy != 0)
			{
				num ^= this.BestAccuracy.GetHashCode();
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				num ^= this.BestRank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014F61 RID: 85857 RVA: 0x0030A829 File Offset: 0x00308A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F62 RID: 85858 RVA: 0x0030A836 File Offset: 0x00308A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F63 RID: 85859 RVA: 0x0030A840 File Offset: 0x00308A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.Cleared)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Cleared);
			}
			if (this.BestScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BestScore);
			}
			if (this.BestAccuracy != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BestAccuracy);
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.BestRank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F64 RID: 85860 RVA: 0x0030A8EC File Offset: 0x00308AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.Cleared)
			{
				num += 2;
			}
			if (this.BestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestScore);
			}
			if (this.BestAccuracy != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestAccuracy);
			}
			if (this.BestRank != RhythmShipRank.Undefined)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BestRank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014F65 RID: 85861 RVA: 0x0030A980 File Offset: 0x00308B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSubLevelPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.Cleared)
			{
				this.Cleared = other.Cleared;
			}
			if (other.BestScore != 0)
			{
				this.BestScore = other.BestScore;
			}
			if (other.BestAccuracy != 0)
			{
				this.BestAccuracy = other.BestAccuracy;
			}
			if (other.BestRank != RhythmShipRank.Undefined)
			{
				this.BestRank = other.BestRank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014F66 RID: 85862 RVA: 0x0030AA0C File Offset: 0x00308C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F67 RID: 85863 RVA: 0x0030AA18 File Offset: 0x00308C18
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
						this.SubLevelId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Cleared = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.BestScore = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.BestAccuracy = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BestRank = (RhythmShipRank)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007E59 RID: 32345
		private static readonly MessageParser<RhythmSubLevelPb> _parser = new MessageParser<RhythmSubLevelPb>(() => new RhythmSubLevelPb());

		// Token: 0x04007E5A RID: 32346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E5B RID: 32347
		public const int SubLevelIdFieldNumber = 1;

		// Token: 0x04007E5C RID: 32348
		private int subLevelId_;

		// Token: 0x04007E5D RID: 32349
		public const int ClearedFieldNumber = 2;

		// Token: 0x04007E5E RID: 32350
		private bool cleared_;

		// Token: 0x04007E5F RID: 32351
		public const int BestScoreFieldNumber = 3;

		// Token: 0x04007E60 RID: 32352
		private int bestScore_;

		// Token: 0x04007E61 RID: 32353
		public const int BestAccuracyFieldNumber = 4;

		// Token: 0x04007E62 RID: 32354
		private int bestAccuracy_;

		// Token: 0x04007E63 RID: 32355
		public const int BestRankFieldNumber = 5;

		// Token: 0x04007E64 RID: 32356
		private RhythmShipRank bestRank_;
	}
}
