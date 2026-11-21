using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001264 RID: 4708
	[NetMessage(EMessageId.SimpleCombatEntitySyncAttributePush)]
	public sealed class SimpleCombatEntitySyncAttributePush : IMessage<SimpleCombatEntitySyncAttributePush>, IMessage, IEquatable<SimpleCombatEntitySyncAttributePush>, IDeepCloneable<SimpleCombatEntitySyncAttributePush>, IBufferMessage
	{
		// Token: 0x06019231 RID: 102961 RVA: 0x003AAC23 File Offset: 0x003A8E23
		[NullableContext(1)]
		public static SimpleCombatEntitySyncAttributePush Create()
		{
			return new SimpleCombatEntitySyncAttributePush();
		}

		// Token: 0x170054FB RID: 21755
		// (get) Token: 0x06019232 RID: 102962 RVA: 0x003AAC2A File Offset: 0x003A8E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054FC RID: 21756
		// (get) Token: 0x06019233 RID: 102963 RVA: 0x003AAC2D File Offset: 0x003A8E2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntitySyncAttributePush.Descriptor;
			}
		}

		// Token: 0x06019234 RID: 102964 RVA: 0x003AAC34 File Offset: 0x003A8E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush()
		{
		}

		// Token: 0x06019235 RID: 102965 RVA: 0x003AAC47 File Offset: 0x003A8E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush(SimpleCombatEntitySyncAttributePush other) : this()
		{
			this.entityAttributeMap_ = other.entityAttributeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019236 RID: 102966 RVA: 0x003AAC71 File Offset: 0x003A8E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySyncAttributePush Clone()
		{
			return new SimpleCombatEntitySyncAttributePush(this);
		}

		// Token: 0x170054FD RID: 21757
		// (get) Token: 0x06019237 RID: 102967 RVA: 0x003AAC79 File Offset: 0x003A8E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<long, SimpleCombatEntityAttributePbInfo> EntityAttributeMap
		{
			get
			{
				return this.entityAttributeMap_;
			}
		}

		// Token: 0x06019238 RID: 102968 RVA: 0x003AAC81 File Offset: 0x003A8E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntitySyncAttributePush);
		}

		// Token: 0x06019239 RID: 102969 RVA: 0x003AAC8F File Offset: 0x003A8E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntitySyncAttributePush other)
		{
			return other != null && (other == this || (this.EntityAttributeMap.Equals(other.EntityAttributeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601923A RID: 102970 RVA: 0x003AACC4 File Offset: 0x003A8EC4
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

		// Token: 0x0601923B RID: 102971 RVA: 0x003AACF8 File Offset: 0x003A8EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601923C RID: 102972 RVA: 0x003AAD05 File Offset: 0x003A8F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601923D RID: 102973 RVA: 0x003AAD0E File Offset: 0x003A8F0E
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

		// Token: 0x0601923E RID: 102974 RVA: 0x003AAD38 File Offset: 0x003A8F38
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

		// Token: 0x0601923F RID: 102975 RVA: 0x003AAD71 File Offset: 0x003A8F71
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

		// Token: 0x06019240 RID: 102976 RVA: 0x003AAD9F File Offset: 0x003A8F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019241 RID: 102977 RVA: 0x003AADA8 File Offset: 0x003A8FA8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityAttributeMap_.AddEntriesFrom(ref input, SimpleCombatEntitySyncAttributePush._map_entityAttributeMap_codec);
				}
			}
		}

		// Token: 0x040094DE RID: 38110
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094DF RID: 38111
		public const int EntityAttributeMapFieldNumber = 5;

		// Token: 0x040094E0 RID: 38112
		private static readonly MapField<long, SimpleCombatEntityAttributePbInfo>.Codec _map_entityAttributeMap_codec = new MapField<long, SimpleCombatEntityAttributePbInfo>.Codec(FieldCodec.ForInt64(8U, 0L), FieldCodec.ForMessage<SimpleCombatEntityAttributePbInfo>(18U, SimpleCombatEntityAttributePbInfo.Parser), 42U);

		// Token: 0x040094E1 RID: 38113
		private readonly MapField<long, SimpleCombatEntityAttributePbInfo> entityAttributeMap_ = new MapField<long, SimpleCombatEntityAttributePbInfo>();
	}
}
