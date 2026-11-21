using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001038 RID: 4152
	[NetMessage(EMessageId.RogueWeeklyRoomInfoNotify)]
	public sealed class RogueWeeklyRoomInfoNotify : IMessage<RogueWeeklyRoomInfoNotify>, IMessage, IEquatable<RogueWeeklyRoomInfoNotify>, IDeepCloneable<RogueWeeklyRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06016366 RID: 90982 RVA: 0x0033A8AD File Offset: 0x00338AAD
		[NullableContext(1)]
		public static RogueWeeklyRoomInfoNotify Create()
		{
			return new RogueWeeklyRoomInfoNotify();
		}

		// Token: 0x17004A46 RID: 19014
		// (get) Token: 0x06016367 RID: 90983 RVA: 0x0033A8B4 File Offset: 0x00338AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A47 RID: 19015
		// (get) Token: 0x06016368 RID: 90984 RVA: 0x0033A8B7 File Offset: 0x00338AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06016369 RID: 90985 RVA: 0x0033A8BE File Offset: 0x00338ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRoomInfoNotify()
		{
		}

		// Token: 0x0601636A RID: 90986 RVA: 0x0033A8C8 File Offset: 0x00338AC8
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

		// Token: 0x0601636B RID: 90987 RVA: 0x0033A934 File Offset: 0x00338B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyRoomInfoNotify Clone()
		{
			return new RogueWeeklyRoomInfoNotify(this);
		}

		// Token: 0x17004A48 RID: 19016
		// (get) Token: 0x0601636C RID: 90988 RVA: 0x0033A93C File Offset: 0x00338B3C
		// (set) Token: 0x0601636D RID: 90989 RVA: 0x0033A944 File Offset: 0x00338B44
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

		// Token: 0x17004A49 RID: 19017
		// (get) Token: 0x0601636E RID: 90990 RVA: 0x0033A94D File Offset: 0x00338B4D
		// (set) Token: 0x0601636F RID: 90991 RVA: 0x0033A955 File Offset: 0x00338B55
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

		// Token: 0x17004A4A RID: 19018
		// (get) Token: 0x06016370 RID: 90992 RVA: 0x0033A95E File Offset: 0x00338B5E
		// (set) Token: 0x06016371 RID: 90993 RVA: 0x0033A966 File Offset: 0x00338B66
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

		// Token: 0x17004A4B RID: 19019
		// (get) Token: 0x06016372 RID: 90994 RVA: 0x0033A96F File Offset: 0x00338B6F
		// (set) Token: 0x06016373 RID: 90995 RVA: 0x0033A977 File Offset: 0x00338B77
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

		// Token: 0x17004A4C RID: 19020
		// (get) Token: 0x06016374 RID: 90996 RVA: 0x0033A980 File Offset: 0x00338B80
		// (set) Token: 0x06016375 RID: 90997 RVA: 0x0033A988 File Offset: 0x00338B88
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

		// Token: 0x17004A4D RID: 19021
		// (get) Token: 0x06016376 RID: 90998 RVA: 0x0033A991 File Offset: 0x00338B91
		// (set) Token: 0x06016377 RID: 90999 RVA: 0x0033A999 File Offset: 0x00338B99
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

		// Token: 0x06016378 RID: 91000 RVA: 0x0033A9A2 File Offset: 0x00338BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyRoomInfoNotify);
		}

		// Token: 0x06016379 RID: 91001 RVA: 0x0033A9B0 File Offset: 0x00338BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601637A RID: 91002 RVA: 0x0033AA3C File Offset: 0x00338C3C
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

		// Token: 0x0601637B RID: 91003 RVA: 0x0033AAF8 File Offset: 0x00338CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601637C RID: 91004 RVA: 0x0033AB05 File Offset: 0x00338D05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601637D RID: 91005 RVA: 0x0033AB10 File Offset: 0x00338D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoguelikeRoomId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoguelikeRoomId);
			}
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurLayer);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoguelikeRoomTypeId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601637E RID: 91006 RVA: 0x0033ABDC File Offset: 0x00338DDC
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

		// Token: 0x0601637F RID: 91007 RVA: 0x0033AC94 File Offset: 0x00338E94
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

		// Token: 0x06016380 RID: 91008 RVA: 0x0033AD34 File Offset: 0x00338F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016381 RID: 91009 RVA: 0x0033AD40 File Offset: 0x00338F40
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
					if (num == 16U)
					{
						this.RoguelikeRoomId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.SkyBoxId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoguelikeRoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Score = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008551 RID: 34129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008552 RID: 34130
		public const int CurLayerFieldNumber = 8;

		// Token: 0x04008553 RID: 34131
		private int curLayer_;

		// Token: 0x04008554 RID: 34132
		public const int MaxLayerFieldNumber = 6;

		// Token: 0x04008555 RID: 34133
		private int maxLayer_;

		// Token: 0x04008556 RID: 34134
		public const int RoguelikeRoomTypeIdFieldNumber = 10;

		// Token: 0x04008557 RID: 34135
		private int roguelikeRoomTypeId_;

		// Token: 0x04008558 RID: 34136
		public const int SkyBoxIdFieldNumber = 4;

		// Token: 0x04008559 RID: 34137
		private int skyBoxId_;

		// Token: 0x0400855A RID: 34138
		public const int RoguelikeRoomIdFieldNumber = 2;

		// Token: 0x0400855B RID: 34139
		private int roguelikeRoomId_;

		// Token: 0x0400855C RID: 34140
		public const int ScoreFieldNumber = 11;

		// Token: 0x0400855D RID: 34141
		private int score_;
	}
}
