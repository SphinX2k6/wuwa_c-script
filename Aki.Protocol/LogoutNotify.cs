using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094D RID: 2381
	[NetMessage(EMessageId.LogoutNotify)]
	public sealed class LogoutNotify : IMessage<LogoutNotify>, IMessage, IEquatable<LogoutNotify>, IDeepCloneable<LogoutNotify>, IBufferMessage
	{
		// Token: 0x0600D1E6 RID: 53734 RVA: 0x001EEFE0 File Offset: 0x001ED1E0
		[NullableContext(1)]
		public static LogoutNotify Create()
		{
			return new LogoutNotify();
		}

		// Token: 0x17002A7B RID: 10875
		// (get) Token: 0x0600D1E7 RID: 53735 RVA: 0x001EEFE7 File Offset: 0x001ED1E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x0600D1E8 RID: 53736 RVA: 0x001EEFEA File Offset: 0x001ED1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogoutNotify.Descriptor;
			}
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x001EEFF1 File Offset: 0x001ED1F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify()
		{
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x001EEFFC File Offset: 0x001ED1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify(LogoutNotify other) : this()
		{
			this.code_ = other.code_;
			this.logoutReason_ = other.logoutReason_;
			this.banInfo_ = ((other.banInfo_ != null) ? other.banInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x001EF054 File Offset: 0x001ED254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogoutNotify Clone()
		{
			return new LogoutNotify(this);
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x0600D1EC RID: 53740 RVA: 0x001EF05C File Offset: 0x001ED25C
		// (set) Token: 0x0600D1ED RID: 53741 RVA: 0x001EF064 File Offset: 0x001ED264
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

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x0600D1EE RID: 53742 RVA: 0x001EF06D File Offset: 0x001ED26D
		// (set) Token: 0x0600D1EF RID: 53743 RVA: 0x001EF075 File Offset: 0x001ED275
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

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x0600D1F0 RID: 53744 RVA: 0x001EF07E File Offset: 0x001ED27E
		// (set) Token: 0x0600D1F1 RID: 53745 RVA: 0x001EF086 File Offset: 0x001ED286
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

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x001EF08F File Offset: 0x001ED28F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogoutNotify);
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x001EF0A0 File Offset: 0x001ED2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogoutNotify other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.LogoutReason == other.LogoutReason && object.Equals(this.BanInfo, other.BanInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1F4 RID: 53748 RVA: 0x001EF100 File Offset: 0x001ED300
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

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x001EF174 File Offset: 0x001ED374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D1F6 RID: 53750 RVA: 0x001EF181 File Offset: 0x001ED381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1F7 RID: 53751 RVA: 0x001EF18C File Offset: 0x001ED38C
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

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x001EF200 File Offset: 0x001ED400
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

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x001EF270 File Offset: 0x001ED470
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

		// Token: 0x0600D1FA RID: 53754 RVA: 0x001EF2EC File Offset: 0x001ED4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x001EF2F8 File Offset: 0x001ED4F8
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

		// Token: 0x0400585D RID: 22621
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400585E RID: 22622
		public const int CodeFieldNumber = 1;

		// Token: 0x0400585F RID: 22623
		private ErrorCode code_;

		// Token: 0x04005860 RID: 22624
		public const int LogoutReasonFieldNumber = 2;

		// Token: 0x04005861 RID: 22625
		private int logoutReason_;

		// Token: 0x04005862 RID: 22626
		public const int BanInfoFieldNumber = 3;

		// Token: 0x04005863 RID: 22627
		private BanLogoutInfo banInfo_;
	}
}
