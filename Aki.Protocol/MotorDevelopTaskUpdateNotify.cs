using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A22 RID: 2594
	[NetMessage(EMessageId.MotorDevelopTaskUpdateNotify)]
	public sealed class MotorDevelopTaskUpdateNotify : IMessage<MotorDevelopTaskUpdateNotify>, IMessage, IEquatable<MotorDevelopTaskUpdateNotify>, IDeepCloneable<MotorDevelopTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E2EE RID: 58094 RVA: 0x00213765 File Offset: 0x00211965
		[NullableContext(1)]
		public static MotorDevelopTaskUpdateNotify Create()
		{
			return new MotorDevelopTaskUpdateNotify();
		}

		// Token: 0x17002DF9 RID: 11769
		// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x0021376C File Offset: 0x0021196C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DFA RID: 11770
		// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x0021376F File Offset: 0x0021196F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E2F1 RID: 58097 RVA: 0x00213776 File Offset: 0x00211976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify()
		{
		}

		// Token: 0x0600E2F2 RID: 58098 RVA: 0x00213789 File Offset: 0x00211989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify(MotorDevelopTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2F3 RID: 58099 RVA: 0x002137B3 File Offset: 0x002119B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify Clone()
		{
			return new MotorDevelopTaskUpdateNotify(this);
		}

		// Token: 0x17002DFB RID: 11771
		// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x002137BB File Offset: 0x002119BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E2F5 RID: 58101 RVA: 0x002137C3 File Offset: 0x002119C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskUpdateNotify);
		}

		// Token: 0x0600E2F6 RID: 58102 RVA: 0x002137D1 File Offset: 0x002119D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2F7 RID: 58103 RVA: 0x00213804 File Offset: 0x00211A04
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

		// Token: 0x0600E2F8 RID: 58104 RVA: 0x00213838 File Offset: 0x00211A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2F9 RID: 58105 RVA: 0x00213845 File Offset: 0x00211A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2FA RID: 58106 RVA: 0x0021384E File Offset: 0x00211A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorDevelopTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2FB RID: 58107 RVA: 0x00213878 File Offset: 0x00211A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorDevelopTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2FC RID: 58108 RVA: 0x002138B1 File Offset: 0x00211AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2FD RID: 58109 RVA: 0x002138DF File Offset: 0x00211ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2FE RID: 58110 RVA: 0x002138E8 File Offset: 0x00211AE8
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, MotorDevelopTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005D5B RID: 23899
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D5C RID: 23900
		public const int TaskFieldNumber = 4;

		// Token: 0x04005D5D RID: 23901
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x04005D5E RID: 23902
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
