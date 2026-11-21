using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C1 RID: 705
	[NetMessage(EMessageId.CommonOrganActionListNotify)]
	public sealed class CommonOrganActionListNotify : IMessage<CommonOrganActionListNotify>, IMessage, IEquatable<CommonOrganActionListNotify>, IDeepCloneable<CommonOrganActionListNotify>, IBufferMessage
	{
		// Token: 0x060048E3 RID: 18659 RVA: 0x000B2FF1 File Offset: 0x000B11F1
		[NullableContext(1)]
		public static CommonOrganActionListNotify Create()
		{
			return new CommonOrganActionListNotify();
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x000B2FF8 File Offset: 0x000B11F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060048E5 RID: 18661 RVA: 0x000B2FFB File Offset: 0x000B11FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonOrganActionListNotify.Descriptor;
			}
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x000B3002 File Offset: 0x000B1202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify()
		{
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x000B300A File Offset: 0x000B120A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify(CommonOrganActionListNotify other) : this()
		{
			this.id_ = other.id_;
			this.actionIndex_ = other.actionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x000B303B File Offset: 0x000B123B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonOrganActionListNotify Clone()
		{
			return new CommonOrganActionListNotify(this);
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060048E9 RID: 18665 RVA: 0x000B3043 File Offset: 0x000B1243
		// (set) Token: 0x060048EA RID: 18666 RVA: 0x000B304B File Offset: 0x000B124B
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060048EB RID: 18667 RVA: 0x000B3054 File Offset: 0x000B1254
		// (set) Token: 0x060048EC RID: 18668 RVA: 0x000B305C File Offset: 0x000B125C
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

		// Token: 0x060048ED RID: 18669 RVA: 0x000B3065 File Offset: 0x000B1265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonOrganActionListNotify);
		}

		// Token: 0x060048EE RID: 18670 RVA: 0x000B3073 File Offset: 0x000B1273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonOrganActionListNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ActionIndex == other.ActionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x000B30B4 File Offset: 0x000B12B4
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

		// Token: 0x060048F0 RID: 18672 RVA: 0x000B310C File Offset: 0x000B130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x000B3119 File Offset: 0x000B1319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x000B3124 File Offset: 0x000B1324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.Id);
			}
			if (this.ActionIndex != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x000B3180 File Offset: 0x000B1380
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

		// Token: 0x060048F4 RID: 18676 RVA: 0x000B31D8 File Offset: 0x000B13D8
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

		// Token: 0x060048F5 RID: 18677 RVA: 0x000B3228 File Offset: 0x000B1428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x000B3234 File Offset: 0x000B1434
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActionIndex = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003060 RID: 12384
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003061 RID: 12385
		public const int IdFieldNumber = 7;

		// Token: 0x04003062 RID: 12386
		private int id_;

		// Token: 0x04003063 RID: 12387
		public const int ActionIndexFieldNumber = 14;

		// Token: 0x04003064 RID: 12388
		private int actionIndex_;
	}
}
