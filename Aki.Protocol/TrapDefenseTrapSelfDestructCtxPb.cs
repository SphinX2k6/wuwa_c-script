using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CF RID: 5327
	public sealed class TrapDefenseTrapSelfDestructCtxPb : IMessage<TrapDefenseTrapSelfDestructCtxPb>, IMessage, IEquatable<TrapDefenseTrapSelfDestructCtxPb>, IDeepCloneable<TrapDefenseTrapSelfDestructCtxPb>, IBufferMessage
	{
		// Token: 0x0601C417 RID: 115735 RVA: 0x00419BE4 File Offset: 0x00417DE4
		[NullableContext(1)]
		public static TrapDefenseTrapSelfDestructCtxPb Create()
		{
			return new TrapDefenseTrapSelfDestructCtxPb();
		}

		// Token: 0x17005FA1 RID: 24481
		// (get) Token: 0x0601C418 RID: 115736 RVA: 0x00419BEB File Offset: 0x00417DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FA2 RID: 24482
		// (get) Token: 0x0601C419 RID: 115737 RVA: 0x00419BEE File Offset: 0x00417DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTrapSelfDestructCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C41A RID: 115738 RVA: 0x00419BF5 File Offset: 0x00417DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb()
		{
		}

		// Token: 0x0601C41B RID: 115739 RVA: 0x00419C08 File Offset: 0x00417E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb(TrapDefenseTrapSelfDestructCtxPb other) : this()
		{
			this.damagedGridCells_ = other.damagedGridCells_.Clone();
			this.fireCount_ = other.fireCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C41C RID: 115740 RVA: 0x00419C3E File Offset: 0x00417E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb Clone()
		{
			return new TrapDefenseTrapSelfDestructCtxPb(this);
		}

		// Token: 0x17005FA3 RID: 24483
		// (get) Token: 0x0601C41D RID: 115741 RVA: 0x00419C46 File Offset: 0x00417E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridPlacementPbInfo> DamagedGridCells
		{
			get
			{
				return this.damagedGridCells_;
			}
		}

		// Token: 0x17005FA4 RID: 24484
		// (get) Token: 0x0601C41E RID: 115742 RVA: 0x00419C4E File Offset: 0x00417E4E
		// (set) Token: 0x0601C41F RID: 115743 RVA: 0x00419C56 File Offset: 0x00417E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FireCount
		{
			get
			{
				return this.fireCount_;
			}
			set
			{
				this.fireCount_ = value;
			}
		}

		// Token: 0x0601C420 RID: 115744 RVA: 0x00419C5F File Offset: 0x00417E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTrapSelfDestructCtxPb);
		}

		// Token: 0x0601C421 RID: 115745 RVA: 0x00419C70 File Offset: 0x00417E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTrapSelfDestructCtxPb other)
		{
			return other != null && (other == this || (this.damagedGridCells_.Equals(other.damagedGridCells_) && this.FireCount == other.FireCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C422 RID: 115746 RVA: 0x00419CC0 File Offset: 0x00417EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.damagedGridCells_.GetHashCode();
			if (this.FireCount != 0)
			{
				num ^= this.FireCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C423 RID: 115747 RVA: 0x00419D0D File Offset: 0x00417F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C424 RID: 115748 RVA: 0x00419D1A File Offset: 0x00417F1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C425 RID: 115749 RVA: 0x00419D24 File Offset: 0x00417F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.damagedGridCells_.WriteTo(ref output, TrapDefenseTrapSelfDestructCtxPb._repeated_damagedGridCells_codec);
			if (this.FireCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.FireCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C426 RID: 115750 RVA: 0x00419D74 File Offset: 0x00417F74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.damagedGridCells_.CalculateSize(TrapDefenseTrapSelfDestructCtxPb._repeated_damagedGridCells_codec);
			if (this.FireCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FireCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C427 RID: 115751 RVA: 0x00419DC8 File Offset: 0x00417FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseTrapSelfDestructCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this.damagedGridCells_.Add(other.damagedGridCells_);
			if (other.FireCount != 0)
			{
				this.FireCount = other.FireCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C428 RID: 115752 RVA: 0x00419E15 File Offset: 0x00418015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C429 RID: 115753 RVA: 0x00419E20 File Offset: 0x00418020
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FireCount = input.ReadInt32();
					}
				}
				else
				{
					this.damagedGridCells_.AddEntriesFrom(ref input, TrapDefenseTrapSelfDestructCtxPb._repeated_damagedGridCells_codec);
				}
			}
		}

		// Token: 0x0400A353 RID: 41811
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A354 RID: 41812
		public const int DamagedGridCellsFieldNumber = 1;

		// Token: 0x0400A355 RID: 41813
		private static readonly FieldCodec<GridPlacementPbInfo> _repeated_damagedGridCells_codec = FieldCodec.ForMessage<GridPlacementPbInfo>(10U, GridPlacementPbInfo.Parser);

		// Token: 0x0400A356 RID: 41814
		private readonly RepeatedField<GridPlacementPbInfo> damagedGridCells_ = new RepeatedField<GridPlacementPbInfo>();

		// Token: 0x0400A357 RID: 41815
		public const int FireCountFieldNumber = 2;

		// Token: 0x0400A358 RID: 41816
		private int fireCount_;
	}
}
