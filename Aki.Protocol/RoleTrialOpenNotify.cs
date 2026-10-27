using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010CB RID: 4299
	[NetMessage(EMessageId.RoleTrialOpenNotify)]
	public sealed class RoleTrialOpenNotify : IMessage<RoleTrialOpenNotify>, IMessage, IEquatable<RoleTrialOpenNotify>, IDeepCloneable<RoleTrialOpenNotify>, IBufferMessage
	{
		// Token: 0x06016F04 RID: 93956 RVA: 0x003547A1 File Offset: 0x003529A1
		[NullableContext(1)]
		public static RoleTrialOpenNotify Create()
		{
			return new RoleTrialOpenNotify();
		}

		// Token: 0x17004CD4 RID: 19668
		// (get) Token: 0x06016F05 RID: 93957 RVA: 0x003547A8 File Offset: 0x003529A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CD5 RID: 19669
		// (get) Token: 0x06016F06 RID: 93958 RVA: 0x003547AB File Offset: 0x003529AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialOpenNotify.Descriptor;
			}
		}

		// Token: 0x06016F07 RID: 93959 RVA: 0x003547B2 File Offset: 0x003529B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialOpenNotify()
		{
		}

		// Token: 0x06016F08 RID: 93960 RVA: 0x003547DC File Offset: 0x003529DC
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

		// Token: 0x06016F09 RID: 93961 RVA: 0x0035484B File Offset: 0x00352A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialOpenNotify Clone()
		{
			return new RoleTrialOpenNotify(this);
		}

		// Token: 0x17004CD6 RID: 19670
		// (get) Token: 0x06016F0A RID: 93962 RVA: 0x00354853 File Offset: 0x00352A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004CD7 RID: 19671
		// (get) Token: 0x06016F0B RID: 93963 RVA: 0x0035485B File Offset: 0x00352A5B
		// (set) Token: 0x06016F0C RID: 93964 RVA: 0x00354863 File Offset: 0x00352A63
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

		// Token: 0x17004CD8 RID: 19672
		// (get) Token: 0x06016F0D RID: 93965 RVA: 0x0035486C File Offset: 0x00352A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanEnterDungeonList
		{
			get
			{
				return this.canEnterDungeonList_;
			}
		}

		// Token: 0x17004CD9 RID: 19673
		// (get) Token: 0x06016F0E RID: 93966 RVA: 0x00354874 File Offset: 0x00352A74
		// (set) Token: 0x06016F0F RID: 93967 RVA: 0x0035487C File Offset: 0x00352A7C
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

		// Token: 0x17004CDA RID: 19674
		// (get) Token: 0x06016F10 RID: 93968 RVA: 0x00354885 File Offset: 0x00352A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrialRoleItem> TrialRoleItems
		{
			get
			{
				return this.trialRoleItems_;
			}
		}

		// Token: 0x06016F11 RID: 93969 RVA: 0x0035488D File Offset: 0x00352A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialOpenNotify);
		}

		// Token: 0x06016F12 RID: 93970 RVA: 0x0035489C File Offset: 0x00352A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialOpenNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.EnableMapAndTeleport == other.EnableMapAndTeleport && this.canEnterDungeonList_.Equals(other.canEnterDungeonList_) && this.ShowTips == other.ShowTips && this.trialRoleItems_.Equals(other.trialRoleItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016F13 RID: 93971 RVA: 0x00354924 File Offset: 0x00352B24
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

		// Token: 0x06016F14 RID: 93972 RVA: 0x003549A6 File Offset: 0x00352BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016F15 RID: 93973 RVA: 0x003549B3 File Offset: 0x00352BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016F16 RID: 93974 RVA: 0x003549BC File Offset: 0x00352BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EnableMapAndTeleport)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.EnableMapAndTeleport);
			}
			this.roleIds_.WriteTo(ref output, RoleTrialOpenNotify._repeated_roleIds_codec);
			this.trialRoleItems_.WriteTo(ref output, RoleTrialOpenNotify._repeated_trialRoleItems_codec);
			this.canEnterDungeonList_.WriteTo(ref output, RoleTrialOpenNotify._repeated_canEnterDungeonList_codec);
			if (this.ShowTips)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.ShowTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016F17 RID: 93975 RVA: 0x00354A48 File Offset: 0x00352C48
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

		// Token: 0x06016F18 RID: 93976 RVA: 0x00354AC0 File Offset: 0x00352CC0
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

		// Token: 0x06016F19 RID: 93977 RVA: 0x00354B43 File Offset: 0x00352D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016F1A RID: 93978 RVA: 0x00354B4C File Offset: 0x00352D4C
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
				if (num > 66U)
				{
					if (num <= 112U)
					{
						if (num == 90U)
						{
							this.trialRoleItems_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_trialRoleItems_codec);
							continue;
						}
						if (num != 112U)
						{
							goto IL_3D;
						}
					}
					else if (num != 114U)
					{
						if (num != 120U)
						{
							goto IL_3D;
						}
						this.ShowTips = input.ReadBool();
						continue;
					}
					this.canEnterDungeonList_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_canEnterDungeonList_codec);
					continue;
				}
				if (num == 32U)
				{
					this.EnableMapAndTeleport = input.ReadBool();
					continue;
				}
				if (num == 64U || num == 66U)
				{
					this.roleIds_.AddEntriesFrom(ref input, RoleTrialOpenNotify._repeated_roleIds_codec);
					continue;
				}
				IL_3D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040088A9 RID: 34985
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088AA RID: 34986
		public const int RoleIdsFieldNumber = 8;

		// Token: 0x040088AB RID: 34987
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(66U);

		// Token: 0x040088AC RID: 34988
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x040088AD RID: 34989
		public const int EnableMapAndTeleportFieldNumber = 4;

		// Token: 0x040088AE RID: 34990
		private bool enableMapAndTeleport_;

		// Token: 0x040088AF RID: 34991
		public const int CanEnterDungeonListFieldNumber = 14;

		// Token: 0x040088B0 RID: 34992
		private static readonly FieldCodec<int> _repeated_canEnterDungeonList_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040088B1 RID: 34993
		private readonly RepeatedField<int> canEnterDungeonList_ = new RepeatedField<int>();

		// Token: 0x040088B2 RID: 34994
		public const int ShowTipsFieldNumber = 15;

		// Token: 0x040088B3 RID: 34995
		private bool showTips_;

		// Token: 0x040088B4 RID: 34996
		public const int TrialRoleItemsFieldNumber = 11;

		// Token: 0x040088B5 RID: 34997
		private static readonly FieldCodec<TrialRoleItem> _repeated_trialRoleItems_codec = FieldCodec.ForMessage<TrialRoleItem>(90U, TrialRoleItem.Parser);

		// Token: 0x040088B6 RID: 34998
		private readonly RepeatedField<TrialRoleItem> trialRoleItems_ = new RepeatedField<TrialRoleItem>();
	}
}
