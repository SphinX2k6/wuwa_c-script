using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008DA RID: 2266
	[NetMessage(EMessageId.KurotatoUpgradeRewardSelectRequest)]
	public sealed class KurotatoUpgradeRewardSelectRequest : IMessage<KurotatoUpgradeRewardSelectRequest>, IMessage, IEquatable<KurotatoUpgradeRewardSelectRequest>, IDeepCloneable<KurotatoUpgradeRewardSelectRequest>, IBufferMessage
	{
		// Token: 0x0600C8A8 RID: 51368 RVA: 0x001DAB87 File Offset: 0x001D8D87
		[NullableContext(1)]
		public static KurotatoUpgradeRewardSelectRequest Create()
		{
			return new KurotatoUpgradeRewardSelectRequest();
		}

		// Token: 0x1700288C RID: 10380
		// (get) Token: 0x0600C8A9 RID: 51369 RVA: 0x001DAB8E File Offset: 0x001D8D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700288D RID: 10381
		// (get) Token: 0x0600C8AA RID: 51370 RVA: 0x001DAB91 File Offset: 0x001D8D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoUpgradeRewardSelectRequest.Descriptor;
			}
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x001DAB98 File Offset: 0x001D8D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest()
		{
		}

		// Token: 0x0600C8AC RID: 51372 RVA: 0x001DABA0 File Offset: 0x001D8DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest(KurotatoUpgradeRewardSelectRequest other) : this()
		{
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C8AD RID: 51373 RVA: 0x001DABC5 File Offset: 0x001D8DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoUpgradeRewardSelectRequest Clone()
		{
			return new KurotatoUpgradeRewardSelectRequest(this);
		}

		// Token: 0x1700288E RID: 10382
		// (get) Token: 0x0600C8AE RID: 51374 RVA: 0x001DABCD File Offset: 0x001D8DCD
		// (set) Token: 0x0600C8AF RID: 51375 RVA: 0x001DABD5 File Offset: 0x001D8DD5
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

		// Token: 0x0600C8B0 RID: 51376 RVA: 0x001DABDE File Offset: 0x001D8DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoUpgradeRewardSelectRequest);
		}

		// Token: 0x0600C8B1 RID: 51377 RVA: 0x001DABEC File Offset: 0x001D8DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoUpgradeRewardSelectRequest other)
		{
			return other != null && (other == this || (this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C8B2 RID: 51378 RVA: 0x001DAC1C File Offset: 0x001D8E1C
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

		// Token: 0x0600C8B3 RID: 51379 RVA: 0x001DAC5B File Offset: 0x001D8E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C8B4 RID: 51380 RVA: 0x001DAC68 File Offset: 0x001D8E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C8B5 RID: 51381 RVA: 0x001DAC71 File Offset: 0x001D8E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C8B6 RID: 51382 RVA: 0x001DACA4 File Offset: 0x001D8EA4
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

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x001DACE2 File Offset: 0x001D8EE2
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

		// Token: 0x0600C8B8 RID: 51384 RVA: 0x001DAD13 File Offset: 0x001D8F13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x001DAD1C File Offset: 0x001D8F1C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SelectionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040055C5 RID: 21957
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055C6 RID: 21958
		public const int SelectionIdFieldNumber = 7;

		// Token: 0x040055C7 RID: 21959
		private int selectionId_;
	}
}
