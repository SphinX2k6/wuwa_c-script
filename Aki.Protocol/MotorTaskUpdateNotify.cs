using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AAA RID: 2730
	[NetMessage(EMessageId.MotorTaskUpdateNotify)]
	public sealed class MotorTaskUpdateNotify : IMessage<MotorTaskUpdateNotify>, IMessage, IEquatable<MotorTaskUpdateNotify>, IDeepCloneable<MotorTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600EDA6 RID: 60838 RVA: 0x0022B130 File Offset: 0x00229330
		[NullableContext(1)]
		public static MotorTaskUpdateNotify Create()
		{
			return new MotorTaskUpdateNotify();
		}

		// Token: 0x17003049 RID: 12361
		// (get) Token: 0x0600EDA7 RID: 60839 RVA: 0x0022B137 File Offset: 0x00229337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700304A RID: 12362
		// (get) Token: 0x0600EDA8 RID: 60840 RVA: 0x0022B13A File Offset: 0x0022933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600EDA9 RID: 60841 RVA: 0x0022B141 File Offset: 0x00229341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify()
		{
		}

		// Token: 0x0600EDAA RID: 60842 RVA: 0x0022B154 File Offset: 0x00229354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify(MotorTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EDAB RID: 60843 RVA: 0x0022B17E File Offset: 0x0022937E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskUpdateNotify Clone()
		{
			return new MotorTaskUpdateNotify(this);
		}

		// Token: 0x1700304B RID: 12363
		// (get) Token: 0x0600EDAC RID: 60844 RVA: 0x0022B186 File Offset: 0x00229386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskPb> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600EDAD RID: 60845 RVA: 0x0022B18E File Offset: 0x0022938E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskUpdateNotify);
		}

		// Token: 0x0600EDAE RID: 60846 RVA: 0x0022B19C File Offset: 0x0022939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EDAF RID: 60847 RVA: 0x0022B1D0 File Offset: 0x002293D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EDB0 RID: 60848 RVA: 0x0022B204 File Offset: 0x00229404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EDB1 RID: 60849 RVA: 0x0022B211 File Offset: 0x00229411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EDB2 RID: 60850 RVA: 0x0022B21A File Offset: 0x0022941A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EDB3 RID: 60851 RVA: 0x0022B244 File Offset: 0x00229444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EDB4 RID: 60852 RVA: 0x0022B27D File Offset: 0x0022947D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EDB5 RID: 60853 RVA: 0x0022B2AB File Offset: 0x002294AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EDB6 RID: 60854 RVA: 0x0022B2B4 File Offset: 0x002294B4
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, MotorTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x0400603D RID: 24637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400603E RID: 24638
		public const int TaskFieldNumber = 10;

		// Token: 0x0400603F RID: 24639
		private static readonly FieldCodec<MotorTaskPb> _repeated_task_codec = FieldCodec.ForMessage<MotorTaskPb>(82U, MotorTaskPb.Parser);

		// Token: 0x04006040 RID: 24640
		private readonly RepeatedField<MotorTaskPb> task_ = new RepeatedField<MotorTaskPb>();
	}
}
