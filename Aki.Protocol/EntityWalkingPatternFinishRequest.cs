using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004CD RID: 1229
	[NetMessage(EMessageId.EntityWalkingPatternFinishRequest)]
	public sealed class EntityWalkingPatternFinishRequest : IMessage<EntityWalkingPatternFinishRequest>, IMessage, IEquatable<EntityWalkingPatternFinishRequest>, IDeepCloneable<EntityWalkingPatternFinishRequest>, IBufferMessage
	{
		// Token: 0x060074CE RID: 29902 RVA: 0x0011E392 File Offset: 0x0011C592
		[NullableContext(1)]
		public static EntityWalkingPatternFinishRequest Create()
		{
			return new EntityWalkingPatternFinishRequest();
		}

		// Token: 0x170016A4 RID: 5796
		// (get) Token: 0x060074CF RID: 29903 RVA: 0x0011E399 File Offset: 0x0011C599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170016A5 RID: 5797
		// (get) Token: 0x060074D0 RID: 29904 RVA: 0x0011E39C File Offset: 0x0011C59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityWalkingPatternFinishRequest.Descriptor;
			}
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x0011E3A3 File Offset: 0x0011C5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest()
		{
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x0011E3AB File Offset: 0x0011C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest(EntityWalkingPatternFinishRequest other) : this()
		{
			this.hostPlayerId_ = other.hostPlayerId_;
			this.entityId_ = other.entityId_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x0011E3E8 File Offset: 0x0011C5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityWalkingPatternFinishRequest Clone()
		{
			return new EntityWalkingPatternFinishRequest(this);
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x060074D4 RID: 29908 RVA: 0x0011E3F0 File Offset: 0x0011C5F0
		// (set) Token: 0x060074D5 RID: 29909 RVA: 0x0011E3F8 File Offset: 0x0011C5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HostPlayerId
		{
			get
			{
				return this.hostPlayerId_;
			}
			set
			{
				this.hostPlayerId_ = value;
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x0011E401 File Offset: 0x0011C601
		// (set) Token: 0x060074D7 RID: 29911 RVA: 0x0011E409 File Offset: 0x0011C609
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

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x0011E412 File Offset: 0x0011C612
		// (set) Token: 0x060074D9 RID: 29913 RVA: 0x0011E41A File Offset: 0x0011C61A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x0011E423 File Offset: 0x0011C623
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityWalkingPatternFinishRequest);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x0011E434 File Offset: 0x0011C634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityWalkingPatternFinishRequest other)
		{
			return other != null && (other == this || (this.HostPlayerId == other.HostPlayerId && this.EntityId == other.EntityId && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x0011E490 File Offset: 0x0011C690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HostPlayerId != 0)
			{
				num ^= this.HostPlayerId.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x0011E501 File Offset: 0x0011C701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x0011E50E File Offset: 0x0011C70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x0011E518 File Offset: 0x0011C718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.HostPlayerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.HostPlayerId);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x0011E590 File Offset: 0x0011C790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HostPlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HostPlayerId);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x0011E600 File Offset: 0x0011C800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityWalkingPatternFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HostPlayerId != 0)
			{
				this.HostPlayerId = other.HostPlayerId;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x0011E664 File Offset: 0x0011C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x0011E670 File Offset: 0x0011C870
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
				if (num != 96U)
				{
					if (num != 104U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Point = input.ReadInt32();
						}
					}
					else
					{
						this.HostPlayerId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003D88 RID: 15752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D89 RID: 15753
		public const int HostPlayerIdFieldNumber = 13;

		// Token: 0x04003D8A RID: 15754
		private int hostPlayerId_;

		// Token: 0x04003D8B RID: 15755
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003D8C RID: 15756
		private long entityId_;

		// Token: 0x04003D8D RID: 15757
		public const int PointFieldNumber = 15;

		// Token: 0x04003D8E RID: 15758
		private int point_;
	}
}
