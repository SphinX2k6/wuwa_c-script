using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8D RID: 3725
	public sealed class RbFloorComponentPb : IMessage<RbFloorComponentPb>, IMessage, IEquatable<RbFloorComponentPb>, IDeepCloneable<RbFloorComponentPb>, IBufferMessage
	{
		// Token: 0x06014016 RID: 81942 RVA: 0x002E9ED8 File Offset: 0x002E80D8
		[NullableContext(1)]
		public static RbFloorComponentPb Create()
		{
			return new RbFloorComponentPb();
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x06014017 RID: 81943 RVA: 0x002E9EDF File Offset: 0x002E80DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x06014018 RID: 81944 RVA: 0x002E9EE2 File Offset: 0x002E80E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbFloorComponentPb.Descriptor;
			}
		}

		// Token: 0x06014019 RID: 81945 RVA: 0x002E9EE9 File Offset: 0x002E80E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb()
		{
		}

		// Token: 0x0601401A RID: 81946 RVA: 0x002E9EFC File Offset: 0x002E80FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb(RbFloorComponentPb other) : this()
		{
			this.gamePlayIncId_ = other.gamePlayIncId_;
			this.type_ = other.type_;
			this.occupiedCellPositions_ = other.occupiedCellPositions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601401B RID: 81947 RVA: 0x002E9F49 File Offset: 0x002E8149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb Clone()
		{
			return new RbFloorComponentPb(this);
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x0601401C RID: 81948 RVA: 0x002E9F51 File Offset: 0x002E8151
		// (set) Token: 0x0601401D RID: 81949 RVA: 0x002E9F59 File Offset: 0x002E8159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayIncId
		{
			get
			{
				return this.gamePlayIncId_;
			}
			set
			{
				this.gamePlayIncId_ = value;
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x0601401E RID: 81950 RVA: 0x002E9F62 File Offset: 0x002E8162
		// (set) Token: 0x0601401F RID: 81951 RVA: 0x002E9F6A File Offset: 0x002E816A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17004291 RID: 17041
		// (get) Token: 0x06014020 RID: 81952 RVA: 0x002E9F73 File Offset: 0x002E8173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x06014021 RID: 81953 RVA: 0x002E9F7B File Offset: 0x002E817B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbFloorComponentPb);
		}

		// Token: 0x06014022 RID: 81954 RVA: 0x002E9F8C File Offset: 0x002E818C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbFloorComponentPb other)
		{
			return other != null && (other == this || (this.GamePlayIncId == other.GamePlayIncId && this.Type == other.Type && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014023 RID: 81955 RVA: 0x002E9FEC File Offset: 0x002E81EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GamePlayIncId != 0)
			{
				num ^= this.GamePlayIncId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.occupiedCellPositions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014024 RID: 81956 RVA: 0x002EA052 File Offset: 0x002E8252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014025 RID: 81957 RVA: 0x002EA05F File Offset: 0x002E825F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014026 RID: 81958 RVA: 0x002EA068 File Offset: 0x002E8268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GamePlayIncId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GamePlayIncId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			this.occupiedCellPositions_.WriteTo(ref output, RbFloorComponentPb._repeated_occupiedCellPositions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014027 RID: 81959 RVA: 0x002EA0D4 File Offset: 0x002E82D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GamePlayIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayIncId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			num += this.occupiedCellPositions_.CalculateSize(RbFloorComponentPb._repeated_occupiedCellPositions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014028 RID: 81960 RVA: 0x002EA140 File Offset: 0x002E8340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbFloorComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GamePlayIncId != 0)
			{
				this.GamePlayIncId = other.GamePlayIncId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			this.occupiedCellPositions_.Add(other.occupiedCellPositions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014029 RID: 81961 RVA: 0x002EA1A1 File Offset: 0x002E83A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601402A RID: 81962 RVA: 0x002EA1AC File Offset: 0x002E83AC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.occupiedCellPositions_.AddEntriesFrom(ref input, RbFloorComponentPb._repeated_occupiedCellPositions_codec);
						}
					}
					else
					{
						this.Type = input.ReadInt32();
					}
				}
				else
				{
					this.GamePlayIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007A29 RID: 31273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A2A RID: 31274
		public const int GamePlayIncIdFieldNumber = 1;

		// Token: 0x04007A2B RID: 31275
		private int gamePlayIncId_;

		// Token: 0x04007A2C RID: 31276
		public const int TypeFieldNumber = 2;

		// Token: 0x04007A2D RID: 31277
		private int type_;

		// Token: 0x04007A2E RID: 31278
		public const int OccupiedCellPositionsFieldNumber = 3;

		// Token: 0x04007A2F RID: 31279
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(26U, RbGridPosition.Parser);

		// Token: 0x04007A30 RID: 31280
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();
	}
}
