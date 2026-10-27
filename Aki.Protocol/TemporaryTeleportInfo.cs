using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200134B RID: 4939
	public sealed class TemporaryTeleportInfo : IMessage<TemporaryTeleportInfo>, IMessage, IEquatable<TemporaryTeleportInfo>, IDeepCloneable<TemporaryTeleportInfo>, IBufferMessage
	{
		// Token: 0x0601A3D2 RID: 107474 RVA: 0x003CFBCC File Offset: 0x003CDDCC
		[NullableContext(1)]
		public static TemporaryTeleportInfo Create()
		{
			return new TemporaryTeleportInfo();
		}

		// Token: 0x17005883 RID: 22659
		// (get) Token: 0x0601A3D3 RID: 107475 RVA: 0x003CFBD3 File Offset: 0x003CDDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TemporaryTeleportInfo> Parser
		{
			get
			{
				return TemporaryTeleportInfo._parser;
			}
		}

		// Token: 0x17005884 RID: 22660
		// (get) Token: 0x0601A3D4 RID: 107476 RVA: 0x003CFBDA File Offset: 0x003CDDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005885 RID: 22661
		// (get) Token: 0x0601A3D5 RID: 107477 RVA: 0x003CFBDD File Offset: 0x003CDDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemporaryTeleportInfo.Descriptor;
			}
		}

		// Token: 0x0601A3D6 RID: 107478 RVA: 0x003CFBE4 File Offset: 0x003CDDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo()
		{
		}

		// Token: 0x0601A3D7 RID: 107479 RVA: 0x003CFBEC File Offset: 0x003CDDEC
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

		// Token: 0x0601A3D8 RID: 107480 RVA: 0x003CFCA0 File Offset: 0x003CDEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemporaryTeleportInfo Clone()
		{
			return new TemporaryTeleportInfo(this);
		}

		// Token: 0x17005886 RID: 22662
		// (get) Token: 0x0601A3D9 RID: 107481 RVA: 0x003CFCA8 File Offset: 0x003CDEA8
		// (set) Token: 0x0601A3DA RID: 107482 RVA: 0x003CFCB0 File Offset: 0x003CDEB0
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

		// Token: 0x17005887 RID: 22663
		// (get) Token: 0x0601A3DB RID: 107483 RVA: 0x003CFCB9 File Offset: 0x003CDEB9
		// (set) Token: 0x0601A3DC RID: 107484 RVA: 0x003CFCC1 File Offset: 0x003CDEC1
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

		// Token: 0x17005888 RID: 22664
		// (get) Token: 0x0601A3DD RID: 107485 RVA: 0x003CFCCA File Offset: 0x003CDECA
		// (set) Token: 0x0601A3DE RID: 107486 RVA: 0x003CFCD2 File Offset: 0x003CDED2
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

		// Token: 0x17005889 RID: 22665
		// (get) Token: 0x0601A3DF RID: 107487 RVA: 0x003CFCDB File Offset: 0x003CDEDB
		// (set) Token: 0x0601A3E0 RID: 107488 RVA: 0x003CFCE3 File Offset: 0x003CDEE3
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

		// Token: 0x1700588A RID: 22666
		// (get) Token: 0x0601A3E1 RID: 107489 RVA: 0x003CFCEC File Offset: 0x003CDEEC
		// (set) Token: 0x0601A3E2 RID: 107490 RVA: 0x003CFCF4 File Offset: 0x003CDEF4
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

		// Token: 0x1700588B RID: 22667
		// (get) Token: 0x0601A3E3 RID: 107491 RVA: 0x003CFCFD File Offset: 0x003CDEFD
		// (set) Token: 0x0601A3E4 RID: 107492 RVA: 0x003CFD05 File Offset: 0x003CDF05
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

		// Token: 0x1700588C RID: 22668
		// (get) Token: 0x0601A3E5 RID: 107493 RVA: 0x003CFD0E File Offset: 0x003CDF0E
		// (set) Token: 0x0601A3E6 RID: 107494 RVA: 0x003CFD16 File Offset: 0x003CDF16
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

		// Token: 0x1700588D RID: 22669
		// (get) Token: 0x0601A3E7 RID: 107495 RVA: 0x003CFD1F File Offset: 0x003CDF1F
		// (set) Token: 0x0601A3E8 RID: 107496 RVA: 0x003CFD27 File Offset: 0x003CDF27
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

		// Token: 0x0601A3E9 RID: 107497 RVA: 0x003CFD30 File Offset: 0x003CDF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemporaryTeleportInfo);
		}

		// Token: 0x0601A3EA RID: 107498 RVA: 0x003CFD40 File Offset: 0x003CDF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemporaryTeleportInfo other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.TemporaryTeleportId == other.TemporaryTeleportId && this.MapId == other.MapId && this.InstId == other.InstId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this.PlayerTeleportPos, other.PlayerTeleportPos) && this.Area == other.Area && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A3EB RID: 107499 RVA: 0x003CFDF8 File Offset: 0x003CDFF8
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

		// Token: 0x0601A3EC RID: 107500 RVA: 0x003CFEDD File Offset: 0x003CE0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A3ED RID: 107501 RVA: 0x003CFEEA File Offset: 0x003CE0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A3EE RID: 107502 RVA: 0x003CFEF4 File Offset: 0x003CE0F4
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

		// Token: 0x0601A3EF RID: 107503 RVA: 0x003CFFF4 File Offset: 0x003CE1F4
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

		// Token: 0x0601A3F0 RID: 107504 RVA: 0x003D00DC File Offset: 0x003CE2DC
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

		// Token: 0x0601A3F1 RID: 107505 RVA: 0x003D01EC File Offset: 0x003CE3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3F2 RID: 107506 RVA: 0x003D01F8 File Offset: 0x003CE3F8
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

		// Token: 0x0400990D RID: 39181
		private static readonly MessageParser<TemporaryTeleportInfo> _parser = new MessageParser<TemporaryTeleportInfo>(() => new TemporaryTeleportInfo());

		// Token: 0x0400990E RID: 39182
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400990F RID: 39183
		public const int MarkIdFieldNumber = 1;

		// Token: 0x04009910 RID: 39184
		private int markId_;

		// Token: 0x04009911 RID: 39185
		public const int TemporaryTeleportIdFieldNumber = 2;

		// Token: 0x04009912 RID: 39186
		private long temporaryTeleportId_;

		// Token: 0x04009913 RID: 39187
		public const int MapIdFieldNumber = 3;

		// Token: 0x04009914 RID: 39188
		private int mapId_;

		// Token: 0x04009915 RID: 39189
		public const int InstIdFieldNumber = 4;

		// Token: 0x04009916 RID: 39190
		private int instId_;

		// Token: 0x04009917 RID: 39191
		public const int PosFieldNumber = 5;

		// Token: 0x04009918 RID: 39192
		private Vector pos_;

		// Token: 0x04009919 RID: 39193
		public const int RotFieldNumber = 6;

		// Token: 0x0400991A RID: 39194
		private Rotator rot_;

		// Token: 0x0400991B RID: 39195
		public const int PlayerTeleportPosFieldNumber = 7;

		// Token: 0x0400991C RID: 39196
		private Vector playerTeleportPos_;

		// Token: 0x0400991D RID: 39197
		public const int AreaFieldNumber = 8;

		// Token: 0x0400991E RID: 39198
		private int area_;
	}
}
