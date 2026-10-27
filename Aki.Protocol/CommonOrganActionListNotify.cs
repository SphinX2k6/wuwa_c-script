using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BB RID: 699
	[NetMessage(EMessageId.CommonOrganActionListNotify)]
	public sealed class CommonOrganActionListNotify : IMessage<CommonOrganActionListNotify>, IMessage, IEquatable<CommonOrganActionListNotify>, IDeepCloneable<CommonOrganActionListNotify>, IBufferMessage
	{
		// Token: 0x0600481C RID: 18460 RVA: 0x000B0DED File Offset: 0x000AEFED
		[NullableContext(1)]
		public static CommonOrganActionListNotify Create()
		{
			return new CommonOrganActionListNotify();
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600481D RID: 18461 RVA: 0x000B0DF4 File Offset: 0x000AEFF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x000B0DF7 File Offset: 0x000AEFF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganActionListNotify.Descriptor;
			}
		}

		// Token: 0x0600481F RID: 18463 RVA: 0x000B0DFE File Offset: 0x000AEFFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify()
		{
		}

		// Token: 0x06004820 RID: 18464 RVA: 0x000B0E06 File Offset: 0x000AF006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify(CommonOrganActionListNotify other) : this()
		{
			this.id_ = other.id_;
			this.actionIndex_ = other.actionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004821 RID: 18465 RVA: 0x000B0E37 File Offset: 0x000AF037
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify Clone()
		{
			return new CommonOrganActionListNotify(this);
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x000B0E3F File Offset: 0x000AF03F
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x000B0E47 File Offset: 0x000AF047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x000B0E50 File Offset: 0x000AF050
		// (set) Token: 0x06004825 RID: 18469 RVA: 0x000B0E58 File Offset: 0x000AF058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActionIndex
		{
			get
			{
				return this.actionIndex_;
			}
			set
			{
				this.actionIndex_ = value;
			}
		}

		// Token: 0x06004826 RID: 18470 RVA: 0x000B0E61 File Offset: 0x000AF061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganActionListNotify);
		}

		// Token: 0x06004827 RID: 18471 RVA: 0x000B0E6F File Offset: 0x000AF06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganActionListNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActionIndex == other.ActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004828 RID: 18472 RVA: 0x000B0EB0 File Offset: 0x000AF0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ActionIndex != 0)
			{
				num ^= this.ActionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x000B0F08 File Offset: 0x000AF108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x000B0F15 File Offset: 0x000AF115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x000B0F20 File Offset: 0x000AF120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActionIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActionIndex);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x000B0F78 File Offset: 0x000AF178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.ActionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x000B0FD0 File Offset: 0x000AF1D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonOrganActionListNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.ActionIndex != 0)
			{
				this.ActionIndex = other.ActionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x000B1020 File Offset: 0x000AF220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x000B102C File Offset: 0x000AF22C
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
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ActionIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002FCD RID: 12237
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FCE RID: 12238
		public const int IdFieldNumber = 2;

		// Token: 0x04002FCF RID: 12239
		private int id_;

		// Token: 0x04002FD0 RID: 12240
		public const int ActionIndexFieldNumber = 1;

		// Token: 0x04002FD1 RID: 12241
		private int actionIndex_;
	}
}
