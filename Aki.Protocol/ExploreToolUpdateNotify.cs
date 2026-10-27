using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050F RID: 1295
	[NetMessage(EMessageId.ExploreToolUpdateNotify)]
	public sealed class ExploreToolUpdateNotify : IMessage<ExploreToolUpdateNotify>, IMessage, IEquatable<ExploreToolUpdateNotify>, IDeepCloneable<ExploreToolUpdateNotify>, IBufferMessage
	{
		// Token: 0x060079D1 RID: 31185 RVA: 0x00128121 File Offset: 0x00126321
		[NullableContext(1)]
		public static ExploreToolUpdateNotify Create()
		{
			return new ExploreToolUpdateNotify();
		}

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x060079D2 RID: 31186 RVA: 0x00128128 File Offset: 0x00126328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x060079D3 RID: 31187 RVA: 0x0012812B File Offset: 0x0012632B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreToolUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x00128132 File Offset: 0x00126332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify()
		{
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x0012813A File Offset: 0x0012633A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify(ExploreToolUpdateNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060079D6 RID: 31190 RVA: 0x0012815F File Offset: 0x0012635F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreToolUpdateNotify Clone()
		{
			return new ExploreToolUpdateNotify(this);
		}

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x060079D7 RID: 31191 RVA: 0x00128167 File Offset: 0x00126367
		// (set) Token: 0x060079D8 RID: 31192 RVA: 0x0012816F File Offset: 0x0012636F
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

		// Token: 0x060079D9 RID: 31193 RVA: 0x00128178 File Offset: 0x00126378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreToolUpdateNotify);
		}

		// Token: 0x060079DA RID: 31194 RVA: 0x00128186 File Offset: 0x00126386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreToolUpdateNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060079DB RID: 31195 RVA: 0x001281B4 File Offset: 0x001263B4
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

		// Token: 0x060079DC RID: 31196 RVA: 0x001281F3 File Offset: 0x001263F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060079DD RID: 31197 RVA: 0x00128200 File Offset: 0x00126400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060079DE RID: 31198 RVA: 0x00128209 File Offset: 0x00126409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060079DF RID: 31199 RVA: 0x0012823C File Offset: 0x0012643C
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

		// Token: 0x060079E0 RID: 31200 RVA: 0x0012827A File Offset: 0x0012647A
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

		// Token: 0x060079E1 RID: 31201 RVA: 0x001282AB File Offset: 0x001264AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079E2 RID: 31202 RVA: 0x001282B4 File Offset: 0x001264B4
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
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003EC4 RID: 16068
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EC5 RID: 16069
		public const int SkillIdFieldNumber = 8;

		// Token: 0x04003EC6 RID: 16070
		private int skillId_;
	}
}
