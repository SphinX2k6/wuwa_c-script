using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001359 RID: 4953
	[NetMessage(EMessageId.SurvivorsTalentLevelUpRequest)]
	public sealed class SurvivorsTalentLevelUpRequest : IMessage<SurvivorsTalentLevelUpRequest>, IMessage, IEquatable<SurvivorsTalentLevelUpRequest>, IDeepCloneable<SurvivorsTalentLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0601A63A RID: 108090 RVA: 0x003D8BAF File Offset: 0x003D6DAF
		[NullableContext(1)]
		public static SurvivorsTalentLevelUpRequest Create()
		{
			return new SurvivorsTalentLevelUpRequest();
		}

		// Token: 0x1700595E RID: 22878
		// (get) Token: 0x0601A63B RID: 108091 RVA: 0x003D8BB6 File Offset: 0x003D6DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700595F RID: 22879
		// (get) Token: 0x0601A63C RID: 108092 RVA: 0x003D8BB9 File Offset: 0x003D6DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0601A63D RID: 108093 RVA: 0x003D8BC0 File Offset: 0x003D6DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest()
		{
		}

		// Token: 0x0601A63E RID: 108094 RVA: 0x003D8BC8 File Offset: 0x003D6DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest(SurvivorsTalentLevelUpRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A63F RID: 108095 RVA: 0x003D8BED File Offset: 0x003D6DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest Clone()
		{
			return new SurvivorsTalentLevelUpRequest(this);
		}

		// Token: 0x17005960 RID: 22880
		// (get) Token: 0x0601A640 RID: 108096 RVA: 0x003D8BF5 File Offset: 0x003D6DF5
		// (set) Token: 0x0601A641 RID: 108097 RVA: 0x003D8BFD File Offset: 0x003D6DFD
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

		// Token: 0x0601A642 RID: 108098 RVA: 0x003D8C06 File Offset: 0x003D6E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentLevelUpRequest);
		}

		// Token: 0x0601A643 RID: 108099 RVA: 0x003D8C14 File Offset: 0x003D6E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentLevelUpRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A644 RID: 108100 RVA: 0x003D8C44 File Offset: 0x003D6E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601A645 RID: 108101 RVA: 0x003D8C83 File Offset: 0x003D6E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A646 RID: 108102 RVA: 0x003D8C90 File Offset: 0x003D6E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A647 RID: 108103 RVA: 0x003D8C99 File Offset: 0x003D6E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A648 RID: 108104 RVA: 0x003D8CCC File Offset: 0x003D6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0601A649 RID: 108105 RVA: 0x003D8D0A File Offset: 0x003D6F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTalentLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A64A RID: 108106 RVA: 0x003D8D3B File Offset: 0x003D6F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A64B RID: 108107 RVA: 0x003D8D44 File Offset: 0x003D6F44
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009AF3 RID: 39667
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AF4 RID: 39668
		public const int SkillIdFieldNumber = 13;

		// Token: 0x04009AF5 RID: 39669
		private int skillId_;
	}
}
