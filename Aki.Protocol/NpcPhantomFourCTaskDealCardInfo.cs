using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B68 RID: 2920
	public sealed class NpcPhantomFourCTaskDealCardInfo : IMessage<NpcPhantomFourCTaskDealCardInfo>, IMessage, IEquatable<NpcPhantomFourCTaskDealCardInfo>, IDeepCloneable<NpcPhantomFourCTaskDealCardInfo>, IBufferMessage
	{
		// Token: 0x0600FD7A RID: 64890 RVA: 0x00250017 File Offset: 0x0024E217
		[NullableContext(1)]
		public static NpcPhantomFourCTaskDealCardInfo Create()
		{
			return new NpcPhantomFourCTaskDealCardInfo();
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600FD7B RID: 64891 RVA: 0x0025001E File Offset: 0x0024E21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600FD7C RID: 64892 RVA: 0x00250021 File Offset: 0x0024E221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomFourCTaskDealCardInfo.Descriptor;
			}
		}

		// Token: 0x0600FD7D RID: 64893 RVA: 0x00250028 File Offset: 0x0024E228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo()
		{
		}

		// Token: 0x0600FD7E RID: 64894 RVA: 0x00250030 File Offset: 0x0024E230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo(NpcPhantomFourCTaskDealCardInfo other) : this()
		{
			this.cardConf_ = other.cardConf_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD7F RID: 64895 RVA: 0x0025006D File Offset: 0x0024E26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo Clone()
		{
			return new NpcPhantomFourCTaskDealCardInfo(this);
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600FD80 RID: 64896 RVA: 0x00250075 File Offset: 0x0024E275
		// (set) Token: 0x0600FD81 RID: 64897 RVA: 0x0025007D File Offset: 0x0024E27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConf
		{
			get
			{
				return this.cardConf_;
			}
			set
			{
				this.cardConf_ = value;
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x0600FD82 RID: 64898 RVA: 0x00250086 File Offset: 0x0024E286
		// (set) Token: 0x0600FD83 RID: 64899 RVA: 0x0025008E File Offset: 0x0024E28E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x0600FD84 RID: 64900 RVA: 0x00250097 File Offset: 0x0024E297
		// (set) Token: 0x0600FD85 RID: 64901 RVA: 0x0025009F File Offset: 0x0024E29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FD86 RID: 64902 RVA: 0x002500A8 File Offset: 0x0024E2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomFourCTaskDealCardInfo);
		}

		// Token: 0x0600FD87 RID: 64903 RVA: 0x002500B8 File Offset: 0x0024E2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomFourCTaskDealCardInfo other)
		{
			return other != null && (other == this || (this.CardConf == other.CardConf && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD88 RID: 64904 RVA: 0x00250114 File Offset: 0x0024E314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardConf != 0)
			{
				num ^= this.CardConf.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD89 RID: 64905 RVA: 0x00250185 File Offset: 0x0024E385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD8A RID: 64906 RVA: 0x00250192 File Offset: 0x0024E392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD8B RID: 64907 RVA: 0x0025019C File Offset: 0x0024E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardConf != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardConf);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD8C RID: 64908 RVA: 0x00250210 File Offset: 0x0024E410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardConf != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConf);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD8D RID: 64909 RVA: 0x00250280 File Offset: 0x0024E480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomFourCTaskDealCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardConf != 0)
			{
				this.CardConf = other.CardConf;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD8E RID: 64910 RVA: 0x002502E4 File Offset: 0x0024E4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD8F RID: 64911 RVA: 0x002502F0 File Offset: 0x0024E4F0
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
							this.CurCardLibraryNum = input.ReadInt32();
						}
					}
					else
					{
						this.HandCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.CardConf = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006582 RID: 25986
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006583 RID: 25987
		public const int CardConfFieldNumber = 1;

		// Token: 0x04006584 RID: 25988
		private int cardConf_;

		// Token: 0x04006585 RID: 25989
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x04006586 RID: 25990
		private int handCardNum_;

		// Token: 0x04006587 RID: 25991
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x04006588 RID: 25992
		private int curCardLibraryNum_;
	}
}
