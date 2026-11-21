using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150B RID: 5387
	[NetMessage(EMessageId.UpdateFormationNotify)]
	public sealed class UpdateFormationNotify : IMessage<UpdateFormationNotify>, IMessage, IEquatable<UpdateFormationNotify>, IDeepCloneable<UpdateFormationNotify>, IBufferMessage
	{
		// Token: 0x0601C8C0 RID: 116928 RVA: 0x004233C1 File Offset: 0x004215C1
		[NullableContext(1)]
		public static UpdateFormationNotify Create()
		{
			return new UpdateFormationNotify();
		}

		// Token: 0x17006093 RID: 24723
		// (get) Token: 0x0601C8C1 RID: 116929 RVA: 0x004233C8 File Offset: 0x004215C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006094 RID: 24724
		// (get) Token: 0x0601C8C2 RID: 116930 RVA: 0x004233CB File Offset: 0x004215CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationNotify.Descriptor;
			}
		}

		// Token: 0x0601C8C3 RID: 116931 RVA: 0x004233D2 File Offset: 0x004215D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify()
		{
		}

		// Token: 0x0601C8C4 RID: 116932 RVA: 0x004233E5 File Offset: 0x004215E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify(UpdateFormationNotify other) : this()
		{
			this.playersFormations_ = other.playersFormations_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8C5 RID: 116933 RVA: 0x0042340F File Offset: 0x0042160F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationNotify Clone()
		{
			return new UpdateFormationNotify(this);
		}

		// Token: 0x17006095 RID: 24725
		// (get) Token: 0x0601C8C6 RID: 116934 RVA: 0x00423417 File Offset: 0x00421617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFightFormations> PlayersFormations
		{
			get
			{
				return this.playersFormations_;
			}
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x0042341F File Offset: 0x0042161F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationNotify);
		}

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x0042342D File Offset: 0x0042162D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationNotify other)
		{
			return other != null && (other == this || (this.playersFormations_.Equals(other.playersFormations_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8C9 RID: 116937 RVA: 0x00423460 File Offset: 0x00421660
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

		// Token: 0x0601C8CA RID: 116938 RVA: 0x00423494 File Offset: 0x00421694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8CB RID: 116939 RVA: 0x004234A1 File Offset: 0x004216A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8CC RID: 116940 RVA: 0x004234AA File Offset: 0x004216AA
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

		// Token: 0x0601C8CD RID: 116941 RVA: 0x004234D4 File Offset: 0x004216D4
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

		// Token: 0x0601C8CE RID: 116942 RVA: 0x0042350D File Offset: 0x0042170D
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

		// Token: 0x0601C8CF RID: 116943 RVA: 0x0042353B File Offset: 0x0042173B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8D0 RID: 116944 RVA: 0x00423544 File Offset: 0x00421744
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playersFormations_.AddEntriesFrom(ref input, UpdateFormationNotify._repeated_playersFormations_codec);
				}
			}
		}

		// Token: 0x0400A498 RID: 42136
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A499 RID: 42137
		public const int PlayersFormationsFieldNumber = 5;

		// Token: 0x0400A49A RID: 42138
		private static readonly FieldCodec<PlayerFightFormations> _repeated_playersFormations_codec = FieldCodec.ForMessage<PlayerFightFormations>(42U, PlayerFightFormations.Parser);

		// Token: 0x0400A49B RID: 42139
		private readonly RepeatedField<PlayerFightFormations> playersFormations_ = new RepeatedField<PlayerFightFormations>();
	}
}
