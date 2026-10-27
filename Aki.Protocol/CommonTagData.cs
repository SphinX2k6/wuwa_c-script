using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002BE RID: 702
	public sealed class CommonTagData : IMessage<CommonTagData>, IMessage, IEquatable<CommonTagData>, IDeepCloneable<CommonTagData>, IBufferMessage
	{
		// Token: 0x06004858 RID: 18520 RVA: 0x000B15AB File Offset: 0x000AF7AB
		[NullableContext(1)]
		public static CommonTagData Create()
		{
			return new CommonTagData();
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06004859 RID: 18521 RVA: 0x000B15B2 File Offset: 0x000AF7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CommonTagData> Parser
		{
			get
			{
				return CommonTagData._parser;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x000B15B9 File Offset: 0x000AF7B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x000B15BC File Offset: 0x000AF7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CommonTagData.Descriptor;
			}
		}

		// Token: 0x0600485C RID: 18524 RVA: 0x000B15C3 File Offset: 0x000AF7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData()
		{
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x000B15CB File Offset: 0x000AF7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData(CommonTagData other) : this()
		{
			this.tagId_ = other.tagId_;
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600485E RID: 18526 RVA: 0x000B15FC File Offset: 0x000AF7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CommonTagData Clone()
		{
			return new CommonTagData(this);
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x000B1604 File Offset: 0x000AF804
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x000B160C File Offset: 0x000AF80C
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x000B1615 File Offset: 0x000AF815
		// (set) Token: 0x06004862 RID: 18530 RVA: 0x000B161D File Offset: 0x000AF81D
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

		// Token: 0x06004863 RID: 18531 RVA: 0x000B1626 File Offset: 0x000AF826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CommonTagData);
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x000B1634 File Offset: 0x000AF834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CommonTagData other)
		{
			return other != null && (other == this || (this.TagId == other.TagId && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x000B1674 File Offset: 0x000AF874
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

		// Token: 0x06004866 RID: 18534 RVA: 0x000B16CC File Offset: 0x000AF8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x000B16D9 File Offset: 0x000AF8D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x000B16E4 File Offset: 0x000AF8E4
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

		// Token: 0x06004869 RID: 18537 RVA: 0x000B173C File Offset: 0x000AF93C
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

		// Token: 0x0600486A RID: 18538 RVA: 0x000B1788 File Offset: 0x000AF988
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

		// Token: 0x0600486B RID: 18539 RVA: 0x000B17D8 File Offset: 0x000AF9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x000B17E4 File Offset: 0x000AF9E4
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

		// Token: 0x04002FDC RID: 12252
		private static readonly MessageParser<CommonTagData> _parser = new MessageParser<CommonTagData>(() => new CommonTagData());

		// Token: 0x04002FDD RID: 12253
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FDE RID: 12254
		public const int TagIdFieldNumber = 1;

		// Token: 0x04002FDF RID: 12255
		private int tagId_;

		// Token: 0x04002FE0 RID: 12256
		public const int IsAddFieldNumber = 2;

		// Token: 0x04002FE1 RID: 12257
		private bool isAdd_;
	}
}
