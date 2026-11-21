using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A2 RID: 4770
	public sealed class SolarSchoolAvgDataPb : IMessage<SolarSchoolAvgDataPb>, IMessage, IEquatable<SolarSchoolAvgDataPb>, IDeepCloneable<SolarSchoolAvgDataPb>, IBufferMessage
	{
		// Token: 0x06019758 RID: 104280 RVA: 0x003B683E File Offset: 0x003B4A3E
		[NullableContext(1)]
		public static SolarSchoolAvgDataPb Create()
		{
			return new SolarSchoolAvgDataPb();
		}

		// Token: 0x17005622 RID: 22050
		// (get) Token: 0x06019759 RID: 104281 RVA: 0x003B6845 File Offset: 0x003B4A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005623 RID: 22051
		// (get) Token: 0x0601975A RID: 104282 RVA: 0x003B6848 File Offset: 0x003B4A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolAvgDataPb.Descriptor;
			}
		}

		// Token: 0x0601975B RID: 104283 RVA: 0x003B684F File Offset: 0x003B4A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAvgDataPb()
		{
		}

		// Token: 0x0601975C RID: 104284 RVA: 0x003B6862 File Offset: 0x003B4A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAvgDataPb(SolarSchoolAvgDataPb other) : this()
		{
			this.avgParamBit_ = other.avgParamBit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601975D RID: 104285 RVA: 0x003B688C File Offset: 0x003B4A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolAvgDataPb Clone()
		{
			return new SolarSchoolAvgDataPb(this);
		}

		// Token: 0x17005624 RID: 22052
		// (get) Token: 0x0601975E RID: 104286 RVA: 0x003B6894 File Offset: 0x003B4A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AvgParamBit
		{
			get
			{
				return this.avgParamBit_;
			}
		}

		// Token: 0x0601975F RID: 104287 RVA: 0x003B689C File Offset: 0x003B4A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolAvgDataPb);
		}

		// Token: 0x06019760 RID: 104288 RVA: 0x003B68AA File Offset: 0x003B4AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolAvgDataPb other)
		{
			return other != null && (other == this || (this.avgParamBit_.Equals(other.avgParamBit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019761 RID: 104289 RVA: 0x003B68E0 File Offset: 0x003B4AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.avgParamBit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019762 RID: 104290 RVA: 0x003B6914 File Offset: 0x003B4B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019763 RID: 104291 RVA: 0x003B6921 File Offset: 0x003B4B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019764 RID: 104292 RVA: 0x003B692A File Offset: 0x003B4B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avgParamBit_.WriteTo(ref output, SolarSchoolAvgDataPb._repeated_avgParamBit_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019765 RID: 104293 RVA: 0x003B6954 File Offset: 0x003B4B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.avgParamBit_.CalculateSize(SolarSchoolAvgDataPb._repeated_avgParamBit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019766 RID: 104294 RVA: 0x003B698D File Offset: 0x003B4B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolAvgDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.avgParamBit_.Add(other.avgParamBit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019767 RID: 104295 RVA: 0x003B69BB File Offset: 0x003B4BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019768 RID: 104296 RVA: 0x003B69C4 File Offset: 0x003B4BC4
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.avgParamBit_.AddEntriesFrom(ref input, SolarSchoolAvgDataPb._repeated_avgParamBit_codec);
				}
			}
		}

		// Token: 0x04009680 RID: 38528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009681 RID: 38529
		public const int AvgParamBitFieldNumber = 1;

		// Token: 0x04009682 RID: 38530
		private static readonly FieldCodec<long> _repeated_avgParamBit_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04009683 RID: 38531
		private readonly RepeatedField<long> avgParamBit_ = new RepeatedField<long>();
	}
}
