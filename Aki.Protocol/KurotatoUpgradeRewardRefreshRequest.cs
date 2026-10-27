using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008D8 RID: 2264
	[NetMessage(EMessageId.KurotatoUpgradeRewardRefreshRequest)]
	public sealed class KurotatoUpgradeRewardRefreshRequest : IMessage<KurotatoUpgradeRewardRefreshRequest>, IMessage, IEquatable<KurotatoUpgradeRewardRefreshRequest>, IDeepCloneable<KurotatoUpgradeRewardRefreshRequest>, IBufferMessage
	{
		// Token: 0x0600C884 RID: 51332 RVA: 0x001DA758 File Offset: 0x001D8958
		[NullableContext(1)]
		public static KurotatoUpgradeRewardRefreshRequest Create()
		{
			return new KurotatoUpgradeRewardRefreshRequest();
		}

		// Token: 0x17002886 RID: 10374
		// (get) Token: 0x0600C885 RID: 51333 RVA: 0x001DA75F File Offset: 0x001D895F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002887 RID: 10375
		// (get) Token: 0x0600C886 RID: 51334 RVA: 0x001DA762 File Offset: 0x001D8962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardRefreshRequest.Descriptor;
			}
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x001DA769 File Offset: 0x001D8969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest()
		{
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x001DA771 File Offset: 0x001D8971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest(KurotatoUpgradeRewardRefreshRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x001DA78A File Offset: 0x001D898A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardRefreshRequest Clone()
		{
			return new KurotatoUpgradeRewardRefreshRequest(this);
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x001DA792 File Offset: 0x001D8992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardRefreshRequest);
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x001DA7A0 File Offset: 0x001D89A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardRefreshRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x001DA7C0 File Offset: 0x001D89C0
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

		// Token: 0x0600C88D RID: 51341 RVA: 0x001DA7E6 File Offset: 0x001D89E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x001DA7F3 File Offset: 0x001D89F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x001DA7FC File Offset: 0x001D89FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x001DA814 File Offset: 0x001D8A14
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

		// Token: 0x0600C891 RID: 51345 RVA: 0x001DA83A File Offset: 0x001D8A3A
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

		// Token: 0x0600C892 RID: 51346 RVA: 0x001DA857 File Offset: 0x001D8A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x001DA860 File Offset: 0x001D8A60
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

		// Token: 0x040055BF RID: 21951
		private UnknownFieldSet _unknownFields;
	}
}
