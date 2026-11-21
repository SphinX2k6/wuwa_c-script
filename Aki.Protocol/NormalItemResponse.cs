using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4E RID: 2894
	[NetMessage(EMessageId.NormalItemResponse)]
	public sealed class NormalItemResponse : IMessage<NormalItemResponse>, IMessage, IEquatable<NormalItemResponse>, IDeepCloneable<NormalItemResponse>, IBufferMessage
	{
		// Token: 0x0600FB2A RID: 64298 RVA: 0x00249B6E File Offset: 0x00247D6E
		[NullableContext(1)]
		public static NormalItemResponse Create()
		{
			return new NormalItemResponse();
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600FB2B RID: 64299 RVA: 0x00249B75 File Offset: 0x00247D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600FB2C RID: 64300 RVA: 0x00249B78 File Offset: 0x00247D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemResponse.Descriptor;
			}
		}

		// Token: 0x0600FB2D RID: 64301 RVA: 0x00249B7F File Offset: 0x00247D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse()
		{
		}

		// Token: 0x0600FB2E RID: 64302 RVA: 0x00249B92 File Offset: 0x00247D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse(NormalItemResponse other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB2F RID: 64303 RVA: 0x00249BBC File Offset: 0x00247DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemResponse Clone()
		{
			return new NormalItemResponse(this);
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600FB30 RID: 64304 RVA: 0x00249BC4 File Offset: 0x00247DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x0600FB31 RID: 64305 RVA: 0x00249BCC File Offset: 0x00247DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemResponse);
		}

		// Token: 0x0600FB32 RID: 64306 RVA: 0x00249BDA File Offset: 0x00247DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemResponse other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB33 RID: 64307 RVA: 0x00249C10 File Offset: 0x00247E10
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

		// Token: 0x0600FB34 RID: 64308 RVA: 0x00249C44 File Offset: 0x00247E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB35 RID: 64309 RVA: 0x00249C51 File Offset: 0x00247E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB36 RID: 64310 RVA: 0x00249C5A File Offset: 0x00247E5A
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

		// Token: 0x0600FB37 RID: 64311 RVA: 0x00249C84 File Offset: 0x00247E84
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

		// Token: 0x0600FB38 RID: 64312 RVA: 0x00249CBD File Offset: 0x00247EBD
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

		// Token: 0x0600FB39 RID: 64313 RVA: 0x00249CEB File Offset: 0x00247EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB3A RID: 64314 RVA: 0x00249CF4 File Offset: 0x00247EF4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.normalItemList_.AddEntriesFrom(ref input, NormalItemResponse._repeated_normalItemList_codec);
				}
			}
		}

		// Token: 0x040064C2 RID: 25794
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064C3 RID: 25795
		public const int NormalItemListFieldNumber = 8;

		// Token: 0x040064C4 RID: 25796
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(66U, NormalItem.Parser);

		// Token: 0x040064C5 RID: 25797
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();
	}
}
