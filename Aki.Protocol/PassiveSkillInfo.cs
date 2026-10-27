using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD0 RID: 3024
	public sealed class PassiveSkillInfo : IMessage<PassiveSkillInfo>, IMessage, IEquatable<PassiveSkillInfo>, IDeepCloneable<PassiveSkillInfo>, IBufferMessage
	{
		// Token: 0x0601060D RID: 67085 RVA: 0x002636B5 File Offset: 0x002618B5
		[NullableContext(1)]
		public static PassiveSkillInfo Create()
		{
			return new PassiveSkillInfo();
		}

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0601060E RID: 67086 RVA: 0x002636BC File Offset: 0x002618BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PassiveSkillInfo> Parser
		{
			get
			{
				return PassiveSkillInfo._parser;
			}
		}

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0601060F RID: 67087 RVA: 0x002636C3 File Offset: 0x002618C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x06010610 RID: 67088 RVA: 0x002636C6 File Offset: 0x002618C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PassiveSkillInfo.Descriptor;
			}
		}

		// Token: 0x06010611 RID: 67089 RVA: 0x002636CD File Offset: 0x002618CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo()
		{
		}

		// Token: 0x06010612 RID: 67090 RVA: 0x002636D5 File Offset: 0x002618D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo(PassiveSkillInfo other) : this()
		{
			this.skillId_ = other.skillId_;
			this.skillCdEndTime_ = other.skillCdEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010613 RID: 67091 RVA: 0x00263706 File Offset: 0x00261906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PassiveSkillInfo Clone()
		{
			return new PassiveSkillInfo(this);
		}

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x06010614 RID: 67092 RVA: 0x0026370E File Offset: 0x0026190E
		// (set) Token: 0x06010615 RID: 67093 RVA: 0x00263716 File Offset: 0x00261916
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

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x06010616 RID: 67094 RVA: 0x0026371F File Offset: 0x0026191F
		// (set) Token: 0x06010617 RID: 67095 RVA: 0x00263727 File Offset: 0x00261927
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

		// Token: 0x06010618 RID: 67096 RVA: 0x00263730 File Offset: 0x00261930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PassiveSkillInfo);
		}

		// Token: 0x06010619 RID: 67097 RVA: 0x0026373E File Offset: 0x0026193E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PassiveSkillInfo other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.SkillCdEndTime == other.SkillCdEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601061A RID: 67098 RVA: 0x0026377C File Offset: 0x0026197C
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

		// Token: 0x0601061B RID: 67099 RVA: 0x002637D4 File Offset: 0x002619D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601061C RID: 67100 RVA: 0x002637E1 File Offset: 0x002619E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601061D RID: 67101 RVA: 0x002637EC File Offset: 0x002619EC
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

		// Token: 0x0601061E RID: 67102 RVA: 0x00263844 File Offset: 0x00261A44
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

		// Token: 0x0601061F RID: 67103 RVA: 0x0026389C File Offset: 0x00261A9C
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

		// Token: 0x06010620 RID: 67104 RVA: 0x002638EC File Offset: 0x00261AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010621 RID: 67105 RVA: 0x002638F8 File Offset: 0x00261AF8
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

		// Token: 0x040067F5 RID: 26613
		private static readonly MessageParser<PassiveSkillInfo> _parser = new MessageParser<PassiveSkillInfo>(() => new PassiveSkillInfo());

		// Token: 0x040067F6 RID: 26614
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067F7 RID: 26615
		public const int SkillIdFieldNumber = 1;

		// Token: 0x040067F8 RID: 26616
		private long skillId_;

		// Token: 0x040067F9 RID: 26617
		public const int SkillCdEndTimeFieldNumber = 2;

		// Token: 0x040067FA RID: 26618
		private long skillCdEndTime_;
	}
}
