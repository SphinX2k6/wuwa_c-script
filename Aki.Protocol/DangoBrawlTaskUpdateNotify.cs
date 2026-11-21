using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000386 RID: 902
	[NetMessage(EMessageId.DangoBrawlTaskUpdateNotify)]
	public sealed class DangoBrawlTaskUpdateNotify : IMessage<DangoBrawlTaskUpdateNotify>, IMessage, IEquatable<DangoBrawlTaskUpdateNotify>, IDeepCloneable<DangoBrawlTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005987 RID: 22919 RVA: 0x000DA505 File Offset: 0x000D8705
		[NullableContext(1)]
		public static DangoBrawlTaskUpdateNotify Create()
		{
			return new DangoBrawlTaskUpdateNotify();
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x000DA50C File Offset: 0x000D870C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06005989 RID: 22921 RVA: 0x000DA50F File Offset: 0x000D870F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x000DA516 File Offset: 0x000D8716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify()
		{
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x000DA529 File Offset: 0x000D8729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify(DangoBrawlTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x000DA553 File Offset: 0x000D8753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlTaskUpdateNotify Clone()
		{
			return new DangoBrawlTaskUpdateNotify(this);
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x0600598D RID: 22925 RVA: 0x000DA55B File Offset: 0x000D875B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x000DA563 File Offset: 0x000D8763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlTaskUpdateNotify);
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x000DA571 File Offset: 0x000D8771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x000DA5A4 File Offset: 0x000D87A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x000DA5D8 File Offset: 0x000D87D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x000DA5E5 File Offset: 0x000D87E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x000DA5EE File Offset: 0x000D87EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tasks_.WriteTo(ref output, DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x000DA618 File Offset: 0x000D8818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tasks_.CalculateSize(DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x000DA651 File Offset: 0x000D8851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x000DA67F File Offset: 0x000D887F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x000DA688 File Offset: 0x000D8888
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.tasks_.AddEntriesFrom(ref input, DangoBrawlTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x040035B7 RID: 13751
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035B8 RID: 13752
		public const int TasksFieldNumber = 12;

		// Token: 0x040035B9 RID: 13753
		private static readonly FieldCodec<ConditionTask> _repeated_tasks_codec = FieldCodec.ForMessage<ConditionTask>(98U, ConditionTask.Parser);

		// Token: 0x040035BA RID: 13754
		private readonly RepeatedField<ConditionTask> tasks_ = new RepeatedField<ConditionTask>();
	}
}
