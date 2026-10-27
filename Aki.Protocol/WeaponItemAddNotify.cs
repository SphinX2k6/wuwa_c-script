using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EF RID: 5359
	[NetMessage(EMessageId.WeaponItemAddNotify)]
	public sealed class WeaponItemAddNotify : IMessage<WeaponItemAddNotify>, IMessage, IEquatable<WeaponItemAddNotify>, IDeepCloneable<WeaponItemAddNotify>, IBufferMessage
	{
		// Token: 0x0601C55F RID: 116063 RVA: 0x004182D8 File Offset: 0x004164D8
		[NullableContext(1)]
		public static WeaponItemAddNotify Create()
		{
			return new WeaponItemAddNotify();
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x0601C560 RID: 116064 RVA: 0x004182DF File Offset: 0x004164DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F8B RID: 24459
		// (get) Token: 0x0601C561 RID: 116065 RVA: 0x004182E2 File Offset: 0x004164E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0601C562 RID: 116066 RVA: 0x004182E9 File Offset: 0x004164E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify()
		{
		}

		// Token: 0x0601C563 RID: 116067 RVA: 0x004182FC File Offset: 0x004164FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify(WeaponItemAddNotify other) : this()
		{
			this.weaponItemList_ = other.weaponItemList_.Clone();
			this.addFromRole_ = other.addFromRole_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C564 RID: 116068 RVA: 0x00418349 File Offset: 0x00416549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponItemAddNotify Clone()
		{
			return new WeaponItemAddNotify(this);
		}

		// Token: 0x17005F8C RID: 24460
		// (get) Token: 0x0601C565 RID: 116069 RVA: 0x00418351 File Offset: 0x00416551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponItem> WeaponItemList
		{
			get
			{
				return this.weaponItemList_;
			}
		}

		// Token: 0x17005F8D RID: 24461
		// (get) Token: 0x0601C566 RID: 116070 RVA: 0x00418359 File Offset: 0x00416559
		// (set) Token: 0x0601C567 RID: 116071 RVA: 0x00418361 File Offset: 0x00416561
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

		// Token: 0x17005F8E RID: 24462
		// (get) Token: 0x0601C568 RID: 116072 RVA: 0x0041836A File Offset: 0x0041656A
		// (set) Token: 0x0601C569 RID: 116073 RVA: 0x00418372 File Offset: 0x00416572
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

		// Token: 0x0601C56A RID: 116074 RVA: 0x0041837B File Offset: 0x0041657B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponItemAddNotify);
		}

		// Token: 0x0601C56B RID: 116075 RVA: 0x0041838C File Offset: 0x0041658C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponItemAddNotify other)
		{
			return other != null && (other == this || (this.weaponItemList_.Equals(other.weaponItemList_) && this.AddFromRole == other.AddFromRole && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C56C RID: 116076 RVA: 0x004183EC File Offset: 0x004165EC
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

		// Token: 0x0601C56D RID: 116077 RVA: 0x00418452 File Offset: 0x00416652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C56E RID: 116078 RVA: 0x0041845F File Offset: 0x0041665F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C56F RID: 116079 RVA: 0x00418468 File Offset: 0x00416668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Reason);
			}
			this.weaponItemList_.WriteTo(ref output, WeaponItemAddNotify._repeated_weaponItemList_codec);
			if (this.AddFromRole)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.AddFromRole);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C570 RID: 116080 RVA: 0x004184D4 File Offset: 0x004166D4
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

		// Token: 0x0601C571 RID: 116081 RVA: 0x00418534 File Offset: 0x00416734
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

		// Token: 0x0601C572 RID: 116082 RVA: 0x00418595 File Offset: 0x00416795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C573 RID: 116083 RVA: 0x004185A0 File Offset: 0x004167A0
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						if (num != 120U)
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
						this.weaponItemList_.AddEntriesFrom(ref input, WeaponItemAddNotify._repeated_weaponItemList_codec);
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A25C RID: 41564
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A25D RID: 41565
		public const int WeaponItemListFieldNumber = 11;

		// Token: 0x0400A25E RID: 41566
		private static readonly FieldCodec<WeaponItem> _repeated_weaponItemList_codec = FieldCodec.ForMessage<WeaponItem>(90U, WeaponItem.Parser);

		// Token: 0x0400A25F RID: 41567
		private readonly RepeatedField<WeaponItem> weaponItemList_ = new RepeatedField<WeaponItem>();

		// Token: 0x0400A260 RID: 41568
		public const int AddFromRoleFieldNumber = 15;

		// Token: 0x0400A261 RID: 41569
		private bool addFromRole_;

		// Token: 0x0400A262 RID: 41570
		public const int ReasonFieldNumber = 2;

		// Token: 0x0400A263 RID: 41571
		private int reason_;
	}
}
