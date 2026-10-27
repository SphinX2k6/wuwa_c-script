using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000636 RID: 1590
	[NetMessage(EMessageId.FormationUpdateNotify)]
	public sealed class FormationUpdateNotify : IMessage<FormationUpdateNotify>, IMessage, IEquatable<FormationUpdateNotify>, IDeepCloneable<FormationUpdateNotify>, IBufferMessage
	{
		// Token: 0x06009284 RID: 37508 RVA: 0x00162658 File Offset: 0x00160858
		[NullableContext(1)]
		public static FormationUpdateNotify Create()
		{
			return new FormationUpdateNotify();
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06009285 RID: 37509 RVA: 0x0016265F File Offset: 0x0016085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06009286 RID: 37510 RVA: 0x00162662 File Offset: 0x00160862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06009287 RID: 37511 RVA: 0x00162669 File Offset: 0x00160869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify()
		{
		}

		// Token: 0x06009288 RID: 37512 RVA: 0x00162688 File Offset: 0x00160888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify(FormationUpdateNotify other) : this()
		{
			this.removeFormationIds_ = other.removeFormationIds_.Clone();
			this.formation_ = other.formation_.Clone();
			this.formationId_ = other.formationId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009289 RID: 37513 RVA: 0x001626DA File Offset: 0x001608DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationUpdateNotify Clone()
		{
			return new FormationUpdateNotify(this);
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x0600928A RID: 37514 RVA: 0x001626E2 File Offset: 0x001608E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveFormationIds
		{
			get
			{
				return this.removeFormationIds_;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x0600928B RID: 37515 RVA: 0x001626EA File Offset: 0x001608EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x0600928C RID: 37516 RVA: 0x001626F2 File Offset: 0x001608F2
		// (set) Token: 0x0600928D RID: 37517 RVA: 0x001626FA File Offset: 0x001608FA
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

		// Token: 0x0600928E RID: 37518 RVA: 0x00162703 File Offset: 0x00160903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationUpdateNotify);
		}

		// Token: 0x0600928F RID: 37519 RVA: 0x00162714 File Offset: 0x00160914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationUpdateNotify other)
		{
			return other != null && (other == this || (this.removeFormationIds_.Equals(other.removeFormationIds_) && this.formation_.Equals(other.formation_) && this.FormationId == other.FormationId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009290 RID: 37520 RVA: 0x00162778 File Offset: 0x00160978
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

		// Token: 0x06009291 RID: 37521 RVA: 0x001627D3 File Offset: 0x001609D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009292 RID: 37522 RVA: 0x001627E0 File Offset: 0x001609E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009293 RID: 37523 RVA: 0x001627EC File Offset: 0x001609EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeFormationIds_.WriteTo(ref output, FormationUpdateNotify._repeated_removeFormationIds_codec);
			this.formation_.WriteTo(ref output, FormationUpdateNotify._repeated_formation_codec);
			if (this.FormationId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.FormationId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009294 RID: 37524 RVA: 0x0016284C File Offset: 0x00160A4C
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

		// Token: 0x06009295 RID: 37525 RVA: 0x001628B0 File Offset: 0x00160AB0
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

		// Token: 0x06009296 RID: 37526 RVA: 0x0016290E File Offset: 0x00160B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009297 RID: 37527 RVA: 0x00162918 File Offset: 0x00160B18
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
				if (num <= 50U)
				{
					if (num == 48U || num == 50U)
					{
						this.removeFormationIds_.AddEntriesFrom(ref input, FormationUpdateNotify._repeated_removeFormationIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.formation_.AddEntriesFrom(ref input, FormationUpdateNotify._repeated_formation_codec);
						continue;
					}
					if (num == 96U)
					{
						this.FormationId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400469A RID: 18074
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400469B RID: 18075
		public const int RemoveFormationIdsFieldNumber = 6;

		// Token: 0x0400469C RID: 18076
		private static readonly FieldCodec<int> _repeated_removeFormationIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400469D RID: 18077
		private readonly RepeatedField<int> removeFormationIds_ = new RepeatedField<int>();

		// Token: 0x0400469E RID: 18078
		public const int FormationFieldNumber = 9;

		// Token: 0x0400469F RID: 18079
		private static readonly FieldCodec<FightFormation> _repeated_formation_codec = FieldCodec.ForMessage<FightFormation>(74U, FightFormation.Parser);

		// Token: 0x040046A0 RID: 18080
		private readonly RepeatedField<FightFormation> formation_ = new RepeatedField<FightFormation>();

		// Token: 0x040046A1 RID: 18081
		public const int FormationIdFieldNumber = 12;

		// Token: 0x040046A2 RID: 18082
		private int formationId_;
	}
}
