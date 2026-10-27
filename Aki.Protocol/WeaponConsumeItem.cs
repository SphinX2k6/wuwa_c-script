using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EC RID: 5356
	public sealed class WeaponConsumeItem : IMessage<WeaponConsumeItem>, IMessage, IEquatable<WeaponConsumeItem>, IDeepCloneable<WeaponConsumeItem>, IBufferMessage
	{
		// Token: 0x0601C50F RID: 115983 RVA: 0x00417607 File Offset: 0x00415807
		[NullableContext(1)]
		public static WeaponConsumeItem Create()
		{
			return new WeaponConsumeItem();
		}

		// Token: 0x17005F74 RID: 24436
		// (get) Token: 0x0601C510 RID: 115984 RVA: 0x0041760E File Offset: 0x0041580E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponConsumeItem> Parser
		{
			get
			{
				return WeaponConsumeItem._parser;
			}
		}

		// Token: 0x17005F75 RID: 24437
		// (get) Token: 0x0601C511 RID: 115985 RVA: 0x00417615 File Offset: 0x00415815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x0601C512 RID: 115986 RVA: 0x00417618 File Offset: 0x00415818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponConsumeItem.Descriptor;
			}
		}

		// Token: 0x0601C513 RID: 115987 RVA: 0x0041761F File Offset: 0x0041581F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem()
		{
		}

		// Token: 0x0601C514 RID: 115988 RVA: 0x00417627 File Offset: 0x00415827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem(WeaponConsumeItem other) : this()
		{
			this.incId_ = other.incId_;
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C515 RID: 115989 RVA: 0x00417664 File Offset: 0x00415864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem Clone()
		{
			return new WeaponConsumeItem(this);
		}

		// Token: 0x17005F77 RID: 24439
		// (get) Token: 0x0601C516 RID: 115990 RVA: 0x0041766C File Offset: 0x0041586C
		// (set) Token: 0x0601C517 RID: 115991 RVA: 0x00417674 File Offset: 0x00415874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005F78 RID: 24440
		// (get) Token: 0x0601C518 RID: 115992 RVA: 0x0041767D File Offset: 0x0041587D
		// (set) Token: 0x0601C519 RID: 115993 RVA: 0x00417685 File Offset: 0x00415885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17005F79 RID: 24441
		// (get) Token: 0x0601C51A RID: 115994 RVA: 0x0041768E File Offset: 0x0041588E
		// (set) Token: 0x0601C51B RID: 115995 RVA: 0x00417696 File Offset: 0x00415896
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

		// Token: 0x0601C51C RID: 115996 RVA: 0x0041769F File Offset: 0x0041589F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponConsumeItem);
		}

		// Token: 0x0601C51D RID: 115997 RVA: 0x004176B0 File Offset: 0x004158B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponConsumeItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C51E RID: 115998 RVA: 0x0041770C File Offset: 0x0041590C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
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

		// Token: 0x0601C51F RID: 115999 RVA: 0x0041777D File Offset: 0x0041597D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C520 RID: 116000 RVA: 0x0041778A File Offset: 0x0041598A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C521 RID: 116001 RVA: 0x00417794 File Offset: 0x00415994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.IncId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C522 RID: 116002 RVA: 0x00417808 File Offset: 0x00415A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
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

		// Token: 0x0601C523 RID: 116003 RVA: 0x00417878 File Offset: 0x00415A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponConsumeItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C524 RID: 116004 RVA: 0x004178DC File Offset: 0x00415ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C525 RID: 116005 RVA: 0x004178E8 File Offset: 0x00415AE8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A23C RID: 41532
		private static readonly MessageParser<WeaponConsumeItem> _parser = new MessageParser<WeaponConsumeItem>(() => new WeaponConsumeItem());

		// Token: 0x0400A23D RID: 41533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A23E RID: 41534
		public const int IncIdFieldNumber = 1;

		// Token: 0x0400A23F RID: 41535
		private int incId_;

		// Token: 0x0400A240 RID: 41536
		public const int CountFieldNumber = 2;

		// Token: 0x0400A241 RID: 41537
		private int count_;

		// Token: 0x0400A242 RID: 41538
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400A243 RID: 41539
		private int itemId_;
	}
}
