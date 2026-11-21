using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D3 RID: 1235
	[NetMessage(EMessageId.ExhibitionItemSaveRequest)]
	public sealed class ExhibitionItemSaveRequest : IMessage<ExhibitionItemSaveRequest>, IMessage, IEquatable<ExhibitionItemSaveRequest>, IDeepCloneable<ExhibitionItemSaveRequest>, IBufferMessage
	{
		// Token: 0x06007585 RID: 30085 RVA: 0x0011FD14 File Offset: 0x0011DF14
		[NullableContext(1)]
		public static ExhibitionItemSaveRequest Create()
		{
			return new ExhibitionItemSaveRequest();
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x0011FD1B File Offset: 0x0011DF1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x0011FD1E File Offset: 0x0011DF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionItemSaveRequest.Descriptor;
			}
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x0011FD25 File Offset: 0x0011DF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest()
		{
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x0011FD38 File Offset: 0x0011DF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest(ExhibitionItemSaveRequest other) : this()
		{
			this.entityItemBundleInfos_ = other.entityItemBundleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x0011FD62 File Offset: 0x0011DF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest Clone()
		{
			return new ExhibitionItemSaveRequest(this);
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x0600758B RID: 30091 RVA: 0x0011FD6A File Offset: 0x0011DF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityItemBundleInfo> EntityItemBundleInfos
		{
			get
			{
				return this.entityItemBundleInfos_;
			}
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x0011FD72 File Offset: 0x0011DF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionItemSaveRequest);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x0011FD80 File Offset: 0x0011DF80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionItemSaveRequest other)
		{
			return other != null && (other == this || (this.entityItemBundleInfos_.Equals(other.entityItemBundleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x0011FDB4 File Offset: 0x0011DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityItemBundleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x0011FDE8 File Offset: 0x0011DFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x0011FDF5 File Offset: 0x0011DFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x0011FDFE File Offset: 0x0011DFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityItemBundleInfos_.WriteTo(ref output, ExhibitionItemSaveRequest._repeated_entityItemBundleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x0011FE28 File Offset: 0x0011E028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityItemBundleInfos_.CalculateSize(ExhibitionItemSaveRequest._repeated_entityItemBundleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x0011FE61 File Offset: 0x0011E061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExhibitionItemSaveRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.entityItemBundleInfos_.Add(other.entityItemBundleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007594 RID: 30100 RVA: 0x0011FE8F File Offset: 0x0011E08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007595 RID: 30101 RVA: 0x0011FE98 File Offset: 0x0011E098
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityItemBundleInfos_.AddEntriesFrom(ref input, ExhibitionItemSaveRequest._repeated_entityItemBundleInfos_codec);
				}
			}
		}

		// Token: 0x04003E0C RID: 15884
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E0D RID: 15885
		public const int EntityItemBundleInfosFieldNumber = 11;

		// Token: 0x04003E0E RID: 15886
		private static readonly FieldCodec<EntityItemBundleInfo> _repeated_entityItemBundleInfos_codec = FieldCodec.ForMessage<EntityItemBundleInfo>(90U, EntityItemBundleInfo.Parser);

		// Token: 0x04003E0F RID: 15887
		private readonly RepeatedField<EntityItemBundleInfo> entityItemBundleInfos_ = new RepeatedField<EntityItemBundleInfo>();
	}
}
