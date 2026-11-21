using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A8 RID: 4776
	public sealed class SolarSchoolExamDataPb : IMessage<SolarSchoolExamDataPb>, IMessage, IEquatable<SolarSchoolExamDataPb>, IDeepCloneable<SolarSchoolExamDataPb>, IBufferMessage
	{
		// Token: 0x060197E8 RID: 104424 RVA: 0x003B8251 File Offset: 0x003B6451
		[NullableContext(1)]
		public static SolarSchoolExamDataPb Create()
		{
			return new SolarSchoolExamDataPb();
		}

		// Token: 0x17005646 RID: 22086
		// (get) Token: 0x060197E9 RID: 104425 RVA: 0x003B8258 File Offset: 0x003B6458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005647 RID: 22087
		// (get) Token: 0x060197EA RID: 104426 RVA: 0x003B825B File Offset: 0x003B645B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolExamDataPb.Descriptor;
			}
		}

		// Token: 0x060197EB RID: 104427 RVA: 0x003B8262 File Offset: 0x003B6462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamDataPb()
		{
		}

		// Token: 0x060197EC RID: 104428 RVA: 0x003B8275 File Offset: 0x003B6475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamDataPb(SolarSchoolExamDataPb other) : this()
		{
			this.exam_ = other.exam_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197ED RID: 104429 RVA: 0x003B829F File Offset: 0x003B649F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolExamDataPb Clone()
		{
			return new SolarSchoolExamDataPb(this);
		}

		// Token: 0x17005648 RID: 22088
		// (get) Token: 0x060197EE RID: 104430 RVA: 0x003B82A7 File Offset: 0x003B64A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolExamResult> Exam
		{
			get
			{
				return this.exam_;
			}
		}

		// Token: 0x060197EF RID: 104431 RVA: 0x003B82AF File Offset: 0x003B64AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolExamDataPb);
		}

		// Token: 0x060197F0 RID: 104432 RVA: 0x003B82BD File Offset: 0x003B64BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolExamDataPb other)
		{
			return other != null && (other == this || (this.exam_.Equals(other.exam_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197F1 RID: 104433 RVA: 0x003B82F0 File Offset: 0x003B64F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.exam_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197F2 RID: 104434 RVA: 0x003B8324 File Offset: 0x003B6524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197F3 RID: 104435 RVA: 0x003B8331 File Offset: 0x003B6531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197F4 RID: 104436 RVA: 0x003B833A File Offset: 0x003B653A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.exam_.WriteTo(ref output, SolarSchoolExamDataPb._repeated_exam_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197F5 RID: 104437 RVA: 0x003B8364 File Offset: 0x003B6564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.exam_.CalculateSize(SolarSchoolExamDataPb._repeated_exam_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197F6 RID: 104438 RVA: 0x003B839D File Offset: 0x003B659D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolExamDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.exam_.Add(other.exam_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197F7 RID: 104439 RVA: 0x003B83CB File Offset: 0x003B65CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197F8 RID: 104440 RVA: 0x003B83D4 File Offset: 0x003B65D4
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
					this.exam_.AddEntriesFrom(ref input, SolarSchoolExamDataPb._repeated_exam_codec);
				}
			}
		}

		// Token: 0x040096AE RID: 38574
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096AF RID: 38575
		public const int ExamFieldNumber = 1;

		// Token: 0x040096B0 RID: 38576
		private static readonly FieldCodec<SolarSchoolExamResult> _repeated_exam_codec = FieldCodec.ForMessage<SolarSchoolExamResult>(10U, SolarSchoolExamResult.Parser);

		// Token: 0x040096B1 RID: 38577
		private readonly RepeatedField<SolarSchoolExamResult> exam_ = new RepeatedField<SolarSchoolExamResult>();
	}
}
