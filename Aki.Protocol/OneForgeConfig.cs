using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B78 RID: 2936
	public sealed class OneForgeConfig : IMessage<OneForgeConfig>, IMessage, IEquatable<OneForgeConfig>, IDeepCloneable<OneForgeConfig>, IBufferMessage
	{
		// Token: 0x0600FEF2 RID: 65266 RVA: 0x00253A2E File Offset: 0x00251C2E
		[NullableContext(1)]
		public static OneForgeConfig Create()
		{
			return new OneForgeConfig();
		}

		// Token: 0x1700341A RID: 13338
		// (get) Token: 0x0600FEF3 RID: 65267 RVA: 0x00253A35 File Offset: 0x00251C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneForgeConfig> Parser
		{
			get
			{
				return OneForgeConfig._parser;
			}
		}

		// Token: 0x1700341B RID: 13339
		// (get) Token: 0x0600FEF4 RID: 65268 RVA: 0x00253A3C File Offset: 0x00251C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600FEF5 RID: 65269 RVA: 0x00253A3F File Offset: 0x00251C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneForgeConfig.Descriptor;
			}
		}

		// Token: 0x0600FEF6 RID: 65270 RVA: 0x00253A46 File Offset: 0x00251C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig()
		{
		}

		// Token: 0x0600FEF7 RID: 65271 RVA: 0x00253A4E File Offset: 0x00251C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig(OneForgeConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FEF8 RID: 65272 RVA: 0x00253A8B File Offset: 0x00251C8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneForgeConfig Clone()
		{
			return new OneForgeConfig(this);
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600FEF9 RID: 65273 RVA: 0x00253A93 File Offset: 0x00251C93
		// (set) Token: 0x0600FEFA RID: 65274 RVA: 0x00253A9B File Offset: 0x00251C9B
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

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600FEFB RID: 65275 RVA: 0x00253AA4 File Offset: 0x00251CA4
		// (set) Token: 0x0600FEFC RID: 65276 RVA: 0x00253AAC File Offset: 0x00251CAC
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

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600FEFD RID: 65277 RVA: 0x00253AB5 File Offset: 0x00251CB5
		// (set) Token: 0x0600FEFE RID: 65278 RVA: 0x00253ABD File Offset: 0x00251CBD
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

		// Token: 0x0600FEFF RID: 65279 RVA: 0x00253AC6 File Offset: 0x00251CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneForgeConfig);
		}

		// Token: 0x0600FF00 RID: 65280 RVA: 0x00253AD4 File Offset: 0x00251CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneForgeConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF01 RID: 65281 RVA: 0x00253B30 File Offset: 0x00251D30
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

		// Token: 0x0600FF02 RID: 65282 RVA: 0x00253BA1 File Offset: 0x00251DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF03 RID: 65283 RVA: 0x00253BAE File Offset: 0x00251DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF04 RID: 65284 RVA: 0x00253BB8 File Offset: 0x00251DB8
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

		// Token: 0x0600FF05 RID: 65285 RVA: 0x00253C2C File Offset: 0x00251E2C
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

		// Token: 0x0600FF06 RID: 65286 RVA: 0x00253C9C File Offset: 0x00251E9C
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

		// Token: 0x0600FF07 RID: 65287 RVA: 0x00253D00 File Offset: 0x00251F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF08 RID: 65288 RVA: 0x00253D0C File Offset: 0x00251F0C
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

		// Token: 0x04006610 RID: 26128
		private static readonly MessageParser<OneForgeConfig> _parser = new MessageParser<OneForgeConfig>(() => new OneForgeConfig());

		// Token: 0x04006611 RID: 26129
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006612 RID: 26130
		public const int IdFieldNumber = 1;

		// Token: 0x04006613 RID: 26131
		private int id_;

		// Token: 0x04006614 RID: 26132
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x04006615 RID: 26133
		private long limitBeginTime_;

		// Token: 0x04006616 RID: 26134
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x04006617 RID: 26135
		private long limitEndTime_;
	}
}
