using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D4 RID: 1492
	[NetMessage(EMessageId.FloroRanchPlayTributeResponse)]
	public sealed class FloroRanchPlayTributeResponse : IMessage<FloroRanchPlayTributeResponse>, IMessage, IEquatable<FloroRanchPlayTributeResponse>, IDeepCloneable<FloroRanchPlayTributeResponse>, IBufferMessage
	{
		// Token: 0x060089FA RID: 35322 RVA: 0x0014D400 File Offset: 0x0014B600
		[NullableContext(1)]
		public static FloroRanchPlayTributeResponse Create()
		{
			return new FloroRanchPlayTributeResponse();
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060089FB RID: 35323 RVA: 0x0014D407 File Offset: 0x0014B607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060089FC RID: 35324 RVA: 0x0014D40A File Offset: 0x0014B60A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTributeResponse.Descriptor;
			}
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x0014D411 File Offset: 0x0014B611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeResponse()
		{
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x0014D424 File Offset: 0x0014B624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeResponse(FloroRanchPlayTributeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.settle_ = other.settle_;
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this.remainDay_ = other.remainDay_;
			this.curStage_ = other.curStage_;
			this.task_ = other.task_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x0014D4A1 File Offset: 0x0014B6A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeResponse Clone()
		{
			return new FloroRanchPlayTributeResponse(this);
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x06008A00 RID: 35328 RVA: 0x0014D4A9 File Offset: 0x0014B6A9
		// (set) Token: 0x06008A01 RID: 35329 RVA: 0x0014D4B1 File Offset: 0x0014B6B1
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

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x06008A02 RID: 35330 RVA: 0x0014D4BA File Offset: 0x0014B6BA
		// (set) Token: 0x06008A03 RID: 35331 RVA: 0x0014D4C2 File Offset: 0x0014B6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Settle
		{
			get
			{
				return this.settle_;
			}
			set
			{
				this.settle_ = value;
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x06008A04 RID: 35332 RVA: 0x0014D4CB File Offset: 0x0014B6CB
		// (set) Token: 0x06008A05 RID: 35333 RVA: 0x0014D4D3 File Offset: 0x0014B6D3
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

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x06008A06 RID: 35334 RVA: 0x0014D4DC File Offset: 0x0014B6DC
		// (set) Token: 0x06008A07 RID: 35335 RVA: 0x0014D4E4 File Offset: 0x0014B6E4
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

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x06008A08 RID: 35336 RVA: 0x0014D4ED File Offset: 0x0014B6ED
		// (set) Token: 0x06008A09 RID: 35337 RVA: 0x0014D4F5 File Offset: 0x0014B6F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainDay
		{
			get
			{
				return this.remainDay_;
			}
			set
			{
				this.remainDay_ = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x06008A0A RID: 35338 RVA: 0x0014D4FE File Offset: 0x0014B6FE
		// (set) Token: 0x06008A0B RID: 35339 RVA: 0x0014D506 File Offset: 0x0014B706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurStage
		{
			get
			{
				return this.curStage_;
			}
			set
			{
				this.curStage_ = value;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x06008A0C RID: 35340 RVA: 0x0014D50F File Offset: 0x0014B70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x06008A0D RID: 35341 RVA: 0x0014D517 File Offset: 0x0014B717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTributeResponse);
		}

		// Token: 0x06008A0E RID: 35342 RVA: 0x0014D528 File Offset: 0x0014B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTributeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Settle == other.Settle && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && this.RemainDay == other.RemainDay && this.CurStage == other.CurStage && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A0F RID: 35343 RVA: 0x0014D5C8 File Offset: 0x0014B7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Settle)
			{
				num ^= this.Settle.GetHashCode();
			}
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this.RemainDay != 0)
			{
				num ^= this.RemainDay.GetHashCode();
			}
			if (this.CurStage != 0)
			{
				num ^= this.CurStage.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A10 RID: 35344 RVA: 0x0014D69A File Offset: 0x0014B89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A11 RID: 35345 RVA: 0x0014D6A7 File Offset: 0x0014B8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A12 RID: 35346 RVA: 0x0014D6B0 File Offset: 0x0014B8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CurCoin);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CurDiamond);
			}
			this.task_.WriteTo(ref output, FloroRanchPlayTributeResponse._repeated_task_codec);
			if (this.RemainDay != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RemainDay);
			}
			if (this.Settle)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Settle);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.CurStage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A13 RID: 35347 RVA: 0x0014D78C File Offset: 0x0014B98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Settle)
			{
				num += 2;
			}
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this.RemainDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainDay);
			}
			if (this.CurStage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurStage);
			}
			num += this.task_.CalculateSize(FloroRanchPlayTributeResponse._repeated_task_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A14 RID: 35348 RVA: 0x0014D84C File Offset: 0x0014BA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayTributeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Settle)
			{
				this.Settle = other.Settle;
			}
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			if (other.RemainDay != 0)
			{
				this.RemainDay = other.RemainDay;
			}
			if (other.CurStage != 0)
			{
				this.CurStage = other.CurStage;
			}
			this.task_.Add(other.task_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A15 RID: 35349 RVA: 0x0014D8FD File Offset: 0x0014BAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A16 RID: 35350 RVA: 0x0014D908 File Offset: 0x0014BB08
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
					if (num == 24U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 74U)
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchPlayTributeResponse._repeated_task_codec);
						continue;
					}
					if (num == 80U)
					{
						this.RemainDay = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Settle = input.ReadBool();
						continue;
					}
					if (num == 104U)
					{
						this.CurStage = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043C5 RID: 17349
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043C6 RID: 17350
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040043C7 RID: 17351
		private ErrorCode errorCode_;

		// Token: 0x040043C8 RID: 17352
		public const int SettleFieldNumber = 12;

		// Token: 0x040043C9 RID: 17353
		private bool settle_;

		// Token: 0x040043CA RID: 17354
		public const int CurCoinFieldNumber = 3;

		// Token: 0x040043CB RID: 17355
		private long curCoin_;

		// Token: 0x040043CC RID: 17356
		public const int CurDiamondFieldNumber = 7;

		// Token: 0x040043CD RID: 17357
		private long curDiamond_;

		// Token: 0x040043CE RID: 17358
		public const int RemainDayFieldNumber = 10;

		// Token: 0x040043CF RID: 17359
		private int remainDay_;

		// Token: 0x040043D0 RID: 17360
		public const int CurStageFieldNumber = 13;

		// Token: 0x040043D1 RID: 17361
		private int curStage_;

		// Token: 0x040043D2 RID: 17362
		public const int TaskFieldNumber = 9;

		// Token: 0x040043D3 RID: 17363
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(74U, FloroRanchPlayTask.Parser);

		// Token: 0x040043D4 RID: 17364
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
