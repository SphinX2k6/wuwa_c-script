using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001228 RID: 4648
	[NetMessage(EMessageId.SimpleCombatEntitySyncAttributePush)]
	public sealed class SimpleCombatEntitySyncAttributePush : IMessage<SimpleCombatEntitySyncAttributePush>, IMessage, IEquatable<SimpleCombatEntitySyncAttributePush>, IDeepCloneable<SimpleCombatEntitySyncAttributePush>, IBufferMessage
	{
		// Token: 0x06018C57 RID: 101463 RVA: 0x0039AD7B File Offset: 0x00398F7B
		[NullableContext(1)]
		public static SimpleCombatEntitySyncAttributePush Create()
		{
			return new SimpleCombatEntitySyncAttributePush();
		}

		// Token: 0x1700537E RID: 21374
		// (get) Token: 0x06018C58 RID: 101464 RVA: 0x0039AD82 File Offset: 0x00398F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700537F RID: 21375
		// (get) Token: 0x06018C59 RID: 101465 RVA: 0x0039AD85 File Offset: 0x00398F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntitySyncAttributePush.Descriptor;
			}
		}

		// Token: 0x06018C5A RID: 101466 RVA: 0x0039AD8C File Offset: 0x00398F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush()
		{
		}

		// Token: 0x06018C5B RID: 101467 RVA: 0x0039AD9F File Offset: 0x00398F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush(SimpleCombatEntitySyncAttributePush other) : this()
		{
			this.entityAttributeMap_ = other.entityAttributeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018C5C RID: 101468 RVA: 0x0039ADC9 File Offset: 0x00398FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush Clone()
		{
			return new SimpleCombatEntitySyncAttributePush(this);
		}

		// Token: 0x17005380 RID: 21376
		// (get) Token: 0x06018C5D RID: 101469 RVA: 0x0039ADD1 File Offset: 0x00398FD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, SimpleCombatEntityAttributePbInfo> EntityAttributeMap
		{
			get
			{
				return this.entityAttributeMap_;
			}
		}

		// Token: 0x06018C5E RID: 101470 RVA: 0x0039ADD9 File Offset: 0x00398FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntitySyncAttributePush);
		}

		// Token: 0x06018C5F RID: 101471 RVA: 0x0039ADE7 File Offset: 0x00398FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntitySyncAttributePush other)
		{
			return other != null && (other == this || (this.EntityAttributeMap.Equals(other.EntityAttributeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018C60 RID: 101472 RVA: 0x0039AE1C File Offset: 0x0039901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.EntityAttributeMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018C61 RID: 101473 RVA: 0x0039AE50 File Offset: 0x00399050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018C62 RID: 101474 RVA: 0x0039AE5D File Offset: 0x0039905D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018C63 RID: 101475 RVA: 0x0039AE66 File Offset: 0x00399066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityAttributeMap_.WriteTo(ref output, SimpleCombatEntitySyncAttributePush._map_entityAttributeMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018C64 RID: 101476 RVA: 0x0039AE90 File Offset: 0x00399090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityAttributeMap_.CalculateSize(SimpleCombatEntitySyncAttributePush._map_entityAttributeMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018C65 RID: 101477 RVA: 0x0039AEC9 File Offset: 0x003990C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntitySyncAttributePush other)
		{
			if (other == null)
			{
				return;
			}
			this.entityAttributeMap_.MergeFrom(other.entityAttributeMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018C66 RID: 101478 RVA: 0x0039AEF7 File Offset: 0x003990F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018C67 RID: 101479 RVA: 0x0039AF00 File Offset: 0x00399100
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityAttributeMap_.AddEntriesFrom(ref input, SimpleCombatEntitySyncAttributePush._map_entityAttributeMap_codec);
				}
			}
		}

		// Token: 0x0400922D RID: 37421
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400922E RID: 37422
		public const int EntityAttributeMapFieldNumber = 6;

		// Token: 0x0400922F RID: 37423
		private static readonly MapField<long, SimpleCombatEntityAttributePbInfo>.Codec _map_entityAttributeMap_codec = new MapField<long, SimpleCombatEntityAttributePbInfo>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForMessage<SimpleCombatEntityAttributePbInfo>(18U, SimpleCombatEntityAttributePbInfo.Parser), 50U);

		// Token: 0x04009230 RID: 37424
		private readonly MapField<long, SimpleCombatEntityAttributePbInfo> entityAttributeMap_ = new MapField<long, SimpleCombatEntityAttributePbInfo>();
	}
}
