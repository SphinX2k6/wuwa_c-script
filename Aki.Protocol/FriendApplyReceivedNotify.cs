using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064F RID: 1615
	[NetMessage(EMessageId.FriendApplyReceivedNotify)]
	public sealed class FriendApplyReceivedNotify : IMessage<FriendApplyReceivedNotify>, IMessage, IEquatable<FriendApplyReceivedNotify>, IDeepCloneable<FriendApplyReceivedNotify>, IBufferMessage
	{
		// Token: 0x06009486 RID: 38022 RVA: 0x00166EDE File Offset: 0x001650DE
		[NullableContext(1)]
		public static FriendApplyReceivedNotify Create()
		{
			return new FriendApplyReceivedNotify();
		}

		// Token: 0x17001D91 RID: 7569
		// (get) Token: 0x06009487 RID: 38023 RVA: 0x00166EE5 File Offset: 0x001650E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x06009488 RID: 38024 RVA: 0x00166EE8 File Offset: 0x001650E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyReceivedNotify.Descriptor;
			}
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x00166EEF File Offset: 0x001650EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify()
		{
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x00166EF7 File Offset: 0x001650F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify(FriendApplyReceivedNotify other) : this()
		{
			this.friendApply_ = ((other.friendApply_ != null) ? other.friendApply_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x00166F2C File Offset: 0x0016512C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify Clone()
		{
			return new FriendApplyReceivedNotify(this);
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x0600948C RID: 38028 RVA: 0x00166F34 File Offset: 0x00165134
		// (set) Token: 0x0600948D RID: 38029 RVA: 0x00166F3C File Offset: 0x0016513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApply FriendApply
		{
			get
			{
				return this.friendApply_;
			}
			set
			{
				this.friendApply_ = value;
			}
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00166F45 File Offset: 0x00165145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyReceivedNotify);
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x00166F53 File Offset: 0x00165153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyReceivedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FriendApply, other.FriendApply) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00166F88 File Offset: 0x00165188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.friendApply_ != null)
			{
				num ^= this.FriendApply.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x00166FC4 File Offset: 0x001651C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x00166FD1 File Offset: 0x001651D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x00166FDA File Offset: 0x001651DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.friendApply_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.FriendApply);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x0016700C File Offset: 0x0016520C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.friendApply_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FriendApply);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x0016704C File Offset: 0x0016524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyReceivedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.friendApply_ != null)
			{
				if (this.friendApply_ == null)
				{
					this.FriendApply = new FriendApply();
				}
				this.FriendApply.MergeFrom(other.FriendApply);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x001670A0 File Offset: 0x001652A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x001670AC File Offset: 0x001652AC
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.friendApply_ == null)
					{
						this.FriendApply = new FriendApply();
					}
					input.ReadMessage(this.FriendApply);
				}
			}
		}

		// Token: 0x0400472E RID: 18222
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400472F RID: 18223
		public const int FriendApplyFieldNumber = 12;

		// Token: 0x04004730 RID: 18224
		private FriendApply friendApply_;
	}
}
