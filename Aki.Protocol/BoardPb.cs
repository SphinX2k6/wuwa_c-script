using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BD RID: 445
	public sealed class BoardPb : IMessage<BoardPb>, IMessage, IEquatable<BoardPb>, IDeepCloneable<BoardPb>, IBufferMessage
	{
		// Token: 0x0600339E RID: 13214 RVA: 0x00082DEE File Offset: 0x00080FEE
		[NullableContext(1)]
		public static BoardPb Create()
		{
			return new BoardPb();
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600339F RID: 13215 RVA: 0x00082DF5 File Offset: 0x00080FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x00082DF8 File Offset: 0x00080FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardPb.Descriptor;
			}
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00082DFF File Offset: 0x00080FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb()
		{
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00082E20 File Offset: 0x00081020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb(BoardPb other) : this()
		{
			this.occupiedGridList_ = other.occupiedGridList_.Clone();
			this.dynamicGridConfigs_ = other.dynamicGridConfigs_.Clone();
			this.canMove_ = other.canMove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00082E72 File Offset: 0x00081072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb Clone()
		{
			return new BoardPb(this);
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00082E7A File Offset: 0x0008107A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupiedBoardGridInfo> OccupiedGridList
		{
			get
			{
				return this.occupiedGridList_;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x00082E82 File Offset: 0x00081082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoardGridDynamicConfig> DynamicGridConfigs
		{
			get
			{
				return this.dynamicGridConfigs_;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060033A6 RID: 13222 RVA: 0x00082E8A File Offset: 0x0008108A
		// (set) Token: 0x060033A7 RID: 13223 RVA: 0x00082E92 File Offset: 0x00081092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanMove
		{
			get
			{
				return this.canMove_;
			}
			set
			{
				this.canMove_ = value;
			}
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00082E9B File Offset: 0x0008109B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardPb);
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00082EAC File Offset: 0x000810AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardPb other)
		{
			return other != null && (other == this || (this.occupiedGridList_.Equals(other.occupiedGridList_) && this.dynamicGridConfigs_.Equals(other.dynamicGridConfigs_) && this.CanMove == other.CanMove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x00082F10 File Offset: 0x00081110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.occupiedGridList_.GetHashCode();
			num ^= this.dynamicGridConfigs_.GetHashCode();
			if (this.CanMove)
			{
				num ^= this.CanMove.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00082F6B File Offset: 0x0008116B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00082F78 File Offset: 0x00081178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00082F84 File Offset: 0x00081184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.occupiedGridList_.WriteTo(ref output, BoardPb._repeated_occupiedGridList_codec);
			this.dynamicGridConfigs_.WriteTo(ref output, BoardPb._repeated_dynamicGridConfigs_codec);
			if (this.CanMove)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanMove);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00082FE4 File Offset: 0x000811E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.occupiedGridList_.CalculateSize(BoardPb._repeated_occupiedGridList_codec);
			num += this.dynamicGridConfigs_.CalculateSize(BoardPb._repeated_dynamicGridConfigs_codec);
			if (this.CanMove)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0008303C File Offset: 0x0008123C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoardPb other)
		{
			if (other == null)
			{
				return;
			}
			this.occupiedGridList_.Add(other.occupiedGridList_);
			this.dynamicGridConfigs_.Add(other.dynamicGridConfigs_);
			if (other.CanMove)
			{
				this.CanMove = other.CanMove;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0008309A File Offset: 0x0008129A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000830A4 File Offset: 0x000812A4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CanMove = input.ReadBool();
						}
					}
					else
					{
						this.dynamicGridConfigs_.AddEntriesFrom(ref input, BoardPb._repeated_dynamicGridConfigs_codec);
					}
				}
				else
				{
					this.occupiedGridList_.AddEntriesFrom(ref input, BoardPb._repeated_occupiedGridList_codec);
				}
			}
		}

		// Token: 0x04002A1E RID: 10782
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A1F RID: 10783
		public const int OccupiedGridListFieldNumber = 1;

		// Token: 0x04002A20 RID: 10784
		private static readonly FieldCodec<OccupiedBoardGridInfo> _repeated_occupiedGridList_codec = FieldCodec.ForMessage<OccupiedBoardGridInfo>(10U, OccupiedBoardGridInfo.Parser);

		// Token: 0x04002A21 RID: 10785
		private readonly RepeatedField<OccupiedBoardGridInfo> occupiedGridList_ = new RepeatedField<OccupiedBoardGridInfo>();

		// Token: 0x04002A22 RID: 10786
		public const int DynamicGridConfigsFieldNumber = 2;

		// Token: 0x04002A23 RID: 10787
		private static readonly FieldCodec<BoardGridDynamicConfig> _repeated_dynamicGridConfigs_codec = FieldCodec.ForMessage<BoardGridDynamicConfig>(18U, BoardGridDynamicConfig.Parser);

		// Token: 0x04002A24 RID: 10788
		private readonly RepeatedField<BoardGridDynamicConfig> dynamicGridConfigs_ = new RepeatedField<BoardGridDynamicConfig>();

		// Token: 0x04002A25 RID: 10789
		public const int CanMoveFieldNumber = 3;

		// Token: 0x04002A26 RID: 10790
		private bool canMove_;
	}
}
