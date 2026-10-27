using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049B RID: 1179
	[NetMessage(EMessageId.EntityIsVisiblePush)]
	public sealed class EntityIsVisiblePush : IMessage<EntityIsVisiblePush>, IMessage, IEquatable<EntityIsVisiblePush>, IDeepCloneable<EntityIsVisiblePush>, IBufferMessage
	{
		// Token: 0x06007092 RID: 28818 RVA: 0x0011446A File Offset: 0x0011266A
		[NullableContext(1)]
		public static EntityIsVisiblePush Create()
		{
			return new EntityIsVisiblePush();
		}

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x06007093 RID: 28819 RVA: 0x00114471 File Offset: 0x00112671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x06007094 RID: 28820 RVA: 0x00114474 File Offset: 0x00112674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisiblePush.Descriptor;
			}
		}

		// Token: 0x06007095 RID: 28821 RVA: 0x0011447B File Offset: 0x0011267B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush()
		{
		}

		// Token: 0x06007096 RID: 28822 RVA: 0x00114484 File Offset: 0x00112684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush(EntityIsVisiblePush other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x001144DC File Offset: 0x001126DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisiblePush Clone()
		{
			return new EntityIsVisiblePush(this);
		}

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x06007098 RID: 28824 RVA: 0x001144E4 File Offset: 0x001126E4
		// (set) Token: 0x06007099 RID: 28825 RVA: 0x001144EC File Offset: 0x001126EC
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

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x0600709A RID: 28826 RVA: 0x001144F5 File Offset: 0x001126F5
		// (set) Token: 0x0600709B RID: 28827 RVA: 0x001144FD File Offset: 0x001126FD
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

		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600709C RID: 28828 RVA: 0x00114506 File Offset: 0x00112706
		// (set) Token: 0x0600709D RID: 28829 RVA: 0x0011450E File Offset: 0x0011270E
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

		// Token: 0x0600709E RID: 28830 RVA: 0x00114517 File Offset: 0x00112717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisiblePush);
		}

		// Token: 0x0600709F RID: 28831 RVA: 0x00114528 File Offset: 0x00112728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisiblePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070A0 RID: 28832 RVA: 0x00114588 File Offset: 0x00112788
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

		// Token: 0x060070A1 RID: 28833 RVA: 0x001145F6 File Offset: 0x001127F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070A2 RID: 28834 RVA: 0x00114603 File Offset: 0x00112803
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070A3 RID: 28835 RVA: 0x0011460C File Offset: 0x0011280C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x00114684 File Offset: 0x00112884
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

		// Token: 0x060070A5 RID: 28837 RVA: 0x001146E8 File Offset: 0x001128E8
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

		// Token: 0x060070A6 RID: 28838 RVA: 0x00114764 File Offset: 0x00112964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070A7 RID: 28839 RVA: 0x00114770 File Offset: 0x00112970
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
				if (num != 18U)
				{
					if (num != 48U)
					{
						if (num != 104U)
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
		}

		// Token: 0x04003C43 RID: 15427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C44 RID: 15428
		public const int IdFieldNumber = 6;

		// Token: 0x04003C45 RID: 15429
		private long id_;

		// Token: 0x04003C46 RID: 15430
		public const int IsVisibleFieldNumber = 13;

		// Token: 0x04003C47 RID: 15431
		private bool isVisible_;

		// Token: 0x04003C48 RID: 15432
		public const int CombatCommonFieldNumber = 2;

		// Token: 0x04003C49 RID: 15433
		private CombatCommon combatCommon_;
	}
}
