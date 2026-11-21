using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D83 RID: 3459
	[NetMessage(EMessageId.PlayerHeadAddNotify)]
	public sealed class PlayerHeadAddNotify : IMessage<PlayerHeadAddNotify>, IMessage, IEquatable<PlayerHeadAddNotify>, IDeepCloneable<PlayerHeadAddNotify>, IBufferMessage
	{
		// Token: 0x06012AD0 RID: 76496 RVA: 0x002BA65F File Offset: 0x002B885F
		[NullableContext(1)]
		public static PlayerHeadAddNotify Create()
		{
			return new PlayerHeadAddNotify();
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x06012AD1 RID: 76497 RVA: 0x002BA666 File Offset: 0x002B8866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x06012AD2 RID: 76498 RVA: 0x002BA669 File Offset: 0x002B8869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadAddNotify.Descriptor;
			}
		}

		// Token: 0x06012AD3 RID: 76499 RVA: 0x002BA670 File Offset: 0x002B8870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify()
		{
		}

		// Token: 0x06012AD4 RID: 76500 RVA: 0x002BA683 File Offset: 0x002B8883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify(PlayerHeadAddNotify other) : this()
		{
			this.addPlayerHeadIds_ = other.addPlayerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AD5 RID: 76501 RVA: 0x002BA6AD File Offset: 0x002B88AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadAddNotify Clone()
		{
			return new PlayerHeadAddNotify(this);
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x06012AD6 RID: 76502 RVA: 0x002BA6B5 File Offset: 0x002B88B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> AddPlayerHeadIds
		{
			get
			{
				return this.addPlayerHeadIds_;
			}
		}

		// Token: 0x06012AD7 RID: 76503 RVA: 0x002BA6BD File Offset: 0x002B88BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadAddNotify);
		}

		// Token: 0x06012AD8 RID: 76504 RVA: 0x002BA6CB File Offset: 0x002B88CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadAddNotify other)
		{
			return other != null && (other == this || (this.addPlayerHeadIds_.Equals(other.addPlayerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012AD9 RID: 76505 RVA: 0x002BA700 File Offset: 0x002B8900
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

		// Token: 0x06012ADA RID: 76506 RVA: 0x002BA734 File Offset: 0x002B8934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012ADB RID: 76507 RVA: 0x002BA741 File Offset: 0x002B8941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012ADC RID: 76508 RVA: 0x002BA74A File Offset: 0x002B894A
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

		// Token: 0x06012ADD RID: 76509 RVA: 0x002BA774 File Offset: 0x002B8974
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

		// Token: 0x06012ADE RID: 76510 RVA: 0x002BA7AD File Offset: 0x002B89AD
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

		// Token: 0x06012ADF RID: 76511 RVA: 0x002BA7DB File Offset: 0x002B89DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012AE0 RID: 76512 RVA: 0x002BA7E4 File Offset: 0x002B89E4
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.addPlayerHeadIds_.AddEntriesFrom(ref input, PlayerHeadAddNotify._repeated_addPlayerHeadIds_codec);
				}
			}
		}

		// Token: 0x0400744E RID: 29774
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400744F RID: 29775
		public const int AddPlayerHeadIdsFieldNumber = 13;

		// Token: 0x04007450 RID: 29776
		private static readonly FieldCodec<int> _repeated_addPlayerHeadIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04007451 RID: 29777
		private readonly RepeatedField<int> addPlayerHeadIds_ = new RepeatedField<int>();
	}
}
