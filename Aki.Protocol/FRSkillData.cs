using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000649 RID: 1609
	public sealed class FRSkillData : IMessage<FRSkillData>, IMessage, IEquatable<FRSkillData>, IDeepCloneable<FRSkillData>, IBufferMessage
	{
		// Token: 0x06009438 RID: 37944 RVA: 0x001664F1 File Offset: 0x001646F1
		[NullableContext(1)]
		public static FRSkillData Create()
		{
			return new FRSkillData();
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06009439 RID: 37945 RVA: 0x001664F8 File Offset: 0x001646F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x0600943A RID: 37946 RVA: 0x001664FB File Offset: 0x001646FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRSkillData.Descriptor;
			}
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00166502 File Offset: 0x00164702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData()
		{
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x0016650A File Offset: 0x0016470A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData(FRSkillData other) : this()
		{
			this.curCanUseNum_ = other.curCanUseNum_;
			this.curDayCanUseNum_ = other.curDayCanUseNum_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x00166547 File Offset: 0x00164747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData Clone()
		{
			return new FRSkillData(this);
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x0600943E RID: 37950 RVA: 0x0016654F File Offset: 0x0016474F
		// (set) Token: 0x0600943F RID: 37951 RVA: 0x00166557 File Offset: 0x00164757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCanUseNum
		{
			get
			{
				return this.curCanUseNum_;
			}
			set
			{
				this.curCanUseNum_ = value;
			}
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x06009440 RID: 37952 RVA: 0x00166560 File Offset: 0x00164760
		// (set) Token: 0x06009441 RID: 37953 RVA: 0x00166568 File Offset: 0x00164768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurDayCanUseNum
		{
			get
			{
				return this.curDayCanUseNum_;
			}
			set
			{
				this.curDayCanUseNum_ = value;
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x06009442 RID: 37954 RVA: 0x00166571 File Offset: 0x00164771
		// (set) Token: 0x06009443 RID: 37955 RVA: 0x00166579 File Offset: 0x00164779
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

		// Token: 0x06009444 RID: 37956 RVA: 0x00166582 File Offset: 0x00164782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRSkillData);
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x00166590 File Offset: 0x00164790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRSkillData other)
		{
			return other != null && (other == this || (this.CurCanUseNum == other.CurCanUseNum && this.CurDayCanUseNum == other.CurDayCanUseNum && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x001665EC File Offset: 0x001647EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurCanUseNum != 0)
			{
				num ^= this.CurCanUseNum.GetHashCode();
			}
			if (this.CurDayCanUseNum != 0)
			{
				num ^= this.CurDayCanUseNum.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x0016665D File Offset: 0x0016485D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x0016666A File Offset: 0x0016486A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00166674 File Offset: 0x00164874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCanUseNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurCanUseNum);
			}
			if (this.CurDayCanUseNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurDayCanUseNum);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x001666E8 File Offset: 0x001648E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurCanUseNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCanUseNum);
			}
			if (this.CurDayCanUseNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurDayCanUseNum);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x00166758 File Offset: 0x00164958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRSkillData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurCanUseNum != 0)
			{
				this.CurCanUseNum = other.CurCanUseNum;
			}
			if (other.CurDayCanUseNum != 0)
			{
				this.CurDayCanUseNum = other.CurDayCanUseNum;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x001667BC File Offset: 0x001649BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x001667C8 File Offset: 0x001649C8
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
							this.SkillId = input.ReadInt32();
						}
					}
					else
					{
						this.CurDayCanUseNum = input.ReadInt32();
					}
				}
				else
				{
					this.CurCanUseNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004764 RID: 18276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004765 RID: 18277
		public const int CurCanUseNumFieldNumber = 1;

		// Token: 0x04004766 RID: 18278
		private int curCanUseNum_;

		// Token: 0x04004767 RID: 18279
		public const int CurDayCanUseNumFieldNumber = 2;

		// Token: 0x04004768 RID: 18280
		private int curDayCanUseNum_;

		// Token: 0x04004769 RID: 18281
		public const int SkillIdFieldNumber = 3;

		// Token: 0x0400476A RID: 18282
		private int skillId_;
	}
}
