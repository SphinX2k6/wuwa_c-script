using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000617 RID: 1559
	[NetMessage(EMessageId.FollowerChairPresentationChangeNotify)]
	public sealed class FollowerChairPresentationChangeNotify : IMessage<FollowerChairPresentationChangeNotify>, IMessage, IEquatable<FollowerChairPresentationChangeNotify>, IDeepCloneable<FollowerChairPresentationChangeNotify>, IBufferMessage
	{
		// Token: 0x06008FEC RID: 36844 RVA: 0x0015C588 File Offset: 0x0015A788
		[NullableContext(1)]
		public static FollowerChairPresentationChangeNotify Create()
		{
			return new FollowerChairPresentationChangeNotify();
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x0015C58F File Offset: 0x0015A78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06008FEE RID: 36846 RVA: 0x0015C592 File Offset: 0x0015A792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FollowerChairPresentationChangeNotify.Descriptor;
			}
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0015C599 File Offset: 0x0015A799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationChangeNotify()
		{
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0015C5A4 File Offset: 0x0015A7A4
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

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0015C624 File Offset: 0x0015A824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FollowerChairPresentationChangeNotify Clone()
		{
			return new FollowerChairPresentationChangeNotify(this);
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06008FF2 RID: 36850 RVA: 0x0015C62C File Offset: 0x0015A82C
		// (set) Token: 0x06008FF3 RID: 36851 RVA: 0x0015C634 File Offset: 0x0015A834
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

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06008FF4 RID: 36852 RVA: 0x0015C63D File Offset: 0x0015A83D
		// (set) Token: 0x06008FF5 RID: 36853 RVA: 0x0015C645 File Offset: 0x0015A845
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

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06008FF6 RID: 36854 RVA: 0x0015C64E File Offset: 0x0015A84E
		// (set) Token: 0x06008FF7 RID: 36855 RVA: 0x0015C656 File Offset: 0x0015A856
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

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06008FF8 RID: 36856 RVA: 0x0015C65F File Offset: 0x0015A85F
		// (set) Token: 0x06008FF9 RID: 36857 RVA: 0x0015C667 File Offset: 0x0015A867
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

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06008FFA RID: 36858 RVA: 0x0015C670 File Offset: 0x0015A870
		// (set) Token: 0x06008FFB RID: 36859 RVA: 0x0015C678 File Offset: 0x0015A878
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

		// Token: 0x06008FFC RID: 36860 RVA: 0x0015C681 File Offset: 0x0015A881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FollowerChairPresentationChangeNotify);
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0015C690 File Offset: 0x0015A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FollowerChairPresentationChangeNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.EntityId == other.EntityId && this.IsShow == other.IsShow && object.Equals(this.Location, other.Location) && object.Equals(this.Rotation, other.Rotation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0015C714 File Offset: 0x0015A914
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

		// Token: 0x06008FFF RID: 36863 RVA: 0x0015C7B1 File Offset: 0x0015A9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x0015C7BE File Offset: 0x0015A9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0015C7C8 File Offset: 0x0015A9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.location_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Location);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PlayerId);
			}
			if (this.rotation_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Rotation);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsShow);
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

		// Token: 0x06009002 RID: 36866 RVA: 0x0015C878 File Offset: 0x0015AA78
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

		// Token: 0x06009003 RID: 36867 RVA: 0x0015C90C File Offset: 0x0015AB0C
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

		// Token: 0x06009004 RID: 36868 RVA: 0x0015C9C8 File Offset: 0x0015ABC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x0015C9D4 File Offset: 0x0015ABD4
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
				if (num <= 56U)
				{
					if (num == 42U)
					{
						if (this.location_ == null)
						{
							this.Location = new Vector();
						}
						input.ReadMessage(this.Location);
						continue;
					}
					if (num == 56U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.rotation_ == null)
						{
							this.Rotation = new Rotator();
						}
						input.ReadMessage(this.Rotation);
						continue;
					}
					if (num == 88U)
					{
						this.IsShow = input.ReadBool();
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

		// Token: 0x040045BF RID: 17855
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045C0 RID: 17856
		public const int PlayerIdFieldNumber = 7;

		// Token: 0x040045C1 RID: 17857
		private int playerId_;

		// Token: 0x040045C2 RID: 17858
		public const int EntityIdFieldNumber = 12;

		// Token: 0x040045C3 RID: 17859
		private long entityId_;

		// Token: 0x040045C4 RID: 17860
		public const int IsShowFieldNumber = 11;

		// Token: 0x040045C5 RID: 17861
		private bool isShow_;

		// Token: 0x040045C6 RID: 17862
		public const int LocationFieldNumber = 5;

		// Token: 0x040045C7 RID: 17863
		private Vector location_;

		// Token: 0x040045C8 RID: 17864
		public const int RotationFieldNumber = 10;

		// Token: 0x040045C9 RID: 17865
		private Rotator rotation_;
	}
}
