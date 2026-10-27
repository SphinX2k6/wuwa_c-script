using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B78 RID: 2936
	public sealed class NpcPhantomFourCTaskDealCardInfo : IMessage<NpcPhantomFourCTaskDealCardInfo>, IMessage, IEquatable<NpcPhantomFourCTaskDealCardInfo>, IDeepCloneable<NpcPhantomFourCTaskDealCardInfo>, IBufferMessage
	{
		// Token: 0x0600FE7E RID: 65150 RVA: 0x00251EE7 File Offset: 0x002500E7
		[NullableContext(1)]
		public static NpcPhantomFourCTaskDealCardInfo Create()
		{
			return new NpcPhantomFourCTaskDealCardInfo();
		}

		// Token: 0x170033F4 RID: 13300
		// (get) Token: 0x0600FE7F RID: 65151 RVA: 0x00251EEE File Offset: 0x002500EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033F5 RID: 13301
		// (get) Token: 0x0600FE80 RID: 65152 RVA: 0x00251EF1 File Offset: 0x002500F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomFourCTaskDealCardInfo.Descriptor;
			}
		}

		// Token: 0x0600FE81 RID: 65153 RVA: 0x00251EF8 File Offset: 0x002500F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo()
		{
		}

		// Token: 0x0600FE82 RID: 65154 RVA: 0x00251F00 File Offset: 0x00250100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo(NpcPhantomFourCTaskDealCardInfo other) : this()
		{
			this.cardConf_ = other.cardConf_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FE83 RID: 65155 RVA: 0x00251F3D File Offset: 0x0025013D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomFourCTaskDealCardInfo Clone()
		{
			return new NpcPhantomFourCTaskDealCardInfo(this);
		}

		// Token: 0x170033F6 RID: 13302
		// (get) Token: 0x0600FE84 RID: 65156 RVA: 0x00251F45 File Offset: 0x00250145
		// (set) Token: 0x0600FE85 RID: 65157 RVA: 0x00251F4D File Offset: 0x0025014D
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

		// Token: 0x170033F7 RID: 13303
		// (get) Token: 0x0600FE86 RID: 65158 RVA: 0x00251F56 File Offset: 0x00250156
		// (set) Token: 0x0600FE87 RID: 65159 RVA: 0x00251F5E File Offset: 0x0025015E
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

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600FE88 RID: 65160 RVA: 0x00251F67 File Offset: 0x00250167
		// (set) Token: 0x0600FE89 RID: 65161 RVA: 0x00251F6F File Offset: 0x0025016F
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

		// Token: 0x0600FE8A RID: 65162 RVA: 0x00251F78 File Offset: 0x00250178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomFourCTaskDealCardInfo);
		}

		// Token: 0x0600FE8B RID: 65163 RVA: 0x00251F88 File Offset: 0x00250188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomFourCTaskDealCardInfo other)
		{
			return other != null && (other == this || (this.CardConf == other.CardConf && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FE8C RID: 65164 RVA: 0x00251FE4 File Offset: 0x002501E4
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

		// Token: 0x0600FE8D RID: 65165 RVA: 0x00252055 File Offset: 0x00250255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FE8E RID: 65166 RVA: 0x00252062 File Offset: 0x00250262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FE8F RID: 65167 RVA: 0x0025206C File Offset: 0x0025026C
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

		// Token: 0x0600FE90 RID: 65168 RVA: 0x002520E0 File Offset: 0x002502E0
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

		// Token: 0x0600FE91 RID: 65169 RVA: 0x00252150 File Offset: 0x00250350
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

		// Token: 0x0600FE92 RID: 65170 RVA: 0x002521B4 File Offset: 0x002503B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FE93 RID: 65171 RVA: 0x002521C0 File Offset: 0x002503C0
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

		// Token: 0x04006572 RID: 25970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006573 RID: 25971
		public const int CardConfFieldNumber = 1;

		// Token: 0x04006574 RID: 25972
		private int cardConf_;

		// Token: 0x04006575 RID: 25973
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x04006576 RID: 25974
		private int handCardNum_;

		// Token: 0x04006577 RID: 25975
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x04006578 RID: 25976
		private int curCardLibraryNum_;
	}
}
