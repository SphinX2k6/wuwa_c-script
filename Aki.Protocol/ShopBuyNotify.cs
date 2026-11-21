using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001229 RID: 4649
	[NetMessage(EMessageId.ShopBuyNotify)]
	public sealed class ShopBuyNotify : IMessage<ShopBuyNotify>, IMessage, IEquatable<ShopBuyNotify>, IDeepCloneable<ShopBuyNotify>, IBufferMessage
	{
		// Token: 0x06018D3E RID: 101694 RVA: 0x0039E621 File Offset: 0x0039C821
		[NullableContext(1)]
		public static ShopBuyNotify Create()
		{
			return new ShopBuyNotify();
		}

		// Token: 0x170053DA RID: 21466
		// (get) Token: 0x06018D3F RID: 101695 RVA: 0x0039E628 File Offset: 0x0039C828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053DB RID: 21467
		// (get) Token: 0x06018D40 RID: 101696 RVA: 0x0039E62B File Offset: 0x0039C82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopBuyNotify.Descriptor;
			}
		}

		// Token: 0x06018D41 RID: 101697 RVA: 0x0039E632 File Offset: 0x0039C832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify()
		{
		}

		// Token: 0x06018D42 RID: 101698 RVA: 0x0039E63A File Offset: 0x0039C83A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify(ShopBuyNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D43 RID: 101699 RVA: 0x0039E66B File Offset: 0x0039C86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopBuyNotify Clone()
		{
			return new ShopBuyNotify(this);
		}

		// Token: 0x170053DC RID: 21468
		// (get) Token: 0x06018D44 RID: 101700 RVA: 0x0039E673 File Offset: 0x0039C873
		// (set) Token: 0x06018D45 RID: 101701 RVA: 0x0039E67B File Offset: 0x0039C87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170053DD RID: 21469
		// (get) Token: 0x06018D46 RID: 101702 RVA: 0x0039E684 File Offset: 0x0039C884
		// (set) Token: 0x06018D47 RID: 101703 RVA: 0x0039E68C File Offset: 0x0039C88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x06018D48 RID: 101704 RVA: 0x0039E695 File Offset: 0x0039C895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopBuyNotify);
		}

		// Token: 0x06018D49 RID: 101705 RVA: 0x0039E6A3 File Offset: 0x0039C8A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopBuyNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D4A RID: 101706 RVA: 0x0039E6E4 File Offset: 0x0039C8E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D4B RID: 101707 RVA: 0x0039E742 File Offset: 0x0039C942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D4C RID: 101708 RVA: 0x0039E74F File Offset: 0x0039C94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D4D RID: 101709 RVA: 0x0039E758 File Offset: 0x0039C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D4E RID: 101710 RVA: 0x0039E7B4 File Offset: 0x0039C9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D4F RID: 101711 RVA: 0x0039E80C File Offset: 0x0039CA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopBuyNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D50 RID: 101712 RVA: 0x0039E85C File Offset: 0x0039CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D51 RID: 101713 RVA: 0x0039E868 File Offset: 0x0039CA68
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400934C RID: 37708
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400934D RID: 37709
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400934E RID: 37710
		private ErrorCode errorCode_;

		// Token: 0x0400934F RID: 37711
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04009350 RID: 37712
		private int entityId_;
	}
}
