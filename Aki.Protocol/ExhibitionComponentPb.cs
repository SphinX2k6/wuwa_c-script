using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004E8 RID: 1256
	public sealed class ExhibitionComponentPb : IMessage<ExhibitionComponentPb>, IMessage, IEquatable<ExhibitionComponentPb>, IDeepCloneable<ExhibitionComponentPb>, IBufferMessage
	{
		// Token: 0x060076EF RID: 30447 RVA: 0x001229C9 File Offset: 0x00120BC9
		[NullableContext(1)]
		public static ExhibitionComponentPb Create()
		{
			return new ExhibitionComponentPb();
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x060076F0 RID: 30448 RVA: 0x001229D0 File Offset: 0x00120BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x060076F1 RID: 30449 RVA: 0x001229D3 File Offset: 0x00120BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionComponentPb.Descriptor;
			}
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x001229DA File Offset: 0x00120BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb()
		{
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x001229E2 File Offset: 0x00120BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb(ExhibitionComponentPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00122A07 File Offset: 0x00120C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb Clone()
		{
			return new ExhibitionComponentPb(this);
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x00122A0F File Offset: 0x00120C0F
		// (set) Token: 0x060076F6 RID: 30454 RVA: 0x00122A17 File Offset: 0x00120C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00122A20 File Offset: 0x00120C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionComponentPb);
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00122A2E File Offset: 0x00120C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionComponentPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00122A5C File Offset: 0x00120C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00122A9B File Offset: 0x00120C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00122AA8 File Offset: 0x00120CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00122AB1 File Offset: 0x00120CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x00122AE4 File Offset: 0x00120CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00122B22 File Offset: 0x00120D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExhibitionComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00122B53 File Offset: 0x00120D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00122B5C File Offset: 0x00120D5C
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
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E18 RID: 15896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E19 RID: 15897
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E1A RID: 15898
		private int itemId_;
	}
}
