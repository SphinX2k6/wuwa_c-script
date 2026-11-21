using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000622 RID: 1570
	[NetMessage(EMessageId.FormationUpdateNotify)]
	public sealed class FormationUpdateNotify : IMessage<FormationUpdateNotify>, IMessage, IEquatable<FormationUpdateNotify>, IDeepCloneable<FormationUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600912E RID: 37166 RVA: 0x0015FC2C File Offset: 0x0015DE2C
		[NullableContext(1)]
		public static FormationUpdateNotify Create()
		{
			return new FormationUpdateNotify();
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x0015FC33 File Offset: 0x0015DE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x0015FC36 File Offset: 0x0015DE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x0015FC3D File Offset: 0x0015DE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify()
		{
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x0015FC5C File Offset: 0x0015DE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify(FormationUpdateNotify other) : this()
		{
			this.removeFormationIds_ = other.removeFormationIds_.Clone();
			this.formation_ = other.formation_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009133 RID: 37171 RVA: 0x0015FCAE File Offset: 0x0015DEAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify Clone()
		{
			return new FormationUpdateNotify(this);
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06009134 RID: 37172 RVA: 0x0015FCB6 File Offset: 0x0015DEB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveFormationIds
		{
			get
			{
				return this.removeFormationIds_;
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06009135 RID: 37173 RVA: 0x0015FCBE File Offset: 0x0015DEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x0015FCC6 File Offset: 0x0015DEC6
		// (set) Token: 0x06009137 RID: 37175 RVA: 0x0015FCCE File Offset: 0x0015DECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FormationId
		{
			get
			{
				return this.formationId_;
			}
			set
			{
				this.formationId_ = value;
			}
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x0015FCD7 File Offset: 0x0015DED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationUpdateNotify);
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x0015FCE8 File Offset: 0x0015DEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationUpdateNotify other)
		{
			return other != null && (other == this || (this.removeFormationIds_.Equals(other.removeFormationIds_) && this.formation_.Equals(other.formation_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600913A RID: 37178 RVA: 0x0015FD4C File Offset: 0x0015DF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.removeFormationIds_.GetHashCode();
			num ^= this.formation_.GetHashCode();
			if (this.FormationId != 0)
			{
				num ^= this.FormationId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x0015FDA7 File Offset: 0x0015DFA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x0015FDB4 File Offset: 0x0015DFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0015FDC0 File Offset: 0x0015DFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FormationId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FormationId);
			}
			this.formation_.WriteTo(ref output, FormationUpdateNotify._repeated_formation_codec);
			this.removeFormationIds_.WriteTo(ref output, FormationUpdateNotify._repeated_removeFormationIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0015FE20 File Offset: 0x0015E020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.removeFormationIds_.CalculateSize(FormationUpdateNotify._repeated_removeFormationIds_codec);
			num += this.formation_.CalculateSize(FormationUpdateNotify._repeated_formation_codec);
			if (this.FormationId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x0015FE84 File Offset: 0x0015E084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.removeFormationIds_.Add(other.removeFormationIds_);
			this.formation_.Add(other.formation_);
			if (other.FormationId != 0)
			{
				this.FormationId = other.FormationId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009140 RID: 37184 RVA: 0x0015FEE2 File Offset: 0x0015E0E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x0015FEEC File Offset: 0x0015E0EC
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
				if (num <= 98U)
				{
					if (num == 48U)
					{
						this.FormationId = input.ReadInt32();
						continue;
					}
					if (num == 98U)
					{
						this.formation_.AddEntriesFrom(ref input, FormationUpdateNotify._repeated_formation_codec);
						continue;
					}
				}
				else if (num == 104U || num == 106U)
				{
					this.removeFormationIds_.AddEntriesFrom(ref input, FormationUpdateNotify._repeated_removeFormationIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004693 RID: 18067
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004694 RID: 18068
		public const int RemoveFormationIdsFieldNumber = 13;

		// Token: 0x04004695 RID: 18069
		private static readonly FieldCodec<int> _repeated_removeFormationIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04004696 RID: 18070
		private readonly RepeatedField<int> removeFormationIds_ = new RepeatedField<int>();

		// Token: 0x04004697 RID: 18071
		public const int FormationFieldNumber = 12;

		// Token: 0x04004698 RID: 18072
		private static readonly FieldCodec<FightFormation> _repeated_formation_codec = FieldCodec.ForMessage<FightFormation>(98U, FightFormation.Parser);

		// Token: 0x04004699 RID: 18073
		private readonly RepeatedField<FightFormation> formation_ = new RepeatedField<FightFormation>();

		// Token: 0x0400469A RID: 18074
		public const int FormationIdFieldNumber = 6;

		// Token: 0x0400469B RID: 18075
		private int formationId_;
	}
}
