using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000355 RID: 853
	public sealed class DangoBrawlFightActionFatigueDamageInfo : IMessage<DangoBrawlFightActionFatigueDamageInfo>, IMessage, IEquatable<DangoBrawlFightActionFatigueDamageInfo>, IDeepCloneable<DangoBrawlFightActionFatigueDamageInfo>, IBufferMessage
	{
		// Token: 0x06005566 RID: 21862 RVA: 0x000D0464 File Offset: 0x000CE664
		[NullableContext(1)]
		public static DangoBrawlFightActionFatigueDamageInfo Create()
		{
			return new DangoBrawlFightActionFatigueDamageInfo();
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x000D046B File Offset: 0x000CE66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06005568 RID: 21864 RVA: 0x000D046E File Offset: 0x000CE66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionFatigueDamageInfo.Descriptor;
			}
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x000D0475 File Offset: 0x000CE675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo()
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x000D047D File Offset: 0x000CE67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo(DangoBrawlFightActionFatigueDamageInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600556B RID: 21867 RVA: 0x000D04AE File Offset: 0x000CE6AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo Clone()
		{
			return new DangoBrawlFightActionFatigueDamageInfo(this);
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x0600556C RID: 21868 RVA: 0x000D04B6 File Offset: 0x000CE6B6
		// (set) Token: 0x0600556D RID: 21869 RVA: 0x000D04BE File Offset: 0x000CE6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetFighterUId
		{
			get
			{
				return this.targetFighterUId_;
			}
			set
			{
				this.targetFighterUId_ = value;
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x0600556E RID: 21870 RVA: 0x000D04C7 File Offset: 0x000CE6C7
		// (set) Token: 0x0600556F RID: 21871 RVA: 0x000D04CF File Offset: 0x000CE6CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Damage
		{
			get
			{
				return this.damage_;
			}
			set
			{
				this.damage_ = value;
			}
		}

		// Token: 0x06005570 RID: 21872 RVA: 0x000D04D8 File Offset: 0x000CE6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionFatigueDamageInfo);
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x000D04E6 File Offset: 0x000CE6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionFatigueDamageInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.Damage == other.Damage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x000D0524 File Offset: 0x000CE724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			if (this.Damage != 0)
			{
				num ^= this.Damage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005573 RID: 21875 RVA: 0x000D057C File Offset: 0x000CE77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x000D0589 File Offset: 0x000CE789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x000D0594 File Offset: 0x000CE794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			if (this.Damage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Damage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005576 RID: 21878 RVA: 0x000D05EC File Offset: 0x000CE7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			if (this.Damage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Damage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005577 RID: 21879 RVA: 0x000D0644 File Offset: 0x000CE844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionFatigueDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			if (other.Damage != 0)
			{
				this.Damage = other.Damage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005578 RID: 21880 RVA: 0x000D0694 File Offset: 0x000CE894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005579 RID: 21881 RVA: 0x000D06A0 File Offset: 0x000CE8A0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Damage = input.ReadInt32();
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400346B RID: 13419
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400346C RID: 13420
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x0400346D RID: 13421
		private int targetFighterUId_;

		// Token: 0x0400346E RID: 13422
		public const int DamageFieldNumber = 2;

		// Token: 0x0400346F RID: 13423
		private int damage_;
	}
}
