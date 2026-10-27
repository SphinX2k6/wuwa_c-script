using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064B RID: 1611
	public sealed class FriendApply : IMessage<FriendApply>, IMessage, IEquatable<FriendApply>, IDeepCloneable<FriendApply>, IBufferMessage
	{
		// Token: 0x06009436 RID: 37942 RVA: 0x00166461 File Offset: 0x00164661
		[NullableContext(1)]
		public static FriendApply Create()
		{
			return new FriendApply();
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06009437 RID: 37943 RVA: 0x00166468 File Offset: 0x00164668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendApply> Parser
		{
			get
			{
				return FriendApply._parser;
			}
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x0016646F File Offset: 0x0016466F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D83 RID: 7555
		// (get) Token: 0x06009439 RID: 37945 RVA: 0x00166472 File Offset: 0x00164672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApply.Descriptor;
			}
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x00166479 File Offset: 0x00164679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply()
		{
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00166484 File Offset: 0x00164684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply(FriendApply other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.createdTime_ = other.createdTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x001664D0 File Offset: 0x001646D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply Clone()
		{
			return new FriendApply(this);
		}

		// Token: 0x17001D84 RID: 7556
		// (get) Token: 0x0600943D RID: 37949 RVA: 0x001664D8 File Offset: 0x001646D8
		// (set) Token: 0x0600943E RID: 37950 RVA: 0x001664E0 File Offset: 0x001646E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17001D85 RID: 7557
		// (get) Token: 0x0600943F RID: 37951 RVA: 0x001664E9 File Offset: 0x001646E9
		// (set) Token: 0x06009440 RID: 37952 RVA: 0x001664F1 File Offset: 0x001646F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreatedTime
		{
			get
			{
				return this.createdTime_;
			}
			set
			{
				this.createdTime_ = value;
			}
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x001664FA File Offset: 0x001646FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApply);
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x00166508 File Offset: 0x00164708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApply other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.CreatedTime == other.CreatedTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x00166558 File Offset: 0x00164758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.CreatedTime != 0L)
			{
				num ^= this.CreatedTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x001665AD File Offset: 0x001647AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x001665BA File Offset: 0x001647BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x001665C4 File Offset: 0x001647C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.CreatedTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.CreatedTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x00166620 File Offset: 0x00164820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.CreatedTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreatedTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x00166678 File Offset: 0x00164878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApply other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.CreatedTime != 0L)
			{
				this.CreatedTime = other.CreatedTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x001666E0 File Offset: 0x001648E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x001666EC File Offset: 0x001648EC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CreatedTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04004719 RID: 18201
		private static readonly MessageParser<FriendApply> _parser = new MessageParser<FriendApply>(() => new FriendApply());

		// Token: 0x0400471A RID: 18202
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400471B RID: 18203
		public const int InfoFieldNumber = 1;

		// Token: 0x0400471C RID: 18204
		private PlayerDetails info_;

		// Token: 0x0400471D RID: 18205
		public const int CreatedTimeFieldNumber = 2;

		// Token: 0x0400471E RID: 18206
		private long createdTime_;
	}
}
