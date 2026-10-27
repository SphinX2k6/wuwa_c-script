using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B42 RID: 2882
	public sealed class NewTowerRecommendTeam : IMessage<NewTowerRecommendTeam>, IMessage, IEquatable<NewTowerRecommendTeam>, IDeepCloneable<NewTowerRecommendTeam>, IBufferMessage
	{
		// Token: 0x0600FA07 RID: 64007 RVA: 0x00247352 File Offset: 0x00245552
		[NullableContext(1)]
		public static NewTowerRecommendTeam Create()
		{
			return new NewTowerRecommendTeam();
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600FA08 RID: 64008 RVA: 0x00247359 File Offset: 0x00245559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerRecommendTeam> Parser
		{
			get
			{
				return NewTowerRecommendTeam._parser;
			}
		}

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600FA09 RID: 64009 RVA: 0x00247360 File Offset: 0x00245560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600FA0A RID: 64010 RVA: 0x00247363 File Offset: 0x00245563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendTeam.Descriptor;
			}
		}

		// Token: 0x0600FA0B RID: 64011 RVA: 0x0024736A File Offset: 0x0024556A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendTeam()
		{
		}

		// Token: 0x0600FA0C RID: 64012 RVA: 0x00247394 File Offset: 0x00245594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendTeam(NewTowerRecommendTeam other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this.skillBranchIds_ = other.skillBranchIds_.Clone();
			this.buffIds_ = other.buffIds_.Clone();
			this.usageRate_ = other.usageRate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FA0D RID: 64013 RVA: 0x002473F7 File Offset: 0x002455F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendTeam Clone()
		{
			return new NewTowerRecommendTeam(this);
		}

		// Token: 0x170032FB RID: 13051
		// (get) Token: 0x0600FA0E RID: 64014 RVA: 0x002473FF File Offset: 0x002455FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600FA0F RID: 64015 RVA: 0x00247407 File Offset: 0x00245607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600FA10 RID: 64016 RVA: 0x0024740F File Offset: 0x0024560F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600FA11 RID: 64017 RVA: 0x00247417 File Offset: 0x00245617
		// (set) Token: 0x0600FA12 RID: 64018 RVA: 0x0024741F File Offset: 0x0024561F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UsageRate
		{
			get
			{
				return this.usageRate_;
			}
			set
			{
				this.usageRate_ = value;
			}
		}

		// Token: 0x0600FA13 RID: 64019 RVA: 0x00247428 File Offset: 0x00245628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendTeam);
		}

		// Token: 0x0600FA14 RID: 64020 RVA: 0x00247438 File Offset: 0x00245638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendTeam other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && this.buffIds_.Equals(other.buffIds_) && this.UsageRate == other.UsageRate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FA15 RID: 64021 RVA: 0x002474B0 File Offset: 0x002456B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			num ^= this.skillBranchIds_.GetHashCode();
			num ^= this.buffIds_.GetHashCode();
			if (this.UsageRate != 0)
			{
				num ^= this.UsageRate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FA16 RID: 64022 RVA: 0x00247519 File Offset: 0x00245719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FA17 RID: 64023 RVA: 0x00247526 File Offset: 0x00245726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FA18 RID: 64024 RVA: 0x00247530 File Offset: 0x00245730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, NewTowerRecommendTeam._repeated_roleIds_codec);
			this.skillBranchIds_.WriteTo(ref output, NewTowerRecommendTeam._repeated_skillBranchIds_codec);
			this.buffIds_.WriteTo(ref output, NewTowerRecommendTeam._repeated_buffIds_codec);
			if (this.UsageRate != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.UsageRate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FA19 RID: 64025 RVA: 0x002475A0 File Offset: 0x002457A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(NewTowerRecommendTeam._repeated_roleIds_codec);
			num += this.skillBranchIds_.CalculateSize(NewTowerRecommendTeam._repeated_skillBranchIds_codec);
			num += this.buffIds_.CalculateSize(NewTowerRecommendTeam._repeated_buffIds_codec);
			if (this.UsageRate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UsageRate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FA1A RID: 64026 RVA: 0x00247618 File Offset: 0x00245818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerRecommendTeam other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			this.skillBranchIds_.Add(other.skillBranchIds_);
			this.buffIds_.Add(other.buffIds_);
			if (other.UsageRate != 0)
			{
				this.UsageRate = other.UsageRate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FA1B RID: 64027 RVA: 0x00247687 File Offset: 0x00245887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FA1C RID: 64028 RVA: 0x00247690 File Offset: 0x00245890
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
				if (num > 16U)
				{
					if (num <= 24U)
					{
						if (num == 18U)
						{
							goto IL_63;
						}
						if (num != 24U)
						{
							goto IL_3C;
						}
					}
					else if (num != 26U)
					{
						if (num != 32U)
						{
							goto IL_3C;
						}
						this.UsageRate = input.ReadInt32();
						continue;
					}
					this.buffIds_.AddEntriesFrom(ref input, NewTowerRecommendTeam._repeated_buffIds_codec);
					continue;
				}
				if (num == 8U || num == 10U)
				{
					this.roleIds_.AddEntriesFrom(ref input, NewTowerRecommendTeam._repeated_roleIds_codec);
					continue;
				}
				if (num == 16U)
				{
					goto IL_63;
				}
				IL_3C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_63:
				this.skillBranchIds_.AddEntriesFrom(ref input, NewTowerRecommendTeam._repeated_skillBranchIds_codec);
			}
		}

		// Token: 0x04006418 RID: 25624
		private static readonly MessageParser<NewTowerRecommendTeam> _parser = new MessageParser<NewTowerRecommendTeam>(() => new NewTowerRecommendTeam());

		// Token: 0x04006419 RID: 25625
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400641A RID: 25626
		public const int RoleIdsFieldNumber = 1;

		// Token: 0x0400641B RID: 25627
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400641C RID: 25628
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x0400641D RID: 25629
		public const int SkillBranchIdsFieldNumber = 2;

		// Token: 0x0400641E RID: 25630
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400641F RID: 25631
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();

		// Token: 0x04006420 RID: 25632
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x04006421 RID: 25633
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006422 RID: 25634
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x04006423 RID: 25635
		public const int UsageRateFieldNumber = 4;

		// Token: 0x04006424 RID: 25636
		private int usageRate_;
	}
}
