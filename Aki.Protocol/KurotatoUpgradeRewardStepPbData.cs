using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CB RID: 2251
	public sealed class KurotatoUpgradeRewardStepPbData : IMessage<KurotatoUpgradeRewardStepPbData>, IMessage, IEquatable<KurotatoUpgradeRewardStepPbData>, IDeepCloneable<KurotatoUpgradeRewardStepPbData>, IBufferMessage
	{
		// Token: 0x0600C7B0 RID: 51120 RVA: 0x001D8C65 File Offset: 0x001D6E65
		[NullableContext(1)]
		public static KurotatoUpgradeRewardStepPbData Create()
		{
			return new KurotatoUpgradeRewardStepPbData();
		}

		// Token: 0x17002853 RID: 10323
		// (get) Token: 0x0600C7B1 RID: 51121 RVA: 0x001D8C6C File Offset: 0x001D6E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600C7B2 RID: 51122 RVA: 0x001D8C6F File Offset: 0x001D6E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C7B3 RID: 51123 RVA: 0x001D8C76 File Offset: 0x001D6E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData()
		{
		}

		// Token: 0x0600C7B4 RID: 51124 RVA: 0x001D8C7E File Offset: 0x001D6E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData(KurotatoUpgradeRewardStepPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C7B5 RID: 51125 RVA: 0x001D8C97 File Offset: 0x001D6E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardStepPbData Clone()
		{
			return new KurotatoUpgradeRewardStepPbData(this);
		}

		// Token: 0x0600C7B6 RID: 51126 RVA: 0x001D8C9F File Offset: 0x001D6E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardStepPbData);
		}

		// Token: 0x0600C7B7 RID: 51127 RVA: 0x001D8CAD File Offset: 0x001D6EAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardStepPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C7B8 RID: 51128 RVA: 0x001D8CCC File Offset: 0x001D6ECC
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

		// Token: 0x0600C7B9 RID: 51129 RVA: 0x001D8CF2 File Offset: 0x001D6EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7BA RID: 51130 RVA: 0x001D8CFF File Offset: 0x001D6EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7BB RID: 51131 RVA: 0x001D8D08 File Offset: 0x001D6F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7BC RID: 51132 RVA: 0x001D8D20 File Offset: 0x001D6F20
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

		// Token: 0x0600C7BD RID: 51133 RVA: 0x001D8D46 File Offset: 0x001D6F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoUpgradeRewardStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7BE RID: 51134 RVA: 0x001D8D63 File Offset: 0x001D6F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7BF RID: 51135 RVA: 0x001D8D6C File Offset: 0x001D6F6C
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

		// Token: 0x040055D2 RID: 21970
		private UnknownFieldSet _unknownFields;
	}
}
