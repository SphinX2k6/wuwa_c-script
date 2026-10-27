using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E6 RID: 998
	public sealed class DollDeliveryInfo : IMessage<DollDeliveryInfo>, IMessage, IEquatable<DollDeliveryInfo>, IDeepCloneable<DollDeliveryInfo>, IBufferMessage
	{
		// Token: 0x060060ED RID: 24813 RVA: 0x000EA270 File Offset: 0x000E8470
		[NullableContext(1)]
		public static DollDeliveryInfo Create()
		{
			return new DollDeliveryInfo();
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x060060EE RID: 24814 RVA: 0x000EA277 File Offset: 0x000E8477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DollDeliveryInfo> Parser
		{
			get
			{
				return DollDeliveryInfo._parser;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x000EA27E File Offset: 0x000E847E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x060060F0 RID: 24816 RVA: 0x000EA281 File Offset: 0x000E8481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryInfo.Descriptor;
			}
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x000EA288 File Offset: 0x000E8488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo()
		{
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x000EA29B File Offset: 0x000E849B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo(DollDeliveryInfo other) : this()
		{
			this.showcaseEntityId_ = other.showcaseEntityId_;
			this.deliveredDolls_ = other.deliveredDolls_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x000EA2D1 File Offset: 0x000E84D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo Clone()
		{
			return new DollDeliveryInfo(this);
		}

		// Token: 0x17001212 RID: 4626
		// (get) Token: 0x060060F4 RID: 24820 RVA: 0x000EA2D9 File Offset: 0x000E84D9
		// (set) Token: 0x060060F5 RID: 24821 RVA: 0x000EA2E1 File Offset: 0x000E84E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShowcaseEntityId
		{
			get
			{
				return this.showcaseEntityId_;
			}
			set
			{
				this.showcaseEntityId_ = value;
			}
		}

		// Token: 0x17001213 RID: 4627
		// (get) Token: 0x060060F6 RID: 24822 RVA: 0x000EA2EA File Offset: 0x000E84EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeliveredDolls
		{
			get
			{
				return this.deliveredDolls_;
			}
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x000EA2F2 File Offset: 0x000E84F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryInfo);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x000EA300 File Offset: 0x000E8500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryInfo other)
		{
			return other != null && (other == this || (this.ShowcaseEntityId == other.ShowcaseEntityId && this.deliveredDolls_.Equals(other.deliveredDolls_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x000EA350 File Offset: 0x000E8550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShowcaseEntityId != 0)
			{
				num ^= this.ShowcaseEntityId.GetHashCode();
			}
			num ^= this.deliveredDolls_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x000EA39D File Offset: 0x000E859D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x000EA3AA File Offset: 0x000E85AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x000EA3B4 File Offset: 0x000E85B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowcaseEntityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ShowcaseEntityId);
			}
			this.deliveredDolls_.WriteTo(ref output, DollDeliveryInfo._repeated_deliveredDolls_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x000EA404 File Offset: 0x000E8604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShowcaseEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShowcaseEntityId);
			}
			num += this.deliveredDolls_.CalculateSize(DollDeliveryInfo._repeated_deliveredDolls_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x000EA458 File Offset: 0x000E8658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShowcaseEntityId != 0)
			{
				this.ShowcaseEntityId = other.ShowcaseEntityId;
			}
			this.deliveredDolls_.Add(other.deliveredDolls_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x000EA4A5 File Offset: 0x000E86A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x000EA4B0 File Offset: 0x000E86B0
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.deliveredDolls_.AddEntriesFrom(ref input, DollDeliveryInfo._repeated_deliveredDolls_codec);
					}
				}
				else
				{
					this.ShowcaseEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400377D RID: 14205
		private static readonly MessageParser<DollDeliveryInfo> _parser = new MessageParser<DollDeliveryInfo>(() => new DollDeliveryInfo());

		// Token: 0x0400377E RID: 14206
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400377F RID: 14207
		public const int ShowcaseEntityIdFieldNumber = 1;

		// Token: 0x04003780 RID: 14208
		private int showcaseEntityId_;

		// Token: 0x04003781 RID: 14209
		public const int DeliveredDollsFieldNumber = 2;

		// Token: 0x04003782 RID: 14210
		private static readonly FieldCodec<int> _repeated_deliveredDolls_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003783 RID: 14211
		private readonly RepeatedField<int> deliveredDolls_ = new RepeatedField<int>();
	}
}
