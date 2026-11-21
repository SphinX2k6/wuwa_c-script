using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047F RID: 1151
	[NetMessage(EMessageId.EntityHonamiStoryEnhanceLevelNotify)]
	public sealed class EntityHonamiStoryEnhanceLevelNotify : IMessage<EntityHonamiStoryEnhanceLevelNotify>, IMessage, IEquatable<EntityHonamiStoryEnhanceLevelNotify>, IDeepCloneable<EntityHonamiStoryEnhanceLevelNotify>, IBufferMessage
	{
		// Token: 0x06006E9C RID: 28316 RVA: 0x0011051D File Offset: 0x0010E71D
		[NullableContext(1)]
		public static EntityHonamiStoryEnhanceLevelNotify Create()
		{
			return new EntityHonamiStoryEnhanceLevelNotify();
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x00110524 File Offset: 0x0010E724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x00110527 File Offset: 0x0010E727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityHonamiStoryEnhanceLevelNotify.Descriptor;
			}
		}

		// Token: 0x06006E9F RID: 28319 RVA: 0x0011052E File Offset: 0x0010E72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify()
		{
		}

		// Token: 0x06006EA0 RID: 28320 RVA: 0x00110538 File Offset: 0x0010E738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify(EntityHonamiStoryEnhanceLevelNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.honamiStoryEnhanceLevelComponentPb_ = ((other.honamiStoryEnhanceLevelComponentPb_ != null) ? other.honamiStoryEnhanceLevelComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EA1 RID: 28321 RVA: 0x00110584 File Offset: 0x0010E784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHonamiStoryEnhanceLevelNotify Clone()
		{
			return new EntityHonamiStoryEnhanceLevelNotify(this);
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x0011058C File Offset: 0x0010E78C
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x00110594 File Offset: 0x0010E794
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

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x0011059D File Offset: 0x0010E79D
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x001105A5 File Offset: 0x0010E7A5
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

		// Token: 0x06006EA6 RID: 28326 RVA: 0x001105AE File Offset: 0x0010E7AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityHonamiStoryEnhanceLevelNotify);
		}

		// Token: 0x06006EA7 RID: 28327 RVA: 0x001105BC File Offset: 0x0010E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityHonamiStoryEnhanceLevelNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.HonamiStoryEnhanceLevelComponentPb, other.HonamiStoryEnhanceLevelComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EA8 RID: 28328 RVA: 0x0011060C File Offset: 0x0010E80C
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

		// Token: 0x06006EA9 RID: 28329 RVA: 0x00110661 File Offset: 0x0010E861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x0011066E File Offset: 0x0010E86E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x00110678 File Offset: 0x0010E878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.honamiStoryEnhanceLevelComponentPb_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.HonamiStoryEnhanceLevelComponentPb);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x001106D4 File Offset: 0x0010E8D4
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

		// Token: 0x06006EAD RID: 28333 RVA: 0x0011072C File Offset: 0x0010E92C
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

		// Token: 0x06006EAE RID: 28334 RVA: 0x00110794 File Offset: 0x0010E994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EAF RID: 28335 RVA: 0x001107A0 File Offset: 0x0010E9A0
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
					if (num != 48U)
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

		// Token: 0x04003C14 RID: 15380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C15 RID: 15381
		public const int EntityIdFieldNumber = 6;

		// Token: 0x04003C16 RID: 15382
		private long entityId_;

		// Token: 0x04003C17 RID: 15383
		public const int HonamiStoryEnhanceLevelComponentPbFieldNumber = 4;

		// Token: 0x04003C18 RID: 15384
		private HonamiStoryEnhanceLevelComponentPb honamiStoryEnhanceLevelComponentPb_;
	}
}
