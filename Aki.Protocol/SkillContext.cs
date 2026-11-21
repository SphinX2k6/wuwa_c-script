using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001275 RID: 4725
	public sealed class SkillContext : IMessage<SkillContext>, IMessage, IEquatable<SkillContext>, IDeepCloneable<SkillContext>, IBufferMessage
	{
		// Token: 0x06019395 RID: 103317 RVA: 0x003ADC8A File Offset: 0x003ABE8A
		[NullableContext(1)]
		public static SkillContext Create()
		{
			return new SkillContext();
		}

		// Token: 0x1700554A RID: 21834
		// (get) Token: 0x06019396 RID: 103318 RVA: 0x003ADC91 File Offset: 0x003ABE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700554B RID: 21835
		// (get) Token: 0x06019397 RID: 103319 RVA: 0x003ADC94 File Offset: 0x003ABE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkillContext.Descriptor;
			}
		}

		// Token: 0x06019398 RID: 103320 RVA: 0x003ADC9B File Offset: 0x003ABE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext()
		{
		}

		// Token: 0x06019399 RID: 103321 RVA: 0x003ADCA3 File Offset: 0x003ABEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext(SkillContext other) : this()
		{
			this.skillId_ = other.skillId_;
			this.contextId_ = other.contextId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601939A RID: 103322 RVA: 0x003ADCD4 File Offset: 0x003ABED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillContext Clone()
		{
			return new SkillContext(this);
		}

		// Token: 0x1700554C RID: 21836
		// (get) Token: 0x0601939B RID: 103323 RVA: 0x003ADCDC File Offset: 0x003ABEDC
		// (set) Token: 0x0601939C RID: 103324 RVA: 0x003ADCE4 File Offset: 0x003ABEE4
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

		// Token: 0x1700554D RID: 21837
		// (get) Token: 0x0601939D RID: 103325 RVA: 0x003ADCED File Offset: 0x003ABEED
		// (set) Token: 0x0601939E RID: 103326 RVA: 0x003ADCF5 File Offset: 0x003ABEF5
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

		// Token: 0x0601939F RID: 103327 RVA: 0x003ADCFE File Offset: 0x003ABEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkillContext);
		}

		// Token: 0x060193A0 RID: 103328 RVA: 0x003ADD0C File Offset: 0x003ABF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkillContext other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.ContextId == other.ContextId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060193A1 RID: 103329 RVA: 0x003ADD4C File Offset: 0x003ABF4C
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

		// Token: 0x060193A2 RID: 103330 RVA: 0x003ADDA4 File Offset: 0x003ABFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060193A3 RID: 103331 RVA: 0x003ADDB1 File Offset: 0x003ABFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060193A4 RID: 103332 RVA: 0x003ADDBC File Offset: 0x003ABFBC
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

		// Token: 0x060193A5 RID: 103333 RVA: 0x003ADE14 File Offset: 0x003AC014
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

		// Token: 0x060193A6 RID: 103334 RVA: 0x003ADE6C File Offset: 0x003AC06C
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

		// Token: 0x060193A7 RID: 103335 RVA: 0x003ADEBC File Offset: 0x003AC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060193A8 RID: 103336 RVA: 0x003ADEC8 File Offset: 0x003AC0C8
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

		// Token: 0x0400954C RID: 38220
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400954D RID: 38221
		public const int SkillIdFieldNumber = 1;

		// Token: 0x0400954E RID: 38222
		private long skillId_;

		// Token: 0x0400954F RID: 38223
		public const int ContextIdFieldNumber = 2;

		// Token: 0x04009550 RID: 38224
		private long contextId_;
	}
}
