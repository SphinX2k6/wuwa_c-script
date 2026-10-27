using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A33 RID: 2611
	[NetMessage(EMessageId.MotorDevelopTaskUpdateNotify)]
	public sealed class MotorDevelopTaskUpdateNotify : IMessage<MotorDevelopTaskUpdateNotify>, IMessage, IEquatable<MotorDevelopTaskUpdateNotify>, IDeepCloneable<MotorDevelopTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E408 RID: 58376 RVA: 0x00215955 File Offset: 0x00213B55
		[NullableContext(1)]
		public static MotorDevelopTaskUpdateNotify Create()
		{
			return new MotorDevelopTaskUpdateNotify();
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600E409 RID: 58377 RVA: 0x0021595C File Offset: 0x00213B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0600E40A RID: 58378 RVA: 0x0021595F File Offset: 0x00213B5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDevelopTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E40B RID: 58379 RVA: 0x00215966 File Offset: 0x00213B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify()
		{
		}

		// Token: 0x0600E40C RID: 58380 RVA: 0x00215979 File Offset: 0x00213B79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify(MotorDevelopTaskUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E40D RID: 58381 RVA: 0x002159A3 File Offset: 0x00213BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDevelopTaskUpdateNotify Clone()
		{
			return new MotorDevelopTaskUpdateNotify(this);
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0600E40E RID: 58382 RVA: 0x002159AB File Offset: 0x00213BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x0600E40F RID: 58383 RVA: 0x002159B3 File Offset: 0x00213BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDevelopTaskUpdateNotify);
		}

		// Token: 0x0600E410 RID: 58384 RVA: 0x002159C1 File Offset: 0x00213BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDevelopTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x002159F4 File Offset: 0x00213BF4
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

		// Token: 0x0600E412 RID: 58386 RVA: 0x00215A28 File Offset: 0x00213C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x00215A35 File Offset: 0x00213C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x00215A3E File Offset: 0x00213C3E
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

		// Token: 0x0600E415 RID: 58389 RVA: 0x00215A68 File Offset: 0x00213C68
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

		// Token: 0x0600E416 RID: 58390 RVA: 0x00215AA1 File Offset: 0x00213CA1
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

		// Token: 0x0600E417 RID: 58391 RVA: 0x00215ACF File Offset: 0x00213CCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E418 RID: 58392 RVA: 0x00215AD8 File Offset: 0x00213CD8
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, MotorDevelopTaskUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x04005D52 RID: 23890
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D53 RID: 23891
		public const int TaskFieldNumber = 11;

		// Token: 0x04005D54 RID: 23892
		private static readonly FieldCodec<ConditionTask> _repeated_task_codec = FieldCodec.ForMessage<ConditionTask>(90U, ConditionTask.Parser);

		// Token: 0x04005D55 RID: 23893
		private readonly RepeatedField<ConditionTask> task_ = new RepeatedField<ConditionTask>();
	}
}
