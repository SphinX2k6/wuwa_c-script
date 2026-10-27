using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC0 RID: 3264
	[NetMessage(EMessageId.PhantomBattleTaskInfoNotify)]
	public sealed class PhantomBattleTaskInfoNotify : IMessage<PhantomBattleTaskInfoNotify>, IMessage, IEquatable<PhantomBattleTaskInfoNotify>, IDeepCloneable<PhantomBattleTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x06011AD7 RID: 72407 RVA: 0x00296ACD File Offset: 0x00294CCD
		[NullableContext(1)]
		public static PhantomBattleTaskInfoNotify Create()
		{
			return new PhantomBattleTaskInfoNotify();
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x06011AD8 RID: 72408 RVA: 0x00296AD4 File Offset: 0x00294CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x06011AD9 RID: 72409 RVA: 0x00296AD7 File Offset: 0x00294CD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x06011ADA RID: 72410 RVA: 0x00296ADE File Offset: 0x00294CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify()
		{
		}

		// Token: 0x06011ADB RID: 72411 RVA: 0x00296AF1 File Offset: 0x00294CF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify(PhantomBattleTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011ADC RID: 72412 RVA: 0x00296B1B File Offset: 0x00294D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify Clone()
		{
			return new PhantomBattleTaskInfoNotify(this);
		}

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x06011ADD RID: 72413 RVA: 0x00296B23 File Offset: 0x00294D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06011ADE RID: 72414 RVA: 0x00296B2B File Offset: 0x00294D2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskInfoNotify);
		}

		// Token: 0x06011ADF RID: 72415 RVA: 0x00296B39 File Offset: 0x00294D39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AE0 RID: 72416 RVA: 0x00296B6C File Offset: 0x00294D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activityTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011AE1 RID: 72417 RVA: 0x00296BA0 File Offset: 0x00294DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AE2 RID: 72418 RVA: 0x00296BAD File Offset: 0x00294DAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AE3 RID: 72419 RVA: 0x00296BB6 File Offset: 0x00294DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, PhantomBattleTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AE4 RID: 72420 RVA: 0x00296BE0 File Offset: 0x00294DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(PhantomBattleTaskInfoNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011AE5 RID: 72421 RVA: 0x00296C19 File Offset: 0x00294E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleTaskInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011AE6 RID: 72422 RVA: 0x00296C47 File Offset: 0x00294E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AE7 RID: 72423 RVA: 0x00296C50 File Offset: 0x00294E50
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, PhantomBattleTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04006F40 RID: 28480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F41 RID: 28481
		public const int ActivityTasksFieldNumber = 8;

		// Token: 0x04006F42 RID: 28482
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(66U, ActivityTask.Parser);

		// Token: 0x04006F43 RID: 28483
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
