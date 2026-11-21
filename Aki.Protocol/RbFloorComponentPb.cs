using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7D RID: 3709
	public sealed class RbFloorComponentPb : IMessage<RbFloorComponentPb>, IMessage, IEquatable<RbFloorComponentPb>, IDeepCloneable<RbFloorComponentPb>, IBufferMessage
	{
		// Token: 0x06013F31 RID: 81713 RVA: 0x002E881C File Offset: 0x002E6A1C
		[NullableContext(1)]
		public static RbFloorComponentPb Create()
		{
			return new RbFloorComponentPb();
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x06013F32 RID: 81714 RVA: 0x002E8823 File Offset: 0x002E6A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x06013F33 RID: 81715 RVA: 0x002E8826 File Offset: 0x002E6A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbFloorComponentPb.Descriptor;
			}
		}

		// Token: 0x06013F34 RID: 81716 RVA: 0x002E882D File Offset: 0x002E6A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb()
		{
		}

		// Token: 0x06013F35 RID: 81717 RVA: 0x002E8840 File Offset: 0x002E6A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb(RbFloorComponentPb other) : this()
		{
			this.gamePlayIncId_ = other.gamePlayIncId_;
			this.type_ = other.type_;
			this.occupiedCellPositions_ = other.occupiedCellPositions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F36 RID: 81718 RVA: 0x002E888D File Offset: 0x002E6A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbFloorComponentPb Clone()
		{
			return new RbFloorComponentPb(this);
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x06013F37 RID: 81719 RVA: 0x002E8895 File Offset: 0x002E6A95
		// (set) Token: 0x06013F38 RID: 81720 RVA: 0x002E889D File Offset: 0x002E6A9D
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

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x06013F39 RID: 81721 RVA: 0x002E88A6 File Offset: 0x002E6AA6
		// (set) Token: 0x06013F3A RID: 81722 RVA: 0x002E88AE File Offset: 0x002E6AAE
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

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x06013F3B RID: 81723 RVA: 0x002E88B7 File Offset: 0x002E6AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RbGridPosition> OccupiedCellPositions
		{
			get
			{
				return this.occupiedCellPositions_;
			}
		}

		// Token: 0x06013F3C RID: 81724 RVA: 0x002E88BF File Offset: 0x002E6ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbFloorComponentPb);
		}

		// Token: 0x06013F3D RID: 81725 RVA: 0x002E88D0 File Offset: 0x002E6AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbFloorComponentPb other)
		{
			return other != null && (other == this || (this.GamePlayIncId == other.GamePlayIncId && this.Type == other.Type && this.occupiedCellPositions_.Equals(other.occupiedCellPositions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F3E RID: 81726 RVA: 0x002E8930 File Offset: 0x002E6B30
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

		// Token: 0x06013F3F RID: 81727 RVA: 0x002E8996 File Offset: 0x002E6B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F40 RID: 81728 RVA: 0x002E89A3 File Offset: 0x002E6BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F41 RID: 81729 RVA: 0x002E89AC File Offset: 0x002E6BAC
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

		// Token: 0x06013F42 RID: 81730 RVA: 0x002E8A18 File Offset: 0x002E6C18
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

		// Token: 0x06013F43 RID: 81731 RVA: 0x002E8A84 File Offset: 0x002E6C84
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

		// Token: 0x06013F44 RID: 81732 RVA: 0x002E8AE5 File Offset: 0x002E6CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F45 RID: 81733 RVA: 0x002E8AF0 File Offset: 0x002E6CF0
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

		// Token: 0x04007A53 RID: 31315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A54 RID: 31316
		public const int GamePlayIncIdFieldNumber = 1;

		// Token: 0x04007A55 RID: 31317
		private int gamePlayIncId_;

		// Token: 0x04007A56 RID: 31318
		public const int TypeFieldNumber = 2;

		// Token: 0x04007A57 RID: 31319
		private int type_;

		// Token: 0x04007A58 RID: 31320
		public const int OccupiedCellPositionsFieldNumber = 3;

		// Token: 0x04007A59 RID: 31321
		private static readonly FieldCodec<RbGridPosition> _repeated_occupiedCellPositions_codec = FieldCodec.ForMessage<RbGridPosition>(26U, RbGridPosition.Parser);

		// Token: 0x04007A5A RID: 31322
		private readonly RepeatedField<RbGridPosition> occupiedCellPositions_ = new RepeatedField<RbGridPosition>();
	}
}
