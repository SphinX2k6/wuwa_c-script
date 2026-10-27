using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000496 RID: 1174
	[NetMessage(EMessageId.EntityHonamiStoryEnhanceLevelNotify)]
	public sealed class EntityHonamiStoryEnhanceLevelNotify : IMessage<EntityHonamiStoryEnhanceLevelNotify>, IMessage, IEquatable<EntityHonamiStoryEnhanceLevelNotify>, IDeepCloneable<EntityHonamiStoryEnhanceLevelNotify>, IBufferMessage
	{
		// Token: 0x0600702A RID: 28714 RVA: 0x00113591 File Offset: 0x00111791
		[NullableContext(1)]
		public static EntityHonamiStoryEnhanceLevelNotify Create()
		{
			return new EntityHonamiStoryEnhanceLevelNotify();
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x00113598 File Offset: 0x00111798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x0600702C RID: 28716 RVA: 0x0011359B File Offset: 0x0011179B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityHonamiStoryEnhanceLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x001135A2 File Offset: 0x001117A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify()
		{
		}

		// Token: 0x0600702E RID: 28718 RVA: 0x001135AC File Offset: 0x001117AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify(EntityHonamiStoryEnhanceLevelNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.honamiStoryEnhanceLevelComponentPb_ = ((other.honamiStoryEnhanceLevelComponentPb_ != null) ? other.honamiStoryEnhanceLevelComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600702F RID: 28719 RVA: 0x001135F8 File Offset: 0x001117F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify Clone()
		{
			return new EntityHonamiStoryEnhanceLevelNotify(this);
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x06007030 RID: 28720 RVA: 0x00113600 File Offset: 0x00111800
		// (set) Token: 0x06007031 RID: 28721 RVA: 0x00113608 File Offset: 0x00111808
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

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x06007032 RID: 28722 RVA: 0x00113611 File Offset: 0x00111811
		// (set) Token: 0x06007033 RID: 28723 RVA: 0x00113619 File Offset: 0x00111819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryEnhanceLevelComponentPb HonamiStoryEnhanceLevelComponentPb
		{
			get
			{
				return this.honamiStoryEnhanceLevelComponentPb_;
			}
			set
			{
				this.honamiStoryEnhanceLevelComponentPb_ = value;
			}
		}

		// Token: 0x06007034 RID: 28724 RVA: 0x00113622 File Offset: 0x00111822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityHonamiStoryEnhanceLevelNotify);
		}

		// Token: 0x06007035 RID: 28725 RVA: 0x00113630 File Offset: 0x00111830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityHonamiStoryEnhanceLevelNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.HonamiStoryEnhanceLevelComponentPb, other.HonamiStoryEnhanceLevelComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007036 RID: 28726 RVA: 0x00113680 File Offset: 0x00111880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.honamiStoryEnhanceLevelComponentPb_ != null)
			{
				num ^= this.HonamiStoryEnhanceLevelComponentPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007037 RID: 28727 RVA: 0x001136D5 File Offset: 0x001118D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x001136E2 File Offset: 0x001118E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x001136EC File Offset: 0x001118EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryEnhanceLevelComponentPb_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.HonamiStoryEnhanceLevelComponentPb);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x00113748 File Offset: 0x00111948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.honamiStoryEnhanceLevelComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryEnhanceLevelComponentPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x001137A0 File Offset: 0x001119A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityHonamiStoryEnhanceLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.honamiStoryEnhanceLevelComponentPb_ != null)
			{
				if (this.honamiStoryEnhanceLevelComponentPb_ == null)
				{
					this.HonamiStoryEnhanceLevelComponentPb = new HonamiStoryEnhanceLevelComponentPb();
				}
				this.HonamiStoryEnhanceLevelComponentPb.MergeFrom(other.HonamiStoryEnhanceLevelComponentPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x00113808 File Offset: 0x00111A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x00113814 File Offset: 0x00111A14
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
				if (num != 90U)
				{
					if (num != 104U)
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
					if (this.honamiStoryEnhanceLevelComponentPb_ == null)
					{
						this.HonamiStoryEnhanceLevelComponentPb = new HonamiStoryEnhanceLevelComponentPb();
					}
					input.ReadMessage(this.HonamiStoryEnhanceLevelComponentPb);
				}
			}
		}

		// Token: 0x04003C26 RID: 15398
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C27 RID: 15399
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003C28 RID: 15400
		private long entityId_;

		// Token: 0x04003C29 RID: 15401
		public const int HonamiStoryEnhanceLevelComponentPbFieldNumber = 11;

		// Token: 0x04003C2A RID: 15402
		private HonamiStoryEnhanceLevelComponentPb honamiStoryEnhanceLevelComponentPb_;
	}
}
