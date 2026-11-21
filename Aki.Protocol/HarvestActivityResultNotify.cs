using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000734 RID: 1844
	[NetMessage(EMessageId.HarvestActivityResultNotify)]
	public sealed class HarvestActivityResultNotify : IMessage<HarvestActivityResultNotify>, IMessage, IEquatable<HarvestActivityResultNotify>, IDeepCloneable<HarvestActivityResultNotify>, IBufferMessage
	{
		// Token: 0x0600A778 RID: 42872 RVA: 0x001935F6 File Offset: 0x001917F6
		[NullableContext(1)]
		public static HarvestActivityResultNotify Create()
		{
			return new HarvestActivityResultNotify();
		}

		// Token: 0x170021A7 RID: 8615
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x001935FD File Offset: 0x001917FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021A8 RID: 8616
		// (get) Token: 0x0600A77A RID: 42874 RVA: 0x00193600 File Offset: 0x00191800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityResultNotify.Descriptor;
			}
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x00193607 File Offset: 0x00191807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify()
		{
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x00193610 File Offset: 0x00191810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify(HarvestActivityResultNotify other) : this()
		{
			this.succ_ = other.succ_;
			this.curPoint_ = other.curPoint_;
			this.hisPoint_ = other.hisPoint_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x00193664 File Offset: 0x00191864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityResultNotify Clone()
		{
			return new HarvestActivityResultNotify(this);
		}

		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x0600A77E RID: 42878 RVA: 0x0019366C File Offset: 0x0019186C
		// (set) Token: 0x0600A77F RID: 42879 RVA: 0x00193674 File Offset: 0x00191874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x0600A780 RID: 42880 RVA: 0x0019367D File Offset: 0x0019187D
		// (set) Token: 0x0600A781 RID: 42881 RVA: 0x00193685 File Offset: 0x00191885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x0600A782 RID: 42882 RVA: 0x0019368E File Offset: 0x0019188E
		// (set) Token: 0x0600A783 RID: 42883 RVA: 0x00193696 File Offset: 0x00191896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HisPoint
		{
			get
			{
				return this.hisPoint_;
			}
			set
			{
				this.hisPoint_ = value;
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x0600A784 RID: 42884 RVA: 0x0019369F File Offset: 0x0019189F
		// (set) Token: 0x0600A785 RID: 42885 RVA: 0x001936A7 File Offset: 0x001918A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x001936B0 File Offset: 0x001918B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityResultNotify);
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x001936C0 File Offset: 0x001918C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityResultNotify other)
		{
			return other != null && (other == this || (this.Succ == other.Succ && this.CurPoint == other.CurPoint && this.HisPoint == other.HisPoint && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x0019372C File Offset: 0x0019192C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.HisPoint != 0)
			{
				num ^= this.HisPoint.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x001937BC File Offset: 0x001919BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x001937C9 File Offset: 0x001919C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x001937D4 File Offset: 0x001919D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HisPoint != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HisPoint);
			}
			if (this.Succ)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Succ);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CurPoint);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x00193868 File Offset: 0x00191A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Succ)
			{
				num += 2;
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.HisPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HisPoint);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x001938E4 File Offset: 0x00191AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.HisPoint != 0)
			{
				this.HisPoint = other.HisPoint;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x0019395C File Offset: 0x00191B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x00193968 File Offset: 0x00191B68
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.HisPoint = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004CE9 RID: 19689
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CEA RID: 19690
		public const int SuccFieldNumber = 7;

		// Token: 0x04004CEB RID: 19691
		private bool succ_;

		// Token: 0x04004CEC RID: 19692
		public const int CurPointFieldNumber = 12;

		// Token: 0x04004CED RID: 19693
		private int curPoint_;

		// Token: 0x04004CEE RID: 19694
		public const int HisPointFieldNumber = 5;

		// Token: 0x04004CEF RID: 19695
		private int hisPoint_;

		// Token: 0x04004CF0 RID: 19696
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004CF1 RID: 19697
		private ErrorCode errorCode_;
	}
}
