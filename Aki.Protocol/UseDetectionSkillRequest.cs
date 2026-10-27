using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B0 RID: 5296
	[NetMessage(EMessageId.UseDetectionSkillRequest)]
	public sealed class UseDetectionSkillRequest : IMessage<UseDetectionSkillRequest>, IMessage, IEquatable<UseDetectionSkillRequest>, IDeepCloneable<UseDetectionSkillRequest>, IBufferMessage
	{
		// Token: 0x0601C019 RID: 114713 RVA: 0x0040C2C3 File Offset: 0x0040A4C3
		[NullableContext(1)]
		public static UseDetectionSkillRequest Create()
		{
			return new UseDetectionSkillRequest();
		}

		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x0601C01A RID: 114714 RVA: 0x0040C2CA File Offset: 0x0040A4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x0601C01B RID: 114715 RVA: 0x0040C2CD File Offset: 0x0040A4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UseDetectionSkillRequest.Descriptor;
			}
		}

		// Token: 0x0601C01C RID: 114716 RVA: 0x0040C2D4 File Offset: 0x0040A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest()
		{
		}

		// Token: 0x0601C01D RID: 114717 RVA: 0x0040C2DC File Offset: 0x0040A4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest(UseDetectionSkillRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.confirmUseDetectionSkill_ = other.confirmUseDetectionSkill_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C01E RID: 114718 RVA: 0x0040C350 File Offset: 0x0040A550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseDetectionSkillRequest Clone()
		{
			return new UseDetectionSkillRequest(this);
		}

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x0601C01F RID: 114719 RVA: 0x0040C358 File Offset: 0x0040A558
		// (set) Token: 0x0601C020 RID: 114720 RVA: 0x0040C360 File Offset: 0x0040A560
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

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x0601C021 RID: 114721 RVA: 0x0040C369 File Offset: 0x0040A569
		// (set) Token: 0x0601C022 RID: 114722 RVA: 0x0040C371 File Offset: 0x0040A571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x0601C023 RID: 114723 RVA: 0x0040C37A File Offset: 0x0040A57A
		// (set) Token: 0x0601C024 RID: 114724 RVA: 0x0040C382 File Offset: 0x0040A582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x0601C025 RID: 114725 RVA: 0x0040C38B File Offset: 0x0040A58B
		// (set) Token: 0x0601C026 RID: 114726 RVA: 0x0040C393 File Offset: 0x0040A593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ConfirmUseDetectionSkill
		{
			get
			{
				return this.confirmUseDetectionSkill_;
			}
			set
			{
				this.confirmUseDetectionSkill_ = value;
			}
		}

		// Token: 0x0601C027 RID: 114727 RVA: 0x0040C39C File Offset: 0x0040A59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UseDetectionSkillRequest);
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x0040C3AC File Offset: 0x0040A5AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UseDetectionSkillRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.ConfirmUseDetectionSkill == other.ConfirmUseDetectionSkill && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C029 RID: 114729 RVA: 0x0040C420 File Offset: 0x0040A620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.ConfirmUseDetectionSkill)
			{
				num ^= this.ConfirmUseDetectionSkill.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C02A RID: 114730 RVA: 0x0040C4A4 File Offset: 0x0040A6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C02B RID: 114731 RVA: 0x0040C4B1 File Offset: 0x0040A6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C02C RID: 114732 RVA: 0x0040C4BC File Offset: 0x0040A6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this.ConfirmUseDetectionSkill)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ConfirmUseDetectionSkill);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C02D RID: 114733 RVA: 0x0040C550 File Offset: 0x0040A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.ConfirmUseDetectionSkill)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C02E RID: 114734 RVA: 0x0040C5CC File Offset: 0x0040A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UseDetectionSkillRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			if (other.ConfirmUseDetectionSkill)
			{
				this.ConfirmUseDetectionSkill = other.ConfirmUseDetectionSkill;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C02F RID: 114735 RVA: 0x0040C674 File Offset: 0x0040A874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C030 RID: 114736 RVA: 0x0040C680 File Offset: 0x0040A880
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ConfirmUseDetectionSkill = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 98U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A0D6 RID: 41174
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0D7 RID: 41175
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400A0D8 RID: 41176
		private int skillId_;

		// Token: 0x0400A0D9 RID: 41177
		public const int PosFieldNumber = 7;

		// Token: 0x0400A0DA RID: 41178
		private Vector pos_;

		// Token: 0x0400A0DB RID: 41179
		public const int RotFieldNumber = 12;

		// Token: 0x0400A0DC RID: 41180
		private Rotator rot_;

		// Token: 0x0400A0DD RID: 41181
		public const int ConfirmUseDetectionSkillFieldNumber = 4;

		// Token: 0x0400A0DE RID: 41182
		private bool confirmUseDetectionSkill_;
	}
}
