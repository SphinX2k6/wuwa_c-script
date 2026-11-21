using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0C RID: 2828
	[NetMessage(EMessageId.NewPlayerSupportActivityTaskUpdateNotify)]
	public sealed class NewPlayerSupportActivityTaskUpdateNotify : IMessage<NewPlayerSupportActivityTaskUpdateNotify>, IMessage, IEquatable<NewPlayerSupportActivityTaskUpdateNotify>, IDeepCloneable<NewPlayerSupportActivityTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600F5E7 RID: 62951 RVA: 0x0023E18F File Offset: 0x0023C38F
		[NullableContext(1)]
		public static NewPlayerSupportActivityTaskUpdateNotify Create()
		{
			return new NewPlayerSupportActivityTaskUpdateNotify();
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600F5E8 RID: 62952 RVA: 0x0023E196 File Offset: 0x0023C396
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600F5E9 RID: 62953 RVA: 0x0023E199 File Offset: 0x0023C399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600F5EA RID: 62954 RVA: 0x0023E1A0 File Offset: 0x0023C3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify()
		{
		}

		// Token: 0x0600F5EB RID: 62955 RVA: 0x0023E1B3 File Offset: 0x0023C3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify(NewPlayerSupportActivityTaskUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F5EC RID: 62956 RVA: 0x0023E1DD File Offset: 0x0023C3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityTaskUpdateNotify Clone()
		{
			return new NewPlayerSupportActivityTaskUpdateNotify(this);
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600F5ED RID: 62957 RVA: 0x0023E1E5 File Offset: 0x0023C3E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600F5EE RID: 62958 RVA: 0x0023E1ED File Offset: 0x0023C3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityTaskUpdateNotify);
		}

		// Token: 0x0600F5EF RID: 62959 RVA: 0x0023E1FB File Offset: 0x0023C3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F5F0 RID: 62960 RVA: 0x0023E230 File Offset: 0x0023C430
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

		// Token: 0x0600F5F1 RID: 62961 RVA: 0x0023E264 File Offset: 0x0023C464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F5F2 RID: 62962 RVA: 0x0023E271 File Offset: 0x0023C471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x0023E27A File Offset: 0x0023C47A
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

		// Token: 0x0600F5F4 RID: 62964 RVA: 0x0023E2A4 File Offset: 0x0023C4A4
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

		// Token: 0x0600F5F5 RID: 62965 RVA: 0x0023E2DD File Offset: 0x0023C4DD
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

		// Token: 0x0600F5F6 RID: 62966 RVA: 0x0023E30B File Offset: 0x0023C50B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F5F7 RID: 62967 RVA: 0x0023E314 File Offset: 0x0023C514
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
					this.conditionTasks_.AddEntriesFrom(ref input, NewPlayerSupportActivityTaskUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x0400632A RID: 25386
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400632B RID: 25387
		public const int ConditionTasksFieldNumber = 12;

		// Token: 0x0400632C RID: 25388
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(98U, ConditionTask.Parser);

		// Token: 0x0400632D RID: 25389
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
