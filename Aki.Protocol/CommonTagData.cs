using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C4 RID: 708
	public sealed class CommonTagData : IMessage<CommonTagData>, IMessage, IEquatable<CommonTagData>, IDeepCloneable<CommonTagData>, IBufferMessage
	{
		// Token: 0x0600491F RID: 18719 RVA: 0x000B37B3 File Offset: 0x000B19B3
		[NullableContext(1)]
		public static CommonTagData Create()
		{
			return new CommonTagData();
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x000B37BA File Offset: 0x000B19BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonTagData> Parser
		{
			get
			{
				return CommonTagData._parser;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06004921 RID: 18721 RVA: 0x000B37C1 File Offset: 0x000B19C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06004922 RID: 18722 RVA: 0x000B37C4 File Offset: 0x000B19C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTagData.Descriptor;
			}
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x000B37CB File Offset: 0x000B19CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData()
		{
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x000B37D3 File Offset: 0x000B19D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData(CommonTagData other) : this()
		{
			this.tagId_ = other.tagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x000B3804 File Offset: 0x000B1A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData Clone()
		{
			return new CommonTagData(this);
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x000B380C File Offset: 0x000B1A0C
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x000B3814 File Offset: 0x000B1A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x000B381D File Offset: 0x000B1A1D
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x000B3825 File Offset: 0x000B1A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x000B382E File Offset: 0x000B1A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTagData);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x000B383C File Offset: 0x000B1A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTagData other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x000B387C File Offset: 0x000B1A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x000B38D4 File Offset: 0x000B1AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x000B38E1 File Offset: 0x000B1AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x000B38EC File Offset: 0x000B1AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TagId);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x000B3944 File Offset: 0x000B1B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x000B3990 File Offset: 0x000B1B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CommonTagData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x000B39E0 File Offset: 0x000B1BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004933 RID: 18739 RVA: 0x000B39EC File Offset: 0x000B1BEC
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
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					this.TagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400306F RID: 12399
		private static readonly MessageParser<CommonTagData> _parser = new MessageParser<CommonTagData>(() => new CommonTagData());

		// Token: 0x04003070 RID: 12400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003071 RID: 12401
		public const int TagIdFieldNumber = 1;

		// Token: 0x04003072 RID: 12402
		private int tagId_;

		// Token: 0x04003073 RID: 12403
		public const int IsAddFieldNumber = 2;

		// Token: 0x04003074 RID: 12404
		private bool isAdd_;
	}
}
