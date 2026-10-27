using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200020A RID: 522
	[NetMessage(EMessageId.BuffStackCountRequest)]
	public sealed class BuffStackCountRequest : IMessage<BuffStackCountRequest>, IMessage, IEquatable<BuffStackCountRequest>, IDeepCloneable<BuffStackCountRequest>, IBufferMessage
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x0008FCD5 File Offset: 0x0008DED5
		[NullableContext(1)]
		public static BuffStackCountRequest Create()
		{
			return new BuffStackCountRequest();
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x0600399E RID: 14750 RVA: 0x0008FCDC File Offset: 0x0008DEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x0008FCDF File Offset: 0x0008DEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuffStackCountRequest.Descriptor;
			}
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0008FCE6 File Offset: 0x0008DEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest()
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x0008FCF0 File Offset: 0x0008DEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest(BuffStackCountRequest other) : this()
		{
			this.handleId_ = other.handleId_;
			this.newStackCount_ = other.newStackCount_;
			this.isPrematureRemoval_ = other.isPrematureRemoval_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0008FD44 File Offset: 0x0008DF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffStackCountRequest Clone()
		{
			return new BuffStackCountRequest(this);
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x0008FD4C File Offset: 0x0008DF4C
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x0008FD54 File Offset: 0x0008DF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandleId
		{
			get
			{
				return this.handleId_;
			}
			set
			{
				this.handleId_ = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x0008FD5D File Offset: 0x0008DF5D
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x0008FD65 File Offset: 0x0008DF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewStackCount
		{
			get
			{
				return this.newStackCount_;
			}
			set
			{
				this.newStackCount_ = value;
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x0008FD6E File Offset: 0x0008DF6E
		// (set) Token: 0x060039A8 RID: 14760 RVA: 0x0008FD76 File Offset: 0x0008DF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPrematureRemoval
		{
			get
			{
				return this.isPrematureRemoval_;
			}
			set
			{
				this.isPrematureRemoval_ = value;
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x0008FD7F File Offset: 0x0008DF7F
		// (set) Token: 0x060039AA RID: 14762 RVA: 0x0008FD87 File Offset: 0x0008DF87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0008FD90 File Offset: 0x0008DF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuffStackCountRequest);
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x0008FDA0 File Offset: 0x0008DFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuffStackCountRequest other)
		{
			return other != null && (other == this || (this.HandleId == other.HandleId && this.NewStackCount == other.NewStackCount && this.IsPrematureRemoval == other.IsPrematureRemoval && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x0008FE0C File Offset: 0x0008E00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HandleId != 0)
			{
				num ^= this.HandleId.GetHashCode();
			}
			if (this.NewStackCount != 0)
			{
				num ^= this.NewStackCount.GetHashCode();
			}
			if (this.IsPrematureRemoval)
			{
				num ^= this.IsPrematureRemoval.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039AE RID: 14766 RVA: 0x0008FE96 File Offset: 0x0008E096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060039AF RID: 14767 RVA: 0x0008FEA3 File Offset: 0x0008E0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x0008FEAC File Offset: 0x0008E0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HandleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.HandleId);
			}
			if (this.IsPrematureRemoval)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsPrematureRemoval);
			}
			if (this.NewStackCount != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.NewStackCount);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0008FF40 File Offset: 0x0008E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HandleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandleId);
			}
			if (this.NewStackCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewStackCount);
			}
			if (this.IsPrematureRemoval)
			{
				num += 2;
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x0008FFBC File Offset: 0x0008E1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuffStackCountRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HandleId != 0)
			{
				this.HandleId = other.HandleId;
			}
			if (other.NewStackCount != 0)
			{
				this.NewStackCount = other.NewStackCount;
			}
			if (other.IsPrematureRemoval)
			{
				this.IsPrematureRemoval = other.IsPrematureRemoval;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00090034 File Offset: 0x0008E234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00090040 File Offset: 0x0008E240
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
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.HandleId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IsPrematureRemoval = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.NewStackCount = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.InstigatorId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002B99 RID: 11161
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B9A RID: 11162
		public const int HandleIdFieldNumber = 6;

		// Token: 0x04002B9B RID: 11163
		private int handleId_;

		// Token: 0x04002B9C RID: 11164
		public const int NewStackCountFieldNumber = 12;

		// Token: 0x04002B9D RID: 11165
		private int newStackCount_;

		// Token: 0x04002B9E RID: 11166
		public const int IsPrematureRemovalFieldNumber = 10;

		// Token: 0x04002B9F RID: 11167
		private bool isPrematureRemoval_;

		// Token: 0x04002BA0 RID: 11168
		public const int InstigatorIdFieldNumber = 13;

		// Token: 0x04002BA1 RID: 11169
		private long instigatorId_;
	}
}
