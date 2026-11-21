using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D0 RID: 976
	[NetMessage(EMessageId.DollDeliveryNotify)]
	public sealed class DollDeliveryNotify : IMessage<DollDeliveryNotify>, IMessage, IEquatable<DollDeliveryNotify>, IDeepCloneable<DollDeliveryNotify>, IBufferMessage
	{
		// Token: 0x06005F72 RID: 24434 RVA: 0x000E73B9 File Offset: 0x000E55B9
		[NullableContext(1)]
		public static DollDeliveryNotify Create()
		{
			return new DollDeliveryNotify();
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x06005F73 RID: 24435 RVA: 0x000E73C0 File Offset: 0x000E55C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06005F74 RID: 24436 RVA: 0x000E73C3 File Offset: 0x000E55C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryNotify.Descriptor;
			}
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x000E73CA File Offset: 0x000E55CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify()
		{
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x000E73E8 File Offset: 0x000E55E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify(DollDeliveryNotify other) : this()
		{
			this.itemIds_ = other.itemIds_.Clone();
			this.dropIds_ = other.dropIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x000E7423 File Offset: 0x000E5623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryNotify Clone()
		{
			return new DollDeliveryNotify(this);
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06005F78 RID: 24440 RVA: 0x000E742B File Offset: 0x000E562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06005F79 RID: 24441 RVA: 0x000E7433 File Offset: 0x000E5633
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DropIds
		{
			get
			{
				return this.dropIds_;
			}
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x000E743B File Offset: 0x000E563B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryNotify);
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x000E744C File Offset: 0x000E564C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryNotify other)
		{
			return other != null && (other == this || (this.itemIds_.Equals(other.itemIds_) && this.dropIds_.Equals(other.dropIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x000E74A0 File Offset: 0x000E56A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemIds_.GetHashCode();
			num ^= this.dropIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x000E74E2 File Offset: 0x000E56E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x000E74EF File Offset: 0x000E56EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x000E74F8 File Offset: 0x000E56F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropIds_.WriteTo(ref output, DollDeliveryNotify._repeated_dropIds_codec);
			this.itemIds_.WriteTo(ref output, DollDeliveryNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x000E7530 File Offset: 0x000E5730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemIds_.CalculateSize(DollDeliveryNotify._repeated_itemIds_codec);
			num += this.dropIds_.CalculateSize(DollDeliveryNotify._repeated_dropIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x000E757C File Offset: 0x000E577C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemIds_.Add(other.itemIds_);
			this.dropIds_.Add(other.dropIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x000E75BB File Offset: 0x000E57BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x000E75C4 File Offset: 0x000E57C4
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.dropIds_.AddEntriesFrom(ref input, DollDeliveryNotify._repeated_dropIds_codec);
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.itemIds_.AddEntriesFrom(ref input, DollDeliveryNotify._repeated_itemIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003771 RID: 14193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003772 RID: 14194
		public const int ItemIdsFieldNumber = 11;

		// Token: 0x04003773 RID: 14195
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04003774 RID: 14196
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();

		// Token: 0x04003775 RID: 14197
		public const int DropIdsFieldNumber = 3;

		// Token: 0x04003776 RID: 14198
		private static readonly FieldCodec<int> _repeated_dropIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04003777 RID: 14199
		private readonly RepeatedField<int> dropIds_ = new RepeatedField<int>();
	}
}
