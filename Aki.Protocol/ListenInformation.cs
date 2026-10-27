using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092D RID: 2349
	public sealed class ListenInformation : IMessage<ListenInformation>, IMessage, IEquatable<ListenInformation>, IDeepCloneable<ListenInformation>, IBufferMessage
	{
		// Token: 0x0600CF25 RID: 53029 RVA: 0x001E817D File Offset: 0x001E637D
		[NullableContext(1)]
		public static ListenInformation Create()
		{
			return new ListenInformation();
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600CF26 RID: 53030 RVA: 0x001E8184 File Offset: 0x001E6384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600CF27 RID: 53031 RVA: 0x001E8187 File Offset: 0x001E6387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ListenInformation.Descriptor;
			}
		}

		// Token: 0x0600CF28 RID: 53032 RVA: 0x001E818E File Offset: 0x001E638E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListenInformation()
		{
		}

		// Token: 0x0600CF29 RID: 53033 RVA: 0x001E81A1 File Offset: 0x001E63A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListenInformation(ListenInformation other) : this()
		{
			this.id_ = other.id_.Clone();
			this.range_ = other.range_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x001E81D7 File Offset: 0x001E63D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ListenInformation Clone()
		{
			return new ListenInformation(this);
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600CF2B RID: 53035 RVA: 0x001E81DF File Offset: 0x001E63DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Id
		{
			get
			{
				return this.id_;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600CF2C RID: 53036 RVA: 0x001E81E7 File Offset: 0x001E63E7
		// (set) Token: 0x0600CF2D RID: 53037 RVA: 0x001E81EF File Offset: 0x001E63EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float Range
		{
			get
			{
				return this.range_;
			}
			set
			{
				this.range_ = value;
			}
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x001E81F8 File Offset: 0x001E63F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ListenInformation);
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x001E8208 File Offset: 0x001E6408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ListenInformation other)
		{
			return other != null && (other == this || (this.id_.Equals(other.id_) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.Range, other.Range) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF30 RID: 53040 RVA: 0x001E8260 File Offset: 0x001E6460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.id_.GetHashCode();
			if (this.Range != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.Range);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF31 RID: 53041 RVA: 0x001E82B4 File Offset: 0x001E64B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF32 RID: 53042 RVA: 0x001E82C1 File Offset: 0x001E64C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF33 RID: 53043 RVA: 0x001E82CC File Offset: 0x001E64CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.id_.WriteTo(ref output, ListenInformation._repeated_id_codec);
			if (this.Range != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.Range);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF34 RID: 53044 RVA: 0x001E8320 File Offset: 0x001E6520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.id_.CalculateSize(ListenInformation._repeated_id_codec);
			if (this.Range != 0f)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF35 RID: 53045 RVA: 0x001E836C File Offset: 0x001E656C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ListenInformation other)
		{
			if (other == null)
			{
				return;
			}
			this.id_.Add(other.id_);
			if (other.Range != 0f)
			{
				this.Range = other.Range;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF36 RID: 53046 RVA: 0x001E83BE File Offset: 0x001E65BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF37 RID: 53047 RVA: 0x001E83C8 File Offset: 0x001E65C8
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
					if (num != 21U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Range = input.ReadFloat();
					}
				}
				else
				{
					this.id_.AddEntriesFrom(ref input, ListenInformation._repeated_id_codec);
				}
			}
		}

		// Token: 0x04005772 RID: 22386
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005773 RID: 22387
		public const int IdFieldNumber = 1;

		// Token: 0x04005774 RID: 22388
		private static readonly FieldCodec<int> _repeated_id_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005775 RID: 22389
		private readonly RepeatedField<int> id_ = new RepeatedField<int>();

		// Token: 0x04005776 RID: 22390
		public const int RangeFieldNumber = 2;

		// Token: 0x04005777 RID: 22391
		private float range_;
	}
}
