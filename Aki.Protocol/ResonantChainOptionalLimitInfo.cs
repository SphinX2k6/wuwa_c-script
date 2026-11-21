using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F18 RID: 3864
	public sealed class ResonantChainOptionalLimitInfo : IMessage<ResonantChainOptionalLimitInfo>, IMessage, IEquatable<ResonantChainOptionalLimitInfo>, IDeepCloneable<ResonantChainOptionalLimitInfo>, IBufferMessage
	{
		// Token: 0x06014B4D RID: 84813 RVA: 0x00301C79 File Offset: 0x002FFE79
		[NullableContext(1)]
		public static ResonantChainOptionalLimitInfo Create()
		{
			return new ResonantChainOptionalLimitInfo();
		}

		// Token: 0x170044D6 RID: 17622
		// (get) Token: 0x06014B4E RID: 84814 RVA: 0x00301C80 File Offset: 0x002FFE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ResonantChainOptionalLimitInfo> Parser
		{
			get
			{
				return ResonantChainOptionalLimitInfo._parser;
			}
		}

		// Token: 0x170044D7 RID: 17623
		// (get) Token: 0x06014B4F RID: 84815 RVA: 0x00301C87 File Offset: 0x002FFE87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044D8 RID: 17624
		// (get) Token: 0x06014B50 RID: 84816 RVA: 0x00301C8A File Offset: 0x002FFE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResonantChainOptionalLimitInfo.Descriptor;
			}
		}

		// Token: 0x06014B51 RID: 84817 RVA: 0x00301C91 File Offset: 0x002FFE91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo()
		{
		}

		// Token: 0x06014B52 RID: 84818 RVA: 0x00301C99 File Offset: 0x002FFE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo(ResonantChainOptionalLimitInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B53 RID: 84819 RVA: 0x00301CCA File Offset: 0x002FFECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResonantChainOptionalLimitInfo Clone()
		{
			return new ResonantChainOptionalLimitInfo(this);
		}

		// Token: 0x170044D9 RID: 17625
		// (get) Token: 0x06014B54 RID: 84820 RVA: 0x00301CD2 File Offset: 0x002FFED2
		// (set) Token: 0x06014B55 RID: 84821 RVA: 0x00301CDA File Offset: 0x002FFEDA
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

		// Token: 0x170044DA RID: 17626
		// (get) Token: 0x06014B56 RID: 84822 RVA: 0x00301CE3 File Offset: 0x002FFEE3
		// (set) Token: 0x06014B57 RID: 84823 RVA: 0x00301CEB File Offset: 0x002FFEEB
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

		// Token: 0x06014B58 RID: 84824 RVA: 0x00301CF4 File Offset: 0x002FFEF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResonantChainOptionalLimitInfo);
		}

		// Token: 0x06014B59 RID: 84825 RVA: 0x00301D02 File Offset: 0x002FFF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResonantChainOptionalLimitInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B5A RID: 84826 RVA: 0x00301D40 File Offset: 0x002FFF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
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

		// Token: 0x06014B5B RID: 84827 RVA: 0x00301D98 File Offset: 0x002FFF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B5C RID: 84828 RVA: 0x00301DA5 File Offset: 0x002FFFA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B5D RID: 84829 RVA: 0x00301DB0 File Offset: 0x002FFFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
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

		// Token: 0x06014B5E RID: 84830 RVA: 0x00301E08 File Offset: 0x00300008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
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

		// Token: 0x06014B5F RID: 84831 RVA: 0x00301E60 File Offset: 0x00300060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResonantChainOptionalLimitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B60 RID: 84832 RVA: 0x00301EB0 File Offset: 0x003000B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B61 RID: 84833 RVA: 0x00301EBC File Offset: 0x003000BC
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
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D84 RID: 32132
		private static readonly MessageParser<ResonantChainOptionalLimitInfo> _parser = new MessageParser<ResonantChainOptionalLimitInfo>(() => new ResonantChainOptionalLimitInfo());

		// Token: 0x04007D85 RID: 32133
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D86 RID: 32134
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04007D87 RID: 32135
		private int itemId_;

		// Token: 0x04007D88 RID: 32136
		public const int CountFieldNumber = 2;

		// Token: 0x04007D89 RID: 32137
		private int count_;
	}
}
