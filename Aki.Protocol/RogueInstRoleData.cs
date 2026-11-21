using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F7C RID: 3964
	public sealed class RogueInstRoleData : IMessage<RogueInstRoleData>, IMessage, IEquatable<RogueInstRoleData>, IDeepCloneable<RogueInstRoleData>, IBufferMessage
	{
		// Token: 0x060153A0 RID: 86944 RVA: 0x00314F28 File Offset: 0x00313128
		[NullableContext(1)]
		public static RogueInstRoleData Create()
		{
			return new RogueInstRoleData();
		}

		// Token: 0x170046B7 RID: 18103
		// (get) Token: 0x060153A1 RID: 86945 RVA: 0x00314F2F File Offset: 0x0031312F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueInstRoleData> Parser
		{
			get
			{
				return RogueInstRoleData._parser;
			}
		}

		// Token: 0x170046B8 RID: 18104
		// (get) Token: 0x060153A2 RID: 86946 RVA: 0x00314F36 File Offset: 0x00313136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046B9 RID: 18105
		// (get) Token: 0x060153A3 RID: 86947 RVA: 0x00314F39 File Offset: 0x00313139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstRoleData.Descriptor;
			}
		}

		// Token: 0x060153A4 RID: 86948 RVA: 0x00314F40 File Offset: 0x00313140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstRoleData()
		{
		}

		// Token: 0x060153A5 RID: 86949 RVA: 0x00314F6C File Offset: 0x0031316C
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

		// Token: 0x060153A6 RID: 86950 RVA: 0x00314FCF File Offset: 0x003131CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstRoleData Clone()
		{
			return new RogueInstRoleData(this);
		}

		// Token: 0x170046BA RID: 18106
		// (get) Token: 0x060153A7 RID: 86951 RVA: 0x00314FD7 File Offset: 0x003131D7
		// (set) Token: 0x060153A8 RID: 86952 RVA: 0x00314FDF File Offset: 0x003131DF
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

		// Token: 0x170046BB RID: 18107
		// (get) Token: 0x060153A9 RID: 86953 RVA: 0x00314FE8 File Offset: 0x003131E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ValidTrialRoleIds
		{
			get
			{
				return this.validTrialRoleIds_;
			}
		}

		// Token: 0x170046BC RID: 18108
		// (get) Token: 0x060153AA RID: 86954 RVA: 0x00314FF0 File Offset: 0x003131F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x170046BD RID: 18109
		// (get) Token: 0x060153AB RID: 86955 RVA: 0x00314FF8 File Offset: 0x003131F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> LockRoleIds
		{
			get
			{
				return this.lockRoleIds_;
			}
		}

		// Token: 0x060153AC RID: 86956 RVA: 0x00315000 File Offset: 0x00313200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstRoleData);
		}

		// Token: 0x060153AD RID: 86957 RVA: 0x00315010 File Offset: 0x00313210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstRoleData other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.validTrialRoleIds_.Equals(other.validTrialRoleIds_) && this.roleIds_.Equals(other.roleIds_) && this.lockRoleIds_.Equals(other.lockRoleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060153AE RID: 86958 RVA: 0x00315088 File Offset: 0x00313288
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

		// Token: 0x060153AF RID: 86959 RVA: 0x003150F1 File Offset: 0x003132F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060153B0 RID: 86960 RVA: 0x003150FE File Offset: 0x003132FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060153B1 RID: 86961 RVA: 0x00315108 File Offset: 0x00313308
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

		// Token: 0x060153B2 RID: 86962 RVA: 0x00315178 File Offset: 0x00313378
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

		// Token: 0x060153B3 RID: 86963 RVA: 0x003151F0 File Offset: 0x003133F0
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

		// Token: 0x060153B4 RID: 86964 RVA: 0x0031525F File Offset: 0x0031345F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060153B5 RID: 86965 RVA: 0x00315268 File Offset: 0x00313468
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

		// Token: 0x04008030 RID: 32816
		private static readonly MessageParser<RogueInstRoleData> _parser = new MessageParser<RogueInstRoleData>(() => new RogueInstRoleData());

		// Token: 0x04008031 RID: 32817
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008032 RID: 32818
		public const int InstIdFieldNumber = 1;

		// Token: 0x04008033 RID: 32819
		private int instId_;

		// Token: 0x04008034 RID: 32820
		public const int ValidTrialRoleIdsFieldNumber = 2;

		// Token: 0x04008035 RID: 32821
		private static readonly FieldCodec<int> _repeated_validTrialRoleIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04008036 RID: 32822
		private readonly RepeatedField<int> validTrialRoleIds_ = new RepeatedField<int>();

		// Token: 0x04008037 RID: 32823
		public const int RoleIdsFieldNumber = 3;

		// Token: 0x04008038 RID: 32824
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008039 RID: 32825
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x0400803A RID: 32826
		public const int LockRoleIdsFieldNumber = 4;

		// Token: 0x0400803B RID: 32827
		private static readonly FieldCodec<int> _repeated_lockRoleIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400803C RID: 32828
		private readonly RepeatedField<int> lockRoleIds_ = new RepeatedField<int>();
	}
}
