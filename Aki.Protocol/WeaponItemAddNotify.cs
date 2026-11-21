using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001565 RID: 5477
	[NetMessage(EMessageId.WeaponItemAddNotify)]
	public sealed class WeaponItemAddNotify : IMessage<WeaponItemAddNotify>, IMessage, IEquatable<WeaponItemAddNotify>, IDeepCloneable<WeaponItemAddNotify>, IBufferMessage
	{
		// Token: 0x0601D026 RID: 118822 RVA: 0x00433D94 File Offset: 0x00431F94
		[NullableContext(1)]
		public static WeaponItemAddNotify Create()
		{
			return new WeaponItemAddNotify();
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x0601D027 RID: 118823 RVA: 0x00433D9B File Offset: 0x00431F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x0601D028 RID: 118824 RVA: 0x00433D9E File Offset: 0x00431F9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0601D029 RID: 118825 RVA: 0x00433DA5 File Offset: 0x00431FA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify()
		{
		}

		// Token: 0x0601D02A RID: 118826 RVA: 0x00433DB8 File Offset: 0x00431FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify(WeaponItemAddNotify other) : this()
		{
			this.weaponItemList_ = other.weaponItemList_.Clone();
			this.addFromRole_ = other.addFromRole_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D02B RID: 118827 RVA: 0x00433E05 File Offset: 0x00432005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify Clone()
		{
			return new WeaponItemAddNotify(this);
		}

		// Token: 0x1700622D RID: 25133
		// (get) Token: 0x0601D02C RID: 118828 RVA: 0x00433E0D File Offset: 0x0043200D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponItem> WeaponItemList
		{
			get
			{
				return this.weaponItemList_;
			}
		}

		// Token: 0x1700622E RID: 25134
		// (get) Token: 0x0601D02D RID: 118829 RVA: 0x00433E15 File Offset: 0x00432015
		// (set) Token: 0x0601D02E RID: 118830 RVA: 0x00433E1D File Offset: 0x0043201D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool AddFromRole
		{
			get
			{
				return this.addFromRole_;
			}
			set
			{
				this.addFromRole_ = value;
			}
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x0601D02F RID: 118831 RVA: 0x00433E26 File Offset: 0x00432026
		// (set) Token: 0x0601D030 RID: 118832 RVA: 0x00433E2E File Offset: 0x0043202E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0601D031 RID: 118833 RVA: 0x00433E37 File Offset: 0x00432037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemAddNotify);
		}

		// Token: 0x0601D032 RID: 118834 RVA: 0x00433E48 File Offset: 0x00432048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemAddNotify other)
		{
			return other != null && (other == this || (this.weaponItemList_.Equals(other.weaponItemList_) && this.AddFromRole == other.AddFromRole && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D033 RID: 118835 RVA: 0x00433EA8 File Offset: 0x004320A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.weaponItemList_.GetHashCode();
			if (this.AddFromRole)
			{
				num ^= this.AddFromRole.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D034 RID: 118836 RVA: 0x00433F0E File Offset: 0x0043210E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D035 RID: 118837 RVA: 0x00433F1B File Offset: 0x0043211B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D036 RID: 118838 RVA: 0x00433F24 File Offset: 0x00432124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponItemList_.WriteTo(ref output, WeaponItemAddNotify._repeated_weaponItemList_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Reason);
			}
			if (this.AddFromRole)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.AddFromRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D037 RID: 118839 RVA: 0x00433F90 File Offset: 0x00432190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponItemList_.CalculateSize(WeaponItemAddNotify._repeated_weaponItemList_codec);
			if (this.AddFromRole)
			{
				num += 2;
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x00433FF0 File Offset: 0x004321F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponItemList_.Add(other.weaponItemList_);
			if (other.AddFromRole)
			{
				this.AddFromRole = other.AddFromRole;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D039 RID: 118841 RVA: 0x00434051 File Offset: 0x00432251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D03A RID: 118842 RVA: 0x0043405C File Offset: 0x0043225C
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AddFromRole = input.ReadBool();
						}
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.weaponItemList_.AddEntriesFrom(ref input, WeaponItemAddNotify._repeated_weaponItemList_codec);
				}
			}
		}

		// Token: 0x0400A6B5 RID: 42677
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A6B6 RID: 42678
		public const int WeaponItemListFieldNumber = 2;

		// Token: 0x0400A6B7 RID: 42679
		private static readonly FieldCodec<WeaponItem> _repeated_weaponItemList_codec = FieldCodec.ForMessage<WeaponItem>(18U, WeaponItem.Parser);

		// Token: 0x0400A6B8 RID: 42680
		private readonly RepeatedField<WeaponItem> weaponItemList_ = new RepeatedField<WeaponItem>();

		// Token: 0x0400A6B9 RID: 42681
		public const int AddFromRoleFieldNumber = 7;

		// Token: 0x0400A6BA RID: 42682
		private bool addFromRole_;

		// Token: 0x0400A6BB RID: 42683
		public const int ReasonFieldNumber = 5;

		// Token: 0x0400A6BC RID: 42684
		private int reason_;
	}
}
