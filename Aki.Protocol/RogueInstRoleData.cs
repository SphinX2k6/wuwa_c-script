using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8C RID: 3980
	public sealed class RogueInstRoleData : IMessage<RogueInstRoleData>, IMessage, IEquatable<RogueInstRoleData>, IDeepCloneable<RogueInstRoleData>, IBufferMessage
	{
		// Token: 0x06015485 RID: 87173 RVA: 0x003165DC File Offset: 0x003147DC
		[NullableContext(1)]
		public static RogueInstRoleData Create()
		{
			return new RogueInstRoleData();
		}

		// Token: 0x170046E1 RID: 18145
		// (get) Token: 0x06015486 RID: 87174 RVA: 0x003165E3 File Offset: 0x003147E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueInstRoleData> Parser
		{
			get
			{
				return RogueInstRoleData._parser;
			}
		}

		// Token: 0x170046E2 RID: 18146
		// (get) Token: 0x06015487 RID: 87175 RVA: 0x003165EA File Offset: 0x003147EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046E3 RID: 18147
		// (get) Token: 0x06015488 RID: 87176 RVA: 0x003165ED File Offset: 0x003147ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstRoleData.Descriptor;
			}
		}

		// Token: 0x06015489 RID: 87177 RVA: 0x003165F4 File Offset: 0x003147F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstRoleData()
		{
		}

		// Token: 0x0601548A RID: 87178 RVA: 0x00316620 File Offset: 0x00314820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstRoleData(RogueInstRoleData other) : this()
		{
			this.instId_ = other.instId_;
			this.validTrialRoleIds_ = other.validTrialRoleIds_.Clone();
			this.roleIds_ = other.roleIds_.Clone();
			this.lockRoleIds_ = other.lockRoleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601548B RID: 87179 RVA: 0x00316683 File Offset: 0x00314883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstRoleData Clone()
		{
			return new RogueInstRoleData(this);
		}

		// Token: 0x170046E4 RID: 18148
		// (get) Token: 0x0601548C RID: 87180 RVA: 0x0031668B File Offset: 0x0031488B
		// (set) Token: 0x0601548D RID: 87181 RVA: 0x00316693 File Offset: 0x00314893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170046E5 RID: 18149
		// (get) Token: 0x0601548E RID: 87182 RVA: 0x0031669C File Offset: 0x0031489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ValidTrialRoleIds
		{
			get
			{
				return this.validTrialRoleIds_;
			}
		}

		// Token: 0x170046E6 RID: 18150
		// (get) Token: 0x0601548F RID: 87183 RVA: 0x003166A4 File Offset: 0x003148A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170046E7 RID: 18151
		// (get) Token: 0x06015490 RID: 87184 RVA: 0x003166AC File Offset: 0x003148AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockRoleIds
		{
			get
			{
				return this.lockRoleIds_;
			}
		}

		// Token: 0x06015491 RID: 87185 RVA: 0x003166B4 File Offset: 0x003148B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstRoleData);
		}

		// Token: 0x06015492 RID: 87186 RVA: 0x003166C4 File Offset: 0x003148C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstRoleData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.validTrialRoleIds_.Equals(other.validTrialRoleIds_) && this.roleIds_.Equals(other.roleIds_) && this.lockRoleIds_.Equals(other.lockRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015493 RID: 87187 RVA: 0x0031673C File Offset: 0x0031493C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			num ^= this.validTrialRoleIds_.GetHashCode();
			num ^= this.roleIds_.GetHashCode();
			num ^= this.lockRoleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x003167A5 File Offset: 0x003149A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015495 RID: 87189 RVA: 0x003167B2 File Offset: 0x003149B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015496 RID: 87190 RVA: 0x003167BC File Offset: 0x003149BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			this.validTrialRoleIds_.WriteTo(ref output, RogueInstRoleData._repeated_validTrialRoleIds_codec);
			this.roleIds_.WriteTo(ref output, RogueInstRoleData._repeated_roleIds_codec);
			this.lockRoleIds_.WriteTo(ref output, RogueInstRoleData._repeated_lockRoleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015497 RID: 87191 RVA: 0x0031682C File Offset: 0x00314A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			num += this.validTrialRoleIds_.CalculateSize(RogueInstRoleData._repeated_validTrialRoleIds_codec);
			num += this.roleIds_.CalculateSize(RogueInstRoleData._repeated_roleIds_codec);
			num += this.lockRoleIds_.CalculateSize(RogueInstRoleData._repeated_lockRoleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x003168A4 File Offset: 0x00314AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstRoleData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this.validTrialRoleIds_.Add(other.validTrialRoleIds_);
			this.roleIds_.Add(other.roleIds_);
			this.lockRoleIds_.Add(other.lockRoleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015499 RID: 87193 RVA: 0x00316913 File Offset: 0x00314B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601549A RID: 87194 RVA: 0x0031691C File Offset: 0x00314B1C
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.InstId = input.ReadInt32();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.validTrialRoleIds_.AddEntriesFrom(ref input, RogueInstRoleData._repeated_validTrialRoleIds_codec);
						continue;
					}
				}
				else if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.roleIds_.AddEntriesFrom(ref input, RogueInstRoleData._repeated_roleIds_codec);
						continue;
					}
				}
				else if (num == 32U || num == 34U)
				{
					this.lockRoleIds_.AddEntriesFrom(ref input, RogueInstRoleData._repeated_lockRoleIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008006 RID: 32774
		private static readonly MessageParser<RogueInstRoleData> _parser = new MessageParser<RogueInstRoleData>(() => new RogueInstRoleData());

		// Token: 0x04008007 RID: 32775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008008 RID: 32776
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008009 RID: 32777
		private int instId_;

		// Token: 0x0400800A RID: 32778
		public const int ValidTrialRoleIdsFieldNumber = 2;

		// Token: 0x0400800B RID: 32779
		private static readonly FieldCodec<int> _repeated_validTrialRoleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400800C RID: 32780
		private readonly RepeatedField<int> validTrialRoleIds_ = new RepeatedField<int>();

		// Token: 0x0400800D RID: 32781
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x0400800E RID: 32782
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400800F RID: 32783
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x04008010 RID: 32784
		public const int LockRoleIdsFieldNumber = 4;

		// Token: 0x04008011 RID: 32785
		private static readonly FieldCodec<int> _repeated_lockRoleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008012 RID: 32786
		private readonly RepeatedField<int> lockRoleIds_ = new RepeatedField<int>();
	}
}
