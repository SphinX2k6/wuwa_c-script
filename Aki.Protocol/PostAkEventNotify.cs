using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBB RID: 3515
	[NetMessage(EMessageId.PostAkEventNotify)]
	public sealed class PostAkEventNotify : IMessage<PostAkEventNotify>, IMessage, IEquatable<PostAkEventNotify>, IDeepCloneable<PostAkEventNotify>, IBufferMessage
	{
		// Token: 0x06012F2D RID: 77613 RVA: 0x002C3A2A File Offset: 0x002C1C2A
		[NullableContext(1)]
		public static PostAkEventNotify Create()
		{
			return new PostAkEventNotify();
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06012F2E RID: 77614 RVA: 0x002C3A31 File Offset: 0x002C1C31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06012F2F RID: 77615 RVA: 0x002C3A34 File Offset: 0x002C1C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PostAkEventNotify.Descriptor;
			}
		}

		// Token: 0x06012F30 RID: 77616 RVA: 0x002C3A3B File Offset: 0x002C1C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PostAkEventNotify()
		{
		}

		// Token: 0x06012F31 RID: 77617 RVA: 0x002C3A50 File Offset: 0x002C1C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PostAkEventNotify(PostAkEventNotify other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.akEvent_ = other.akEvent_;
			this.persistWhenExitDungeon_ = other.persistWhenExitDungeon_;
			this.musicEventType_ = other.musicEventType_;
			this.isBanVehicleRadio_ = other.isBanVehicleRadio_;
			this.fadeOutTimeWhenFlowEnd_ = other.fadeOutTimeWhenFlowEnd_;
			this.delayTime_ = other.delayTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F32 RID: 77618 RVA: 0x002C3AE0 File Offset: 0x002C1CE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PostAkEventNotify Clone()
		{
			return new PostAkEventNotify(this);
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x06012F33 RID: 77619 RVA: 0x002C3AE8 File Offset: 0x002C1CE8
		// (set) Token: 0x06012F34 RID: 77620 RVA: 0x002C3AF0 File Offset: 0x002C1CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x06012F35 RID: 77621 RVA: 0x002C3AF9 File Offset: 0x002C1CF9
		// (set) Token: 0x06012F36 RID: 77622 RVA: 0x002C3B01 File Offset: 0x002C1D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x06012F37 RID: 77623 RVA: 0x002C3B0A File Offset: 0x002C1D0A
		// (set) Token: 0x06012F38 RID: 77624 RVA: 0x002C3B12 File Offset: 0x002C1D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AkEvent
		{
			get
			{
				return this.akEvent_;
			}
			set
			{
				this.akEvent_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x06012F39 RID: 77625 RVA: 0x002C3B25 File Offset: 0x002C1D25
		// (set) Token: 0x06012F3A RID: 77626 RVA: 0x002C3B3D File Offset: 0x002C1D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PersistWhenExitDungeon
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.persistWhenExitDungeon_;
				}
				return PostAkEventNotify.PersistWhenExitDungeonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.persistWhenExitDungeon_ = value;
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06012F3B RID: 77627 RVA: 0x002C3B54 File Offset: 0x002C1D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasPersistWhenExitDungeon
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06012F3C RID: 77628 RVA: 0x002C3B61 File Offset: 0x002C1D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPersistWhenExitDungeon()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06012F3D RID: 77629 RVA: 0x002C3B72 File Offset: 0x002C1D72
		// (set) Token: 0x06012F3E RID: 77630 RVA: 0x002C3B83 File Offset: 0x002C1D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string MusicEventType
		{
			get
			{
				return this.musicEventType_ ?? PostAkEventNotify.MusicEventTypeDefaultValue;
			}
			set
			{
				this.musicEventType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06012F3F RID: 77631 RVA: 0x002C3B96 File Offset: 0x002C1D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasMusicEventType
		{
			get
			{
				return this.musicEventType_ != null;
			}
		}

		// Token: 0x06012F40 RID: 77632 RVA: 0x002C3BA1 File Offset: 0x002C1DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMusicEventType()
		{
			this.musicEventType_ = null;
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06012F41 RID: 77633 RVA: 0x002C3BAA File Offset: 0x002C1DAA
		// (set) Token: 0x06012F42 RID: 77634 RVA: 0x002C3BC2 File Offset: 0x002C1DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsBanVehicleRadio
		{
			get
			{
				if ((this._hasBits0 & 4) != 0)
				{
					return this.isBanVehicleRadio_;
				}
				return PostAkEventNotify.IsBanVehicleRadioDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.isBanVehicleRadio_ = value;
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x06012F43 RID: 77635 RVA: 0x002C3BD9 File Offset: 0x002C1DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasIsBanVehicleRadio
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06012F44 RID: 77636 RVA: 0x002C3BE6 File Offset: 0x002C1DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearIsBanVehicleRadio()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x06012F45 RID: 77637 RVA: 0x002C3BF7 File Offset: 0x002C1DF7
		// (set) Token: 0x06012F46 RID: 77638 RVA: 0x002C3C0F File Offset: 0x002C1E0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float FadeOutTimeWhenFlowEnd
		{
			get
			{
				if ((this._hasBits0 & 8) != 0)
				{
					return this.fadeOutTimeWhenFlowEnd_;
				}
				return PostAkEventNotify.FadeOutTimeWhenFlowEndDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.fadeOutTimeWhenFlowEnd_ = value;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x06012F47 RID: 77639 RVA: 0x002C3C26 File Offset: 0x002C1E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFadeOutTimeWhenFlowEnd
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06012F48 RID: 77640 RVA: 0x002C3C33 File Offset: 0x002C1E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearFadeOutTimeWhenFlowEnd()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17003EEC RID: 16108
		// (get) Token: 0x06012F49 RID: 77641 RVA: 0x002C3C44 File Offset: 0x002C1E44
		// (set) Token: 0x06012F4A RID: 77642 RVA: 0x002C3C5C File Offset: 0x002C1E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float DelayTime
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.delayTime_;
				}
				return PostAkEventNotify.DelayTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.delayTime_ = value;
			}
		}

		// Token: 0x17003EED RID: 16109
		// (get) Token: 0x06012F4B RID: 77643 RVA: 0x002C3C73 File Offset: 0x002C1E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasDelayTime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06012F4C RID: 77644 RVA: 0x002C3C80 File Offset: 0x002C1E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearDelayTime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06012F4D RID: 77645 RVA: 0x002C3C91 File Offset: 0x002C1E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PostAkEventNotify);
		}

		// Token: 0x06012F4E RID: 77646 RVA: 0x002C3CA0 File Offset: 0x002C1EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PostAkEventNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && !(this.AkEvent != other.AkEvent) && this.PersistWhenExitDungeon == other.PersistWhenExitDungeon && !(this.MusicEventType != other.MusicEventType) && this.IsBanVehicleRadio == other.IsBanVehicleRadio && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.FadeOutTimeWhenFlowEnd, other.FadeOutTimeWhenFlowEnd) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.DelayTime, other.DelayTime) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F4F RID: 77647 RVA: 0x002C3D68 File Offset: 0x002C1F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.AkEvent.Length != 0)
			{
				num ^= this.AkEvent.GetHashCode();
			}
			if (this.HasPersistWhenExitDungeon)
			{
				num ^= this.PersistWhenExitDungeon.GetHashCode();
			}
			if (this.HasMusicEventType)
			{
				num ^= this.MusicEventType.GetHashCode();
			}
			if (this.HasIsBanVehicleRadio)
			{
				num ^= this.IsBanVehicleRadio.GetHashCode();
			}
			if (this.HasFadeOutTimeWhenFlowEnd)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.FadeOutTimeWhenFlowEnd);
			}
			if (this.HasDelayTime)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.DelayTime);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F50 RID: 77648 RVA: 0x002C3E59 File Offset: 0x002C2059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F51 RID: 77649 RVA: 0x002C3E66 File Offset: 0x002C2066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F52 RID: 77650 RVA: 0x002C3E70 File Offset: 0x002C2070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasDelayTime)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.DelayTime);
			}
			if (this.HasMusicEventType)
			{
				output.WriteRawTag(18);
				output.WriteString(this.MusicEventType);
			}
			if (this.HasPersistWhenExitDungeon)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.PersistWhenExitDungeon);
			}
			if (this.HasIsBanVehicleRadio)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsBanVehicleRadio);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.HasFadeOutTimeWhenFlowEnd)
			{
				output.WriteRawTag(69);
				output.WriteFloat(this.FadeOutTimeWhenFlowEnd);
			}
			if (this.AkEvent.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.AkEvent);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F53 RID: 77651 RVA: 0x002C3F78 File Offset: 0x002C2178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.AkEvent.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AkEvent);
			}
			if (this.HasPersistWhenExitDungeon)
			{
				num += 2;
			}
			if (this.HasMusicEventType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MusicEventType);
			}
			if (this.HasIsBanVehicleRadio)
			{
				num += 2;
			}
			if (this.HasFadeOutTimeWhenFlowEnd)
			{
				num += 5;
			}
			if (this.HasDelayTime)
			{
				num += 5;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F54 RID: 77652 RVA: 0x002C4034 File Offset: 0x002C2234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PostAkEventNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.AkEvent.Length != 0)
			{
				this.AkEvent = other.AkEvent;
			}
			if (other.HasPersistWhenExitDungeon)
			{
				this.PersistWhenExitDungeon = other.PersistWhenExitDungeon;
			}
			if (other.HasMusicEventType)
			{
				this.MusicEventType = other.MusicEventType;
			}
			if (other.HasIsBanVehicleRadio)
			{
				this.IsBanVehicleRadio = other.IsBanVehicleRadio;
			}
			if (other.HasFadeOutTimeWhenFlowEnd)
			{
				this.FadeOutTimeWhenFlowEnd = other.FadeOutTimeWhenFlowEnd;
			}
			if (other.HasDelayTime)
			{
				this.DelayTime = other.DelayTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F55 RID: 77653 RVA: 0x002C4101 File Offset: 0x002C2301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F56 RID: 77654 RVA: 0x002C410C File Offset: 0x002C230C
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
				if (num <= 32U)
				{
					if (num <= 18U)
					{
						if (num == 13U)
						{
							this.DelayTime = input.ReadFloat();
							continue;
						}
						if (num == 18U)
						{
							this.MusicEventType = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.PersistWhenExitDungeon = input.ReadBool();
							continue;
						}
						if (num == 32U)
						{
							this.IsBanVehicleRadio = input.ReadBool();
							continue;
						}
					}
				}
				else if (num <= 69U)
				{
					if (num == 56U)
					{
						this.TreeOwnerId = input.ReadInt32();
						continue;
					}
					if (num == 69U)
					{
						this.FadeOutTimeWhenFlowEnd = input.ReadFloat();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.AkEvent = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400757F RID: 30079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007580 RID: 30080
		private int _hasBits0;

		// Token: 0x04007581 RID: 30081
		public const int TreeOwnerIdFieldNumber = 7;

		// Token: 0x04007582 RID: 30082
		private int treeOwnerId_;

		// Token: 0x04007583 RID: 30083
		public const int TreeIncIdFieldNumber = 10;

		// Token: 0x04007584 RID: 30084
		private long treeIncId_;

		// Token: 0x04007585 RID: 30085
		public const int AkEventFieldNumber = 9;

		// Token: 0x04007586 RID: 30086
		private string akEvent_ = "";

		// Token: 0x04007587 RID: 30087
		public const int PersistWhenExitDungeonFieldNumber = 3;

		// Token: 0x04007588 RID: 30088
		private static readonly bool PersistWhenExitDungeonDefaultValue = false;

		// Token: 0x04007589 RID: 30089
		private bool persistWhenExitDungeon_;

		// Token: 0x0400758A RID: 30090
		public const int MusicEventTypeFieldNumber = 2;

		// Token: 0x0400758B RID: 30091
		private static readonly string MusicEventTypeDefaultValue = "";

		// Token: 0x0400758C RID: 30092
		private string musicEventType_;

		// Token: 0x0400758D RID: 30093
		public const int IsBanVehicleRadioFieldNumber = 4;

		// Token: 0x0400758E RID: 30094
		private static readonly bool IsBanVehicleRadioDefaultValue = false;

		// Token: 0x0400758F RID: 30095
		private bool isBanVehicleRadio_;

		// Token: 0x04007590 RID: 30096
		public const int FadeOutTimeWhenFlowEndFieldNumber = 8;

		// Token: 0x04007591 RID: 30097
		private static readonly float FadeOutTimeWhenFlowEndDefaultValue = 0f;

		// Token: 0x04007592 RID: 30098
		private float fadeOutTimeWhenFlowEnd_;

		// Token: 0x04007593 RID: 30099
		public const int DelayTimeFieldNumber = 1;

		// Token: 0x04007594 RID: 30100
		private static readonly float DelayTimeDefaultValue = 0f;

		// Token: 0x04007595 RID: 30101
		private float delayTime_;
	}
}
