using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065D RID: 1629
	public sealed class FRSkillData : IMessage<FRSkillData>, IMessage, IEquatable<FRSkillData>, IDeepCloneable<FRSkillData>, IBufferMessage
	{
		// Token: 0x0600958E RID: 38286 RVA: 0x00168F1D File Offset: 0x0016711D
		[NullableContext(1)]
		public static FRSkillData Create()
		{
			return new FRSkillData();
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x0600958F RID: 38287 RVA: 0x00168F24 File Offset: 0x00167124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x06009590 RID: 38288 RVA: 0x00168F27 File Offset: 0x00167127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRSkillData.Descriptor;
			}
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x00168F2E File Offset: 0x0016712E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData()
		{
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x00168F36 File Offset: 0x00167136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData(FRSkillData other) : this()
		{
			this.curCanUseNum_ = other.curCanUseNum_;
			this.curDayCanUseNum_ = other.curDayCanUseNum_;
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x00168F73 File Offset: 0x00167173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRSkillData Clone()
		{
			return new FRSkillData(this);
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x06009594 RID: 38292 RVA: 0x00168F7B File Offset: 0x0016717B
		// (set) Token: 0x06009595 RID: 38293 RVA: 0x00168F83 File Offset: 0x00167183
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

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x06009596 RID: 38294 RVA: 0x00168F8C File Offset: 0x0016718C
		// (set) Token: 0x06009597 RID: 38295 RVA: 0x00168F94 File Offset: 0x00167194
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

		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x06009598 RID: 38296 RVA: 0x00168F9D File Offset: 0x0016719D
		// (set) Token: 0x06009599 RID: 38297 RVA: 0x00168FA5 File Offset: 0x001671A5
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

		// Token: 0x0600959A RID: 38298 RVA: 0x00168FAE File Offset: 0x001671AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRSkillData);
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x00168FBC File Offset: 0x001671BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRSkillData other)
		{
			return other != null && (other == this || (this.CurCanUseNum == other.CurCanUseNum && this.CurDayCanUseNum == other.CurDayCanUseNum && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x00169018 File Offset: 0x00167218
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

		// Token: 0x0600959D RID: 38301 RVA: 0x00169089 File Offset: 0x00167289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x00169096 File Offset: 0x00167296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x001690A0 File Offset: 0x001672A0
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

		// Token: 0x060095A0 RID: 38304 RVA: 0x00169114 File Offset: 0x00167314
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

		// Token: 0x060095A1 RID: 38305 RVA: 0x00169184 File Offset: 0x00167384
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

		// Token: 0x060095A2 RID: 38306 RVA: 0x001691E8 File Offset: 0x001673E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x001691F4 File Offset: 0x001673F4
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

		// Token: 0x0400476B RID: 18283
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400476C RID: 18284
		public const int CurCanUseNumFieldNumber = 1;

		// Token: 0x0400476D RID: 18285
		private int curCanUseNum_;

		// Token: 0x0400476E RID: 18286
		public const int CurDayCanUseNumFieldNumber = 2;

		// Token: 0x0400476F RID: 18287
		private int curDayCanUseNum_;

		// Token: 0x04004770 RID: 18288
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04004771 RID: 18289
		private int skillId_;
	}
}
