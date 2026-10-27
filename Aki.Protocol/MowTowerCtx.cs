using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACA RID: 2762
	public sealed class MowTowerCtx : IMessage<MowTowerCtx>, IMessage, IEquatable<MowTowerCtx>, IDeepCloneable<MowTowerCtx>, IBufferMessage
	{
		// Token: 0x0600F078 RID: 61560 RVA: 0x00232139 File Offset: 0x00230339
		[NullableContext(1)]
		public static MowTowerCtx Create()
		{
			return new MowTowerCtx();
		}

		// Token: 0x170030F4 RID: 12532
		// (get) Token: 0x0600F079 RID: 61561 RVA: 0x00232140 File Offset: 0x00230340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x0600F07A RID: 61562 RVA: 0x00232143 File Offset: 0x00230343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerCtx.Descriptor;
			}
		}

		// Token: 0x0600F07B RID: 61563 RVA: 0x0023214A File Offset: 0x0023034A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx()
		{
		}

		// Token: 0x0600F07C RID: 61564 RVA: 0x00232168 File Offset: 0x00230368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx(MowTowerCtx other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.selectBuff_ = other.selectBuff_.Clone();
			this.secondRoles_ = other.secondRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F07D RID: 61565 RVA: 0x002321BA File Offset: 0x002303BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx Clone()
		{
			return new MowTowerCtx(this);
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x0600F07E RID: 61566 RVA: 0x002321C2 File Offset: 0x002303C2
		// (set) Token: 0x0600F07F RID: 61567 RVA: 0x002321CA File Offset: 0x002303CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelsId
		{
			get
			{
				return this.levelsId_;
			}
			set
			{
				this.levelsId_ = value;
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x002321D3 File Offset: 0x002303D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600F081 RID: 61569 RVA: 0x002321DB File Offset: 0x002303DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoles
		{
			get
			{
				return this.secondRoles_;
			}
		}

		// Token: 0x0600F082 RID: 61570 RVA: 0x002321E3 File Offset: 0x002303E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerCtx);
		}

		// Token: 0x0600F083 RID: 61571 RVA: 0x002321F4 File Offset: 0x002303F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.secondRoles_.Equals(other.secondRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F084 RID: 61572 RVA: 0x00232258 File Offset: 0x00230458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelsId != 0)
			{
				num ^= this.LevelsId.GetHashCode();
			}
			num ^= this.selectBuff_.GetHashCode();
			num ^= this.secondRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F085 RID: 61573 RVA: 0x002322B3 File Offset: 0x002304B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F086 RID: 61574 RVA: 0x002322C0 File Offset: 0x002304C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F087 RID: 61575 RVA: 0x002322CC File Offset: 0x002304CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelsId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelsId);
			}
			this.selectBuff_.WriteTo(ref output, MowTowerCtx._repeated_selectBuff_codec);
			this.secondRoles_.WriteTo(ref output, MowTowerCtx._repeated_secondRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F088 RID: 61576 RVA: 0x0023232C File Offset: 0x0023052C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelsId);
			}
			num += this.selectBuff_.CalculateSize(MowTowerCtx._repeated_selectBuff_codec);
			num += this.secondRoles_.CalculateSize(MowTowerCtx._repeated_secondRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F089 RID: 61577 RVA: 0x00232390 File Offset: 0x00230590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelsId != 0)
			{
				this.LevelsId = other.LevelsId;
			}
			this.selectBuff_.Add(other.selectBuff_);
			this.secondRoles_.Add(other.secondRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F08A RID: 61578 RVA: 0x002323EE File Offset: 0x002305EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F08B RID: 61579 RVA: 0x002323F8 File Offset: 0x002305F8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.LevelsId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.secondRoles_.AddEntriesFrom(ref input, MowTowerCtx._repeated_secondRoles_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.selectBuff_.AddEntriesFrom(ref input, MowTowerCtx._repeated_selectBuff_codec);
			}
		}

		// Token: 0x04006133 RID: 24883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006134 RID: 24884
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x04006135 RID: 24885
		private int levelsId_;

		// Token: 0x04006136 RID: 24886
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x04006137 RID: 24887
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006138 RID: 24888
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x04006139 RID: 24889
		public const int SecondRolesFieldNumber = 3;

		// Token: 0x0400613A RID: 24890
		private static readonly FieldCodec<int> _repeated_secondRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400613B RID: 24891
		private readonly RepeatedField<int> secondRoles_ = new RepeatedField<int>();
	}
}
