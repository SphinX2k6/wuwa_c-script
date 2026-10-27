using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200121E RID: 4638
	public sealed class SimpleCombatComponentPb : IMessage<SimpleCombatComponentPb>, IMessage, IEquatable<SimpleCombatComponentPb>, IDeepCloneable<SimpleCombatComponentPb>, IBufferMessage
	{
		// Token: 0x06018B63 RID: 101219 RVA: 0x00397C76 File Offset: 0x00395E76
		[NullableContext(1)]
		public static SimpleCombatComponentPb Create()
		{
			return new SimpleCombatComponentPb();
		}

		// Token: 0x1700533E RID: 21310
		// (get) Token: 0x06018B64 RID: 101220 RVA: 0x00397C7D File Offset: 0x00395E7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700533F RID: 21311
		// (get) Token: 0x06018B65 RID: 101221 RVA: 0x00397C80 File Offset: 0x00395E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatComponentPb.Descriptor;
			}
		}

		// Token: 0x06018B66 RID: 101222 RVA: 0x00397C87 File Offset: 0x00395E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb()
		{
		}

		// Token: 0x06018B67 RID: 101223 RVA: 0x00397CB0 File Offset: 0x00395EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb(SimpleCombatComponentPb other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.subTypeId_ = other.subTypeId_;
			this.splineConfigId_ = other.splineConfigId_;
			this.buffLayers_ = other.buffLayers_.Clone();
			this.attributeMap_ = other.attributeMap_.Clone();
			this.lockedAttributeMap_ = other.lockedAttributeMap_.Clone();
			if (other.MoveTypeCase == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
			{
				this.SplineMoveType = other.SplineMoveType.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018B68 RID: 101224 RVA: 0x00397D45 File Offset: 0x00395F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb Clone()
		{
			return new SimpleCombatComponentPb(this);
		}

		// Token: 0x17005340 RID: 21312
		// (get) Token: 0x06018B69 RID: 101225 RVA: 0x00397D4D File Offset: 0x00395F4D
		// (set) Token: 0x06018B6A RID: 101226 RVA: 0x00397D55 File Offset: 0x00395F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubTypeId
		{
			get
			{
				return this.subTypeId_;
			}
			set
			{
				this.subTypeId_ = value;
			}
		}

		// Token: 0x17005341 RID: 21313
		// (get) Token: 0x06018B6B RID: 101227 RVA: 0x00397D5E File Offset: 0x00395F5E
		// (set) Token: 0x06018B6C RID: 101228 RVA: 0x00397D76 File Offset: 0x00395F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SplineConfigId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.splineConfigId_;
				}
				return SimpleCombatComponentPb.SplineConfigIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.splineConfigId_ = value;
			}
		}

		// Token: 0x17005342 RID: 21314
		// (get) Token: 0x06018B6D RID: 101229 RVA: 0x00397D8D File Offset: 0x00395F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSplineConfigId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06018B6E RID: 101230 RVA: 0x00397D9A File Offset: 0x00395F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSplineConfigId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17005343 RID: 21315
		// (get) Token: 0x06018B6F RID: 101231 RVA: 0x00397DAB File Offset: 0x00395FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BuffLayers
		{
			get
			{
				return this.buffLayers_;
			}
		}

		// Token: 0x17005344 RID: 21316
		// (get) Token: 0x06018B70 RID: 101232 RVA: 0x00397DB3 File Offset: 0x00395FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AttributeMap
		{
			get
			{
				return this.attributeMap_;
			}
		}

		// Token: 0x17005345 RID: 21317
		// (get) Token: 0x06018B71 RID: 101233 RVA: 0x00397DBB File Offset: 0x00395FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedAttributeMap
		{
			get
			{
				return this.lockedAttributeMap_;
			}
		}

		// Token: 0x17005346 RID: 21318
		// (get) Token: 0x06018B72 RID: 101234 RVA: 0x00397DC3 File Offset: 0x00395FC3
		// (set) Token: 0x06018B73 RID: 101235 RVA: 0x00397DDB File Offset: 0x00395FDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatSplineMovePbType SplineMoveType
		{
			get
			{
				if (this.moveTypeCase_ != SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
				{
					return null;
				}
				return (SimpleCombatSplineMovePbType)this.moveType_;
			}
			set
			{
				this.moveType_ = value;
				this.moveTypeCase_ = ((value == null) ? SimpleCombatComponentPb.MoveTypeOneofCase.None : SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType);
			}
		}

		// Token: 0x17005347 RID: 21319
		// (get) Token: 0x06018B74 RID: 101236 RVA: 0x00397DF1 File Offset: 0x00395FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb.MoveTypeOneofCase MoveTypeCase
		{
			get
			{
				return this.moveTypeCase_;
			}
		}

		// Token: 0x06018B75 RID: 101237 RVA: 0x00397DF9 File Offset: 0x00395FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMoveType()
		{
			this.moveTypeCase_ = SimpleCombatComponentPb.MoveTypeOneofCase.None;
			this.moveType_ = null;
		}

		// Token: 0x06018B76 RID: 101238 RVA: 0x00397E09 File Offset: 0x00396009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatComponentPb);
		}

		// Token: 0x06018B77 RID: 101239 RVA: 0x00397E18 File Offset: 0x00396018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatComponentPb other)
		{
			return other != null && (other == this || (this.SubTypeId == other.SubTypeId && this.SplineConfigId == other.SplineConfigId && this.BuffLayers.Equals(other.BuffLayers) && this.AttributeMap.Equals(other.AttributeMap) && this.LockedAttributeMap.Equals(other.LockedAttributeMap) && object.Equals(this.SplineMoveType, other.SplineMoveType) && this.MoveTypeCase == other.MoveTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018B78 RID: 101240 RVA: 0x00397EC8 File Offset: 0x003960C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubTypeId != 0)
			{
				num ^= this.SubTypeId.GetHashCode();
			}
			if (this.HasSplineConfigId)
			{
				num ^= this.SplineConfigId.GetHashCode();
			}
			num ^= this.BuffLayers.GetHashCode();
			num ^= this.AttributeMap.GetHashCode();
			num ^= this.LockedAttributeMap.GetHashCode();
			if (this.moveTypeCase_ == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
			{
				num ^= this.SplineMoveType.GetHashCode();
			}
			num ^= (int)this.moveTypeCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018B79 RID: 101241 RVA: 0x00397F6A File Offset: 0x0039616A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018B7A RID: 101242 RVA: 0x00397F77 File Offset: 0x00396177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018B7B RID: 101243 RVA: 0x00397F80 File Offset: 0x00396180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubTypeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SubTypeId);
			}
			if (this.HasSplineConfigId)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SplineConfigId);
			}
			this.buffLayers_.WriteTo(ref output, SimpleCombatComponentPb._map_buffLayers_codec);
			this.attributeMap_.WriteTo(ref output, SimpleCombatComponentPb._map_attributeMap_codec);
			this.lockedAttributeMap_.WriteTo(ref output, SimpleCombatComponentPb._map_lockedAttributeMap_codec);
			if (this.moveTypeCase_ == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.SplineMoveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018B7C RID: 101244 RVA: 0x00398028 File Offset: 0x00396228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubTypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubTypeId);
			}
			if (this.HasSplineConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SplineConfigId);
			}
			num += this.buffLayers_.CalculateSize(SimpleCombatComponentPb._map_buffLayers_codec);
			num += this.attributeMap_.CalculateSize(SimpleCombatComponentPb._map_attributeMap_codec);
			num += this.lockedAttributeMap_.CalculateSize(SimpleCombatComponentPb._map_lockedAttributeMap_codec);
			if (this.moveTypeCase_ == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SplineMoveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018B7D RID: 101245 RVA: 0x003980D0 File Offset: 0x003962D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubTypeId != 0)
			{
				this.SubTypeId = other.SubTypeId;
			}
			if (other.HasSplineConfigId)
			{
				this.SplineConfigId = other.SplineConfigId;
			}
			this.buffLayers_.MergeFrom(other.buffLayers_);
			this.attributeMap_.MergeFrom(other.attributeMap_);
			this.lockedAttributeMap_.MergeFrom(other.lockedAttributeMap_);
			if (other.MoveTypeCase == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
			{
				if (this.SplineMoveType == null)
				{
					this.SplineMoveType = new SimpleCombatSplineMovePbType();
				}
				this.SplineMoveType.MergeFrom(other.SplineMoveType);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018B7E RID: 101246 RVA: 0x00398180 File Offset: 0x00396380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018B7F RID: 101247 RVA: 0x0039818C File Offset: 0x0039638C
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
				if (num <= 34U)
				{
					if (num == 8U)
					{
						this.SubTypeId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SplineConfigId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.buffLayers_.AddEntriesFrom(ref input, SimpleCombatComponentPb._map_buffLayers_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.attributeMap_.AddEntriesFrom(ref input, SimpleCombatComponentPb._map_attributeMap_codec);
						continue;
					}
					if (num == 50U)
					{
						this.lockedAttributeMap_.AddEntriesFrom(ref input, SimpleCombatComponentPb._map_lockedAttributeMap_codec);
						continue;
					}
					if (num == 58U)
					{
						SimpleCombatSplineMovePbType simpleCombatSplineMovePbType = new SimpleCombatSplineMovePbType();
						if (this.moveTypeCase_ == SimpleCombatComponentPb.MoveTypeOneofCase.SplineMoveType)
						{
							simpleCombatSplineMovePbType.MergeFrom(this.SplineMoveType);
						}
						input.ReadMessage(simpleCombatSplineMovePbType);
						this.SplineMoveType = simpleCombatSplineMovePbType;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040091DA RID: 37338
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091DB RID: 37339
		private int _hasBits0;

		// Token: 0x040091DC RID: 37340
		public const int SubTypeIdFieldNumber = 1;

		// Token: 0x040091DD RID: 37341
		private int subTypeId_;

		// Token: 0x040091DE RID: 37342
		public const int SplineConfigIdFieldNumber = 3;

		// Token: 0x040091DF RID: 37343
		private static readonly int SplineConfigIdDefaultValue = 0;

		// Token: 0x040091E0 RID: 37344
		private int splineConfigId_;

		// Token: 0x040091E1 RID: 37345
		public const int BuffLayersFieldNumber = 4;

		// Token: 0x040091E2 RID: 37346
		private static readonly MapField<int, int>.Codec _map_buffLayers_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x040091E3 RID: 37347
		private readonly MapField<int, int> buffLayers_ = new MapField<int, int>();

		// Token: 0x040091E4 RID: 37348
		public const int AttributeMapFieldNumber = 5;

		// Token: 0x040091E5 RID: 37349
		private static readonly MapField<int, int>.Codec _map_attributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x040091E6 RID: 37350
		private readonly MapField<int, int> attributeMap_ = new MapField<int, int>();

		// Token: 0x040091E7 RID: 37351
		public const int LockedAttributeMapFieldNumber = 6;

		// Token: 0x040091E8 RID: 37352
		private static readonly MapField<int, int>.Codec _map_lockedAttributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x040091E9 RID: 37353
		private readonly MapField<int, int> lockedAttributeMap_ = new MapField<int, int>();

		// Token: 0x040091EA RID: 37354
		public const int SplineMoveTypeFieldNumber = 7;

		// Token: 0x040091EB RID: 37355
		private object moveType_;

		// Token: 0x040091EC RID: 37356
		private SimpleCombatComponentPb.MoveTypeOneofCase moveTypeCase_;

		// Token: 0x02001993 RID: 6547
		public enum MoveTypeOneofCase
		{
			// Token: 0x0400CA10 RID: 51728
			None,
			// Token: 0x0400CA11 RID: 51729
			SplineMoveType = 7
		}
	}
}
