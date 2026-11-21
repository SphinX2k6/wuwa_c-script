using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046D RID: 1133
	[NetMessage(EMessageId.EntityDressOrnamentChangeNotify)]
	public sealed class EntityDressOrnamentChangeNotify : IMessage<EntityDressOrnamentChangeNotify>, IMessage, IEquatable<EntityDressOrnamentChangeNotify>, IDeepCloneable<EntityDressOrnamentChangeNotify>, IBufferMessage
	{
		// Token: 0x06006D20 RID: 27936 RVA: 0x0010CC94 File Offset: 0x0010AE94
		[NullableContext(1)]
		public static EntityDressOrnamentChangeNotify Create()
		{
			return new EntityDressOrnamentChangeNotify();
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06006D21 RID: 27937 RVA: 0x0010CC9B File Offset: 0x0010AE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06006D22 RID: 27938 RVA: 0x0010CC9E File Offset: 0x0010AE9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDressOrnamentChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006D23 RID: 27939 RVA: 0x0010CCA5 File Offset: 0x0010AEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify()
		{
		}

		// Token: 0x06006D24 RID: 27940 RVA: 0x0010CCB0 File Offset: 0x0010AEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify(EntityDressOrnamentChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.ornamentComponentPb_ = ((other.ornamentComponentPb_ != null) ? other.ornamentComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D25 RID: 27941 RVA: 0x0010CCFC File Offset: 0x0010AEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify Clone()
		{
			return new EntityDressOrnamentChangeNotify(this);
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06006D26 RID: 27942 RVA: 0x0010CD04 File Offset: 0x0010AF04
		// (set) Token: 0x06006D27 RID: 27943 RVA: 0x0010CD0C File Offset: 0x0010AF0C
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

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06006D28 RID: 27944 RVA: 0x0010CD15 File Offset: 0x0010AF15
		// (set) Token: 0x06006D29 RID: 27945 RVA: 0x0010CD1D File Offset: 0x0010AF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OrnamentComponentPb OrnamentComponentPb
		{
			get
			{
				return this.ornamentComponentPb_;
			}
			set
			{
				this.ornamentComponentPb_ = value;
			}
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x0010CD26 File Offset: 0x0010AF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDressOrnamentChangeNotify);
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x0010CD34 File Offset: 0x0010AF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDressOrnamentChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.OrnamentComponentPb, other.OrnamentComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x0010CD84 File Offset: 0x0010AF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ornamentComponentPb_ != null)
			{
				num ^= this.OrnamentComponentPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x0010CDD9 File Offset: 0x0010AFD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x0010CDE6 File Offset: 0x0010AFE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x0010CDF0 File Offset: 0x0010AFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.ornamentComponentPb_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.OrnamentComponentPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x0010CE4C File Offset: 0x0010B04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ornamentComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OrnamentComponentPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x0010CEA4 File Offset: 0x0010B0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityDressOrnamentChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ornamentComponentPb_ != null)
			{
				if (this.ornamentComponentPb_ == null)
				{
					this.OrnamentComponentPb = new OrnamentComponentPb();
				}
				this.OrnamentComponentPb.MergeFrom(other.OrnamentComponentPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x0010CF0C File Offset: 0x0010B10C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x0010CF18 File Offset: 0x0010B118
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
				if (num != 32U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.ornamentComponentPb_ == null)
						{
							this.OrnamentComponentPb = new OrnamentComponentPb();
						}
						input.ReadMessage(this.OrnamentComponentPb);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003BA1 RID: 15265
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BA2 RID: 15266
		public const int EntityIdFieldNumber = 4;

		// Token: 0x04003BA3 RID: 15267
		private long entityId_;

		// Token: 0x04003BA4 RID: 15268
		public const int OrnamentComponentPbFieldNumber = 14;

		// Token: 0x04003BA5 RID: 15269
		private OrnamentComponentPb ornamentComponentPb_;
	}
}
