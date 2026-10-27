using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001132 RID: 4402
	[NetMessage(EMessageId.RoverRogueTaskUpdateNotify)]
	public sealed class RoverRogueTaskUpdateNotify : IMessage<RoverRogueTaskUpdateNotify>, IMessage, IEquatable<RoverRogueTaskUpdateNotify>, IDeepCloneable<RoverRogueTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x060177B0 RID: 96176 RVA: 0x0036924F File Offset: 0x0036744F
		[NullableContext(1)]
		public static RoverRogueTaskUpdateNotify Create()
		{
			return new RoverRogueTaskUpdateNotify();
		}

		// Token: 0x17004ED1 RID: 20177
		// (get) Token: 0x060177B1 RID: 96177 RVA: 0x00369256 File Offset: 0x00367456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004ED2 RID: 20178
		// (get) Token: 0x060177B2 RID: 96178 RVA: 0x00369259 File Offset: 0x00367459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060177B3 RID: 96179 RVA: 0x00369260 File Offset: 0x00367460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify()
		{
		}

		// Token: 0x060177B4 RID: 96180 RVA: 0x00369273 File Offset: 0x00367473
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify(RoverRogueTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060177B5 RID: 96181 RVA: 0x0036929D File Offset: 0x0036749D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueTaskUpdateNotify Clone()
		{
			return new RoverRogueTaskUpdateNotify(this);
		}

		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x060177B6 RID: 96182 RVA: 0x003692A5 File Offset: 0x003674A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x060177B7 RID: 96183 RVA: 0x003692AD File Offset: 0x003674AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueTaskUpdateNotify);
		}

		// Token: 0x060177B8 RID: 96184 RVA: 0x003692BB File Offset: 0x003674BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060177B9 RID: 96185 RVA: 0x003692F0 File Offset: 0x003674F0
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

		// Token: 0x060177BA RID: 96186 RVA: 0x00369324 File Offset: 0x00367524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060177BB RID: 96187 RVA: 0x00369331 File Offset: 0x00367531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060177BC RID: 96188 RVA: 0x0036933A File Offset: 0x0036753A
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

		// Token: 0x060177BD RID: 96189 RVA: 0x00369364 File Offset: 0x00367564
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

		// Token: 0x060177BE RID: 96190 RVA: 0x0036939D File Offset: 0x0036759D
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

		// Token: 0x060177BF RID: 96191 RVA: 0x003693CB File Offset: 0x003675CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060177C0 RID: 96192 RVA: 0x003693D4 File Offset: 0x003675D4
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
					this.tasks_.AddEntriesFrom(ref input, RoverRogueTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x04008B9B RID: 35739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B9C RID: 35740
		public const int TasksFieldNumber = 12;

		// Token: 0x04008B9D RID: 35741
		private static readonly FieldCodec<ConditionTask> _repeated_tasks_codec = FieldCodec.ForMessage<ConditionTask>(98U, ConditionTask.Parser);

		// Token: 0x04008B9E RID: 35742
		private readonly RepeatedField<ConditionTask> tasks_ = new RepeatedField<ConditionTask>();
	}
}
