using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DB RID: 4827
	[NetMessage(EMessageId.SplineMoveNotify)]
	public sealed class SplineMoveNotify : IMessage<SplineMoveNotify>, IMessage, IEquatable<SplineMoveNotify>, IDeepCloneable<SplineMoveNotify>, IBufferMessage
	{
		// Token: 0x06019C22 RID: 105506 RVA: 0x003C1C99 File Offset: 0x003BFE99
		[NullableContext(1)]
		public static SplineMoveNotify Create()
		{
			return new SplineMoveNotify();
		}

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x06019C23 RID: 105507 RVA: 0x003C1CA0 File Offset: 0x003BFEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x06019C24 RID: 105508 RVA: 0x003C1CA3 File Offset: 0x003BFEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveNotify.Descriptor;
			}
		}

		// Token: 0x06019C25 RID: 105509 RVA: 0x003C1CAA File Offset: 0x003BFEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify()
		{
		}

		// Token: 0x06019C26 RID: 105510 RVA: 0x003C1CB4 File Offset: 0x003BFEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify(SplineMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pathId_ = other.pathId_;
			this.pathRatio_ = other.pathRatio_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C27 RID: 105511 RVA: 0x003C1D18 File Offset: 0x003BFF18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify Clone()
		{
			return new SplineMoveNotify(this);
		}

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x06019C28 RID: 105512 RVA: 0x003C1D20 File Offset: 0x003BFF20
		// (set) Token: 0x06019C29 RID: 105513 RVA: 0x003C1D28 File Offset: 0x003BFF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x06019C2A RID: 105514 RVA: 0x003C1D31 File Offset: 0x003BFF31
		// (set) Token: 0x06019C2B RID: 105515 RVA: 0x003C1D39 File Offset: 0x003BFF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathId
		{
			get
			{
				return this.pathId_;
			}
			set
			{
				this.pathId_ = value;
			}
		}

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x06019C2C RID: 105516 RVA: 0x003C1D42 File Offset: 0x003BFF42
		// (set) Token: 0x06019C2D RID: 105517 RVA: 0x003C1D4A File Offset: 0x003BFF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathRatio
		{
			get
			{
				return this.pathRatio_;
			}
			set
			{
				this.pathRatio_ = value;
			}
		}

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x06019C2E RID: 105518 RVA: 0x003C1D53 File Offset: 0x003BFF53
		// (set) Token: 0x06019C2F RID: 105519 RVA: 0x003C1D5B File Offset: 0x003BFF5B
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

		// Token: 0x06019C30 RID: 105520 RVA: 0x003C1D64 File Offset: 0x003BFF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveNotify);
		}

		// Token: 0x06019C31 RID: 105521 RVA: 0x003C1D74 File Offset: 0x003BFF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PathId == other.PathId && this.PathRatio == other.PathRatio && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C32 RID: 105522 RVA: 0x003C1DE4 File Offset: 0x003BFFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PathId != 0)
			{
				num ^= this.PathId.GetHashCode();
			}
			if (this.PathRatio != 0)
			{
				num ^= this.PathRatio.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019C33 RID: 105523 RVA: 0x003C1E6B File Offset: 0x003C006B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C34 RID: 105524 RVA: 0x003C1E78 File Offset: 0x003C0078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C35 RID: 105525 RVA: 0x003C1E84 File Offset: 0x003C0084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.PathRatio != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PathRatio);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.PathId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.PathId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C36 RID: 105526 RVA: 0x003C1F18 File Offset: 0x003C0118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PathId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathId);
			}
			if (this.PathRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathRatio);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019C37 RID: 105527 RVA: 0x003C1FA0 File Offset: 0x003C01A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PathId != 0)
			{
				this.PathId = other.PathId;
			}
			if (other.PathRatio != 0)
			{
				this.PathRatio = other.PathRatio;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019C38 RID: 105528 RVA: 0x003C2030 File Offset: 0x003C0230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C39 RID: 105529 RVA: 0x003C203C File Offset: 0x003C023C
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
					if (num == 10U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 24U)
					{
						this.PathRatio = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.PathId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009806 RID: 38918
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009807 RID: 38919
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04009808 RID: 38920
		private long entityId_;

		// Token: 0x04009809 RID: 38921
		public const int PathIdFieldNumber = 10;

		// Token: 0x0400980A RID: 38922
		private int pathId_;

		// Token: 0x0400980B RID: 38923
		public const int PathRatioFieldNumber = 3;

		// Token: 0x0400980C RID: 38924
		private int pathRatio_;

		// Token: 0x0400980D RID: 38925
		public const int PosFieldNumber = 1;

		// Token: 0x0400980E RID: 38926
		private Vector pos_;
	}
}
