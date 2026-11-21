using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F9 RID: 1273
	[NetMessage(EMessageId.ExploreToolUpdateNotify)]
	public sealed class ExploreToolUpdateNotify : IMessage<ExploreToolUpdateNotify>, IMessage, IEquatable<ExploreToolUpdateNotify>, IDeepCloneable<ExploreToolUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007855 RID: 30805 RVA: 0x0012528D File Offset: 0x0012348D
		[NullableContext(1)]
		public static ExploreToolUpdateNotify Create()
		{
			return new ExploreToolUpdateNotify();
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x00125294 File Offset: 0x00123494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06007857 RID: 30807 RVA: 0x00125297 File Offset: 0x00123497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x0012529E File Offset: 0x0012349E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify()
		{
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x001252A6 File Offset: 0x001234A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify(ExploreToolUpdateNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x001252CB File Offset: 0x001234CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify Clone()
		{
			return new ExploreToolUpdateNotify(this);
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600785B RID: 30811 RVA: 0x001252D3 File Offset: 0x001234D3
		// (set) Token: 0x0600785C RID: 30812 RVA: 0x001252DB File Offset: 0x001234DB
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

		// Token: 0x0600785D RID: 30813 RVA: 0x001252E4 File Offset: 0x001234E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolUpdateNotify);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x001252F2 File Offset: 0x001234F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolUpdateNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x00125320 File Offset: 0x00123520
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

		// Token: 0x06007860 RID: 30816 RVA: 0x0012535F File Offset: 0x0012355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x0012536C File Offset: 0x0012356C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00125375 File Offset: 0x00123575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x001253A8 File Offset: 0x001235A8
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

		// Token: 0x06007864 RID: 30820 RVA: 0x001253E6 File Offset: 0x001235E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreToolUpdateNotify other)
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

		// Token: 0x06007865 RID: 30821 RVA: 0x00125417 File Offset: 0x00123617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00125420 File Offset: 0x00123620
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003EB5 RID: 16053
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EB6 RID: 16054
		public const int SkillIdFieldNumber = 7;

		// Token: 0x04003EB7 RID: 16055
		private int skillId_;
	}
}
