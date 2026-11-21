using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE5 RID: 3813
	[NetMessage(EMessageId.RemoveCombineRelationNotify)]
	public sealed class RemoveCombineRelationNotify : IMessage<RemoveCombineRelationNotify>, IMessage, IEquatable<RemoveCombineRelationNotify>, IDeepCloneable<RemoveCombineRelationNotify>, IBufferMessage
	{
		// Token: 0x06014761 RID: 83809 RVA: 0x002F9C11 File Offset: 0x002F7E11
		[NullableContext(1)]
		public static RemoveCombineRelationNotify Create()
		{
			return new RemoveCombineRelationNotify();
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x06014762 RID: 83810 RVA: 0x002F9C18 File Offset: 0x002F7E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x06014763 RID: 83811 RVA: 0x002F9C1B File Offset: 0x002F7E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveCombineRelationNotify.Descriptor;
			}
		}

		// Token: 0x06014764 RID: 83812 RVA: 0x002F9C22 File Offset: 0x002F7E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify()
		{
		}

		// Token: 0x06014765 RID: 83813 RVA: 0x002F9C2A File Offset: 0x002F7E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify(RemoveCombineRelationNotify other) : this()
		{
			this.combinerEntity_ = other.combinerEntity_;
			this.targetEntity_ = other.targetEntity_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014766 RID: 83814 RVA: 0x002F9C5B File Offset: 0x002F7E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveCombineRelationNotify Clone()
		{
			return new RemoveCombineRelationNotify(this);
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x06014767 RID: 83815 RVA: 0x002F9C63 File Offset: 0x002F7E63
		// (set) Token: 0x06014768 RID: 83816 RVA: 0x002F9C6B File Offset: 0x002F7E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CombinerEntity
		{
			get
			{
				return this.combinerEntity_;
			}
			set
			{
				this.combinerEntity_ = value;
			}
		}

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x06014769 RID: 83817 RVA: 0x002F9C74 File Offset: 0x002F7E74
		// (set) Token: 0x0601476A RID: 83818 RVA: 0x002F9C7C File Offset: 0x002F7E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntity
		{
			get
			{
				return this.targetEntity_;
			}
			set
			{
				this.targetEntity_ = value;
			}
		}

		// Token: 0x0601476B RID: 83819 RVA: 0x002F9C85 File Offset: 0x002F7E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveCombineRelationNotify);
		}

		// Token: 0x0601476C RID: 83820 RVA: 0x002F9C93 File Offset: 0x002F7E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveCombineRelationNotify other)
		{
			return other != null && (other == this || (this.CombinerEntity == other.CombinerEntity && this.TargetEntity == other.TargetEntity && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601476D RID: 83821 RVA: 0x002F9CD4 File Offset: 0x002F7ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CombinerEntity != 0L)
			{
				num ^= this.CombinerEntity.GetHashCode();
			}
			if (this.TargetEntity != 0L)
			{
				num ^= this.TargetEntity.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601476E RID: 83822 RVA: 0x002F9D2C File Offset: 0x002F7F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601476F RID: 83823 RVA: 0x002F9D39 File Offset: 0x002F7F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014770 RID: 83824 RVA: 0x002F9D44 File Offset: 0x002F7F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CombinerEntity != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.CombinerEntity);
			}
			if (this.TargetEntity != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TargetEntity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014771 RID: 83825 RVA: 0x002F9DA0 File Offset: 0x002F7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CombinerEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CombinerEntity);
			}
			if (this.TargetEntity != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntity);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014772 RID: 83826 RVA: 0x002F9DF8 File Offset: 0x002F7FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveCombineRelationNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CombinerEntity != 0L)
			{
				this.CombinerEntity = other.CombinerEntity;
			}
			if (other.TargetEntity != 0L)
			{
				this.TargetEntity = other.TargetEntity;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014773 RID: 83827 RVA: 0x002F9E48 File Offset: 0x002F8048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014774 RID: 83828 RVA: 0x002F9E54 File Offset: 0x002F8054
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetEntity = input.ReadInt64();
					}
				}
				else
				{
					this.CombinerEntity = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007C8F RID: 31887
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C90 RID: 31888
		public const int CombinerEntityFieldNumber = 8;

		// Token: 0x04007C91 RID: 31889
		private long combinerEntity_;

		// Token: 0x04007C92 RID: 31890
		public const int TargetEntityFieldNumber = 14;

		// Token: 0x04007C93 RID: 31891
		private long targetEntity_;
	}
}
