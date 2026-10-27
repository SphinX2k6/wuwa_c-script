using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000353 RID: 851
	public sealed class DangoBrawlFightActionReflectDamageInfo : IMessage<DangoBrawlFightActionReflectDamageInfo>, IMessage, IEquatable<DangoBrawlFightActionReflectDamageInfo>, IDeepCloneable<DangoBrawlFightActionReflectDamageInfo>, IBufferMessage
	{
		// Token: 0x06005515 RID: 21781 RVA: 0x000CFE9F File Offset: 0x000CE09F
		[NullableContext(1)]
		public static DangoBrawlFightActionReflectDamageInfo Create()
		{
			return new DangoBrawlFightActionReflectDamageInfo();
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x000CFEA6 File Offset: 0x000CE0A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06005517 RID: 21783 RVA: 0x000CFEA9 File Offset: 0x000CE0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlFightActionReflectDamageInfo.Descriptor;
			}
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x000CFEB0 File Offset: 0x000CE0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo()
		{
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x000CFEC3 File Offset: 0x000CE0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo(DangoBrawlFightActionReflectDamageInfo other) : this()
		{
			this.targetFighterUId_ = other.targetFighterUId_;
			this.damages_ = other.damages_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x000CFEF9 File Offset: 0x000CE0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlFightActionReflectDamageInfo Clone()
		{
			return new DangoBrawlFightActionReflectDamageInfo(this);
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x0600551B RID: 21787 RVA: 0x000CFF01 File Offset: 0x000CE101
		// (set) Token: 0x0600551C RID: 21788 RVA: 0x000CFF09 File Offset: 0x000CE109
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

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x0600551D RID: 21789 RVA: 0x000CFF12 File Offset: 0x000CE112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Damages
		{
			get
			{
				return this.damages_;
			}
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000CFF1A File Offset: 0x000CE11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlFightActionReflectDamageInfo);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x000CFF28 File Offset: 0x000CE128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlFightActionReflectDamageInfo other)
		{
			return other != null && (other == this || (this.TargetFighterUId == other.TargetFighterUId && this.damages_.Equals(other.damages_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x000CFF78 File Offset: 0x000CE178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetFighterUId != 0)
			{
				num ^= this.TargetFighterUId.GetHashCode();
			}
			num ^= this.damages_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x000CFFC5 File Offset: 0x000CE1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x000CFFD2 File Offset: 0x000CE1D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x000CFFDC File Offset: 0x000CE1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetFighterUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TargetFighterUId);
			}
			this.damages_.WriteTo(ref output, DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x000D002C File Offset: 0x000CE22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetFighterUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetFighterUId);
			}
			num += this.damages_.CalculateSize(DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x000D0080 File Offset: 0x000CE280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlFightActionReflectDamageInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetFighterUId != 0)
			{
				this.TargetFighterUId = other.TargetFighterUId;
			}
			this.damages_.Add(other.damages_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x000D00CD File Offset: 0x000CE2CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x000D00D8 File Offset: 0x000CE2D8
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.damages_.AddEntriesFrom(ref input, DangoBrawlFightActionReflectDamageInfo._repeated_damages_codec);
					}
				}
				else
				{
					this.TargetFighterUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003406 RID: 13318
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003407 RID: 13319
		public const int TargetFighterUIdFieldNumber = 1;

		// Token: 0x04003408 RID: 13320
		private int targetFighterUId_;

		// Token: 0x04003409 RID: 13321
		public const int DamagesFieldNumber = 2;

		// Token: 0x0400340A RID: 13322
		private static readonly FieldCodec<int> _repeated_damages_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400340B RID: 13323
		private readonly RepeatedField<int> damages_ = new RepeatedField<int>();
	}
}
