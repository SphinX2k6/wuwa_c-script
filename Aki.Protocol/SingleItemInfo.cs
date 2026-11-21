using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126D RID: 4717
	public sealed class SingleItemInfo : IMessage<SingleItemInfo>, IMessage, IEquatable<SingleItemInfo>, IDeepCloneable<SingleItemInfo>, IBufferMessage
	{
		// Token: 0x060192EC RID: 103148 RVA: 0x003AC479 File Offset: 0x003AA679
		[NullableContext(1)]
		public static SingleItemInfo Create()
		{
			return new SingleItemInfo();
		}

		// Token: 0x17005523 RID: 21795
		// (get) Token: 0x060192ED RID: 103149 RVA: 0x003AC480 File Offset: 0x003AA680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SingleItemInfo> Parser
		{
			get
			{
				return SingleItemInfo._parser;
			}
		}

		// Token: 0x17005524 RID: 21796
		// (get) Token: 0x060192EE RID: 103150 RVA: 0x003AC487 File Offset: 0x003AA687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005525 RID: 21797
		// (get) Token: 0x060192EF RID: 103151 RVA: 0x003AC48A File Offset: 0x003AA68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SingleItemInfo.Descriptor;
			}
		}

		// Token: 0x060192F0 RID: 103152 RVA: 0x003AC491 File Offset: 0x003AA691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo()
		{
		}

		// Token: 0x060192F1 RID: 103153 RVA: 0x003AC499 File Offset: 0x003AA699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo(SingleItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060192F2 RID: 103154 RVA: 0x003AC4CA File Offset: 0x003AA6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SingleItemInfo Clone()
		{
			return new SingleItemInfo(this);
		}

		// Token: 0x17005526 RID: 21798
		// (get) Token: 0x060192F3 RID: 103155 RVA: 0x003AC4D2 File Offset: 0x003AA6D2
		// (set) Token: 0x060192F4 RID: 103156 RVA: 0x003AC4DA File Offset: 0x003AA6DA
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

		// Token: 0x17005527 RID: 21799
		// (get) Token: 0x060192F5 RID: 103157 RVA: 0x003AC4E3 File Offset: 0x003AA6E3
		// (set) Token: 0x060192F6 RID: 103158 RVA: 0x003AC4EB File Offset: 0x003AA6EB
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

		// Token: 0x060192F7 RID: 103159 RVA: 0x003AC4F4 File Offset: 0x003AA6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SingleItemInfo);
		}

		// Token: 0x060192F8 RID: 103160 RVA: 0x003AC502 File Offset: 0x003AA702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SingleItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060192F9 RID: 103161 RVA: 0x003AC540 File Offset: 0x003AA740
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

		// Token: 0x060192FA RID: 103162 RVA: 0x003AC598 File Offset: 0x003AA798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060192FB RID: 103163 RVA: 0x003AC5A5 File Offset: 0x003AA7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060192FC RID: 103164 RVA: 0x003AC5B0 File Offset: 0x003AA7B0
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

		// Token: 0x060192FD RID: 103165 RVA: 0x003AC608 File Offset: 0x003AA808
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

		// Token: 0x060192FE RID: 103166 RVA: 0x003AC660 File Offset: 0x003AA860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SingleItemInfo other)
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

		// Token: 0x060192FF RID: 103167 RVA: 0x003AC6B0 File Offset: 0x003AA8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019300 RID: 103168 RVA: 0x003AC6BC File Offset: 0x003AA8BC
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

		// Token: 0x04009513 RID: 38163
		private static readonly MessageParser<SingleItemInfo> _parser = new MessageParser<SingleItemInfo>(() => new SingleItemInfo());

		// Token: 0x04009514 RID: 38164
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009515 RID: 38165
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04009516 RID: 38166
		private int itemId_;

		// Token: 0x04009517 RID: 38167
		public const int ItemNumFieldNumber = 2;

		// Token: 0x04009518 RID: 38168
		private int itemNum_;
	}
}
