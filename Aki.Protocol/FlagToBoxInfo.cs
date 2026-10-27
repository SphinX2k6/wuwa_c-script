using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A3 RID: 1443
	public sealed class FlagToBoxInfo : IMessage<FlagToBoxInfo>, IMessage, IEquatable<FlagToBoxInfo>, IDeepCloneable<FlagToBoxInfo>, IBufferMessage
	{
		// Token: 0x06008573 RID: 34163 RVA: 0x00140C61 File Offset: 0x0013EE61
		[NullableContext(1)]
		public static FlagToBoxInfo Create()
		{
			return new FlagToBoxInfo();
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06008574 RID: 34164 RVA: 0x00140C68 File Offset: 0x0013EE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FlagToBoxInfo> Parser
		{
			get
			{
				return FlagToBoxInfo._parser;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x00140C6F File Offset: 0x0013EE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06008576 RID: 34166 RVA: 0x00140C72 File Offset: 0x0013EE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagToBoxInfo.Descriptor;
			}
		}

		// Token: 0x06008577 RID: 34167 RVA: 0x00140C79 File Offset: 0x0013EE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo()
		{
		}

		// Token: 0x06008578 RID: 34168 RVA: 0x00140C81 File Offset: 0x0013EE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo(FlagToBoxInfo other) : this()
		{
			this.flagId_ = other.flagId_;
			this.boxGetCount_ = other.boxGetCount_;
			this.totalCount_ = other.totalCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008579 RID: 34169 RVA: 0x00140CBE File Offset: 0x0013EEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagToBoxInfo Clone()
		{
			return new FlagToBoxInfo(this);
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x00140CC6 File Offset: 0x0013EEC6
		// (set) Token: 0x0600857B RID: 34171 RVA: 0x00140CCE File Offset: 0x0013EECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlagId
		{
			get
			{
				return this.flagId_;
			}
			set
			{
				this.flagId_ = value;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x0600857C RID: 34172 RVA: 0x00140CD7 File Offset: 0x0013EED7
		// (set) Token: 0x0600857D RID: 34173 RVA: 0x00140CDF File Offset: 0x0013EEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxGetCount
		{
			get
			{
				return this.boxGetCount_;
			}
			set
			{
				this.boxGetCount_ = value;
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x0600857E RID: 34174 RVA: 0x00140CE8 File Offset: 0x0013EEE8
		// (set) Token: 0x0600857F RID: 34175 RVA: 0x00140CF0 File Offset: 0x0013EEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalCount
		{
			get
			{
				return this.totalCount_;
			}
			set
			{
				this.totalCount_ = value;
			}
		}

		// Token: 0x06008580 RID: 34176 RVA: 0x00140CF9 File Offset: 0x0013EEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagToBoxInfo);
		}

		// Token: 0x06008581 RID: 34177 RVA: 0x00140D08 File Offset: 0x0013EF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagToBoxInfo other)
		{
			return other != null && (other == this || (this.FlagId == other.FlagId && this.BoxGetCount == other.BoxGetCount && this.TotalCount == other.TotalCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008582 RID: 34178 RVA: 0x00140D64 File Offset: 0x0013EF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlagId != 0)
			{
				num ^= this.FlagId.GetHashCode();
			}
			if (this.BoxGetCount != 0)
			{
				num ^= this.BoxGetCount.GetHashCode();
			}
			if (this.TotalCount != 0)
			{
				num ^= this.TotalCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008583 RID: 34179 RVA: 0x00140DD5 File Offset: 0x0013EFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008584 RID: 34180 RVA: 0x00140DE2 File Offset: 0x0013EFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008585 RID: 34181 RVA: 0x00140DEC File Offset: 0x0013EFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlagId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FlagId);
			}
			if (this.BoxGetCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BoxGetCount);
			}
			if (this.TotalCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008586 RID: 34182 RVA: 0x00140E60 File Offset: 0x0013F060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlagId);
			}
			if (this.BoxGetCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxGetCount);
			}
			if (this.TotalCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008587 RID: 34183 RVA: 0x00140ED0 File Offset: 0x0013F0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagToBoxInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlagId != 0)
			{
				this.FlagId = other.FlagId;
			}
			if (other.BoxGetCount != 0)
			{
				this.BoxGetCount = other.BoxGetCount;
			}
			if (other.TotalCount != 0)
			{
				this.TotalCount = other.TotalCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008588 RID: 34184 RVA: 0x00140F34 File Offset: 0x0013F134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008589 RID: 34185 RVA: 0x00140F40 File Offset: 0x0013F140
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TotalCount = input.ReadInt32();
						}
					}
					else
					{
						this.BoxGetCount = input.ReadInt32();
					}
				}
				else
				{
					this.FlagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041FC RID: 16892
		private static readonly MessageParser<FlagToBoxInfo> _parser = new MessageParser<FlagToBoxInfo>(() => new FlagToBoxInfo());

		// Token: 0x040041FD RID: 16893
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041FE RID: 16894
		public const int FlagIdFieldNumber = 1;

		// Token: 0x040041FF RID: 16895
		private int flagId_;

		// Token: 0x04004200 RID: 16896
		public const int BoxGetCountFieldNumber = 2;

		// Token: 0x04004201 RID: 16897
		private int boxGetCount_;

		// Token: 0x04004202 RID: 16898
		public const int TotalCountFieldNumber = 3;

		// Token: 0x04004203 RID: 16899
		private int totalCount_;
	}
}
