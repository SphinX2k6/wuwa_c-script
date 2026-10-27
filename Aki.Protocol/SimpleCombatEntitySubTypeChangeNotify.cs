using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001227 RID: 4647
	[NetMessage(EMessageId.SimpleCombatEntitySubTypeChangeNotify)]
	public sealed class SimpleCombatEntitySubTypeChangeNotify : IMessage<SimpleCombatEntitySubTypeChangeNotify>, IMessage, IEquatable<SimpleCombatEntitySubTypeChangeNotify>, IDeepCloneable<SimpleCombatEntitySubTypeChangeNotify>, IBufferMessage
	{
		// Token: 0x06018C43 RID: 101443 RVA: 0x0039AA8D File Offset: 0x00398C8D
		[NullableContext(1)]
		public static SimpleCombatEntitySubTypeChangeNotify Create()
		{
			return new SimpleCombatEntitySubTypeChangeNotify();
		}

		// Token: 0x1700537A RID: 21370
		// (get) Token: 0x06018C44 RID: 101444 RVA: 0x0039AA94 File Offset: 0x00398C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700537B RID: 21371
		// (get) Token: 0x06018C45 RID: 101445 RVA: 0x0039AA97 File Offset: 0x00398C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntitySubTypeChangeNotify.Descriptor;
			}
		}

		// Token: 0x06018C46 RID: 101446 RVA: 0x0039AA9E File Offset: 0x00398C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify()
		{
		}

		// Token: 0x06018C47 RID: 101447 RVA: 0x0039AAA8 File Offset: 0x00398CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify(SimpleCombatEntitySubTypeChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newComponentData_ = ((other.newComponentData_ != null) ? other.newComponentData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C48 RID: 101448 RVA: 0x0039AAF4 File Offset: 0x00398CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify Clone()
		{
			return new SimpleCombatEntitySubTypeChangeNotify(this);
		}

		// Token: 0x1700537C RID: 21372
		// (get) Token: 0x06018C49 RID: 101449 RVA: 0x0039AAFC File Offset: 0x00398CFC
		// (set) Token: 0x06018C4A RID: 101450 RVA: 0x0039AB04 File Offset: 0x00398D04
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

		// Token: 0x1700537D RID: 21373
		// (get) Token: 0x06018C4B RID: 101451 RVA: 0x0039AB0D File Offset: 0x00398D0D
		// (set) Token: 0x06018C4C RID: 101452 RVA: 0x0039AB15 File Offset: 0x00398D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb NewComponentData
		{
			get
			{
				return this.newComponentData_;
			}
			set
			{
				this.newComponentData_ = value;
			}
		}

		// Token: 0x06018C4D RID: 101453 RVA: 0x0039AB1E File Offset: 0x00398D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntitySubTypeChangeNotify);
		}

		// Token: 0x06018C4E RID: 101454 RVA: 0x0039AB2C File Offset: 0x00398D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntitySubTypeChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.NewComponentData, other.NewComponentData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C4F RID: 101455 RVA: 0x0039AB7C File Offset: 0x00398D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.newComponentData_ != null)
			{
				num ^= this.NewComponentData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C50 RID: 101456 RVA: 0x0039ABD1 File Offset: 0x00398DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C51 RID: 101457 RVA: 0x0039ABDE File Offset: 0x00398DDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C52 RID: 101458 RVA: 0x0039ABE8 File Offset: 0x00398DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C53 RID: 101459 RVA: 0x0039AC44 File Offset: 0x00398E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C54 RID: 101460 RVA: 0x0039AC9C File Offset: 0x00398E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntitySubTypeChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.newComponentData_ != null)
			{
				if (this.newComponentData_ == null)
				{
					this.NewComponentData = new SimpleCombatComponentPb();
				}
				this.NewComponentData.MergeFrom(other.NewComponentData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C55 RID: 101461 RVA: 0x0039AD04 File Offset: 0x00398F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C56 RID: 101462 RVA: 0x0039AD10 File Offset: 0x00398F10
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
				if (num != 72U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.newComponentData_ == null)
						{
							this.NewComponentData = new SimpleCombatComponentPb();
						}
						input.ReadMessage(this.NewComponentData);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009228 RID: 37416
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009229 RID: 37417
		public const int EntityIdFieldNumber = 9;

		// Token: 0x0400922A RID: 37418
		private long entityId_;

		// Token: 0x0400922B RID: 37419
		public const int NewComponentDataFieldNumber = 13;

		// Token: 0x0400922C RID: 37420
		private SimpleCombatComponentPb newComponentData_;
	}
}
