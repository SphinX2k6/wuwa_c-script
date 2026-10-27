using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BB RID: 187
	public sealed class AdventureItemData : IMessage<AdventureItemData>, IMessage, IEquatable<AdventureItemData>, IDeepCloneable<AdventureItemData>, IBufferMessage
	{
		// Token: 0x06001E55 RID: 7765 RVA: 0x00052CBC File Offset: 0x00050EBC
		[NullableContext(1)]
		public static AdventureItemData Create()
		{
			return new AdventureItemData();
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00052CC3 File Offset: 0x00050EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureItemData> Parser
		{
			get
			{
				return AdventureItemData._parser;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x00052CCA File Offset: 0x00050ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00052CCD File Offset: 0x00050ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureItemData.Descriptor;
			}
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00052CD4 File Offset: 0x00050ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData()
		{
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00052CDC File Offset: 0x00050EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData(AdventureItemData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00052D0D File Offset: 0x00050F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData Clone()
		{
			return new AdventureItemData(this);
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00052D15 File Offset: 0x00050F15
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00052D1D File Offset: 0x00050F1D
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00052D26 File Offset: 0x00050F26
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x00052D2E File Offset: 0x00050F2E
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

		// Token: 0x06001E60 RID: 7776 RVA: 0x00052D37 File Offset: 0x00050F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureItemData);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00052D45 File Offset: 0x00050F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureItemData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00052D84 File Offset: 0x00050F84
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

		// Token: 0x06001E63 RID: 7779 RVA: 0x00052DDC File Offset: 0x00050FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00052DE9 File Offset: 0x00050FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00052DF4 File Offset: 0x00050FF4
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

		// Token: 0x06001E66 RID: 7782 RVA: 0x00052E4C File Offset: 0x0005104C
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

		// Token: 0x06001E67 RID: 7783 RVA: 0x00052EA4 File Offset: 0x000510A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureItemData other)
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

		// Token: 0x06001E68 RID: 7784 RVA: 0x00052EF4 File Offset: 0x000510F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00052F00 File Offset: 0x00051100
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

		// Token: 0x04002355 RID: 9045
		private static readonly MessageParser<AdventureItemData> _parser = new MessageParser<AdventureItemData>(() => new AdventureItemData());

		// Token: 0x04002356 RID: 9046
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002357 RID: 9047
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04002358 RID: 9048
		private int itemId_;

		// Token: 0x04002359 RID: 9049
		public const int ItemNumFieldNumber = 2;

		// Token: 0x0400235A RID: 9050
		private int itemNum_;
	}
}
