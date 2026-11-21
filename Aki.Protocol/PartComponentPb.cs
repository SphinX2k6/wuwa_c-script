using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB4 RID: 2996
	public sealed class PartComponentPb : IMessage<PartComponentPb>, IMessage, IEquatable<PartComponentPb>, IDeepCloneable<PartComponentPb>, IBufferMessage
	{
		// Token: 0x06010415 RID: 66581 RVA: 0x0025F876 File Offset: 0x0025DA76
		[NullableContext(1)]
		public static PartComponentPb Create()
		{
			return new PartComponentPb();
		}

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x06010416 RID: 66582 RVA: 0x0025F87D File Offset: 0x0025DA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x06010417 RID: 66583 RVA: 0x0025F880 File Offset: 0x0025DA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartComponentPb.Descriptor;
			}
		}

		// Token: 0x06010418 RID: 66584 RVA: 0x0025F887 File Offset: 0x0025DA87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb()
		{
		}

		// Token: 0x06010419 RID: 66585 RVA: 0x0025F89A File Offset: 0x0025DA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb(PartComponentPb other) : this()
		{
			this.partLifeInfos_ = other.partLifeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601041A RID: 66586 RVA: 0x0025F8C4 File Offset: 0x0025DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartComponentPb Clone()
		{
			return new PartComponentPb(this);
		}

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0601041B RID: 66587 RVA: 0x0025F8CC File Offset: 0x0025DACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PartInformation> PartLifeInfos
		{
			get
			{
				return this.partLifeInfos_;
			}
		}

		// Token: 0x0601041C RID: 66588 RVA: 0x0025F8D4 File Offset: 0x0025DAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartComponentPb);
		}

		// Token: 0x0601041D RID: 66589 RVA: 0x0025F8E2 File Offset: 0x0025DAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartComponentPb other)
		{
			return other != null && (other == this || (this.partLifeInfos_.Equals(other.partLifeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601041E RID: 66590 RVA: 0x0025F918 File Offset: 0x0025DB18
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

		// Token: 0x0601041F RID: 66591 RVA: 0x0025F94C File Offset: 0x0025DB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010420 RID: 66592 RVA: 0x0025F959 File Offset: 0x0025DB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010421 RID: 66593 RVA: 0x0025F962 File Offset: 0x0025DB62
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

		// Token: 0x06010422 RID: 66594 RVA: 0x0025F98C File Offset: 0x0025DB8C
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

		// Token: 0x06010423 RID: 66595 RVA: 0x0025F9C5 File Offset: 0x0025DBC5
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

		// Token: 0x06010424 RID: 66596 RVA: 0x0025F9F3 File Offset: 0x0025DBF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010425 RID: 66597 RVA: 0x0025F9FC File Offset: 0x0025DBFC
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

		// Token: 0x040067C1 RID: 26561
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067C2 RID: 26562
		public const int PartLifeInfosFieldNumber = 1;

		// Token: 0x040067C3 RID: 26563
		private static readonly FieldCodec<PartInformation> _repeated_partLifeInfos_codec = FieldCodec.ForMessage<PartInformation>(10U, PartInformation.Parser);

		// Token: 0x040067C4 RID: 26564
		private readonly RepeatedField<PartInformation> partLifeInfos_ = new RepeatedField<PartInformation>();
	}
}
