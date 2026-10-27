using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000446 RID: 1094
	[NetMessage(EMessageId.EnergySyncRequest)]
	public sealed class EnergySyncRequest : IMessage<EnergySyncRequest>, IMessage, IEquatable<EnergySyncRequest>, IDeepCloneable<EnergySyncRequest>, IBufferMessage
	{
		// Token: 0x060068AD RID: 26797 RVA: 0x000FB736 File Offset: 0x000F9936
		[NullableContext(1)]
		public static EnergySyncRequest Create()
		{
			return new EnergySyncRequest();
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x000FB73D File Offset: 0x000F993D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x000FB740 File Offset: 0x000F9940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergySyncRequest.Descriptor;
			}
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x000FB747 File Offset: 0x000F9947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest()
		{
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x000FB75A File Offset: 0x000F995A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest(EnergySyncRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068B2 RID: 26802 RVA: 0x000FB784 File Offset: 0x000F9984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncRequest Clone()
		{
			return new EnergySyncRequest(this);
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060068B3 RID: 26803 RVA: 0x000FB78C File Offset: 0x000F998C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x060068B4 RID: 26804 RVA: 0x000FB794 File Offset: 0x000F9994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergySyncRequest);
		}

		// Token: 0x060068B5 RID: 26805 RVA: 0x000FB7A2 File Offset: 0x000F99A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergySyncRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068B6 RID: 26806 RVA: 0x000FB7D8 File Offset: 0x000F99D8
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

		// Token: 0x060068B7 RID: 26807 RVA: 0x000FB80C File Offset: 0x000F9A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x000FB819 File Offset: 0x000F9A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x000FB822 File Offset: 0x000F9A22
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

		// Token: 0x060068BA RID: 26810 RVA: 0x000FB84C File Offset: 0x000F9A4C
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

		// Token: 0x060068BB RID: 26811 RVA: 0x000FB885 File Offset: 0x000F9A85
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

		// Token: 0x060068BC RID: 26812 RVA: 0x000FB8B3 File Offset: 0x000F9AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x000FB8BC File Offset: 0x000F9ABC
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, EnergySyncRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x040039C8 RID: 14792
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039C9 RID: 14793
		public const int IdsFieldNumber = 10;

		// Token: 0x040039CA RID: 14794
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040039CB RID: 14795
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
