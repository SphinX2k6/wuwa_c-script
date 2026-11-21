using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200116C RID: 4460
	[NetMessage(EMessageId.RoverRogueTaskUpdateNotify)]
	public sealed class RoverRogueTaskUpdateNotify : IMessage<RoverRogueTaskUpdateNotify>, IMessage, IEquatable<RoverRogueTaskUpdateNotify>, IDeepCloneable<RoverRogueTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017D51 RID: 97617 RVA: 0x003785A0 File Offset: 0x003767A0
		[NullableContext(1)]
		public static RoverRogueTaskUpdateNotify Create()
		{
			return new RoverRogueTaskUpdateNotify();
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x06017D52 RID: 97618 RVA: 0x003785A7 File Offset: 0x003767A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06017D53 RID: 97619 RVA: 0x003785AA File Offset: 0x003767AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017D54 RID: 97620 RVA: 0x003785B1 File Offset: 0x003767B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify()
		{
		}

		// Token: 0x06017D55 RID: 97621 RVA: 0x003785C4 File Offset: 0x003767C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify(RoverRogueTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017D56 RID: 97622 RVA: 0x003785EE File Offset: 0x003767EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify Clone()
		{
			return new RoverRogueTaskUpdateNotify(this);
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06017D57 RID: 97623 RVA: 0x003785F6 File Offset: 0x003767F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x06017D58 RID: 97624 RVA: 0x003785FE File Offset: 0x003767FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskUpdateNotify);
		}

		// Token: 0x06017D59 RID: 97625 RVA: 0x0037860C File Offset: 0x0037680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017D5A RID: 97626 RVA: 0x00378640 File Offset: 0x00376840
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

		// Token: 0x06017D5B RID: 97627 RVA: 0x00378674 File Offset: 0x00376874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017D5C RID: 97628 RVA: 0x00378681 File Offset: 0x00376881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017D5D RID: 97629 RVA: 0x0037868A File Offset: 0x0037688A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tasks_.WriteTo(ref output, RoverRogueTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017D5E RID: 97630 RVA: 0x003786B4 File Offset: 0x003768B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tasks_.CalculateSize(RoverRogueTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017D5F RID: 97631 RVA: 0x003786ED File Offset: 0x003768ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017D60 RID: 97632 RVA: 0x0037871B File Offset: 0x0037691B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x00378724 File Offset: 0x00376924
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
					this.tasks_.AddEntriesFrom(ref input, RoverRogueTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x04008E2E RID: 36398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E2F RID: 36399
		public const int TasksFieldNumber = 8;

		// Token: 0x04008E30 RID: 36400
		private static readonly FieldCodec<ConditionTask> _repeated_tasks_codec = FieldCodec.ForMessage<ConditionTask>(66U, ConditionTask.Parser);

		// Token: 0x04008E31 RID: 36401
		private readonly RepeatedField<ConditionTask> tasks_ = new RepeatedField<ConditionTask>();
	}
}
