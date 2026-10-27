using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000361 RID: 865
	[NetMessage(EMessageId.DangoBrawlItemUnlockNotify)]
	public sealed class DangoBrawlItemUnlockNotify : IMessage<DangoBrawlItemUnlockNotify>, IMessage, IEquatable<DangoBrawlItemUnlockNotify>, IDeepCloneable<DangoBrawlItemUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600564C RID: 22092 RVA: 0x000D2E60 File Offset: 0x000D1060
		[NullableContext(1)]
		public static DangoBrawlItemUnlockNotify Create()
		{
			return new DangoBrawlItemUnlockNotify();
		}

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x0600564D RID: 22093 RVA: 0x000D2E67 File Offset: 0x000D1067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x0600564E RID: 22094 RVA: 0x000D2E6A File Offset: 0x000D106A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlItemUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x000D2E71 File Offset: 0x000D1071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify()
		{
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x000D2E84 File Offset: 0x000D1084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify(DangoBrawlItemUnlockNotify other) : this()
		{
			this.itemIds_ = other.itemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x000D2EAE File Offset: 0x000D10AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlItemUnlockNotify Clone()
		{
			return new DangoBrawlItemUnlockNotify(this);
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x000D2EB6 File Offset: 0x000D10B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ItemIds
		{
			get
			{
				return this.itemIds_;
			}
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x000D2EBE File Offset: 0x000D10BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlItemUnlockNotify);
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x000D2ECC File Offset: 0x000D10CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlItemUnlockNotify other)
		{
			return other != null && (other == this || (this.itemIds_.Equals(other.itemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x000D2F00 File Offset: 0x000D1100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x000D2F34 File Offset: 0x000D1134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x000D2F41 File Offset: 0x000D1141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x000D2F4A File Offset: 0x000D114A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemIds_.WriteTo(ref output, DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x000D2F74 File Offset: 0x000D1174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemIds_.CalculateSize(DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x000D2FAD File Offset: 0x000D11AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlItemUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.itemIds_.Add(other.itemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x000D2FDB File Offset: 0x000D11DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x000D2FE4 File Offset: 0x000D11E4
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemIds_.AddEntriesFrom(ref input, DangoBrawlItemUnlockNotify._repeated_itemIds_codec);
				}
			}
		}

		// Token: 0x04003473 RID: 13427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003474 RID: 13428
		public const int ItemIdsFieldNumber = 9;

		// Token: 0x04003475 RID: 13429
		private static readonly FieldCodec<int> _repeated_itemIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04003476 RID: 13430
		private readonly RepeatedField<int> itemIds_ = new RepeatedField<int>();
	}
}
