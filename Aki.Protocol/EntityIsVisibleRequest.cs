using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000485 RID: 1157
	[NetMessage(EMessageId.EntityIsVisibleRequest)]
	public sealed class EntityIsVisibleRequest : IMessage<EntityIsVisibleRequest>, IMessage, IEquatable<EntityIsVisibleRequest>, IDeepCloneable<EntityIsVisibleRequest>, IBufferMessage
	{
		// Token: 0x06006F1A RID: 28442 RVA: 0x00111776 File Offset: 0x0010F976
		[NullableContext(1)]
		public static EntityIsVisibleRequest Create()
		{
			return new EntityIsVisibleRequest();
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06006F1B RID: 28443 RVA: 0x0011177D File Offset: 0x0010F97D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x00111780 File Offset: 0x0010F980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleRequest.Descriptor;
			}
		}

		// Token: 0x06006F1D RID: 28445 RVA: 0x00111787 File Offset: 0x0010F987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest()
		{
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00111790 File Offset: 0x0010F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest(EntityIsVisibleRequest other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x001117E8 File Offset: 0x0010F9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest Clone()
		{
			return new EntityIsVisibleRequest(this);
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x001117F0 File Offset: 0x0010F9F0
		// (set) Token: 0x06006F21 RID: 28449 RVA: 0x001117F8 File Offset: 0x0010F9F8
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

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00111801 File Offset: 0x0010FA01
		// (set) Token: 0x06006F23 RID: 28451 RVA: 0x00111809 File Offset: 0x0010FA09
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

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06006F24 RID: 28452 RVA: 0x00111812 File Offset: 0x0010FA12
		// (set) Token: 0x06006F25 RID: 28453 RVA: 0x0011181A File Offset: 0x0010FA1A
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

		// Token: 0x06006F26 RID: 28454 RVA: 0x00111823 File Offset: 0x0010FA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleRequest);
		}

		// Token: 0x06006F27 RID: 28455 RVA: 0x00111834 File Offset: 0x0010FA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F28 RID: 28456 RVA: 0x00111894 File Offset: 0x0010FA94
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

		// Token: 0x06006F29 RID: 28457 RVA: 0x00111902 File Offset: 0x0010FB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x0011190F File Offset: 0x0010FB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00111918 File Offset: 0x0010FB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00111990 File Offset: 0x0010FB90
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

		// Token: 0x06006F2D RID: 28461 RVA: 0x001119F4 File Offset: 0x0010FBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityIsVisibleRequest other)
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

		// Token: 0x06006F2E RID: 28462 RVA: 0x00111A70 File Offset: 0x0010FC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00111A7C File Offset: 0x0010FC7C
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
				if (num != 16U)
				{
					if (num != 34U)
					{
						if (num != 72U)
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

		// Token: 0x04003C38 RID: 15416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C39 RID: 15417
		public const int IdFieldNumber = 2;

		// Token: 0x04003C3A RID: 15418
		private long id_;

		// Token: 0x04003C3B RID: 15419
		public const int IsVisibleFieldNumber = 9;

		// Token: 0x04003C3C RID: 15420
		private bool isVisible_;

		// Token: 0x04003C3D RID: 15421
		public const int CombatCommonFieldNumber = 4;

		// Token: 0x04003C3E RID: 15422
		private CombatCommon combatCommon_;
	}
}
