using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008B4 RID: 2228
	[NetMessage(EMessageId.KurotatoResTaskUpdateNotify)]
	public sealed class KurotatoResTaskUpdateNotify : IMessage<KurotatoResTaskUpdateNotify>, IMessage, IEquatable<KurotatoResTaskUpdateNotify>, IDeepCloneable<KurotatoResTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C5B3 RID: 50611 RVA: 0x001D42D9 File Offset: 0x001D24D9
		[NullableContext(1)]
		public static KurotatoResTaskUpdateNotify Create()
		{
			return new KurotatoResTaskUpdateNotify();
		}

		// Token: 0x170027F3 RID: 10227
		// (get) Token: 0x0600C5B4 RID: 50612 RVA: 0x001D42E0 File Offset: 0x001D24E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027F4 RID: 10228
		// (get) Token: 0x0600C5B5 RID: 50613 RVA: 0x001D42E3 File Offset: 0x001D24E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C5B6 RID: 50614 RVA: 0x001D42EA File Offset: 0x001D24EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify()
		{
		}

		// Token: 0x0600C5B7 RID: 50615 RVA: 0x001D42FD File Offset: 0x001D24FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify(KurotatoResTaskUpdateNotify other) : this()
		{
			this.resTasks_ = other.resTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C5B8 RID: 50616 RVA: 0x001D4327 File Offset: 0x001D2527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify Clone()
		{
			return new KurotatoResTaskUpdateNotify(this);
		}

		// Token: 0x170027F5 RID: 10229
		// (get) Token: 0x0600C5B9 RID: 50617 RVA: 0x001D432F File Offset: 0x001D252F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ResTasks
		{
			get
			{
				return this.resTasks_;
			}
		}

		// Token: 0x0600C5BA RID: 50618 RVA: 0x001D4337 File Offset: 0x001D2537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskUpdateNotify);
		}

		// Token: 0x0600C5BB RID: 50619 RVA: 0x001D4345 File Offset: 0x001D2545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.resTasks_.Equals(other.resTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C5BC RID: 50620 RVA: 0x001D4378 File Offset: 0x001D2578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.resTasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C5BD RID: 50621 RVA: 0x001D43AC File Offset: 0x001D25AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C5BE RID: 50622 RVA: 0x001D43B9 File Offset: 0x001D25B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x001D43C2 File Offset: 0x001D25C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.resTasks_.WriteTo(ref output, KurotatoResTaskUpdateNotify._repeated_resTasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C5C0 RID: 50624 RVA: 0x001D43EC File Offset: 0x001D25EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.resTasks_.CalculateSize(KurotatoResTaskUpdateNotify._repeated_resTasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C5C1 RID: 50625 RVA: 0x001D4425 File Offset: 0x001D2625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoResTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.resTasks_.Add(other.resTasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C5C2 RID: 50626 RVA: 0x001D4453 File Offset: 0x001D2653
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C5C3 RID: 50627 RVA: 0x001D445C File Offset: 0x001D265C
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
					this.resTasks_.AddEntriesFrom(ref input, KurotatoResTaskUpdateNotify._repeated_resTasks_codec);
				}
			}
		}

		// Token: 0x04005504 RID: 21764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005505 RID: 21765
		public const int ResTasksFieldNumber = 1;

		// Token: 0x04005506 RID: 21766
		private static readonly FieldCodec<ConditionTask> _repeated_resTasks_codec = FieldCodec.ForMessage<ConditionTask>(10U, ConditionTask.Parser);

		// Token: 0x04005507 RID: 21767
		private readonly RepeatedField<ConditionTask> resTasks_ = new RepeatedField<ConditionTask>();
	}
}
