using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D37 RID: 3383
	[NetMessage(EMessageId.PhotoMemoryRewardRequest)]
	public sealed class PhotoMemoryRewardRequest : IMessage<PhotoMemoryRewardRequest>, IMessage, IEquatable<PhotoMemoryRewardRequest>, IDeepCloneable<PhotoMemoryRewardRequest>, IBufferMessage
	{
		// Token: 0x0601242C RID: 74796 RVA: 0x002AA739 File Offset: 0x002A8939
		[NullableContext(1)]
		public static PhotoMemoryRewardRequest Create()
		{
			return new PhotoMemoryRewardRequest();
		}

		// Token: 0x17003C82 RID: 15490
		// (get) Token: 0x0601242D RID: 74797 RVA: 0x002AA740 File Offset: 0x002A8940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x0601242E RID: 74798 RVA: 0x002AA743 File Offset: 0x002A8943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601242F RID: 74799 RVA: 0x002AA74A File Offset: 0x002A894A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest()
		{
		}

		// Token: 0x06012430 RID: 74800 RVA: 0x002AA75D File Offset: 0x002A895D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest(PhotoMemoryRewardRequest other) : this()
		{
			this.collectIds_ = other.collectIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012431 RID: 74801 RVA: 0x002AA787 File Offset: 0x002A8987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryRewardRequest Clone()
		{
			return new PhotoMemoryRewardRequest(this);
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x06012432 RID: 74802 RVA: 0x002AA78F File Offset: 0x002A898F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CollectIds
		{
			get
			{
				return this.collectIds_;
			}
		}

		// Token: 0x06012433 RID: 74803 RVA: 0x002AA797 File Offset: 0x002A8997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryRewardRequest);
		}

		// Token: 0x06012434 RID: 74804 RVA: 0x002AA7A5 File Offset: 0x002A89A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryRewardRequest other)
		{
			return other != null && (other == this || (this.collectIds_.Equals(other.collectIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012435 RID: 74805 RVA: 0x002AA7D8 File Offset: 0x002A89D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.collectIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012436 RID: 74806 RVA: 0x002AA80C File Offset: 0x002A8A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012437 RID: 74807 RVA: 0x002AA819 File Offset: 0x002A8A19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012438 RID: 74808 RVA: 0x002AA822 File Offset: 0x002A8A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.collectIds_.WriteTo(ref output, PhotoMemoryRewardRequest._repeated_collectIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012439 RID: 74809 RVA: 0x002AA84C File Offset: 0x002A8A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.collectIds_.CalculateSize(PhotoMemoryRewardRequest._repeated_collectIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601243A RID: 74810 RVA: 0x002AA885 File Offset: 0x002A8A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.collectIds_.Add(other.collectIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601243B RID: 74811 RVA: 0x002AA8B3 File Offset: 0x002A8AB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601243C RID: 74812 RVA: 0x002AA8BC File Offset: 0x002A8ABC
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.collectIds_.AddEntriesFrom(ref input, PhotoMemoryRewardRequest._repeated_collectIds_codec);
				}
			}
		}

		// Token: 0x040071EC RID: 29164
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071ED RID: 29165
		public const int CollectIdsFieldNumber = 6;

		// Token: 0x040071EE RID: 29166
		private static readonly FieldCodec<int> _repeated_collectIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x040071EF RID: 29167
		private readonly RepeatedField<int> collectIds_ = new RepeatedField<int>();
	}
}
