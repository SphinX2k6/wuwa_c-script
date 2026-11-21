using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005A8 RID: 1448
	[NetMessage(EMessageId.FloroRanchPlayGachaRefreshResponse)]
	public sealed class FloroRanchPlayGachaRefreshResponse : IMessage<FloroRanchPlayGachaRefreshResponse>, IMessage, IEquatable<FloroRanchPlayGachaRefreshResponse>, IDeepCloneable<FloroRanchPlayGachaRefreshResponse>, IBufferMessage
	{
		// Token: 0x0600864B RID: 34379 RVA: 0x00143B4F File Offset: 0x00141D4F
		[NullableContext(1)]
		public static FloroRanchPlayGachaRefreshResponse Create()
		{
			return new FloroRanchPlayGachaRefreshResponse();
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x00143B56 File Offset: 0x00141D56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x0600864D RID: 34381 RVA: 0x00143B59 File Offset: 0x00141D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayGachaRefreshResponse.Descriptor;
			}
		}

		// Token: 0x0600864E RID: 34382 RVA: 0x00143B60 File Offset: 0x00141D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshResponse()
		{
		}

		// Token: 0x0600864F RID: 34383 RVA: 0x00143B68 File Offset: 0x00141D68
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

		// Token: 0x06008650 RID: 34384 RVA: 0x00143BCC File Offset: 0x00141DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayGachaRefreshResponse Clone()
		{
			return new FloroRanchPlayGachaRefreshResponse(this);
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x06008651 RID: 34385 RVA: 0x00143BD4 File Offset: 0x00141DD4
		// (set) Token: 0x06008652 RID: 34386 RVA: 0x00143BDC File Offset: 0x00141DDC
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

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06008653 RID: 34387 RVA: 0x00143BE5 File Offset: 0x00141DE5
		// (set) Token: 0x06008654 RID: 34388 RVA: 0x00143BED File Offset: 0x00141DED
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

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x06008655 RID: 34389 RVA: 0x00143BF6 File Offset: 0x00141DF6
		// (set) Token: 0x06008656 RID: 34390 RVA: 0x00143BFE File Offset: 0x00141DFE
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

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06008657 RID: 34391 RVA: 0x00143C07 File Offset: 0x00141E07
		// (set) Token: 0x06008658 RID: 34392 RVA: 0x00143C0F File Offset: 0x00141E0F
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

		// Token: 0x06008659 RID: 34393 RVA: 0x00143C18 File Offset: 0x00141E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayGachaRefreshResponse);
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00143C28 File Offset: 0x00141E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayGachaRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Task, other.Task) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x00143C98 File Offset: 0x00141E98
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

		// Token: 0x0600865C RID: 34396 RVA: 0x00143D25 File Offset: 0x00141F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600865D RID: 34397 RVA: 0x00143D32 File Offset: 0x00141F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600865E RID: 34398 RVA: 0x00143D3C File Offset: 0x00141F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.CurCoin);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.task_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600865F RID: 34399 RVA: 0x00143DD0 File Offset: 0x00141FD0
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

		// Token: 0x06008660 RID: 34400 RVA: 0x00143E58 File Offset: 0x00142058
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

		// Token: 0x06008661 RID: 34401 RVA: 0x00143EE8 File Offset: 0x001420E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x00143EF4 File Offset: 0x001420F4
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
					if (num == 48U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						if (this.task_ == null)
						{
							this.Task = new FloroRanchGacha();
						}
						input.ReadMessage(this.Task);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040042CB RID: 17099
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042CC RID: 17100
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040042CD RID: 17101
		private ErrorCode errorCode_;

		// Token: 0x040042CE RID: 17102
		public const int TaskFieldNumber = 15;

		// Token: 0x040042CF RID: 17103
		private FloroRanchGacha task_;

		// Token: 0x040042D0 RID: 17104
		public const int CurCoinFieldNumber = 9;

		// Token: 0x040042D1 RID: 17105
		private long curCoin_;

		// Token: 0x040042D2 RID: 17106
		public const int CurDiamondFieldNumber = 6;

		// Token: 0x040042D3 RID: 17107
		private long curDiamond_;
	}
}
