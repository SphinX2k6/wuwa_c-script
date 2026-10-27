using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF3 RID: 3315
	public sealed class PhantomPropSlot : IMessage<PhantomPropSlot>, IMessage, IEquatable<PhantomPropSlot>, IDeepCloneable<PhantomPropSlot>, IBufferMessage
	{
		// Token: 0x06011ED2 RID: 73426 RVA: 0x0029F1B3 File Offset: 0x0029D3B3
		[NullableContext(1)]
		public static PhantomPropSlot Create()
		{
			return new PhantomPropSlot();
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x06011ED3 RID: 73427 RVA: 0x0029F1BA File Offset: 0x0029D3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x06011ED4 RID: 73428 RVA: 0x0029F1BD File Offset: 0x0029D3BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomPropSlot.Descriptor;
			}
		}

		// Token: 0x06011ED5 RID: 73429 RVA: 0x0029F1C4 File Offset: 0x0029D3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot()
		{
		}

		// Token: 0x06011ED6 RID: 73430 RVA: 0x0029F1D7 File Offset: 0x0029D3D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot(PhantomPropSlot other) : this()
		{
			this.index_ = other.index_;
			this.phantomProp_ = other.phantomProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011ED7 RID: 73431 RVA: 0x0029F20D File Offset: 0x0029D40D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomPropSlot Clone()
		{
			return new PhantomPropSlot(this);
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x06011ED8 RID: 73432 RVA: 0x0029F215 File Offset: 0x0029D415
		// (set) Token: 0x06011ED9 RID: 73433 RVA: 0x0029F21D File Offset: 0x0029D41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17003B69 RID: 15209
		// (get) Token: 0x06011EDA RID: 73434 RVA: 0x0029F226 File Offset: 0x0029D426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomPropInfo> PhantomProp
		{
			get
			{
				return this.phantomProp_;
			}
		}

		// Token: 0x06011EDB RID: 73435 RVA: 0x0029F22E File Offset: 0x0029D42E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomPropSlot);
		}

		// Token: 0x06011EDC RID: 73436 RVA: 0x0029F23C File Offset: 0x0029D43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomPropSlot other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.phantomProp_.Equals(other.phantomProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011EDD RID: 73437 RVA: 0x0029F28C File Offset: 0x0029D48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.phantomProp_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011EDE RID: 73438 RVA: 0x0029F2D9 File Offset: 0x0029D4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011EDF RID: 73439 RVA: 0x0029F2E6 File Offset: 0x0029D4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011EE0 RID: 73440 RVA: 0x0029F2F0 File Offset: 0x0029D4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Index);
			}
			this.phantomProp_.WriteTo(ref output, PhantomPropSlot._repeated_phantomProp_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011EE1 RID: 73441 RVA: 0x0029F340 File Offset: 0x0029D540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.phantomProp_.CalculateSize(PhantomPropSlot._repeated_phantomProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011EE2 RID: 73442 RVA: 0x0029F394 File Offset: 0x0029D594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomPropSlot other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.phantomProp_.Add(other.phantomProp_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011EE3 RID: 73443 RVA: 0x0029F3E1 File Offset: 0x0029D5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011EE4 RID: 73444 RVA: 0x0029F3EC File Offset: 0x0029D5EC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomProp_.AddEntriesFrom(ref input, PhantomPropSlot._repeated_phantomProp_codec);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007066 RID: 28774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007067 RID: 28775
		public const int IndexFieldNumber = 1;

		// Token: 0x04007068 RID: 28776
		private int index_;

		// Token: 0x04007069 RID: 28777
		public const int PhantomPropFieldNumber = 2;

		// Token: 0x0400706A RID: 28778
		private static readonly FieldCodec<PhantomPropInfo> _repeated_phantomProp_codec = FieldCodec.ForMessage<PhantomPropInfo>(18U, PhantomPropInfo.Parser);

		// Token: 0x0400706B RID: 28779
		private readonly RepeatedField<PhantomPropInfo> phantomProp_ = new RepeatedField<PhantomPropInfo>();
	}
}
