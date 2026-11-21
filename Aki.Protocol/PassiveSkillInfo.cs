using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BC0 RID: 3008
	public sealed class PassiveSkillInfo : IMessage<PassiveSkillInfo>, IMessage, IEquatable<PassiveSkillInfo>, IDeepCloneable<PassiveSkillInfo>, IBufferMessage
	{
		// Token: 0x06010509 RID: 66825 RVA: 0x002617F9 File Offset: 0x0025F9F9
		[NullableContext(1)]
		public static PassiveSkillInfo Create()
		{
			return new PassiveSkillInfo();
		}

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0601050A RID: 66826 RVA: 0x00261800 File Offset: 0x0025FA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PassiveSkillInfo> Parser
		{
			get
			{
				return PassiveSkillInfo._parser;
			}
		}

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0601050B RID: 66827 RVA: 0x00261807 File Offset: 0x0025FA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0601050C RID: 66828 RVA: 0x0026180A File Offset: 0x0025FA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillInfo.Descriptor;
			}
		}

		// Token: 0x0601050D RID: 66829 RVA: 0x00261811 File Offset: 0x0025FA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo()
		{
		}

		// Token: 0x0601050E RID: 66830 RVA: 0x00261819 File Offset: 0x0025FA19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo(PassiveSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.skillCdEndTime_ = other.skillCdEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601050F RID: 66831 RVA: 0x0026184A File Offset: 0x0025FA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo Clone()
		{
			return new PassiveSkillInfo(this);
		}

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x06010510 RID: 66832 RVA: 0x00261852 File Offset: 0x0025FA52
		// (set) Token: 0x06010511 RID: 66833 RVA: 0x0026185A File Offset: 0x0025FA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillId
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

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x06010512 RID: 66834 RVA: 0x00261863 File Offset: 0x0025FA63
		// (set) Token: 0x06010513 RID: 66835 RVA: 0x0026186B File Offset: 0x0025FA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SkillCdEndTime
		{
			get
			{
				return this.skillCdEndTime_;
			}
			set
			{
				this.skillCdEndTime_ = value;
			}
		}

		// Token: 0x06010514 RID: 66836 RVA: 0x00261874 File Offset: 0x0025FA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillInfo);
		}

		// Token: 0x06010515 RID: 66837 RVA: 0x00261882 File Offset: 0x0025FA82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.SkillCdEndTime == other.SkillCdEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010516 RID: 66838 RVA: 0x002618C0 File Offset: 0x0025FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SkillCdEndTime != 0L)
			{
				num ^= this.SkillCdEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010517 RID: 66839 RVA: 0x00261918 File Offset: 0x0025FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010518 RID: 66840 RVA: 0x00261925 File Offset: 0x0025FB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010519 RID: 66841 RVA: 0x00261930 File Offset: 0x0025FB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.SkillCdEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.SkillCdEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601051A RID: 66842 RVA: 0x00261988 File Offset: 0x0025FB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.SkillCdEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillCdEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601051B RID: 66843 RVA: 0x002619E0 File Offset: 0x0025FBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PassiveSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SkillCdEndTime != 0L)
			{
				this.SkillCdEndTime = other.SkillCdEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601051C RID: 66844 RVA: 0x00261A30 File Offset: 0x0025FC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601051D RID: 66845 RVA: 0x00261A3C File Offset: 0x0025FC3C
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
						this.SkillCdEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04006805 RID: 26629
		private static readonly MessageParser<PassiveSkillInfo> _parser = new MessageParser<PassiveSkillInfo>(() => new PassiveSkillInfo());

		// Token: 0x04006806 RID: 26630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006807 RID: 26631
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04006808 RID: 26632
		private long skillId_;

		// Token: 0x04006809 RID: 26633
		public const int SkillCdEndTimeFieldNumber = 2;

		// Token: 0x0400680A RID: 26634
		private long skillCdEndTime_;
	}
}
