using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB9 RID: 2745
	public sealed class MowTowerCtx : IMessage<MowTowerCtx>, IMessage, IEquatable<MowTowerCtx>, IDeepCloneable<MowTowerCtx>, IBufferMessage
	{
		// Token: 0x0600EF5E RID: 61278 RVA: 0x0022FF2D File Offset: 0x0022E12D
		[NullableContext(1)]
		public static MowTowerCtx Create()
		{
			return new MowTowerCtx();
		}

		// Token: 0x170030B6 RID: 12470
		// (get) Token: 0x0600EF5F RID: 61279 RVA: 0x0022FF34 File Offset: 0x0022E134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170030B7 RID: 12471
		// (get) Token: 0x0600EF60 RID: 61280 RVA: 0x0022FF37 File Offset: 0x0022E137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerCtx.Descriptor;
			}
		}

		// Token: 0x0600EF61 RID: 61281 RVA: 0x0022FF3E File Offset: 0x0022E13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx()
		{
		}

		// Token: 0x0600EF62 RID: 61282 RVA: 0x0022FF5C File Offset: 0x0022E15C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx(MowTowerCtx other) : this()
		{
			this.levelsId_ = other.levelsId_;
			this.selectBuff_ = other.selectBuff_.Clone();
			this.secondRoles_ = other.secondRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EF63 RID: 61283 RVA: 0x0022FFAE File Offset: 0x0022E1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerCtx Clone()
		{
			return new MowTowerCtx(this);
		}

		// Token: 0x170030B8 RID: 12472
		// (get) Token: 0x0600EF64 RID: 61284 RVA: 0x0022FFB6 File Offset: 0x0022E1B6
		// (set) Token: 0x0600EF65 RID: 61285 RVA: 0x0022FFBE File Offset: 0x0022E1BE
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

		// Token: 0x170030B9 RID: 12473
		// (get) Token: 0x0600EF66 RID: 61286 RVA: 0x0022FFC7 File Offset: 0x0022E1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SelectBuff
		{
			get
			{
				return this.selectBuff_;
			}
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x0600EF67 RID: 61287 RVA: 0x0022FFCF File Offset: 0x0022E1CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SecondRoles
		{
			get
			{
				return this.secondRoles_;
			}
		}

		// Token: 0x0600EF68 RID: 61288 RVA: 0x0022FFD7 File Offset: 0x0022E1D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerCtx);
		}

		// Token: 0x0600EF69 RID: 61289 RVA: 0x0022FFE8 File Offset: 0x0022E1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerCtx other)
		{
			return other != null && (other == this || (this.LevelsId == other.LevelsId && this.selectBuff_.Equals(other.selectBuff_) && this.secondRoles_.Equals(other.secondRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EF6A RID: 61290 RVA: 0x0023004C File Offset: 0x0022E24C
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

		// Token: 0x0600EF6B RID: 61291 RVA: 0x002300A7 File Offset: 0x0022E2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EF6C RID: 61292 RVA: 0x002300B4 File Offset: 0x0022E2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EF6D RID: 61293 RVA: 0x002300C0 File Offset: 0x0022E2C0
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

		// Token: 0x0600EF6E RID: 61294 RVA: 0x00230120 File Offset: 0x0022E320
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

		// Token: 0x0600EF6F RID: 61295 RVA: 0x00230184 File Offset: 0x0022E384
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

		// Token: 0x0600EF70 RID: 61296 RVA: 0x002301E2 File Offset: 0x0022E3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EF71 RID: 61297 RVA: 0x002301EC File Offset: 0x0022E3EC
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

		// Token: 0x0400613C RID: 24892
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400613D RID: 24893
		public const int LevelsIdFieldNumber = 1;

		// Token: 0x0400613E RID: 24894
		private int levelsId_;

		// Token: 0x0400613F RID: 24895
		public const int SelectBuffFieldNumber = 2;

		// Token: 0x04006140 RID: 24896
		private static readonly FieldCodec<int> _repeated_selectBuff_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006141 RID: 24897
		private readonly RepeatedField<int> selectBuff_ = new RepeatedField<int>();

		// Token: 0x04006142 RID: 24898
		public const int SecondRolesFieldNumber = 3;

		// Token: 0x04006143 RID: 24899
		private static readonly FieldCodec<int> _repeated_secondRoles_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04006144 RID: 24900
		private readonly RepeatedField<int> secondRoles_ = new RepeatedField<int>();
	}
}
