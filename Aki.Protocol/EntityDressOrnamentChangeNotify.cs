using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000484 RID: 1156
	[NetMessage(EMessageId.EntityDressOrnamentChangeNotify)]
	public sealed class EntityDressOrnamentChangeNotify : IMessage<EntityDressOrnamentChangeNotify>, IMessage, IEquatable<EntityDressOrnamentChangeNotify>, IDeepCloneable<EntityDressOrnamentChangeNotify>, IBufferMessage
	{
		// Token: 0x06006EAE RID: 28334 RVA: 0x0010FD08 File Offset: 0x0010DF08
		[NullableContext(1)]
		public static EntityDressOrnamentChangeNotify Create()
		{
			return new EntityDressOrnamentChangeNotify();
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06006EAF RID: 28335 RVA: 0x0010FD0F File Offset: 0x0010DF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x0010FD12 File Offset: 0x0010DF12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityDressOrnamentChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006EB1 RID: 28337 RVA: 0x0010FD19 File Offset: 0x0010DF19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify()
		{
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x0010FD24 File Offset: 0x0010DF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify(EntityDressOrnamentChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.ornamentComponentPb_ = ((other.ornamentComponentPb_ != null) ? other.ornamentComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x0010FD70 File Offset: 0x0010DF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityDressOrnamentChangeNotify Clone()
		{
			return new EntityDressOrnamentChangeNotify(this);
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x0010FD78 File Offset: 0x0010DF78
		// (set) Token: 0x06006EB5 RID: 28341 RVA: 0x0010FD80 File Offset: 0x0010DF80
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

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06006EB6 RID: 28342 RVA: 0x0010FD89 File Offset: 0x0010DF89
		// (set) Token: 0x06006EB7 RID: 28343 RVA: 0x0010FD91 File Offset: 0x0010DF91
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

		// Token: 0x06006EB8 RID: 28344 RVA: 0x0010FD9A File Offset: 0x0010DF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityDressOrnamentChangeNotify);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x0010FDA8 File Offset: 0x0010DFA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityDressOrnamentChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.OrnamentComponentPb, other.OrnamentComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0010FDF8 File Offset: 0x0010DFF8
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

		// Token: 0x06006EBB RID: 28347 RVA: 0x0010FE4D File Offset: 0x0010E04D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x0010FE5A File Offset: 0x0010E05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x0010FE64 File Offset: 0x0010E064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ornamentComponentPb_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.OrnamentComponentPb);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x0010FEC0 File Offset: 0x0010E0C0
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

		// Token: 0x06006EBF RID: 28351 RVA: 0x0010FF18 File Offset: 0x0010E118
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

		// Token: 0x06006EC0 RID: 28352 RVA: 0x0010FF80 File Offset: 0x0010E180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x0010FF8C File Offset: 0x0010E18C
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
				if (num != 34U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
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
		}

		// Token: 0x04003BB3 RID: 15283
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BB4 RID: 15284
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003BB5 RID: 15285
		private long entityId_;

		// Token: 0x04003BB6 RID: 15286
		public const int OrnamentComponentPbFieldNumber = 4;

		// Token: 0x04003BB7 RID: 15287
		private OrnamentComponentPb ornamentComponentPb_;
	}
}
