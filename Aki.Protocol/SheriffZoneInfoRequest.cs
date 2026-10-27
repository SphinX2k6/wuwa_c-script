using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E7 RID: 4583
	[NetMessage(EMessageId.SheriffZoneInfoRequest)]
	public sealed class SheriffZoneInfoRequest : IMessage<SheriffZoneInfoRequest>, IMessage, IEquatable<SheriffZoneInfoRequest>, IDeepCloneable<SheriffZoneInfoRequest>, IBufferMessage
	{
		// Token: 0x060186E2 RID: 100066 RVA: 0x0038D590 File Offset: 0x0038B790
		[NullableContext(1)]
		public static SheriffZoneInfoRequest Create()
		{
			return new SheriffZoneInfoRequest();
		}

		// Token: 0x17005240 RID: 21056
		// (get) Token: 0x060186E3 RID: 100067 RVA: 0x0038D597 File Offset: 0x0038B797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005241 RID: 21057
		// (get) Token: 0x060186E4 RID: 100068 RVA: 0x0038D59A File Offset: 0x0038B79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfoRequest.Descriptor;
			}
		}

		// Token: 0x060186E5 RID: 100069 RVA: 0x0038D5A1 File Offset: 0x0038B7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest()
		{
		}

		// Token: 0x060186E6 RID: 100070 RVA: 0x0038D5B4 File Offset: 0x0038B7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest(SheriffZoneInfoRequest other) : this()
		{
			this.zoneIds_ = other.zoneIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060186E7 RID: 100071 RVA: 0x0038D5DE File Offset: 0x0038B7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoRequest Clone()
		{
			return new SheriffZoneInfoRequest(this);
		}

		// Token: 0x17005242 RID: 21058
		// (get) Token: 0x060186E8 RID: 100072 RVA: 0x0038D5E6 File Offset: 0x0038B7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ZoneIds
		{
			get
			{
				return this.zoneIds_;
			}
		}

		// Token: 0x060186E9 RID: 100073 RVA: 0x0038D5EE File Offset: 0x0038B7EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfoRequest);
		}

		// Token: 0x060186EA RID: 100074 RVA: 0x0038D5FC File Offset: 0x0038B7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfoRequest other)
		{
			return other != null && (other == this || (this.zoneIds_.Equals(other.zoneIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060186EB RID: 100075 RVA: 0x0038D630 File Offset: 0x0038B830
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

		// Token: 0x060186EC RID: 100076 RVA: 0x0038D664 File Offset: 0x0038B864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060186ED RID: 100077 RVA: 0x0038D671 File Offset: 0x0038B871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060186EE RID: 100078 RVA: 0x0038D67A File Offset: 0x0038B87A
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

		// Token: 0x060186EF RID: 100079 RVA: 0x0038D6A4 File Offset: 0x0038B8A4
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

		// Token: 0x060186F0 RID: 100080 RVA: 0x0038D6DD File Offset: 0x0038B8DD
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

		// Token: 0x060186F1 RID: 100081 RVA: 0x0038D70B File Offset: 0x0038B90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060186F2 RID: 100082 RVA: 0x0038D714 File Offset: 0x0038B914
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.zoneIds_.AddEntriesFrom(ref input, SheriffZoneInfoRequest._repeated_zoneIds_codec);
				}
			}
		}

		// Token: 0x04009071 RID: 36977
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009072 RID: 36978
		public const int ZoneIdsFieldNumber = 13;

		// Token: 0x04009073 RID: 36979
		private static readonly FieldCodec<int> _repeated_zoneIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04009074 RID: 36980
		private readonly RepeatedField<int> zoneIds_ = new RepeatedField<int>();
	}
}
