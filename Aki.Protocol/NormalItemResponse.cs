using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5F RID: 2911
	[NetMessage(EMessageId.NormalItemResponse)]
	public sealed class NormalItemResponse : IMessage<NormalItemResponse>, IMessage, IEquatable<NormalItemResponse>, IDeepCloneable<NormalItemResponse>, IBufferMessage
	{
		// Token: 0x0600FC44 RID: 64580 RVA: 0x0024BD82 File Offset: 0x00249F82
		[NullableContext(1)]
		public static NormalItemResponse Create()
		{
			return new NormalItemResponse();
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600FC45 RID: 64581 RVA: 0x0024BD89 File Offset: 0x00249F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600FC46 RID: 64582 RVA: 0x0024BD8C File Offset: 0x00249F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemResponse.Descriptor;
			}
		}

		// Token: 0x0600FC47 RID: 64583 RVA: 0x0024BD93 File Offset: 0x00249F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse()
		{
		}

		// Token: 0x0600FC48 RID: 64584 RVA: 0x0024BDA6 File Offset: 0x00249FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse(NormalItemResponse other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC49 RID: 64585 RVA: 0x0024BDD0 File Offset: 0x00249FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse Clone()
		{
			return new NormalItemResponse(this);
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600FC4A RID: 64586 RVA: 0x0024BDD8 File Offset: 0x00249FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x0600FC4B RID: 64587 RVA: 0x0024BDE0 File Offset: 0x00249FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemResponse);
		}

		// Token: 0x0600FC4C RID: 64588 RVA: 0x0024BDEE File Offset: 0x00249FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemResponse other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC4D RID: 64589 RVA: 0x0024BE24 File Offset: 0x0024A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC4E RID: 64590 RVA: 0x0024BE58 File Offset: 0x0024A058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC4F RID: 64591 RVA: 0x0024BE65 File Offset: 0x0024A065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC50 RID: 64592 RVA: 0x0024BE6E File Offset: 0x0024A06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemList_.WriteTo(ref output, NormalItemResponse._repeated_normalItemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC51 RID: 64593 RVA: 0x0024BE98 File Offset: 0x0024A098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemList_.CalculateSize(NormalItemResponse._repeated_normalItemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC52 RID: 64594 RVA: 0x0024BED1 File Offset: 0x0024A0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemList_.Add(other.normalItemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC53 RID: 64595 RVA: 0x0024BEFF File Offset: 0x0024A0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC54 RID: 64596 RVA: 0x0024BF08 File Offset: 0x0024A108
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.normalItemList_.AddEntriesFrom(ref input, NormalItemResponse._repeated_normalItemList_codec);
				}
			}
		}

		// Token: 0x040064B9 RID: 25785
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064BA RID: 25786
		public const int NormalItemListFieldNumber = 3;

		// Token: 0x040064BB RID: 25787
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(26U, NormalItem.Parser);

		// Token: 0x040064BC RID: 25788
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();
	}
}
