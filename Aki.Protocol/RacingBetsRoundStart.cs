using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E66 RID: 3686
	public sealed class RacingBetsRoundStart : IMessage<RacingBetsRoundStart>, IMessage, IEquatable<RacingBetsRoundStart>, IDeepCloneable<RacingBetsRoundStart>, IBufferMessage
	{
		// Token: 0x06013D46 RID: 81222 RVA: 0x002E3E81 File Offset: 0x002E2081
		[NullableContext(1)]
		public static RacingBetsRoundStart Create()
		{
			return new RacingBetsRoundStart();
		}

		// Token: 0x170041F7 RID: 16887
		// (get) Token: 0x06013D47 RID: 81223 RVA: 0x002E3E88 File Offset: 0x002E2088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041F8 RID: 16888
		// (get) Token: 0x06013D48 RID: 81224 RVA: 0x002E3E8B File Offset: 0x002E208B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsRoundStart.Descriptor;
			}
		}

		// Token: 0x06013D49 RID: 81225 RVA: 0x002E3E92 File Offset: 0x002E2092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart()
		{
		}

		// Token: 0x06013D4A RID: 81226 RVA: 0x002E3E9A File Offset: 0x002E209A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart(RacingBetsRoundStart other) : this()
		{
			this.legMatchId_ = other.legMatchId_;
			this.roundRank_ = other.roundRank_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D4B RID: 81227 RVA: 0x002E3ECB File Offset: 0x002E20CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsRoundStart Clone()
		{
			return new RacingBetsRoundStart(this);
		}

		// Token: 0x170041F9 RID: 16889
		// (get) Token: 0x06013D4C RID: 81228 RVA: 0x002E3ED3 File Offset: 0x002E20D3
		// (set) Token: 0x06013D4D RID: 81229 RVA: 0x002E3EDB File Offset: 0x002E20DB
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

		// Token: 0x170041FA RID: 16890
		// (get) Token: 0x06013D4E RID: 81230 RVA: 0x002E3EE4 File Offset: 0x002E20E4
		// (set) Token: 0x06013D4F RID: 81231 RVA: 0x002E3EEC File Offset: 0x002E20EC
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

		// Token: 0x06013D50 RID: 81232 RVA: 0x002E3EF5 File Offset: 0x002E20F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsRoundStart);
		}

		// Token: 0x06013D51 RID: 81233 RVA: 0x002E3F03 File Offset: 0x002E2103
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsRoundStart other)
		{
			return other != null && (other == this || (this.LegMatchId == other.LegMatchId && this.RoundRank == other.RoundRank && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D52 RID: 81234 RVA: 0x002E3F44 File Offset: 0x002E2144
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

		// Token: 0x06013D53 RID: 81235 RVA: 0x002E3F9C File Offset: 0x002E219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D54 RID: 81236 RVA: 0x002E3FA9 File Offset: 0x002E21A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D55 RID: 81237 RVA: 0x002E3FB4 File Offset: 0x002E21B4
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

		// Token: 0x06013D56 RID: 81238 RVA: 0x002E400C File Offset: 0x002E220C
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

		// Token: 0x06013D57 RID: 81239 RVA: 0x002E4064 File Offset: 0x002E2264
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

		// Token: 0x06013D58 RID: 81240 RVA: 0x002E40B4 File Offset: 0x002E22B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D59 RID: 81241 RVA: 0x002E40C0 File Offset: 0x002E22C0
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

		// Token: 0x040079BF RID: 31167
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079C0 RID: 31168
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x040079C1 RID: 31169
		private int legMatchId_;

		// Token: 0x040079C2 RID: 31170
		public const int RoundRankFieldNumber = 2;

		// Token: 0x040079C3 RID: 31171
		private int roundRank_;
	}
}
