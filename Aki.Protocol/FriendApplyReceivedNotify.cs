using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200063B RID: 1595
	[NetMessage(EMessageId.FriendApplyReceivedNotify)]
	public sealed class FriendApplyReceivedNotify : IMessage<FriendApplyReceivedNotify>, IMessage, IEquatable<FriendApplyReceivedNotify>, IDeepCloneable<FriendApplyReceivedNotify>, IBufferMessage
	{
		// Token: 0x06009330 RID: 37680 RVA: 0x001644AE File Offset: 0x001626AE
		[NullableContext(1)]
		public static FriendApplyReceivedNotify Create()
		{
			return new FriendApplyReceivedNotify();
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06009331 RID: 37681 RVA: 0x001644B5 File Offset: 0x001626B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06009332 RID: 37682 RVA: 0x001644B8 File Offset: 0x001626B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyReceivedNotify.Descriptor;
			}
		}

		// Token: 0x06009333 RID: 37683 RVA: 0x001644BF File Offset: 0x001626BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify()
		{
		}

		// Token: 0x06009334 RID: 37684 RVA: 0x001644C7 File Offset: 0x001626C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify(FriendApplyReceivedNotify other) : this()
		{
			this.friendApply_ = ((other.friendApply_ != null) ? other.friendApply_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009335 RID: 37685 RVA: 0x001644FC File Offset: 0x001626FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyReceivedNotify Clone()
		{
			return new FriendApplyReceivedNotify(this);
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06009336 RID: 37686 RVA: 0x00164504 File Offset: 0x00162704
		// (set) Token: 0x06009337 RID: 37687 RVA: 0x0016450C File Offset: 0x0016270C
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

		// Token: 0x06009338 RID: 37688 RVA: 0x00164515 File Offset: 0x00162715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyReceivedNotify);
		}

		// Token: 0x06009339 RID: 37689 RVA: 0x00164523 File Offset: 0x00162723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyReceivedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FriendApply, other.FriendApply) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600933A RID: 37690 RVA: 0x00164558 File Offset: 0x00162758
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

		// Token: 0x0600933B RID: 37691 RVA: 0x00164594 File Offset: 0x00162794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600933C RID: 37692 RVA: 0x001645A1 File Offset: 0x001627A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600933D RID: 37693 RVA: 0x001645AA File Offset: 0x001627AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.friendApply_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.FriendApply);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600933E RID: 37694 RVA: 0x001645DC File Offset: 0x001627DC
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

		// Token: 0x0600933F RID: 37695 RVA: 0x0016461C File Offset: 0x0016281C
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

		// Token: 0x06009340 RID: 37696 RVA: 0x00164670 File Offset: 0x00162870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009341 RID: 37697 RVA: 0x0016467C File Offset: 0x0016287C
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
				if (num != 122U)
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

		// Token: 0x04004727 RID: 18215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004728 RID: 18216
		public const int FriendApplyFieldNumber = 15;

		// Token: 0x04004729 RID: 18217
		private FriendApply friendApply_;
	}
}
