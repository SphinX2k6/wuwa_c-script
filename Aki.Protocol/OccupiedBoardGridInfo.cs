using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7F RID: 2943
	public sealed class OccupiedBoardGridInfo : IMessage<OccupiedBoardGridInfo>, IMessage, IEquatable<OccupiedBoardGridInfo>, IDeepCloneable<OccupiedBoardGridInfo>, IBufferMessage
	{
		// Token: 0x0600FF12 RID: 65298 RVA: 0x002532C3 File Offset: 0x002514C3
		[NullableContext(1)]
		public static OccupiedBoardGridInfo Create()
		{
			return new OccupiedBoardGridInfo();
		}

		// Token: 0x17003414 RID: 13332
		// (get) Token: 0x0600FF13 RID: 65299 RVA: 0x002532CA File Offset: 0x002514CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OccupiedBoardGridInfo> Parser
		{
			get
			{
				return OccupiedBoardGridInfo._parser;
			}
		}

		// Token: 0x17003415 RID: 13333
		// (get) Token: 0x0600FF14 RID: 65300 RVA: 0x002532D1 File Offset: 0x002514D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003416 RID: 13334
		// (get) Token: 0x0600FF15 RID: 65301 RVA: 0x002532D4 File Offset: 0x002514D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OccupiedBoardGridInfo.Descriptor;
			}
		}

		// Token: 0x0600FF16 RID: 65302 RVA: 0x002532DB File Offset: 0x002514DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo()
		{
		}

		// Token: 0x0600FF17 RID: 65303 RVA: 0x002532E4 File Offset: 0x002514E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo(OccupiedBoardGridInfo other) : this()
		{
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.occupyingEntityConfigId_ = other.occupyingEntityConfigId_;
			this.entityConfigType_ = other.entityConfigType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF18 RID: 65304 RVA: 0x0025333C File Offset: 0x0025153C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OccupiedBoardGridInfo Clone()
		{
			return new OccupiedBoardGridInfo(this);
		}

		// Token: 0x17003417 RID: 13335
		// (get) Token: 0x0600FF19 RID: 65305 RVA: 0x00253344 File Offset: 0x00251544
		// (set) Token: 0x0600FF1A RID: 65306 RVA: 0x0025334C File Offset: 0x0025154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo Pos
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

		// Token: 0x17003418 RID: 13336
		// (get) Token: 0x0600FF1B RID: 65307 RVA: 0x00253355 File Offset: 0x00251555
		// (set) Token: 0x0600FF1C RID: 65308 RVA: 0x0025335D File Offset: 0x0025155D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OccupyingEntityConfigId
		{
			get
			{
				return this.occupyingEntityConfigId_;
			}
			set
			{
				this.occupyingEntityConfigId_ = value;
			}
		}

		// Token: 0x17003419 RID: 13337
		// (get) Token: 0x0600FF1D RID: 65309 RVA: 0x00253366 File Offset: 0x00251566
		// (set) Token: 0x0600FF1E RID: 65310 RVA: 0x0025336E File Offset: 0x0025156E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigType
		{
			get
			{
				return this.entityConfigType_;
			}
			set
			{
				this.entityConfigType_ = value;
			}
		}

		// Token: 0x0600FF1F RID: 65311 RVA: 0x00253377 File Offset: 0x00251577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OccupiedBoardGridInfo);
		}

		// Token: 0x0600FF20 RID: 65312 RVA: 0x00253388 File Offset: 0x00251588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OccupiedBoardGridInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Pos, other.Pos) && this.OccupyingEntityConfigId == other.OccupyingEntityConfigId && this.EntityConfigType == other.EntityConfigType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF21 RID: 65313 RVA: 0x002533E8 File Offset: 0x002515E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				num ^= this.OccupyingEntityConfigId.GetHashCode();
			}
			if (this.EntityConfigType != 0)
			{
				num ^= this.EntityConfigType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FF22 RID: 65314 RVA: 0x00253456 File Offset: 0x00251656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF23 RID: 65315 RVA: 0x00253463 File Offset: 0x00251663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF24 RID: 65316 RVA: 0x0025346C File Offset: 0x0025166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OccupyingEntityConfigId);
			}
			if (this.EntityConfigType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntityConfigType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FF25 RID: 65317 RVA: 0x002534E4 File Offset: 0x002516E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.OccupyingEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OccupyingEntityConfigId);
			}
			if (this.EntityConfigType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FF26 RID: 65318 RVA: 0x00253554 File Offset: 0x00251754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OccupiedBoardGridInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new BoardGridPositionInfo();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.OccupyingEntityConfigId != 0)
			{
				this.OccupyingEntityConfigId = other.OccupyingEntityConfigId;
			}
			if (other.EntityConfigType != 0)
			{
				this.EntityConfigType = other.EntityConfigType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FF27 RID: 65319 RVA: 0x002535D0 File Offset: 0x002517D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF28 RID: 65320 RVA: 0x002535DC File Offset: 0x002517DC
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityConfigType = input.ReadInt32();
						}
					}
					else
					{
						this.OccupyingEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new BoardGridPositionInfo();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x0400659C RID: 26012
		private static readonly MessageParser<OccupiedBoardGridInfo> _parser = new MessageParser<OccupiedBoardGridInfo>(() => new OccupiedBoardGridInfo());

		// Token: 0x0400659D RID: 26013
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400659E RID: 26014
		public const int PosFieldNumber = 1;

		// Token: 0x0400659F RID: 26015
		private BoardGridPositionInfo pos_;

		// Token: 0x040065A0 RID: 26016
		public const int OccupyingEntityConfigIdFieldNumber = 2;

		// Token: 0x040065A1 RID: 26017
		private int occupyingEntityConfigId_;

		// Token: 0x040065A2 RID: 26018
		public const int EntityConfigTypeFieldNumber = 3;

		// Token: 0x040065A3 RID: 26019
		private int entityConfigType_;
	}
}
