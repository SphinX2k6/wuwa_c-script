using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B8 RID: 2232
	[NetMessage(EMessageId.KurotatoShopRewardRefreshRequest)]
	public sealed class KurotatoShopRewardRefreshRequest : IMessage<KurotatoShopRewardRefreshRequest>, IMessage, IEquatable<KurotatoShopRewardRefreshRequest>, IDeepCloneable<KurotatoShopRewardRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600C640 RID: 50752 RVA: 0x001D5A38 File Offset: 0x001D3C38
		[NullableContext(1)]
		public static KurotatoShopRewardRefreshRequest Create()
		{
			return new KurotatoShopRewardRefreshRequest();
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600C641 RID: 50753 RVA: 0x001D5A3F File Offset: 0x001D3C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x0600C642 RID: 50754 RVA: 0x001D5A42 File Offset: 0x001D3C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600C643 RID: 50755 RVA: 0x001D5A49 File Offset: 0x001D3C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest()
		{
		}

		// Token: 0x0600C644 RID: 50756 RVA: 0x001D5A51 File Offset: 0x001D3C51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest(KurotatoShopRewardRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x001D5A6A File Offset: 0x001D3C6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest Clone()
		{
			return new KurotatoShopRewardRefreshRequest(this);
		}

		// Token: 0x0600C646 RID: 50758 RVA: 0x001D5A72 File Offset: 0x001D3C72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardRefreshRequest);
		}

		// Token: 0x0600C647 RID: 50759 RVA: 0x001D5A80 File Offset: 0x001D3C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C648 RID: 50760 RVA: 0x001D5AA0 File Offset: 0x001D3CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C649 RID: 50761 RVA: 0x001D5AC6 File Offset: 0x001D3CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C64A RID: 50762 RVA: 0x001D5AD3 File Offset: 0x001D3CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x001D5ADC File Offset: 0x001D3CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C64C RID: 50764 RVA: 0x001D5AF4 File Offset: 0x001D3CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C64D RID: 50765 RVA: 0x001D5B1A File Offset: 0x001D3D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardRefreshRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C64E RID: 50766 RVA: 0x001D5B37 File Offset: 0x001D3D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C64F RID: 50767 RVA: 0x001D5B40 File Offset: 0x001D3D40
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005581 RID: 21889
		private UnknownFieldSet _unknownFields;
	}
}
