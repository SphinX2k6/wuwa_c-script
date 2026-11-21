using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125A RID: 4698
	public sealed class SimpleCombatComponentPb : IMessage<SimpleCombatComponentPb>, IMessage, IEquatable<SimpleCombatComponentPb>, IDeepCloneable<SimpleCombatComponentPb>, IBufferMessage
	{
		// Token: 0x0601913D RID: 102717 RVA: 0x003A7B1E File Offset: 0x003A5D1E
		[NullableContext(1)]
		public static SimpleCombatComponentPb Create()
		{
			return new SimpleCombatComponentPb();
		}

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x0601913E RID: 102718 RVA: 0x003A7B25 File Offset: 0x003A5D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x0601913F RID: 102719 RVA: 0x003A7B28 File Offset: 0x003A5D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatComponentPb.Descriptor;
			}
		}

		// Token: 0x06019140 RID: 102720 RVA: 0x003A7B2F File Offset: 0x003A5D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb()
		{
		}

		// Token: 0x06019141 RID: 102721 RVA: 0x003A7B58 File Offset: 0x003A5D58
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

		// Token: 0x06019142 RID: 102722 RVA: 0x003A7BED File Offset: 0x003A5DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb Clone()
		{
			return new SimpleCombatComponentPb(this);
		}

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x06019143 RID: 102723 RVA: 0x003A7BF5 File Offset: 0x003A5DF5
		// (set) Token: 0x06019144 RID: 102724 RVA: 0x003A7BFD File Offset: 0x003A5DFD
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

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x06019145 RID: 102725 RVA: 0x003A7C06 File Offset: 0x003A5E06
		// (set) Token: 0x06019146 RID: 102726 RVA: 0x003A7C1E File Offset: 0x003A5E1E
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

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x06019147 RID: 102727 RVA: 0x003A7C35 File Offset: 0x003A5E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSplineConfigId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06019148 RID: 102728 RVA: 0x003A7C42 File Offset: 0x003A5E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSplineConfigId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x06019149 RID: 102729 RVA: 0x003A7C53 File Offset: 0x003A5E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BuffLayers
		{
			get
			{
				return this.buffLayers_;
			}
		}

		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x0601914A RID: 102730 RVA: 0x003A7C5B File Offset: 0x003A5E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> AttributeMap
		{
			get
			{
				return this.attributeMap_;
			}
		}

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x0601914B RID: 102731 RVA: 0x003A7C63 File Offset: 0x003A5E63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> LockedAttributeMap
		{
			get
			{
				return this.lockedAttributeMap_;
			}
		}

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x0601914C RID: 102732 RVA: 0x003A7C6B File Offset: 0x003A5E6B
		// (set) Token: 0x0601914D RID: 102733 RVA: 0x003A7C83 File Offset: 0x003A5E83
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

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x0601914E RID: 102734 RVA: 0x003A7C99 File Offset: 0x003A5E99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb.MoveTypeOneofCase MoveTypeCase
		{
			get
			{
				return this.moveTypeCase_;
			}
		}

		// Token: 0x0601914F RID: 102735 RVA: 0x003A7CA1 File Offset: 0x003A5EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearMoveType()
		{
			this.moveTypeCase_ = SimpleCombatComponentPb.MoveTypeOneofCase.None;
			this.moveType_ = null;
		}

		// Token: 0x06019150 RID: 102736 RVA: 0x003A7CB1 File Offset: 0x003A5EB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatComponentPb);
		}

		// Token: 0x06019151 RID: 102737 RVA: 0x003A7CC0 File Offset: 0x003A5EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatComponentPb other)
		{
			return other != null && (other == this || (this.SubTypeId == other.SubTypeId && this.SplineConfigId == other.SplineConfigId && this.BuffLayers.Equals(other.BuffLayers) && this.AttributeMap.Equals(other.AttributeMap) && this.LockedAttributeMap.Equals(other.LockedAttributeMap) && object.Equals(this.SplineMoveType, other.SplineMoveType) && this.MoveTypeCase == other.MoveTypeCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019152 RID: 102738 RVA: 0x003A7D70 File Offset: 0x003A5F70
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

		// Token: 0x06019153 RID: 102739 RVA: 0x003A7E12 File Offset: 0x003A6012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019154 RID: 102740 RVA: 0x003A7E1F File Offset: 0x003A601F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019155 RID: 102741 RVA: 0x003A7E28 File Offset: 0x003A6028
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

		// Token: 0x06019156 RID: 102742 RVA: 0x003A7ED0 File Offset: 0x003A60D0
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

		// Token: 0x06019157 RID: 102743 RVA: 0x003A7F78 File Offset: 0x003A6178
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

		// Token: 0x06019158 RID: 102744 RVA: 0x003A8028 File Offset: 0x003A6228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019159 RID: 102745 RVA: 0x003A8034 File Offset: 0x003A6234
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

		// Token: 0x0400948B RID: 38027
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400948C RID: 38028
		private int _hasBits0;

		// Token: 0x0400948D RID: 38029
		public const int SubTypeIdFieldNumber = 1;

		// Token: 0x0400948E RID: 38030
		private int subTypeId_;

		// Token: 0x0400948F RID: 38031
		public const int SplineConfigIdFieldNumber = 3;

		// Token: 0x04009490 RID: 38032
		private static readonly int SplineConfigIdDefaultValue = 0;

		// Token: 0x04009491 RID: 38033
		private int splineConfigId_;

		// Token: 0x04009492 RID: 38034
		public const int BuffLayersFieldNumber = 4;

		// Token: 0x04009493 RID: 38035
		private static readonly MapField<int, int>.Codec _map_buffLayers_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04009494 RID: 38036
		private readonly MapField<int, int> buffLayers_ = new MapField<int, int>();

		// Token: 0x04009495 RID: 38037
		public const int AttributeMapFieldNumber = 5;

		// Token: 0x04009496 RID: 38038
		private static readonly MapField<int, int>.Codec _map_attributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04009497 RID: 38039
		private readonly MapField<int, int> attributeMap_ = new MapField<int, int>();

		// Token: 0x04009498 RID: 38040
		public const int LockedAttributeMapFieldNumber = 6;

		// Token: 0x04009499 RID: 38041
		private static readonly MapField<int, int>.Codec _map_lockedAttributeMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x0400949A RID: 38042
		private readonly MapField<int, int> lockedAttributeMap_ = new MapField<int, int>();

		// Token: 0x0400949B RID: 38043
		public const int SplineMoveTypeFieldNumber = 7;

		// Token: 0x0400949C RID: 38044
		private object moveType_;

		// Token: 0x0400949D RID: 38045
		private SimpleCombatComponentPb.MoveTypeOneofCase moveTypeCase_;

		// Token: 0x02001A1F RID: 6687
		public enum MoveTypeOneofCase
		{
			// Token: 0x0400CF5B RID: 53083
			None,
			// Token: 0x0400CF5C RID: 53084
			SplineMoveType = 7
		}
	}
}
