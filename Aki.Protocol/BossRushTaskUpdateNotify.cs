using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E3 RID: 483
	[NetMessage(EMessageId.BossRushTaskUpdateNotify)]
	public sealed class BossRushTaskUpdateNotify : IMessage<BossRushTaskUpdateNotify>, IMessage, IEquatable<BossRushTaskUpdateNotify>, IDeepCloneable<BossRushTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06003659 RID: 13913 RVA: 0x000886C1 File Offset: 0x000868C1
		[NullableContext(1)]
		public static BossRushTaskUpdateNotify Create()
		{
			return new BossRushTaskUpdateNotify();
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x0600365A RID: 13914 RVA: 0x000886C8 File Offset: 0x000868C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x000886CB File Offset: 0x000868CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x000886D2 File Offset: 0x000868D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify()
		{
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x000886E5 File Offset: 0x000868E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify(BossRushTaskUpdateNotify other) : this()
		{
			this.activityTasks_ = other.activityTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0008870F File Offset: 0x0008690F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushTaskUpdateNotify Clone()
		{
			return new BossRushTaskUpdateNotify(this);
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600365F RID: 13919 RVA: 0x00088717 File Offset: 0x00086917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityTask> ActivityTasks
		{
			get
			{
				return this.activityTasks_;
			}
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0008871F File Offset: 0x0008691F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushTaskUpdateNotify);
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x0008872D File Offset: 0x0008692D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.activityTasks_.Equals(other.activityTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x00088760 File Offset: 0x00086960
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

		// Token: 0x06003663 RID: 13923 RVA: 0x00088794 File Offset: 0x00086994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x000887A1 File Offset: 0x000869A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x000887AA File Offset: 0x000869AA
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

		// Token: 0x06003666 RID: 13926 RVA: 0x000887D4 File Offset: 0x000869D4
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

		// Token: 0x06003667 RID: 13927 RVA: 0x0008880D File Offset: 0x00086A0D
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

		// Token: 0x06003668 RID: 13928 RVA: 0x0008883B File Offset: 0x00086A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x00088844 File Offset: 0x00086A44
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activityTasks_.AddEntriesFrom(ref input, BossRushTaskUpdateNotify._repeated_activityTasks_codec);
				}
			}
		}

		// Token: 0x04002A9B RID: 10907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A9C RID: 10908
		public const int ActivityTasksFieldNumber = 14;

		// Token: 0x04002A9D RID: 10909
		private static readonly FieldCodec<ActivityTask> _repeated_activityTasks_codec = FieldCodec.ForMessage<ActivityTask>(114U, ActivityTask.Parser);

		// Token: 0x04002A9E RID: 10910
		private readonly RepeatedField<ActivityTask> activityTasks_ = new RepeatedField<ActivityTask>();
	}
}
