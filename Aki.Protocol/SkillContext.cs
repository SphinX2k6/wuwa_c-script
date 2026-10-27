using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001238 RID: 4664
	public sealed class SkillContext : IMessage<SkillContext>, IMessage, IEquatable<SkillContext>, IDeepCloneable<SkillContext>, IBufferMessage
	{
		// Token: 0x06018DAB RID: 101803 RVA: 0x0039DD2A File Offset: 0x0039BF2A
		[NullableContext(1)]
		public static SkillContext Create()
		{
			return new SkillContext();
		}

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x06018DAC RID: 101804 RVA: 0x0039DD31 File Offset: 0x0039BF31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x06018DAD RID: 101805 RVA: 0x0039DD34 File Offset: 0x0039BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillContext.Descriptor;
			}
		}

		// Token: 0x06018DAE RID: 101806 RVA: 0x0039DD3B File Offset: 0x0039BF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext()
		{
		}

		// Token: 0x06018DAF RID: 101807 RVA: 0x0039DD43 File Offset: 0x0039BF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext(SkillContext other) : this()
		{
			this.skillId_ = other.skillId_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018DB0 RID: 101808 RVA: 0x0039DD74 File Offset: 0x0039BF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext Clone()
		{
			return new SkillContext(this);
		}

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x06018DB1 RID: 101809 RVA: 0x0039DD7C File Offset: 0x0039BF7C
		// (set) Token: 0x06018DB2 RID: 101810 RVA: 0x0039DD84 File Offset: 0x0039BF84
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

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x06018DB3 RID: 101811 RVA: 0x0039DD8D File Offset: 0x0039BF8D
		// (set) Token: 0x06018DB4 RID: 101812 RVA: 0x0039DD95 File Offset: 0x0039BF95
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

		// Token: 0x06018DB5 RID: 101813 RVA: 0x0039DD9E File Offset: 0x0039BF9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillContext);
		}

		// Token: 0x06018DB6 RID: 101814 RVA: 0x0039DDAC File Offset: 0x0039BFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillContext other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x0039DDEC File Offset: 0x0039BFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0L)
			{
				num ^= this.SkillId.GetHashCode();
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

		// Token: 0x06018DB8 RID: 101816 RVA: 0x0039DE44 File Offset: 0x0039C044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018DB9 RID: 101817 RVA: 0x0039DE51 File Offset: 0x0039C051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018DBA RID: 101818 RVA: 0x0039DE5C File Offset: 0x0039C05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SkillId);
			}
			if (this.ContextId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ContextId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018DBB RID: 101819 RVA: 0x0039DEB4 File Offset: 0x0039C0B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SkillId);
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

		// Token: 0x06018DBC RID: 101820 RVA: 0x0039DF0C File Offset: 0x0039C10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkillContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0L)
			{
				this.SkillId = other.SkillId;
			}
			if (other.ContextId != 0L)
			{
				this.ContextId = other.ContextId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018DBD RID: 101821 RVA: 0x0039DF5C File Offset: 0x0039C15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018DBE RID: 101822 RVA: 0x0039DF68 File Offset: 0x0039C168
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
						this.ContextId = input.ReadInt64();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400929A RID: 37530
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400929B RID: 37531
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400929C RID: 37532
		private long skillId_;

		// Token: 0x0400929D RID: 37533
		public const int ContextIdFieldNumber = 2;

		// Token: 0x0400929E RID: 37534
		private long contextId_;
	}
}
