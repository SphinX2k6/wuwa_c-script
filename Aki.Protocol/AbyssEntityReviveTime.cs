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
		// Token: 0x06001187 RID: 4487 RVA: 0x00030BA6 File Offset: 0x0002EDA6
		[NullableContext(1)]
		public static AbyssEntityReviveTime Create()
		{
			return new AbyssEntityReviveTime();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x00030BAD File Offset: 0x0002EDAD
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
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x00030BB4 File Offset: 0x0002EDB4
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
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x00030BB7 File Offset: 0x0002EDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssEntityReviveTime.Descriptor;
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00030BBE File Offset: 0x0002EDBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime()
		{
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00030BC6 File Offset: 0x0002EDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime(AbyssEntityReviveTime other) : this()
		{
			this.entityId_ = other.entityId_;
			this.reviveTime_ = other.reviveTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00030BF7 File Offset: 0x0002EDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssEntityReviveTime Clone()
		{
			return new AbyssEntityReviveTime(this);
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00030BFF File Offset: 0x0002EDFF
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00030C07 File Offset: 0x0002EE07
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
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00030C10 File Offset: 0x0002EE10
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x00030C18 File Offset: 0x0002EE18
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

		// Token: 0x06001192 RID: 4498 RVA: 0x00030C21 File Offset: 0x0002EE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssEntityReviveTime);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00030C2F File Offset: 0x0002EE2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssEntityReviveTime other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ReviveTime == other.ReviveTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00030C70 File Offset: 0x0002EE70
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

		// Token: 0x06001195 RID: 4501 RVA: 0x00030CC8 File Offset: 0x0002EEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00030CD5 File Offset: 0x0002EED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x00030CE0 File Offset: 0x0002EEE0
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

		// Token: 0x06001198 RID: 4504 RVA: 0x00030D38 File Offset: 0x0002EF38
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

		// Token: 0x06001199 RID: 4505 RVA: 0x00030D90 File Offset: 0x0002EF90
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

		// Token: 0x0600119A RID: 4506 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00030DEC File Offset: 0x0002EFEC
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

		// Token: 0x04001FC8 RID: 8136
		private static readonly MessageParser<AbyssEntityReviveTime> _parser = new MessageParser<AbyssEntityReviveTime>(() => new AbyssEntityReviveTime());

		// Token: 0x04001FC9 RID: 8137
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FCA RID: 8138
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04001FCB RID: 8139
		private long entityId_;

		// Token: 0x04001FCC RID: 8140
		public const int ReviveTimeFieldNumber = 2;

		// Token: 0x04001FCD RID: 8141
		private long reviveTime_;
	}
}
