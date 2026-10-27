using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000799 RID: 1945
	[NetMessage(EMessageId.HonamiStoryResidentTaskInfoUpdateNotify)]
	public sealed class HonamiStoryResidentTaskInfoUpdateNotify : IMessage<HonamiStoryResidentTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryResidentTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryResidentTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AF73 RID: 44915 RVA: 0x001A521C File Offset: 0x001A341C
		[NullableContext(1)]
		public static HonamiStoryResidentTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryResidentTaskInfoUpdateNotify();
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x0600AF74 RID: 44916 RVA: 0x001A5223 File Offset: 0x001A3423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x0600AF75 RID: 44917 RVA: 0x001A5226 File Offset: 0x001A3426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryResidentTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AF76 RID: 44918 RVA: 0x001A522D File Offset: 0x001A342D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600AF77 RID: 44919 RVA: 0x001A5240 File Offset: 0x001A3440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify(HonamiStoryResidentTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF78 RID: 44920 RVA: 0x001A526A File Offset: 0x001A346A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryResidentTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryResidentTaskInfoUpdateNotify(this);
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0600AF79 RID: 44921 RVA: 0x001A5272 File Offset: 0x001A3472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600AF7A RID: 44922 RVA: 0x001A527A File Offset: 0x001A347A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryResidentTaskInfoUpdateNotify);
		}

		// Token: 0x0600AF7B RID: 44923 RVA: 0x001A5288 File Offset: 0x001A3488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryResidentTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF7C RID: 44924 RVA: 0x001A52BC File Offset: 0x001A34BC
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

		// Token: 0x0600AF7D RID: 44925 RVA: 0x001A52F0 File Offset: 0x001A34F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF7E RID: 44926 RVA: 0x001A52FD File Offset: 0x001A34FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF7F RID: 44927 RVA: 0x001A5306 File Offset: 0x001A3506
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF80 RID: 44928 RVA: 0x001A5330 File Offset: 0x001A3530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF81 RID: 44929 RVA: 0x001A5369 File Offset: 0x001A3569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryResidentTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF82 RID: 44930 RVA: 0x001A5397 File Offset: 0x001A3597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF83 RID: 44931 RVA: 0x001A53A0 File Offset: 0x001A35A0
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryResidentTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004EFB RID: 20219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EFC RID: 20220
		public const int ConditionTasksFieldNumber = 4;

		// Token: 0x04004EFD RID: 20221
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(34U, ConditionTask.Parser);

		// Token: 0x04004EFE RID: 20222
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
