using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DF RID: 991
	public sealed class DollGrabShowcaseComponentPb : IMessage<DollGrabShowcaseComponentPb>, IMessage, IEquatable<DollGrabShowcaseComponentPb>, IDeepCloneable<DollGrabShowcaseComponentPb>, IBufferMessage
	{
		// Token: 0x0600608F RID: 24719 RVA: 0x000E9520 File Offset: 0x000E7720
		[NullableContext(1)]
		public static DollGrabShowcaseComponentPb Create()
		{
			return new DollGrabShowcaseComponentPb();
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x06006090 RID: 24720 RVA: 0x000E9527 File Offset: 0x000E7727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x000E952A File Offset: 0x000E772A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabShowcaseComponentPb.Descriptor;
			}
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x000E9531 File Offset: 0x000E7731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb()
		{
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x000E9544 File Offset: 0x000E7744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb(DollGrabShowcaseComponentPb other) : this()
		{
			this.dollItems_ = other.dollItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x000E956E File Offset: 0x000E776E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb Clone()
		{
			return new DollGrabShowcaseComponentPb(this);
		}

		// Token: 0x170011F6 RID: 4598
		// (get) Token: 0x06006095 RID: 24725 RVA: 0x000E9576 File Offset: 0x000E7776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DollItems
		{
			get
			{
				return this.dollItems_;
			}
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x000E957E File Offset: 0x000E777E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabShowcaseComponentPb);
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x000E958C File Offset: 0x000E778C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabShowcaseComponentPb other)
		{
			return other != null && (other == this || (this.dollItems_.Equals(other.dollItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x000E95C0 File Offset: 0x000E77C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dollItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x000E95F4 File Offset: 0x000E77F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x000E9601 File Offset: 0x000E7801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x000E960A File Offset: 0x000E780A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dollItems_.WriteTo(ref output, DollGrabShowcaseComponentPb._repeated_dollItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x000E9634 File Offset: 0x000E7834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dollItems_.CalculateSize(DollGrabShowcaseComponentPb._repeated_dollItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x000E966D File Offset: 0x000E786D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabShowcaseComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			this.dollItems_.Add(other.dollItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x000E969B File Offset: 0x000E789B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x000E96A4 File Offset: 0x000E78A4
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
					this.dollItems_.AddEntriesFrom(ref input, DollGrabShowcaseComponentPb._repeated_dollItems_codec);
				}
			}
		}

		// Token: 0x040037B2 RID: 14258
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037B3 RID: 14259
		public const int DollItemsFieldNumber = 1;

		// Token: 0x040037B4 RID: 14260
		private static readonly FieldCodec<int> _repeated_dollItems_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040037B5 RID: 14261
		private readonly RepeatedField<int> dollItems_ = new RepeatedField<int>();
	}
}
