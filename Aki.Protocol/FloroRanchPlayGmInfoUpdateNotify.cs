using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005AB RID: 1451
	[NetMessage(EMessageId.FloroRanchPlayGmInfoUpdateNotify)]
	public sealed class FloroRanchPlayGmInfoUpdateNotify : IMessage<FloroRanchPlayGmInfoUpdateNotify>, IMessage, IEquatable<FloroRanchPlayGmInfoUpdateNotify>, IDeepCloneable<FloroRanchPlayGmInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008691 RID: 34449 RVA: 0x00144726 File Offset: 0x00142926
		[NullableContext(1)]
		public static FloroRanchPlayGmInfoUpdateNotify Create()
		{
			return new FloroRanchPlayGmInfoUpdateNotify();
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06008692 RID: 34450 RVA: 0x0014472D File Offset: 0x0014292D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06008693 RID: 34451 RVA: 0x00144730 File Offset: 0x00142930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGmInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x00144737 File Offset: 0x00142937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify()
		{
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x0014474A File Offset: 0x0014294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify(FloroRanchPlayGmInfoUpdateNotify other) : this()
		{
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x00144774 File Offset: 0x00142974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGmInfoUpdateNotify Clone()
		{
			return new FloroRanchPlayGmInfoUpdateNotify(this);
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06008697 RID: 34455 RVA: 0x0014477C File Offset: 0x0014297C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x00144784 File Offset: 0x00142984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGmInfoUpdateNotify);
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x00144792 File Offset: 0x00142992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGmInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x001447C8 File Offset: 0x001429C8
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

		// Token: 0x0600869B RID: 34459 RVA: 0x001447FC File Offset: 0x001429FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x00144809 File Offset: 0x00142A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x00144812 File Offset: 0x00142A12
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

		// Token: 0x0600869E RID: 34462 RVA: 0x0014483C File Offset: 0x00142A3C
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

		// Token: 0x0600869F RID: 34463 RVA: 0x00144875 File Offset: 0x00142A75
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

		// Token: 0x060086A0 RID: 34464 RVA: 0x001448A3 File Offset: 0x00142AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086A1 RID: 34465 RVA: 0x001448AC File Offset: 0x00142AAC
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
					this.task_.AddEntriesFrom(ref input, FloroRanchPlayGmInfoUpdateNotify._repeated_task_codec);
				}
			}
		}

		// Token: 0x040042E5 RID: 17125
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042E6 RID: 17126
		public const int TaskFieldNumber = 9;

		// Token: 0x040042E7 RID: 17127
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(74U, FloroRanchPlayTask.Parser);

		// Token: 0x040042E8 RID: 17128
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
