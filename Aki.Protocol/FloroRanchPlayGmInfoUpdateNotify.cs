using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C0 RID: 1472
	[NetMessage(EMessageId.FloroRanchPlayGmInfoUpdateNotify)]
	public sealed class FloroRanchPlayGmInfoUpdateNotify : IMessage<FloroRanchPlayGmInfoUpdateNotify>, IMessage, IEquatable<FloroRanchPlayGmInfoUpdateNotify>, IDeepCloneable<FloroRanchPlayGmInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x060087F9 RID: 34809 RVA: 0x0014733E File Offset: 0x0014553E
		[NullableContext(1)]
		public static FloroRanchPlayGmInfoUpdateNotify Create()
		{
			return new FloroRanchPlayGmInfoUpdateNotify();
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060087FA RID: 34810 RVA: 0x00147345 File Offset: 0x00145545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060087FB RID: 34811 RVA: 0x00147348 File Offset: 0x00145548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGmInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060087FC RID: 34812 RVA: 0x0014734F File Offset: 0x0014554F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify()
		{
		}

		// Token: 0x060087FD RID: 34813 RVA: 0x00147362 File Offset: 0x00145562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify(FloroRanchPlayGmInfoUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087FE RID: 34814 RVA: 0x0014738C File Offset: 0x0014558C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify Clone()
		{
			return new FloroRanchPlayGmInfoUpdateNotify(this);
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060087FF RID: 34815 RVA: 0x00147394 File Offset: 0x00145594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008800 RID: 34816 RVA: 0x0014739C File Offset: 0x0014559C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGmInfoUpdateNotify);
		}

		// Token: 0x06008801 RID: 34817 RVA: 0x001473AA File Offset: 0x001455AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGmInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008802 RID: 34818 RVA: 0x001473E0 File Offset: 0x001455E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008803 RID: 34819 RVA: 0x00147414 File Offset: 0x00145614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008804 RID: 34820 RVA: 0x00147421 File Offset: 0x00145621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008805 RID: 34821 RVA: 0x0014742A File Offset: 0x0014562A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, FloroRanchPlayGmInfoUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x00147454 File Offset: 0x00145654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.task_.CalculateSize(FloroRanchPlayGmInfoUpdateNotify._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x0014748D File Offset: 0x0014568D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGmInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x001474BB File Offset: 0x001456BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x001474C4 File Offset: 0x001456C4
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.task_.AddEntriesFrom(ref input, FloroRanchPlayGmInfoUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x040042EF RID: 17135
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042F0 RID: 17136
		public const int TaskFieldNumber = 5;

		// Token: 0x040042F1 RID: 17137
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(42U, FloroRanchPlayTask.Parser);

		// Token: 0x040042F2 RID: 17138
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
