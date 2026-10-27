using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB2 RID: 3762
	[NetMessage(EMessageId.RecallMapMarkInfoNotify)]
	public sealed class RecallMapMarkInfoNotify : IMessage<RecallMapMarkInfoNotify>, IMessage, IEquatable<RecallMapMarkInfoNotify>, IDeepCloneable<RecallMapMarkInfoNotify>, IBufferMessage
	{
		// Token: 0x060142FD RID: 82685 RVA: 0x002EFE21 File Offset: 0x002EE021
		[NullableContext(1)]
		public static RecallMapMarkInfoNotify Create()
		{
			return new RecallMapMarkInfoNotify();
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x060142FE RID: 82686 RVA: 0x002EFE28 File Offset: 0x002EE028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x060142FF RID: 82687 RVA: 0x002EFE2B File Offset: 0x002EE02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallMapMarkInfoNotify.Descriptor;
			}
		}

		// Token: 0x06014300 RID: 82688 RVA: 0x002EFE32 File Offset: 0x002EE032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify()
		{
		}

		// Token: 0x06014301 RID: 82689 RVA: 0x002EFE45 File Offset: 0x002EE045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify(RecallMapMarkInfoNotify other) : this()
		{
			this.mapMarkShowInfos_ = other.mapMarkShowInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014302 RID: 82690 RVA: 0x002EFE6F File Offset: 0x002EE06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallMapMarkInfoNotify Clone()
		{
			return new RecallMapMarkInfoNotify(this);
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x06014303 RID: 82691 RVA: 0x002EFE77 File Offset: 0x002EE077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MapMarkShowInfo> MapMarkShowInfos
		{
			get
			{
				return this.mapMarkShowInfos_;
			}
		}

		// Token: 0x06014304 RID: 82692 RVA: 0x002EFE7F File Offset: 0x002EE07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallMapMarkInfoNotify);
		}

		// Token: 0x06014305 RID: 82693 RVA: 0x002EFE8D File Offset: 0x002EE08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallMapMarkInfoNotify other)
		{
			return other != null && (other == this || (this.mapMarkShowInfos_.Equals(other.mapMarkShowInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014306 RID: 82694 RVA: 0x002EFEC0 File Offset: 0x002EE0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mapMarkShowInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014307 RID: 82695 RVA: 0x002EFEF4 File Offset: 0x002EE0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014308 RID: 82696 RVA: 0x002EFF01 File Offset: 0x002EE101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014309 RID: 82697 RVA: 0x002EFF0A File Offset: 0x002EE10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mapMarkShowInfos_.WriteTo(ref output, RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601430A RID: 82698 RVA: 0x002EFF34 File Offset: 0x002EE134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mapMarkShowInfos_.CalculateSize(RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601430B RID: 82699 RVA: 0x002EFF6D File Offset: 0x002EE16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallMapMarkInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.mapMarkShowInfos_.Add(other.mapMarkShowInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601430C RID: 82700 RVA: 0x002EFF9B File Offset: 0x002EE19B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601430D RID: 82701 RVA: 0x002EFFA4 File Offset: 0x002EE1A4
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mapMarkShowInfos_.AddEntriesFrom(ref input, RecallMapMarkInfoNotify._repeated_mapMarkShowInfos_codec);
				}
			}
		}

		// Token: 0x04007AEA RID: 31466
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007AEB RID: 31467
		public const int MapMarkShowInfosFieldNumber = 15;

		// Token: 0x04007AEC RID: 31468
		private static readonly FieldCodec<MapMarkShowInfo> _repeated_mapMarkShowInfos_codec = FieldCodec.ForMessage<MapMarkShowInfo>(122U, MapMarkShowInfo.Parser);

		// Token: 0x04007AED RID: 31469
		private readonly RepeatedField<MapMarkShowInfo> mapMarkShowInfos_ = new RepeatedField<MapMarkShowInfo>();
	}
}
