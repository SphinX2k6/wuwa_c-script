using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EA RID: 4842
	[NetMessage(EMessageId.SurvivorsTalentLevelUpRequest)]
	public sealed class SurvivorsTalentLevelUpRequest : IMessage<SurvivorsTalentLevelUpRequest>, IMessage, IEquatable<SurvivorsTalentLevelUpRequest>, IDeepCloneable<SurvivorsTalentLevelUpRequest>, IBufferMessage
	{
		// Token: 0x06019C04 RID: 105476 RVA: 0x003BE48F File Offset: 0x003BC68F
		[NullableContext(1)]
		public static SurvivorsTalentLevelUpRequest Create()
		{
			return new SurvivorsTalentLevelUpRequest();
		}

		// Token: 0x170056DD RID: 22237
		// (get) Token: 0x06019C05 RID: 105477 RVA: 0x003BE496 File Offset: 0x003BC696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056DE RID: 22238
		// (get) Token: 0x06019C06 RID: 105478 RVA: 0x003BE499 File Offset: 0x003BC699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x06019C07 RID: 105479 RVA: 0x003BE4A0 File Offset: 0x003BC6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest()
		{
		}

		// Token: 0x06019C08 RID: 105480 RVA: 0x003BE4A8 File Offset: 0x003BC6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest(SurvivorsTalentLevelUpRequest other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C09 RID: 105481 RVA: 0x003BE4CD File Offset: 0x003BC6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpRequest Clone()
		{
			return new SurvivorsTalentLevelUpRequest(this);
		}

		// Token: 0x170056DF RID: 22239
		// (get) Token: 0x06019C0A RID: 105482 RVA: 0x003BE4D5 File Offset: 0x003BC6D5
		// (set) Token: 0x06019C0B RID: 105483 RVA: 0x003BE4DD File Offset: 0x003BC6DD
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

		// Token: 0x06019C0C RID: 105484 RVA: 0x003BE4E6 File Offset: 0x003BC6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentLevelUpRequest);
		}

		// Token: 0x06019C0D RID: 105485 RVA: 0x003BE4F4 File Offset: 0x003BC6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentLevelUpRequest other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C0E RID: 105486 RVA: 0x003BE524 File Offset: 0x003BC724
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

		// Token: 0x06019C0F RID: 105487 RVA: 0x003BE563 File Offset: 0x003BC763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C10 RID: 105488 RVA: 0x003BE570 File Offset: 0x003BC770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C11 RID: 105489 RVA: 0x003BE579 File Offset: 0x003BC779
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

		// Token: 0x06019C12 RID: 105490 RVA: 0x003BE5AC File Offset: 0x003BC7AC
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

		// Token: 0x06019C13 RID: 105491 RVA: 0x003BE5EA File Offset: 0x003BC7EA
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

		// Token: 0x06019C14 RID: 105492 RVA: 0x003BE61B File Offset: 0x003BC81B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C15 RID: 105493 RVA: 0x003BE624 File Offset: 0x003BC824
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

		// Token: 0x040096C9 RID: 38601
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096CA RID: 38602
		public const int SkillIdFieldNumber = 14;

		// Token: 0x040096CB RID: 38603
		private int skillId_;
	}
}
