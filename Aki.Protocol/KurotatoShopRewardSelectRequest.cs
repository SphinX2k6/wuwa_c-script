using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008BA RID: 2234
	[NetMessage(EMessageId.KurotatoShopRewardSelectRequest)]
	public sealed class KurotatoShopRewardSelectRequest : IMessage<KurotatoShopRewardSelectRequest>, IMessage, IEquatable<KurotatoShopRewardSelectRequest>, IDeepCloneable<KurotatoShopRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C664 RID: 50788 RVA: 0x001D5E67 File Offset: 0x001D4067
		[NullableContext(1)]
		public static KurotatoShopRewardSelectRequest Create()
		{
			return new KurotatoShopRewardSelectRequest();
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x0600C665 RID: 50789 RVA: 0x001D5E6E File Offset: 0x001D406E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x0600C666 RID: 50790 RVA: 0x001D5E71 File Offset: 0x001D4071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C667 RID: 50791 RVA: 0x001D5E78 File Offset: 0x001D4078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest()
		{
		}

		// Token: 0x0600C668 RID: 50792 RVA: 0x001D5E80 File Offset: 0x001D4080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest(KurotatoShopRewardSelectRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C669 RID: 50793 RVA: 0x001D5EA5 File Offset: 0x001D40A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectRequest Clone()
		{
			return new KurotatoShopRewardSelectRequest(this);
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x0600C66A RID: 50794 RVA: 0x001D5EAD File Offset: 0x001D40AD
		// (set) Token: 0x0600C66B RID: 50795 RVA: 0x001D5EB5 File Offset: 0x001D40B5
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

		// Token: 0x0600C66C RID: 50796 RVA: 0x001D5EBE File Offset: 0x001D40BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardSelectRequest);
		}

		// Token: 0x0600C66D RID: 50797 RVA: 0x001D5ECC File Offset: 0x001D40CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardSelectRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C66E RID: 50798 RVA: 0x001D5EFC File Offset: 0x001D40FC
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

		// Token: 0x0600C66F RID: 50799 RVA: 0x001D5F3B File Offset: 0x001D413B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C670 RID: 50800 RVA: 0x001D5F48 File Offset: 0x001D4148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x001D5F51 File Offset: 0x001D4151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x001D5F84 File Offset: 0x001D4184
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

		// Token: 0x0600C673 RID: 50803 RVA: 0x001D5FC2 File Offset: 0x001D41C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardSelectRequest other)
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

		// Token: 0x0600C674 RID: 50804 RVA: 0x001D5FF3 File Offset: 0x001D41F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C675 RID: 50805 RVA: 0x001D5FFC File Offset: 0x001D41FC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005587 RID: 21895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005588 RID: 21896
		public const int SelectionIdFieldNumber = 1;

		// Token: 0x04005589 RID: 21897
		private int selectionId_;
	}
}
