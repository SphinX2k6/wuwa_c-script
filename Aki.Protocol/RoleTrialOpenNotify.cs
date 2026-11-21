using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001105 RID: 4357
	[NetMessage(EMessageId.RoleTrialOpenNotify)]
	public sealed class RoleTrialOpenNotify : IMessage<RoleTrialOpenNotify>, IMessage, IEquatable<RoleTrialOpenNotify>, IDeepCloneable<RoleTrialOpenNotify>, IBufferMessage
	{
		// Token: 0x060174A3 RID: 95395 RVA: 0x00363A5D File Offset: 0x00361C5D
		[NullableContext(1)]
		public static RoleTrialOpenNotify Create()
		{
			return new RoleTrialOpenNotify();
		}

		// Token: 0x17004E3F RID: 20031
		// (get) Token: 0x060174A4 RID: 95396 RVA: 0x00363A64 File Offset: 0x00361C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E40 RID: 20032
		// (get) Token: 0x060174A5 RID: 95397 RVA: 0x00363A67 File Offset: 0x00361C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialOpenNotify.Descriptor;
			}
		}

		// Token: 0x060174A6 RID: 95398 RVA: 0x00363A6E File Offset: 0x00361C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialOpenNotify()
		{
		}

		// Token: 0x060174A7 RID: 95399 RVA: 0x00363A98 File Offset: 0x00361C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialOpenNotify(RoleTrialOpenNotify other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this.enableMapAndTeleport_ = other.enableMapAndTeleport_;
			this.canEnterDungeonList_ = other.canEnterDungeonList_.Clone();
			this.showTips_ = other.showTips_;
			this.trialRoleItems_ = other.trialRoleItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060174A8 RID: 95400 RVA: 0x00363B07 File Offset: 0x00361D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialOpenNotify Clone()
		{
			return new RoleTrialOpenNotify(this);
		}

		// Token: 0x17004E41 RID: 20033
		// (get) Token: 0x060174A9 RID: 95401 RVA: 0x00363B0F File Offset: 0x00361D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004E42 RID: 20034
		// (get) Token: 0x060174AA RID: 95402 RVA: 0x00363B17 File Offset: 0x00361D17
		// (set) Token: 0x060174AB RID: 95403 RVA: 0x00363B1F File Offset: 0x00361D1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EnableMapAndTeleport
		{
			get
			{
				return this.enableMapAndTeleport_;
			}
			set
			{
				this.enableMapAndTeleport_ = value;
			}
		}

		// Token: 0x17004E43 RID: 20035
		// (get) Token: 0x060174AC RID: 95404 RVA: 0x00363B28 File Offset: 0x00361D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanEnterDungeonList
		{
			get
			{
				return this.canEnterDungeonList_;
			}
		}

		// Token: 0x17004E44 RID: 20036
		// (get) Token: 0x060174AD RID: 95405 RVA: 0x00363B30 File Offset: 0x00361D30
		// (set) Token: 0x060174AE RID: 95406 RVA: 0x00363B38 File Offset: 0x00361D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowTips
		{
			get
			{
				return this.showTips_;
			}
			set
			{
				this.showTips_ = value;
			}
		}

		// Token: 0x17004E45 RID: 20037
		// (get) Token: 0x060174AF RID: 95407 RVA: 0x00363B41 File Offset: 0x00361D41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrialRoleItem> TrialRoleItems
		{
			get
			{
				return this.trialRoleItems_;
			}
		}

		// Token: 0x060174B0 RID: 95408 RVA: 0x00363B49 File Offset: 0x00361D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialOpenNotify);
		}

		// Token: 0x060174B1 RID: 95409 RVA: 0x00363B58 File Offset: 0x00361D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialOpenNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.EnableMapAndTeleport == other.EnableMapAndTeleport && this.canEnterDungeonList_.Equals(other.canEnterDungeonList_) && this.ShowTips == other.ShowTips && this.trialRoleItems_.Equals(other.trialRoleItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060174B2 RID: 95410 RVA: 0x00363BE0 File Offset: 0x00361DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			if (this.EnableMapAndTeleport)
			{
				num ^= this.EnableMapAndTeleport.GetHashCode();
			}
			num ^= this.canEnterDungeonList_.GetHashCode();
			if (this.ShowTips)
			{
				num ^= this.ShowTips.GetHashCode();
			}
			num ^= this.trialRoleItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060174B3 RID: 95411 RVA: 0x00363C62 File Offset: 0x00361E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060174B4 RID: 95412 RVA: 0x00363C6F File Offset: 0x00361E6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060174B5 RID: 95413 RVA: 0x00363C78 File Offset: 0x00361E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowTips)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ShowTips);
			}
			this.roleIds_.WriteTo(ref output, RoleTrialOpenNotify._repeated_roleIds_codec);
			this.canEnterDungeonList_.WriteTo(ref output, RoleTrialOpenNotify._repeated_canEnterDungeonList_codec);
			this.trialRoleItems_.WriteTo(ref output, RoleTrialOpenNotify._repeated_trialRoleItems_codec);
			if (this.EnableMapAndTeleport)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.EnableMapAndTeleport);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060174B6 RID: 95414 RVA: 0x00363D04 File Offset: 0x00361F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(RoleTrialOpenNotify._repeated_roleIds_codec);
			if (this.EnableMapAndTeleport)
			{
				num += 2;
			}
			num += this.canEnterDungeonList_.CalculateSize(RoleTrialOpenNotify._repeated_canEnterDungeonList_codec);
			if (this.ShowTips)
			{
				num += 2;
			}
			num += this.trialRoleItems_.CalculateSize(RoleTrialOpenNotify._repeated_trialRoleItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060174B7 RID: 95415 RVA: 0x00363D7C File Offset: 0x00361F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialOpenNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.EnableMapAndTeleport)
			{
				this.EnableMapAndTeleport = other.EnableMapAndTeleport;
			}
			this.canEnterDungeonList_.Add(other.canEnterDungeonList_);
			if (other.ShowTips)
			{
				this.ShowTips = other.ShowTips;
			}
			this.trialRoleItems_.Add(other.trialRoleItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060174B8 RID: 95416 RVA: 0x00363DFF File Offset: 0x00361FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060174B9 RID: 95417 RVA: 0x00363E08 File Offset: 0x00362008
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.ShowTips = input.ReadBool();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.roleIds_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_roleIds_codec);
						continue;
					}
				}
				else if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.canEnterDungeonList_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_canEnterDungeonList_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.trialRoleItems_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_trialRoleItems_codec);
						continue;
					}
					if (num == 120U)
					{
						this.EnableMapAndTeleport = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008B3A RID: 35642
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B3B RID: 35643
		public const int RoleIdsFieldNumber = 4;

		// Token: 0x04008B3C RID: 35644
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008B3D RID: 35645
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008B3E RID: 35646
		public const int EnableMapAndTeleportFieldNumber = 15;

		// Token: 0x04008B3F RID: 35647
		private bool enableMapAndTeleport_;

		// Token: 0x04008B40 RID: 35648
		public const int CanEnterDungeonListFieldNumber = 5;

		// Token: 0x04008B41 RID: 35649
		private static readonly FieldCodec<int> _repeated_canEnterDungeonList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04008B42 RID: 35650
		private readonly RepeatedField<int> canEnterDungeonList_ = new RepeatedField<int>();

		// Token: 0x04008B43 RID: 35651
		public const int ShowTipsFieldNumber = 1;

		// Token: 0x04008B44 RID: 35652
		private bool showTips_;

		// Token: 0x04008B45 RID: 35653
		public const int TrialRoleItemsFieldNumber = 6;

		// Token: 0x04008B46 RID: 35654
		private static readonly FieldCodec<TrialRoleItem> _repeated_trialRoleItems_codec = FieldCodec.ForMessage<TrialRoleItem>(50U, TrialRoleItem.Parser);

		// Token: 0x04008B47 RID: 35655
		private readonly RepeatedField<TrialRoleItem> trialRoleItems_ = new RepeatedField<TrialRoleItem>();
	}
}
