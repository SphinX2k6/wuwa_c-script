using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AC RID: 940
	public sealed class DependenceComponentPb : IMessage<DependenceComponentPb>, IMessage, IEquatable<DependenceComponentPb>, IDeepCloneable<DependenceComponentPb>, IBufferMessage
	{
		// Token: 0x06005C97 RID: 23703 RVA: 0x000E1014 File Offset: 0x000DF214
		[NullableContext(1)]
		public static DependenceComponentPb Create()
		{
			return new DependenceComponentPb();
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06005C98 RID: 23704 RVA: 0x000E101B File Offset: 0x000DF21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x000E101E File Offset: 0x000DF21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DependenceComponentPb.Descriptor;
			}
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x000E1025 File Offset: 0x000DF225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb()
		{
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x000E1038 File Offset: 0x000DF238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb(DependenceComponentPb other) : this()
		{
			this.dependenceEntityIds_ = other.dependenceEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x000E1062 File Offset: 0x000DF262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DependenceComponentPb Clone()
		{
			return new DependenceComponentPb(this);
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06005C9D RID: 23709 RVA: 0x000E106A File Offset: 0x000DF26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> DependenceEntityIds
		{
			get
			{
				return this.dependenceEntityIds_;
			}
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x000E1072 File Offset: 0x000DF272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DependenceComponentPb);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x000E1080 File Offset: 0x000DF280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DependenceComponentPb other)
		{
			return other != null && (other == this || (this.dependenceEntityIds_.Equals(other.dependenceEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x000E10B4 File Offset: 0x000DF2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dependenceEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x000E10E8 File Offset: 0x000DF2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x000E10F5 File Offset: 0x000DF2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x000E10FE File Offset: 0x000DF2FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dependenceEntityIds_.WriteTo(ref output, DependenceComponentPb._repeated_dependenceEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x000E1128 File Offset: 0x000DF328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dependenceEntityIds_.CalculateSize(DependenceComponentPb._repeated_dependenceEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x000E1161 File Offset: 0x000DF361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DependenceComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.dependenceEntityIds_.Add(other.dependenceEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x000E118F File Offset: 0x000DF38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x000E1198 File Offset: 0x000DF398
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
					this.dependenceEntityIds_.AddEntriesFrom(ref input, DependenceComponentPb._repeated_dependenceEntityIds_codec);
				}
			}
		}

		// Token: 0x040036A4 RID: 13988
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A5 RID: 13989
		public const int DependenceEntityIdsFieldNumber = 1;

		// Token: 0x040036A6 RID: 13990
		private static readonly FieldCodec<long> _repeated_dependenceEntityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x040036A7 RID: 13991
		private readonly RepeatedField<long> dependenceEntityIds_ = new RepeatedField<long>();
	}
}
