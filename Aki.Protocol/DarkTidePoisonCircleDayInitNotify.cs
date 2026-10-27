using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B2 RID: 946
	[NetMessage(EMessageId.DarkTidePoisonCircleDayInitNotify)]
	public sealed class DarkTidePoisonCircleDayInitNotify : IMessage<DarkTidePoisonCircleDayInitNotify>, IMessage, IEquatable<DarkTidePoisonCircleDayInitNotify>, IDeepCloneable<DarkTidePoisonCircleDayInitNotify>, IBufferMessage
	{
		// Token: 0x06005CDB RID: 23771 RVA: 0x000E17F2 File Offset: 0x000DF9F2
		[NullableContext(1)]
		public static DarkTidePoisonCircleDayInitNotify Create()
		{
			return new DarkTidePoisonCircleDayInitNotify();
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06005CDC RID: 23772 RVA: 0x000E17F9 File Offset: 0x000DF9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x000E17FC File Offset: 0x000DF9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePoisonCircleDayInitNotify.Descriptor;
			}
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x000E1803 File Offset: 0x000DFA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleDayInitNotify()
		{
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x000E180B File Offset: 0x000DFA0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleDayInitNotify(DarkTidePoisonCircleDayInitNotify other) : this()
		{
			this.dayInitPoisonCircleInfo_ = ((other.dayInitPoisonCircleInfo_ != null) ? other.dayInitPoisonCircleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x000E1840 File Offset: 0x000DFA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleDayInitNotify Clone()
		{
			return new DarkTidePoisonCircleDayInitNotify(this);
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x000E1848 File Offset: 0x000DFA48
		// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x000E1850 File Offset: 0x000DFA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo DayInitPoisonCircleInfo
		{
			get
			{
				return this.dayInitPoisonCircleInfo_;
			}
			set
			{
				this.dayInitPoisonCircleInfo_ = value;
			}
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x000E1859 File Offset: 0x000DFA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePoisonCircleDayInitNotify);
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000E1867 File Offset: 0x000DFA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePoisonCircleDayInitNotify other)
		{
			return other != null && (other == this || (object.Equals(this.DayInitPoisonCircleInfo, other.DayInitPoisonCircleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000E189C File Offset: 0x000DFA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dayInitPoisonCircleInfo_ != null)
			{
				num ^= this.DayInitPoisonCircleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x000E18D8 File Offset: 0x000DFAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x000E18E5 File Offset: 0x000DFAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x000E18EE File Offset: 0x000DFAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dayInitPoisonCircleInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.DayInitPoisonCircleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x000E1920 File Offset: 0x000DFB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dayInitPoisonCircleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DayInitPoisonCircleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x000E1960 File Offset: 0x000DFB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePoisonCircleDayInitNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.dayInitPoisonCircleInfo_ != null)
			{
				if (this.dayInitPoisonCircleInfo_ == null)
				{
					this.DayInitPoisonCircleInfo = new PoisonCircleSnapshotInfo();
				}
				this.DayInitPoisonCircleInfo.MergeFrom(other.DayInitPoisonCircleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x000E19B4 File Offset: 0x000DFBB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x000E19C0 File Offset: 0x000DFBC0
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.dayInitPoisonCircleInfo_ == null)
					{
						this.DayInitPoisonCircleInfo = new PoisonCircleSnapshotInfo();
					}
					input.ReadMessage(this.DayInitPoisonCircleInfo);
				}
			}
		}

		// Token: 0x04003668 RID: 13928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003669 RID: 13929
		public const int DayInitPoisonCircleInfoFieldNumber = 13;

		// Token: 0x0400366A RID: 13930
		private PoisonCircleSnapshotInfo dayInitPoisonCircleInfo_;
	}
}
