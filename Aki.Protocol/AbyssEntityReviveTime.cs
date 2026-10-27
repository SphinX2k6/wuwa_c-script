using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000024 RID: 36
	public sealed class AbyssEntityReviveTime : IMessage<AbyssEntityReviveTime>, IMessage, IEquatable<AbyssEntityReviveTime>, IDeepCloneable<AbyssEntityReviveTime>, IBufferMessage
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x000305F2 File Offset: 0x0002E7F2
		[NullableContext(1)]
		public static AbyssEntityReviveTime Create()
		{
			return new AbyssEntityReviveTime();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x000305F9 File Offset: 0x0002E7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssEntityReviveTime> Parser
		{
			get
			{
				return AbyssEntityReviveTime._parser;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x00030600 File Offset: 0x0002E800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x00030603 File Offset: 0x0002E803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssEntityReviveTime.Descriptor;
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0003060A File Offset: 0x0002E80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime()
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00030612 File Offset: 0x0002E812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime(AbyssEntityReviveTime other) : this()
		{
			this.entityId_ = other.entityId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00030643 File Offset: 0x0002E843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime Clone()
		{
			return new AbyssEntityReviveTime(this);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0003064B File Offset: 0x0002E84B
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x00030653 File Offset: 0x0002E853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x0003065C File Offset: 0x0002E85C
		// (set) Token: 0x06001166 RID: 4454 RVA: 0x00030664 File Offset: 0x0002E864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ReviveTime
		{
			get
			{
				return this.reviveTime_;
			}
			set
			{
				this.reviveTime_ = value;
			}
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0003066D File Offset: 0x0002E86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssEntityReviveTime);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0003067B File Offset: 0x0002E87B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssEntityReviveTime other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000306BC File Offset: 0x0002E8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ReviveTime != 0L)
			{
				num ^= this.ReviveTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00030714 File Offset: 0x0002E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00030721 File Offset: 0x0002E921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x0003072C File Offset: 0x0002E92C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.ReviveTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ReviveTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00030784 File Offset: 0x0002E984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ReviveTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ReviveTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x000307DC File Offset: 0x0002E9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssEntityReviveTime other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ReviveTime != 0L)
			{
				this.ReviveTime = other.ReviveTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0003082C File Offset: 0x0002EA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00030838 File Offset: 0x0002EA38
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
						this.ReviveTime = input.ReadInt64();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04001F72 RID: 8050
		private static readonly MessageParser<AbyssEntityReviveTime> _parser = new MessageParser<AbyssEntityReviveTime>(() => new AbyssEntityReviveTime());

		// Token: 0x04001F73 RID: 8051
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F74 RID: 8052
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04001F75 RID: 8053
		private long entityId_;

		// Token: 0x04001F76 RID: 8054
		public const int ReviveTimeFieldNumber = 2;

		// Token: 0x04001F77 RID: 8055
		private long reviveTime_;
	}
}
