using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CB0 RID: 3248
	[NetMessage(EMessageId.PhantomBattleTaskInfoNotify)]
	public sealed class PhantomBattleTaskInfoNotify : IMessage<PhantomBattleTaskInfoNotify>, IMessage, IEquatable<PhantomBattleTaskInfoNotify>, IDeepCloneable<PhantomBattleTaskInfoNotify>, IBufferMessage
	{
		// Token: 0x060119D7 RID: 72151 RVA: 0x00294D6D File Offset: 0x00292F6D
		[NullableContext(1)]
		public static PhantomBattleTaskInfoNotify Create()
		{
			return new PhantomBattleTaskInfoNotify();
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x060119D8 RID: 72152 RVA: 0x00294D74 File Offset: 0x00292F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x060119D9 RID: 72153 RVA: 0x00294D77 File Offset: 0x00292F77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskInfoNotify.Descriptor;
			}
		}

		// Token: 0x060119DA RID: 72154 RVA: 0x00294D7E File Offset: 0x00292F7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify()
		{
		}

		// Token: 0x060119DB RID: 72155 RVA: 0x00294D91 File Offset: 0x00292F91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify(PhantomBattleTaskInfoNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060119DC RID: 72156 RVA: 0x00294DBB File Offset: 0x00292FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskInfoNotify Clone()
		{
			return new PhantomBattleTaskInfoNotify(this);
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x060119DD RID: 72157 RVA: 0x00294DC3 File Offset: 0x00292FC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x060119DE RID: 72158 RVA: 0x00294DCB File Offset: 0x00292FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskInfoNotify);
		}

		// Token: 0x060119DF RID: 72159 RVA: 0x00294DD9 File Offset: 0x00292FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskInfoNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060119E0 RID: 72160 RVA: 0x00294E0C File Offset: 0x0029300C
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

		// Token: 0x060119E1 RID: 72161 RVA: 0x00294E40 File Offset: 0x00293040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060119E2 RID: 72162 RVA: 0x00294E4D File Offset: 0x0029304D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060119E3 RID: 72163 RVA: 0x00294E56 File Offset: 0x00293056
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

		// Token: 0x060119E4 RID: 72164 RVA: 0x00294E80 File Offset: 0x00293080
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

		// Token: 0x060119E5 RID: 72165 RVA: 0x00294EB9 File Offset: 0x002930B9
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

		// Token: 0x060119E6 RID: 72166 RVA: 0x00294EE7 File Offset: 0x002930E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060119E7 RID: 72167 RVA: 0x00294EF0 File Offset: 0x002930F0
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, PhantomBattleTaskInfoNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04006F54 RID: 28500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F55 RID: 28501
		public const int ActivityTasksFieldNumber = 6;

		// Token: 0x04006F56 RID: 28502
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(50U, ActivityTask.Parser);

		// Token: 0x04006F57 RID: 28503
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
