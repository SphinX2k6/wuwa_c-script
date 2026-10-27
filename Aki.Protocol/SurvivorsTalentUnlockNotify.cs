using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EC RID: 4844
	[NetMessage(EMessageId.SurvivorsTalentUnlockNotify)]
	public sealed class SurvivorsTalentUnlockNotify : IMessage<SurvivorsTalentUnlockNotify>, IMessage, IEquatable<SurvivorsTalentUnlockNotify>, IDeepCloneable<SurvivorsTalentUnlockNotify>, IBufferMessage
	{
		// Token: 0x06019C2A RID: 105514 RVA: 0x003BE908 File Offset: 0x003BCB08
		[NullableContext(1)]
		public static SurvivorsTalentUnlockNotify Create()
		{
			return new SurvivorsTalentUnlockNotify();
		}

		// Token: 0x170056E4 RID: 22244
		// (get) Token: 0x06019C2B RID: 105515 RVA: 0x003BE90F File Offset: 0x003BCB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056E5 RID: 22245
		// (get) Token: 0x06019C2C RID: 105516 RVA: 0x003BE912 File Offset: 0x003BCB12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06019C2D RID: 105517 RVA: 0x003BE919 File Offset: 0x003BCB19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify()
		{
		}

		// Token: 0x06019C2E RID: 105518 RVA: 0x003BE921 File Offset: 0x003BCB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify(SurvivorsTalentUnlockNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C2F RID: 105519 RVA: 0x003BE946 File Offset: 0x003BCB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentUnlockNotify Clone()
		{
			return new SurvivorsTalentUnlockNotify(this);
		}

		// Token: 0x170056E6 RID: 22246
		// (get) Token: 0x06019C30 RID: 105520 RVA: 0x003BE94E File Offset: 0x003BCB4E
		// (set) Token: 0x06019C31 RID: 105521 RVA: 0x003BE956 File Offset: 0x003BCB56
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

		// Token: 0x06019C32 RID: 105522 RVA: 0x003BE95F File Offset: 0x003BCB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentUnlockNotify);
		}

		// Token: 0x06019C33 RID: 105523 RVA: 0x003BE96D File Offset: 0x003BCB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentUnlockNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C34 RID: 105524 RVA: 0x003BE99C File Offset: 0x003BCB9C
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

		// Token: 0x06019C35 RID: 105525 RVA: 0x003BE9DB File Offset: 0x003BCBDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C36 RID: 105526 RVA: 0x003BE9E8 File Offset: 0x003BCBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C37 RID: 105527 RVA: 0x003BE9F1 File Offset: 0x003BCBF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C38 RID: 105528 RVA: 0x003BEA24 File Offset: 0x003BCC24
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

		// Token: 0x06019C39 RID: 105529 RVA: 0x003BEA62 File Offset: 0x003BCC62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTalentUnlockNotify other)
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

		// Token: 0x06019C3A RID: 105530 RVA: 0x003BEA93 File Offset: 0x003BCC93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C3B RID: 105531 RVA: 0x003BEA9C File Offset: 0x003BCC9C
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040096D1 RID: 38609
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096D2 RID: 38610
		public const int SkillIdFieldNumber = 14;

		// Token: 0x040096D3 RID: 38611
		private int skillId_;
	}
}
