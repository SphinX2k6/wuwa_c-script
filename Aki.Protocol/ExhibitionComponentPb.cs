using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004D2 RID: 1234
	public sealed class ExhibitionComponentPb : IMessage<ExhibitionComponentPb>, IMessage, IEquatable<ExhibitionComponentPb>, IDeepCloneable<ExhibitionComponentPb>, IBufferMessage
	{
		// Token: 0x06007573 RID: 30067 RVA: 0x0011FB3C File Offset: 0x0011DD3C
		[NullableContext(1)]
		public static ExhibitionComponentPb Create()
		{
			return new ExhibitionComponentPb();
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06007574 RID: 30068 RVA: 0x0011FB43 File Offset: 0x0011DD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06007575 RID: 30069 RVA: 0x0011FB46 File Offset: 0x0011DD46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExhibitionComponentPb.Descriptor;
			}
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x0011FB4D File Offset: 0x0011DD4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb()
		{
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x0011FB55 File Offset: 0x0011DD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb(ExhibitionComponentPb other) : this()
		{
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x0011FB7A File Offset: 0x0011DD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExhibitionComponentPb Clone()
		{
			return new ExhibitionComponentPb(this);
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x0011FB82 File Offset: 0x0011DD82
		// (set) Token: 0x0600757A RID: 30074 RVA: 0x0011FB8A File Offset: 0x0011DD8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x0011FB93 File Offset: 0x0011DD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExhibitionComponentPb);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x0011FBA1 File Offset: 0x0011DDA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExhibitionComponentPb other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x0011FBD0 File Offset: 0x0011DDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x0011FC0F File Offset: 0x0011DE0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x0011FC1C File Offset: 0x0011DE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0011FC25 File Offset: 0x0011DE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x0011FC58 File Offset: 0x0011DE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x0011FC96 File Offset: 0x0011DE96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExhibitionComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x0011FCC7 File Offset: 0x0011DEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x0011FCD0 File Offset: 0x0011DED0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003E09 RID: 15881
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E0A RID: 15882
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04003E0B RID: 15883
		private int itemId_;
	}
}
