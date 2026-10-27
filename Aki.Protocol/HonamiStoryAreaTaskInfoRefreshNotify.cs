using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000766 RID: 1894
	[NetMessage(EMessageId.HonamiStoryAreaTaskInfoRefreshNotify)]
	public sealed class HonamiStoryAreaTaskInfoRefreshNotify : IMessage<HonamiStoryAreaTaskInfoRefreshNotify>, IMessage, IEquatable<HonamiStoryAreaTaskInfoRefreshNotify>, IDeepCloneable<HonamiStoryAreaTaskInfoRefreshNotify>, IBufferMessage
	{
		// Token: 0x0600AB5D RID: 43869 RVA: 0x0019C535 File Offset: 0x0019A735
		[NullableContext(1)]
		public static HonamiStoryAreaTaskInfoRefreshNotify Create()
		{
			return new HonamiStoryAreaTaskInfoRefreshNotify();
		}

		// Token: 0x17002289 RID: 8841
		// (get) Token: 0x0600AB5E RID: 43870 RVA: 0x0019C53C File Offset: 0x0019A73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700228A RID: 8842
		// (get) Token: 0x0600AB5F RID: 43871 RVA: 0x0019C53F File Offset: 0x0019A73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaTaskInfoRefreshNotify.Descriptor;
			}
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x0019C546 File Offset: 0x0019A746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify()
		{
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x0019C559 File Offset: 0x0019A759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify(HonamiStoryAreaTaskInfoRefreshNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x0019C583 File Offset: 0x0019A783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoRefreshNotify Clone()
		{
			return new HonamiStoryAreaTaskInfoRefreshNotify(this);
		}

		// Token: 0x1700228B RID: 8843
		// (get) Token: 0x0600AB63 RID: 43875 RVA: 0x0019C58B File Offset: 0x0019A78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x0019C593 File Offset: 0x0019A793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaTaskInfoRefreshNotify);
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x0019C5A1 File Offset: 0x0019A7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaTaskInfoRefreshNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x0019C5D4 File Offset: 0x0019A7D4
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

		// Token: 0x0600AB67 RID: 43879 RVA: 0x0019C608 File Offset: 0x0019A808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x0019C615 File Offset: 0x0019A815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x0019C61E File Offset: 0x0019A81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x0019C648 File Offset: 0x0019A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x0019C681 File Offset: 0x0019A881
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaTaskInfoRefreshNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0019C6AF File Offset: 0x0019A8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x0019C6B8 File Offset: 0x0019A8B8
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
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryAreaTaskInfoRefreshNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004DCF RID: 19919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD0 RID: 19920
		public const int ConditionTasksFieldNumber = 6;

		// Token: 0x04004DD1 RID: 19921
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(50U, ConditionTask.Parser);

		// Token: 0x04004DD2 RID: 19922
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
