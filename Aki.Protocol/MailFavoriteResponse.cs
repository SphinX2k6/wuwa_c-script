using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000969 RID: 2409
	[NetMessage(EMessageId.MailFavoriteResponse)]
	public sealed class MailFavoriteResponse : IMessage<MailFavoriteResponse>, IMessage, IEquatable<MailFavoriteResponse>, IDeepCloneable<MailFavoriteResponse>, IBufferMessage
	{
		// Token: 0x0600D44E RID: 54350 RVA: 0x001F4344 File Offset: 0x001F2544
		[NullableContext(1)]
		public static MailFavoriteResponse Create()
		{
			return new MailFavoriteResponse();
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x0600D44F RID: 54351 RVA: 0x001F434B File Offset: 0x001F254B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x0600D450 RID: 54352 RVA: 0x001F434E File Offset: 0x001F254E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MailFavoriteResponse.Descriptor;
			}
		}

		// Token: 0x0600D451 RID: 54353 RVA: 0x001F4355 File Offset: 0x001F2555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse()
		{
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x001F4368 File Offset: 0x001F2568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse(MailFavoriteResponse other) : this()
		{
			this.id_ = other.id_;
			this.state_ = other.state_;
			this.errorCode_ = other.errorCode_;
			this.expiryTime_ = other.expiryTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x001F43BC File Offset: 0x001F25BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MailFavoriteResponse Clone()
		{
			return new MailFavoriteResponse(this);
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x0600D454 RID: 54356 RVA: 0x001F43C4 File Offset: 0x001F25C4
		// (set) Token: 0x0600D455 RID: 54357 RVA: 0x001F43CC File Offset: 0x001F25CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x001F43DF File Offset: 0x001F25DF
		// (set) Token: 0x0600D457 RID: 54359 RVA: 0x001F43E7 File Offset: 0x001F25E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600D458 RID: 54360 RVA: 0x001F43F0 File Offset: 0x001F25F0
		// (set) Token: 0x0600D459 RID: 54361 RVA: 0x001F43F8 File Offset: 0x001F25F8
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

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600D45A RID: 54362 RVA: 0x001F4401 File Offset: 0x001F2601
		// (set) Token: 0x0600D45B RID: 54363 RVA: 0x001F4409 File Offset: 0x001F2609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpiryTime
		{
			get
			{
				return this.expiryTime_;
			}
			set
			{
				this.expiryTime_ = value;
			}
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x001F4412 File Offset: 0x001F2612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MailFavoriteResponse);
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x001F4420 File Offset: 0x001F2620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MailFavoriteResponse other)
		{
			return other != null && (other == this || (!(this.Id != other.Id) && this.State == other.State && this.ErrorCode == other.ErrorCode && this.ExpiryTime == other.ExpiryTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x001F4490 File Offset: 0x001F2690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id.Length != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.State != 0)
			{
				num ^= this.State.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ExpiryTime != 0L)
			{
				num ^= this.ExpiryTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x001F4522 File Offset: 0x001F2722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x001F452F File Offset: 0x001F272F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D461 RID: 54369 RVA: 0x001F4538 File Offset: 0x001F2738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ExpiryTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ExpiryTime);
			}
			if (this.Id.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.Id);
			}
			if (this.State != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x001F45D0 File Offset: 0x001F27D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			if (this.State != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.State);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ExpiryTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpiryTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x001F465C File Offset: 0x001F285C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MailFavoriteResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id.Length != 0)
			{
				this.Id = other.Id;
			}
			if (other.State != 0)
			{
				this.State = other.State;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ExpiryTime != 0L)
			{
				this.ExpiryTime = other.ExpiryTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D464 RID: 54372 RVA: 0x001F46D9 File Offset: 0x001F28D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x001F46E4 File Offset: 0x001F28E4
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
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.ExpiryTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.Id = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.State = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400595D RID: 22877
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400595E RID: 22878
		public const int IdFieldNumber = 10;

		// Token: 0x0400595F RID: 22879
		private string id_ = "";

		// Token: 0x04005960 RID: 22880
		public const int StateFieldNumber = 12;

		// Token: 0x04005961 RID: 22881
		private int state_;

		// Token: 0x04005962 RID: 22882
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04005963 RID: 22883
		private ErrorCode errorCode_;

		// Token: 0x04005964 RID: 22884
		public const int ExpiryTimeFieldNumber = 4;

		// Token: 0x04005965 RID: 22885
		private long expiryTime_;
	}
}
