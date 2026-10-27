using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003FD RID: 1021
	public sealed class DoubleInstActivityReward : IMessage<DoubleInstActivityReward>, IMessage, IEquatable<DoubleInstActivityReward>, IDeepCloneable<DoubleInstActivityReward>, IBufferMessage
	{
		// Token: 0x060062A8 RID: 25256 RVA: 0x000ED83D File Offset: 0x000EBA3D
		[NullableContext(1)]
		public static DoubleInstActivityReward Create()
		{
			return new DoubleInstActivityReward();
		}

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x000ED844 File Offset: 0x000EBA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001265 RID: 4709
		// (get) Token: 0x060062AA RID: 25258 RVA: 0x000ED847 File Offset: 0x000EBA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoubleInstActivityReward.Descriptor;
			}
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x000ED84E File Offset: 0x000EBA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward()
		{
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x000ED856 File Offset: 0x000EBA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward(DoubleInstActivityReward other) : this()
		{
			this.getDoubleInstRwdCount_ = other.getDoubleInstRwdCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x000ED87B File Offset: 0x000EBA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoubleInstActivityReward Clone()
		{
			return new DoubleInstActivityReward(this);
		}

		// Token: 0x17001266 RID: 4710
		// (get) Token: 0x060062AE RID: 25262 RVA: 0x000ED883 File Offset: 0x000EBA83
		// (set) Token: 0x060062AF RID: 25263 RVA: 0x000ED88B File Offset: 0x000EBA8B
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

		// Token: 0x060062B0 RID: 25264 RVA: 0x000ED894 File Offset: 0x000EBA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoubleInstActivityReward);
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x000ED8A2 File Offset: 0x000EBAA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoubleInstActivityReward other)
		{
			return other != null && (other == this || (this.GetDoubleInstRwdCount == other.GetDoubleInstRwdCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x000ED8D0 File Offset: 0x000EBAD0
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

		// Token: 0x060062B3 RID: 25267 RVA: 0x000ED90F File Offset: 0x000EBB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x000ED91C File Offset: 0x000EBB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x000ED925 File Offset: 0x000EBB25
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

		// Token: 0x060062B6 RID: 25270 RVA: 0x000ED958 File Offset: 0x000EBB58
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

		// Token: 0x060062B7 RID: 25271 RVA: 0x000ED996 File Offset: 0x000EBB96
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

		// Token: 0x060062B8 RID: 25272 RVA: 0x000ED9C7 File Offset: 0x000EBBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x000ED9D0 File Offset: 0x000EBBD0
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

		// Token: 0x040037EA RID: 14314
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037EB RID: 14315
		public const int GetDoubleInstRwdCountFieldNumber = 1;

		// Token: 0x040037EC RID: 14316
		private int getDoubleInstRwdCount_;
	}
}
