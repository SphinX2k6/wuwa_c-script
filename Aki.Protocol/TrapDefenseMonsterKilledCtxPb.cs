using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A4 RID: 5284
	public sealed class TrapDefenseMonsterKilledCtxPb : IMessage<TrapDefenseMonsterKilledCtxPb>, IMessage, IEquatable<TrapDefenseMonsterKilledCtxPb>, IDeepCloneable<TrapDefenseMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601C0B2 RID: 114866 RVA: 0x004125AD File Offset: 0x004107AD
		[NullableContext(1)]
		public static TrapDefenseMonsterKilledCtxPb Create()
		{
			return new TrapDefenseMonsterKilledCtxPb();
		}

		// Token: 0x17005EEB RID: 24299
		// (get) Token: 0x0601C0B3 RID: 114867 RVA: 0x004125B4 File Offset: 0x004107B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EEC RID: 24300
		// (get) Token: 0x0601C0B4 RID: 114868 RVA: 0x004125B7 File Offset: 0x004107B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x004125BE File Offset: 0x004107BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb()
		{
		}

		// Token: 0x0601C0B6 RID: 114870 RVA: 0x004125D1 File Offset: 0x004107D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb(TrapDefenseMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pollutedGridCells_ = other.pollutedGridCells_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C0B7 RID: 114871 RVA: 0x00412607 File Offset: 0x00410807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb Clone()
		{
			return new TrapDefenseMonsterKilledCtxPb(this);
		}

		// Token: 0x17005EED RID: 24301
		// (get) Token: 0x0601C0B8 RID: 114872 RVA: 0x0041260F File Offset: 0x0041080F
		// (set) Token: 0x0601C0B9 RID: 114873 RVA: 0x00412617 File Offset: 0x00410817
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

		// Token: 0x17005EEE RID: 24302
		// (get) Token: 0x0601C0BA RID: 114874 RVA: 0x00412620 File Offset: 0x00410820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridPlacementPbInfo> PollutedGridCells
		{
			get
			{
				return this.pollutedGridCells_;
			}
		}

		// Token: 0x0601C0BB RID: 114875 RVA: 0x00412628 File Offset: 0x00410828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterKilledCtxPb);
		}

		// Token: 0x0601C0BC RID: 114876 RVA: 0x00412638 File Offset: 0x00410838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.pollutedGridCells_.Equals(other.pollutedGridCells_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C0BD RID: 114877 RVA: 0x00412688 File Offset: 0x00410888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.pollutedGridCells_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C0BE RID: 114878 RVA: 0x004126D5 File Offset: 0x004108D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C0BF RID: 114879 RVA: 0x004126E2 File Offset: 0x004108E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C0C0 RID: 114880 RVA: 0x004126EC File Offset: 0x004108EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			this.pollutedGridCells_.WriteTo(ref output, TrapDefenseMonsterKilledCtxPb._repeated_pollutedGridCells_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C0C1 RID: 114881 RVA: 0x0041273C File Offset: 0x0041093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.pollutedGridCells_.CalculateSize(TrapDefenseMonsterKilledCtxPb._repeated_pollutedGridCells_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C0C2 RID: 114882 RVA: 0x00412790 File Offset: 0x00410990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseMonsterKilledCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.pollutedGridCells_.Add(other.pollutedGridCells_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C0C3 RID: 114883 RVA: 0x004127DD File Offset: 0x004109DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C0C4 RID: 114884 RVA: 0x004127E8 File Offset: 0x004109E8
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.pollutedGridCells_.AddEntriesFrom(ref input, TrapDefenseMonsterKilledCtxPb._repeated_pollutedGridCells_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A25E RID: 41566
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A25F RID: 41567
		public const int EntityIdFieldNumber = 1;

		// Token: 0x0400A260 RID: 41568
		private long entityId_;

		// Token: 0x0400A261 RID: 41569
		public const int PollutedGridCellsFieldNumber = 2;

		// Token: 0x0400A262 RID: 41570
		private static readonly FieldCodec<GridPlacementPbInfo> _repeated_pollutedGridCells_codec = FieldCodec.ForMessage<GridPlacementPbInfo>(18U, GridPlacementPbInfo.Parser);

		// Token: 0x0400A263 RID: 41571
		private readonly RepeatedField<GridPlacementPbInfo> pollutedGridCells_ = new RepeatedField<GridPlacementPbInfo>();
	}
}
