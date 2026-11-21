using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000774 RID: 1908
	[NetMessage(EMessageId.HonamiStoryLimitTaskInfoUpdateNotify)]
	public sealed class HonamiStoryLimitTaskInfoUpdateNotify : IMessage<HonamiStoryLimitTaskInfoUpdateNotify>, IMessage, IEquatable<HonamiStoryLimitTaskInfoUpdateNotify>, IDeepCloneable<HonamiStoryLimitTaskInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600ACCF RID: 44239 RVA: 0x0019FDC1 File Offset: 0x0019DFC1
		[NullableContext(1)]
		public static HonamiStoryLimitTaskInfoUpdateNotify Create()
		{
			return new HonamiStoryLimitTaskInfoUpdateNotify();
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600ACD0 RID: 44240 RVA: 0x0019FDC8 File Offset: 0x0019DFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600ACD1 RID: 44241 RVA: 0x0019FDCB File Offset: 0x0019DFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryLimitTaskInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x0019FDD2 File Offset: 0x0019DFD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify()
		{
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x0019FDE5 File Offset: 0x0019DFE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify(HonamiStoryLimitTaskInfoUpdateNotify other) : this()
		{
			this.conditionTasks_ = other.conditionTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x0019FE0F File Offset: 0x0019E00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryLimitTaskInfoUpdateNotify Clone()
		{
			return new HonamiStoryLimitTaskInfoUpdateNotify(this);
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0600ACD5 RID: 44245 RVA: 0x0019FE17 File Offset: 0x0019E017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ConditionTasks
		{
			get
			{
				return this.conditionTasks_;
			}
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x0019FE1F File Offset: 0x0019E01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryLimitTaskInfoUpdateNotify);
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x0019FE2D File Offset: 0x0019E02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryLimitTaskInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.conditionTasks_.Equals(other.conditionTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x0019FE60 File Offset: 0x0019E060
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

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x0019FE94 File Offset: 0x0019E094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x0019FEA1 File Offset: 0x0019E0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x0019FEAA File Offset: 0x0019E0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.conditionTasks_.WriteTo(ref output, HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x0019FED4 File Offset: 0x0019E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.conditionTasks_.CalculateSize(HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x0019FF0D File Offset: 0x0019E10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryLimitTaskInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.conditionTasks_.Add(other.conditionTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x0019FF3B File Offset: 0x0019E13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x0019FF44 File Offset: 0x0019E144
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.conditionTasks_.AddEntriesFrom(ref input, HonamiStoryLimitTaskInfoUpdateNotify._repeated_conditionTasks_codec);
				}
			}
		}

		// Token: 0x04004E9F RID: 20127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA0 RID: 20128
		public const int ConditionTasksFieldNumber = 7;

		// Token: 0x04004EA1 RID: 20129
		private static readonly FieldCodec<ConditionTask> _repeated_conditionTasks_codec = FieldCodec.ForMessage<ConditionTask>(58U, ConditionTask.Parser);

		// Token: 0x04004EA2 RID: 20130
		private readonly RepeatedField<ConditionTask> conditionTasks_ = new RepeatedField<ConditionTask>();
	}
}
