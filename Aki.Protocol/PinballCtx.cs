using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D33 RID: 3379
	public sealed class PinballCtx : IMessage<PinballCtx>, IMessage, IEquatable<PinballCtx>, IDeepCloneable<PinballCtx>, IBufferMessage
	{
		// Token: 0x0601241A RID: 74778 RVA: 0x002AA94B File Offset: 0x002A8B4B
		[NullableContext(1)]
		public static PinballCtx Create()
		{
			return new PinballCtx();
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x0601241B RID: 74779 RVA: 0x002AA952 File Offset: 0x002A8B52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C7D RID: 15485
		// (get) Token: 0x0601241C RID: 74780 RVA: 0x002AA955 File Offset: 0x002A8B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballCtx.Descriptor;
			}
		}

		// Token: 0x0601241D RID: 74781 RVA: 0x002AA95C File Offset: 0x002A8B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx()
		{
		}

		// Token: 0x0601241E RID: 74782 RVA: 0x002AA96F File Offset: 0x002A8B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx(PinballCtx other) : this()
		{
			this.levelId_ = other.levelId_;
			this.formationRoles_ = other.formationRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601241F RID: 74783 RVA: 0x002AA9A5 File Offset: 0x002A8BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx Clone()
		{
			return new PinballCtx(this);
		}

		// Token: 0x17003C7E RID: 15486
		// (get) Token: 0x06012420 RID: 74784 RVA: 0x002AA9AD File Offset: 0x002A8BAD
		// (set) Token: 0x06012421 RID: 74785 RVA: 0x002AA9B5 File Offset: 0x002A8BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17003C7F RID: 15487
		// (get) Token: 0x06012422 RID: 74786 RVA: 0x002AA9BE File Offset: 0x002A8BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FormationRoles
		{
			get
			{
				return this.formationRoles_;
			}
		}

		// Token: 0x06012423 RID: 74787 RVA: 0x002AA9C6 File Offset: 0x002A8BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballCtx);
		}

		// Token: 0x06012424 RID: 74788 RVA: 0x002AA9D4 File Offset: 0x002A8BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballCtx other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.formationRoles_.Equals(other.formationRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012425 RID: 74789 RVA: 0x002AAA24 File Offset: 0x002A8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.formationRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012426 RID: 74790 RVA: 0x002AAA71 File Offset: 0x002A8C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012427 RID: 74791 RVA: 0x002AAA7E File Offset: 0x002A8C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012428 RID: 74792 RVA: 0x002AAA88 File Offset: 0x002A8C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			this.formationRoles_.WriteTo(ref output, PinballCtx._repeated_formationRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012429 RID: 74793 RVA: 0x002AAAD8 File Offset: 0x002A8CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.formationRoles_.CalculateSize(PinballCtx._repeated_formationRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601242A RID: 74794 RVA: 0x002AAB2C File Offset: 0x002A8D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.formationRoles_.Add(other.formationRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601242B RID: 74795 RVA: 0x002AAB79 File Offset: 0x002A8D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601242C RID: 74796 RVA: 0x002AAB84 File Offset: 0x002A8D84
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formationRoles_.AddEntriesFrom(ref input, PinballCtx._repeated_formationRoles_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007243 RID: 29251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007244 RID: 29252
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04007245 RID: 29253
		private int levelId_;

		// Token: 0x04007246 RID: 29254
		public const int FormationRolesFieldNumber = 2;

		// Token: 0x04007247 RID: 29255
		private static readonly FieldCodec<int> _repeated_formationRoles_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007248 RID: 29256
		private readonly RepeatedField<int> formationRoles_ = new RepeatedField<int>();
	}
}
