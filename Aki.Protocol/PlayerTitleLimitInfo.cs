using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB4 RID: 3508
	public sealed class PlayerTitleLimitInfo : IMessage<PlayerTitleLimitInfo>, IMessage, IEquatable<PlayerTitleLimitInfo>, IDeepCloneable<PlayerTitleLimitInfo>, IBufferMessage
	{
		// Token: 0x06012E73 RID: 77427 RVA: 0x002C20AA File Offset: 0x002C02AA
		[NullableContext(1)]
		public static PlayerTitleLimitInfo Create()
		{
			return new PlayerTitleLimitInfo();
		}

		// Token: 0x17003EC2 RID: 16066
		// (get) Token: 0x06012E74 RID: 77428 RVA: 0x002C20B1 File Offset: 0x002C02B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerTitleLimitInfo> Parser
		{
			get
			{
				return PlayerTitleLimitInfo._parser;
			}
		}

		// Token: 0x17003EC3 RID: 16067
		// (get) Token: 0x06012E75 RID: 77429 RVA: 0x002C20B8 File Offset: 0x002C02B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x06012E76 RID: 77430 RVA: 0x002C20BB File Offset: 0x002C02BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleLimitInfo.Descriptor;
			}
		}

		// Token: 0x06012E77 RID: 77431 RVA: 0x002C20C2 File Offset: 0x002C02C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo()
		{
		}

		// Token: 0x06012E78 RID: 77432 RVA: 0x002C20CA File Offset: 0x002C02CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo(PlayerTitleLimitInfo other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E79 RID: 77433 RVA: 0x002C2107 File Offset: 0x002C0307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo Clone()
		{
			return new PlayerTitleLimitInfo(this);
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x06012E7A RID: 77434 RVA: 0x002C210F File Offset: 0x002C030F
		// (set) Token: 0x06012E7B RID: 77435 RVA: 0x002C2117 File Offset: 0x002C0317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerTitleId
		{
			get
			{
				return this.playerTitleId_;
			}
			set
			{
				this.playerTitleId_ = value;
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x06012E7C RID: 77436 RVA: 0x002C2120 File Offset: 0x002C0320
		// (set) Token: 0x06012E7D RID: 77437 RVA: 0x002C2128 File Offset: 0x002C0328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x06012E7E RID: 77438 RVA: 0x002C2131 File Offset: 0x002C0331
		// (set) Token: 0x06012E7F RID: 77439 RVA: 0x002C2139 File Offset: 0x002C0339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x06012E80 RID: 77440 RVA: 0x002C2142 File Offset: 0x002C0342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleLimitInfo);
		}

		// Token: 0x06012E81 RID: 77441 RVA: 0x002C2150 File Offset: 0x002C0350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleLimitInfo other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E82 RID: 77442 RVA: 0x002C21AC File Offset: 0x002C03AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerTitleId != 0)
			{
				num ^= this.PlayerTitleId.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E83 RID: 77443 RVA: 0x002C221D File Offset: 0x002C041D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E84 RID: 77444 RVA: 0x002C222A File Offset: 0x002C042A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E85 RID: 77445 RVA: 0x002C2234 File Offset: 0x002C0434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerTitleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerTitleId);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E86 RID: 77446 RVA: 0x002C22A8 File Offset: 0x002C04A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerTitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerTitleId);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012E87 RID: 77447 RVA: 0x002C2318 File Offset: 0x002C0518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleLimitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerTitleId != 0)
			{
				this.PlayerTitleId = other.PlayerTitleId;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E88 RID: 77448 RVA: 0x002C237C File Offset: 0x002C057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E89 RID: 77449 RVA: 0x002C2388 File Offset: 0x002C0588
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.BeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.PlayerTitleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007501 RID: 29953
		private static readonly MessageParser<PlayerTitleLimitInfo> _parser = new MessageParser<PlayerTitleLimitInfo>(() => new PlayerTitleLimitInfo());

		// Token: 0x04007502 RID: 29954
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007503 RID: 29955
		public const int PlayerTitleIdFieldNumber = 1;

		// Token: 0x04007504 RID: 29956
		private int playerTitleId_;

		// Token: 0x04007505 RID: 29957
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04007506 RID: 29958
		private long beginTime_;

		// Token: 0x04007507 RID: 29959
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04007508 RID: 29960
		private long endTime_;
	}
}
