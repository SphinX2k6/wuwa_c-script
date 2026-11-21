using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000F9 RID: 249
	[NetMessage(EMessageId.ANStartPush)]
	public sealed class ANStartPush : IMessage<ANStartPush>, IMessage, IEquatable<ANStartPush>, IDeepCloneable<ANStartPush>, IBufferMessage
	{
		// Token: 0x06002381 RID: 9089 RVA: 0x0005EB87 File Offset: 0x0005CD87
		[NullableContext(1)]
		public static ANStartPush Create()
		{
			return new ANStartPush();
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06002382 RID: 9090 RVA: 0x0005EB8E File Offset: 0x0005CD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x0005EB91 File Offset: 0x0005CD91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ANStartPush.Descriptor;
			}
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x0005EB98 File Offset: 0x0005CD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush()
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush(ANStartPush other) : this()
		{
			this.skillId_ = other.skillId_;
			this.montageIndex_ = other.montageIndex_;
			this.anIndex_ = other.anIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x0005EBDD File Offset: 0x0005CDDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ANStartPush Clone()
		{
			return new ANStartPush(this);
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06002387 RID: 9095 RVA: 0x0005EBE5 File Offset: 0x0005CDE5
		// (set) Token: 0x06002388 RID: 9096 RVA: 0x0005EBED File Offset: 0x0005CDED
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

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06002389 RID: 9097 RVA: 0x0005EBF6 File Offset: 0x0005CDF6
		// (set) Token: 0x0600238A RID: 9098 RVA: 0x0005EBFE File Offset: 0x0005CDFE
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

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600238B RID: 9099 RVA: 0x0005EC07 File Offset: 0x0005CE07
		// (set) Token: 0x0600238C RID: 9100 RVA: 0x0005EC0F File Offset: 0x0005CE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AnIndex
		{
			get
			{
				return this.anIndex_;
			}
			set
			{
				this.anIndex_ = value;
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0005EC18 File Offset: 0x0005CE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ANStartPush);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0005EC28 File Offset: 0x0005CE28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ANStartPush other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.MontageIndex == other.MontageIndex && this.AnIndex == other.AnIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0005EC84 File Offset: 0x0005CE84
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
			if (this.AnIndex != 0)
			{
				num ^= this.AnIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0005ECF5 File Offset: 0x0005CEF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0005ED02 File Offset: 0x0005CF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0005ED0C File Offset: 0x0005CF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.SkillId);
			}
			if (this.AnIndex != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AnIndex);
			}
			if (this.MontageIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.MontageIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0005ED84 File Offset: 0x0005CF84
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
			if (this.AnIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AnIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ANStartPush other)
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
			if (other.AnIndex != 0)
			{
				this.AnIndex = other.AnIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0005EE58 File Offset: 0x0005D058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0005EE64 File Offset: 0x0005D064
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
				if (num != 24U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MontageIndex = input.ReadInt32();
						}
					}
					else
					{
						this.AnIndex = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002544 RID: 9540
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002545 RID: 9541
		public const int SkillIdFieldNumber = 3;

		// Token: 0x04002546 RID: 9542
		private long skillId_;

		// Token: 0x04002547 RID: 9543
		public const int MontageIndexFieldNumber = 14;

		// Token: 0x04002548 RID: 9544
		private int montageIndex_;

		// Token: 0x04002549 RID: 9545
		public const int AnIndexFieldNumber = 13;

		// Token: 0x0400254A RID: 9546
		private int anIndex_;
	}
}
