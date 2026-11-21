using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A7 RID: 1703
	public sealed class GatherItemInfo : IMessage<GatherItemInfo>, IMessage, IEquatable<GatherItemInfo>, IDeepCloneable<GatherItemInfo>, IBufferMessage
	{
		// Token: 0x06009C76 RID: 40054 RVA: 0x0017CAD1 File Offset: 0x0017ACD1
		[NullableContext(1)]
		public static GatherItemInfo Create()
		{
			return new GatherItemInfo();
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06009C77 RID: 40055 RVA: 0x0017CAD8 File Offset: 0x0017ACD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherItemInfo> Parser
		{
			get
			{
				return GatherItemInfo._parser;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06009C78 RID: 40056 RVA: 0x0017CADF File Offset: 0x0017ACDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06009C79 RID: 40057 RVA: 0x0017CAE2 File Offset: 0x0017ACE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherItemInfo.Descriptor;
			}
		}

		// Token: 0x06009C7A RID: 40058 RVA: 0x0017CAE9 File Offset: 0x0017ACE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo()
		{
		}

		// Token: 0x06009C7B RID: 40059 RVA: 0x0017CAF1 File Offset: 0x0017ACF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo(GatherItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C7C RID: 40060 RVA: 0x0017CB22 File Offset: 0x0017AD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo Clone()
		{
			return new GatherItemInfo(this);
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x06009C7D RID: 40061 RVA: 0x0017CB2A File Offset: 0x0017AD2A
		// (set) Token: 0x06009C7E RID: 40062 RVA: 0x0017CB32 File Offset: 0x0017AD32
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

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x06009C7F RID: 40063 RVA: 0x0017CB3B File Offset: 0x0017AD3B
		// (set) Token: 0x06009C80 RID: 40064 RVA: 0x0017CB43 File Offset: 0x0017AD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemNum
		{
			get
			{
				return this.itemNum_;
			}
			set
			{
				this.itemNum_ = value;
			}
		}

		// Token: 0x06009C81 RID: 40065 RVA: 0x0017CB4C File Offset: 0x0017AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherItemInfo);
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x0017CB5A File Offset: 0x0017AD5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x0017CB98 File Offset: 0x0017AD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemNum != 0)
			{
				num ^= this.ItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x0017CBF0 File Offset: 0x0017ADF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x0017CBFD File Offset: 0x0017ADFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x0017CC08 File Offset: 0x0017AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x0017CC60 File Offset: 0x0017AE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x0017CCB8 File Offset: 0x0017AEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemNum != 0)
			{
				this.ItemNum = other.ItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x0017CD08 File Offset: 0x0017AF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x0017CD14 File Offset: 0x0017AF14
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
						this.ItemNum = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A03 RID: 18947
		private static readonly MessageParser<GatherItemInfo> _parser = new MessageParser<GatherItemInfo>(() => new GatherItemInfo());

		// Token: 0x04004A04 RID: 18948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A05 RID: 18949
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004A06 RID: 18950
		private int itemId_;

		// Token: 0x04004A07 RID: 18951
		public const int ItemNumFieldNumber = 2;

		// Token: 0x04004A08 RID: 18952
		private int itemNum_;
	}
}
