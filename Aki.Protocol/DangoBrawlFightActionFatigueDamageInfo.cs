using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034D RID: 845
	public sealed class DangoBrawlFightActionFatigueDamageInfo : IMessage<DangoBrawlFightActionFatigueDamageInfo>, IMessage, IEquatable<DangoBrawlFightActionFatigueDamageInfo>, IDeepCloneable<DangoBrawlFightActionFatigueDamageInfo>, IBufferMessage
	{
		// Token: 0x06005479 RID: 21625 RVA: 0x000CDDD8 File Offset: 0x000CBFD8
		[NullableContext(1)]
		public static DangoBrawlFightActionFatigueDamageInfo Create()
		{
			return new DangoBrawlFightActionFatigueDamageInfo();
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600547A RID: 21626 RVA: 0x000CDDDF File Offset: 0x000CBFDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x0600547B RID: 21627 RVA: 0x000CDDE2 File Offset: 0x000CBFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionFatigueDamageInfo.Descriptor;
			}
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x000CDDE9 File Offset: 0x000CBFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo()
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x000CDDF1 File Offset: 0x000CBFF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo(DangoBrawlFightActionFatigueDamageInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damage_ = other.damage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600547E RID: 21630 RVA: 0x000CDE22 File Offset: 0x000CC022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionFatigueDamageInfo Clone()
		{
			return new DangoBrawlFightActionFatigueDamageInfo(this);
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600547F RID: 21631 RVA: 0x000CDE2A File Offset: 0x000CC02A
		// (set) Token: 0x06005480 RID: 21632 RVA: 0x000CDE32 File Offset: 0x000CC032
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

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06005481 RID: 21633 RVA: 0x000CDE3B File Offset: 0x000CC03B
		// (set) Token: 0x06005482 RID: 21634 RVA: 0x000CDE43 File Offset: 0x000CC043
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

		// Token: 0x06005483 RID: 21635 RVA: 0x000CDE4C File Offset: 0x000CC04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionFatigueDamageInfo);
		}

		// Token: 0x06005484 RID: 21636 RVA: 0x000CDE5A File Offset: 0x000CC05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionFatigueDamageInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.Damage == other.Damage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005485 RID: 21637 RVA: 0x000CDE98 File Offset: 0x000CC098
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

		// Token: 0x06005486 RID: 21638 RVA: 0x000CDEF0 File Offset: 0x000CC0F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x000CDEFD File Offset: 0x000CC0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x000CDF08 File Offset: 0x000CC108
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

		// Token: 0x06005489 RID: 21641 RVA: 0x000CDF60 File Offset: 0x000CC160
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

		// Token: 0x0600548A RID: 21642 RVA: 0x000CDFB8 File Offset: 0x000CC1B8
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

		// Token: 0x0600548B RID: 21643 RVA: 0x000CE008 File Offset: 0x000CC208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600548C RID: 21644 RVA: 0x000CE014 File Offset: 0x000CC214
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

		// Token: 0x040033CF RID: 13263
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D0 RID: 13264
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x040033D1 RID: 13265
		private int targetFighterUId_;

		// Token: 0x040033D2 RID: 13266
		public const int DamageFieldNumber = 2;

		// Token: 0x040033D3 RID: 13267
		private int damage_;
	}
}
