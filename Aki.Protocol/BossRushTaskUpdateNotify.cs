using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E7 RID: 487
	[NetMessage(EMessageId.BossRushTaskUpdateNotify)]
	public sealed class BossRushTaskUpdateNotify : IMessage<BossRushTaskUpdateNotify>, IMessage, IEquatable<BossRushTaskUpdateNotify>, IDeepCloneable<BossRushTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x060036E6 RID: 14054 RVA: 0x00089E35 File Offset: 0x00088035
		[NullableContext(1)]
		public static BossRushTaskUpdateNotify Create()
		{
			return new BossRushTaskUpdateNotify();
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x00089E3C File Offset: 0x0008803C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00089E3F File Offset: 0x0008803F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00089E46 File Offset: 0x00088046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify()
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00089E59 File Offset: 0x00088059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify(BossRushTaskUpdateNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00089E83 File Offset: 0x00088083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify Clone()
		{
			return new BossRushTaskUpdateNotify(this);
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00089E8B File Offset: 0x0008808B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00089E93 File Offset: 0x00088093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskUpdateNotify);
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00089EA1 File Offset: 0x000880A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00089ED4 File Offset: 0x000880D4
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

		// Token: 0x060036F0 RID: 14064 RVA: 0x00089F08 File Offset: 0x00088108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00089F15 File Offset: 0x00088115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00089F1E File Offset: 0x0008811E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activityTasks_.WriteTo(ref output, BossRushTaskUpdateNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00089F48 File Offset: 0x00088148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activityTasks_.CalculateSize(BossRushTaskUpdateNotify._repeated_activityTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00089F81 File Offset: 0x00088181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activityTasks_.Add(other.activityTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00089FAF File Offset: 0x000881AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00089FB8 File Offset: 0x000881B8
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BossRushTaskUpdateNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04002B16 RID: 11030
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B17 RID: 11031
		public const int ActivityTasksFieldNumber = 9;

		// Token: 0x04002B18 RID: 11032
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(74U, ActivityTask.Parser);

		// Token: 0x04002B19 RID: 11033
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
