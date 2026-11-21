using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000BC RID: 188
	public sealed class AdventureItemData : IMessage<AdventureItemData>, IMessage, IEquatable<AdventureItemData>, IDeepCloneable<AdventureItemData>, IBufferMessage
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00053970 File Offset: 0x00051B70
		[NullableContext(1)]
		public static AdventureItemData Create()
		{
			return new AdventureItemData();
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x00053977 File Offset: 0x00051B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureItemData> Parser
		{
			get
			{
				return AdventureItemData._parser;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0005397E File Offset: 0x00051B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00053981 File Offset: 0x00051B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureItemData.Descriptor;
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00053988 File Offset: 0x00051B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData()
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00053990 File Offset: 0x00051B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData(AdventureItemData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemNum_ = other.itemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000539C1 File Offset: 0x00051BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureItemData Clone()
		{
			return new AdventureItemData(this);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x000539C9 File Offset: 0x00051BC9
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x000539D1 File Offset: 0x00051BD1
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

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x000539DA File Offset: 0x00051BDA
		// (set) Token: 0x06001EA8 RID: 7848 RVA: 0x000539E2 File Offset: 0x00051BE2
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

		// Token: 0x06001EA9 RID: 7849 RVA: 0x000539EB File Offset: 0x00051BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureItemData);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000539F9 File Offset: 0x00051BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureItemData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemNum == other.ItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00053A38 File Offset: 0x00051C38
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

		// Token: 0x06001EAC RID: 7852 RVA: 0x00053A90 File Offset: 0x00051C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00053A9D File Offset: 0x00051C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00053AA8 File Offset: 0x00051CA8
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

		// Token: 0x06001EAF RID: 7855 RVA: 0x00053B00 File Offset: 0x00051D00
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

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00053B58 File Offset: 0x00051D58
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

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00053BA8 File Offset: 0x00051DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00053BB4 File Offset: 0x00051DB4
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

		// Token: 0x040023B8 RID: 9144
		private static readonly MessageParser<AdventureItemData> _parser = new MessageParser<AdventureItemData>(() => new AdventureItemData());

		// Token: 0x040023B9 RID: 9145
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023BA RID: 9146
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040023BB RID: 9147
		private int itemId_;

		// Token: 0x040023BC RID: 9148
		public const int ItemNumFieldNumber = 2;

		// Token: 0x040023BD RID: 9149
		private int itemNum_;
	}
}
