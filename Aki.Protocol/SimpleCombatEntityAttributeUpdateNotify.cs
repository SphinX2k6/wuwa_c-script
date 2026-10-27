using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001221 RID: 4641
	[NetMessage(EMessageId.SimpleCombatEntityAttributeUpdateNotify)]
	public sealed class SimpleCombatEntityAttributeUpdateNotify : IMessage<SimpleCombatEntityAttributeUpdateNotify>, IMessage, IEquatable<SimpleCombatEntityAttributeUpdateNotify>, IDeepCloneable<SimpleCombatEntityAttributeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06018BA5 RID: 101285 RVA: 0x003986D9 File Offset: 0x003968D9
		[NullableContext(1)]
		public static SimpleCombatEntityAttributeUpdateNotify Create()
		{
			return new SimpleCombatEntityAttributeUpdateNotify();
		}

		// Token: 0x1700534F RID: 21327
		// (get) Token: 0x06018BA6 RID: 101286 RVA: 0x003986E0 File Offset: 0x003968E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005350 RID: 21328
		// (get) Token: 0x06018BA7 RID: 101287 RVA: 0x003986E3 File Offset: 0x003968E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityAttributeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06018BA8 RID: 101288 RVA: 0x003986EA File Offset: 0x003968EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify()
		{
		}

		// Token: 0x06018BA9 RID: 101289 RVA: 0x003986F4 File Offset: 0x003968F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify(SimpleCombatEntityAttributeUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.attributePbInfo_ = ((other.attributePbInfo_ != null) ? other.attributePbInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BAA RID: 101290 RVA: 0x00398740 File Offset: 0x00396940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributeUpdateNotify Clone()
		{
			return new SimpleCombatEntityAttributeUpdateNotify(this);
		}

		// Token: 0x17005351 RID: 21329
		// (get) Token: 0x06018BAB RID: 101291 RVA: 0x00398748 File Offset: 0x00396948
		// (set) Token: 0x06018BAC RID: 101292 RVA: 0x00398750 File Offset: 0x00396950
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

		// Token: 0x17005352 RID: 21330
		// (get) Token: 0x06018BAD RID: 101293 RVA: 0x00398759 File Offset: 0x00396959
		// (set) Token: 0x06018BAE RID: 101294 RVA: 0x00398761 File Offset: 0x00396961
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

		// Token: 0x06018BAF RID: 101295 RVA: 0x0039876A File Offset: 0x0039696A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityAttributeUpdateNotify);
		}

		// Token: 0x06018BB0 RID: 101296 RVA: 0x00398778 File Offset: 0x00396978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityAttributeUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.AttributePbInfo, other.AttributePbInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BB1 RID: 101297 RVA: 0x003987C8 File Offset: 0x003969C8
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

		// Token: 0x06018BB2 RID: 101298 RVA: 0x0039881D File Offset: 0x00396A1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BB3 RID: 101299 RVA: 0x0039882A File Offset: 0x00396A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BB4 RID: 101300 RVA: 0x00398834 File Offset: 0x00396A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.attributePbInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AttributePbInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018BB5 RID: 101301 RVA: 0x00398890 File Offset: 0x00396A90
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

		// Token: 0x06018BB6 RID: 101302 RVA: 0x003988E8 File Offset: 0x00396AE8
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

		// Token: 0x06018BB7 RID: 101303 RVA: 0x00398950 File Offset: 0x00396B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BB8 RID: 101304 RVA: 0x0039895C File Offset: 0x00396B5C
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
				if (num != 88U)
				{
					if (num != 114U)
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

		// Token: 0x040091F6 RID: 37366
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091F7 RID: 37367
		public const int EntityIdFieldNumber = 11;

		// Token: 0x040091F8 RID: 37368
		private long entityId_;

		// Token: 0x040091F9 RID: 37369
		public const int AttributePbInfoFieldNumber = 14;

		// Token: 0x040091FA RID: 37370
		private SimpleCombatEntityAttributePbInfo attributePbInfo_;
	}
}
