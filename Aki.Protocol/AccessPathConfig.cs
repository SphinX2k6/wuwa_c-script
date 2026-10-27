using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000052 RID: 82
	public sealed class AccessPathConfig : IMessage<AccessPathConfig>, IMessage, IEquatable<AccessPathConfig>, IDeepCloneable<AccessPathConfig>, IBufferMessage
	{
		// Token: 0x060014FD RID: 5373 RVA: 0x00037FD5 File Offset: 0x000361D5
		[NullableContext(1)]
		public static AccessPathConfig Create()
		{
			return new AccessPathConfig();
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x00037FDC File Offset: 0x000361DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AccessPathConfig> Parser
		{
			get
			{
				return AccessPathConfig._parser;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00037FE3 File Offset: 0x000361E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00037FE6 File Offset: 0x000361E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AccessPathConfig.Descriptor;
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00037FED File Offset: 0x000361ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig()
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00037FF5 File Offset: 0x000361F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig(AccessPathConfig other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00038032 File Offset: 0x00036232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AccessPathConfig Clone()
		{
			return new AccessPathConfig(this);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0003803A File Offset: 0x0003623A
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x00038042 File Offset: 0x00036242
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

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0003804B File Offset: 0x0003624B
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x00038053 File Offset: 0x00036253
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

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0003805C File Offset: 0x0003625C
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x00038064 File Offset: 0x00036264
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

		// Token: 0x0600150A RID: 5386 RVA: 0x0003806D File Offset: 0x0003626D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AccessPathConfig);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0003807C File Offset: 0x0003627C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AccessPathConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000380D8 File Offset: 0x000362D8
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

		// Token: 0x0600150D RID: 5389 RVA: 0x00038149 File Offset: 0x00036349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00038156 File Offset: 0x00036356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x00038160 File Offset: 0x00036360
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

		// Token: 0x06001510 RID: 5392 RVA: 0x000381D4 File Offset: 0x000363D4
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

		// Token: 0x06001511 RID: 5393 RVA: 0x00038244 File Offset: 0x00036444
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

		// Token: 0x06001512 RID: 5394 RVA: 0x000382A8 File Offset: 0x000364A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000382B4 File Offset: 0x000364B4
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

		// Token: 0x04002083 RID: 8323
		private static readonly MessageParser<AccessPathConfig> _parser = new MessageParser<AccessPathConfig>(() => new AccessPathConfig());

		// Token: 0x04002084 RID: 8324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002085 RID: 8325
		public const int IdFieldNumber = 1;

		// Token: 0x04002086 RID: 8326
		private int id_;

		// Token: 0x04002087 RID: 8327
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x04002088 RID: 8328
		private long beginTime_;

		// Token: 0x04002089 RID: 8329
		public const int EndTimeFieldNumber = 3;

		// Token: 0x0400208A RID: 8330
		private long endTime_;
	}
}
