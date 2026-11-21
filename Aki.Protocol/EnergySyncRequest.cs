using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042F RID: 1071
	[NetMessage(EMessageId.EnergySyncRequest)]
	public sealed class EnergySyncRequest : IMessage<EnergySyncRequest>, IMessage, IEquatable<EnergySyncRequest>, IDeepCloneable<EnergySyncRequest>, IBufferMessage
	{
		// Token: 0x0600671D RID: 26397 RVA: 0x000F85AA File Offset: 0x000F67AA
		[NullableContext(1)]
		public static EnergySyncRequest Create()
		{
			return new EnergySyncRequest();
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x000F85B1 File Offset: 0x000F67B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x0600671F RID: 26399 RVA: 0x000F85B4 File Offset: 0x000F67B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergySyncRequest.Descriptor;
			}
		}

		// Token: 0x06006720 RID: 26400 RVA: 0x000F85BB File Offset: 0x000F67BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest()
		{
		}

		// Token: 0x06006721 RID: 26401 RVA: 0x000F85CE File Offset: 0x000F67CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest(EnergySyncRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006722 RID: 26402 RVA: 0x000F85F8 File Offset: 0x000F67F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest Clone()
		{
			return new EnergySyncRequest(this);
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06006723 RID: 26403 RVA: 0x000F8600 File Offset: 0x000F6800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06006724 RID: 26404 RVA: 0x000F8608 File Offset: 0x000F6808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergySyncRequest);
		}

		// Token: 0x06006725 RID: 26405 RVA: 0x000F8616 File Offset: 0x000F6816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergySyncRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006726 RID: 26406 RVA: 0x000F864C File Offset: 0x000F684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006727 RID: 26407 RVA: 0x000F8680 File Offset: 0x000F6880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006728 RID: 26408 RVA: 0x000F868D File Offset: 0x000F688D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006729 RID: 26409 RVA: 0x000F8696 File Offset: 0x000F6896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, EnergySyncRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600672A RID: 26410 RVA: 0x000F86C0 File Offset: 0x000F68C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(EnergySyncRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600672B RID: 26411 RVA: 0x000F86F9 File Offset: 0x000F68F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnergySyncRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600672C RID: 26412 RVA: 0x000F8727 File Offset: 0x000F6927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600672D RID: 26413 RVA: 0x000F8730 File Offset: 0x000F6930
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
					this.ids_.AddEntriesFrom(ref input, EnergySyncRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040039B5 RID: 14773
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039B6 RID: 14774
		public const int IdsFieldNumber = 9;

		// Token: 0x040039B7 RID: 14775
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040039B8 RID: 14776
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
