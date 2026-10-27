using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000798 RID: 1944
	public sealed class HonamiStoryRackInfo : IMessage<HonamiStoryRackInfo>, IMessage, IEquatable<HonamiStoryRackInfo>, IDeepCloneable<HonamiStoryRackInfo>, IBufferMessage
	{
		// Token: 0x0600AF5C RID: 44892 RVA: 0x001A4EA3 File Offset: 0x001A30A3
		[NullableContext(1)]
		public static HonamiStoryRackInfo Create()
		{
			return new HonamiStoryRackInfo();
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x001A4EAA File Offset: 0x001A30AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryRackInfo> Parser
		{
			get
			{
				return HonamiStoryRackInfo._parser;
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x0600AF5E RID: 44894 RVA: 0x001A4EB1 File Offset: 0x001A30B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x0600AF5F RID: 44895 RVA: 0x001A4EB4 File Offset: 0x001A30B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryRackInfo.Descriptor;
			}
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x001A4EBB File Offset: 0x001A30BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo()
		{
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x001A4ED0 File Offset: 0x001A30D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo(HonamiStoryRackInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.honamiStorySlotInfos_ = other.honamiStorySlotInfos_.Clone();
			this.dressWeapon_ = other.dressWeapon_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x001A4F1D File Offset: 0x001A311D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo Clone()
		{
			return new HonamiStoryRackInfo(this);
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x0600AF63 RID: 44899 RVA: 0x001A4F25 File Offset: 0x001A3125
		// (set) Token: 0x0600AF64 RID: 44900 RVA: 0x001A4F2D File Offset: 0x001A312D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x0600AF65 RID: 44901 RVA: 0x001A4F36 File Offset: 0x001A3136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStorySlotInfo> HonamiStorySlotInfos
		{
			get
			{
				return this.honamiStorySlotInfos_;
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x0600AF66 RID: 44902 RVA: 0x001A4F3E File Offset: 0x001A313E
		// (set) Token: 0x0600AF67 RID: 44903 RVA: 0x001A4F46 File Offset: 0x001A3146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DressWeapon
		{
			get
			{
				return this.dressWeapon_;
			}
			set
			{
				this.dressWeapon_ = value;
			}
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x001A4F4F File Offset: 0x001A314F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryRackInfo);
		}

		// Token: 0x0600AF69 RID: 44905 RVA: 0x001A4F60 File Offset: 0x001A3160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryRackInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.honamiStorySlotInfos_.Equals(other.honamiStorySlotInfos_) && this.DressWeapon == other.DressWeapon && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AF6A RID: 44906 RVA: 0x001A4FC0 File Offset: 0x001A31C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.honamiStorySlotInfos_.GetHashCode();
			if (this.DressWeapon != 0)
			{
				num ^= this.DressWeapon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AF6B RID: 44907 RVA: 0x001A5026 File Offset: 0x001A3226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AF6C RID: 44908 RVA: 0x001A5033 File Offset: 0x001A3233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AF6D RID: 44909 RVA: 0x001A503C File Offset: 0x001A323C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			this.honamiStorySlotInfos_.WriteTo(ref output, HonamiStoryRackInfo._repeated_honamiStorySlotInfos_codec);
			if (this.DressWeapon != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.DressWeapon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AF6E RID: 44910 RVA: 0x001A50A8 File Offset: 0x001A32A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.honamiStorySlotInfos_.CalculateSize(HonamiStoryRackInfo._repeated_honamiStorySlotInfos_codec);
			if (this.DressWeapon != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DressWeapon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AF6F RID: 44911 RVA: 0x001A5114 File Offset: 0x001A3314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryRackInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.honamiStorySlotInfos_.Add(other.honamiStorySlotInfos_);
			if (other.DressWeapon != 0)
			{
				this.DressWeapon = other.DressWeapon;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AF70 RID: 44912 RVA: 0x001A5175 File Offset: 0x001A3375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AF71 RID: 44913 RVA: 0x001A5180 File Offset: 0x001A3380
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
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DressWeapon = input.ReadInt32();
						}
					}
					else
					{
						this.honamiStorySlotInfos_.AddEntriesFrom(ref input, HonamiStoryRackInfo._repeated_honamiStorySlotInfos_codec);
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EF2 RID: 20210
		private static readonly MessageParser<HonamiStoryRackInfo> _parser = new MessageParser<HonamiStoryRackInfo>(() => new HonamiStoryRackInfo());

		// Token: 0x04004EF3 RID: 20211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EF4 RID: 20212
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04004EF5 RID: 20213
		private int roleId_;

		// Token: 0x04004EF6 RID: 20214
		public const int HonamiStorySlotInfosFieldNumber = 2;

		// Token: 0x04004EF7 RID: 20215
		private static readonly FieldCodec<HonamiStorySlotInfo> _repeated_honamiStorySlotInfos_codec = FieldCodec.ForMessage<HonamiStorySlotInfo>(18U, HonamiStorySlotInfo.Parser);

		// Token: 0x04004EF8 RID: 20216
		private readonly RepeatedField<HonamiStorySlotInfo> honamiStorySlotInfos_ = new RepeatedField<HonamiStorySlotInfo>();

		// Token: 0x04004EF9 RID: 20217
		public const int DressWeaponFieldNumber = 3;

		// Token: 0x04004EFA RID: 20218
		private int dressWeapon_;
	}
}
