using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000484 RID: 1156
	[NetMessage(EMessageId.EntityIsVisiblePush)]
	public sealed class EntityIsVisiblePush : IMessage<EntityIsVisiblePush>, IMessage, IEquatable<EntityIsVisiblePush>, IDeepCloneable<EntityIsVisiblePush>, IBufferMessage
	{
		// Token: 0x06006F04 RID: 28420 RVA: 0x001113F1 File Offset: 0x0010F5F1
		[NullableContext(1)]
		public static EntityIsVisiblePush Create()
		{
			return new EntityIsVisiblePush();
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x06006F05 RID: 28421 RVA: 0x001113F8 File Offset: 0x0010F5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x001113FB File Offset: 0x0010F5FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisiblePush.Descriptor;
			}
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x00111402 File Offset: 0x0010F602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush()
		{
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x0011140C File Offset: 0x0010F60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush(EntityIsVisiblePush other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x00111464 File Offset: 0x0010F664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush Clone()
		{
			return new EntityIsVisiblePush(this);
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x06006F0A RID: 28426 RVA: 0x0011146C File Offset: 0x0010F66C
		// (set) Token: 0x06006F0B RID: 28427 RVA: 0x00111474 File Offset: 0x0010F674
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

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06006F0C RID: 28428 RVA: 0x0011147D File Offset: 0x0010F67D
		// (set) Token: 0x06006F0D RID: 28429 RVA: 0x00111485 File Offset: 0x0010F685
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

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06006F0E RID: 28430 RVA: 0x0011148E File Offset: 0x0010F68E
		// (set) Token: 0x06006F0F RID: 28431 RVA: 0x00111496 File Offset: 0x0010F696
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

		// Token: 0x06006F10 RID: 28432 RVA: 0x0011149F File Offset: 0x0010F69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisiblePush);
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x001114B0 File Offset: 0x0010F6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisiblePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00111510 File Offset: 0x0010F710
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

		// Token: 0x06006F13 RID: 28435 RVA: 0x0011157E File Offset: 0x0010F77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x0011158B File Offset: 0x0010F78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x00111594 File Offset: 0x0010F794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsVisible)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsVisible);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x0011160C File Offset: 0x0010F80C
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

		// Token: 0x06006F17 RID: 28439 RVA: 0x00111670 File Offset: 0x0010F870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityIsVisiblePush other)
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

		// Token: 0x06006F18 RID: 28440 RVA: 0x001116EC File Offset: 0x0010F8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F19 RID: 28441 RVA: 0x001116F8 File Offset: 0x0010F8F8
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
					if (num != 96U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.IsVisible = input.ReadBool();
				}
			}
		}

		// Token: 0x04003C31 RID: 15409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C32 RID: 15410
		public const int IdFieldNumber = 12;

		// Token: 0x04003C33 RID: 15411
		private long id_;

		// Token: 0x04003C34 RID: 15412
		public const int IsVisibleFieldNumber = 4;

		// Token: 0x04003C35 RID: 15413
		private bool isVisible_;

		// Token: 0x04003C36 RID: 15414
		public const int CombatCommonFieldNumber = 13;

		// Token: 0x04003C37 RID: 15415
		private CombatCommon combatCommon_;
	}
}
