using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B5 RID: 2229
	[NetMessage(EMessageId.KurotatoShopRewardLockRequest)]
	public sealed class KurotatoShopRewardLockRequest : IMessage<KurotatoShopRewardLockRequest>, IMessage, IEquatable<KurotatoShopRewardLockRequest>, IDeepCloneable<KurotatoShopRewardLockRequest>, IBufferMessage
	{
		// Token: 0x0600C608 RID: 50696 RVA: 0x001D5345 File Offset: 0x001D3545
		[NullableContext(1)]
		public static KurotatoShopRewardLockRequest Create()
		{
			return new KurotatoShopRewardLockRequest();
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x0600C609 RID: 50697 RVA: 0x001D534C File Offset: 0x001D354C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x0600C60A RID: 50698 RVA: 0x001D534F File Offset: 0x001D354F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardLockRequest.Descriptor;
			}
		}

		// Token: 0x0600C60B RID: 50699 RVA: 0x001D5356 File Offset: 0x001D3556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest()
		{
		}

		// Token: 0x0600C60C RID: 50700 RVA: 0x001D535E File Offset: 0x001D355E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest(KurotatoShopRewardLockRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C60D RID: 50701 RVA: 0x001D5383 File Offset: 0x001D3583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardLockRequest Clone()
		{
			return new KurotatoShopRewardLockRequest(this);
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x0600C60E RID: 50702 RVA: 0x001D538B File Offset: 0x001D358B
		// (set) Token: 0x0600C60F RID: 50703 RVA: 0x001D5393 File Offset: 0x001D3593
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

		// Token: 0x0600C610 RID: 50704 RVA: 0x001D539C File Offset: 0x001D359C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardLockRequest);
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x001D53AA File Offset: 0x001D35AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardLockRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x001D53D8 File Offset: 0x001D35D8
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

		// Token: 0x0600C613 RID: 50707 RVA: 0x001D5417 File Offset: 0x001D3617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C614 RID: 50708 RVA: 0x001D5424 File Offset: 0x001D3624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C615 RID: 50709 RVA: 0x001D542D File Offset: 0x001D362D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C616 RID: 50710 RVA: 0x001D5460 File Offset: 0x001D3660
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

		// Token: 0x0600C617 RID: 50711 RVA: 0x001D549E File Offset: 0x001D369E
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

		// Token: 0x0600C618 RID: 50712 RVA: 0x001D54CF File Offset: 0x001D36CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C619 RID: 50713 RVA: 0x001D54D8 File Offset: 0x001D36D8
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005576 RID: 21878
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005577 RID: 21879
		public const int SelectionIdFieldNumber = 13;

		// Token: 0x04005578 RID: 21880
		private int selectionId_;
	}
}
