using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001431 RID: 5169
	public sealed class TrapDefenseMonsterKilledCtxPb : IMessage<TrapDefenseMonsterKilledCtxPb>, IMessage, IEquatable<TrapDefenseMonsterKilledCtxPb>, IDeepCloneable<TrapDefenseMonsterKilledCtxPb>, IBufferMessage
	{
		// Token: 0x0601B627 RID: 112167 RVA: 0x003F72D9 File Offset: 0x003F54D9
		[NullableContext(1)]
		public static TrapDefenseMonsterKilledCtxPb Create()
		{
			return new TrapDefenseMonsterKilledCtxPb();
		}

		// Token: 0x17005C56 RID: 23638
		// (get) Token: 0x0601B628 RID: 112168 RVA: 0x003F72E0 File Offset: 0x003F54E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C57 RID: 23639
		// (get) Token: 0x0601B629 RID: 112169 RVA: 0x003F72E3 File Offset: 0x003F54E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseMonsterKilledCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B62A RID: 112170 RVA: 0x003F72EA File Offset: 0x003F54EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb()
		{
		}

		// Token: 0x0601B62B RID: 112171 RVA: 0x003F72FD File Offset: 0x003F54FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb(TrapDefenseMonsterKilledCtxPb other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pollutedGridCells_ = other.pollutedGridCells_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B62C RID: 112172 RVA: 0x003F7333 File Offset: 0x003F5533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterKilledCtxPb Clone()
		{
			return new TrapDefenseMonsterKilledCtxPb(this);
		}

		// Token: 0x17005C58 RID: 23640
		// (get) Token: 0x0601B62D RID: 112173 RVA: 0x003F733B File Offset: 0x003F553B
		// (set) Token: 0x0601B62E RID: 112174 RVA: 0x003F7343 File Offset: 0x003F5543
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

		// Token: 0x17005C59 RID: 23641
		// (get) Token: 0x0601B62F RID: 112175 RVA: 0x003F734C File Offset: 0x003F554C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridPlacementPbInfo> PollutedGridCells
		{
			get
			{
				return this.pollutedGridCells_;
			}
		}

		// Token: 0x0601B630 RID: 112176 RVA: 0x003F7354 File Offset: 0x003F5554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseMonsterKilledCtxPb);
		}

		// Token: 0x0601B631 RID: 112177 RVA: 0x003F7364 File Offset: 0x003F5564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseMonsterKilledCtxPb other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.pollutedGridCells_.Equals(other.pollutedGridCells_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B632 RID: 112178 RVA: 0x003F73B4 File Offset: 0x003F55B4
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

		// Token: 0x0601B633 RID: 112179 RVA: 0x003F7401 File Offset: 0x003F5601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B634 RID: 112180 RVA: 0x003F740E File Offset: 0x003F560E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B635 RID: 112181 RVA: 0x003F7418 File Offset: 0x003F5618
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

		// Token: 0x0601B636 RID: 112182 RVA: 0x003F7468 File Offset: 0x003F5668
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

		// Token: 0x0601B637 RID: 112183 RVA: 0x003F74BC File Offset: 0x003F56BC
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

		// Token: 0x0601B638 RID: 112184 RVA: 0x003F7509 File Offset: 0x003F5709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B639 RID: 112185 RVA: 0x003F7514 File Offset: 0x003F5714
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

		// Token: 0x04009E17 RID: 40471
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E18 RID: 40472
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009E19 RID: 40473
		private long entityId_;

		// Token: 0x04009E1A RID: 40474
		public const int PollutedGridCellsFieldNumber = 2;

		// Token: 0x04009E1B RID: 40475
		private static readonly FieldCodec<GridPlacementPbInfo> _repeated_pollutedGridCells_codec = FieldCodec.ForMessage<GridPlacementPbInfo>(18U, GridPlacementPbInfo.Parser);

		// Token: 0x04009E1C RID: 40476
		private readonly RepeatedField<GridPlacementPbInfo> pollutedGridCells_ = new RepeatedField<GridPlacementPbInfo>();
	}
}
