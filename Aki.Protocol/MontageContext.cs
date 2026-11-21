using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F6 RID: 2550
	public sealed class MontageContext : IMessage<MontageContext>, IMessage, IEquatable<MontageContext>, IDeepCloneable<MontageContext>, IBufferMessage
	{
		// Token: 0x0600DF84 RID: 57220 RVA: 0x0020C650 File Offset: 0x0020A850
		[NullableContext(1)]
		public static MontageContext Create()
		{
			return new MontageContext();
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600DF85 RID: 57221 RVA: 0x0020C657 File Offset: 0x0020A857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600DF86 RID: 57222 RVA: 0x0020C65A File Offset: 0x0020A85A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MontageContext.Descriptor;
			}
		}

		// Token: 0x0600DF87 RID: 57223 RVA: 0x0020C661 File Offset: 0x0020A861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext()
		{
		}

		// Token: 0x0600DF88 RID: 57224 RVA: 0x0020C669 File Offset: 0x0020A869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext(MontageContext other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF89 RID: 57225 RVA: 0x0020C6A6 File Offset: 0x0020A8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MontageContext Clone()
		{
			return new MontageContext(this);
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x0020C6AE File Offset: 0x0020A8AE
		// (set) Token: 0x0600DF8B RID: 57227 RVA: 0x0020C6B6 File Offset: 0x0020A8B6
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

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x0600DF8C RID: 57228 RVA: 0x0020C6BF File Offset: 0x0020A8BF
		// (set) Token: 0x0600DF8D RID: 57229 RVA: 0x0020C6C7 File Offset: 0x0020A8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MontageIndex
		{
			get
			{
				return this.montageIndex_;
			}
			set
			{
				this.montageIndex_ = value;
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x0020C6D0 File Offset: 0x0020A8D0
		// (set) Token: 0x0600DF8F RID: 57231 RVA: 0x0020C6D8 File Offset: 0x0020A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ContextId
		{
			get
			{
				return this.contextId_;
			}
			set
			{
				this.contextId_ = value;
			}
		}

		// Token: 0x0600DF90 RID: 57232 RVA: 0x0020C6E1 File Offset: 0x0020A8E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MontageContext);
		}

		// Token: 0x0600DF91 RID: 57233 RVA: 0x0020C6F0 File Offset: 0x0020A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MontageContext other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF92 RID: 57234 RVA: 0x0020C74C File Offset: 0x0020A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.MontageIndex != 0)
			{
				num ^= this.MontageIndex.GetHashCode();
			}
			if (this.ContextId != 0L)
			{
				num ^= this.ContextId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF93 RID: 57235 RVA: 0x0020C7BD File Offset: 0x0020A9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF94 RID: 57236 RVA: 0x0020C7CA File Offset: 0x0020A9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF95 RID: 57237 RVA: 0x0020C7D4 File Offset: 0x0020A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MontageIndex);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF96 RID: 57238 RVA: 0x0020C848 File Offset: 0x0020AA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
			}
			if (this.MontageIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MontageIndex);
			}
			if (this.ContextId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF97 RID: 57239 RVA: 0x0020C8B8 File Offset: 0x0020AAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MontageContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.MontageIndex != 0)
			{
				this.MontageIndex = other.MontageIndex;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF98 RID: 57240 RVA: 0x0020C91C File Offset: 0x0020AB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF99 RID: 57241 RVA: 0x0020C928 File Offset: 0x0020AB28
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
							this.ContextId = input.ReadInt64();
						}
					}
					else
					{
						this.MontageIndex = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005C76 RID: 23670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C77 RID: 23671
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04005C78 RID: 23672
		private long skillId_;

		// Token: 0x04005C79 RID: 23673
		public const int MontageIndexFieldNumber = 2;

		// Token: 0x04005C7A RID: 23674
		private int montageIndex_;

		// Token: 0x04005C7B RID: 23675
		public const int ContextIdFieldNumber = 3;

		// Token: 0x04005C7C RID: 23676
		private long contextId_;
	}
}
