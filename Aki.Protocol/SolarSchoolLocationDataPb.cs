using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B2 RID: 4786
	public sealed class SolarSchoolLocationDataPb : IMessage<SolarSchoolLocationDataPb>, IMessage, IEquatable<SolarSchoolLocationDataPb>, IDeepCloneable<SolarSchoolLocationDataPb>, IBufferMessage
	{
		// Token: 0x060198C0 RID: 104640 RVA: 0x003B9FDE File Offset: 0x003B81DE
		[NullableContext(1)]
		public static SolarSchoolLocationDataPb Create()
		{
			return new SolarSchoolLocationDataPb();
		}

		// Token: 0x17005677 RID: 22135
		// (get) Token: 0x060198C1 RID: 104641 RVA: 0x003B9FE5 File Offset: 0x003B81E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005678 RID: 22136
		// (get) Token: 0x060198C2 RID: 104642 RVA: 0x003B9FE8 File Offset: 0x003B81E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolLocationDataPb.Descriptor;
			}
		}

		// Token: 0x060198C3 RID: 104643 RVA: 0x003B9FEF File Offset: 0x003B81EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLocationDataPb()
		{
		}

		// Token: 0x060198C4 RID: 104644 RVA: 0x003BA002 File Offset: 0x003B8202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLocationDataPb(SolarSchoolLocationDataPb other) : this()
		{
			this.viewedBit_ = other.viewedBit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060198C5 RID: 104645 RVA: 0x003BA02C File Offset: 0x003B822C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolLocationDataPb Clone()
		{
			return new SolarSchoolLocationDataPb(this);
		}

		// Token: 0x17005679 RID: 22137
		// (get) Token: 0x060198C6 RID: 104646 RVA: 0x003BA034 File Offset: 0x003B8234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> ViewedBit
		{
			get
			{
				return this.viewedBit_;
			}
		}

		// Token: 0x060198C7 RID: 104647 RVA: 0x003BA03C File Offset: 0x003B823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolLocationDataPb);
		}

		// Token: 0x060198C8 RID: 104648 RVA: 0x003BA04A File Offset: 0x003B824A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolLocationDataPb other)
		{
			return other != null && (other == this || (this.viewedBit_.Equals(other.viewedBit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060198C9 RID: 104649 RVA: 0x003BA080 File Offset: 0x003B8280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.viewedBit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060198CA RID: 104650 RVA: 0x003BA0B4 File Offset: 0x003B82B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060198CB RID: 104651 RVA: 0x003BA0C1 File Offset: 0x003B82C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060198CC RID: 104652 RVA: 0x003BA0CA File Offset: 0x003B82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.viewedBit_.WriteTo(ref output, SolarSchoolLocationDataPb._repeated_viewedBit_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060198CD RID: 104653 RVA: 0x003BA0F4 File Offset: 0x003B82F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.viewedBit_.CalculateSize(SolarSchoolLocationDataPb._repeated_viewedBit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060198CE RID: 104654 RVA: 0x003BA12D File Offset: 0x003B832D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolLocationDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.viewedBit_.Add(other.viewedBit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060198CF RID: 104655 RVA: 0x003BA15B File Offset: 0x003B835B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060198D0 RID: 104656 RVA: 0x003BA164 File Offset: 0x003B8364
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
					this.viewedBit_.AddEntriesFrom(ref input, SolarSchoolLocationDataPb._repeated_viewedBit_codec);
				}
			}
		}

		// Token: 0x040096F3 RID: 38643
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096F4 RID: 38644
		public const int ViewedBitFieldNumber = 1;

		// Token: 0x040096F5 RID: 38645
		private static readonly FieldCodec<long> _repeated_viewedBit_codec = FieldCodec.ForInt64(10U);

		// Token: 0x040096F6 RID: 38646
		private readonly RepeatedField<long> viewedBit_ = new RepeatedField<long>();
	}
}
