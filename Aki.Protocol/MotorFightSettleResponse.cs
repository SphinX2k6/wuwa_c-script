using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A58 RID: 2648
	[NetMessage(EMessageId.MotorFightSettleResponse)]
	public sealed class MotorFightSettleResponse : IMessage<MotorFightSettleResponse>, IMessage, IEquatable<MotorFightSettleResponse>, IDeepCloneable<MotorFightSettleResponse>, IBufferMessage
	{
		// Token: 0x0600E75C RID: 59228 RVA: 0x0021D48E File Offset: 0x0021B68E
		[NullableContext(1)]
		public static MotorFightSettleResponse Create()
		{
			return new MotorFightSettleResponse();
		}

		// Token: 0x17002EEF RID: 12015
		// (get) Token: 0x0600E75D RID: 59229 RVA: 0x0021D495 File Offset: 0x0021B695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002EF0 RID: 12016
		// (get) Token: 0x0600E75E RID: 59230 RVA: 0x0021D498 File Offset: 0x0021B698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightSettleResponse.Descriptor;
			}
		}

		// Token: 0x0600E75F RID: 59231 RVA: 0x0021D49F File Offset: 0x0021B69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse()
		{
		}

		// Token: 0x0600E760 RID: 59232 RVA: 0x0021D4A8 File Offset: 0x0021B6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse(MotorFightSettleResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.win_ = other.win_;
			this.result_ = ((other.result_ != null) ? other.result_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E761 RID: 59233 RVA: 0x0021D500 File Offset: 0x0021B700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightSettleResponse Clone()
		{
			return new MotorFightSettleResponse(this);
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600E762 RID: 59234 RVA: 0x0021D508 File Offset: 0x0021B708
		// (set) Token: 0x0600E763 RID: 59235 RVA: 0x0021D510 File Offset: 0x0021B710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x17002EF2 RID: 12018
		// (get) Token: 0x0600E764 RID: 59236 RVA: 0x0021D519 File Offset: 0x0021B719
		// (set) Token: 0x0600E765 RID: 59237 RVA: 0x0021D521 File Offset: 0x0021B721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Win
		{
			get
			{
				return this.win_;
			}
			set
			{
				this.win_ = value;
			}
		}

		// Token: 0x17002EF3 RID: 12019
		// (get) Token: 0x0600E766 RID: 59238 RVA: 0x0021D52A File Offset: 0x0021B72A
		// (set) Token: 0x0600E767 RID: 59239 RVA: 0x0021D532 File Offset: 0x0021B732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x0600E768 RID: 59240 RVA: 0x0021D53B File Offset: 0x0021B73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightSettleResponse);
		}

		// Token: 0x0600E769 RID: 59241 RVA: 0x0021D54C File Offset: 0x0021B74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightSettleResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.Win == other.Win && object.Equals(this.Result, other.Result) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E76A RID: 59242 RVA: 0x0021D5AC File Offset: 0x0021B7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.Win)
			{
				num ^= this.Win.GetHashCode();
			}
			if (this.result_ != null)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E76B RID: 59243 RVA: 0x0021D620 File Offset: 0x0021B820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E76C RID: 59244 RVA: 0x0021D62D File Offset: 0x0021B82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x0021D638 File Offset: 0x0021B838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Win)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.Win);
			}
			if (this.result_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Result);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E76E RID: 59246 RVA: 0x0021D6B0 File Offset: 0x0021B8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.Win)
			{
				num += 2;
			}
			if (this.result_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E76F RID: 59247 RVA: 0x0021D714 File Offset: 0x0021B914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.Win)
			{
				this.Win = other.Win;
			}
			if (other.result_ != null)
			{
				if (this.result_ == null)
				{
					this.Result = new MotorFightResult();
				}
				this.Result.MergeFrom(other.Result);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E770 RID: 59248 RVA: 0x0021D790 File Offset: 0x0021B990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E771 RID: 59249 RVA: 0x0021D79C File Offset: 0x0021B99C
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
				if (num != 64U)
				{
					if (num != 82U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						if (this.result_ == null)
						{
							this.Result = new MotorFightResult();
						}
						input.ReadMessage(this.Result);
					}
				}
				else
				{
					this.Win = input.ReadBool();
				}
			}
		}

		// Token: 0x04005EB3 RID: 24243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EB4 RID: 24244
		public const int ErrCodeFieldNumber = 15;

		// Token: 0x04005EB5 RID: 24245
		private ErrorCode errCode_;

		// Token: 0x04005EB6 RID: 24246
		public const int WinFieldNumber = 8;

		// Token: 0x04005EB7 RID: 24247
		private bool win_;

		// Token: 0x04005EB8 RID: 24248
		public const int ResultFieldNumber = 10;

		// Token: 0x04005EB9 RID: 24249
		private MotorFightResult result_;
	}
}
