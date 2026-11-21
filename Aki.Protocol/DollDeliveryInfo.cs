using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CF RID: 975
	public sealed class DollDeliveryInfo : IMessage<DollDeliveryInfo>, IMessage, IEquatable<DollDeliveryInfo>, IDeepCloneable<DollDeliveryInfo>, IBufferMessage
	{
		// Token: 0x06005F5D RID: 24413 RVA: 0x000E70F0 File Offset: 0x000E52F0
		[NullableContext(1)]
		public static DollDeliveryInfo Create()
		{
			return new DollDeliveryInfo();
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06005F5E RID: 24414 RVA: 0x000E70F7 File Offset: 0x000E52F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DollDeliveryInfo> Parser
		{
			get
			{
				return DollDeliveryInfo._parser;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x000E70FE File Offset: 0x000E52FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x06005F60 RID: 24416 RVA: 0x000E7101 File Offset: 0x000E5301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryInfo.Descriptor;
			}
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x000E7108 File Offset: 0x000E5308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo()
		{
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x000E711B File Offset: 0x000E531B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo(DollDeliveryInfo other) : this()
		{
			this.showcaseEntityId_ = other.showcaseEntityId_;
			this.deliveredDolls_ = other.deliveredDolls_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x000E7151 File Offset: 0x000E5351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryInfo Clone()
		{
			return new DollDeliveryInfo(this);
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x06005F64 RID: 24420 RVA: 0x000E7159 File Offset: 0x000E5359
		// (set) Token: 0x06005F65 RID: 24421 RVA: 0x000E7161 File Offset: 0x000E5361
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

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x000E716A File Offset: 0x000E536A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeliveredDolls
		{
			get
			{
				return this.deliveredDolls_;
			}
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x000E7172 File Offset: 0x000E5372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryInfo);
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x000E7180 File Offset: 0x000E5380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryInfo other)
		{
			return other != null && (other == this || (this.ShowcaseEntityId == other.ShowcaseEntityId && this.deliveredDolls_.Equals(other.deliveredDolls_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x000E71D0 File Offset: 0x000E53D0
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

		// Token: 0x06005F6A RID: 24426 RVA: 0x000E721D File Offset: 0x000E541D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x000E722A File Offset: 0x000E542A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x000E7234 File Offset: 0x000E5434
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

		// Token: 0x06005F6D RID: 24429 RVA: 0x000E7284 File Offset: 0x000E5484
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

		// Token: 0x06005F6E RID: 24430 RVA: 0x000E72D8 File Offset: 0x000E54D8
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

		// Token: 0x06005F6F RID: 24431 RVA: 0x000E7325 File Offset: 0x000E5525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x000E7330 File Offset: 0x000E5530
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

		// Token: 0x0400376A RID: 14186
		private static readonly MessageParser<DollDeliveryInfo> _parser = new MessageParser<DollDeliveryInfo>(() => new DollDeliveryInfo());

		// Token: 0x0400376B RID: 14187
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400376C RID: 14188
		public const int ShowcaseEntityIdFieldNumber = 1;

		// Token: 0x0400376D RID: 14189
		private int showcaseEntityId_;

		// Token: 0x0400376E RID: 14190
		public const int DeliveredDollsFieldNumber = 2;

		// Token: 0x0400376F RID: 14191
		private static readonly FieldCodec<int> _repeated_deliveredDolls_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04003770 RID: 14192
		private readonly RepeatedField<int> deliveredDolls_ = new RepeatedField<int>();
	}
}
