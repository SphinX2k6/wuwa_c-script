using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A3 RID: 2211
	[NetMessage(EMessageId.KurotatoResTaskUpdateNotify)]
	public sealed class KurotatoResTaskUpdateNotify : IMessage<KurotatoResTaskUpdateNotify>, IMessage, IEquatable<KurotatoResTaskUpdateNotify>, IDeepCloneable<KurotatoResTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C497 RID: 50327 RVA: 0x001D1FF1 File Offset: 0x001D01F1
		[NullableContext(1)]
		public static KurotatoResTaskUpdateNotify Create()
		{
			return new KurotatoResTaskUpdateNotify();
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x0600C498 RID: 50328 RVA: 0x001D1FF8 File Offset: 0x001D01F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x0600C499 RID: 50329 RVA: 0x001D1FFB File Offset: 0x001D01FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoResTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x001D2002 File Offset: 0x001D0202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify()
		{
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x001D2015 File Offset: 0x001D0215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify(KurotatoResTaskUpdateNotify other) : this()
		{
			this.resTasks_ = other.resTasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x001D203F File Offset: 0x001D023F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoResTaskUpdateNotify Clone()
		{
			return new KurotatoResTaskUpdateNotify(this);
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x0600C49D RID: 50333 RVA: 0x001D2047 File Offset: 0x001D0247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ConditionTask> ResTasks
		{
			get
			{
				return this.resTasks_;
			}
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x001D204F File Offset: 0x001D024F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoResTaskUpdateNotify);
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x001D205D File Offset: 0x001D025D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoResTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.resTasks_.Equals(other.resTasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x001D2090 File Offset: 0x001D0290
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

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x001D20C4 File Offset: 0x001D02C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x001D20D1 File Offset: 0x001D02D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x001D20DA File Offset: 0x001D02DA
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

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x001D2104 File Offset: 0x001D0304
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

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x001D213D File Offset: 0x001D033D
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

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x001D216B File Offset: 0x001D036B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x001D2174 File Offset: 0x001D0374
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.resTasks_.AddEntriesFrom(ref input, KurotatoResTaskUpdateNotify._repeated_resTasks_codec);
				}
			}
		}

		// Token: 0x0400550B RID: 21771
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400550C RID: 21772
		public const int ResTasksFieldNumber = 15;

		// Token: 0x0400550D RID: 21773
		private static readonly FieldCodec<ConditionTask> _repeated_resTasks_codec = FieldCodec.ForMessage<ConditionTask>(122U, ConditionTask.Parser);

		// Token: 0x0400550E RID: 21774
		private readonly RepeatedField<ConditionTask> resTasks_ = new RepeatedField<ConditionTask>();
	}
}
