using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001562 RID: 5474
	public sealed class WeaponConsumeItem : IMessage<WeaponConsumeItem>, IMessage, IEquatable<WeaponConsumeItem>, IDeepCloneable<WeaponConsumeItem>, IBufferMessage
	{
		// Token: 0x0601CFD6 RID: 118742 RVA: 0x004330C3 File Offset: 0x004312C3
		[NullableContext(1)]
		public static WeaponConsumeItem Create()
		{
			return new WeaponConsumeItem();
		}

		// Token: 0x17006215 RID: 25109
		// (get) Token: 0x0601CFD7 RID: 118743 RVA: 0x004330CA File Offset: 0x004312CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponConsumeItem> Parser
		{
			get
			{
				return WeaponConsumeItem._parser;
			}
		}

		// Token: 0x17006216 RID: 25110
		// (get) Token: 0x0601CFD8 RID: 118744 RVA: 0x004330D1 File Offset: 0x004312D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006217 RID: 25111
		// (get) Token: 0x0601CFD9 RID: 118745 RVA: 0x004330D4 File Offset: 0x004312D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponConsumeItem.Descriptor;
			}
		}

		// Token: 0x0601CFDA RID: 118746 RVA: 0x004330DB File Offset: 0x004312DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem()
		{
		}

		// Token: 0x0601CFDB RID: 118747 RVA: 0x004330E3 File Offset: 0x004312E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem(WeaponConsumeItem other) : this()
		{
			this.incId_ = other.incId_;
			this.count_ = other.count_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFDC RID: 118748 RVA: 0x00433120 File Offset: 0x00431320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponConsumeItem Clone()
		{
			return new WeaponConsumeItem(this);
		}

		// Token: 0x17006218 RID: 25112
		// (get) Token: 0x0601CFDD RID: 118749 RVA: 0x00433128 File Offset: 0x00431328
		// (set) Token: 0x0601CFDE RID: 118750 RVA: 0x00433130 File Offset: 0x00431330
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

		// Token: 0x17006219 RID: 25113
		// (get) Token: 0x0601CFDF RID: 118751 RVA: 0x00433139 File Offset: 0x00431339
		// (set) Token: 0x0601CFE0 RID: 118752 RVA: 0x00433141 File Offset: 0x00431341
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

		// Token: 0x1700621A RID: 25114
		// (get) Token: 0x0601CFE1 RID: 118753 RVA: 0x0043314A File Offset: 0x0043134A
		// (set) Token: 0x0601CFE2 RID: 118754 RVA: 0x00433152 File Offset: 0x00431352
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

		// Token: 0x0601CFE3 RID: 118755 RVA: 0x0043315B File Offset: 0x0043135B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponConsumeItem);
		}

		// Token: 0x0601CFE4 RID: 118756 RVA: 0x0043316C File Offset: 0x0043136C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponConsumeItem other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && this.Count == other.Count && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFE5 RID: 118757 RVA: 0x004331C8 File Offset: 0x004313C8
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

		// Token: 0x0601CFE6 RID: 118758 RVA: 0x00433239 File Offset: 0x00431439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFE7 RID: 118759 RVA: 0x00433246 File Offset: 0x00431446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFE8 RID: 118760 RVA: 0x00433250 File Offset: 0x00431450
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

		// Token: 0x0601CFE9 RID: 118761 RVA: 0x004332C4 File Offset: 0x004314C4
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

		// Token: 0x0601CFEA RID: 118762 RVA: 0x00433334 File Offset: 0x00431534
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

		// Token: 0x0601CFEB RID: 118763 RVA: 0x00433398 File Offset: 0x00431598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFEC RID: 118764 RVA: 0x004333A4 File Offset: 0x004315A4
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

		// Token: 0x0400A695 RID: 42645
		private static readonly MessageParser<WeaponConsumeItem> _parser = new MessageParser<WeaponConsumeItem>(() => new WeaponConsumeItem());

		// Token: 0x0400A696 RID: 42646
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A697 RID: 42647
		public const int IncIdFieldNumber = 1;

		// Token: 0x0400A698 RID: 42648
		private int incId_;

		// Token: 0x0400A699 RID: 42649
		public const int CountFieldNumber = 2;

		// Token: 0x0400A69A RID: 42650
		private int count_;

		// Token: 0x0400A69B RID: 42651
		public const int ItemIdFieldNumber = 3;

		// Token: 0x0400A69C RID: 42652
		private int itemId_;
	}
}
