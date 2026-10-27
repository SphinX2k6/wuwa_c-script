using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000004 RID: 4
	public sealed class ValidTimeItem : IProto_NormalItem, IMessage<ValidTimeItem>, IMessage, IEquatable<ValidTimeItem>, IDeepCloneable<ValidTimeItem>, IBufferMessage
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000023B6 File Offset: 0x000005B6
		[NullableContext(1)]
		public static ValidTimeItem Create()
		{
			return new ValidTimeItem();
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023BD File Offset: 0x000005BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ValidTimeItem> Parser
		{
			get
			{
				return ValidTimeItem._parser;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000023C4 File Offset: 0x000005C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000023C7 File Offset: 0x000005C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ValidTimeItem.Descriptor;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000023CE File Offset: 0x000005CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItem()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023D8 File Offset: 0x000005D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItem(ValidTimeItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.incrId_ = other.incrId_;
			this.expireTime_ = other.expireTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000242C File Offset: 0x0000062C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ValidTimeItem Clone()
		{
			return new ValidTimeItem(this);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002434 File Offset: 0x00000634
		// (set) Token: 0x06000024 RID: 36 RVA: 0x0000243C File Offset: 0x0000063C
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002445 File Offset: 0x00000645
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000244D File Offset: 0x0000064D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002456 File Offset: 0x00000656
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000245E File Offset: 0x0000065E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002467 File Offset: 0x00000667
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000246F File Offset: 0x0000066F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpireTime
		{
			get
			{
				return this.expireTime_;
			}
			set
			{
				this.expireTime_ = value;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002478 File Offset: 0x00000678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ValidTimeItem);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002488 File Offset: 0x00000688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ValidTimeItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.IncrId == other.IncrId && this.ExpireTime == other.ExpireTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000024F4 File Offset: 0x000006F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.ExpireTime != 0L)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000257E File Offset: 0x0000077E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000258B File Offset: 0x0000078B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002594 File Offset: 0x00000794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncrId);
			}
			if (this.ExpireTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ExpireTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002624 File Offset: 0x00000824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.ExpireTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpireTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000026AC File Offset: 0x000008AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ValidTimeItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.ExpireTime != 0L)
			{
				this.ExpireTime = other.ExpireTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002724 File Offset: 0x00000924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002730 File Offset: 0x00000930
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Count = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ExpireTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly MessageParser<ValidTimeItem> _parser = new MessageParser<ValidTimeItem>(() => new ValidTimeItem());

		// Token: 0x0400000A RID: 10
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400000B RID: 11
		public const int IdFieldNumber = 1;

		// Token: 0x0400000C RID: 12
		private int id_;

		// Token: 0x0400000D RID: 13
		public const int CountFieldNumber = 2;

		// Token: 0x0400000E RID: 14
		private int count_;

		// Token: 0x0400000F RID: 15
		public const int IncrIdFieldNumber = 3;

		// Token: 0x04000010 RID: 16
		private int incrId_;

		// Token: 0x04000011 RID: 17
		public const int ExpireTimeFieldNumber = 4;

		// Token: 0x04000012 RID: 18
		private long expireTime_;
	}
}
