using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C9 RID: 1225
	public sealed class ExamFinishSyncDataPb : IMessage<ExamFinishSyncDataPb>, IMessage, IEquatable<ExamFinishSyncDataPb>, IDeepCloneable<ExamFinishSyncDataPb>, IBufferMessage
	{
		// Token: 0x060074C2 RID: 29890 RVA: 0x0011E495 File Offset: 0x0011C695
		[NullableContext(1)]
		public static ExamFinishSyncDataPb Create()
		{
			return new ExamFinishSyncDataPb();
		}

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x060074C3 RID: 29891 RVA: 0x0011E49C File Offset: 0x0011C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x060074C4 RID: 29892 RVA: 0x0011E49F File Offset: 0x0011C69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExamFinishSyncDataPb.Descriptor;
			}
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0011E4A6 File Offset: 0x0011C6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExamFinishSyncDataPb()
		{
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x0011E4AE File Offset: 0x0011C6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExamFinishSyncDataPb(ExamFinishSyncDataPb other) : this()
		{
			this.examId_ = other.examId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x0011E4DF File Offset: 0x0011C6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExamFinishSyncDataPb Clone()
		{
			return new ExamFinishSyncDataPb(this);
		}

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x0011E4E7 File Offset: 0x0011C6E7
		// (set) Token: 0x060074C9 RID: 29897 RVA: 0x0011E4EF File Offset: 0x0011C6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExamId
		{
			get
			{
				return this.examId_;
			}
			set
			{
				this.examId_ = value;
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x0011E4F8 File Offset: 0x0011C6F8
		// (set) Token: 0x060074CB RID: 29899 RVA: 0x0011E500 File Offset: 0x0011C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x0011E509 File Offset: 0x0011C709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExamFinishSyncDataPb);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0011E517 File Offset: 0x0011C717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExamFinishSyncDataPb other)
		{
			return other != null && (other == this || (this.ExamId == other.ExamId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x0011E558 File Offset: 0x0011C758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExamId != 0)
			{
				num ^= this.ExamId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x0011E5B0 File Offset: 0x0011C7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x0011E5BD File Offset: 0x0011C7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x0011E5C8 File Offset: 0x0011C7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ExamId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ExamId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x0011E620 File Offset: 0x0011C820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExamId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExamId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x0011E678 File Offset: 0x0011C878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExamFinishSyncDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExamId != 0)
			{
				this.ExamId = other.ExamId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x0011E6C8 File Offset: 0x0011C8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x0011E6D4 File Offset: 0x0011C8D4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.ExamId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DDB RID: 15835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DDC RID: 15836
		public const int ExamIdFieldNumber = 1;

		// Token: 0x04003DDD RID: 15837
		private int examId_;

		// Token: 0x04003DDE RID: 15838
		public const int ScoreFieldNumber = 2;

		// Token: 0x04003DDF RID: 15839
		private int score_;
	}
}
