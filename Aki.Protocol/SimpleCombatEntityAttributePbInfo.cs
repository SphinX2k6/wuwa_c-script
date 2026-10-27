using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001220 RID: 4640
	public sealed class SimpleCombatEntityAttributePbInfo : IMessage<SimpleCombatEntityAttributePbInfo>, IMessage, IEquatable<SimpleCombatEntityAttributePbInfo>, IDeepCloneable<SimpleCombatEntityAttributePbInfo>, IBufferMessage
	{
		// Token: 0x06018B91 RID: 101265 RVA: 0x00398406 File Offset: 0x00396606
		[NullableContext(1)]
		public static SimpleCombatEntityAttributePbInfo Create()
		{
			return new SimpleCombatEntityAttributePbInfo();
		}

		// Token: 0x1700534A RID: 21322
		// (get) Token: 0x06018B92 RID: 101266 RVA: 0x0039840D File Offset: 0x0039660D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SimpleCombatEntityAttributePbInfo> Parser
		{
			get
			{
				return SimpleCombatEntityAttributePbInfo._parser;
			}
		}

		// Token: 0x1700534B RID: 21323
		// (get) Token: 0x06018B93 RID: 101267 RVA: 0x00398414 File Offset: 0x00396614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700534C RID: 21324
		// (get) Token: 0x06018B94 RID: 101268 RVA: 0x00398417 File Offset: 0x00396617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntityAttributePbInfo.Descriptor;
			}
		}

		// Token: 0x06018B95 RID: 101269 RVA: 0x0039841E File Offset: 0x0039661E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo()
		{
		}

		// Token: 0x06018B96 RID: 101270 RVA: 0x0039843C File Offset: 0x0039663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo(SimpleCombatEntityAttributePbInfo other) : this()
		{
			this.attributeMap_ = other.attributeMap_.Clone();
			this.lockedAttributeMap_ = other.lockedAttributeMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B97 RID: 101271 RVA: 0x00398477 File Offset: 0x00396677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntityAttributePbInfo Clone()
		{
			return new SimpleCombatEntityAttributePbInfo(this);
		}

		// Token: 0x1700534D RID: 21325
		// (get) Token: 0x06018B98 RID: 101272 RVA: 0x0039847F File Offset: 0x0039667F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AttributeMap
		{
			get
			{
				return this.attributeMap_;
			}
		}

		// Token: 0x1700534E RID: 21326
		// (get) Token: 0x06018B99 RID: 101273 RVA: 0x00398487 File Offset: 0x00396687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedAttributeMap
		{
			get
			{
				return this.lockedAttributeMap_;
			}
		}

		// Token: 0x06018B9A RID: 101274 RVA: 0x0039848F File Offset: 0x0039668F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntityAttributePbInfo);
		}

		// Token: 0x06018B9B RID: 101275 RVA: 0x003984A0 File Offset: 0x003966A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntityAttributePbInfo other)
		{
			return other != null && (other == this || (this.AttributeMap.Equals(other.AttributeMap) && this.LockedAttributeMap.Equals(other.LockedAttributeMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B9C RID: 101276 RVA: 0x003984F4 File Offset: 0x003966F4
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

		// Token: 0x06018B9D RID: 101277 RVA: 0x00398536 File Offset: 0x00396736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B9E RID: 101278 RVA: 0x00398543 File Offset: 0x00396743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B9F RID: 101279 RVA: 0x0039854C File Offset: 0x0039674C
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

		// Token: 0x06018BA0 RID: 101280 RVA: 0x00398584 File Offset: 0x00396784
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

		// Token: 0x06018BA1 RID: 101281 RVA: 0x003985D0 File Offset: 0x003967D0
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

		// Token: 0x06018BA2 RID: 101282 RVA: 0x0039860F File Offset: 0x0039680F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BA3 RID: 101283 RVA: 0x00398618 File Offset: 0x00396818
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

		// Token: 0x040091EE RID: 37358
		private static readonly MessageParser<SimpleCombatEntityAttributePbInfo> _parser = new MessageParser<SimpleCombatEntityAttributePbInfo>(() => new SimpleCombatEntityAttributePbInfo());

		// Token: 0x040091EF RID: 37359
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091F0 RID: 37360
		public const int AttributeMapFieldNumber = 1;

		// Token: 0x040091F1 RID: 37361
		private static readonly MapField<int, int>.Codec _map_attributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x040091F2 RID: 37362
		private readonly MapField<int, int> attributeMap_ = new MapField<int, int>();

		// Token: 0x040091F3 RID: 37363
		public const int LockedAttributeMapFieldNumber = 2;

		// Token: 0x040091F4 RID: 37364
		private static readonly MapField<int, int>.Codec _map_lockedAttributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 18U);

		// Token: 0x040091F5 RID: 37365
		private readonly MapField<int, int> lockedAttributeMap_ = new MapField<int, int>();
	}
}
