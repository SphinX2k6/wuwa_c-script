using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D93 RID: 3475
	[NetMessage(EMessageId.PlayerHeadAddNotify)]
	public sealed class PlayerHeadAddNotify : IMessage<PlayerHeadAddNotify>, IMessage, IEquatable<PlayerHeadAddNotify>, IDeepCloneable<PlayerHeadAddNotify>, IBufferMessage
	{
		// Token: 0x06012BCC RID: 76748 RVA: 0x002BC283 File Offset: 0x002BA483
		[NullableContext(1)]
		public static PlayerHeadAddNotify Create()
		{
			return new PlayerHeadAddNotify();
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x06012BCD RID: 76749 RVA: 0x002BC28A File Offset: 0x002BA48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E32 RID: 15922
		// (get) Token: 0x06012BCE RID: 76750 RVA: 0x002BC28D File Offset: 0x002BA48D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadAddNotify.Descriptor;
			}
		}

		// Token: 0x06012BCF RID: 76751 RVA: 0x002BC294 File Offset: 0x002BA494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify()
		{
		}

		// Token: 0x06012BD0 RID: 76752 RVA: 0x002BC2A7 File Offset: 0x002BA4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify(PlayerHeadAddNotify other) : this()
		{
			this.addPlayerHeadIds_ = other.addPlayerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012BD1 RID: 76753 RVA: 0x002BC2D1 File Offset: 0x002BA4D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify Clone()
		{
			return new PlayerHeadAddNotify(this);
		}

		// Token: 0x17003E33 RID: 15923
		// (get) Token: 0x06012BD2 RID: 76754 RVA: 0x002BC2D9 File Offset: 0x002BA4D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddPlayerHeadIds
		{
			get
			{
				return this.addPlayerHeadIds_;
			}
		}

		// Token: 0x06012BD3 RID: 76755 RVA: 0x002BC2E1 File Offset: 0x002BA4E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadAddNotify);
		}

		// Token: 0x06012BD4 RID: 76756 RVA: 0x002BC2EF File Offset: 0x002BA4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadAddNotify other)
		{
			return other != null && (other == this || (this.addPlayerHeadIds_.Equals(other.addPlayerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012BD5 RID: 76757 RVA: 0x002BC324 File Offset: 0x002BA524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.addPlayerHeadIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012BD6 RID: 76758 RVA: 0x002BC358 File Offset: 0x002BA558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012BD7 RID: 76759 RVA: 0x002BC365 File Offset: 0x002BA565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012BD8 RID: 76760 RVA: 0x002BC36E File Offset: 0x002BA56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addPlayerHeadIds_.WriteTo(ref output, PlayerHeadAddNotify._repeated_addPlayerHeadIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012BD9 RID: 76761 RVA: 0x002BC398 File Offset: 0x002BA598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.addPlayerHeadIds_.CalculateSize(PlayerHeadAddNotify._repeated_addPlayerHeadIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012BDA RID: 76762 RVA: 0x002BC3D1 File Offset: 0x002BA5D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.addPlayerHeadIds_.Add(other.addPlayerHeadIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012BDB RID: 76763 RVA: 0x002BC3FF File Offset: 0x002BA5FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012BDC RID: 76764 RVA: 0x002BC408 File Offset: 0x002BA608
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.addPlayerHeadIds_.AddEntriesFrom(ref input, PlayerHeadAddNotify._repeated_addPlayerHeadIds_codec);
				}
			}
		}

		// Token: 0x04007436 RID: 29750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007437 RID: 29751
		public const int AddPlayerHeadIdsFieldNumber = 9;

		// Token: 0x04007438 RID: 29752
		private static readonly FieldCodec<int> _repeated_addPlayerHeadIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04007439 RID: 29753
		private readonly RepeatedField<int> addPlayerHeadIds_ = new RepeatedField<int>();
	}
}
