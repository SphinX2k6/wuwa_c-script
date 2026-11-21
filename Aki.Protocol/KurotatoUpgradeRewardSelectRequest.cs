using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008C9 RID: 2249
	[NetMessage(EMessageId.KurotatoUpgradeRewardSelectRequest)]
	public sealed class KurotatoUpgradeRewardSelectRequest : IMessage<KurotatoUpgradeRewardSelectRequest>, IMessage, IEquatable<KurotatoUpgradeRewardSelectRequest>, IDeepCloneable<KurotatoUpgradeRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C78C RID: 51084 RVA: 0x001D88AB File Offset: 0x001D6AAB
		[NullableContext(1)]
		public static KurotatoUpgradeRewardSelectRequest Create()
		{
			return new KurotatoUpgradeRewardSelectRequest();
		}

		// Token: 0x1700284D RID: 10317
		// (get) Token: 0x0600C78D RID: 51085 RVA: 0x001D88B2 File Offset: 0x001D6AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700284E RID: 10318
		// (get) Token: 0x0600C78E RID: 51086 RVA: 0x001D88B5 File Offset: 0x001D6AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x001D88BC File Offset: 0x001D6ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest()
		{
		}

		// Token: 0x0600C790 RID: 51088 RVA: 0x001D88C4 File Offset: 0x001D6AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest(KurotatoUpgradeRewardSelectRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C791 RID: 51089 RVA: 0x001D88E9 File Offset: 0x001D6AE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest Clone()
		{
			return new KurotatoUpgradeRewardSelectRequest(this);
		}

		// Token: 0x1700284F RID: 10319
		// (get) Token: 0x0600C792 RID: 51090 RVA: 0x001D88F1 File Offset: 0x001D6AF1
		// (set) Token: 0x0600C793 RID: 51091 RVA: 0x001D88F9 File Offset: 0x001D6AF9
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

		// Token: 0x0600C794 RID: 51092 RVA: 0x001D8902 File Offset: 0x001D6B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardSelectRequest);
		}

		// Token: 0x0600C795 RID: 51093 RVA: 0x001D8910 File Offset: 0x001D6B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardSelectRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C796 RID: 51094 RVA: 0x001D8940 File Offset: 0x001D6B40
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

		// Token: 0x0600C797 RID: 51095 RVA: 0x001D897F File Offset: 0x001D6B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C798 RID: 51096 RVA: 0x001D898C File Offset: 0x001D6B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C799 RID: 51097 RVA: 0x001D8995 File Offset: 0x001D6B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C79A RID: 51098 RVA: 0x001D89C8 File Offset: 0x001D6BC8
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

		// Token: 0x0600C79B RID: 51099 RVA: 0x001D8A06 File Offset: 0x001D6C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardSelectRequest other)
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

		// Token: 0x0600C79C RID: 51100 RVA: 0x001D8A37 File Offset: 0x001D6C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x001D8A40 File Offset: 0x001D6C40
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055CC RID: 21964
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055CD RID: 21965
		public const int SelectionIdFieldNumber = 14;

		// Token: 0x040055CE RID: 21966
		private int selectionId_;
	}
}
