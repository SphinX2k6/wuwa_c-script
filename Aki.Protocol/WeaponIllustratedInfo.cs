using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001563 RID: 5475
	public sealed class WeaponIllustratedInfo : IMessage<WeaponIllustratedInfo>, IMessage, IEquatable<WeaponIllustratedInfo>, IDeepCloneable<WeaponIllustratedInfo>, IBufferMessage
	{
		// Token: 0x0601CFEE RID: 118766 RVA: 0x0043342A File Offset: 0x0043162A
		[NullableContext(1)]
		public static WeaponIllustratedInfo Create()
		{
			return new WeaponIllustratedInfo();
		}

		// Token: 0x1700621B RID: 25115
		// (get) Token: 0x0601CFEF RID: 118767 RVA: 0x00433431 File Offset: 0x00431631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeaponIllustratedInfo> Parser
		{
			get
			{
				return WeaponIllustratedInfo._parser;
			}
		}

		// Token: 0x1700621C RID: 25116
		// (get) Token: 0x0601CFF0 RID: 118768 RVA: 0x00433438 File Offset: 0x00431638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700621D RID: 25117
		// (get) Token: 0x0601CFF1 RID: 118769 RVA: 0x0043343B File Offset: 0x0043163B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0601CFF2 RID: 118770 RVA: 0x00433442 File Offset: 0x00431642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo()
		{
		}

		// Token: 0x0601CFF3 RID: 118771 RVA: 0x0043344A File Offset: 0x0043164A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo(WeaponIllustratedInfo other) : this()
		{
			this.weaponId_ = other.weaponId_;
			this.unlockTime_ = other.unlockTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFF4 RID: 118772 RVA: 0x0043347B File Offset: 0x0043167B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponIllustratedInfo Clone()
		{
			return new WeaponIllustratedInfo(this);
		}

		// Token: 0x1700621E RID: 25118
		// (get) Token: 0x0601CFF5 RID: 118773 RVA: 0x00433483 File Offset: 0x00431683
		// (set) Token: 0x0601CFF6 RID: 118774 RVA: 0x0043348B File Offset: 0x0043168B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponId
		{
			get
			{
				return this.weaponId_;
			}
			set
			{
				this.weaponId_ = value;
			}
		}

		// Token: 0x1700621F RID: 25119
		// (get) Token: 0x0601CFF7 RID: 118775 RVA: 0x00433494 File Offset: 0x00431694
		// (set) Token: 0x0601CFF8 RID: 118776 RVA: 0x0043349C File Offset: 0x0043169C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x0601CFF9 RID: 118777 RVA: 0x004334A5 File Offset: 0x004316A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponIllustratedInfo);
		}

		// Token: 0x0601CFFA RID: 118778 RVA: 0x004334B3 File Offset: 0x004316B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponIllustratedInfo other)
		{
			return other != null && (other == this || (this.WeaponId == other.WeaponId && this.UnlockTime == other.UnlockTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFFB RID: 118779 RVA: 0x004334F4 File Offset: 0x004316F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WeaponId != 0)
			{
				num ^= this.WeaponId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CFFC RID: 118780 RVA: 0x0043354C File Offset: 0x0043174C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFFD RID: 118781 RVA: 0x00433559 File Offset: 0x00431759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFFE RID: 118782 RVA: 0x00433564 File Offset: 0x00431764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WeaponId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WeaponId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFFF RID: 118783 RVA: 0x004335BC File Offset: 0x004317BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WeaponId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D000 RID: 118784 RVA: 0x00433614 File Offset: 0x00431814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WeaponId != 0)
			{
				this.WeaponId = other.WeaponId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D001 RID: 118785 RVA: 0x00433664 File Offset: 0x00431864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D002 RID: 118786 RVA: 0x00433670 File Offset: 0x00431870
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.WeaponId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A69D RID: 42653
		private static readonly MessageParser<WeaponIllustratedInfo> _parser = new MessageParser<WeaponIllustratedInfo>(() => new WeaponIllustratedInfo());

		// Token: 0x0400A69E RID: 42654
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A69F RID: 42655
		public const int WeaponIdFieldNumber = 1;

		// Token: 0x0400A6A0 RID: 42656
		private int weaponId_;

		// Token: 0x0400A6A1 RID: 42657
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x0400A6A2 RID: 42658
		private long unlockTime_;
	}
}
