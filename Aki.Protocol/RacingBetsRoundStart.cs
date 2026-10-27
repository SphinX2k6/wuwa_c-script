using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E76 RID: 3702
	public sealed class RacingBetsRoundStart : IMessage<RacingBetsRoundStart>, IMessage, IEquatable<RacingBetsRoundStart>, IDeepCloneable<RacingBetsRoundStart>, IBufferMessage
	{
		// Token: 0x06013E2B RID: 81451 RVA: 0x002E5541 File Offset: 0x002E3741
		[NullableContext(1)]
		public static RacingBetsRoundStart Create()
		{
			return new RacingBetsRoundStart();
		}

		// Token: 0x17004221 RID: 16929
		// (get) Token: 0x06013E2C RID: 81452 RVA: 0x002E5548 File Offset: 0x002E3748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004222 RID: 16930
		// (get) Token: 0x06013E2D RID: 81453 RVA: 0x002E554B File Offset: 0x002E374B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRoundStart.Descriptor;
			}
		}

		// Token: 0x06013E2E RID: 81454 RVA: 0x002E5552 File Offset: 0x002E3752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart()
		{
		}

		// Token: 0x06013E2F RID: 81455 RVA: 0x002E555A File Offset: 0x002E375A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart(RacingBetsRoundStart other) : this()
		{
			this.legMatchId_ = other.legMatchId_;
			this.roundRank_ = other.roundRank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E30 RID: 81456 RVA: 0x002E558B File Offset: 0x002E378B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart Clone()
		{
			return new RacingBetsRoundStart(this);
		}

		// Token: 0x17004223 RID: 16931
		// (get) Token: 0x06013E31 RID: 81457 RVA: 0x002E5593 File Offset: 0x002E3793
		// (set) Token: 0x06013E32 RID: 81458 RVA: 0x002E559B File Offset: 0x002E379B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x17004224 RID: 16932
		// (get) Token: 0x06013E33 RID: 81459 RVA: 0x002E55A4 File Offset: 0x002E37A4
		// (set) Token: 0x06013E34 RID: 81460 RVA: 0x002E55AC File Offset: 0x002E37AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundRank
		{
			get
			{
				return this.roundRank_;
			}
			set
			{
				this.roundRank_ = value;
			}
		}

		// Token: 0x06013E35 RID: 81461 RVA: 0x002E55B5 File Offset: 0x002E37B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRoundStart);
		}

		// Token: 0x06013E36 RID: 81462 RVA: 0x002E55C3 File Offset: 0x002E37C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRoundStart other)
		{
			return other != null && (other == this || (this.LegMatchId == other.LegMatchId && this.RoundRank == other.RoundRank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E37 RID: 81463 RVA: 0x002E5604 File Offset: 0x002E3804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.RoundRank != 0)
			{
				num ^= this.RoundRank.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E38 RID: 81464 RVA: 0x002E565C File Offset: 0x002E385C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E39 RID: 81465 RVA: 0x002E5669 File Offset: 0x002E3869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E3A RID: 81466 RVA: 0x002E5674 File Offset: 0x002E3874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.RoundRank != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoundRank);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E3B RID: 81467 RVA: 0x002E56CC File Offset: 0x002E38CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.RoundRank != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundRank);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013E3C RID: 81468 RVA: 0x002E5724 File Offset: 0x002E3924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsRoundStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.RoundRank != 0)
			{
				this.RoundRank = other.RoundRank;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013E3D RID: 81469 RVA: 0x002E5774 File Offset: 0x002E3974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E3E RID: 81470 RVA: 0x002E5780 File Offset: 0x002E3980
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RoundRank = input.ReadInt32();
					}
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007995 RID: 31125
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007996 RID: 31126
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x04007997 RID: 31127
		private int legMatchId_;

		// Token: 0x04007998 RID: 31128
		public const int RoundRankFieldNumber = 2;

		// Token: 0x04007999 RID: 31129
		private int roundRank_;
	}
}
