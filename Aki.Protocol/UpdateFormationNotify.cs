using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001497 RID: 5271
	[NetMessage(EMessageId.UpdateFormationNotify)]
	public sealed class UpdateFormationNotify : IMessage<UpdateFormationNotify>, IMessage, IEquatable<UpdateFormationNotify>, IDeepCloneable<UpdateFormationNotify>, IBufferMessage
	{
		// Token: 0x0601BE23 RID: 114211 RVA: 0x00407F1D File Offset: 0x0040611D
		[NullableContext(1)]
		public static UpdateFormationNotify Create()
		{
			return new UpdateFormationNotify();
		}

		// Token: 0x17005DFB RID: 24059
		// (get) Token: 0x0601BE24 RID: 114212 RVA: 0x00407F24 File Offset: 0x00406124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DFC RID: 24060
		// (get) Token: 0x0601BE25 RID: 114213 RVA: 0x00407F27 File Offset: 0x00406127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationNotify.Descriptor;
			}
		}

		// Token: 0x0601BE26 RID: 114214 RVA: 0x00407F2E File Offset: 0x0040612E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify()
		{
		}

		// Token: 0x0601BE27 RID: 114215 RVA: 0x00407F41 File Offset: 0x00406141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify(UpdateFormationNotify other) : this()
		{
			this.playersFormations_ = other.playersFormations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE28 RID: 114216 RVA: 0x00407F6B File Offset: 0x0040616B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify Clone()
		{
			return new UpdateFormationNotify(this);
		}

		// Token: 0x17005DFD RID: 24061
		// (get) Token: 0x0601BE29 RID: 114217 RVA: 0x00407F73 File Offset: 0x00406173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFightFormations> PlayersFormations
		{
			get
			{
				return this.playersFormations_;
			}
		}

		// Token: 0x0601BE2A RID: 114218 RVA: 0x00407F7B File Offset: 0x0040617B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationNotify);
		}

		// Token: 0x0601BE2B RID: 114219 RVA: 0x00407F89 File Offset: 0x00406189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationNotify other)
		{
			return other != null && (other == this || (this.playersFormations_.Equals(other.playersFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE2C RID: 114220 RVA: 0x00407FBC File Offset: 0x004061BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playersFormations_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE2D RID: 114221 RVA: 0x00407FF0 File Offset: 0x004061F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE2E RID: 114222 RVA: 0x00407FFD File Offset: 0x004061FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE2F RID: 114223 RVA: 0x00408006 File Offset: 0x00406206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playersFormations_.WriteTo(ref output, UpdateFormationNotify._repeated_playersFormations_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE30 RID: 114224 RVA: 0x00408030 File Offset: 0x00406230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playersFormations_.CalculateSize(UpdateFormationNotify._repeated_playersFormations_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE31 RID: 114225 RVA: 0x00408069 File Offset: 0x00406269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFormationNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playersFormations_.Add(other.playersFormations_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE32 RID: 114226 RVA: 0x00408097 File Offset: 0x00406297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE33 RID: 114227 RVA: 0x004080A0 File Offset: 0x004062A0
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playersFormations_.AddEntriesFrom(ref input, UpdateFormationNotify._repeated_playersFormations_codec);
				}
			}
		}

		// Token: 0x0400A04D RID: 41037
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A04E RID: 41038
		public const int PlayersFormationsFieldNumber = 4;

		// Token: 0x0400A04F RID: 41039
		private static readonly FieldCodec<PlayerFightFormations> _repeated_playersFormations_codec = FieldCodec.ForMessage<PlayerFightFormations>(34U, PlayerFightFormations.Parser);

		// Token: 0x0400A050 RID: 41040
		private readonly RepeatedField<PlayerFightFormations> playersFormations_ = new RepeatedField<PlayerFightFormations>();
	}
}
