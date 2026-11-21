using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F7 RID: 2039
	[NetMessage(EMessageId.InfrV2TreeFinishCondUpdateNotify)]
	public sealed class InfrV2TreeFinishCondUpdateNotify : IMessage<InfrV2TreeFinishCondUpdateNotify>, IMessage, IEquatable<InfrV2TreeFinishCondUpdateNotify>, IDeepCloneable<InfrV2TreeFinishCondUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600B6DE RID: 46814 RVA: 0x001B4379 File Offset: 0x001B2579
		[NullableContext(1)]
		public static InfrV2TreeFinishCondUpdateNotify Create()
		{
			return new InfrV2TreeFinishCondUpdateNotify();
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x001B4380 File Offset: 0x001B2580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x0600B6E0 RID: 46816 RVA: 0x001B4383 File Offset: 0x001B2583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TreeFinishCondUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x001B438A File Offset: 0x001B258A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify()
		{
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x001B439D File Offset: 0x001B259D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify(InfrV2TreeFinishCondUpdateNotify other) : this()
		{
			this.cond_ = other.cond_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x001B43C7 File Offset: 0x001B25C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TreeFinishCondUpdateNotify Clone()
		{
			return new InfrV2TreeFinishCondUpdateNotify(this);
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x001B43CF File Offset: 0x001B25CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Cond
		{
			get
			{
				return this.cond_;
			}
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x001B43D7 File Offset: 0x001B25D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TreeFinishCondUpdateNotify);
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x001B43E5 File Offset: 0x001B25E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TreeFinishCondUpdateNotify other)
		{
			return other != null && (other == this || (this.cond_.Equals(other.cond_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x001B4418 File Offset: 0x001B2618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cond_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x001B444C File Offset: 0x001B264C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x001B4459 File Offset: 0x001B2659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x001B4462 File Offset: 0x001B2662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cond_.WriteTo(ref output, InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x001B448C File Offset: 0x001B268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cond_.CalculateSize(InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x001B44C5 File Offset: 0x001B26C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TreeFinishCondUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.cond_.Add(other.cond_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x001B44F3 File Offset: 0x001B26F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x001B44FC File Offset: 0x001B26FC
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cond_.AddEntriesFrom(ref input, InfrV2TreeFinishCondUpdateNotify._repeated_cond_codec);
				}
			}
		}

		// Token: 0x04005127 RID: 20775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005128 RID: 20776
		public const int CondFieldNumber = 1;

		// Token: 0x04005129 RID: 20777
		private static readonly FieldCodec<int> _repeated_cond_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400512A RID: 20778
		private readonly RepeatedField<int> cond_ = new RepeatedField<int>();
	}
}
