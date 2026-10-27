using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BD RID: 1469
	[NetMessage(EMessageId.FloroRanchPlayGachaRefreshResponse)]
	public sealed class FloroRanchPlayGachaRefreshResponse : IMessage<FloroRanchPlayGachaRefreshResponse>, IMessage, IEquatable<FloroRanchPlayGachaRefreshResponse>, IDeepCloneable<FloroRanchPlayGachaRefreshResponse>, IBufferMessage
	{
		// Token: 0x060087B3 RID: 34739 RVA: 0x00146767 File Offset: 0x00144967
		[NullableContext(1)]
		public static FloroRanchPlayGachaRefreshResponse Create()
		{
			return new FloroRanchPlayGachaRefreshResponse();
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060087B4 RID: 34740 RVA: 0x0014676E File Offset: 0x0014496E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060087B5 RID: 34741 RVA: 0x00146771 File Offset: 0x00144971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRefreshResponse.Descriptor;
			}
		}

		// Token: 0x060087B6 RID: 34742 RVA: 0x00146778 File Offset: 0x00144978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshResponse()
		{
		}

		// Token: 0x060087B7 RID: 34743 RVA: 0x00146780 File Offset: 0x00144980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshResponse(FloroRanchPlayGachaRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087B8 RID: 34744 RVA: 0x001467E4 File Offset: 0x001449E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshResponse Clone()
		{
			return new FloroRanchPlayGachaRefreshResponse(this);
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060087B9 RID: 34745 RVA: 0x001467EC File Offset: 0x001449EC
		// (set) Token: 0x060087BA RID: 34746 RVA: 0x001467F4 File Offset: 0x001449F4
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

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060087BB RID: 34747 RVA: 0x001467FD File Offset: 0x001449FD
		// (set) Token: 0x060087BC RID: 34748 RVA: 0x00146805 File Offset: 0x00144A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchGacha Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060087BD RID: 34749 RVA: 0x0014680E File Offset: 0x00144A0E
		// (set) Token: 0x060087BE RID: 34750 RVA: 0x00146816 File Offset: 0x00144A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060087BF RID: 34751 RVA: 0x0014681F File Offset: 0x00144A1F
		// (set) Token: 0x060087C0 RID: 34752 RVA: 0x00146827 File Offset: 0x00144A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurDiamond
		{
			get
			{
				return this.curDiamond_;
			}
			set
			{
				this.curDiamond_ = value;
			}
		}

		// Token: 0x060087C1 RID: 34753 RVA: 0x00146830 File Offset: 0x00144A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRefreshResponse);
		}

		// Token: 0x060087C2 RID: 34754 RVA: 0x00146840 File Offset: 0x00144A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Task, other.Task) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087C3 RID: 34755 RVA: 0x001468B0 File Offset: 0x00144AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087C4 RID: 34756 RVA: 0x0014693D File Offset: 0x00144B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x0014694A File Offset: 0x00144B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x00146954 File Offset: 0x00144B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.task_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Task);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.CurCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x001469E8 File Offset: 0x00144BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x00146A70 File Offset: 0x00144C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayGachaRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new FloroRanchGacha();
				}
				this.Task.MergeFrom(other.Task);
			}
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x00146B00 File Offset: 0x00144D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x00146B0C File Offset: 0x00144D0C
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
				if (num <= 72U)
				{
					if (num == 40U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.task_ == null)
						{
							this.Task = new FloroRanchGacha();
						}
						input.ReadMessage(this.Task);
						continue;
					}
					if (num == 104U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042D5 RID: 17109
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042D6 RID: 17110
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x040042D7 RID: 17111
		private ErrorCode errorCode_;

		// Token: 0x040042D8 RID: 17112
		public const int TaskFieldNumber = 11;

		// Token: 0x040042D9 RID: 17113
		private FloroRanchGacha task_;

		// Token: 0x040042DA RID: 17114
		public const int CurCoinFieldNumber = 13;

		// Token: 0x040042DB RID: 17115
		private long curCoin_;

		// Token: 0x040042DC RID: 17116
		public const int CurDiamondFieldNumber = 5;

		// Token: 0x040042DD RID: 17117
		private long curDiamond_;
	}
}
