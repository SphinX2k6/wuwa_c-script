using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B1D RID: 2845
	[NetMessage(EMessageId.NewPlayerSupportActivityTaskUpdateNotify)]
	public sealed class NewPlayerSupportActivityTaskUpdateNotify : IMessage<NewPlayerSupportActivityTaskUpdateNotify>, IMessage, IEquatable<NewPlayerSupportActivityTaskUpdateNotify>, IDeepCloneable<NewPlayerSupportActivityTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F701 RID: 63233 RVA: 0x002403A7 File Offset: 0x0023E5A7
		[NullableContext(1)]
		public static NewPlayerSupportActivityTaskUpdateNotify Create()
		{
			return new NewPlayerSupportActivityTaskUpdateNotify();
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600F702 RID: 63234 RVA: 0x002403AE File Offset: 0x0023E5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600F703 RID: 63235 RVA: 0x002403B1 File Offset: 0x0023E5B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F704 RID: 63236 RVA: 0x002403B8 File Offset: 0x0023E5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify()
		{
		}

		// Token: 0x0600F705 RID: 63237 RVA: 0x002403CB File Offset: 0x0023E5CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify(NewPlayerSupportActivityTaskUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F706 RID: 63238 RVA: 0x002403F5 File Offset: 0x0023E5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify Clone()
		{
			return new NewPlayerSupportActivityTaskUpdateNotify(this);
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600F707 RID: 63239 RVA: 0x002403FD File Offset: 0x0023E5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600F708 RID: 63240 RVA: 0x00240405 File Offset: 0x0023E605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTaskUpdateNotify);
		}

		// Token: 0x0600F709 RID: 63241 RVA: 0x00240413 File Offset: 0x0023E613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F70A RID: 63242 RVA: 0x00240448 File Offset: 0x0023E648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.conditionTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F70B RID: 63243 RVA: 0x0024047C File Offset: 0x0023E67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F70C RID: 63244 RVA: 0x00240489 File Offset: 0x0023E689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F70D RID: 63245 RVA: 0x00240492 File Offset: 0x0023E692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, NewPlayerSupportActivityTaskUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F70E RID: 63246 RVA: 0x002404BC File Offset: 0x0023E6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(NewPlayerSupportActivityTaskUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F70F RID: 63247 RVA: 0x002404F5 File Offset: 0x0023E6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportActivityTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F710 RID: 63248 RVA: 0x00240523 File Offset: 0x0023E723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F711 RID: 63249 RVA: 0x0024052C File Offset: 0x0023E72C
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, NewPlayerSupportActivityTaskUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04006321 RID: 25377
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006322 RID: 25378
		public const int ConditionTasksFieldNumber = 3;

		// Token: 0x04006323 RID: 25379
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(26U, ConditionTask.Parser);

		// Token: 0x04006324 RID: 25380
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
