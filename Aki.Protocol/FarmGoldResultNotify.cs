using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000515 RID: 1301
	[NetMessage(EMessageId.FarmGoldResultNotify)]
	public sealed class FarmGoldResultNotify : IMessage<FarmGoldResultNotify>, IMessage, IEquatable<FarmGoldResultNotify>, IDeepCloneable<FarmGoldResultNotify>, IBufferMessage
	{
		// Token: 0x06007A8A RID: 31370 RVA: 0x00129B05 File Offset: 0x00127D05
		[NullableContext(1)]
		public static FarmGoldResultNotify Create()
		{
			return new FarmGoldResultNotify();
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x06007A8B RID: 31371 RVA: 0x00129B0C File Offset: 0x00127D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x06007A8C RID: 31372 RVA: 0x00129B0F File Offset: 0x00127D0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultNotify.Descriptor;
			}
		}

		// Token: 0x06007A8D RID: 31373 RVA: 0x00129B16 File Offset: 0x00127D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify()
		{
		}

		// Token: 0x06007A8E RID: 31374 RVA: 0x00129B20 File Offset: 0x00127D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify(FarmGoldResultNotify other) : this()
		{
			this.succ_ = other.succ_;
			this.curPoint_ = other.curPoint_;
			this.hisPoint_ = other.hisPoint_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x00129B74 File Offset: 0x00127D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify Clone()
		{
			return new FarmGoldResultNotify(this);
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x00129B7C File Offset: 0x00127D7C
		// (set) Token: 0x06007A91 RID: 31377 RVA: 0x00129B84 File Offset: 0x00127D84
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

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x06007A92 RID: 31378 RVA: 0x00129B8D File Offset: 0x00127D8D
		// (set) Token: 0x06007A93 RID: 31379 RVA: 0x00129B95 File Offset: 0x00127D95
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

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x00129B9E File Offset: 0x00127D9E
		// (set) Token: 0x06007A95 RID: 31381 RVA: 0x00129BA6 File Offset: 0x00127DA6
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

		// Token: 0x170017C3 RID: 6083
		// (get) Token: 0x06007A96 RID: 31382 RVA: 0x00129BAF File Offset: 0x00127DAF
		// (set) Token: 0x06007A97 RID: 31383 RVA: 0x00129BB7 File Offset: 0x00127DB7
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

		// Token: 0x06007A98 RID: 31384 RVA: 0x00129BC0 File Offset: 0x00127DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultNotify);
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00129BD0 File Offset: 0x00127DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultNotify other)
		{
			return other != null && (other == this || (this.Succ == other.Succ && this.CurPoint == other.CurPoint && this.HisPoint == other.HisPoint && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00129C3C File Offset: 0x00127E3C
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

		// Token: 0x06007A9B RID: 31387 RVA: 0x00129CCC File Offset: 0x00127ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x00129CD9 File Offset: 0x00127ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00129CE4 File Offset: 0x00127EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HisPoint != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HisPoint);
			}
			if (this.Succ)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Succ);
			}
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.CurPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00129D78 File Offset: 0x00127F78
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

		// Token: 0x06007A9F RID: 31391 RVA: 0x00129DF4 File Offset: 0x00127FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultNotify other)
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

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00129E6C File Offset: 0x0012806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AA1 RID: 31393 RVA: 0x00129E78 File Offset: 0x00128078
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
					if (num == 64U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 72U)
					{
						this.HisPoint = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F42 RID: 16194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F43 RID: 16195
		public const int SuccFieldNumber = 12;

		// Token: 0x04003F44 RID: 16196
		private bool succ_;

		// Token: 0x04003F45 RID: 16197
		public const int CurPointFieldNumber = 14;

		// Token: 0x04003F46 RID: 16198
		private int curPoint_;

		// Token: 0x04003F47 RID: 16199
		public const int HisPointFieldNumber = 9;

		// Token: 0x04003F48 RID: 16200
		private int hisPoint_;

		// Token: 0x04003F49 RID: 16201
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003F4A RID: 16202
		private ErrorCode errorCode_;
	}
}
