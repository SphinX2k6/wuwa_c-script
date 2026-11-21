using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E46 RID: 3654
	public sealed class RacingBetsDangoInfo : IMessage<RacingBetsDangoInfo>, IMessage, IEquatable<RacingBetsDangoInfo>, IDeepCloneable<RacingBetsDangoInfo>, IBufferMessage
	{
		// Token: 0x06013A53 RID: 80467 RVA: 0x002DBAA0 File Offset: 0x002D9CA0
		[NullableContext(1)]
		public static RacingBetsDangoInfo Create()
		{
			return new RacingBetsDangoInfo();
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x06013A54 RID: 80468 RVA: 0x002DBAA7 File Offset: 0x002D9CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsDangoInfo> Parser
		{
			get
			{
				return RacingBetsDangoInfo._parser;
			}
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x06013A55 RID: 80469 RVA: 0x002DBAAE File Offset: 0x002D9CAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x06013A56 RID: 80470 RVA: 0x002DBAB1 File Offset: 0x002D9CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoInfo.Descriptor;
			}
		}

		// Token: 0x06013A57 RID: 80471 RVA: 0x002DBAB8 File Offset: 0x002D9CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo()
		{
		}

		// Token: 0x06013A58 RID: 80472 RVA: 0x002DBAC0 File Offset: 0x002D9CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo(RacingBetsDangoInfo other) : this()
		{
			this.id_ = other.id_;
			this.curPoint_ = other.curPoint_;
			this.odds_ = other.odds_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A59 RID: 80473 RVA: 0x002DBAFD File Offset: 0x002D9CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoInfo Clone()
		{
			return new RacingBetsDangoInfo(this);
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x06013A5A RID: 80474 RVA: 0x002DBB05 File Offset: 0x002D9D05
		// (set) Token: 0x06013A5B RID: 80475 RVA: 0x002DBB0D File Offset: 0x002D9D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x06013A5C RID: 80476 RVA: 0x002DBB16 File Offset: 0x002D9D16
		// (set) Token: 0x06013A5D RID: 80477 RVA: 0x002DBB1E File Offset: 0x002D9D1E
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

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x06013A5E RID: 80478 RVA: 0x002DBB27 File Offset: 0x002D9D27
		// (set) Token: 0x06013A5F RID: 80479 RVA: 0x002DBB2F File Offset: 0x002D9D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Odds
		{
			get
			{
				return this.odds_;
			}
			set
			{
				this.odds_ = value;
			}
		}

		// Token: 0x06013A60 RID: 80480 RVA: 0x002DBB38 File Offset: 0x002D9D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoInfo);
		}

		// Token: 0x06013A61 RID: 80481 RVA: 0x002DBB48 File Offset: 0x002D9D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.CurPoint == other.CurPoint && this.Odds == other.Odds && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A62 RID: 80482 RVA: 0x002DBBA4 File Offset: 0x002D9DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.Odds != 0)
			{
				num ^= this.Odds.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A63 RID: 80483 RVA: 0x002DBC15 File Offset: 0x002D9E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A64 RID: 80484 RVA: 0x002DBC22 File Offset: 0x002D9E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A65 RID: 80485 RVA: 0x002DBC2C File Offset: 0x002D9E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurPoint);
			}
			if (this.Odds != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Odds);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A66 RID: 80486 RVA: 0x002DBCA0 File Offset: 0x002D9EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.Odds != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Odds);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A67 RID: 80487 RVA: 0x002DBD10 File Offset: 0x002D9F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.Odds != 0)
			{
				this.Odds = other.Odds;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A68 RID: 80488 RVA: 0x002DBD74 File Offset: 0x002D9F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A69 RID: 80489 RVA: 0x002DBD80 File Offset: 0x002D9F80
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Odds = input.ReadInt32();
						}
					}
					else
					{
						this.CurPoint = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078AC RID: 30892
		private static readonly MessageParser<RacingBetsDangoInfo> _parser = new MessageParser<RacingBetsDangoInfo>(() => new RacingBetsDangoInfo());

		// Token: 0x040078AD RID: 30893
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078AE RID: 30894
		public const int IdFieldNumber = 1;

		// Token: 0x040078AF RID: 30895
		private int id_;

		// Token: 0x040078B0 RID: 30896
		public const int CurPointFieldNumber = 2;

		// Token: 0x040078B1 RID: 30897
		private int curPoint_;

		// Token: 0x040078B2 RID: 30898
		public const int OddsFieldNumber = 3;

		// Token: 0x040078B3 RID: 30899
		private int odds_;
	}
}
