using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000602 RID: 1538
	[NetMessage(EMessageId.FollowerChairPresentationChangeNotify)]
	public sealed class FollowerChairPresentationChangeNotify : IMessage<FollowerChairPresentationChangeNotify>, IMessage, IEquatable<FollowerChairPresentationChangeNotify>, IDeepCloneable<FollowerChairPresentationChangeNotify>, IBufferMessage
	{
		// Token: 0x06008E84 RID: 36484 RVA: 0x00159980 File Offset: 0x00157B80
		[NullableContext(1)]
		public static FollowerChairPresentationChangeNotify Create()
		{
			return new FollowerChairPresentationChangeNotify();
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06008E85 RID: 36485 RVA: 0x00159987 File Offset: 0x00157B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06008E86 RID: 36486 RVA: 0x0015998A File Offset: 0x00157B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowerChairPresentationChangeNotify.Descriptor;
			}
		}

		// Token: 0x06008E87 RID: 36487 RVA: 0x00159991 File Offset: 0x00157B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationChangeNotify()
		{
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x0015999C File Offset: 0x00157B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationChangeNotify(FollowerChairPresentationChangeNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.entityId_ = other.entityId_;
			this.isShow_ = other.isShow_;
			this.location_ = ((other.location_ != null) ? other.location_.Clone() : null);
			this.rotation_ = ((other.rotation_ != null) ? other.rotation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x00159A1C File Offset: 0x00157C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationChangeNotify Clone()
		{
			return new FollowerChairPresentationChangeNotify(this);
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06008E8A RID: 36490 RVA: 0x00159A24 File Offset: 0x00157C24
		// (set) Token: 0x06008E8B RID: 36491 RVA: 0x00159A2C File Offset: 0x00157C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06008E8C RID: 36492 RVA: 0x00159A35 File Offset: 0x00157C35
		// (set) Token: 0x06008E8D RID: 36493 RVA: 0x00159A3D File Offset: 0x00157C3D
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

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x00159A46 File Offset: 0x00157C46
		// (set) Token: 0x06008E8F RID: 36495 RVA: 0x00159A4E File Offset: 0x00157C4E
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

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x00159A57 File Offset: 0x00157C57
		// (set) Token: 0x06008E91 RID: 36497 RVA: 0x00159A5F File Offset: 0x00157C5F
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

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x00159A68 File Offset: 0x00157C68
		// (set) Token: 0x06008E93 RID: 36499 RVA: 0x00159A70 File Offset: 0x00157C70
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

		// Token: 0x06008E94 RID: 36500 RVA: 0x00159A79 File Offset: 0x00157C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowerChairPresentationChangeNotify);
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x00159A88 File Offset: 0x00157C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowerChairPresentationChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x00159B0C File Offset: 0x00157D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
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

		// Token: 0x06008E97 RID: 36503 RVA: 0x00159BA9 File Offset: 0x00157DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x00159BB6 File Offset: 0x00157DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x00159BC0 File Offset: 0x00157DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShow);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.PlayerId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rotation);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x00159C6C File Offset: 0x00157E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
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

		// Token: 0x06008E9B RID: 36507 RVA: 0x00159D00 File Offset: 0x00157F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FollowerChairPresentationChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
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

		// Token: 0x06008E9C RID: 36508 RVA: 0x00159DBC File Offset: 0x00157FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x00159DC8 File Offset: 0x00157FC8
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 50U)
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
					if (num == 122U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045B5 RID: 17845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B6 RID: 17846
		public const int PlayerIdFieldNumber = 5;

		// Token: 0x040045B7 RID: 17847
		private int playerId_;

		// Token: 0x040045B8 RID: 17848
		public const int EntityIdFieldNumber = 14;

		// Token: 0x040045B9 RID: 17849
		private long entityId_;

		// Token: 0x040045BA RID: 17850
		public const int IsShowFieldNumber = 1;

		// Token: 0x040045BB RID: 17851
		private bool isShow_;

		// Token: 0x040045BC RID: 17852
		public const int LocationFieldNumber = 15;

		// Token: 0x040045BD RID: 17853
		private Vector location_;

		// Token: 0x040045BE RID: 17854
		public const int RotationFieldNumber = 6;

		// Token: 0x040045BF RID: 17855
		private Rotator rotation_;
	}
}
