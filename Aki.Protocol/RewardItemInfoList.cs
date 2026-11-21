using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F25 RID: 3877
	public sealed class RewardItemInfoList : IMessage<RewardItemInfoList>, IMessage, IEquatable<RewardItemInfoList>, IDeepCloneable<RewardItemInfoList>, IBufferMessage
	{
		// Token: 0x06014C71 RID: 85105 RVA: 0x00304668 File Offset: 0x00302868
		[NullableContext(1)]
		public static RewardItemInfoList Create()
		{
			return new RewardItemInfoList();
		}

		// Token: 0x1700451A RID: 17690
		// (get) Token: 0x06014C72 RID: 85106 RVA: 0x0030466F File Offset: 0x0030286F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RewardItemInfoList> Parser
		{
			get
			{
				return RewardItemInfoList._parser;
			}
		}

		// Token: 0x1700451B RID: 17691
		// (get) Token: 0x06014C73 RID: 85107 RVA: 0x00304676 File Offset: 0x00302876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700451C RID: 17692
		// (get) Token: 0x06014C74 RID: 85108 RVA: 0x00304679 File Offset: 0x00302879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RewardItemInfoList.Descriptor;
			}
		}

		// Token: 0x06014C75 RID: 85109 RVA: 0x00304680 File Offset: 0x00302880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList()
		{
		}

		// Token: 0x06014C76 RID: 85110 RVA: 0x00304693 File Offset: 0x00302893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList(RewardItemInfoList other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014C77 RID: 85111 RVA: 0x003046BD File Offset: 0x003028BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RewardItemInfoList Clone()
		{
			return new RewardItemInfoList(this);
		}

		// Token: 0x1700451D RID: 17693
		// (get) Token: 0x06014C78 RID: 85112 RVA: 0x003046C5 File Offset: 0x003028C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RewardItemInfo> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x06014C79 RID: 85113 RVA: 0x003046CD File Offset: 0x003028CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RewardItemInfoList);
		}

		// Token: 0x06014C7A RID: 85114 RVA: 0x003046DB File Offset: 0x003028DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RewardItemInfoList other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014C7B RID: 85115 RVA: 0x00304710 File Offset: 0x00302910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014C7C RID: 85116 RVA: 0x00304744 File Offset: 0x00302944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014C7D RID: 85117 RVA: 0x00304751 File Offset: 0x00302951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014C7E RID: 85118 RVA: 0x0030475A File Offset: 0x0030295A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, RewardItemInfoList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014C7F RID: 85119 RVA: 0x00304784 File Offset: 0x00302984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(RewardItemInfoList._repeated_itemList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014C80 RID: 85120 RVA: 0x003047BD File Offset: 0x003029BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RewardItemInfoList other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014C81 RID: 85121 RVA: 0x003047EB File Offset: 0x003029EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014C82 RID: 85122 RVA: 0x003047F4 File Offset: 0x003029F4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.itemList_.AddEntriesFrom(ref input, RewardItemInfoList._repeated_itemList_codec);
				}
			}
		}

		// Token: 0x04007DE3 RID: 32227
		private static readonly MessageParser<RewardItemInfoList> _parser = new MessageParser<RewardItemInfoList>(() => new RewardItemInfoList());

		// Token: 0x04007DE4 RID: 32228
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007DE5 RID: 32229
		public const int ItemListFieldNumber = 1;

		// Token: 0x04007DE6 RID: 32230
		private static readonly FieldCodec<RewardItemInfo> _repeated_itemList_codec = FieldCodec.ForMessage<RewardItemInfo>(10U, RewardItemInfo.Parser);

		// Token: 0x04007DE7 RID: 32231
		private readonly RepeatedField<RewardItemInfo> itemList_ = new RepeatedField<RewardItemInfo>();
	}
}
