using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA4 RID: 3492
	public sealed class PlayerTitleLimitInfo : IMessage<PlayerTitleLimitInfo>, IMessage, IEquatable<PlayerTitleLimitInfo>, IDeepCloneable<PlayerTitleLimitInfo>, IBufferMessage
	{
		// Token: 0x06012D77 RID: 77175 RVA: 0x002C0486 File Offset: 0x002BE686
		[NullableContext(1)]
		public static PlayerTitleLimitInfo Create()
		{
			return new PlayerTitleLimitInfo();
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x06012D78 RID: 77176 RVA: 0x002C048D File Offset: 0x002BE68D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerTitleLimitInfo> Parser
		{
			get
			{
				return PlayerTitleLimitInfo._parser;
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x06012D79 RID: 77177 RVA: 0x002C0494 File Offset: 0x002BE694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x06012D7A RID: 77178 RVA: 0x002C0497 File Offset: 0x002BE697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleLimitInfo.Descriptor;
			}
		}

		// Token: 0x06012D7B RID: 77179 RVA: 0x002C049E File Offset: 0x002BE69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo()
		{
		}

		// Token: 0x06012D7C RID: 77180 RVA: 0x002C04A6 File Offset: 0x002BE6A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo(PlayerTitleLimitInfo other) : this()
		{
			this.playerTitleId_ = other.playerTitleId_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D7D RID: 77181 RVA: 0x002C04E3 File Offset: 0x002BE6E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleLimitInfo Clone()
		{
			return new PlayerTitleLimitInfo(this);
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x06012D7E RID: 77182 RVA: 0x002C04EB File Offset: 0x002BE6EB
		// (set) Token: 0x06012D7F RID: 77183 RVA: 0x002C04F3 File Offset: 0x002BE6F3
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

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x06012D80 RID: 77184 RVA: 0x002C04FC File Offset: 0x002BE6FC
		// (set) Token: 0x06012D81 RID: 77185 RVA: 0x002C0504 File Offset: 0x002BE704
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

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x06012D82 RID: 77186 RVA: 0x002C050D File Offset: 0x002BE70D
		// (set) Token: 0x06012D83 RID: 77187 RVA: 0x002C0515 File Offset: 0x002BE715
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

		// Token: 0x06012D84 RID: 77188 RVA: 0x002C051E File Offset: 0x002BE71E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleLimitInfo);
		}

		// Token: 0x06012D85 RID: 77189 RVA: 0x002C052C File Offset: 0x002BE72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleLimitInfo other)
		{
			return other != null && (other == this || (this.PlayerTitleId == other.PlayerTitleId && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D86 RID: 77190 RVA: 0x002C0588 File Offset: 0x002BE788
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

		// Token: 0x06012D87 RID: 77191 RVA: 0x002C05F9 File Offset: 0x002BE7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D88 RID: 77192 RVA: 0x002C0606 File Offset: 0x002BE806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D89 RID: 77193 RVA: 0x002C0610 File Offset: 0x002BE810
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

		// Token: 0x06012D8A RID: 77194 RVA: 0x002C0684 File Offset: 0x002BE884
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

		// Token: 0x06012D8B RID: 77195 RVA: 0x002C06F4 File Offset: 0x002BE8F4
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

		// Token: 0x06012D8C RID: 77196 RVA: 0x002C0758 File Offset: 0x002BE958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D8D RID: 77197 RVA: 0x002C0764 File Offset: 0x002BE964
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

		// Token: 0x04007519 RID: 29977
		private static readonly MessageParser<PlayerTitleLimitInfo> _parser = new MessageParser<PlayerTitleLimitInfo>(() => new PlayerTitleLimitInfo());

		// Token: 0x0400751A RID: 29978
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400751B RID: 29979
		public const int PlayerTitleIdFieldNumber = 1;

		// Token: 0x0400751C RID: 29980
		private int playerTitleId_;

		// Token: 0x0400751D RID: 29981
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x0400751E RID: 29982
		private long beginTime_;

		// Token: 0x0400751F RID: 29983
		public const int EndTimeFieldNumber = 3;

		// Token: 0x04007520 RID: 29984
		private long endTime_;
	}
}
