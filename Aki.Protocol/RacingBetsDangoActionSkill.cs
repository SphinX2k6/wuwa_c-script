using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E43 RID: 3651
	public sealed class RacingBetsDangoActionSkill : IMessage<RacingBetsDangoActionSkill>, IMessage, IEquatable<RacingBetsDangoActionSkill>, IDeepCloneable<RacingBetsDangoActionSkill>, IBufferMessage
	{
		// Token: 0x06013A17 RID: 80407 RVA: 0x002DB2E9 File Offset: 0x002D94E9
		[NullableContext(1)]
		public static RacingBetsDangoActionSkill Create()
		{
			return new RacingBetsDangoActionSkill();
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06013A18 RID: 80408 RVA: 0x002DB2F0 File Offset: 0x002D94F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x06013A19 RID: 80409 RVA: 0x002DB2F3 File Offset: 0x002D94F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionSkill.Descriptor;
			}
		}

		// Token: 0x06013A1A RID: 80410 RVA: 0x002DB2FA File Offset: 0x002D94FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill()
		{
		}

		// Token: 0x06013A1B RID: 80411 RVA: 0x002DB302 File Offset: 0x002D9502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill(RacingBetsDangoActionSkill other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.skillId_ = other.skillId_;
			this.isSuccess_ = other.isSuccess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A1C RID: 80412 RVA: 0x002DB33F File Offset: 0x002D953F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill Clone()
		{
			return new RacingBetsDangoActionSkill(this);
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x06013A1D RID: 80413 RVA: 0x002DB347 File Offset: 0x002D9547
		// (set) Token: 0x06013A1E RID: 80414 RVA: 0x002DB34F File Offset: 0x002D954F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x06013A1F RID: 80415 RVA: 0x002DB358 File Offset: 0x002D9558
		// (set) Token: 0x06013A20 RID: 80416 RVA: 0x002DB360 File Offset: 0x002D9560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06013A21 RID: 80417 RVA: 0x002DB369 File Offset: 0x002D9569
		// (set) Token: 0x06013A22 RID: 80418 RVA: 0x002DB371 File Offset: 0x002D9571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x06013A23 RID: 80419 RVA: 0x002DB37A File Offset: 0x002D957A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionSkill);
		}

		// Token: 0x06013A24 RID: 80420 RVA: 0x002DB388 File Offset: 0x002D9588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionSkill other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.SkillId == other.SkillId && this.IsSuccess == other.IsSuccess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A25 RID: 80421 RVA: 0x002DB3E4 File Offset: 0x002D95E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A26 RID: 80422 RVA: 0x002DB455 File Offset: 0x002D9655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A27 RID: 80423 RVA: 0x002DB462 File Offset: 0x002D9662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A28 RID: 80424 RVA: 0x002DB46C File Offset: 0x002D966C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSuccess);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A29 RID: 80425 RVA: 0x002DB4E0 File Offset: 0x002D96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A2A RID: 80426 RVA: 0x002DB544 File Offset: 0x002D9744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionSkill other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A2B RID: 80427 RVA: 0x002DB5A8 File Offset: 0x002D97A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A2C RID: 80428 RVA: 0x002DB5B4 File Offset: 0x002D97B4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsSuccess = input.ReadBool();
						}
					}
					else
					{
						this.SkillId = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400789C RID: 30876
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400789D RID: 30877
		public const int DangoIdFieldNumber = 1;

		// Token: 0x0400789E RID: 30878
		private int dangoId_;

		// Token: 0x0400789F RID: 30879
		public const int SkillIdFieldNumber = 2;

		// Token: 0x040078A0 RID: 30880
		private int skillId_;

		// Token: 0x040078A1 RID: 30881
		public const int IsSuccessFieldNumber = 3;

		// Token: 0x040078A2 RID: 30882
		private bool isSuccess_;
	}
}
