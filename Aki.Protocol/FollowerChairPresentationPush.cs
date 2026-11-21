using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000603 RID: 1539
	[NetMessage(EMessageId.FollowerChairPresentationPush)]
	public sealed class FollowerChairPresentationPush : IMessage<FollowerChairPresentationPush>, IMessage, IEquatable<FollowerChairPresentationPush>, IDeepCloneable<FollowerChairPresentationPush>, IBufferMessage
	{
		// Token: 0x06008E9E RID: 36510 RVA: 0x00159E8B File Offset: 0x0015808B
		[NullableContext(1)]
		public static FollowerChairPresentationPush Create()
		{
			return new FollowerChairPresentationPush();
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x00159E92 File Offset: 0x00158092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x00159E95 File Offset: 0x00158095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowerChairPresentationPush.Descriptor;
			}
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x00159E9C File Offset: 0x0015809C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationPush()
		{
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00159EA4 File Offset: 0x001580A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationPush(FollowerChairPresentationPush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isShow_ = other.isShow_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00159F18 File Offset: 0x00158118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationPush Clone()
		{
			return new FollowerChairPresentationPush(this);
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06008EA4 RID: 36516 RVA: 0x00159F20 File Offset: 0x00158120
		// (set) Token: 0x06008EA5 RID: 36517 RVA: 0x00159F28 File Offset: 0x00158128
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

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06008EA6 RID: 36518 RVA: 0x00159F31 File Offset: 0x00158131
		// (set) Token: 0x06008EA7 RID: 36519 RVA: 0x00159F39 File Offset: 0x00158139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06008EA8 RID: 36520 RVA: 0x00159F42 File Offset: 0x00158142
		// (set) Token: 0x06008EA9 RID: 36521 RVA: 0x00159F4A File Offset: 0x0015814A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06008EAA RID: 36522 RVA: 0x00159F53 File Offset: 0x00158153
		// (set) Token: 0x06008EAB RID: 36523 RVA: 0x00159F5B File Offset: 0x0015815B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00159F64 File Offset: 0x00158164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowerChairPresentationPush);
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x00159F74 File Offset: 0x00158174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowerChairPresentationPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x00159FE8 File Offset: 0x001581E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.location_ != null)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this.rotation_ != null)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x0015A06C File Offset: 0x0015826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0015A079 File Offset: 0x00158279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0015A084 File Offset: 0x00158284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsShow);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Location);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Rotation);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0015A118 File Offset: 0x00158318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.location_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Location);
			}
			if (this.rotation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0015A194 File Offset: 0x00158394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowerChairPresentationPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.location_ != null)
			{
				if (this.location_ == null)
				{
					this.Location = new Vector();
				}
				this.Location.MergeFrom(other.Location);
			}
			if (other.rotation_ != null)
			{
				if (this.rotation_ == null)
				{
					this.Rotation = new Rotator();
				}
				this.Rotation.MergeFrom(other.Rotation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x0015A23C File Offset: 0x0015843C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0015A248 File Offset: 0x00158448
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
				if (num <= 58U)
				{
					if (num == 40U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 58U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045C0 RID: 17856
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045C1 RID: 17857
		public const int EntityIdFieldNumber = 14;

		// Token: 0x040045C2 RID: 17858
		private long entityId_;

		// Token: 0x040045C3 RID: 17859
		public const int IsShowFieldNumber = 5;

		// Token: 0x040045C4 RID: 17860
		private bool isShow_;

		// Token: 0x040045C5 RID: 17861
		public const int LocationFieldNumber = 7;

		// Token: 0x040045C6 RID: 17862
		private Vector location_;

		// Token: 0x040045C7 RID: 17863
		public const int RotationFieldNumber = 8;

		// Token: 0x040045C8 RID: 17864
		private Rotator rotation_;
	}
}
