using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E6 RID: 998
	public sealed class DoubleInstActivityReward : IMessage<DoubleInstActivityReward>, IMessage, IEquatable<DoubleInstActivityReward>, IDeepCloneable<DoubleInstActivityReward>, IBufferMessage
	{
		// Token: 0x06006118 RID: 24856 RVA: 0x000EA6C5 File Offset: 0x000E88C5
		[NullableContext(1)]
		public static DoubleInstActivityReward Create()
		{
			return new DoubleInstActivityReward();
		}

		// Token: 0x1700120F RID: 4623
		// (get) Token: 0x06006119 RID: 24857 RVA: 0x000EA6CC File Offset: 0x000E88CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001210 RID: 4624
		// (get) Token: 0x0600611A RID: 24858 RVA: 0x000EA6CF File Offset: 0x000E88CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoubleInstActivityReward.Descriptor;
			}
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x000EA6D6 File Offset: 0x000E88D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward()
		{
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x000EA6DE File Offset: 0x000E88DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward(DoubleInstActivityReward other) : this()
		{
			this.getDoubleInstRwdCount_ = other.getDoubleInstRwdCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x000EA703 File Offset: 0x000E8903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward Clone()
		{
			return new DoubleInstActivityReward(this);
		}

		// Token: 0x17001211 RID: 4625
		// (get) Token: 0x0600611E RID: 24862 RVA: 0x000EA70B File Offset: 0x000E890B
		// (set) Token: 0x0600611F RID: 24863 RVA: 0x000EA713 File Offset: 0x000E8913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GetDoubleInstRwdCount
		{
			get
			{
				return this.getDoubleInstRwdCount_;
			}
			set
			{
				this.getDoubleInstRwdCount_ = value;
			}
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x000EA71C File Offset: 0x000E891C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoubleInstActivityReward);
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x000EA72A File Offset: 0x000E892A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoubleInstActivityReward other)
		{
			return other != null && (other == this || (this.GetDoubleInstRwdCount == other.GetDoubleInstRwdCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x000EA758 File Offset: 0x000E8958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GetDoubleInstRwdCount != 0)
			{
				num ^= this.GetDoubleInstRwdCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x000EA797 File Offset: 0x000E8997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x000EA7A4 File Offset: 0x000E89A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x000EA7AD File Offset: 0x000E89AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GetDoubleInstRwdCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GetDoubleInstRwdCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x000EA7E0 File Offset: 0x000E89E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GetDoubleInstRwdCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GetDoubleInstRwdCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x000EA81E File Offset: 0x000E8A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoubleInstActivityReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GetDoubleInstRwdCount != 0)
			{
				this.GetDoubleInstRwdCount = other.GetDoubleInstRwdCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x000EA84F File Offset: 0x000E8A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x000EA858 File Offset: 0x000E8A58
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
					this.GetDoubleInstRwdCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037D7 RID: 14295
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037D8 RID: 14296
		public const int GetDoubleInstRwdCountFieldNumber = 1;

		// Token: 0x040037D9 RID: 14297
		private int getDoubleInstRwdCount_;
	}
}
