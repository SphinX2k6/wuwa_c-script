using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A5E RID: 2654
	[NetMessage(EMessageId.MotorFightTaskUpdateNotify)]
	public sealed class MotorFightTaskUpdateNotify : IMessage<MotorFightTaskUpdateNotify>, IMessage, IEquatable<MotorFightTaskUpdateNotify>, IDeepCloneable<MotorFightTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E7D2 RID: 59346 RVA: 0x0021E2E1 File Offset: 0x0021C4E1
		[NullableContext(1)]
		public static MotorFightTaskUpdateNotify Create()
		{
			return new MotorFightTaskUpdateNotify();
		}

		// Token: 0x17002F06 RID: 12038
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x0021E2E8 File Offset: 0x0021C4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F07 RID: 12039
		// (get) Token: 0x0600E7D4 RID: 59348 RVA: 0x0021E2EB File Offset: 0x0021C4EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x0021E2F2 File Offset: 0x0021C4F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify()
		{
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x0021E305 File Offset: 0x0021C505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify(MotorFightTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x0021E32F File Offset: 0x0021C52F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTaskUpdateNotify Clone()
		{
			return new MotorFightTaskUpdateNotify(this);
		}

		// Token: 0x17002F08 RID: 12040
		// (get) Token: 0x0600E7D8 RID: 59352 RVA: 0x0021E337 File Offset: 0x0021C537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x0021E33F File Offset: 0x0021C53F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTaskUpdateNotify);
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x0021E34D File Offset: 0x0021C54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x0021E380 File Offset: 0x0021C580
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

		// Token: 0x0600E7DC RID: 59356 RVA: 0x0021E3B4 File Offset: 0x0021C5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x0021E3C1 File Offset: 0x0021C5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x0021E3CA File Offset: 0x0021C5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorFightTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E7DF RID: 59359 RVA: 0x0021E3F4 File Offset: 0x0021C5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorFightTaskUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x0021E42D File Offset: 0x0021C62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x0021E45B File Offset: 0x0021C65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x0021E464 File Offset: 0x0021C664
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, MotorFightTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005ED0 RID: 24272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005ED1 RID: 24273
		public const int TaskFieldNumber = 5;

		// Token: 0x04005ED2 RID: 24274
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(42U, ConditionTask.Parser);

		// Token: 0x04005ED3 RID: 24275
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
