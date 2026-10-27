using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000767 RID: 1895
	[NetMessage(EMessageId.HonamiStoryAreaTaskInfoUpdateNotify)]
	public sealed class HonamiStoryAreaTaskInfoUpdateNotify : IMessage<HonamiStoryAreaTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryAreaTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryAreaTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AB6F RID: 43887 RVA: 0x0019C715 File Offset: 0x0019A915
		[NullableContext(1)]
		public static HonamiStoryAreaTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryAreaTaskInfoUpdateNotify();
		}

		// Token: 0x1700228C RID: 8844
		// (get) Token: 0x0600AB70 RID: 43888 RVA: 0x0019C71C File Offset: 0x0019A91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700228D RID: 8845
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x0019C71F File Offset: 0x0019A91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x0019C726 File Offset: 0x0019A926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x0019C739 File Offset: 0x0019A939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify(HonamiStoryAreaTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB74 RID: 43892 RVA: 0x0019C763 File Offset: 0x0019A963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryAreaTaskInfoUpdateNotify(this);
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x0600AB75 RID: 43893 RVA: 0x0019C76B File Offset: 0x0019A96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x0019C773 File Offset: 0x0019A973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaTaskInfoUpdateNotify);
		}

		// Token: 0x0600AB77 RID: 43895 RVA: 0x0019C781 File Offset: 0x0019A981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x0019C7B4 File Offset: 0x0019A9B4
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

		// Token: 0x0600AB79 RID: 43897 RVA: 0x0019C7E8 File Offset: 0x0019A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x0019C7F5 File Offset: 0x0019A9F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x0019C7FE File Offset: 0x0019A9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x0019C828 File Offset: 0x0019AA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x0019C861 File Offset: 0x0019AA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x0019C88F File Offset: 0x0019AA8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x0019C898 File Offset: 0x0019AA98
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
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryAreaTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004DD3 RID: 19923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DD4 RID: 19924
		public const int ConditionTasksFieldNumber = 1;

		// Token: 0x04004DD5 RID: 19925
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04004DD6 RID: 19926
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
