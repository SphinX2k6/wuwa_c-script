using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B8 RID: 1208
	public sealed class EntranceComponentPb : IMessage<EntranceComponentPb>, IMessage, IEquatable<EntranceComponentPb>, IDeepCloneable<EntranceComponentPb>, IBufferMessage
	{
		// Token: 0x06007366 RID: 29542 RVA: 0x0011B7A1 File Offset: 0x001199A1
		[NullableContext(1)]
		public static EntranceComponentPb Create()
		{
			return new EntranceComponentPb();
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06007367 RID: 29543 RVA: 0x0011B7A8 File Offset: 0x001199A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06007368 RID: 29544 RVA: 0x0011B7AB File Offset: 0x001199AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntranceComponentPb.Descriptor;
			}
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0011B7B2 File Offset: 0x001199B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb()
		{
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x0011B7BA File Offset: 0x001199BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb(EntranceComponentPb other) : this()
		{
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x0011B7DF File Offset: 0x001199DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceComponentPb Clone()
		{
			return new EntranceComponentPb(this);
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x0011B7E7 File Offset: 0x001199E7
		// (set) Token: 0x0600736D RID: 29549 RVA: 0x0011B7EF File Offset: 0x001199EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntranceState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x0011B7F8 File Offset: 0x001199F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntranceComponentPb);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0011B806 File Offset: 0x00119A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntranceComponentPb other)
		{
			return other != null && (other == this || (this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x0011B834 File Offset: 0x00119A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.State != EntranceState.NotUnlock)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x0011B879 File Offset: 0x00119A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x0011B886 File Offset: 0x00119A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x0011B88F File Offset: 0x00119A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.State != EntranceState.NotUnlock)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x0011B8C0 File Offset: 0x00119AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.State != EntranceState.NotUnlock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x0011B8FE File Offset: 0x00119AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntranceComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.State != EntranceState.NotUnlock)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x0011B92F File Offset: 0x00119B2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x0011B938 File Offset: 0x00119B38
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.State = (EntranceState)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D7E RID: 15742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D7F RID: 15743
		public const int StateFieldNumber = 1;

		// Token: 0x04003D80 RID: 15744
		private EntranceState state_;
	}
}
