using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AE RID: 942
	public sealed class DarkTideNormalItemPb : IMessage<DarkTideNormalItemPb>, IMessage, IEquatable<DarkTideNormalItemPb>, IDeepCloneable<DarkTideNormalItemPb>, IBufferMessage
	{
		// Token: 0x06005C8C RID: 23692 RVA: 0x000E0E2E File Offset: 0x000DF02E
		[NullableContext(1)]
		public static DarkTideNormalItemPb Create()
		{
			return new DarkTideNormalItemPb();
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06005C8D RID: 23693 RVA: 0x000E0E35 File Offset: 0x000DF035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DarkTideNormalItemPb> Parser
		{
			get
			{
				return DarkTideNormalItemPb._parser;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x000E0E3C File Offset: 0x000DF03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x06005C8F RID: 23695 RVA: 0x000E0E3F File Offset: 0x000DF03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideNormalItemPb.Descriptor;
			}
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x000E0E46 File Offset: 0x000DF046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideNormalItemPb()
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x000E0E4E File Offset: 0x000DF04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideNormalItemPb(DarkTideNormalItemPb other) : this()
		{
			this.configId_ = other.configId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x000E0E7F File Offset: 0x000DF07F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideNormalItemPb Clone()
		{
			return new DarkTideNormalItemPb(this);
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x06005C93 RID: 23699 RVA: 0x000E0E87 File Offset: 0x000DF087
		// (set) Token: 0x06005C94 RID: 23700 RVA: 0x000E0E8F File Offset: 0x000DF08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x06005C95 RID: 23701 RVA: 0x000E0E98 File Offset: 0x000DF098
		// (set) Token: 0x06005C96 RID: 23702 RVA: 0x000E0EA0 File Offset: 0x000DF0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x000E0EA9 File Offset: 0x000DF0A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideNormalItemPb);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x000E0EB7 File Offset: 0x000DF0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideNormalItemPb other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x000E0EF8 File Offset: 0x000DF0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x000E0F50 File Offset: 0x000DF150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x000E0F5D File Offset: 0x000DF15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x000E0F68 File Offset: 0x000DF168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x000E0FC0 File Offset: 0x000DF1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x000E1018 File Offset: 0x000DF218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideNormalItemPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x000E1068 File Offset: 0x000DF268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x000E1074 File Offset: 0x000DF274
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003653 RID: 13907
		private static readonly MessageParser<DarkTideNormalItemPb> _parser = new MessageParser<DarkTideNormalItemPb>(() => new DarkTideNormalItemPb());

		// Token: 0x04003654 RID: 13908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003655 RID: 13909
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04003656 RID: 13910
		private int configId_;

		// Token: 0x04003657 RID: 13911
		public const int CountFieldNumber = 2;

		// Token: 0x04003658 RID: 13912
		private int count_;
	}
}
