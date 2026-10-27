using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B9 RID: 441
	public sealed class BoardPb : IMessage<BoardPb>, IMessage, IEquatable<BoardPb>, IDeepCloneable<BoardPb>, IBufferMessage
	{
		// Token: 0x06003311 RID: 13073 RVA: 0x0008167E File Offset: 0x0007F87E
		[NullableContext(1)]
		public static BoardPb Create()
		{
			return new BoardPb();
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x00081685 File Offset: 0x0007F885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00081688 File Offset: 0x0007F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardPb.Descriptor;
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0008168F File Offset: 0x0007F88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb()
		{
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000816B0 File Offset: 0x0007F8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb(BoardPb other) : this()
		{
			this.occupiedGridList_ = other.occupiedGridList_.Clone();
			this.dynamicGridConfigs_ = other.dynamicGridConfigs_.Clone();
			this.canMove_ = other.canMove_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00081702 File Offset: 0x0007F902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardPb Clone()
		{
			return new BoardPb(this);
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003317 RID: 13079 RVA: 0x0008170A File Offset: 0x0007F90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OccupiedBoardGridInfo> OccupiedGridList
		{
			get
			{
				return this.occupiedGridList_;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003318 RID: 13080 RVA: 0x00081712 File Offset: 0x0007F912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BoardGridDynamicConfig> DynamicGridConfigs
		{
			get
			{
				return this.dynamicGridConfigs_;
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003319 RID: 13081 RVA: 0x0008171A File Offset: 0x0007F91A
		// (set) Token: 0x0600331A RID: 13082 RVA: 0x00081722 File Offset: 0x0007F922
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

		// Token: 0x0600331B RID: 13083 RVA: 0x0008172B File Offset: 0x0007F92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardPb);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x0008173C File Offset: 0x0007F93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardPb other)
		{
			return other != null && (other == this || (this.occupiedGridList_.Equals(other.occupiedGridList_) && this.dynamicGridConfigs_.Equals(other.dynamicGridConfigs_) && this.CanMove == other.CanMove && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000817A0 File Offset: 0x0007F9A0
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

		// Token: 0x0600331E RID: 13086 RVA: 0x000817FB File Offset: 0x0007F9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00081808 File Offset: 0x0007FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00081814 File Offset: 0x0007FA14
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

		// Token: 0x06003321 RID: 13089 RVA: 0x00081874 File Offset: 0x0007FA74
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

		// Token: 0x06003322 RID: 13090 RVA: 0x000818CC File Offset: 0x0007FACC
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

		// Token: 0x06003323 RID: 13091 RVA: 0x0008192A File Offset: 0x0007FB2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00081934 File Offset: 0x0007FB34
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

		// Token: 0x040029A3 RID: 10659
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029A4 RID: 10660
		public const int OccupiedGridListFieldNumber = 1;

		// Token: 0x040029A5 RID: 10661
		private static readonly FieldCodec<OccupiedBoardGridInfo> _repeated_occupiedGridList_codec = FieldCodec.ForMessage<OccupiedBoardGridInfo>(10U, OccupiedBoardGridInfo.Parser);

		// Token: 0x040029A6 RID: 10662
		private readonly RepeatedField<OccupiedBoardGridInfo> occupiedGridList_ = new RepeatedField<OccupiedBoardGridInfo>();

		// Token: 0x040029A7 RID: 10663
		public const int DynamicGridConfigsFieldNumber = 2;

		// Token: 0x040029A8 RID: 10664
		private static readonly FieldCodec<BoardGridDynamicConfig> _repeated_dynamicGridConfigs_codec = FieldCodec.ForMessage<BoardGridDynamicConfig>(18U, BoardGridDynamicConfig.Parser);

		// Token: 0x040029A9 RID: 10665
		private readonly RepeatedField<BoardGridDynamicConfig> dynamicGridConfigs_ = new RepeatedField<BoardGridDynamicConfig>();

		// Token: 0x040029AA RID: 10666
		public const int CanMoveFieldNumber = 3;

		// Token: 0x040029AB RID: 10667
		private bool canMove_;
	}
}
