using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012D8 RID: 4824
	[NetMessage(EMessageId.SpecialItemNotify)]
	public sealed class SpecialItemNotify : IMessage<SpecialItemNotify>, IMessage, IEquatable<SpecialItemNotify>, IDeepCloneable<SpecialItemNotify>, IBufferMessage
	{
		// Token: 0x06019BEE RID: 105454 RVA: 0x003C17A5 File Offset: 0x003BF9A5
		[NullableContext(1)]
		public static SpecialItemNotify Create()
		{
			return new SpecialItemNotify();
		}

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x06019BEF RID: 105455 RVA: 0x003C17AC File Offset: 0x003BF9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x06019BF0 RID: 105456 RVA: 0x003C17AF File Offset: 0x003BF9AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpecialItemNotify.Descriptor;
			}
		}

		// Token: 0x06019BF1 RID: 105457 RVA: 0x003C17B6 File Offset: 0x003BF9B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify()
		{
		}

		// Token: 0x06019BF2 RID: 105458 RVA: 0x003C17BE File Offset: 0x003BF9BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify(SpecialItemNotify other) : this()
		{
			this.equipItemId_ = other.equipItemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019BF3 RID: 105459 RVA: 0x003C17E3 File Offset: 0x003BF9E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpecialItemNotify Clone()
		{
			return new SpecialItemNotify(this);
		}

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x06019BF4 RID: 105460 RVA: 0x003C17EB File Offset: 0x003BF9EB
		// (set) Token: 0x06019BF5 RID: 105461 RVA: 0x003C17F3 File Offset: 0x003BF9F3
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

		// Token: 0x06019BF6 RID: 105462 RVA: 0x003C17FC File Offset: 0x003BF9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpecialItemNotify);
		}

		// Token: 0x06019BF7 RID: 105463 RVA: 0x003C180A File Offset: 0x003BFA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpecialItemNotify other)
		{
			return other != null && (other == this || (this.EquipItemId == other.EquipItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019BF8 RID: 105464 RVA: 0x003C1838 File Offset: 0x003BFA38
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

		// Token: 0x06019BF9 RID: 105465 RVA: 0x003C1877 File Offset: 0x003BFA77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019BFA RID: 105466 RVA: 0x003C1884 File Offset: 0x003BFA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019BFB RID: 105467 RVA: 0x003C188D File Offset: 0x003BFA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EquipItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EquipItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019BFC RID: 105468 RVA: 0x003C18C0 File Offset: 0x003BFAC0
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

		// Token: 0x06019BFD RID: 105469 RVA: 0x003C18FE File Offset: 0x003BFAFE
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

		// Token: 0x06019BFE RID: 105470 RVA: 0x003C192F File Offset: 0x003BFB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019BFF RID: 105471 RVA: 0x003C1938 File Offset: 0x003BFB38
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EquipItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040097FF RID: 38911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009800 RID: 38912
		public const int EquipItemIdFieldNumber = 5;

		// Token: 0x04009801 RID: 38913
		private int equipItemId_;
	}
}
