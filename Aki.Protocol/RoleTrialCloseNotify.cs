using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001102 RID: 4354
	[NetMessage(EMessageId.RoleTrialCloseNotify)]
	public sealed class RoleTrialCloseNotify : IMessage<RoleTrialCloseNotify>, IMessage, IEquatable<RoleTrialCloseNotify>, IDeepCloneable<RoleTrialCloseNotify>, IBufferMessage
	{
		// Token: 0x06017466 RID: 95334 RVA: 0x003631F8 File Offset: 0x003613F8
		[NullableContext(1)]
		public static RoleTrialCloseNotify Create()
		{
			return new RoleTrialCloseNotify();
		}

		// Token: 0x17004E32 RID: 20018
		// (get) Token: 0x06017467 RID: 95335 RVA: 0x003631FF File Offset: 0x003613FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E33 RID: 20019
		// (get) Token: 0x06017468 RID: 95336 RVA: 0x00363202 File Offset: 0x00361402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTrialCloseNotify.Descriptor;
			}
		}

		// Token: 0x06017469 RID: 95337 RVA: 0x00363209 File Offset: 0x00361409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify()
		{
		}

		// Token: 0x0601746A RID: 95338 RVA: 0x00363228 File Offset: 0x00361428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify(RoleTrialCloseNotify other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this.enableMapAndTeleport_ = other.enableMapAndTeleport_;
			this.canEnterDungeonList_ = other.canEnterDungeonList_.Clone();
			this.showTips_ = other.showTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601746B RID: 95339 RVA: 0x00363286 File Offset: 0x00361486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTrialCloseNotify Clone()
		{
			return new RoleTrialCloseNotify(this);
		}

		// Token: 0x17004E34 RID: 20020
		// (get) Token: 0x0601746C RID: 95340 RVA: 0x0036328E File Offset: 0x0036148E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004E35 RID: 20021
		// (get) Token: 0x0601746D RID: 95341 RVA: 0x00363296 File Offset: 0x00361496
		// (set) Token: 0x0601746E RID: 95342 RVA: 0x0036329E File Offset: 0x0036149E
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

		// Token: 0x17004E36 RID: 20022
		// (get) Token: 0x0601746F RID: 95343 RVA: 0x003632A7 File Offset: 0x003614A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CanEnterDungeonList
		{
			get
			{
				return this.canEnterDungeonList_;
			}
		}

		// Token: 0x17004E37 RID: 20023
		// (get) Token: 0x06017470 RID: 95344 RVA: 0x003632AF File Offset: 0x003614AF
		// (set) Token: 0x06017471 RID: 95345 RVA: 0x003632B7 File Offset: 0x003614B7
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

		// Token: 0x06017472 RID: 95346 RVA: 0x003632C0 File Offset: 0x003614C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTrialCloseNotify);
		}

		// Token: 0x06017473 RID: 95347 RVA: 0x003632D0 File Offset: 0x003614D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTrialCloseNotify other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.EnableMapAndTeleport == other.EnableMapAndTeleport && this.canEnterDungeonList_.Equals(other.canEnterDungeonList_) && this.ShowTips == other.ShowTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017474 RID: 95348 RVA: 0x00363344 File Offset: 0x00361544
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017475 RID: 95349 RVA: 0x003633B8 File Offset: 0x003615B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017476 RID: 95350 RVA: 0x003633C5 File Offset: 0x003615C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017477 RID: 95351 RVA: 0x003633D0 File Offset: 0x003615D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowTips)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowTips);
			}
			if (this.EnableMapAndTeleport)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.EnableMapAndTeleport);
			}
			this.roleIds_.WriteTo(ref output, RoleTrialCloseNotify._repeated_roleIds_codec);
			this.canEnterDungeonList_.WriteTo(ref output, RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017478 RID: 95352 RVA: 0x0036344C File Offset: 0x0036164C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(RoleTrialCloseNotify._repeated_roleIds_codec);
			if (this.EnableMapAndTeleport)
			{
				num += 2;
			}
			num += this.canEnterDungeonList_.CalculateSize(RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
			if (this.ShowTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017479 RID: 95353 RVA: 0x003634B0 File Offset: 0x003616B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTrialCloseNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601747A RID: 95354 RVA: 0x00363522 File Offset: 0x00361722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601747B RID: 95355 RVA: 0x0036352C File Offset: 0x0036172C
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
				if (num <= 56U)
				{
					if (num == 16U)
					{
						this.ShowTips = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.EnableMapAndTeleport = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						goto IL_61;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_61;
					}
					if (num == 88U || num == 90U)
					{
						this.canEnterDungeonList_.AddEntriesFrom(ref input, RoleTrialCloseNotify._repeated_canEnterDungeonList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_61:
				this.roleIds_.AddEntriesFrom(ref input, RoleTrialCloseNotify._repeated_roleIds_codec);
			}
		}

		// Token: 0x04008B26 RID: 35622
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B27 RID: 35623
		public const int RoleIdsFieldNumber = 7;

		// Token: 0x04008B28 RID: 35624
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008B29 RID: 35625
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008B2A RID: 35626
		public const int EnableMapAndTeleportFieldNumber = 5;

		// Token: 0x04008B2B RID: 35627
		private bool enableMapAndTeleport_;

		// Token: 0x04008B2C RID: 35628
		public const int CanEnterDungeonListFieldNumber = 11;

		// Token: 0x04008B2D RID: 35629
		private static readonly FieldCodec<int> _repeated_canEnterDungeonList_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04008B2E RID: 35630
		private readonly RepeatedField<int> canEnterDungeonList_ = new RepeatedField<int>();

		// Token: 0x04008B2F RID: 35631
		public const int ShowTipsFieldNumber = 2;

		// Token: 0x04008B30 RID: 35632
		private bool showTips_;
	}
}
