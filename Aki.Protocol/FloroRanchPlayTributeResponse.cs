using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BF RID: 1471
	[NetMessage(EMessageId.FloroRanchPlayTributeResponse)]
	public sealed class FloroRanchPlayTributeResponse : IMessage<FloroRanchPlayTributeResponse>, IMessage, IEquatable<FloroRanchPlayTributeResponse>, IDeepCloneable<FloroRanchPlayTributeResponse>, IBufferMessage
	{
		// Token: 0x06008892 RID: 34962 RVA: 0x0014A7E4 File Offset: 0x001489E4
		[NullableContext(1)]
		public static FloroRanchPlayTributeResponse Create()
		{
			return new FloroRanchPlayTributeResponse();
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x06008893 RID: 34963 RVA: 0x0014A7EB File Offset: 0x001489EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x06008894 RID: 34964 RVA: 0x0014A7EE File Offset: 0x001489EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayTributeResponse.Descriptor;
			}
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x0014A7F5 File Offset: 0x001489F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeResponse()
		{
		}

		// Token: 0x06008896 RID: 34966 RVA: 0x0014A808 File Offset: 0x00148A08
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

		// Token: 0x06008897 RID: 34967 RVA: 0x0014A885 File Offset: 0x00148A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayTributeResponse Clone()
		{
			return new FloroRanchPlayTributeResponse(this);
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06008898 RID: 34968 RVA: 0x0014A88D File Offset: 0x00148A8D
		// (set) Token: 0x06008899 RID: 34969 RVA: 0x0014A895 File Offset: 0x00148A95
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

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600889A RID: 34970 RVA: 0x0014A89E File Offset: 0x00148A9E
		// (set) Token: 0x0600889B RID: 34971 RVA: 0x0014A8A6 File Offset: 0x00148AA6
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

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600889C RID: 34972 RVA: 0x0014A8AF File Offset: 0x00148AAF
		// (set) Token: 0x0600889D RID: 34973 RVA: 0x0014A8B7 File Offset: 0x00148AB7
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

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600889E RID: 34974 RVA: 0x0014A8C0 File Offset: 0x00148AC0
		// (set) Token: 0x0600889F RID: 34975 RVA: 0x0014A8C8 File Offset: 0x00148AC8
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

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x060088A0 RID: 34976 RVA: 0x0014A8D1 File Offset: 0x00148AD1
		// (set) Token: 0x060088A1 RID: 34977 RVA: 0x0014A8D9 File Offset: 0x00148AD9
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

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x060088A2 RID: 34978 RVA: 0x0014A8E2 File Offset: 0x00148AE2
		// (set) Token: 0x060088A3 RID: 34979 RVA: 0x0014A8EA File Offset: 0x00148AEA
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

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x060088A4 RID: 34980 RVA: 0x0014A8F3 File Offset: 0x00148AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x060088A5 RID: 34981 RVA: 0x0014A8FB File Offset: 0x00148AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayTributeResponse);
		}

		// Token: 0x060088A6 RID: 34982 RVA: 0x0014A90C File Offset: 0x00148B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayTributeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Settle == other.Settle && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && this.RemainDay == other.RemainDay && this.CurStage == other.CurStage && this.task_.Equals(other.task_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088A7 RID: 34983 RVA: 0x0014A9AC File Offset: 0x00148BAC
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

		// Token: 0x060088A8 RID: 34984 RVA: 0x0014AA7E File Offset: 0x00148C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x0014AA8B File Offset: 0x00148C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x0014AA94 File Offset: 0x00148C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Settle)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Settle);
			}
			this.task_.WriteTo(ref output, FloroRanchPlayTributeResponse._repeated_task_codec);
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.CurCoin);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RemainDay != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RemainDay);
			}
			if (this.CurStage != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurStage);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.CurDiamond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x0014AB70 File Offset: 0x00148D70
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

		// Token: 0x060088AC RID: 34988 RVA: 0x0014AC30 File Offset: 0x00148E30
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

		// Token: 0x060088AD RID: 34989 RVA: 0x0014ACE1 File Offset: 0x00148EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x0014ACEC File Offset: 0x00148EEC
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
					if (num == 8U)
					{
						this.Settle = input.ReadBool();
						continue;
					}
					if (num == 34U)
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchPlayTributeResponse._repeated_task_codec);
						continue;
					}
					if (num == 56U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				else if (num <= 80U)
				{
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
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
					if (num == 112U)
					{
						this.CurStage = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040043BB RID: 17339
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043BC RID: 17340
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040043BD RID: 17341
		private ErrorCode errorCode_;

		// Token: 0x040043BE RID: 17342
		public const int SettleFieldNumber = 1;

		// Token: 0x040043BF RID: 17343
		private bool settle_;

		// Token: 0x040043C0 RID: 17344
		public const int CurCoinFieldNumber = 7;

		// Token: 0x040043C1 RID: 17345
		private long curCoin_;

		// Token: 0x040043C2 RID: 17346
		public const int CurDiamondFieldNumber = 15;

		// Token: 0x040043C3 RID: 17347
		private long curDiamond_;

		// Token: 0x040043C4 RID: 17348
		public const int RemainDayFieldNumber = 10;

		// Token: 0x040043C5 RID: 17349
		private int remainDay_;

		// Token: 0x040043C6 RID: 17350
		public const int CurStageFieldNumber = 14;

		// Token: 0x040043C7 RID: 17351
		private int curStage_;

		// Token: 0x040043C8 RID: 17352
		public const int TaskFieldNumber = 4;

		// Token: 0x040043C9 RID: 17353
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(34U, FloroRanchPlayTask.Parser);

		// Token: 0x040043CA RID: 17354
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();
	}
}
