using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B31 RID: 2865
	public sealed class NewTowerRecommendTeam : IMessage<NewTowerRecommendTeam>, IMessage, IEquatable<NewTowerRecommendTeam>, IDeepCloneable<NewTowerRecommendTeam>, IBufferMessage
	{
		// Token: 0x0600F8ED RID: 63725 RVA: 0x0024513B File Offset: 0x0024333B
		[NullableContext(1)]
		public static NewTowerRecommendTeam Create()
		{
			return new NewTowerRecommendTeam();
		}

		// Token: 0x170032BA RID: 12986
		// (get) Token: 0x0600F8EE RID: 63726 RVA: 0x00245142 File Offset: 0x00243342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewTowerRecommendTeam> Parser
		{
			get
			{
				return NewTowerRecommendTeam._parser;
			}
		}

		// Token: 0x170032BB RID: 12987
		// (get) Token: 0x0600F8EF RID: 63727 RVA: 0x00245149 File Offset: 0x00243349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032BC RID: 12988
		// (get) Token: 0x0600F8F0 RID: 63728 RVA: 0x0024514C File Offset: 0x0024334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerRecommendTeam.Descriptor;
			}
		}

		// Token: 0x0600F8F1 RID: 63729 RVA: 0x00245153 File Offset: 0x00243353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendTeam()
		{
		}

		// Token: 0x0600F8F2 RID: 63730 RVA: 0x0024517C File Offset: 0x0024337C
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

		// Token: 0x0600F8F3 RID: 63731 RVA: 0x002451DF File Offset: 0x002433DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerRecommendTeam Clone()
		{
			return new NewTowerRecommendTeam(this);
		}

		// Token: 0x170032BD RID: 12989
		// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x002451E7 File Offset: 0x002433E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170032BE RID: 12990
		// (get) Token: 0x0600F8F5 RID: 63733 RVA: 0x002451EF File Offset: 0x002433EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkillBranchIds
		{
			get
			{
				return this.skillBranchIds_;
			}
		}

		// Token: 0x170032BF RID: 12991
		// (get) Token: 0x0600F8F6 RID: 63734 RVA: 0x002451F7 File Offset: 0x002433F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x170032C0 RID: 12992
		// (get) Token: 0x0600F8F7 RID: 63735 RVA: 0x002451FF File Offset: 0x002433FF
		// (set) Token: 0x0600F8F8 RID: 63736 RVA: 0x00245207 File Offset: 0x00243407
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

		// Token: 0x0600F8F9 RID: 63737 RVA: 0x00245210 File Offset: 0x00243410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerRecommendTeam);
		}

		// Token: 0x0600F8FA RID: 63738 RVA: 0x00245220 File Offset: 0x00243420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerRecommendTeam other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && this.skillBranchIds_.Equals(other.skillBranchIds_) && this.buffIds_.Equals(other.buffIds_) && this.UsageRate == other.UsageRate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F8FB RID: 63739 RVA: 0x00245298 File Offset: 0x00243498
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

		// Token: 0x0600F8FC RID: 63740 RVA: 0x00245301 File Offset: 0x00243501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F8FD RID: 63741 RVA: 0x0024530E File Offset: 0x0024350E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F8FE RID: 63742 RVA: 0x00245318 File Offset: 0x00243518
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

		// Token: 0x0600F8FF RID: 63743 RVA: 0x00245388 File Offset: 0x00243588
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

		// Token: 0x0600F900 RID: 63744 RVA: 0x00245400 File Offset: 0x00243600
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

		// Token: 0x0600F901 RID: 63745 RVA: 0x0024546F File Offset: 0x0024366F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F902 RID: 63746 RVA: 0x00245478 File Offset: 0x00243678
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

		// Token: 0x04006421 RID: 25633
		private static readonly MessageParser<NewTowerRecommendTeam> _parser = new MessageParser<NewTowerRecommendTeam>(() => new NewTowerRecommendTeam());

		// Token: 0x04006422 RID: 25634
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006423 RID: 25635
		public const int RoleIdsFieldNumber = 1;

		// Token: 0x04006424 RID: 25636
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04006425 RID: 25637
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04006426 RID: 25638
		public const int SkillBranchIdsFieldNumber = 2;

		// Token: 0x04006427 RID: 25639
		private static readonly FieldCodec<int> _repeated_skillBranchIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006428 RID: 25640
		private readonly RepeatedField<int> skillBranchIds_ = new RepeatedField<int>();

		// Token: 0x04006429 RID: 25641
		public const int BuffIdsFieldNumber = 3;

		// Token: 0x0400642A RID: 25642
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400642B RID: 25643
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();

		// Token: 0x0400642C RID: 25644
		public const int UsageRateFieldNumber = 4;

		// Token: 0x0400642D RID: 25645
		private int usageRate_;
	}
}
