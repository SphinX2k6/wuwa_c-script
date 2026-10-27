using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049A RID: 1178
	[NetMessage(EMessageId.EntityIsVisibleNotify)]
	public sealed class EntityIsVisibleNotify : IMessage<EntityIsVisibleNotify>, IMessage, IEquatable<EntityIsVisibleNotify>, IDeepCloneable<EntityIsVisibleNotify>, IBufferMessage
	{
		// Token: 0x0600707C RID: 28796 RVA: 0x001140E4 File Offset: 0x001122E4
		[NullableContext(1)]
		public static EntityIsVisibleNotify Create()
		{
			return new EntityIsVisibleNotify();
		}

		// Token: 0x170015AC RID: 5548
		// (get) Token: 0x0600707D RID: 28797 RVA: 0x001140EB File Offset: 0x001122EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015AD RID: 5549
		// (get) Token: 0x0600707E RID: 28798 RVA: 0x001140EE File Offset: 0x001122EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityIsVisibleNotify.Descriptor;
			}
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x001140F5 File Offset: 0x001122F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify()
		{
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x00114100 File Offset: 0x00112300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify(EntityIsVisibleNotify other) : this()
		{
			this.id_ = other.id_;
			this.isVisible_ = other.isVisible_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x00114158 File Offset: 0x00112358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityIsVisibleNotify Clone()
		{
			return new EntityIsVisibleNotify(this);
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06007082 RID: 28802 RVA: 0x00114160 File Offset: 0x00112360
		// (set) Token: 0x06007083 RID: 28803 RVA: 0x00114168 File Offset: 0x00112368
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

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06007084 RID: 28804 RVA: 0x00114171 File Offset: 0x00112371
		// (set) Token: 0x06007085 RID: 28805 RVA: 0x00114179 File Offset: 0x00112379
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

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x06007086 RID: 28806 RVA: 0x00114182 File Offset: 0x00112382
		// (set) Token: 0x06007087 RID: 28807 RVA: 0x0011418A File Offset: 0x0011238A
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

		// Token: 0x06007088 RID: 28808 RVA: 0x00114193 File Offset: 0x00112393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityIsVisibleNotify);
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x001141A4 File Offset: 0x001123A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityIsVisibleNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsVisible == other.IsVisible && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x00114204 File Offset: 0x00112404
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

		// Token: 0x0600708B RID: 28811 RVA: 0x00114272 File Offset: 0x00112472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600708C RID: 28812 RVA: 0x0011427F File Offset: 0x0011247F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600708D RID: 28813 RVA: 0x00114288 File Offset: 0x00112488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsVisible);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600708E RID: 28814 RVA: 0x00114300 File Offset: 0x00112500
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

		// Token: 0x0600708F RID: 28815 RVA: 0x00114364 File Offset: 0x00112564
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

		// Token: 0x06007090 RID: 28816 RVA: 0x001143E0 File Offset: 0x001125E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007091 RID: 28817 RVA: 0x001143EC File Offset: 0x001125EC
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
					if (num != 48U)
					{
						if (num != 82U)
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
						this.IsVisible = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C3C RID: 15420
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C3D RID: 15421
		public const int IdFieldNumber = 4;

		// Token: 0x04003C3E RID: 15422
		private long id_;

		// Token: 0x04003C3F RID: 15423
		public const int IsVisibleFieldNumber = 6;

		// Token: 0x04003C40 RID: 15424
		private bool isVisible_;

		// Token: 0x04003C41 RID: 15425
		public const int CombatCommonFieldNumber = 10;

		// Token: 0x04003C42 RID: 15426
		private CombatCommon combatCommon_;
	}
}
