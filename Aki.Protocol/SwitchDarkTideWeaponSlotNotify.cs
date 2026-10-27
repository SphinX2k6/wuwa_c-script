using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FE RID: 4862
	[NetMessage(EMessageId.SwitchDarkTideWeaponSlotNotify)]
	public sealed class SwitchDarkTideWeaponSlotNotify : IMessage<SwitchDarkTideWeaponSlotNotify>, IMessage, IEquatable<SwitchDarkTideWeaponSlotNotify>, IDeepCloneable<SwitchDarkTideWeaponSlotNotify>, IBufferMessage
	{
		// Token: 0x06019D8C RID: 105868 RVA: 0x003C17E1 File Offset: 0x003BF9E1
		[NullableContext(1)]
		public static SwitchDarkTideWeaponSlotNotify Create()
		{
			return new SwitchDarkTideWeaponSlotNotify();
		}

		// Token: 0x1700572A RID: 22314
		// (get) Token: 0x06019D8D RID: 105869 RVA: 0x003C17E8 File Offset: 0x003BF9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700572B RID: 22315
		// (get) Token: 0x06019D8E RID: 105870 RVA: 0x003C17EB File Offset: 0x003BF9EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchDarkTideWeaponSlotNotify.Descriptor;
			}
		}

		// Token: 0x06019D8F RID: 105871 RVA: 0x003C17F2 File Offset: 0x003BF9F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponSlotNotify()
		{
		}

		// Token: 0x06019D90 RID: 105872 RVA: 0x003C17FA File Offset: 0x003BF9FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponSlotNotify(SwitchDarkTideWeaponSlotNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.currentWeaponSlotIndex_ = other.currentWeaponSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D91 RID: 105873 RVA: 0x003C182B File Offset: 0x003BFA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchDarkTideWeaponSlotNotify Clone()
		{
			return new SwitchDarkTideWeaponSlotNotify(this);
		}

		// Token: 0x1700572C RID: 22316
		// (get) Token: 0x06019D92 RID: 105874 RVA: 0x003C1833 File Offset: 0x003BFA33
		// (set) Token: 0x06019D93 RID: 105875 RVA: 0x003C183B File Offset: 0x003BFA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700572D RID: 22317
		// (get) Token: 0x06019D94 RID: 105876 RVA: 0x003C1844 File Offset: 0x003BFA44
		// (set) Token: 0x06019D95 RID: 105877 RVA: 0x003C184C File Offset: 0x003BFA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentWeaponSlotIndex
		{
			get
			{
				return this.currentWeaponSlotIndex_;
			}
			set
			{
				this.currentWeaponSlotIndex_ = value;
			}
		}

		// Token: 0x06019D96 RID: 105878 RVA: 0x003C1855 File Offset: 0x003BFA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchDarkTideWeaponSlotNotify);
		}

		// Token: 0x06019D97 RID: 105879 RVA: 0x003C1863 File Offset: 0x003BFA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchDarkTideWeaponSlotNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.CurrentWeaponSlotIndex == other.CurrentWeaponSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D98 RID: 105880 RVA: 0x003C18A4 File Offset: 0x003BFAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.CurrentWeaponSlotIndex != 0)
			{
				num ^= this.CurrentWeaponSlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D99 RID: 105881 RVA: 0x003C18FC File Offset: 0x003BFAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D9A RID: 105882 RVA: 0x003C1909 File Offset: 0x003BFB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D9B RID: 105883 RVA: 0x003C1914 File Offset: 0x003BFB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.CurrentWeaponSlotIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CurrentWeaponSlotIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D9C RID: 105884 RVA: 0x003C196C File Offset: 0x003BFB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.CurrentWeaponSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentWeaponSlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D9D RID: 105885 RVA: 0x003C19C4 File Offset: 0x003BFBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchDarkTideWeaponSlotNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.CurrentWeaponSlotIndex != 0)
			{
				this.CurrentWeaponSlotIndex = other.CurrentWeaponSlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D9E RID: 105886 RVA: 0x003C1A14 File Offset: 0x003BFC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D9F RID: 105887 RVA: 0x003C1A20 File Offset: 0x003BFC20
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurrentWeaponSlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400972D RID: 38701
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400972E RID: 38702
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400972F RID: 38703
		private int playerId_;

		// Token: 0x04009730 RID: 38704
		public const int CurrentWeaponSlotIndexFieldNumber = 4;

		// Token: 0x04009731 RID: 38705
		private int currentWeaponSlotIndex_;
	}
}
