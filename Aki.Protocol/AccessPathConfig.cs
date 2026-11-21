using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000053 RID: 83
	public sealed class AccessPathConfig : IMessage<AccessPathConfig>, IMessage, IEquatable<AccessPathConfig>, IDeepCloneable<AccessPathConfig>, IBufferMessage
	{
		// Token: 0x06001540 RID: 5440 RVA: 0x00038979 File Offset: 0x00036B79
		[NullableContext(1)]
		public static AccessPathConfig Create()
		{
			return new AccessPathConfig();
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00038980 File Offset: 0x00036B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccessPathConfig> Parser
		{
			get
			{
				return AccessPathConfig._parser;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x00038987 File Offset: 0x00036B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0003898A File Offset: 0x00036B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfig.Descriptor;
			}
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x00038991 File Offset: 0x00036B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig()
		{
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x00038999 File Offset: 0x00036B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig(AccessPathConfig other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x000389D6 File Offset: 0x00036BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig Clone()
		{
			return new AccessPathConfig(this);
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000389DE File Offset: 0x00036BDE
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x000389E6 File Offset: 0x00036BE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x000389EF File Offset: 0x00036BEF
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x000389F7 File Offset: 0x00036BF7
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

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x00038A00 File Offset: 0x00036C00
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x00038A08 File Offset: 0x00036C08
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

		// Token: 0x0600154D RID: 5453 RVA: 0x00038A11 File Offset: 0x00036C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfig);
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00038A20 File Offset: 0x00036C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00038A7C File Offset: 0x00036C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
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

		// Token: 0x06001550 RID: 5456 RVA: 0x00038AED File Offset: 0x00036CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00038AFA File Offset: 0x00036CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x00038B04 File Offset: 0x00036D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
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

		// Token: 0x06001553 RID: 5459 RVA: 0x00038B78 File Offset: 0x00036D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
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

		// Token: 0x06001554 RID: 5460 RVA: 0x00038BE8 File Offset: 0x00036DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AccessPathConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
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

		// Token: 0x06001555 RID: 5461 RVA: 0x00038C4C File Offset: 0x00036E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00038C58 File Offset: 0x00036E58
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040020E2 RID: 8418
		private static readonly MessageParser<AccessPathConfig> _parser = new MessageParser<AccessPathConfig>(() => new AccessPathConfig());

		// Token: 0x040020E3 RID: 8419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020E4 RID: 8420
		public const int IdFieldNumber = 1;

		// Token: 0x040020E5 RID: 8421
		private int id_;

		// Token: 0x040020E6 RID: 8422
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x040020E7 RID: 8423
		private long beginTime_;

		// Token: 0x040020E8 RID: 8424
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040020E9 RID: 8425
		private long endTime_;
	}
}
