using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D43 RID: 3395
	public sealed class PinballCtx : IMessage<PinballCtx>, IMessage, IEquatable<PinballCtx>, IDeepCloneable<PinballCtx>, IBufferMessage
	{
		// Token: 0x06012516 RID: 75030 RVA: 0x002AC56B File Offset: 0x002AA76B
		[NullableContext(1)]
		public static PinballCtx Create()
		{
			return new PinballCtx();
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x06012517 RID: 75031 RVA: 0x002AC572 File Offset: 0x002AA772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x06012518 RID: 75032 RVA: 0x002AC575 File Offset: 0x002AA775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballCtx.Descriptor;
			}
		}

		// Token: 0x06012519 RID: 75033 RVA: 0x002AC57C File Offset: 0x002AA77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx()
		{
		}

		// Token: 0x0601251A RID: 75034 RVA: 0x002AC58F File Offset: 0x002AA78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx(PinballCtx other) : this()
		{
			this.levelId_ = other.levelId_;
			this.formationRoles_ = other.formationRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601251B RID: 75035 RVA: 0x002AC5C5 File Offset: 0x002AA7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballCtx Clone()
		{
			return new PinballCtx(this);
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0601251C RID: 75036 RVA: 0x002AC5CD File Offset: 0x002AA7CD
		// (set) Token: 0x0601251D RID: 75037 RVA: 0x002AC5D5 File Offset: 0x002AA7D5
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

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0601251E RID: 75038 RVA: 0x002AC5DE File Offset: 0x002AA7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FormationRoles
		{
			get
			{
				return this.formationRoles_;
			}
		}

		// Token: 0x0601251F RID: 75039 RVA: 0x002AC5E6 File Offset: 0x002AA7E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballCtx);
		}

		// Token: 0x06012520 RID: 75040 RVA: 0x002AC5F4 File Offset: 0x002AA7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballCtx other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.formationRoles_.Equals(other.formationRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012521 RID: 75041 RVA: 0x002AC644 File Offset: 0x002AA844
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

		// Token: 0x06012522 RID: 75042 RVA: 0x002AC691 File Offset: 0x002AA891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012523 RID: 75043 RVA: 0x002AC69E File Offset: 0x002AA89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012524 RID: 75044 RVA: 0x002AC6A8 File Offset: 0x002AA8A8
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

		// Token: 0x06012525 RID: 75045 RVA: 0x002AC6F8 File Offset: 0x002AA8F8
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

		// Token: 0x06012526 RID: 75046 RVA: 0x002AC74C File Offset: 0x002AA94C
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

		// Token: 0x06012527 RID: 75047 RVA: 0x002AC799 File Offset: 0x002AA999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012528 RID: 75048 RVA: 0x002AC7A4 File Offset: 0x002AA9A4
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

		// Token: 0x0400722B RID: 29227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400722C RID: 29228
		public const int LevelIdFieldNumber = 1;

		// Token: 0x0400722D RID: 29229
		private int levelId_;

		// Token: 0x0400722E RID: 29230
		public const int FormationRolesFieldNumber = 2;

		// Token: 0x0400722F RID: 29231
		private static readonly FieldCodec<int> _repeated_formationRoles_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04007230 RID: 29232
		private readonly RepeatedField<int> formationRoles_ = new RepeatedField<int>();
	}
}
