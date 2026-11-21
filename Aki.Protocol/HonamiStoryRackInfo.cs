using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000784 RID: 1924
	public sealed class HonamiStoryRackInfo : IMessage<HonamiStoryRackInfo>, IMessage, IEquatable<HonamiStoryRackInfo>, IDeepCloneable<HonamiStoryRackInfo>, IBufferMessage
	{
		// Token: 0x0600AE06 RID: 44550 RVA: 0x001A247B File Offset: 0x001A067B
		[NullableContext(1)]
		public static HonamiStoryRackInfo Create()
		{
			return new HonamiStoryRackInfo();
		}

		// Token: 0x17002315 RID: 8981
		// (get) Token: 0x0600AE07 RID: 44551 RVA: 0x001A2482 File Offset: 0x001A0682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryRackInfo> Parser
		{
			get
			{
				return HonamiStoryRackInfo._parser;
			}
		}

		// Token: 0x17002316 RID: 8982
		// (get) Token: 0x0600AE08 RID: 44552 RVA: 0x001A2489 File Offset: 0x001A0689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002317 RID: 8983
		// (get) Token: 0x0600AE09 RID: 44553 RVA: 0x001A248C File Offset: 0x001A068C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryRackInfo.Descriptor;
			}
		}

		// Token: 0x0600AE0A RID: 44554 RVA: 0x001A2493 File Offset: 0x001A0693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo()
		{
		}

		// Token: 0x0600AE0B RID: 44555 RVA: 0x001A24A8 File Offset: 0x001A06A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo(HonamiStoryRackInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.honamiStorySlotInfos_ = other.honamiStorySlotInfos_.Clone();
			this.dressWeapon_ = other.dressWeapon_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE0C RID: 44556 RVA: 0x001A24F5 File Offset: 0x001A06F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryRackInfo Clone()
		{
			return new HonamiStoryRackInfo(this);
		}

		// Token: 0x17002318 RID: 8984
		// (get) Token: 0x0600AE0D RID: 44557 RVA: 0x001A24FD File Offset: 0x001A06FD
		// (set) Token: 0x0600AE0E RID: 44558 RVA: 0x001A2505 File Offset: 0x001A0705
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

		// Token: 0x17002319 RID: 8985
		// (get) Token: 0x0600AE0F RID: 44559 RVA: 0x001A250E File Offset: 0x001A070E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStorySlotInfo> HonamiStorySlotInfos
		{
			get
			{
				return this.honamiStorySlotInfos_;
			}
		}

		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x0600AE10 RID: 44560 RVA: 0x001A2516 File Offset: 0x001A0716
		// (set) Token: 0x0600AE11 RID: 44561 RVA: 0x001A251E File Offset: 0x001A071E
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

		// Token: 0x0600AE12 RID: 44562 RVA: 0x001A2527 File Offset: 0x001A0727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryRackInfo);
		}

		// Token: 0x0600AE13 RID: 44563 RVA: 0x001A2538 File Offset: 0x001A0738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryRackInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.honamiStorySlotInfos_.Equals(other.honamiStorySlotInfos_) && this.DressWeapon == other.DressWeapon && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AE14 RID: 44564 RVA: 0x001A2598 File Offset: 0x001A0798
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

		// Token: 0x0600AE15 RID: 44565 RVA: 0x001A25FE File Offset: 0x001A07FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AE16 RID: 44566 RVA: 0x001A260B File Offset: 0x001A080B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE17 RID: 44567 RVA: 0x001A2614 File Offset: 0x001A0814
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

		// Token: 0x0600AE18 RID: 44568 RVA: 0x001A2680 File Offset: 0x001A0880
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

		// Token: 0x0600AE19 RID: 44569 RVA: 0x001A26EC File Offset: 0x001A08EC
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

		// Token: 0x0600AE1A RID: 44570 RVA: 0x001A274D File Offset: 0x001A094D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE1B RID: 44571 RVA: 0x001A2758 File Offset: 0x001A0958
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

		// Token: 0x04004EEB RID: 20203
		private static readonly MessageParser<HonamiStoryRackInfo> _parser = new MessageParser<HonamiStoryRackInfo>(() => new HonamiStoryRackInfo());

		// Token: 0x04004EEC RID: 20204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EED RID: 20205
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04004EEE RID: 20206
		private int roleId_;

		// Token: 0x04004EEF RID: 20207
		public const int HonamiStorySlotInfosFieldNumber = 2;

		// Token: 0x04004EF0 RID: 20208
		private static readonly FieldCodec<HonamiStorySlotInfo> _repeated_honamiStorySlotInfos_codec = FieldCodec.ForMessage<HonamiStorySlotInfo>(18U, HonamiStorySlotInfo.Parser);

		// Token: 0x04004EF1 RID: 20209
		private readonly RepeatedField<HonamiStorySlotInfo> honamiStorySlotInfos_ = new RepeatedField<HonamiStorySlotInfo>();

		// Token: 0x04004EF2 RID: 20210
		public const int DressWeaponFieldNumber = 3;

		// Token: 0x04004EF3 RID: 20211
		private int dressWeapon_;
	}
}
