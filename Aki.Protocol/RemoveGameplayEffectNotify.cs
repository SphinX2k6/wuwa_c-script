using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF8 RID: 3832
	[NetMessage(EMessageId.RemoveGameplayEffectNotify)]
	public sealed class RemoveGameplayEffectNotify : IMessage<RemoveGameplayEffectNotify>, IMessage, IEquatable<RemoveGameplayEffectNotify>, IDeepCloneable<RemoveGameplayEffectNotify>, IBufferMessage
	{
		// Token: 0x0601487E RID: 84094 RVA: 0x002FB921 File Offset: 0x002F9B21
		[NullableContext(1)]
		public static RemoveGameplayEffectNotify Create()
		{
			return new RemoveGameplayEffectNotify();
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x0601487F RID: 84095 RVA: 0x002FB928 File Offset: 0x002F9B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x06014880 RID: 84096 RVA: 0x002FB92B File Offset: 0x002F9B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveGameplayEffectNotify.Descriptor;
			}
		}

		// Token: 0x06014881 RID: 84097 RVA: 0x002FB932 File Offset: 0x002F9B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify()
		{
		}

		// Token: 0x06014882 RID: 84098 RVA: 0x002FB93A File Offset: 0x002F9B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify(RemoveGameplayEffectNotify other) : this()
		{
			this.handle_ = other.handle_;
			this.entityId_ = other.entityId_;
			this.instigatorId_ = other.instigatorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014883 RID: 84099 RVA: 0x002FB977 File Offset: 0x002F9B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveGameplayEffectNotify Clone()
		{
			return new RemoveGameplayEffectNotify(this);
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x06014884 RID: 84100 RVA: 0x002FB97F File Offset: 0x002F9B7F
		// (set) Token: 0x06014885 RID: 84101 RVA: 0x002FB987 File Offset: 0x002F9B87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x06014886 RID: 84102 RVA: 0x002FB990 File Offset: 0x002F9B90
		// (set) Token: 0x06014887 RID: 84103 RVA: 0x002FB998 File Offset: 0x002F9B98
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

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x06014888 RID: 84104 RVA: 0x002FB9A1 File Offset: 0x002F9BA1
		// (set) Token: 0x06014889 RID: 84105 RVA: 0x002FB9A9 File Offset: 0x002F9BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InstigatorId
		{
			get
			{
				return this.instigatorId_;
			}
			set
			{
				this.instigatorId_ = value;
			}
		}

		// Token: 0x0601488A RID: 84106 RVA: 0x002FB9B2 File Offset: 0x002F9BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveGameplayEffectNotify);
		}

		// Token: 0x0601488B RID: 84107 RVA: 0x002FB9C0 File Offset: 0x002F9BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveGameplayEffectNotify other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.EntityId == other.EntityId && this.InstigatorId == other.InstigatorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601488C RID: 84108 RVA: 0x002FBA1C File Offset: 0x002F9C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.InstigatorId != 0L)
			{
				num ^= this.InstigatorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601488D RID: 84109 RVA: 0x002FBA8D File Offset: 0x002F9C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601488E RID: 84110 RVA: 0x002FBA9A File Offset: 0x002F9C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601488F RID: 84111 RVA: 0x002FBAA4 File Offset: 0x002F9CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.Handle != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Handle);
			}
			if (this.InstigatorId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014890 RID: 84112 RVA: 0x002FBB1C File Offset: 0x002F9D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.InstigatorId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InstigatorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014891 RID: 84113 RVA: 0x002FBB8C File Offset: 0x002F9D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveGameplayEffectNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.InstigatorId != 0L)
			{
				this.InstigatorId = other.InstigatorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014892 RID: 84114 RVA: 0x002FBBF0 File Offset: 0x002F9DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014893 RID: 84115 RVA: 0x002FBBFC File Offset: 0x002F9DFC
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
				if (num != 40U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstigatorId = input.ReadInt64();
						}
					}
					else
					{
						this.Handle = input.ReadInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007C72 RID: 31858
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C73 RID: 31859
		public const int HandleFieldNumber = 13;

		// Token: 0x04007C74 RID: 31860
		private int handle_;

		// Token: 0x04007C75 RID: 31861
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04007C76 RID: 31862
		private long entityId_;

		// Token: 0x04007C77 RID: 31863
		public const int InstigatorIdFieldNumber = 14;

		// Token: 0x04007C78 RID: 31864
		private long instigatorId_;
	}
}
