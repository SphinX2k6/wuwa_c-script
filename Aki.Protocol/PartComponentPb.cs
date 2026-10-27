using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC4 RID: 3012
	public sealed class PartComponentPb : IMessage<PartComponentPb>, IMessage, IEquatable<PartComponentPb>, IDeepCloneable<PartComponentPb>, IBufferMessage
	{
		// Token: 0x06010519 RID: 66841 RVA: 0x0026172E File Offset: 0x0025F92E
		[NullableContext(1)]
		public static PartComponentPb Create()
		{
			return new PartComponentPb();
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0601051A RID: 66842 RVA: 0x00261735 File Offset: 0x0025F935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0601051B RID: 66843 RVA: 0x00261738 File Offset: 0x0025F938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentPb.Descriptor;
			}
		}

		// Token: 0x0601051C RID: 66844 RVA: 0x0026173F File Offset: 0x0025F93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb()
		{
		}

		// Token: 0x0601051D RID: 66845 RVA: 0x00261752 File Offset: 0x0025F952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb(PartComponentPb other) : this()
		{
			this.partLifeInfos_ = other.partLifeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601051E RID: 66846 RVA: 0x0026177C File Offset: 0x0025F97C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb Clone()
		{
			return new PartComponentPb(this);
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0601051F RID: 66847 RVA: 0x00261784 File Offset: 0x0025F984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartLifeInfos
		{
			get
			{
				return this.partLifeInfos_;
			}
		}

		// Token: 0x06010520 RID: 66848 RVA: 0x0026178C File Offset: 0x0025F98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentPb);
		}

		// Token: 0x06010521 RID: 66849 RVA: 0x0026179A File Offset: 0x0025F99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentPb other)
		{
			return other != null && (other == this || (this.partLifeInfos_.Equals(other.partLifeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010522 RID: 66850 RVA: 0x002617D0 File Offset: 0x0025F9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.partLifeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010523 RID: 66851 RVA: 0x00261804 File Offset: 0x0025FA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010524 RID: 66852 RVA: 0x00261811 File Offset: 0x0025FA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010525 RID: 66853 RVA: 0x0026181A File Offset: 0x0025FA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.partLifeInfos_.WriteTo(ref output, PartComponentPb._repeated_partLifeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010526 RID: 66854 RVA: 0x00261844 File Offset: 0x0025FA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.partLifeInfos_.CalculateSize(PartComponentPb._repeated_partLifeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010527 RID: 66855 RVA: 0x0026187D File Offset: 0x0025FA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.partLifeInfos_.Add(other.partLifeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010528 RID: 66856 RVA: 0x002618AB File Offset: 0x0025FAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010529 RID: 66857 RVA: 0x002618B4 File Offset: 0x0025FAB4
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
					this.partLifeInfos_.AddEntriesFrom(ref input, PartComponentPb._repeated_partLifeInfos_codec);
				}
			}
		}

		// Token: 0x040067B1 RID: 26545
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067B2 RID: 26546
		public const int PartLifeInfosFieldNumber = 1;

		// Token: 0x040067B3 RID: 26547
		private static readonly FieldCodec<PartInformation> _repeated_partLifeInfos_codec = FieldCodec.ForMessage<PartInformation>(10U, PartInformation.Parser);

		// Token: 0x040067B4 RID: 26548
		private readonly RepeatedField<PartInformation> partLifeInfos_ = new RepeatedField<PartInformation>();
	}
}
