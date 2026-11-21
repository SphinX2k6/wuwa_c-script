using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003ED RID: 1005
	public sealed class DrinkMixRole : IMessage<DrinkMixRole>, IMessage, IEquatable<DrinkMixRole>, IDeepCloneable<DrinkMixRole>, IBufferMessage
	{
		// Token: 0x060061A5 RID: 24997 RVA: 0x000EB95D File Offset: 0x000E9B5D
		[NullableContext(1)]
		public static DrinkMixRole Create()
		{
			return new DrinkMixRole();
		}

		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x060061A6 RID: 24998 RVA: 0x000EB964 File Offset: 0x000E9B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DrinkMixRole> Parser
		{
			get
			{
				return DrinkMixRole._parser;
			}
		}

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x060061A7 RID: 24999 RVA: 0x000EB96B File Offset: 0x000E9B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x060061A8 RID: 25000 RVA: 0x000EB96E File Offset: 0x000E9B6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrinkMixRole.Descriptor;
			}
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x000EB975 File Offset: 0x000E9B75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixRole()
		{
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x000EB980 File Offset: 0x000E9B80
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

		// Token: 0x060061AB RID: 25003 RVA: 0x000EB9D4 File Offset: 0x000E9BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrinkMixRole Clone()
		{
			return new DrinkMixRole(this);
		}

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x060061AC RID: 25004 RVA: 0x000EB9DC File Offset: 0x000E9BDC
		// (set) Token: 0x060061AD RID: 25005 RVA: 0x000EB9E4 File Offset: 0x000E9BE4
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

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x060061AE RID: 25006 RVA: 0x000EB9ED File Offset: 0x000E9BED
		// (set) Token: 0x060061AF RID: 25007 RVA: 0x000EB9F5 File Offset: 0x000E9BF5
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

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x060061B0 RID: 25008 RVA: 0x000EB9FE File Offset: 0x000E9BFE
		// (set) Token: 0x060061B1 RID: 25009 RVA: 0x000EBA06 File Offset: 0x000E9C06
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

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x060061B2 RID: 25010 RVA: 0x000EBA0F File Offset: 0x000E9C0F
		// (set) Token: 0x060061B3 RID: 25011 RVA: 0x000EBA17 File Offset: 0x000E9C17
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

		// Token: 0x060061B4 RID: 25012 RVA: 0x000EBA20 File Offset: 0x000E9C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrinkMixRole);
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x000EBA30 File Offset: 0x000E9C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrinkMixRole other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.FirstPass == other.FirstPass && this.MaxLike == other.MaxLike && this.RewardGet == other.RewardGet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x000EBA9C File Offset: 0x000E9C9C
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

		// Token: 0x060061B7 RID: 25015 RVA: 0x000EBB26 File Offset: 0x000E9D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x000EBB33 File Offset: 0x000E9D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x000EBB3C File Offset: 0x000E9D3C
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

		// Token: 0x060061BA RID: 25018 RVA: 0x000EBBCC File Offset: 0x000E9DCC
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

		// Token: 0x060061BB RID: 25019 RVA: 0x000EBC30 File Offset: 0x000E9E30
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

		// Token: 0x060061BC RID: 25020 RVA: 0x000EBCA8 File Offset: 0x000E9EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x000EBCB4 File Offset: 0x000E9EB4
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

		// Token: 0x040037FE RID: 14334
		private static readonly MessageParser<DrinkMixRole> _parser = new MessageParser<DrinkMixRole>(() => new DrinkMixRole());

		// Token: 0x040037FF RID: 14335
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003800 RID: 14336
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04003801 RID: 14337
		private int roleId_;

		// Token: 0x04003802 RID: 14338
		public const int FirstPassFieldNumber = 2;

		// Token: 0x04003803 RID: 14339
		private bool firstPass_;

		// Token: 0x04003804 RID: 14340
		public const int MaxLikeFieldNumber = 3;

		// Token: 0x04003805 RID: 14341
		private bool maxLike_;

		// Token: 0x04003806 RID: 14342
		public const int RewardGetFieldNumber = 4;

		// Token: 0x04003807 RID: 14343
		private bool rewardGet_;
	}
}
