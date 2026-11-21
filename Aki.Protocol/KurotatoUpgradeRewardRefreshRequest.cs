using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C7 RID: 2247
	[NetMessage(EMessageId.KurotatoUpgradeRewardRefreshRequest)]
	public sealed class KurotatoUpgradeRewardRefreshRequest : IMessage<KurotatoUpgradeRewardRefreshRequest>, IMessage, IEquatable<KurotatoUpgradeRewardRefreshRequest>, IDeepCloneable<KurotatoUpgradeRewardRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600C768 RID: 51048 RVA: 0x001D847C File Offset: 0x001D667C
		[NullableContext(1)]
		public static KurotatoUpgradeRewardRefreshRequest Create()
		{
			return new KurotatoUpgradeRewardRefreshRequest();
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x0600C769 RID: 51049 RVA: 0x001D8483 File Offset: 0x001D6683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x0600C76A RID: 51050 RVA: 0x001D8486 File Offset: 0x001D6686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600C76B RID: 51051 RVA: 0x001D848D File Offset: 0x001D668D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest()
		{
		}

		// Token: 0x0600C76C RID: 51052 RVA: 0x001D8495 File Offset: 0x001D6695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest(KurotatoUpgradeRewardRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C76D RID: 51053 RVA: 0x001D84AE File Offset: 0x001D66AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest Clone()
		{
			return new KurotatoUpgradeRewardRefreshRequest(this);
		}

		// Token: 0x0600C76E RID: 51054 RVA: 0x001D84B6 File Offset: 0x001D66B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardRefreshRequest);
		}

		// Token: 0x0600C76F RID: 51055 RVA: 0x001D84C4 File Offset: 0x001D66C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C770 RID: 51056 RVA: 0x001D84E4 File Offset: 0x001D66E4
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

		// Token: 0x0600C771 RID: 51057 RVA: 0x001D850A File Offset: 0x001D670A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C772 RID: 51058 RVA: 0x001D8517 File Offset: 0x001D6717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x001D8520 File Offset: 0x001D6720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C774 RID: 51060 RVA: 0x001D8538 File Offset: 0x001D6738
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

		// Token: 0x0600C775 RID: 51061 RVA: 0x001D855E File Offset: 0x001D675E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardRefreshRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x001D857B File Offset: 0x001D677B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x001D8584 File Offset: 0x001D6784
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

		// Token: 0x040055C6 RID: 21958
		private UnknownFieldSet _unknownFields;
	}
}
