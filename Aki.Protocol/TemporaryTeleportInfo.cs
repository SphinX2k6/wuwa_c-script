using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BE RID: 5054
	public sealed class TemporaryTeleportInfo : IMessage<TemporaryTeleportInfo>, IMessage, IEquatable<TemporaryTeleportInfo>, IDeepCloneable<TemporaryTeleportInfo>, IBufferMessage
	{
		// Token: 0x0601AE59 RID: 110169 RVA: 0x003EACFC File Offset: 0x003E8EFC
		[NullableContext(1)]
		public static TemporaryTeleportInfo Create()
		{
			return new TemporaryTeleportInfo();
		}

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x0601AE5A RID: 110170 RVA: 0x003EAD03 File Offset: 0x003E8F03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TemporaryTeleportInfo> Parser
		{
			get
			{
				return TemporaryTeleportInfo._parser;
			}
		}

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x0601AE5B RID: 110171 RVA: 0x003EAD0A File Offset: 0x003E8F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x0601AE5C RID: 110172 RVA: 0x003EAD0D File Offset: 0x003E8F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportInfo.Descriptor;
			}
		}

		// Token: 0x0601AE5D RID: 110173 RVA: 0x003EAD14 File Offset: 0x003E8F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo()
		{
		}

		// Token: 0x0601AE5E RID: 110174 RVA: 0x003EAD1C File Offset: 0x003E8F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo(TemporaryTeleportInfo other) : this()
		{
			this.markId_ = other.markId_;
			this.temporaryTeleportId_ = other.temporaryTeleportId_;
			this.mapId_ = other.mapId_;
			this.instId_ = other.instId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.playerTeleportPos_ = ((other.playerTeleportPos_ != null) ? other.playerTeleportPos_.Clone() : null);
			this.area_ = other.area_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE5F RID: 110175 RVA: 0x003EADD0 File Offset: 0x003E8FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo Clone()
		{
			return new TemporaryTeleportInfo(this);
		}

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x0601AE60 RID: 110176 RVA: 0x003EADD8 File Offset: 0x003E8FD8
		// (set) Token: 0x0601AE61 RID: 110177 RVA: 0x003EADE0 File Offset: 0x003E8FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x0601AE62 RID: 110178 RVA: 0x003EADE9 File Offset: 0x003E8FE9
		// (set) Token: 0x0601AE63 RID: 110179 RVA: 0x003EADF1 File Offset: 0x003E8FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TemporaryTeleportId
		{
			get
			{
				return this.temporaryTeleportId_;
			}
			set
			{
				this.temporaryTeleportId_ = value;
			}
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x0601AE64 RID: 110180 RVA: 0x003EADFA File Offset: 0x003E8FFA
		// (set) Token: 0x0601AE65 RID: 110181 RVA: 0x003EAE02 File Offset: 0x003E9002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x0601AE66 RID: 110182 RVA: 0x003EAE0B File Offset: 0x003E900B
		// (set) Token: 0x0601AE67 RID: 110183 RVA: 0x003EAE13 File Offset: 0x003E9013
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x0601AE68 RID: 110184 RVA: 0x003EAE1C File Offset: 0x003E901C
		// (set) Token: 0x0601AE69 RID: 110185 RVA: 0x003EAE24 File Offset: 0x003E9024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x0601AE6A RID: 110186 RVA: 0x003EAE2D File Offset: 0x003E902D
		// (set) Token: 0x0601AE6B RID: 110187 RVA: 0x003EAE35 File Offset: 0x003E9035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x0601AE6C RID: 110188 RVA: 0x003EAE3E File Offset: 0x003E903E
		// (set) Token: 0x0601AE6D RID: 110189 RVA: 0x003EAE46 File Offset: 0x003E9046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PlayerTeleportPos
		{
			get
			{
				return this.playerTeleportPos_;
			}
			set
			{
				this.playerTeleportPos_ = value;
			}
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x0601AE6E RID: 110190 RVA: 0x003EAE4F File Offset: 0x003E904F
		// (set) Token: 0x0601AE6F RID: 110191 RVA: 0x003EAE57 File Offset: 0x003E9057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Area
		{
			get
			{
				return this.area_;
			}
			set
			{
				this.area_ = value;
			}
		}

		// Token: 0x0601AE70 RID: 110192 RVA: 0x003EAE60 File Offset: 0x003E9060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportInfo);
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x003EAE70 File Offset: 0x003E9070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportInfo other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.TemporaryTeleportId == other.TemporaryTeleportId && this.MapId == other.MapId && this.InstId == other.InstId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this.PlayerTeleportPos, other.PlayerTeleportPos) && this.Area == other.Area && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x003EAF28 File Offset: 0x003E9128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.TemporaryTeleportId != 0L)
			{
				num ^= this.TemporaryTeleportId.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.playerTeleportPos_ != null)
			{
				num ^= this.PlayerTeleportPos.GetHashCode();
			}
			if (this.Area != 0)
			{
				num ^= this.Area.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x003EB00D File Offset: 0x003E920D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x003EB01A File Offset: 0x003E921A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE75 RID: 110197 RVA: 0x003EB024 File Offset: 0x003E9224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MarkId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MarkId);
			}
			if (this.TemporaryTeleportId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TemporaryTeleportId);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MapId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.InstId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rot);
			}
			if (this.playerTeleportPos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.PlayerTeleportPos);
			}
			if (this.Area != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Area);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x003EB124 File Offset: 0x003E9324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.TemporaryTeleportId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TemporaryTeleportId);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.playerTeleportPos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerTeleportPos);
			}
			if (this.Area != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Area);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE77 RID: 110199 RVA: 0x003EB20C File Offset: 0x003E940C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemporaryTeleportInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.TemporaryTeleportId != 0L)
			{
				this.TemporaryTeleportId = other.TemporaryTeleportId;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.playerTeleportPos_ != null)
			{
				if (this.playerTeleportPos_ == null)
				{
					this.PlayerTeleportPos = new Vector();
				}
				this.PlayerTeleportPos.MergeFrom(other.PlayerTeleportPos);
			}
			if (other.Area != 0)
			{
				this.Area = other.Area;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE78 RID: 110200 RVA: 0x003EB31C File Offset: 0x003E951C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE79 RID: 110201 RVA: 0x003EB328 File Offset: 0x003E9528
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
				if (num <= 32U)
				{
					if (num <= 16U)
					{
						if (num == 8U)
						{
							this.MarkId = input.ReadInt32();
							continue;
						}
						if (num == 16U)
						{
							this.TemporaryTeleportId = input.ReadInt64();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.MapId = input.ReadInt32();
							continue;
						}
						if (num == 32U)
						{
							this.InstId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 50U)
				{
					if (num == 42U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 50U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.playerTeleportPos_ == null)
						{
							this.PlayerTeleportPos = new Vector();
						}
						input.ReadMessage(this.PlayerTeleportPos);
						continue;
					}
					if (num == 64U)
					{
						this.Area = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D4F RID: 40271
		private static readonly MessageParser<TemporaryTeleportInfo> _parser = new MessageParser<TemporaryTeleportInfo>(() => new TemporaryTeleportInfo());

		// Token: 0x04009D50 RID: 40272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D51 RID: 40273
		public const int MarkIdFieldNumber = 1;

		// Token: 0x04009D52 RID: 40274
		private int markId_;

		// Token: 0x04009D53 RID: 40275
		public const int TemporaryTeleportIdFieldNumber = 2;

		// Token: 0x04009D54 RID: 40276
		private long temporaryTeleportId_;

		// Token: 0x04009D55 RID: 40277
		public const int MapIdFieldNumber = 3;

		// Token: 0x04009D56 RID: 40278
		private int mapId_;

		// Token: 0x04009D57 RID: 40279
		public const int InstIdFieldNumber = 4;

		// Token: 0x04009D58 RID: 40280
		private int instId_;

		// Token: 0x04009D59 RID: 40281
		public const int PosFieldNumber = 5;

		// Token: 0x04009D5A RID: 40282
		private Vector pos_;

		// Token: 0x04009D5B RID: 40283
		public const int RotFieldNumber = 6;

		// Token: 0x04009D5C RID: 40284
		private Rotator rot_;

		// Token: 0x04009D5D RID: 40285
		public const int PlayerTeleportPosFieldNumber = 7;

		// Token: 0x04009D5E RID: 40286
		private Vector playerTeleportPos_;

		// Token: 0x04009D5F RID: 40287
		public const int AreaFieldNumber = 8;

		// Token: 0x04009D60 RID: 40288
		private int area_;
	}
}
