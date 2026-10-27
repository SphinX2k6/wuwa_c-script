using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000618 RID: 1560
	[NetMessage(EMessageId.FollowerChairPresentationPush)]
	public sealed class FollowerChairPresentationPush : IMessage<FollowerChairPresentationPush>, IMessage, IEquatable<FollowerChairPresentationPush>, IDeepCloneable<FollowerChairPresentationPush>, IBufferMessage
	{
		// Token: 0x06009006 RID: 36870 RVA: 0x0015CA98 File Offset: 0x0015AC98
		[NullableContext(1)]
		public static FollowerChairPresentationPush Create()
		{
			return new FollowerChairPresentationPush();
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x0015CA9F File Offset: 0x0015AC9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06009008 RID: 36872 RVA: 0x0015CAA2 File Offset: 0x0015ACA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowerChairPresentationPush.Descriptor;
			}
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0015CAA9 File Offset: 0x0015ACA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationPush()
		{
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0015CAB4 File Offset: 0x0015ACB4
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

		// Token: 0x0600900B RID: 36875 RVA: 0x0015CB28 File Offset: 0x0015AD28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationPush Clone()
		{
			return new FollowerChairPresentationPush(this);
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x0600900C RID: 36876 RVA: 0x0015CB30 File Offset: 0x0015AD30
		// (set) Token: 0x0600900D RID: 36877 RVA: 0x0015CB38 File Offset: 0x0015AD38
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

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x0600900E RID: 36878 RVA: 0x0015CB41 File Offset: 0x0015AD41
		// (set) Token: 0x0600900F RID: 36879 RVA: 0x0015CB49 File Offset: 0x0015AD49
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

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06009010 RID: 36880 RVA: 0x0015CB52 File Offset: 0x0015AD52
		// (set) Token: 0x06009011 RID: 36881 RVA: 0x0015CB5A File Offset: 0x0015AD5A
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

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06009012 RID: 36882 RVA: 0x0015CB63 File Offset: 0x0015AD63
		// (set) Token: 0x06009013 RID: 36883 RVA: 0x0015CB6B File Offset: 0x0015AD6B
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

		// Token: 0x06009014 RID: 36884 RVA: 0x0015CB74 File Offset: 0x0015AD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowerChairPresentationPush);
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x0015CB84 File Offset: 0x0015AD84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowerChairPresentationPush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0015CBF8 File Offset: 0x0015ADF8
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

		// Token: 0x06009017 RID: 36887 RVA: 0x0015CC7C File Offset: 0x0015AE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x0015CC89 File Offset: 0x0015AE89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x0015CC94 File Offset: 0x0015AE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsShow);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Rotation);
			}
			if (this.location_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Location);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x0015CD24 File Offset: 0x0015AF24
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

		// Token: 0x0600901B RID: 36891 RVA: 0x0015CDA0 File Offset: 0x0015AFA0
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

		// Token: 0x0600901C RID: 36892 RVA: 0x0015CE48 File Offset: 0x0015B048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x0015CE54 File Offset: 0x0015B054
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
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 26U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045CA RID: 17866
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045CB RID: 17867
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040045CC RID: 17868
		private long entityId_;

		// Token: 0x040045CD RID: 17869
		public const int IsShowFieldNumber = 1;

		// Token: 0x040045CE RID: 17870
		private bool isShow_;

		// Token: 0x040045CF RID: 17871
		public const int LocationFieldNumber = 6;

		// Token: 0x040045D0 RID: 17872
		private Vector location_;

		// Token: 0x040045D1 RID: 17873
		public const int RotationFieldNumber = 3;

		// Token: 0x040045D2 RID: 17874
		private Rotator rotation_;
	}
}
