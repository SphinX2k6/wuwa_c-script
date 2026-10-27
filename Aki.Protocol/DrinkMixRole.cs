using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000404 RID: 1028
	public sealed class DrinkMixRole : IMessage<DrinkMixRole>, IMessage, IEquatable<DrinkMixRole>, IDeepCloneable<DrinkMixRole>, IBufferMessage
	{
		// Token: 0x06006335 RID: 25397 RVA: 0x000EEAD5 File Offset: 0x000ECCD5
		[NullableContext(1)]
		public static DrinkMixRole Create()
		{
			return new DrinkMixRole();
		}

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x000EEADC File Offset: 0x000ECCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMixRole> Parser
		{
			get
			{
				return DrinkMixRole._parser;
			}
		}

		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x000EEAE3 File Offset: 0x000ECCE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001283 RID: 4739
		// (get) Token: 0x06006338 RID: 25400 RVA: 0x000EEAE6 File Offset: 0x000ECCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMixRole.Descriptor;
			}
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x000EEAED File Offset: 0x000ECCED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixRole()
		{
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x000EEAF8 File Offset: 0x000ECCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixRole(DrinkMixRole other) : this()
		{
			this.roleId_ = other.roleId_;
			this.firstPass_ = other.firstPass_;
			this.maxLike_ = other.maxLike_;
			this.rewardGet_ = other.rewardGet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x000EEB4C File Offset: 0x000ECD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixRole Clone()
		{
			return new DrinkMixRole(this);
		}

		// Token: 0x17001284 RID: 4740
		// (get) Token: 0x0600633C RID: 25404 RVA: 0x000EEB54 File Offset: 0x000ECD54
		// (set) Token: 0x0600633D RID: 25405 RVA: 0x000EEB5C File Offset: 0x000ECD5C
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

		// Token: 0x17001285 RID: 4741
		// (get) Token: 0x0600633E RID: 25406 RVA: 0x000EEB65 File Offset: 0x000ECD65
		// (set) Token: 0x0600633F RID: 25407 RVA: 0x000EEB6D File Offset: 0x000ECD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstPass
		{
			get
			{
				return this.firstPass_;
			}
			set
			{
				this.firstPass_ = value;
			}
		}

		// Token: 0x17001286 RID: 4742
		// (get) Token: 0x06006340 RID: 25408 RVA: 0x000EEB76 File Offset: 0x000ECD76
		// (set) Token: 0x06006341 RID: 25409 RVA: 0x000EEB7E File Offset: 0x000ECD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MaxLike
		{
			get
			{
				return this.maxLike_;
			}
			set
			{
				this.maxLike_ = value;
			}
		}

		// Token: 0x17001287 RID: 4743
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x000EEB87 File Offset: 0x000ECD87
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x000EEB8F File Offset: 0x000ECD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool RewardGet
		{
			get
			{
				return this.rewardGet_;
			}
			set
			{
				this.rewardGet_ = value;
			}
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x000EEB98 File Offset: 0x000ECD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMixRole);
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x000EEBA8 File Offset: 0x000ECDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMixRole other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.FirstPass == other.FirstPass && this.MaxLike == other.MaxLike && this.RewardGet == other.RewardGet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x000EEC14 File Offset: 0x000ECE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.FirstPass)
			{
				num ^= this.FirstPass.GetHashCode();
			}
			if (this.MaxLike)
			{
				num ^= this.MaxLike.GetHashCode();
			}
			if (this.RewardGet)
			{
				num ^= this.RewardGet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x000EEC9E File Offset: 0x000ECE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x000EECAB File Offset: 0x000ECEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x000EECB4 File Offset: 0x000ECEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.FirstPass)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.FirstPass);
			}
			if (this.MaxLike)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.MaxLike);
			}
			if (this.RewardGet)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.RewardGet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x000EED44 File Offset: 0x000ECF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.FirstPass)
			{
				num += 2;
			}
			if (this.MaxLike)
			{
				num += 2;
			}
			if (this.RewardGet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x000EEDA8 File Offset: 0x000ECFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrinkMixRole other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.FirstPass)
			{
				this.FirstPass = other.FirstPass;
			}
			if (other.MaxLike)
			{
				this.MaxLike = other.MaxLike;
			}
			if (other.RewardGet)
			{
				this.RewardGet = other.RewardGet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x000EEE20 File Offset: 0x000ED020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x000EEE2C File Offset: 0x000ED02C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FirstPass = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxLike = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.RewardGet = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003811 RID: 14353
		private static readonly MessageParser<DrinkMixRole> _parser = new MessageParser<DrinkMixRole>(() => new DrinkMixRole());

		// Token: 0x04003812 RID: 14354
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003813 RID: 14355
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003814 RID: 14356
		private int roleId_;

		// Token: 0x04003815 RID: 14357
		public const int FirstPassFieldNumber = 2;

		// Token: 0x04003816 RID: 14358
		private bool firstPass_;

		// Token: 0x04003817 RID: 14359
		public const int MaxLikeFieldNumber = 3;

		// Token: 0x04003818 RID: 14360
		private bool maxLike_;

		// Token: 0x04003819 RID: 14361
		public const int RewardGetFieldNumber = 4;

		// Token: 0x0400381A RID: 14362
		private bool rewardGet_;
	}
}
