using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002F4 RID: 756
	[NetMessage(EMessageId.ContextIdNotify)]
	public sealed class ContextIdNotify : IMessage<ContextIdNotify>, IMessage, IEquatable<ContextIdNotify>, IDeepCloneable<ContextIdNotify>, IBufferMessage
	{
		// Token: 0x06004CE4 RID: 19684 RVA: 0x000BB67D File Offset: 0x000B987D
		[NullableContext(1)]
		public static ContextIdNotify Create()
		{
			return new ContextIdNotify();
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x000BB684 File Offset: 0x000B9884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x000BB687 File Offset: 0x000B9887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContextIdNotify.Descriptor;
			}
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x000BB68E File Offset: 0x000B988E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify()
		{
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x000BB696 File Offset: 0x000B9896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify(ContextIdNotify other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x000BB6BB File Offset: 0x000B98BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ContextIdNotify Clone()
		{
			return new ContextIdNotify(this);
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x000BB6C3 File Offset: 0x000B98C3
		// (set) Token: 0x06004CEB RID: 19691 RVA: 0x000BB6CB File Offset: 0x000B98CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x000BB6D4 File Offset: 0x000B98D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContextIdNotify);
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x000BB6E2 File Offset: 0x000B98E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ContextIdNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x000BB710 File Offset: 0x000B9910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x000BB74F File Offset: 0x000B994F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x000BB75C File Offset: 0x000B995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x000BB765 File Offset: 0x000B9965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x000BB798 File Offset: 0x000B9998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x000BB7D6 File Offset: 0x000B99D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ContextIdNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x000BB807 File Offset: 0x000B9A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x000BB810 File Offset: 0x000B9A10
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003176 RID: 12662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003177 RID: 12663
		public const int IdFieldNumber = 4;

		// Token: 0x04003178 RID: 12664
		private long id_;
	}
}
