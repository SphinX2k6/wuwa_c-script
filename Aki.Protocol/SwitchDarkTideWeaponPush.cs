using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FD RID: 4861
	[NetMessage(EMessageId.SwitchDarkTideWeaponPush)]
	public sealed class SwitchDarkTideWeaponPush : IMessage<SwitchDarkTideWeaponPush>, IMessage, IEquatable<SwitchDarkTideWeaponPush>, IDeepCloneable<SwitchDarkTideWeaponPush>, IBufferMessage
	{
		// Token: 0x06019D7A RID: 105850 RVA: 0x003C1608 File Offset: 0x003BF808
		[NullableContext(1)]
		public static SwitchDarkTideWeaponPush Create()
		{
			return new SwitchDarkTideWeaponPush();
		}

		// Token: 0x17005727 RID: 22311
		// (get) Token: 0x06019D7B RID: 105851 RVA: 0x003C160F File Offset: 0x003BF80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005728 RID: 22312
		// (get) Token: 0x06019D7C RID: 105852 RVA: 0x003C1612 File Offset: 0x003BF812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchDarkTideWeaponPush.Descriptor;
			}
		}

		// Token: 0x06019D7D RID: 105853 RVA: 0x003C1619 File Offset: 0x003BF819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponPush()
		{
		}

		// Token: 0x06019D7E RID: 105854 RVA: 0x003C1621 File Offset: 0x003BF821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponPush(SwitchDarkTideWeaponPush other) : this()
		{
			this.newSlotIndex_ = other.newSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D7F RID: 105855 RVA: 0x003C1646 File Offset: 0x003BF846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponPush Clone()
		{
			return new SwitchDarkTideWeaponPush(this);
		}

		// Token: 0x17005729 RID: 22313
		// (get) Token: 0x06019D80 RID: 105856 RVA: 0x003C164E File Offset: 0x003BF84E
		// (set) Token: 0x06019D81 RID: 105857 RVA: 0x003C1656 File Offset: 0x003BF856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewSlotIndex
		{
			get
			{
				return this.newSlotIndex_;
			}
			set
			{
				this.newSlotIndex_ = value;
			}
		}

		// Token: 0x06019D82 RID: 105858 RVA: 0x003C165F File Offset: 0x003BF85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchDarkTideWeaponPush);
		}

		// Token: 0x06019D83 RID: 105859 RVA: 0x003C166D File Offset: 0x003BF86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchDarkTideWeaponPush other)
		{
			return other != null && (other == this || (this.NewSlotIndex == other.NewSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D84 RID: 105860 RVA: 0x003C169C File Offset: 0x003BF89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NewSlotIndex != 0)
			{
				num ^= this.NewSlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D85 RID: 105861 RVA: 0x003C16DB File Offset: 0x003BF8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D86 RID: 105862 RVA: 0x003C16E8 File Offset: 0x003BF8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D87 RID: 105863 RVA: 0x003C16F1 File Offset: 0x003BF8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewSlotIndex != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.NewSlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D88 RID: 105864 RVA: 0x003C1724 File Offset: 0x003BF924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NewSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewSlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D89 RID: 105865 RVA: 0x003C1762 File Offset: 0x003BF962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchDarkTideWeaponPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NewSlotIndex != 0)
			{
				this.NewSlotIndex = other.NewSlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D8A RID: 105866 RVA: 0x003C1793 File Offset: 0x003BF993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D8B RID: 105867 RVA: 0x003C179C File Offset: 0x003BF99C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NewSlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400972A RID: 38698
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400972B RID: 38699
		public const int NewSlotIndexFieldNumber = 9;

		// Token: 0x0400972C RID: 38700
		private int newSlotIndex_;
	}
}
