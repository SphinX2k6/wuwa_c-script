using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B88 RID: 2952
	public sealed class OneForgeConfig : IMessage<OneForgeConfig>, IMessage, IEquatable<OneForgeConfig>, IDeepCloneable<OneForgeConfig>, IBufferMessage
	{
		// Token: 0x0600FFF6 RID: 65526 RVA: 0x002558FE File Offset: 0x00253AFE
		[NullableContext(1)]
		public static OneForgeConfig Create()
		{
			return new OneForgeConfig();
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600FFF7 RID: 65527 RVA: 0x00255905 File Offset: 0x00253B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneForgeConfig> Parser
		{
			get
			{
				return OneForgeConfig._parser;
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600FFF8 RID: 65528 RVA: 0x0025590C File Offset: 0x00253B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600FFF9 RID: 65529 RVA: 0x0025590F File Offset: 0x00253B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneForgeConfig.Descriptor;
			}
		}

		// Token: 0x0600FFFA RID: 65530 RVA: 0x00255916 File Offset: 0x00253B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig()
		{
		}

		// Token: 0x0600FFFB RID: 65531 RVA: 0x0025591E File Offset: 0x00253B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig(OneForgeConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFFC RID: 65532 RVA: 0x0025595B File Offset: 0x00253B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig Clone()
		{
			return new OneForgeConfig(this);
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600FFFD RID: 65533 RVA: 0x00255963 File Offset: 0x00253B63
		// (set) Token: 0x0600FFFE RID: 65534 RVA: 0x0025596B File Offset: 0x00253B6B
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

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600FFFF RID: 65535 RVA: 0x00255974 File Offset: 0x00253B74
		// (set) Token: 0x06010000 RID: 65536 RVA: 0x0025597C File Offset: 0x00253B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x06010001 RID: 65537 RVA: 0x00255985 File Offset: 0x00253B85
		// (set) Token: 0x06010002 RID: 65538 RVA: 0x0025598D File Offset: 0x00253B8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x06010003 RID: 65539 RVA: 0x00255996 File Offset: 0x00253B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneForgeConfig);
		}

		// Token: 0x06010004 RID: 65540 RVA: 0x002559A4 File Offset: 0x00253BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneForgeConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010005 RID: 65541 RVA: 0x00255A00 File Offset: 0x00253C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010006 RID: 65542 RVA: 0x00255A71 File Offset: 0x00253C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010007 RID: 65543 RVA: 0x00255A7E File Offset: 0x00253C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010008 RID: 65544 RVA: 0x00255A88 File Offset: 0x00253C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010009 RID: 65545 RVA: 0x00255AFC File Offset: 0x00253CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601000A RID: 65546 RVA: 0x00255B6C File Offset: 0x00253D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneForgeConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601000B RID: 65547 RVA: 0x00255BD0 File Offset: 0x00253DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601000C RID: 65548 RVA: 0x00255BDC File Offset: 0x00253DDC
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
							this.LimitEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.LimitBeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006600 RID: 26112
		private static readonly MessageParser<OneForgeConfig> _parser = new MessageParser<OneForgeConfig>(() => new OneForgeConfig());

		// Token: 0x04006601 RID: 26113
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006602 RID: 26114
		public const int IdFieldNumber = 1;

		// Token: 0x04006603 RID: 26115
		private int id_;

		// Token: 0x04006604 RID: 26116
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x04006605 RID: 26117
		private long limitBeginTime_;

		// Token: 0x04006606 RID: 26118
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x04006607 RID: 26119
		private long limitEndTime_;
	}
}
