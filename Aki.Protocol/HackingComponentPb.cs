using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000732 RID: 1842
	public sealed class HackingComponentPb : IMessage<HackingComponentPb>, IMessage, IEquatable<HackingComponentPb>, IDeepCloneable<HackingComponentPb>, IBufferMessage
	{
		// Token: 0x0600A714 RID: 42772 RVA: 0x00192526 File Offset: 0x00190726
		[NullableContext(1)]
		public static HackingComponentPb Create()
		{
			return new HackingComponentPb();
		}

		// Token: 0x17002197 RID: 8599
		// (get) Token: 0x0600A715 RID: 42773 RVA: 0x0019252D File Offset: 0x0019072D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002198 RID: 8600
		// (get) Token: 0x0600A716 RID: 42774 RVA: 0x00192530 File Offset: 0x00190730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HackingComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x00192537 File Offset: 0x00190737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb()
		{
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x0019254A File Offset: 0x0019074A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb(HackingComponentPb other) : this()
		{
			this.entityIds_ = other.entityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x00192574 File Offset: 0x00190774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackingComponentPb Clone()
		{
			return new HackingComponentPb(this);
		}

		// Token: 0x17002199 RID: 8601
		// (get) Token: 0x0600A71A RID: 42778 RVA: 0x0019257C File Offset: 0x0019077C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityIds
		{
			get
			{
				return this.entityIds_;
			}
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x00192584 File Offset: 0x00190784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HackingComponentPb);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x00192592 File Offset: 0x00190792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HackingComponentPb other)
		{
			return other != null && (other == this || (this.entityIds_.Equals(other.entityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x001925C8 File Offset: 0x001907C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x001925FC File Offset: 0x001907FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x00192609 File Offset: 0x00190809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x00192612 File Offset: 0x00190812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIds_.WriteTo(ref output, HackingComponentPb._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x0019263C File Offset: 0x0019083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIds_.CalculateSize(HackingComponentPb._repeated_entityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x00192675 File Offset: 0x00190875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HackingComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIds_.Add(other.entityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x001926A3 File Offset: 0x001908A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x001926AC File Offset: 0x001908AC
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
					this.entityIds_.AddEntriesFrom(ref input, HackingComponentPb._repeated_entityIds_codec);
				}
			}
		}

		// Token: 0x04004C75 RID: 19573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C76 RID: 19574
		public const int EntityIdsFieldNumber = 1;

		// Token: 0x04004C77 RID: 19575
		private static readonly FieldCodec<long> _repeated_entityIds_codec = FieldCodec.ForInt64(10U);

		// Token: 0x04004C78 RID: 19576
		private readonly RepeatedField<long> entityIds_ = new RepeatedField<long>();
	}
}
