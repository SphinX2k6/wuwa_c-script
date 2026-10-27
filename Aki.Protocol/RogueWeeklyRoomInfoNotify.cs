using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001048 RID: 4168
	[NetMessage(EMessageId.RogueWeeklyRoomInfoNotify)]
	public sealed class RogueWeeklyRoomInfoNotify : IMessage<RogueWeeklyRoomInfoNotify>, IMessage, IEquatable<RogueWeeklyRoomInfoNotify>, IDeepCloneable<RogueWeeklyRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x0601644B RID: 91211 RVA: 0x0033BF7D File Offset: 0x0033A17D
		[NullableContext(1)]
		public static RogueWeeklyRoomInfoNotify Create()
		{
			return new RogueWeeklyRoomInfoNotify();
		}

		// Token: 0x17004A70 RID: 19056
		// (get) Token: 0x0601644C RID: 91212 RVA: 0x0033BF84 File Offset: 0x0033A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A71 RID: 19057
		// (get) Token: 0x0601644D RID: 91213 RVA: 0x0033BF87 File Offset: 0x0033A187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601644E RID: 91214 RVA: 0x0033BF8E File Offset: 0x0033A18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRoomInfoNotify()
		{
		}

		// Token: 0x0601644F RID: 91215 RVA: 0x0033BF98 File Offset: 0x0033A198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRoomInfoNotify(RogueWeeklyRoomInfoNotify other) : this()
		{
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.roguelikeRoomTypeId_ = other.roguelikeRoomTypeId_;
			this.skyBoxId_ = other.skyBoxId_;
			this.roguelikeRoomId_ = other.roguelikeRoomId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016450 RID: 91216 RVA: 0x0033C004 File Offset: 0x0033A204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRoomInfoNotify Clone()
		{
			return new RogueWeeklyRoomInfoNotify(this);
		}

		// Token: 0x17004A72 RID: 19058
		// (get) Token: 0x06016451 RID: 91217 RVA: 0x0033C00C File Offset: 0x0033A20C
		// (set) Token: 0x06016452 RID: 91218 RVA: 0x0033C014 File Offset: 0x0033A214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x17004A73 RID: 19059
		// (get) Token: 0x06016453 RID: 91219 RVA: 0x0033C01D File Offset: 0x0033A21D
		// (set) Token: 0x06016454 RID: 91220 RVA: 0x0033C025 File Offset: 0x0033A225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x17004A74 RID: 19060
		// (get) Token: 0x06016455 RID: 91221 RVA: 0x0033C02E File Offset: 0x0033A22E
		// (set) Token: 0x06016456 RID: 91222 RVA: 0x0033C036 File Offset: 0x0033A236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoguelikeRoomTypeId
		{
			get
			{
				return this.roguelikeRoomTypeId_;
			}
			set
			{
				this.roguelikeRoomTypeId_ = value;
			}
		}

		// Token: 0x17004A75 RID: 19061
		// (get) Token: 0x06016457 RID: 91223 RVA: 0x0033C03F File Offset: 0x0033A23F
		// (set) Token: 0x06016458 RID: 91224 RVA: 0x0033C047 File Offset: 0x0033A247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkyBoxId
		{
			get
			{
				return this.skyBoxId_;
			}
			set
			{
				this.skyBoxId_ = value;
			}
		}

		// Token: 0x17004A76 RID: 19062
		// (get) Token: 0x06016459 RID: 91225 RVA: 0x0033C050 File Offset: 0x0033A250
		// (set) Token: 0x0601645A RID: 91226 RVA: 0x0033C058 File Offset: 0x0033A258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoguelikeRoomId
		{
			get
			{
				return this.roguelikeRoomId_;
			}
			set
			{
				this.roguelikeRoomId_ = value;
			}
		}

		// Token: 0x17004A77 RID: 19063
		// (get) Token: 0x0601645B RID: 91227 RVA: 0x0033C061 File Offset: 0x0033A261
		// (set) Token: 0x0601645C RID: 91228 RVA: 0x0033C069 File Offset: 0x0033A269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x0601645D RID: 91229 RVA: 0x0033C072 File Offset: 0x0033A272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRoomInfoNotify);
		}

		// Token: 0x0601645E RID: 91230 RVA: 0x0033C080 File Offset: 0x0033A280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601645F RID: 91231 RVA: 0x0033C10C File Offset: 0x0033A30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				num ^= this.RoguelikeRoomTypeId.GetHashCode();
			}
			if (this.SkyBoxId != 0)
			{
				num ^= this.SkyBoxId.GetHashCode();
			}
			if (this.RoguelikeRoomId != 0)
			{
				num ^= this.RoguelikeRoomId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016460 RID: 91232 RVA: 0x0033C1C8 File Offset: 0x0033A3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016461 RID: 91233 RVA: 0x0033C1D5 File Offset: 0x0033A3D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016462 RID: 91234 RVA: 0x0033C1E0 File Offset: 0x0033A3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurLayer);
			}
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Score);
			}
			if (this.RoguelikeRoomId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.RoguelikeRoomId);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoguelikeRoomTypeId);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MaxLayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016463 RID: 91235 RVA: 0x0033C2A8 File Offset: 0x0033A4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoguelikeRoomTypeId);
			}
			if (this.SkyBoxId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkyBoxId);
			}
			if (this.RoguelikeRoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoguelikeRoomId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016464 RID: 91236 RVA: 0x0033C360 File Offset: 0x0033A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyRoomInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.RoguelikeRoomTypeId != 0)
			{
				this.RoguelikeRoomTypeId = other.RoguelikeRoomTypeId;
			}
			if (other.SkyBoxId != 0)
			{
				this.SkyBoxId = other.SkyBoxId;
			}
			if (other.RoguelikeRoomId != 0)
			{
				this.RoguelikeRoomId = other.RoguelikeRoomId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016465 RID: 91237 RVA: 0x0033C400 File Offset: 0x0033A600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016466 RID: 91238 RVA: 0x0033C40C File Offset: 0x0033A60C
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
						this.CurLayer = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkyBoxId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.RoguelikeRoomId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.RoguelikeRoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008527 RID: 34087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008528 RID: 34088
		public const int CurLayerFieldNumber = 1;

		// Token: 0x04008529 RID: 34089
		private int curLayer_;

		// Token: 0x0400852A RID: 34090
		public const int MaxLayerFieldNumber = 14;

		// Token: 0x0400852B RID: 34091
		private int maxLayer_;

		// Token: 0x0400852C RID: 34092
		public const int RoguelikeRoomTypeIdFieldNumber = 12;

		// Token: 0x0400852D RID: 34093
		private int roguelikeRoomTypeId_;

		// Token: 0x0400852E RID: 34094
		public const int SkyBoxIdFieldNumber = 2;

		// Token: 0x0400852F RID: 34095
		private int skyBoxId_;

		// Token: 0x04008530 RID: 34096
		public const int RoguelikeRoomIdFieldNumber = 9;

		// Token: 0x04008531 RID: 34097
		private int roguelikeRoomId_;

		// Token: 0x04008532 RID: 34098
		public const int ScoreFieldNumber = 3;

		// Token: 0x04008533 RID: 34099
		private int score_;
	}
}
