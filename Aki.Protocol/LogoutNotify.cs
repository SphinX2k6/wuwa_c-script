using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093C RID: 2364
	[NetMessage(EMessageId.LogoutNotify)]
	public sealed class LogoutNotify : IMessage<LogoutNotify>, IMessage, IEquatable<LogoutNotify>, IDeepCloneable<LogoutNotify>, IBufferMessage
	{
		// Token: 0x0600D0CC RID: 53452 RVA: 0x001ECDF8 File Offset: 0x001EAFF8
		[NullableContext(1)]
		public static LogoutNotify Create()
		{
			return new LogoutNotify();
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x0600D0CD RID: 53453 RVA: 0x001ECDFF File Offset: 0x001EAFFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x001ECE02 File Offset: 0x001EB002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogoutNotify.Descriptor;
			}
		}

		// Token: 0x0600D0CF RID: 53455 RVA: 0x001ECE09 File Offset: 0x001EB009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify()
		{
		}

		// Token: 0x0600D0D0 RID: 53456 RVA: 0x001ECE14 File Offset: 0x001EB014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify(LogoutNotify other) : this()
		{
			this.code_ = other.code_;
			this.logoutReason_ = other.logoutReason_;
			this.banInfo_ = ((other.banInfo_ != null) ? other.banInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0D1 RID: 53457 RVA: 0x001ECE6C File Offset: 0x001EB06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify Clone()
		{
			return new LogoutNotify(this);
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x0600D0D2 RID: 53458 RVA: 0x001ECE74 File Offset: 0x001EB074
		// (set) Token: 0x0600D0D3 RID: 53459 RVA: 0x001ECE7C File Offset: 0x001EB07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x0600D0D4 RID: 53460 RVA: 0x001ECE85 File Offset: 0x001EB085
		// (set) Token: 0x0600D0D5 RID: 53461 RVA: 0x001ECE8D File Offset: 0x001EB08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LogoutReason
		{
			get
			{
				return this.logoutReason_;
			}
			set
			{
				this.logoutReason_ = value;
			}
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x0600D0D6 RID: 53462 RVA: 0x001ECE96 File Offset: 0x001EB096
		// (set) Token: 0x0600D0D7 RID: 53463 RVA: 0x001ECE9E File Offset: 0x001EB09E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo BanInfo
		{
			get
			{
				return this.banInfo_;
			}
			set
			{
				this.banInfo_ = value;
			}
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x001ECEA7 File Offset: 0x001EB0A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogoutNotify);
		}

		// Token: 0x0600D0D9 RID: 53465 RVA: 0x001ECEB8 File Offset: 0x001EB0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogoutNotify other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.LogoutReason == other.LogoutReason && object.Equals(this.BanInfo, other.BanInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0DA RID: 53466 RVA: 0x001ECF18 File Offset: 0x001EB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.LogoutReason != 0)
			{
				num ^= this.LogoutReason.GetHashCode();
			}
			if (this.banInfo_ != null)
			{
				num ^= this.BanInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0DB RID: 53467 RVA: 0x001ECF8C File Offset: 0x001EB18C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D0DC RID: 53468 RVA: 0x001ECF99 File Offset: 0x001EB199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0DD RID: 53469 RVA: 0x001ECFA4 File Offset: 0x001EB1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.LogoutReason != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LogoutReason);
			}
			if (this.banInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.BanInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0DE RID: 53470 RVA: 0x001ED018 File Offset: 0x001EB218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.LogoutReason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LogoutReason);
			}
			if (this.banInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BanInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0DF RID: 53471 RVA: 0x001ED088 File Offset: 0x001EB288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogoutNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.LogoutReason != 0)
			{
				this.LogoutReason = other.LogoutReason;
			}
			if (other.banInfo_ != null)
			{
				if (this.banInfo_ == null)
				{
					this.BanInfo = new BanLogoutInfo();
				}
				this.BanInfo.MergeFrom(other.BanInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0E0 RID: 53472 RVA: 0x001ED104 File Offset: 0x001EB304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x001ED110 File Offset: 0x001EB310
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.banInfo_ == null)
							{
								this.BanInfo = new BanLogoutInfo();
							}
							input.ReadMessage(this.BanInfo);
						}
					}
					else
					{
						this.LogoutReason = input.ReadInt32();
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005866 RID: 22630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005867 RID: 22631
		public const int CodeFieldNumber = 1;

		// Token: 0x04005868 RID: 22632
		private ErrorCode code_;

		// Token: 0x04005869 RID: 22633
		public const int LogoutReasonFieldNumber = 2;

		// Token: 0x0400586A RID: 22634
		private int logoutReason_;

		// Token: 0x0400586B RID: 22635
		public const int BanInfoFieldNumber = 3;

		// Token: 0x0400586C RID: 22636
		private BanLogoutInfo banInfo_;
	}
}
