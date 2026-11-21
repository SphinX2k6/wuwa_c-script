using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E73 RID: 3699
	public sealed class RandomSummonRequestInfo : IMessage<RandomSummonRequestInfo>, IMessage, IEquatable<RandomSummonRequestInfo>, IDeepCloneable<RandomSummonRequestInfo>, IBufferMessage
	{
		// Token: 0x06013E50 RID: 81488 RVA: 0x002E61EB File Offset: 0x002E43EB
		[NullableContext(1)]
		public static RandomSummonRequestInfo Create()
		{
			return new RandomSummonRequestInfo();
		}

		// Token: 0x1700422E RID: 16942
		// (get) Token: 0x06013E51 RID: 81489 RVA: 0x002E61F2 File Offset: 0x002E43F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700422F RID: 16943
		// (get) Token: 0x06013E52 RID: 81490 RVA: 0x002E61F5 File Offset: 0x002E43F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RandomSummonRequestInfo.Descriptor;
			}
		}

		// Token: 0x06013E53 RID: 81491 RVA: 0x002E61FC File Offset: 0x002E43FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo()
		{
		}

		// Token: 0x06013E54 RID: 81492 RVA: 0x002E6204 File Offset: 0x002E4404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo(RandomSummonRequestInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.summonIndex_ = other.summonIndex_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.isVisible_ = other.isVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E55 RID: 81493 RVA: 0x002E6284 File Offset: 0x002E4484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo Clone()
		{
			return new RandomSummonRequestInfo(this);
		}

		// Token: 0x17004230 RID: 16944
		// (get) Token: 0x06013E56 RID: 81494 RVA: 0x002E628C File Offset: 0x002E448C
		// (set) Token: 0x06013E57 RID: 81495 RVA: 0x002E6294 File Offset: 0x002E4494
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

		// Token: 0x17004231 RID: 16945
		// (get) Token: 0x06013E58 RID: 81496 RVA: 0x002E629D File Offset: 0x002E449D
		// (set) Token: 0x06013E59 RID: 81497 RVA: 0x002E62A5 File Offset: 0x002E44A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonIndex
		{
			get
			{
				return this.summonIndex_;
			}
			set
			{
				this.summonIndex_ = value;
			}
		}

		// Token: 0x17004232 RID: 16946
		// (get) Token: 0x06013E5A RID: 81498 RVA: 0x002E62AE File Offset: 0x002E44AE
		// (set) Token: 0x06013E5B RID: 81499 RVA: 0x002E62B6 File Offset: 0x002E44B6
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

		// Token: 0x17004233 RID: 16947
		// (get) Token: 0x06013E5C RID: 81500 RVA: 0x002E62BF File Offset: 0x002E44BF
		// (set) Token: 0x06013E5D RID: 81501 RVA: 0x002E62C7 File Offset: 0x002E44C7
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

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x06013E5E RID: 81502 RVA: 0x002E62D0 File Offset: 0x002E44D0
		// (set) Token: 0x06013E5F RID: 81503 RVA: 0x002E62D8 File Offset: 0x002E44D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisible
		{
			get
			{
				return this.isVisible_;
			}
			set
			{
				this.isVisible_ = value;
			}
		}

		// Token: 0x06013E60 RID: 81504 RVA: 0x002E62E1 File Offset: 0x002E44E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RandomSummonRequestInfo);
		}

		// Token: 0x06013E61 RID: 81505 RVA: 0x002E62F0 File Offset: 0x002E44F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RandomSummonRequestInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.SummonIndex == other.SummonIndex && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.IsVisible == other.IsVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E62 RID: 81506 RVA: 0x002E6374 File Offset: 0x002E4574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SummonIndex != 0)
			{
				num ^= this.SummonIndex.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013E63 RID: 81507 RVA: 0x002E6411 File Offset: 0x002E4611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E64 RID: 81508 RVA: 0x002E641E File Offset: 0x002E461E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E65 RID: 81509 RVA: 0x002E6428 File Offset: 0x002E4628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.SummonIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SummonIndex);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rot);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013E66 RID: 81510 RVA: 0x002E64D4 File Offset: 0x002E46D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.SummonIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonIndex);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.IsVisible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013E67 RID: 81511 RVA: 0x002E6568 File Offset: 0x002E4768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RandomSummonRequestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SummonIndex != 0)
			{
				this.SummonIndex = other.SummonIndex;
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
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013E68 RID: 81512 RVA: 0x002E6624 File Offset: 0x002E4824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E69 RID: 81513 RVA: 0x002E6630 File Offset: 0x002E4830
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
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SummonIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 34U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 40U)
					{
						this.IsVisible = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007A09 RID: 31241
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A0A RID: 31242
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04007A0B RID: 31243
		private int skillId_;

		// Token: 0x04007A0C RID: 31244
		public const int SummonIndexFieldNumber = 2;

		// Token: 0x04007A0D RID: 31245
		private int summonIndex_;

		// Token: 0x04007A0E RID: 31246
		public const int PosFieldNumber = 3;

		// Token: 0x04007A0F RID: 31247
		private Vector pos_;

		// Token: 0x04007A10 RID: 31248
		public const int RotFieldNumber = 4;

		// Token: 0x04007A11 RID: 31249
		private Rotator rot_;

		// Token: 0x04007A12 RID: 31250
		public const int IsVisibleFieldNumber = 5;

		// Token: 0x04007A13 RID: 31251
		private bool isVisible_;
	}
}
