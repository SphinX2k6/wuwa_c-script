using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125D RID: 4701
	[NetMessage(EMessageId.SimpleCombatEntityAttributeUpdateNotify)]
	public sealed class SimpleCombatEntityAttributeUpdateNotify : IMessage<SimpleCombatEntityAttributeUpdateNotify>, IMessage, IEquatable<SimpleCombatEntityAttributeUpdateNotify>, IDeepCloneable<SimpleCombatEntityAttributeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601917F RID: 102783 RVA: 0x003A8581 File Offset: 0x003A6781
		[NullableContext(1)]
		public static SimpleCombatEntityAttributeUpdateNotify Create()
		{
			return new SimpleCombatEntityAttributeUpdateNotify();
		}

		// Token: 0x170054CC RID: 21708
		// (get) Token: 0x06019180 RID: 102784 RVA: 0x003A8588 File Offset: 0x003A6788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054CD RID: 21709
		// (get) Token: 0x06019181 RID: 102785 RVA: 0x003A858B File Offset: 0x003A678B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityAttributeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06019182 RID: 102786 RVA: 0x003A8592 File Offset: 0x003A6792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify()
		{
		}

		// Token: 0x06019183 RID: 102787 RVA: 0x003A859C File Offset: 0x003A679C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify(SimpleCombatEntityAttributeUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.attributePbInfo_ = ((other.attributePbInfo_ != null) ? other.attributePbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019184 RID: 102788 RVA: 0x003A85E8 File Offset: 0x003A67E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify Clone()
		{
			return new SimpleCombatEntityAttributeUpdateNotify(this);
		}

		// Token: 0x170054CE RID: 21710
		// (get) Token: 0x06019185 RID: 102789 RVA: 0x003A85F0 File Offset: 0x003A67F0
		// (set) Token: 0x06019186 RID: 102790 RVA: 0x003A85F8 File Offset: 0x003A67F8
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

		// Token: 0x170054CF RID: 21711
		// (get) Token: 0x06019187 RID: 102791 RVA: 0x003A8601 File Offset: 0x003A6801
		// (set) Token: 0x06019188 RID: 102792 RVA: 0x003A8609 File Offset: 0x003A6809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo AttributePbInfo
		{
			get
			{
				return this.attributePbInfo_;
			}
			set
			{
				this.attributePbInfo_ = value;
			}
		}

		// Token: 0x06019189 RID: 102793 RVA: 0x003A8612 File Offset: 0x003A6812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityAttributeUpdateNotify);
		}

		// Token: 0x0601918A RID: 102794 RVA: 0x003A8620 File Offset: 0x003A6820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityAttributeUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AttributePbInfo, other.AttributePbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601918B RID: 102795 RVA: 0x003A8670 File Offset: 0x003A6870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.attributePbInfo_ != null)
			{
				num ^= this.AttributePbInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601918C RID: 102796 RVA: 0x003A86C5 File Offset: 0x003A68C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601918D RID: 102797 RVA: 0x003A86D2 File Offset: 0x003A68D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601918E RID: 102798 RVA: 0x003A86DC File Offset: 0x003A68DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityId);
			}
			if (this.attributePbInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AttributePbInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601918F RID: 102799 RVA: 0x003A8738 File Offset: 0x003A6938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.attributePbInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttributePbInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019190 RID: 102800 RVA: 0x003A8790 File Offset: 0x003A6990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityAttributeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.attributePbInfo_ != null)
			{
				if (this.attributePbInfo_ == null)
				{
					this.AttributePbInfo = new SimpleCombatEntityAttributePbInfo();
				}
				this.AttributePbInfo.MergeFrom(other.AttributePbInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019191 RID: 102801 RVA: 0x003A87F8 File Offset: 0x003A69F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019192 RID: 102802 RVA: 0x003A8804 File Offset: 0x003A6A04
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
				if (num != 48U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.attributePbInfo_ == null)
						{
							this.AttributePbInfo = new SimpleCombatEntityAttributePbInfo();
						}
						input.ReadMessage(this.AttributePbInfo);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040094A7 RID: 38055
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094A8 RID: 38056
		public const int EntityIdFieldNumber = 6;

		// Token: 0x040094A9 RID: 38057
		private long entityId_;

		// Token: 0x040094AA RID: 38058
		public const int AttributePbInfoFieldNumber = 15;

		// Token: 0x040094AB RID: 38059
		private SimpleCombatEntityAttributePbInfo attributePbInfo_;
	}
}
