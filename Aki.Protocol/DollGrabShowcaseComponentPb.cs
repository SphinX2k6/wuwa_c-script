using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F6 RID: 1014
	public sealed class DollGrabShowcaseComponentPb : IMessage<DollGrabShowcaseComponentPb>, IMessage, IEquatable<DollGrabShowcaseComponentPb>, IDeepCloneable<DollGrabShowcaseComponentPb>, IBufferMessage
	{
		// Token: 0x0600621F RID: 25119 RVA: 0x000EC6A0 File Offset: 0x000EA8A0
		[NullableContext(1)]
		public static DollGrabShowcaseComponentPb Create()
		{
			return new DollGrabShowcaseComponentPb();
		}

		// Token: 0x17001249 RID: 4681
		// (get) Token: 0x06006220 RID: 25120 RVA: 0x000EC6A7 File Offset: 0x000EA8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x06006221 RID: 25121 RVA: 0x000EC6AA File Offset: 0x000EA8AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabShowcaseComponentPb.Descriptor;
			}
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x000EC6B1 File Offset: 0x000EA8B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb()
		{
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x000EC6C4 File Offset: 0x000EA8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb(DollGrabShowcaseComponentPb other) : this()
		{
			this.dollItems_ = other.dollItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x000EC6EE File Offset: 0x000EA8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabShowcaseComponentPb Clone()
		{
			return new DollGrabShowcaseComponentPb(this);
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x06006225 RID: 25125 RVA: 0x000EC6F6 File Offset: 0x000EA8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DollItems
		{
			get
			{
				return this.dollItems_;
			}
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x000EC6FE File Offset: 0x000EA8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabShowcaseComponentPb);
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x000EC70C File Offset: 0x000EA90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabShowcaseComponentPb other)
		{
			return other != null && (other == this || (this.dollItems_.Equals(other.dollItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x000EC740 File Offset: 0x000EA940
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

		// Token: 0x06006229 RID: 25129 RVA: 0x000EC774 File Offset: 0x000EA974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x000EC781 File Offset: 0x000EA981
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x000EC78A File Offset: 0x000EA98A
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

		// Token: 0x0600622C RID: 25132 RVA: 0x000EC7B4 File Offset: 0x000EA9B4
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

		// Token: 0x0600622D RID: 25133 RVA: 0x000EC7ED File Offset: 0x000EA9ED
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

		// Token: 0x0600622E RID: 25134 RVA: 0x000EC81B File Offset: 0x000EAA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x000EC824 File Offset: 0x000EAA24
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

		// Token: 0x040037C5 RID: 14277
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C6 RID: 14278
		public const int DollItemsFieldNumber = 1;

		// Token: 0x040037C7 RID: 14279
		private static readonly FieldCodec<int> _repeated_dollItems_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040037C8 RID: 14280
		private readonly RepeatedField<int> dollItems_ = new RepeatedField<int>();
	}
}
