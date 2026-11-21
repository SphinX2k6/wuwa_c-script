using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001222 RID: 4642
	[NetMessage(EMessageId.SheriffZoneInfoRequest)]
	public sealed class SheriffZoneInfoRequest : IMessage<SheriffZoneInfoRequest>, IMessage, IEquatable<SheriffZoneInfoRequest>, IDeepCloneable<SheriffZoneInfoRequest>, IBufferMessage
	{
		// Token: 0x06018CA6 RID: 101542 RVA: 0x0039D0FC File Offset: 0x0039B2FC
		[NullableContext(1)]
		public static SheriffZoneInfoRequest Create()
		{
			return new SheriffZoneInfoRequest();
		}

		// Token: 0x170053B8 RID: 21432
		// (get) Token: 0x06018CA7 RID: 101543 RVA: 0x0039D103 File Offset: 0x0039B303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053B9 RID: 21433
		// (get) Token: 0x06018CA8 RID: 101544 RVA: 0x0039D106 File Offset: 0x0039B306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfoRequest.Descriptor;
			}
		}

		// Token: 0x06018CA9 RID: 101545 RVA: 0x0039D10D File Offset: 0x0039B30D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest()
		{
		}

		// Token: 0x06018CAA RID: 101546 RVA: 0x0039D120 File Offset: 0x0039B320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest(SheriffZoneInfoRequest other) : this()
		{
			this.zoneIds_ = other.zoneIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CAB RID: 101547 RVA: 0x0039D14A File Offset: 0x0039B34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest Clone()
		{
			return new SheriffZoneInfoRequest(this);
		}

		// Token: 0x170053BA RID: 21434
		// (get) Token: 0x06018CAC RID: 101548 RVA: 0x0039D152 File Offset: 0x0039B352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ZoneIds
		{
			get
			{
				return this.zoneIds_;
			}
		}

		// Token: 0x06018CAD RID: 101549 RVA: 0x0039D15A File Offset: 0x0039B35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfoRequest);
		}

		// Token: 0x06018CAE RID: 101550 RVA: 0x0039D168 File Offset: 0x0039B368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfoRequest other)
		{
			return other != null && (other == this || (this.zoneIds_.Equals(other.zoneIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CAF RID: 101551 RVA: 0x0039D19C File Offset: 0x0039B39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.zoneIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CB0 RID: 101552 RVA: 0x0039D1D0 File Offset: 0x0039B3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CB1 RID: 101553 RVA: 0x0039D1DD File Offset: 0x0039B3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CB2 RID: 101554 RVA: 0x0039D1E6 File Offset: 0x0039B3E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.zoneIds_.WriteTo(ref output, SheriffZoneInfoRequest._repeated_zoneIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CB3 RID: 101555 RVA: 0x0039D210 File Offset: 0x0039B410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.zoneIds_.CalculateSize(SheriffZoneInfoRequest._repeated_zoneIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CB4 RID: 101556 RVA: 0x0039D249 File Offset: 0x0039B449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffZoneInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.zoneIds_.Add(other.zoneIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CB5 RID: 101557 RVA: 0x0039D277 File Offset: 0x0039B477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CB6 RID: 101558 RVA: 0x0039D280 File Offset: 0x0039B480
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
					this.zoneIds_.AddEntriesFrom(ref input, SheriffZoneInfoRequest._repeated_zoneIds_codec);
				}
			}
		}

		// Token: 0x0400931B RID: 37659
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400931C RID: 37660
		public const int ZoneIdsFieldNumber = 9;

		// Token: 0x0400931D RID: 37661
		private static readonly FieldCodec<int> _repeated_zoneIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400931E RID: 37662
		private readonly RepeatedField<int> zoneIds_ = new RepeatedField<int>();
	}
}
