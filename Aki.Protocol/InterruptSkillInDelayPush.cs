using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000836 RID: 2102
	[NetMessage(EMessageId.InterruptSkillInDelayPush)]
	public sealed class InterruptSkillInDelayPush : IMessage<InterruptSkillInDelayPush>, IMessage, IEquatable<InterruptSkillInDelayPush>, IDeepCloneable<InterruptSkillInDelayPush>, IBufferMessage
	{
		// Token: 0x0600BBC8 RID: 48072 RVA: 0x001BF258 File Offset: 0x001BD458
		[NullableContext(1)]
		public static InterruptSkillInDelayPush Create()
		{
			return new InterruptSkillInDelayPush();
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600BBC9 RID: 48073 RVA: 0x001BF25F File Offset: 0x001BD45F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600BBCA RID: 48074 RVA: 0x001BF262 File Offset: 0x001BD462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InterruptSkillInDelayPush.Descriptor;
			}
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x001BF269 File Offset: 0x001BD469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush()
		{
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x001BF271 File Offset: 0x001BD471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush(InterruptSkillInDelayPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x001BF296 File Offset: 0x001BD496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InterruptSkillInDelayPush Clone()
		{
			return new InterruptSkillInDelayPush(this);
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600BBCE RID: 48078 RVA: 0x001BF29E File Offset: 0x001BD49E
		// (set) Token: 0x0600BBCF RID: 48079 RVA: 0x001BF2A6 File Offset: 0x001BD4A6
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

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x001BF2AF File Offset: 0x001BD4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InterruptSkillInDelayPush);
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x001BF2BD File Offset: 0x001BD4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InterruptSkillInDelayPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x001BF2EC File Offset: 0x001BD4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x001BF32B File Offset: 0x001BD52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x001BF338 File Offset: 0x001BD538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x001BF341 File Offset: 0x001BD541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x001BF374 File Offset: 0x001BD574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x001BF3B2 File Offset: 0x001BD5B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InterruptSkillInDelayPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x001BF3E3 File Offset: 0x001BD5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x001BF3EC File Offset: 0x001BD5EC
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400525C RID: 21084
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400525D RID: 21085
		public const int SkillIdFieldNumber = 8;

		// Token: 0x0400525E RID: 21086
		private long skillId_;
	}
}
