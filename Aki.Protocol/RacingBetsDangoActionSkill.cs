using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E53 RID: 3667
	public sealed class RacingBetsDangoActionSkill : IMessage<RacingBetsDangoActionSkill>, IMessage, IEquatable<RacingBetsDangoActionSkill>, IDeepCloneable<RacingBetsDangoActionSkill>, IBufferMessage
	{
		// Token: 0x06013AFC RID: 80636 RVA: 0x002DC9A5 File Offset: 0x002DABA5
		[NullableContext(1)]
		public static RacingBetsDangoActionSkill Create()
		{
			return new RacingBetsDangoActionSkill();
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06013AFD RID: 80637 RVA: 0x002DC9AC File Offset: 0x002DABAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06013AFE RID: 80638 RVA: 0x002DC9AF File Offset: 0x002DABAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionSkill.Descriptor;
			}
		}

		// Token: 0x06013AFF RID: 80639 RVA: 0x002DC9B6 File Offset: 0x002DABB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill()
		{
		}

		// Token: 0x06013B00 RID: 80640 RVA: 0x002DC9BE File Offset: 0x002DABBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill(RacingBetsDangoActionSkill other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this.skillId_ = other.skillId_;
			this.isSuccess_ = other.isSuccess_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B01 RID: 80641 RVA: 0x002DC9FB File Offset: 0x002DABFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionSkill Clone()
		{
			return new RacingBetsDangoActionSkill(this);
		}

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06013B02 RID: 80642 RVA: 0x002DCA03 File Offset: 0x002DAC03
		// (set) Token: 0x06013B03 RID: 80643 RVA: 0x002DCA0B File Offset: 0x002DAC0B
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

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06013B04 RID: 80644 RVA: 0x002DCA14 File Offset: 0x002DAC14
		// (set) Token: 0x06013B05 RID: 80645 RVA: 0x002DCA1C File Offset: 0x002DAC1C
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

		// Token: 0x17004159 RID: 16729
		// (get) Token: 0x06013B06 RID: 80646 RVA: 0x002DCA25 File Offset: 0x002DAC25
		// (set) Token: 0x06013B07 RID: 80647 RVA: 0x002DCA2D File Offset: 0x002DAC2D
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

		// Token: 0x06013B08 RID: 80648 RVA: 0x002DCA36 File Offset: 0x002DAC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionSkill);
		}

		// Token: 0x06013B09 RID: 80649 RVA: 0x002DCA44 File Offset: 0x002DAC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionSkill other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && this.SkillId == other.SkillId && this.IsSuccess == other.IsSuccess && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B0A RID: 80650 RVA: 0x002DCAA0 File Offset: 0x002DACA0
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

		// Token: 0x06013B0B RID: 80651 RVA: 0x002DCB11 File Offset: 0x002DAD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B0C RID: 80652 RVA: 0x002DCB1E File Offset: 0x002DAD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B0D RID: 80653 RVA: 0x002DCB28 File Offset: 0x002DAD28
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

		// Token: 0x06013B0E RID: 80654 RVA: 0x002DCB9C File Offset: 0x002DAD9C
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

		// Token: 0x06013B0F RID: 80655 RVA: 0x002DCC00 File Offset: 0x002DAE00
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

		// Token: 0x06013B10 RID: 80656 RVA: 0x002DCC64 File Offset: 0x002DAE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B11 RID: 80657 RVA: 0x002DCC70 File Offset: 0x002DAE70
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

		// Token: 0x04007872 RID: 30834
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007873 RID: 30835
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007874 RID: 30836
		private int dangoId_;

		// Token: 0x04007875 RID: 30837
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04007876 RID: 30838
		private int skillId_;

		// Token: 0x04007877 RID: 30839
		public const int IsSuccessFieldNumber = 3;

		// Token: 0x04007878 RID: 30840
		private bool isSuccess_;
	}
}
