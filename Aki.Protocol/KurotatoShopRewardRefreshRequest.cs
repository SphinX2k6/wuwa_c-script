using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C9 RID: 2249
	[NetMessage(EMessageId.KurotatoShopRewardRefreshRequest)]
	public sealed class KurotatoShopRewardRefreshRequest : IMessage<KurotatoShopRewardRefreshRequest>, IMessage, IEquatable<KurotatoShopRewardRefreshRequest>, IDeepCloneable<KurotatoShopRewardRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600C75C RID: 51036 RVA: 0x001D7D24 File Offset: 0x001D5F24
		[NullableContext(1)]
		public static KurotatoShopRewardRefreshRequest Create()
		{
			return new KurotatoShopRewardRefreshRequest();
		}

		// Token: 0x1700284B RID: 10315
		// (get) Token: 0x0600C75D RID: 51037 RVA: 0x001D7D2B File Offset: 0x001D5F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700284C RID: 10316
		// (get) Token: 0x0600C75E RID: 51038 RVA: 0x001D7D2E File Offset: 0x001D5F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600C75F RID: 51039 RVA: 0x001D7D35 File Offset: 0x001D5F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest()
		{
		}

		// Token: 0x0600C760 RID: 51040 RVA: 0x001D7D3D File Offset: 0x001D5F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest(KurotatoShopRewardRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C761 RID: 51041 RVA: 0x001D7D56 File Offset: 0x001D5F56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardRefreshRequest Clone()
		{
			return new KurotatoShopRewardRefreshRequest(this);
		}

		// Token: 0x0600C762 RID: 51042 RVA: 0x001D7D5E File Offset: 0x001D5F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardRefreshRequest);
		}

		// Token: 0x0600C763 RID: 51043 RVA: 0x001D7D6C File Offset: 0x001D5F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C764 RID: 51044 RVA: 0x001D7D8C File Offset: 0x001D5F8C
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

		// Token: 0x0600C765 RID: 51045 RVA: 0x001D7DB2 File Offset: 0x001D5FB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C766 RID: 51046 RVA: 0x001D7DBF File Offset: 0x001D5FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C767 RID: 51047 RVA: 0x001D7DC8 File Offset: 0x001D5FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C768 RID: 51048 RVA: 0x001D7DE0 File Offset: 0x001D5FE0
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

		// Token: 0x0600C769 RID: 51049 RVA: 0x001D7E06 File Offset: 0x001D6006
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

		// Token: 0x0600C76A RID: 51050 RVA: 0x001D7E23 File Offset: 0x001D6023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x001D7E2C File Offset: 0x001D602C
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

		// Token: 0x0400557A RID: 21882
		private UnknownFieldSet _unknownFields;
	}
}
