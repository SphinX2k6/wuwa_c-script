using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E83 RID: 3715
	public sealed class RandomSummonRequestInfo : IMessage<RandomSummonRequestInfo>, IMessage, IEquatable<RandomSummonRequestInfo>, IDeepCloneable<RandomSummonRequestInfo>, IBufferMessage
	{
		// Token: 0x06013F35 RID: 81717 RVA: 0x002E78A7 File Offset: 0x002E5AA7
		[NullableContext(1)]
		public static RandomSummonRequestInfo Create()
		{
			return new RandomSummonRequestInfo();
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x06013F36 RID: 81718 RVA: 0x002E78AE File Offset: 0x002E5AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x06013F37 RID: 81719 RVA: 0x002E78B1 File Offset: 0x002E5AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RandomSummonRequestInfo.Descriptor;
			}
		}

		// Token: 0x06013F38 RID: 81720 RVA: 0x002E78B8 File Offset: 0x002E5AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo()
		{
		}

		// Token: 0x06013F39 RID: 81721 RVA: 0x002E78C0 File Offset: 0x002E5AC0
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

		// Token: 0x06013F3A RID: 81722 RVA: 0x002E7940 File Offset: 0x002E5B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RandomSummonRequestInfo Clone()
		{
			return new RandomSummonRequestInfo(this);
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x06013F3B RID: 81723 RVA: 0x002E7948 File Offset: 0x002E5B48
		// (set) Token: 0x06013F3C RID: 81724 RVA: 0x002E7950 File Offset: 0x002E5B50
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

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x06013F3D RID: 81725 RVA: 0x002E7959 File Offset: 0x002E5B59
		// (set) Token: 0x06013F3E RID: 81726 RVA: 0x002E7961 File Offset: 0x002E5B61
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

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x06013F3F RID: 81727 RVA: 0x002E796A File Offset: 0x002E5B6A
		// (set) Token: 0x06013F40 RID: 81728 RVA: 0x002E7972 File Offset: 0x002E5B72
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

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06013F41 RID: 81729 RVA: 0x002E797B File Offset: 0x002E5B7B
		// (set) Token: 0x06013F42 RID: 81730 RVA: 0x002E7983 File Offset: 0x002E5B83
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

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06013F43 RID: 81731 RVA: 0x002E798C File Offset: 0x002E5B8C
		// (set) Token: 0x06013F44 RID: 81732 RVA: 0x002E7994 File Offset: 0x002E5B94
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

		// Token: 0x06013F45 RID: 81733 RVA: 0x002E799D File Offset: 0x002E5B9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RandomSummonRequestInfo);
		}

		// Token: 0x06013F46 RID: 81734 RVA: 0x002E79AC File Offset: 0x002E5BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RandomSummonRequestInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.SummonIndex == other.SummonIndex && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.IsVisible == other.IsVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F47 RID: 81735 RVA: 0x002E7A30 File Offset: 0x002E5C30
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

		// Token: 0x06013F48 RID: 81736 RVA: 0x002E7ACD File Offset: 0x002E5CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F49 RID: 81737 RVA: 0x002E7ADA File Offset: 0x002E5CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F4A RID: 81738 RVA: 0x002E7AE4 File Offset: 0x002E5CE4
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

		// Token: 0x06013F4B RID: 81739 RVA: 0x002E7B90 File Offset: 0x002E5D90
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

		// Token: 0x06013F4C RID: 81740 RVA: 0x002E7C24 File Offset: 0x002E5E24
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

		// Token: 0x06013F4D RID: 81741 RVA: 0x002E7CE0 File Offset: 0x002E5EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F4E RID: 81742 RVA: 0x002E7CEC File Offset: 0x002E5EEC
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

		// Token: 0x040079DF RID: 31199
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079E0 RID: 31200
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040079E1 RID: 31201
		private int skillId_;

		// Token: 0x040079E2 RID: 31202
		public const int SummonIndexFieldNumber = 2;

		// Token: 0x040079E3 RID: 31203
		private int summonIndex_;

		// Token: 0x040079E4 RID: 31204
		public const int PosFieldNumber = 3;

		// Token: 0x040079E5 RID: 31205
		private Vector pos_;

		// Token: 0x040079E6 RID: 31206
		public const int RotFieldNumber = 4;

		// Token: 0x040079E7 RID: 31207
		private Rotator rot_;

		// Token: 0x040079E8 RID: 31208
		public const int IsVisibleFieldNumber = 5;

		// Token: 0x040079E9 RID: 31209
		private bool isVisible_;
	}
}
