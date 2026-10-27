using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C6 RID: 2246
	[NetMessage(EMessageId.KurotatoShopRewardLockRequest)]
	public sealed class KurotatoShopRewardLockRequest : IMessage<KurotatoShopRewardLockRequest>, IMessage, IEquatable<KurotatoShopRewardLockRequest>, IDeepCloneable<KurotatoShopRewardLockRequest>, IBufferMessage
	{
		// Token: 0x0600C724 RID: 50980 RVA: 0x001D7631 File Offset: 0x001D5831
		[NullableContext(1)]
		public static KurotatoShopRewardLockRequest Create()
		{
			return new KurotatoShopRewardLockRequest();
		}

		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x0600C725 RID: 50981 RVA: 0x001D7638 File Offset: 0x001D5838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x0600C726 RID: 50982 RVA: 0x001D763B File Offset: 0x001D583B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardLockRequest.Descriptor;
			}
		}

		// Token: 0x0600C727 RID: 50983 RVA: 0x001D7642 File Offset: 0x001D5842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest()
		{
		}

		// Token: 0x0600C728 RID: 50984 RVA: 0x001D764A File Offset: 0x001D584A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest(KurotatoShopRewardLockRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x001D766F File Offset: 0x001D586F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest Clone()
		{
			return new KurotatoShopRewardLockRequest(this);
		}

		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x0600C72A RID: 50986 RVA: 0x001D7677 File Offset: 0x001D5877
		// (set) Token: 0x0600C72B RID: 50987 RVA: 0x001D767F File Offset: 0x001D587F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
		{
			get
			{
				return this.selectionId_;
			}
			set
			{
				this.selectionId_ = value;
			}
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x001D7688 File Offset: 0x001D5888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardLockRequest);
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x001D7696 File Offset: 0x001D5896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardLockRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x001D76C4 File Offset: 0x001D58C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectionId != 0)
			{
				num ^= this.SelectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x001D7703 File Offset: 0x001D5903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x001D7710 File Offset: 0x001D5910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x001D7719 File Offset: 0x001D5919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x001D774C File Offset: 0x001D594C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C733 RID: 50995 RVA: 0x001D778A File Offset: 0x001D598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardLockRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectionId != 0)
			{
				this.SelectionId = other.SelectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C734 RID: 50996 RVA: 0x001D77BB File Offset: 0x001D59BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C735 RID: 50997 RVA: 0x001D77C4 File Offset: 0x001D59C4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400556F RID: 21871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005570 RID: 21872
		public const int SelectionIdFieldNumber = 4;

		// Token: 0x04005571 RID: 21873
		private int selectionId_;
	}
}
