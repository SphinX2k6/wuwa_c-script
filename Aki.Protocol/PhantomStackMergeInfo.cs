using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0A RID: 3338
	public sealed class PhantomStackMergeInfo : IMessage<PhantomStackMergeInfo>, IMessage, IEquatable<PhantomStackMergeInfo>, IDeepCloneable<PhantomStackMergeInfo>, IBufferMessage
	{
		// Token: 0x0601209B RID: 73883 RVA: 0x002A2E67 File Offset: 0x002A1067
		[NullableContext(1)]
		public static PhantomStackMergeInfo Create()
		{
			return new PhantomStackMergeInfo();
		}

		// Token: 0x17003BC3 RID: 15299
		// (get) Token: 0x0601209C RID: 73884 RVA: 0x002A2E6E File Offset: 0x002A106E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackMergeInfo> Parser
		{
			get
			{
				return PhantomStackMergeInfo._parser;
			}
		}

		// Token: 0x17003BC4 RID: 15300
		// (get) Token: 0x0601209D RID: 73885 RVA: 0x002A2E75 File Offset: 0x002A1075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BC5 RID: 15301
		// (get) Token: 0x0601209E RID: 73886 RVA: 0x002A2E78 File Offset: 0x002A1078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackMergeInfo.Descriptor;
			}
		}

		// Token: 0x0601209F RID: 73887 RVA: 0x002A2E7F File Offset: 0x002A107F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo()
		{
		}

		// Token: 0x060120A0 RID: 73888 RVA: 0x002A2E88 File Offset: 0x002A1088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo(PhantomStackMergeInfo other) : this()
		{
			this.mergedIncrId_ = other.mergedIncrId_;
			this.representativeItem_ = ((other.representativeItem_ != null) ? other.representativeItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120A1 RID: 73889 RVA: 0x002A2ED4 File Offset: 0x002A10D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackMergeInfo Clone()
		{
			return new PhantomStackMergeInfo(this);
		}

		// Token: 0x17003BC6 RID: 15302
		// (get) Token: 0x060120A2 RID: 73890 RVA: 0x002A2EDC File Offset: 0x002A10DC
		// (set) Token: 0x060120A3 RID: 73891 RVA: 0x002A2EE4 File Offset: 0x002A10E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MergedIncrId
		{
			get
			{
				return this.mergedIncrId_;
			}
			set
			{
				this.mergedIncrId_ = value;
			}
		}

		// Token: 0x17003BC7 RID: 15303
		// (get) Token: 0x060120A4 RID: 73892 RVA: 0x002A2EED File Offset: 0x002A10ED
		// (set) Token: 0x060120A5 RID: 73893 RVA: 0x002A2EF5 File Offset: 0x002A10F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem RepresentativeItem
		{
			get
			{
				return this.representativeItem_;
			}
			set
			{
				this.representativeItem_ = value;
			}
		}

		// Token: 0x060120A6 RID: 73894 RVA: 0x002A2EFE File Offset: 0x002A10FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackMergeInfo);
		}

		// Token: 0x060120A7 RID: 73895 RVA: 0x002A2F0C File Offset: 0x002A110C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackMergeInfo other)
		{
			return other != null && (other == this || (this.MergedIncrId == other.MergedIncrId && object.Equals(this.RepresentativeItem, other.RepresentativeItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120A8 RID: 73896 RVA: 0x002A2F5C File Offset: 0x002A115C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MergedIncrId != 0)
			{
				num ^= this.MergedIncrId.GetHashCode();
			}
			if (this.representativeItem_ != null)
			{
				num ^= this.RepresentativeItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120A9 RID: 73897 RVA: 0x002A2FB1 File Offset: 0x002A11B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120AA RID: 73898 RVA: 0x002A2FBE File Offset: 0x002A11BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120AB RID: 73899 RVA: 0x002A2FC8 File Offset: 0x002A11C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MergedIncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MergedIncrId);
			}
			if (this.representativeItem_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RepresentativeItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120AC RID: 73900 RVA: 0x002A3020 File Offset: 0x002A1220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MergedIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MergedIncrId);
			}
			if (this.representativeItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RepresentativeItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120AD RID: 73901 RVA: 0x002A3078 File Offset: 0x002A1278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomStackMergeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MergedIncrId != 0)
			{
				this.MergedIncrId = other.MergedIncrId;
			}
			if (other.representativeItem_ != null)
			{
				if (this.representativeItem_ == null)
				{
					this.RepresentativeItem = new PhantomItem();
				}
				this.RepresentativeItem.MergeFrom(other.RepresentativeItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120AE RID: 73902 RVA: 0x002A30E0 File Offset: 0x002A12E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120AF RID: 73903 RVA: 0x002A30EC File Offset: 0x002A12EC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.representativeItem_ == null)
						{
							this.RepresentativeItem = new PhantomItem();
						}
						input.ReadMessage(this.RepresentativeItem);
					}
				}
				else
				{
					this.MergedIncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040070EC RID: 28908
		private static readonly MessageParser<PhantomStackMergeInfo> _parser = new MessageParser<PhantomStackMergeInfo>(() => new PhantomStackMergeInfo());

		// Token: 0x040070ED RID: 28909
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070EE RID: 28910
		public const int MergedIncrIdFieldNumber = 1;

		// Token: 0x040070EF RID: 28911
		private int mergedIncrId_;

		// Token: 0x040070F0 RID: 28912
		public const int RepresentativeItemFieldNumber = 2;

		// Token: 0x040070F1 RID: 28913
		private PhantomItem representativeItem_;
	}
}
