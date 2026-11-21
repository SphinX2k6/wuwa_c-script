using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC1 RID: 3777
	public sealed class RecentlyTeamInfo : IMessage<RecentlyTeamInfo>, IMessage, IEquatable<RecentlyTeamInfo>, IDeepCloneable<RecentlyTeamInfo>, IBufferMessage
	{
		// Token: 0x06014463 RID: 83043 RVA: 0x002F2BF5 File Offset: 0x002F0DF5
		[NullableContext(1)]
		public static RecentlyTeamInfo Create()
		{
			return new RecentlyTeamInfo();
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x06014464 RID: 83044 RVA: 0x002F2BFC File Offset: 0x002F0DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecentlyTeamInfo> Parser
		{
			get
			{
				return RecentlyTeamInfo._parser;
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x06014465 RID: 83045 RVA: 0x002F2C03 File Offset: 0x002F0E03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x06014466 RID: 83046 RVA: 0x002F2C06 File Offset: 0x002F0E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentlyTeamInfo.Descriptor;
			}
		}

		// Token: 0x06014467 RID: 83047 RVA: 0x002F2C0D File Offset: 0x002F0E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo()
		{
		}

		// Token: 0x06014468 RID: 83048 RVA: 0x002F2C18 File Offset: 0x002F0E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo(RecentlyTeamInfo other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.teamTime_ = other.teamTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014469 RID: 83049 RVA: 0x002F2C64 File Offset: 0x002F0E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo Clone()
		{
			return new RecentlyTeamInfo(this);
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0601446A RID: 83050 RVA: 0x002F2C6C File Offset: 0x002F0E6C
		// (set) Token: 0x0601446B RID: 83051 RVA: 0x002F2C74 File Offset: 0x002F0E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0601446C RID: 83052 RVA: 0x002F2C7D File Offset: 0x002F0E7D
		// (set) Token: 0x0601446D RID: 83053 RVA: 0x002F2C85 File Offset: 0x002F0E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TeamTime
		{
			get
			{
				return this.teamTime_;
			}
			set
			{
				this.teamTime_ = value;
			}
		}

		// Token: 0x0601446E RID: 83054 RVA: 0x002F2C8E File Offset: 0x002F0E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentlyTeamInfo);
		}

		// Token: 0x0601446F RID: 83055 RVA: 0x002F2C9C File Offset: 0x002F0E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecentlyTeamInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.TeamTime == other.TeamTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014470 RID: 83056 RVA: 0x002F2CEC File Offset: 0x002F0EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.TeamTime != 0L)
			{
				num ^= this.TeamTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014471 RID: 83057 RVA: 0x002F2D41 File Offset: 0x002F0F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014472 RID: 83058 RVA: 0x002F2D4E File Offset: 0x002F0F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014473 RID: 83059 RVA: 0x002F2D58 File Offset: 0x002F0F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.TeamTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TeamTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014474 RID: 83060 RVA: 0x002F2DB4 File Offset: 0x002F0FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.TeamTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TeamTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014475 RID: 83061 RVA: 0x002F2E0C File Offset: 0x002F100C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecentlyTeamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.TeamTime != 0L)
			{
				this.TeamTime = other.TeamTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014476 RID: 83062 RVA: 0x002F2E74 File Offset: 0x002F1074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014477 RID: 83063 RVA: 0x002F2E80 File Offset: 0x002F1080
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TeamTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04007B97 RID: 31639
		private static readonly MessageParser<RecentlyTeamInfo> _parser = new MessageParser<RecentlyTeamInfo>(() => new RecentlyTeamInfo());

		// Token: 0x04007B98 RID: 31640
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B99 RID: 31641
		public const int InfoFieldNumber = 1;

		// Token: 0x04007B9A RID: 31642
		private PlayerDetails info_;

		// Token: 0x04007B9B RID: 31643
		public const int TeamTimeFieldNumber = 2;

		// Token: 0x04007B9C RID: 31644
		private long teamTime_;
	}
}
