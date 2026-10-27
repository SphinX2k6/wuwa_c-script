using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049C RID: 1180
	[NetMessage(EMessageId.EntityIsVisibleRequest)]
	public sealed class EntityIsVisibleRequest : IMessage<EntityIsVisibleRequest>, IMessage, IEquatable<EntityIsVisibleRequest>, IDeepCloneable<EntityIsVisibleRequest>, IBufferMessage
	{
		// Token: 0x060070A8 RID: 28840 RVA: 0x001147EE File Offset: 0x001129EE
		[NullableContext(1)]
		public static EntityIsVisibleRequest Create()
		{
			return new EntityIsVisibleRequest();
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x060070A9 RID: 28841 RVA: 0x001147F5 File Offset: 0x001129F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x001147F8 File Offset: 0x001129F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleRequest.Descriptor;
			}
		}

		// Token: 0x060070AB RID: 28843 RVA: 0x001147FF File Offset: 0x001129FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest()
		{
		}

		// Token: 0x060070AC RID: 28844 RVA: 0x00114808 File Offset: 0x00112A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest(EntityIsVisibleRequest other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070AD RID: 28845 RVA: 0x00114860 File Offset: 0x00112A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleRequest Clone()
		{
			return new EntityIsVisibleRequest(this);
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x00114868 File Offset: 0x00112A68
		// (set) Token: 0x060070AF RID: 28847 RVA: 0x00114870 File Offset: 0x00112A70
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

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x060070B0 RID: 28848 RVA: 0x00114879 File Offset: 0x00112A79
		// (set) Token: 0x060070B1 RID: 28849 RVA: 0x00114881 File Offset: 0x00112A81
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x060070B2 RID: 28850 RVA: 0x0011488A File Offset: 0x00112A8A
		// (set) Token: 0x060070B3 RID: 28851 RVA: 0x00114892 File Offset: 0x00112A92
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

		// Token: 0x060070B4 RID: 28852 RVA: 0x0011489B File Offset: 0x00112A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleRequest);
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x001148AC File Offset: 0x00112AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0011490C File Offset: 0x00112B0C
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

		// Token: 0x060070B7 RID: 28855 RVA: 0x0011497A File Offset: 0x00112B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00114987 File Offset: 0x00112B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00114990 File Offset: 0x00112B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsVisible)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsVisible);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00114A08 File Offset: 0x00112C08
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

		// Token: 0x060070BB RID: 28859 RVA: 0x00114A6C File Offset: 0x00112C6C
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

		// Token: 0x060070BC RID: 28860 RVA: 0x00114AE8 File Offset: 0x00112CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x00114AF4 File Offset: 0x00112CF4
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
					if (num != 58U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Id = input.ReadInt64();
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
					this.IsVisible = input.ReadBool();
				}
			}
		}

		// Token: 0x04003C4A RID: 15434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C4B RID: 15435
		public const int IdFieldNumber = 9;

		// Token: 0x04003C4C RID: 15436
		private long id_;

		// Token: 0x04003C4D RID: 15437
		public const int IsVisibleFieldNumber = 4;

		// Token: 0x04003C4E RID: 15438
		private bool isVisible_;

		// Token: 0x04003C4F RID: 15439
		public const int CombatCommonFieldNumber = 7;

		// Token: 0x04003C50 RID: 15440
		private CombatCommon combatCommon_;
	}
}
