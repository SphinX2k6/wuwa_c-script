using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125C RID: 4700
	public sealed class SimpleCombatEntityAttributePbInfo : IMessage<SimpleCombatEntityAttributePbInfo>, IMessage, IEquatable<SimpleCombatEntityAttributePbInfo>, IDeepCloneable<SimpleCombatEntityAttributePbInfo>, IBufferMessage
	{
		// Token: 0x0601916B RID: 102763 RVA: 0x003A82AE File Offset: 0x003A64AE
		[NullableContext(1)]
		public static SimpleCombatEntityAttributePbInfo Create()
		{
			return new SimpleCombatEntityAttributePbInfo();
		}

		// Token: 0x170054C7 RID: 21703
		// (get) Token: 0x0601916C RID: 102764 RVA: 0x003A82B5 File Offset: 0x003A64B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleCombatEntityAttributePbInfo> Parser
		{
			get
			{
				return SimpleCombatEntityAttributePbInfo._parser;
			}
		}

		// Token: 0x170054C8 RID: 21704
		// (get) Token: 0x0601916D RID: 102765 RVA: 0x003A82BC File Offset: 0x003A64BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054C9 RID: 21705
		// (get) Token: 0x0601916E RID: 102766 RVA: 0x003A82BF File Offset: 0x003A64BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityAttributePbInfo.Descriptor;
			}
		}

		// Token: 0x0601916F RID: 102767 RVA: 0x003A82C6 File Offset: 0x003A64C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo()
		{
		}

		// Token: 0x06019170 RID: 102768 RVA: 0x003A82E4 File Offset: 0x003A64E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo(SimpleCombatEntityAttributePbInfo other) : this()
		{
			this.attributeMap_ = other.attributeMap_.Clone();
			this.lockedAttributeMap_ = other.lockedAttributeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019171 RID: 102769 RVA: 0x003A831F File Offset: 0x003A651F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo Clone()
		{
			return new SimpleCombatEntityAttributePbInfo(this);
		}

		// Token: 0x170054CA RID: 21706
		// (get) Token: 0x06019172 RID: 102770 RVA: 0x003A8327 File Offset: 0x003A6527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AttributeMap
		{
			get
			{
				return this.attributeMap_;
			}
		}

		// Token: 0x170054CB RID: 21707
		// (get) Token: 0x06019173 RID: 102771 RVA: 0x003A832F File Offset: 0x003A652F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedAttributeMap
		{
			get
			{
				return this.lockedAttributeMap_;
			}
		}

		// Token: 0x06019174 RID: 102772 RVA: 0x003A8337 File Offset: 0x003A6537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityAttributePbInfo);
		}

		// Token: 0x06019175 RID: 102773 RVA: 0x003A8348 File Offset: 0x003A6548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityAttributePbInfo other)
		{
			return other != null && (other == this || (this.AttributeMap.Equals(other.AttributeMap) && this.LockedAttributeMap.Equals(other.LockedAttributeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019176 RID: 102774 RVA: 0x003A839C File Offset: 0x003A659C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.AttributeMap.GetHashCode();
			num ^= this.LockedAttributeMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019177 RID: 102775 RVA: 0x003A83DE File Offset: 0x003A65DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019178 RID: 102776 RVA: 0x003A83EB File Offset: 0x003A65EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019179 RID: 102777 RVA: 0x003A83F4 File Offset: 0x003A65F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attributeMap_.WriteTo(ref output, SimpleCombatEntityAttributePbInfo._map_attributeMap_codec);
			this.lockedAttributeMap_.WriteTo(ref output, SimpleCombatEntityAttributePbInfo._map_lockedAttributeMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601917A RID: 102778 RVA: 0x003A842C File Offset: 0x003A662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attributeMap_.CalculateSize(SimpleCombatEntityAttributePbInfo._map_attributeMap_codec);
			num += this.lockedAttributeMap_.CalculateSize(SimpleCombatEntityAttributePbInfo._map_lockedAttributeMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601917B RID: 102779 RVA: 0x003A8478 File Offset: 0x003A6678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntityAttributePbInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.attributeMap_.MergeFrom(other.attributeMap_);
			this.lockedAttributeMap_.MergeFrom(other.lockedAttributeMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601917C RID: 102780 RVA: 0x003A84B7 File Offset: 0x003A66B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601917D RID: 102781 RVA: 0x003A84C0 File Offset: 0x003A66C0
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lockedAttributeMap_.AddEntriesFrom(ref input, SimpleCombatEntityAttributePbInfo._map_lockedAttributeMap_codec);
					}
				}
				else
				{
					this.attributeMap_.AddEntriesFrom(ref input, SimpleCombatEntityAttributePbInfo._map_attributeMap_codec);
				}
			}
		}

		// Token: 0x0400949F RID: 38047
		private static readonly MessageParser<SimpleCombatEntityAttributePbInfo> _parser = new MessageParser<SimpleCombatEntityAttributePbInfo>(() => new SimpleCombatEntityAttributePbInfo());

		// Token: 0x040094A0 RID: 38048
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094A1 RID: 38049
		public const int AttributeMapFieldNumber = 1;

		// Token: 0x040094A2 RID: 38050
		private static readonly MapField<int, int>.Codec _map_attributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x040094A3 RID: 38051
		private readonly MapField<int, int> attributeMap_ = new MapField<int, int>();

		// Token: 0x040094A4 RID: 38052
		public const int LockedAttributeMapFieldNumber = 2;

		// Token: 0x040094A5 RID: 38053
		private static readonly MapField<int, int>.Codec _map_lockedAttributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040094A6 RID: 38054
		private readonly MapField<int, int> lockedAttributeMap_ = new MapField<int, int>();
	}
}
