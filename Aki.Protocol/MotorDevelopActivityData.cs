using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1F RID: 2591
	public sealed class MotorDevelopActivityData : IMessage<MotorDevelopActivityData>, IMessage, IEquatable<MotorDevelopActivityData>, IDeepCloneable<MotorDevelopActivityData>, IBufferMessage
	{
		// Token: 0x0600E2B8 RID: 58040 RVA: 0x002131C4 File Offset: 0x002113C4
		[NullableContext(1)]
		public static MotorDevelopActivityData Create()
		{
			return new MotorDevelopActivityData();
		}

		// Token: 0x17002DF0 RID: 11760
		// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x002131CB File Offset: 0x002113CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DF1 RID: 11761
		// (get) Token: 0x0600E2BA RID: 58042 RVA: 0x002131CE File Offset: 0x002113CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopActivityData.Descriptor;
			}
		}

		// Token: 0x0600E2BB RID: 58043 RVA: 0x002131D5 File Offset: 0x002113D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData()
		{
		}

		// Token: 0x0600E2BC RID: 58044 RVA: 0x002131E8 File Offset: 0x002113E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData(MotorDevelopActivityData other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2BD RID: 58045 RVA: 0x00213212 File Offset: 0x00211412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopActivityData Clone()
		{
			return new MotorDevelopActivityData(this);
		}

		// Token: 0x17002DF2 RID: 11762
		// (get) Token: 0x0600E2BE RID: 58046 RVA: 0x0021321A File Offset: 0x0021141A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E2BF RID: 58047 RVA: 0x00213222 File Offset: 0x00211422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopActivityData);
		}

		// Token: 0x0600E2C0 RID: 58048 RVA: 0x00213230 File Offset: 0x00211430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopActivityData other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2C1 RID: 58049 RVA: 0x00213264 File Offset: 0x00211464
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

		// Token: 0x0600E2C2 RID: 58050 RVA: 0x00213298 File Offset: 0x00211498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2C3 RID: 58051 RVA: 0x002132A5 File Offset: 0x002114A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2C4 RID: 58052 RVA: 0x002132AE File Offset: 0x002114AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, MotorDevelopActivityData._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2C5 RID: 58053 RVA: 0x002132D8 File Offset: 0x002114D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(MotorDevelopActivityData._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2C6 RID: 58054 RVA: 0x00213311 File Offset: 0x00211511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDevelopActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2C7 RID: 58055 RVA: 0x0021333F File Offset: 0x0021153F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2C8 RID: 58056 RVA: 0x00213348 File Offset: 0x00211548
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
					this.task_.AddEntriesFrom(ref input, MotorDevelopActivityData._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005D50 RID: 23888
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D51 RID: 23889
		public const int TaskFieldNumber = 1;

		// Token: 0x04005D52 RID: 23890
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005D53 RID: 23891
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
