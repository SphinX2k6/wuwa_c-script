using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CA RID: 1226
	[NetMessage(EMessageId.ExchangeRewardInfoNotify)]
	public sealed class ExchangeRewardInfoNotify : IMessage<ExchangeRewardInfoNotify>, IMessage, IEquatable<ExchangeRewardInfoNotify>, IDeepCloneable<ExchangeRewardInfoNotify>, IBufferMessage
	{
		// Token: 0x060074D6 RID: 29910 RVA: 0x0011E72B File Offset: 0x0011C92B
		[NullableContext(1)]
		public static ExchangeRewardInfoNotify Create()
		{
			return new ExchangeRewardInfoNotify();
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x060074D7 RID: 29911 RVA: 0x0011E732 File Offset: 0x0011C932
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x0011E735 File Offset: 0x0011C935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeRewardInfoNotify.Descriptor;
			}
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x0011E73C File Offset: 0x0011C93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify()
		{
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0011E744 File Offset: 0x0011C944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify(ExchangeRewardInfoNotify other) : this()
		{
			this.exchangeRewardId_ = other.exchangeRewardId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x0011E775 File Offset: 0x0011C975
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeRewardInfoNotify Clone()
		{
			return new ExchangeRewardInfoNotify(this);
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x0011E77D File Offset: 0x0011C97D
		// (set) Token: 0x060074DD RID: 29917 RVA: 0x0011E785 File Offset: 0x0011C985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExchangeRewardId
		{
			get
			{
				return this.exchangeRewardId_;
			}
			set
			{
				this.exchangeRewardId_ = value;
			}
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x0011E78E File Offset: 0x0011C98E
		// (set) Token: 0x060074DF RID: 29919 RVA: 0x0011E796 File Offset: 0x0011C996
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

		// Token: 0x060074E0 RID: 29920 RVA: 0x0011E79F File Offset: 0x0011C99F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeRewardInfoNotify);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x0011E7AD File Offset: 0x0011C9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeRewardInfoNotify other)
		{
			return other != null && (other == this || (this.ExchangeRewardId == other.ExchangeRewardId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x0011E7EC File Offset: 0x0011C9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ExchangeRewardId != 0)
			{
				num ^= this.ExchangeRewardId.GetHashCode();
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

		// Token: 0x060074E3 RID: 29923 RVA: 0x0011E844 File Offset: 0x0011CA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x0011E851 File Offset: 0x0011CA51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x0011E85C File Offset: 0x0011CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Count);
			}
			if (this.ExchangeRewardId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ExchangeRewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x0011E8B8 File Offset: 0x0011CAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ExchangeRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExchangeRewardId);
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

		// Token: 0x060074E7 RID: 29927 RVA: 0x0011E910 File Offset: 0x0011CB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeRewardInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ExchangeRewardId != 0)
			{
				this.ExchangeRewardId = other.ExchangeRewardId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x0011E960 File Offset: 0x0011CB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x0011E96C File Offset: 0x0011CB6C
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ExchangeRewardId = input.ReadInt32();
					}
				}
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003DE0 RID: 15840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DE1 RID: 15841
		public const int ExchangeRewardIdFieldNumber = 13;

		// Token: 0x04003DE2 RID: 15842
		private int exchangeRewardId_;

		// Token: 0x04003DE3 RID: 15843
		public const int CountFieldNumber = 8;

		// Token: 0x04003DE4 RID: 15844
		private int count_;
	}
}
