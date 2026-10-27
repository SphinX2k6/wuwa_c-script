using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001498 RID: 5272
	[NetMessage(EMessageId.UpdateFormationRequest)]
	public sealed class UpdateFormationRequest : IMessage<UpdateFormationRequest>, IMessage, IEquatable<UpdateFormationRequest>, IDeepCloneable<UpdateFormationRequest>, IBufferMessage
	{
		// Token: 0x0601BE35 RID: 114229 RVA: 0x004080FD File Offset: 0x004062FD
		[NullableContext(1)]
		public static UpdateFormationRequest Create()
		{
			return new UpdateFormationRequest();
		}

		// Token: 0x17005DFE RID: 24062
		// (get) Token: 0x0601BE36 RID: 114230 RVA: 0x00408104 File Offset: 0x00406304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DFF RID: 24063
		// (get) Token: 0x0601BE37 RID: 114231 RVA: 0x00408107 File Offset: 0x00406307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationRequest.Descriptor;
			}
		}

		// Token: 0x0601BE38 RID: 114232 RVA: 0x0040810E File Offset: 0x0040630E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest()
		{
		}

		// Token: 0x0601BE39 RID: 114233 RVA: 0x00408121 File Offset: 0x00406321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest(UpdateFormationRequest other) : this()
		{
			this.formations_ = other.formations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE3A RID: 114234 RVA: 0x0040814B File Offset: 0x0040634B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationRequest Clone()
		{
			return new UpdateFormationRequest(this);
		}

		// Token: 0x17005E00 RID: 24064
		// (get) Token: 0x0601BE3B RID: 114235 RVA: 0x00408153 File Offset: 0x00406353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightFormation> Formations
		{
			get
			{
				return this.formations_;
			}
		}

		// Token: 0x0601BE3C RID: 114236 RVA: 0x0040815B File Offset: 0x0040635B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationRequest);
		}

		// Token: 0x0601BE3D RID: 114237 RVA: 0x00408169 File Offset: 0x00406369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationRequest other)
		{
			return other != null && (other == this || (this.formations_.Equals(other.formations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE3E RID: 114238 RVA: 0x0040819C File Offset: 0x0040639C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.formations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE3F RID: 114239 RVA: 0x004081D0 File Offset: 0x004063D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE40 RID: 114240 RVA: 0x004081DD File Offset: 0x004063DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE41 RID: 114241 RVA: 0x004081E6 File Offset: 0x004063E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formations_.WriteTo(ref output, UpdateFormationRequest._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE42 RID: 114242 RVA: 0x00408210 File Offset: 0x00406410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formations_.CalculateSize(UpdateFormationRequest._repeated_formations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE43 RID: 114243 RVA: 0x00408249 File Offset: 0x00406449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFormationRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.formations_.Add(other.formations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE44 RID: 114244 RVA: 0x00408277 File Offset: 0x00406477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE45 RID: 114245 RVA: 0x00408280 File Offset: 0x00406480
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.formations_.AddEntriesFrom(ref input, UpdateFormationRequest._repeated_formations_codec);
				}
			}
		}

		// Token: 0x0400A051 RID: 41041
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A052 RID: 41042
		public const int FormationsFieldNumber = 12;

		// Token: 0x0400A053 RID: 41043
		private static readonly FieldCodec<FightFormation> _repeated_formations_codec = FieldCodec.ForMessage<FightFormation>(98U, FightFormation.Parser);

		// Token: 0x0400A054 RID: 41044
		private readonly RepeatedField<FightFormation> formations_ = new RepeatedField<FightFormation>();
	}
}
