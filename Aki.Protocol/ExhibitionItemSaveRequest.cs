using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E9 RID: 1257
	[NetMessage(EMessageId.ExhibitionItemSaveRequest)]
	public sealed class ExhibitionItemSaveRequest : IMessage<ExhibitionItemSaveRequest>, IMessage, IEquatable<ExhibitionItemSaveRequest>, IDeepCloneable<ExhibitionItemSaveRequest>, IBufferMessage
	{
		// Token: 0x06007701 RID: 30465 RVA: 0x00122BA0 File Offset: 0x00120DA0
		[NullableContext(1)]
		public static ExhibitionItemSaveRequest Create()
		{
			return new ExhibitionItemSaveRequest();
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06007702 RID: 30466 RVA: 0x00122BA7 File Offset: 0x00120DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06007703 RID: 30467 RVA: 0x00122BAA File Offset: 0x00120DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionItemSaveRequest.Descriptor;
			}
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x00122BB1 File Offset: 0x00120DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest()
		{
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x00122BC4 File Offset: 0x00120DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest(ExhibitionItemSaveRequest other) : this()
		{
			this.entityItemBundleInfos_ = other.entityItemBundleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00122BEE File Offset: 0x00120DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionItemSaveRequest Clone()
		{
			return new ExhibitionItemSaveRequest(this);
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06007707 RID: 30471 RVA: 0x00122BF6 File Offset: 0x00120DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityItemBundleInfo> EntityItemBundleInfos
		{
			get
			{
				return this.entityItemBundleInfos_;
			}
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00122BFE File Offset: 0x00120DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionItemSaveRequest);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00122C0C File Offset: 0x00120E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionItemSaveRequest other)
		{
			return other != null && (other == this || (this.entityItemBundleInfos_.Equals(other.entityItemBundleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00122C40 File Offset: 0x00120E40
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

		// Token: 0x0600770B RID: 30475 RVA: 0x00122C74 File Offset: 0x00120E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00122C81 File Offset: 0x00120E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00122C8A File Offset: 0x00120E8A
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

		// Token: 0x0600770E RID: 30478 RVA: 0x00122CB4 File Offset: 0x00120EB4
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

		// Token: 0x0600770F RID: 30479 RVA: 0x00122CED File Offset: 0x00120EED
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

		// Token: 0x06007710 RID: 30480 RVA: 0x00122D1B File Offset: 0x00120F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00122D24 File Offset: 0x00120F24
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityItemBundleInfos_.AddEntriesFrom(ref input, ExhibitionItemSaveRequest._repeated_entityItemBundleInfos_codec);
				}
			}
		}

		// Token: 0x04003E1B RID: 15899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E1C RID: 15900
		public const int EntityItemBundleInfosFieldNumber = 1;

		// Token: 0x04003E1D RID: 15901
		private static readonly FieldCodec<EntityItemBundleInfo> _repeated_entityItemBundleInfos_codec = FieldCodec.ForMessage<EntityItemBundleInfo>(10U, EntityItemBundleInfo.Parser);

		// Token: 0x04003E1E RID: 15902
		private readonly RepeatedField<EntityItemBundleInfo> entityItemBundleInfos_ = new RepeatedField<EntityItemBundleInfo>();
	}
}
