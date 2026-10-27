using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000159 RID: 345
	public sealed class BanLogoutInfo : IMessage<BanLogoutInfo>, IMessage, IEquatable<BanLogoutInfo>, IDeepCloneable<BanLogoutInfo>, IBufferMessage
	{
		// Token: 0x06002B7D RID: 11133 RVA: 0x000715C4 File Offset: 0x0006F7C4
		[NullableContext(1)]
		public static BanLogoutInfo Create()
		{
			return new BanLogoutInfo();
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000715CB File Offset: 0x0006F7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000715CE File Offset: 0x0006F7CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BanLogoutInfo.Descriptor;
			}
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x000715D5 File Offset: 0x0006F7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo()
		{
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000715DD File Offset: 0x0006F7DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo(BanLogoutInfo other) : this()
		{
			this.reason_ = other.reason_;
			this.banEndTime_ = other.banEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x0007160E File Offset: 0x0006F80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BanLogoutInfo Clone()
		{
			return new BanLogoutInfo(this);
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x00071616 File Offset: 0x0006F816
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x0007161E File Offset: 0x0006F81E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x00071627 File Offset: 0x0006F827
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x0007162F File Offset: 0x0006F82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BanEndTime
		{
			get
			{
				return this.banEndTime_;
			}
			set
			{
				this.banEndTime_ = value;
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00071638 File Offset: 0x0006F838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BanLogoutInfo);
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00071646 File Offset: 0x0006F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BanLogoutInfo other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.BanEndTime == other.BanEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00071684 File Offset: 0x0006F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.BanEndTime != 0L)
			{
				num ^= this.BanEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x000716DC File Offset: 0x0006F8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B8B RID: 11147 RVA: 0x000716E9 File Offset: 0x0006F8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B8C RID: 11148 RVA: 0x000716F4 File Offset: 0x0006F8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Reason);
			}
			if (this.BanEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0007174C File Offset: 0x0006F94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this.BanEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BanEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B8E RID: 11150 RVA: 0x000717A4 File Offset: 0x0006F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BanLogoutInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			if (other.BanEndTime != 0L)
			{
				this.BanEndTime = other.BanEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B8F RID: 11151 RVA: 0x000717F4 File Offset: 0x0006F9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B90 RID: 11152 RVA: 0x00071800 File Offset: 0x0006FA00
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BanEndTime = input.ReadInt64();
					}
				}
				else
				{
					this.Reason = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027A2 RID: 10146
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027A3 RID: 10147
		public const int ReasonFieldNumber = 1;

		// Token: 0x040027A4 RID: 10148
		private int reason_;

		// Token: 0x040027A5 RID: 10149
		public const int BanEndTimeFieldNumber = 2;

		// Token: 0x040027A6 RID: 10150
		private long banEndTime_;
	}
}
