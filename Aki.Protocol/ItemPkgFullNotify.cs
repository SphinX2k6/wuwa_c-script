using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000847 RID: 2119
	[NetMessage(EMessageId.ItemPkgFullNotify)]
	public sealed class ItemPkgFullNotify : IMessage<ItemPkgFullNotify>, IMessage, IEquatable<ItemPkgFullNotify>, IDeepCloneable<ItemPkgFullNotify>, IBufferMessage
	{
		// Token: 0x0600BD57 RID: 48471 RVA: 0x001C2629 File Offset: 0x001C0829
		[NullableContext(1)]
		public static ItemPkgFullNotify Create()
		{
			return new ItemPkgFullNotify();
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600BD58 RID: 48472 RVA: 0x001C2630 File Offset: 0x001C0830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600BD59 RID: 48473 RVA: 0x001C2633 File Offset: 0x001C0833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemPkgFullNotify.Descriptor;
			}
		}

		// Token: 0x0600BD5A RID: 48474 RVA: 0x001C263A File Offset: 0x001C083A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify()
		{
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x001C2642 File Offset: 0x001C0842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify(ItemPkgFullNotify other) : this()
		{
			this.pkgType_ = other.pkgType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x001C2667 File Offset: 0x001C0867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify Clone()
		{
			return new ItemPkgFullNotify(this);
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600BD5D RID: 48477 RVA: 0x001C266F File Offset: 0x001C086F
		// (set) Token: 0x0600BD5E RID: 48478 RVA: 0x001C2677 File Offset: 0x001C0877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PkgType
		{
			get
			{
				return this.pkgType_;
			}
			set
			{
				this.pkgType_ = value;
			}
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x001C2680 File Offset: 0x001C0880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemPkgFullNotify);
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x001C268E File Offset: 0x001C088E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemPkgFullNotify other)
		{
			return other != null && (other == this || (this.PkgType == other.PkgType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x001C26BC File Offset: 0x001C08BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PkgType != 0)
			{
				num ^= this.PkgType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x001C26FB File Offset: 0x001C08FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD63 RID: 48483 RVA: 0x001C2708 File Offset: 0x001C0908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD64 RID: 48484 RVA: 0x001C2711 File Offset: 0x001C0911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PkgType != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PkgType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD65 RID: 48485 RVA: 0x001C2744 File Offset: 0x001C0944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PkgType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PkgType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x001C2782 File Offset: 0x001C0982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemPkgFullNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PkgType != 0)
			{
				this.PkgType = other.PkgType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x001C27B3 File Offset: 0x001C09B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD68 RID: 48488 RVA: 0x001C27BC File Offset: 0x001C09BC
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PkgType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005318 RID: 21272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005319 RID: 21273
		public const int PkgTypeFieldNumber = 12;

		// Token: 0x0400531A RID: 21274
		private int pkgType_;
	}
}
