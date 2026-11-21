using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D86 RID: 3462
	[NetMessage(EMessageId.PlayerHeadUpdateNotify)]
	public sealed class PlayerHeadUpdateNotify : IMessage<PlayerHeadUpdateNotify>, IMessage, IEquatable<PlayerHeadUpdateNotify>, IDeepCloneable<PlayerHeadUpdateNotify>, IBufferMessage
	{
		// Token: 0x06012B04 RID: 76548 RVA: 0x002BAB5C File Offset: 0x002B8D5C
		[NullableContext(1)]
		public static PlayerHeadUpdateNotify Create()
		{
			return new PlayerHeadUpdateNotify();
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x06012B05 RID: 76549 RVA: 0x002BAB63 File Offset: 0x002B8D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x06012B06 RID: 76550 RVA: 0x002BAB66 File Offset: 0x002B8D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06012B07 RID: 76551 RVA: 0x002BAB6D File Offset: 0x002B8D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify()
		{
		}

		// Token: 0x06012B08 RID: 76552 RVA: 0x002BAB80 File Offset: 0x002B8D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify(PlayerHeadUpdateNotify other) : this()
		{
			this.playerHeadIds_ = other.playerHeadIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012B09 RID: 76553 RVA: 0x002BABAA File Offset: 0x002B8DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadUpdateNotify Clone()
		{
			return new PlayerHeadUpdateNotify(this);
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x06012B0A RID: 76554 RVA: 0x002BABB2 File Offset: 0x002B8DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PlayerHeadIds
		{
			get
			{
				return this.playerHeadIds_;
			}
		}

		// Token: 0x06012B0B RID: 76555 RVA: 0x002BABBA File Offset: 0x002B8DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadUpdateNotify);
		}

		// Token: 0x06012B0C RID: 76556 RVA: 0x002BABC8 File Offset: 0x002B8DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadUpdateNotify other)
		{
			return other != null && (other == this || (this.playerHeadIds_.Equals(other.playerHeadIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012B0D RID: 76557 RVA: 0x002BABFC File Offset: 0x002B8DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playerHeadIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012B0E RID: 76558 RVA: 0x002BAC30 File Offset: 0x002B8E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012B0F RID: 76559 RVA: 0x002BAC3D File Offset: 0x002B8E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012B10 RID: 76560 RVA: 0x002BAC46 File Offset: 0x002B8E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playerHeadIds_.WriteTo(ref output, PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012B11 RID: 76561 RVA: 0x002BAC70 File Offset: 0x002B8E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playerHeadIds_.CalculateSize(PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012B12 RID: 76562 RVA: 0x002BACA9 File Offset: 0x002B8EA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playerHeadIds_.Add(other.playerHeadIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012B13 RID: 76563 RVA: 0x002BACD7 File Offset: 0x002B8ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012B14 RID: 76564 RVA: 0x002BACE0 File Offset: 0x002B8EE0
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
					this.playerHeadIds_.AddEntriesFrom(ref input, PlayerHeadUpdateNotify._repeated_playerHeadIds_codec);
				}
			}
		}

		// Token: 0x04007457 RID: 29783
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007458 RID: 29784
		public const int PlayerHeadIdsFieldNumber = 9;

		// Token: 0x04007459 RID: 29785
		private static readonly FieldCodec<int> _repeated_playerHeadIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400745A RID: 29786
		private readonly RepeatedField<int> playerHeadIds_ = new RepeatedField<int>();
	}
}
