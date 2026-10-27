using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001269 RID: 4713
	[NetMessage(EMessageId.SpecialItemNotify)]
	public sealed class SpecialItemNotify : IMessage<SpecialItemNotify>, IMessage, IEquatable<SpecialItemNotify>, IDeepCloneable<SpecialItemNotify>, IBufferMessage
	{
		// Token: 0x060191B8 RID: 102840 RVA: 0x003A7061 File Offset: 0x003A5261
		[NullableContext(1)]
		public static SpecialItemNotify Create()
		{
			return new SpecialItemNotify();
		}

		// Token: 0x170054AF RID: 21679
		// (get) Token: 0x060191B9 RID: 102841 RVA: 0x003A7068 File Offset: 0x003A5268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B0 RID: 21680
		// (get) Token: 0x060191BA RID: 102842 RVA: 0x003A706B File Offset: 0x003A526B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemNotify.Descriptor;
			}
		}

		// Token: 0x060191BB RID: 102843 RVA: 0x003A7072 File Offset: 0x003A5272
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify()
		{
		}

		// Token: 0x060191BC RID: 102844 RVA: 0x003A707A File Offset: 0x003A527A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify(SpecialItemNotify other) : this()
		{
			this.equipItemId_ = other.equipItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191BD RID: 102845 RVA: 0x003A709F File Offset: 0x003A529F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify Clone()
		{
			return new SpecialItemNotify(this);
		}

		// Token: 0x170054B1 RID: 21681
		// (get) Token: 0x060191BE RID: 102846 RVA: 0x003A70A7 File Offset: 0x003A52A7
		// (set) Token: 0x060191BF RID: 102847 RVA: 0x003A70AF File Offset: 0x003A52AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EquipItemId
		{
			get
			{
				return this.equipItemId_;
			}
			set
			{
				this.equipItemId_ = value;
			}
		}

		// Token: 0x060191C0 RID: 102848 RVA: 0x003A70B8 File Offset: 0x003A52B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemNotify);
		}

		// Token: 0x060191C1 RID: 102849 RVA: 0x003A70C6 File Offset: 0x003A52C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemNotify other)
		{
			return other != null && (other == this || (this.EquipItemId == other.EquipItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191C2 RID: 102850 RVA: 0x003A70F4 File Offset: 0x003A52F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EquipItemId != 0)
			{
				num ^= this.EquipItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060191C3 RID: 102851 RVA: 0x003A7133 File Offset: 0x003A5333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191C4 RID: 102852 RVA: 0x003A7140 File Offset: 0x003A5340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191C5 RID: 102853 RVA: 0x003A7149 File Offset: 0x003A5349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipItemId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EquipItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060191C6 RID: 102854 RVA: 0x003A717C File Offset: 0x003A537C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EquipItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EquipItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060191C7 RID: 102855 RVA: 0x003A71BA File Offset: 0x003A53BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpecialItemNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EquipItemId != 0)
			{
				this.EquipItemId = other.EquipItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060191C8 RID: 102856 RVA: 0x003A71EB File Offset: 0x003A53EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060191C9 RID: 102857 RVA: 0x003A71F4 File Offset: 0x003A53F4
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EquipItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093D5 RID: 37845
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093D6 RID: 37846
		public const int EquipItemIdFieldNumber = 10;

		// Token: 0x040093D7 RID: 37847
		private int equipItemId_;
	}
}
