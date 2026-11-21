using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001323 RID: 4899
	public sealed class SummonRequestInfo : IMessage<SummonRequestInfo>, IMessage, IEquatable<SummonRequestInfo>, IDeepCloneable<SummonRequestInfo>, IBufferMessage
	{
		// Token: 0x0601A1D8 RID: 106968 RVA: 0x003CE45F File Offset: 0x003CC65F
		[NullableContext(1)]
		public static SummonRequestInfo Create()
		{
			return new SummonRequestInfo();
		}

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x0601A1D9 RID: 106969 RVA: 0x003CE466 File Offset: 0x003CC666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x0601A1DA RID: 106970 RVA: 0x003CE469 File Offset: 0x003CC669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRequestInfo.Descriptor;
			}
		}

		// Token: 0x0601A1DB RID: 106971 RVA: 0x003CE470 File Offset: 0x003CC670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo()
		{
		}

		// Token: 0x0601A1DC RID: 106972 RVA: 0x003CE478 File Offset: 0x003CC678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo(SummonRequestInfo other) : this()
		{
			this.summonEntityId_ = other.summonEntityId_;
			this.skillId_ = other.skillId_;
			this.summonConfigId_ = other.summonConfigId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.isVisible_ = other.isVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A1DD RID: 106973 RVA: 0x003CE504 File Offset: 0x003CC704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo Clone()
		{
			return new SummonRequestInfo(this);
		}

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x0601A1DE RID: 106974 RVA: 0x003CE50C File Offset: 0x003CC70C
		// (set) Token: 0x0601A1DF RID: 106975 RVA: 0x003CE514 File Offset: 0x003CC714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonEntityId
		{
			get
			{
				return this.summonEntityId_;
			}
			set
			{
				this.summonEntityId_ = value;
			}
		}

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x0601A1E0 RID: 106976 RVA: 0x003CE51D File Offset: 0x003CC71D
		// (set) Token: 0x0601A1E1 RID: 106977 RVA: 0x003CE525 File Offset: 0x003CC725
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

		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x0601A1E2 RID: 106978 RVA: 0x003CE52E File Offset: 0x003CC72E
		// (set) Token: 0x0601A1E3 RID: 106979 RVA: 0x003CE536 File Offset: 0x003CC736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonConfigId
		{
			get
			{
				return this.summonConfigId_;
			}
			set
			{
				this.summonConfigId_ = value;
			}
		}

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x0601A1E4 RID: 106980 RVA: 0x003CE53F File Offset: 0x003CC73F
		// (set) Token: 0x0601A1E5 RID: 106981 RVA: 0x003CE547 File Offset: 0x003CC747
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

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0601A1E6 RID: 106982 RVA: 0x003CE550 File Offset: 0x003CC750
		// (set) Token: 0x0601A1E7 RID: 106983 RVA: 0x003CE558 File Offset: 0x003CC758
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

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x0601A1E8 RID: 106984 RVA: 0x003CE561 File Offset: 0x003CC761
		// (set) Token: 0x0601A1E9 RID: 106985 RVA: 0x003CE569 File Offset: 0x003CC769
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

		// Token: 0x0601A1EA RID: 106986 RVA: 0x003CE572 File Offset: 0x003CC772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRequestInfo);
		}

		// Token: 0x0601A1EB RID: 106987 RVA: 0x003CE580 File Offset: 0x003CC780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRequestInfo other)
		{
			return other != null && (other == this || (this.SummonEntityId == other.SummonEntityId && this.SkillId == other.SkillId && this.SummonConfigId == other.SummonConfigId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.IsVisible == other.IsVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A1EC RID: 106988 RVA: 0x003CE614 File Offset: 0x003CC814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonEntityId != 0L)
			{
				num ^= this.SummonEntityId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SummonConfigId != 0)
			{
				num ^= this.SummonConfigId.GetHashCode();
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

		// Token: 0x0601A1ED RID: 106989 RVA: 0x003CE6CA File Offset: 0x003CC8CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A1EE RID: 106990 RVA: 0x003CE6D7 File Offset: 0x003CC8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A1EF RID: 106991 RVA: 0x003CE6E0 File Offset: 0x003CC8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SummonEntityId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this.SummonConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SummonConfigId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rot);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A1F0 RID: 106992 RVA: 0x003CE7A8 File Offset: 0x003CC9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonEntityId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.SummonConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonConfigId);
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

		// Token: 0x0601A1F1 RID: 106993 RVA: 0x003CE854 File Offset: 0x003CCA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRequestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonEntityId != 0L)
			{
				this.SummonEntityId = other.SummonEntityId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SummonConfigId != 0)
			{
				this.SummonConfigId = other.SummonConfigId;
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

		// Token: 0x0601A1F2 RID: 106994 RVA: 0x003CE924 File Offset: 0x003CCB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A1F3 RID: 106995 RVA: 0x003CE930 File Offset: 0x003CCB30
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SummonEntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SummonConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 42U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 48U)
					{
						this.IsVisible = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040099A5 RID: 39333
		private UnknownFieldSet _unknownFields;

		// Token: 0x040099A6 RID: 39334
		public const int SummonEntityIdFieldNumber = 1;

		// Token: 0x040099A7 RID: 39335
		private long summonEntityId_;

		// Token: 0x040099A8 RID: 39336
		public const int SkillIdFieldNumber = 2;

		// Token: 0x040099A9 RID: 39337
		private int skillId_;

		// Token: 0x040099AA RID: 39338
		public const int SummonConfigIdFieldNumber = 3;

		// Token: 0x040099AB RID: 39339
		private int summonConfigId_;

		// Token: 0x040099AC RID: 39340
		public const int PosFieldNumber = 4;

		// Token: 0x040099AD RID: 39341
		private Vector pos_;

		// Token: 0x040099AE RID: 39342
		public const int RotFieldNumber = 5;

		// Token: 0x040099AF RID: 39343
		private Rotator rot_;

		// Token: 0x040099B0 RID: 39344
		public const int IsVisibleFieldNumber = 6;

		// Token: 0x040099B1 RID: 39345
		private bool isVisible_;
	}
}
