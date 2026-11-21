using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001720 RID: 5920
	[NetMessage(EMessageId.AiBlackboardCdPush)]
	public sealed class AiBlackboardCdPush : IMessage<AiBlackboardCdPush>, IMessage, IEquatable<AiBlackboardCdPush>, IDeepCloneable<AiBlackboardCdPush>, IBufferMessage
	{
		// Token: 0x0601DB86 RID: 121734 RVA: 0x0045C316 File Offset: 0x0045A516
		[NullableContext(1)]
		public static AiBlackboardCdPush Create()
		{
			return new AiBlackboardCdPush();
		}

		// Token: 0x17006534 RID: 25908
		// (get) Token: 0x0601DB87 RID: 121735 RVA: 0x0045C31D File Offset: 0x0045A51D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006535 RID: 25909
		// (get) Token: 0x0601DB88 RID: 121736 RVA: 0x0045C320 File Offset: 0x0045A520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiBlackboardCdPush.Descriptor;
			}
		}

		// Token: 0x0601DB89 RID: 121737 RVA: 0x0045C327 File Offset: 0x0045A527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush()
		{
		}

		// Token: 0x0601DB8A RID: 121738 RVA: 0x0045C345 File Offset: 0x0045A545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush(AiBlackboardCdPush other) : this()
		{
			this.aiBlackboardCdModify_ = other.aiBlackboardCdModify_.Clone();
			this.aiBlackboardCdComplete_ = other.aiBlackboardCdComplete_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DB8B RID: 121739 RVA: 0x0045C380 File Offset: 0x0045A580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiBlackboardCdPush Clone()
		{
			return new AiBlackboardCdPush(this);
		}

		// Token: 0x17006536 RID: 25910
		// (get) Token: 0x0601DB8C RID: 121740 RVA: 0x0045C388 File Offset: 0x0045A588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Long> AiBlackboardCdModify
		{
			get
			{
				return this.aiBlackboardCdModify_;
			}
		}

		// Token: 0x17006537 RID: 25911
		// (get) Token: 0x0601DB8D RID: 121741 RVA: 0x0045C390 File Offset: 0x0045A590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Int2Bool> AiBlackboardCdComplete
		{
			get
			{
				return this.aiBlackboardCdComplete_;
			}
		}

		// Token: 0x0601DB8E RID: 121742 RVA: 0x0045C398 File Offset: 0x0045A598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiBlackboardCdPush);
		}

		// Token: 0x0601DB8F RID: 121743 RVA: 0x0045C3A8 File Offset: 0x0045A5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiBlackboardCdPush other)
		{
			return other != null && (other == this || (this.aiBlackboardCdModify_.Equals(other.aiBlackboardCdModify_) && this.aiBlackboardCdComplete_.Equals(other.aiBlackboardCdComplete_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DB90 RID: 121744 RVA: 0x0045C3FC File Offset: 0x0045A5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aiBlackboardCdModify_.GetHashCode();
			num ^= this.aiBlackboardCdComplete_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DB91 RID: 121745 RVA: 0x0045C43E File Offset: 0x0045A63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DB92 RID: 121746 RVA: 0x0045C44B File Offset: 0x0045A64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DB93 RID: 121747 RVA: 0x0045C454 File Offset: 0x0045A654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aiBlackboardCdComplete_.WriteTo(ref output, AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
			this.aiBlackboardCdModify_.WriteTo(ref output, AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DB94 RID: 121748 RVA: 0x0045C48C File Offset: 0x0045A68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aiBlackboardCdModify_.CalculateSize(AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
			num += this.aiBlackboardCdComplete_.CalculateSize(AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DB95 RID: 121749 RVA: 0x0045C4D8 File Offset: 0x0045A6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiBlackboardCdPush other)
		{
			if (other == null)
			{
				return;
			}
			this.aiBlackboardCdModify_.Add(other.aiBlackboardCdModify_);
			this.aiBlackboardCdComplete_.Add(other.aiBlackboardCdComplete_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DB96 RID: 121750 RVA: 0x0045C517 File Offset: 0x0045A717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DB97 RID: 121751 RVA: 0x0045C520 File Offset: 0x0045A720
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.aiBlackboardCdModify_.AddEntriesFrom(ref input, AiBlackboardCdPush._repeated_aiBlackboardCdModify_codec);
					}
				}
				else
				{
					this.aiBlackboardCdComplete_.AddEntriesFrom(ref input, AiBlackboardCdPush._repeated_aiBlackboardCdComplete_codec);
				}
			}
		}

		// Token: 0x0400C93B RID: 51515
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C93C RID: 51516
		public const int AiBlackboardCdModifyFieldNumber = 11;

		// Token: 0x0400C93D RID: 51517
		private static readonly FieldCodec<Int2Long> _repeated_aiBlackboardCdModify_codec = FieldCodec.ForMessage<Int2Long>(90U, Int2Long.Parser);

		// Token: 0x0400C93E RID: 51518
		private readonly RepeatedField<Int2Long> aiBlackboardCdModify_ = new RepeatedField<Int2Long>();

		// Token: 0x0400C93F RID: 51519
		public const int AiBlackboardCdCompleteFieldNumber = 5;

		// Token: 0x0400C940 RID: 51520
		private static readonly FieldCodec<Int2Bool> _repeated_aiBlackboardCdComplete_codec = FieldCodec.ForMessage<Int2Bool>(42U, Int2Bool.Parser);

		// Token: 0x0400C941 RID: 51521
		private readonly RepeatedField<Int2Bool> aiBlackboardCdComplete_ = new RepeatedField<Int2Bool>();
	}
}
