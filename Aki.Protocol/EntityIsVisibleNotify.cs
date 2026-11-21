using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000483 RID: 1155
	[NetMessage(EMessageId.EntityIsVisibleNotify)]
	public sealed class EntityIsVisibleNotify : IMessage<EntityIsVisibleNotify>, IMessage, IEquatable<EntityIsVisibleNotify>, IDeepCloneable<EntityIsVisibleNotify>, IBufferMessage
	{
		// Token: 0x06006EEE RID: 28398 RVA: 0x00111070 File Offset: 0x0010F270
		[NullableContext(1)]
		public static EntityIsVisibleNotify Create()
		{
			return new EntityIsVisibleNotify();
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06006EEF RID: 28399 RVA: 0x00111077 File Offset: 0x0010F277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x0011107A File Offset: 0x0010F27A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleNotify.Descriptor;
			}
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x00111081 File Offset: 0x0010F281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify()
		{
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x0011108C File Offset: 0x0010F28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify(EntityIsVisibleNotify other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x001110E4 File Offset: 0x0010F2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify Clone()
		{
			return new EntityIsVisibleNotify(this);
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06006EF4 RID: 28404 RVA: 0x001110EC File Offset: 0x0010F2EC
		// (set) Token: 0x06006EF5 RID: 28405 RVA: 0x001110F4 File Offset: 0x0010F2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
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

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x001110FD File Offset: 0x0010F2FD
		// (set) Token: 0x06006EF7 RID: 28407 RVA: 0x00111105 File Offset: 0x0010F305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisible
		{
			get
			{
				return this.isVisible_;
			}
			set
			{
				this.isVisible_ = value;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x0011110E File Offset: 0x0010F30E
		// (set) Token: 0x06006EF9 RID: 28409 RVA: 0x00111116 File Offset: 0x0010F316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x0011111F File Offset: 0x0010F31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleNotify);
		}

		// Token: 0x06006EFB RID: 28411 RVA: 0x00111130 File Offset: 0x0010F330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x00111190 File Offset: 0x0010F390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x001111FE File Offset: 0x0010F3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x0011120B File Offset: 0x0010F40B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EFF RID: 28415 RVA: 0x00111214 File Offset: 0x0010F414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F00 RID: 28416 RVA: 0x00111288 File Offset: 0x0010F488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.IsVisible)
			{
				num += 2;
			}
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x001112EC File Offset: 0x0010F4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityIsVisibleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x00111368 File Offset: 0x0010F568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00111374 File Offset: 0x0010F574
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
					if (num != 66U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsVisible = input.ReadBool();
						}
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C2A RID: 15402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C2B RID: 15403
		public const int IdFieldNumber = 1;

		// Token: 0x04003C2C RID: 15404
		private long id_;

		// Token: 0x04003C2D RID: 15405
		public const int IsVisibleFieldNumber = 10;

		// Token: 0x04003C2E RID: 15406
		private bool isVisible_;

		// Token: 0x04003C2F RID: 15407
		public const int CombatCommonFieldNumber = 8;

		// Token: 0x04003C30 RID: 15408
		private CombatCommon combatCommon_;
	}
}
