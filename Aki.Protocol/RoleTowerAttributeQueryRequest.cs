using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010B8 RID: 4280
	[NetMessage(EMessageId.RoleTowerAttributeQueryRequest)]
	public sealed class RoleTowerAttributeQueryRequest : IMessage<RoleTowerAttributeQueryRequest>, IMessage, IEquatable<RoleTowerAttributeQueryRequest>, IDeepCloneable<RoleTowerAttributeQueryRequest>, IBufferMessage
	{
		// Token: 0x06016DE9 RID: 93673 RVA: 0x00352BA7 File Offset: 0x00350DA7
		[NullableContext(1)]
		public static RoleTowerAttributeQueryRequest Create()
		{
			return new RoleTowerAttributeQueryRequest();
		}

		// Token: 0x17004CA2 RID: 19618
		// (get) Token: 0x06016DEA RID: 93674 RVA: 0x00352BAE File Offset: 0x00350DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CA3 RID: 19619
		// (get) Token: 0x06016DEB RID: 93675 RVA: 0x00352BB1 File Offset: 0x00350DB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerAttributeQueryRequest.Descriptor;
			}
		}

		// Token: 0x06016DEC RID: 93676 RVA: 0x00352BB8 File Offset: 0x00350DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryRequest()
		{
		}

		// Token: 0x06016DED RID: 93677 RVA: 0x00352BCC File Offset: 0x00350DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryRequest(RoleTowerAttributeQueryRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.roleIds_ = other.roleIds_.Clone();
			this.useInitInstData_ = other.useInitInstData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016DEE RID: 93678 RVA: 0x00352C19 File Offset: 0x00350E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerAttributeQueryRequest Clone()
		{
			return new RoleTowerAttributeQueryRequest(this);
		}

		// Token: 0x17004CA4 RID: 19620
		// (get) Token: 0x06016DEF RID: 93679 RVA: 0x00352C21 File Offset: 0x00350E21
		// (set) Token: 0x06016DF0 RID: 93680 RVA: 0x00352C29 File Offset: 0x00350E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17004CA5 RID: 19621
		// (get) Token: 0x06016DF1 RID: 93681 RVA: 0x00352C32 File Offset: 0x00350E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x17004CA6 RID: 19622
		// (get) Token: 0x06016DF2 RID: 93682 RVA: 0x00352C3A File Offset: 0x00350E3A
		// (set) Token: 0x06016DF3 RID: 93683 RVA: 0x00352C42 File Offset: 0x00350E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool UseInitInstData
		{
			get
			{
				return this.useInitInstData_;
			}
			set
			{
				this.useInitInstData_ = value;
			}
		}

		// Token: 0x06016DF4 RID: 93684 RVA: 0x00352C4B File Offset: 0x00350E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerAttributeQueryRequest);
		}

		// Token: 0x06016DF5 RID: 93685 RVA: 0x00352C5C File Offset: 0x00350E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerAttributeQueryRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.roleIds_.Equals(other.roleIds_) && this.UseInitInstData == other.UseInitInstData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016DF6 RID: 93686 RVA: 0x00352CBC File Offset: 0x00350EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			num ^= this.roleIds_.GetHashCode();
			if (this.UseInitInstData)
			{
				num ^= this.UseInitInstData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016DF7 RID: 93687 RVA: 0x00352D22 File Offset: 0x00350F22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016DF8 RID: 93688 RVA: 0x00352D2F File Offset: 0x00350F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016DF9 RID: 93689 RVA: 0x00352D38 File Offset: 0x00350F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ChallengeId);
			}
			this.roleIds_.WriteTo(ref output, RoleTowerAttributeQueryRequest._repeated_roleIds_codec);
			if (this.UseInitInstData)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.UseInitInstData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016DFA RID: 93690 RVA: 0x00352DA4 File Offset: 0x00350FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			num += this.roleIds_.CalculateSize(RoleTowerAttributeQueryRequest._repeated_roleIds_codec);
			if (this.UseInitInstData)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016DFB RID: 93691 RVA: 0x00352E04 File Offset: 0x00351004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerAttributeQueryRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this.roleIds_.Add(other.roleIds_);
			if (other.UseInitInstData)
			{
				this.UseInitInstData = other.UseInitInstData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016DFC RID: 93692 RVA: 0x00352E65 File Offset: 0x00351065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016DFD RID: 93693 RVA: 0x00352E70 File Offset: 0x00351070
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
				if (num <= 72U)
				{
					if (num == 64U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.UseInitInstData = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.roleIds_.AddEntriesFrom(ref input, RoleTowerAttributeQueryRequest._repeated_roleIds_codec);
			}
		}

		// Token: 0x040088CC RID: 35020
		private UnknownFieldSet _unknownFields;

		// Token: 0x040088CD RID: 35021
		public const int ChallengeIdFieldNumber = 8;

		// Token: 0x040088CE RID: 35022
		private int challengeId_;

		// Token: 0x040088CF RID: 35023
		public const int RoleIdsFieldNumber = 9;

		// Token: 0x040088D0 RID: 35024
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040088D1 RID: 35025
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();

		// Token: 0x040088D2 RID: 35026
		public const int UseInitInstDataFieldNumber = 13;

		// Token: 0x040088D3 RID: 35027
		private bool useInitInstData_;
	}
}
