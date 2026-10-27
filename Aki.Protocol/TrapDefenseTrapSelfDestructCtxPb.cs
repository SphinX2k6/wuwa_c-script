using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200145C RID: 5212
	public sealed class TrapDefenseTrapSelfDestructCtxPb : IMessage<TrapDefenseTrapSelfDestructCtxPb>, IMessage, IEquatable<TrapDefenseTrapSelfDestructCtxPb>, IDeepCloneable<TrapDefenseTrapSelfDestructCtxPb>, IBufferMessage
	{
		// Token: 0x0601B98C RID: 113036 RVA: 0x003FE910 File Offset: 0x003FCB10
		[NullableContext(1)]
		public static TrapDefenseTrapSelfDestructCtxPb Create()
		{
			return new TrapDefenseTrapSelfDestructCtxPb();
		}

		// Token: 0x17005D0C RID: 23820
		// (get) Token: 0x0601B98D RID: 113037 RVA: 0x003FE917 File Offset: 0x003FCB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D0D RID: 23821
		// (get) Token: 0x0601B98E RID: 113038 RVA: 0x003FE91A File Offset: 0x003FCB1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseTrapSelfDestructCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B98F RID: 113039 RVA: 0x003FE921 File Offset: 0x003FCB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb()
		{
		}

		// Token: 0x0601B990 RID: 113040 RVA: 0x003FE934 File Offset: 0x003FCB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb(TrapDefenseTrapSelfDestructCtxPb other) : this()
		{
			this.damagedGridCells_ = other.damagedGridCells_.Clone();
			this.fireCount_ = other.fireCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B991 RID: 113041 RVA: 0x003FE96A File Offset: 0x003FCB6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseTrapSelfDestructCtxPb Clone()
		{
			return new TrapDefenseTrapSelfDestructCtxPb(this);
		}

		// Token: 0x17005D0E RID: 23822
		// (get) Token: 0x0601B992 RID: 113042 RVA: 0x003FE972 File Offset: 0x003FCB72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GridPlacementPbInfo> DamagedGridCells
		{
			get
			{
				return this.damagedGridCells_;
			}
		}

		// Token: 0x17005D0F RID: 23823
		// (get) Token: 0x0601B993 RID: 113043 RVA: 0x003FE97A File Offset: 0x003FCB7A
		// (set) Token: 0x0601B994 RID: 113044 RVA: 0x003FE982 File Offset: 0x003FCB82
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

		// Token: 0x0601B995 RID: 113045 RVA: 0x003FE98B File Offset: 0x003FCB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseTrapSelfDestructCtxPb);
		}

		// Token: 0x0601B996 RID: 113046 RVA: 0x003FE99C File Offset: 0x003FCB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseTrapSelfDestructCtxPb other)
		{
			return other != null && (other == this || (this.damagedGridCells_.Equals(other.damagedGridCells_) && this.FireCount == other.FireCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B997 RID: 113047 RVA: 0x003FE9EC File Offset: 0x003FCBEC
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

		// Token: 0x0601B998 RID: 113048 RVA: 0x003FEA39 File Offset: 0x003FCC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B999 RID: 113049 RVA: 0x003FEA46 File Offset: 0x003FCC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B99A RID: 113050 RVA: 0x003FEA50 File Offset: 0x003FCC50
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

		// Token: 0x0601B99B RID: 113051 RVA: 0x003FEAA0 File Offset: 0x003FCCA0
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

		// Token: 0x0601B99C RID: 113052 RVA: 0x003FEAF4 File Offset: 0x003FCCF4
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

		// Token: 0x0601B99D RID: 113053 RVA: 0x003FEB41 File Offset: 0x003FCD41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B99E RID: 113054 RVA: 0x003FEB4C File Offset: 0x003FCD4C
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

		// Token: 0x04009F0C RID: 40716
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F0D RID: 40717
		public const int DamagedGridCellsFieldNumber = 1;

		// Token: 0x04009F0E RID: 40718
		private static readonly FieldCodec<GridPlacementPbInfo> _repeated_damagedGridCells_codec = FieldCodec.ForMessage<GridPlacementPbInfo>(10U, GridPlacementPbInfo.Parser);

		// Token: 0x04009F0F RID: 40719
		private readonly RepeatedField<GridPlacementPbInfo> damagedGridCells_ = new RepeatedField<GridPlacementPbInfo>();

		// Token: 0x04009F10 RID: 40720
		public const int FireCountFieldNumber = 2;

		// Token: 0x04009F11 RID: 40721
		private int fireCount_;
	}
}
