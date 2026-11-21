using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001122 RID: 4386
	[NetMessage(EMessageId.RollBlockSyncInfoNotify)]
	public sealed class RollBlockSyncInfoNotify : IMessage<RollBlockSyncInfoNotify>, IMessage, IEquatable<RollBlockSyncInfoNotify>, IDeepCloneable<RollBlockSyncInfoNotify>, IBufferMessage
	{
		// Token: 0x060176F2 RID: 95986 RVA: 0x00368A2B File Offset: 0x00366C2B
		[NullableContext(1)]
		public static RollBlockSyncInfoNotify Create()
		{
			return new RollBlockSyncInfoNotify();
		}

		// Token: 0x17004EBB RID: 20155
		// (get) Token: 0x060176F3 RID: 95987 RVA: 0x00368A32 File Offset: 0x00366C32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EBC RID: 20156
		// (get) Token: 0x060176F4 RID: 95988 RVA: 0x00368A35 File Offset: 0x00366C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSyncInfoNotify.Descriptor;
			}
		}

		// Token: 0x060176F5 RID: 95989 RVA: 0x00368A3C File Offset: 0x00366C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify()
		{
		}

		// Token: 0x060176F6 RID: 95990 RVA: 0x00368A4F File Offset: 0x00366C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify(RollBlockSyncInfoNotify other) : this()
		{
			this.fullInfos_ = other.fullInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176F7 RID: 95991 RVA: 0x00368A79 File Offset: 0x00366C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSyncInfoNotify Clone()
		{
			return new RollBlockSyncInfoNotify(this);
		}

		// Token: 0x17004EBD RID: 20157
		// (get) Token: 0x060176F8 RID: 95992 RVA: 0x00368A81 File Offset: 0x00366C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RollBlockGamePlayPbInfo> FullInfos
		{
			get
			{
				return this.fullInfos_;
			}
		}

		// Token: 0x060176F9 RID: 95993 RVA: 0x00368A89 File Offset: 0x00366C89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSyncInfoNotify);
		}

		// Token: 0x060176FA RID: 95994 RVA: 0x00368A97 File Offset: 0x00366C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSyncInfoNotify other)
		{
			return other != null && (other == this || (this.fullInfos_.Equals(other.fullInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176FB RID: 95995 RVA: 0x00368ACC File Offset: 0x00366CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.fullInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176FC RID: 95996 RVA: 0x00368B00 File Offset: 0x00366D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176FD RID: 95997 RVA: 0x00368B0D File Offset: 0x00366D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176FE RID: 95998 RVA: 0x00368B16 File Offset: 0x00366D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fullInfos_.WriteTo(ref output, RollBlockSyncInfoNotify._repeated_fullInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176FF RID: 95999 RVA: 0x00368B40 File Offset: 0x00366D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.fullInfos_.CalculateSize(RollBlockSyncInfoNotify._repeated_fullInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017700 RID: 96000 RVA: 0x00368B79 File Offset: 0x00366D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSyncInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.fullInfos_.Add(other.fullInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017701 RID: 96001 RVA: 0x00368BA7 File Offset: 0x00366DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017702 RID: 96002 RVA: 0x00368BB0 File Offset: 0x00366DB0
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.fullInfos_.AddEntriesFrom(ref input, RollBlockSyncInfoNotify._repeated_fullInfos_codec);
				}
			}
		}

		// Token: 0x04008BDD RID: 35805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BDE RID: 35806
		public const int FullInfosFieldNumber = 9;

		// Token: 0x04008BDF RID: 35807
		private static readonly FieldCodec<RollBlockGamePlayPbInfo> _repeated_fullInfos_codec = FieldCodec.ForMessage<RollBlockGamePlayPbInfo>(74U, RollBlockGamePlayPbInfo.Parser);

		// Token: 0x04008BE0 RID: 35808
		private readonly RepeatedField<RollBlockGamePlayPbInfo> fullInfos_ = new RepeatedField<RollBlockGamePlayPbInfo>();
	}
}
