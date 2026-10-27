using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006BB RID: 1723
	public sealed class GatherItemInfo : IMessage<GatherItemInfo>, IMessage, IEquatable<GatherItemInfo>, IDeepCloneable<GatherItemInfo>, IBufferMessage
	{
		// Token: 0x06009DCC RID: 40396 RVA: 0x0017F501 File Offset: 0x0017D701
		[NullableContext(1)]
		public static GatherItemInfo Create()
		{
			return new GatherItemInfo();
		}

		// Token: 0x17001FB6 RID: 8118
		// (get) Token: 0x06009DCD RID: 40397 RVA: 0x0017F508 File Offset: 0x0017D708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GatherItemInfo> Parser
		{
			get
			{
				return GatherItemInfo._parser;
			}
		}

		// Token: 0x17001FB7 RID: 8119
		// (get) Token: 0x06009DCE RID: 40398 RVA: 0x0017F50F File Offset: 0x0017D70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FB8 RID: 8120
		// (get) Token: 0x06009DCF RID: 40399 RVA: 0x0017F512 File Offset: 0x0017D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherItemInfo.Descriptor;
			}
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x0017F519 File Offset: 0x0017D719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo()
		{
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x0017F521 File Offset: 0x0017D721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo(GatherItemInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x0017F552 File Offset: 0x0017D752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherItemInfo Clone()
		{
			return new GatherItemInfo(this);
		}

		// Token: 0x17001FB9 RID: 8121
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x0017F55A File Offset: 0x0017D75A
		// (set) Token: 0x06009DD4 RID: 40404 RVA: 0x0017F562 File Offset: 0x0017D762
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

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x0017F56B File Offset: 0x0017D76B
		// (set) Token: 0x06009DD6 RID: 40406 RVA: 0x0017F573 File Offset: 0x0017D773
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

		// Token: 0x06009DD7 RID: 40407 RVA: 0x0017F57C File Offset: 0x0017D77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherItemInfo);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x0017F58A File Offset: 0x0017D78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherItemInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x0017F5C8 File Offset: 0x0017D7C8
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

		// Token: 0x06009DDA RID: 40410 RVA: 0x0017F620 File Offset: 0x0017D820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DDB RID: 40411 RVA: 0x0017F62D File Offset: 0x0017D82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x0017F638 File Offset: 0x0017D838
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

		// Token: 0x06009DDD RID: 40413 RVA: 0x0017F690 File Offset: 0x0017D890
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

		// Token: 0x06009DDE RID: 40414 RVA: 0x0017F6E8 File Offset: 0x0017D8E8
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

		// Token: 0x06009DDF RID: 40415 RVA: 0x0017F738 File Offset: 0x0017D938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0017F744 File Offset: 0x0017D944
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

		// Token: 0x04004A0A RID: 18954
		private static readonly MessageParser<GatherItemInfo> _parser = new MessageParser<GatherItemInfo>(() => new GatherItemInfo());

		// Token: 0x04004A0B RID: 18955
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A0C RID: 18956
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04004A0D RID: 18957
		private int itemId_;

		// Token: 0x04004A0E RID: 18958
		public const int ItemNumFieldNumber = 2;

		// Token: 0x04004A0F RID: 18959
		private int itemNum_;
	}
}
