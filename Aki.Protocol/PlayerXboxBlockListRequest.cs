using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAD RID: 3501
	[NetMessage(EMessageId.PlayerXboxBlockListRequest)]
	public sealed class PlayerXboxBlockListRequest : IMessage<PlayerXboxBlockListRequest>, IMessage, IEquatable<PlayerXboxBlockListRequest>, IDeepCloneable<PlayerXboxBlockListRequest>, IBufferMessage
	{
		// Token: 0x06012E23 RID: 77347 RVA: 0x002C196C File Offset: 0x002BFB6C
		[NullableContext(1)]
		public static PlayerXboxBlockListRequest Create()
		{
			return new PlayerXboxBlockListRequest();
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x06012E24 RID: 77348 RVA: 0x002C1973 File Offset: 0x002BFB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x06012E25 RID: 77349 RVA: 0x002C1976 File Offset: 0x002BFB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxBlockListRequest.Descriptor;
			}
		}

		// Token: 0x06012E26 RID: 77350 RVA: 0x002C197D File Offset: 0x002BFB7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest()
		{
		}

		// Token: 0x06012E27 RID: 77351 RVA: 0x002C1990 File Offset: 0x002BFB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest(PlayerXboxBlockListRequest other) : this()
		{
			this.xboxAccountIds_ = other.xboxAccountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E28 RID: 77352 RVA: 0x002C19BA File Offset: 0x002BFBBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest Clone()
		{
			return new PlayerXboxBlockListRequest(this);
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x06012E29 RID: 77353 RVA: 0x002C19C2 File Offset: 0x002BFBC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> XboxAccountIds
		{
			get
			{
				return this.xboxAccountIds_;
			}
		}

		// Token: 0x06012E2A RID: 77354 RVA: 0x002C19CA File Offset: 0x002BFBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxBlockListRequest);
		}

		// Token: 0x06012E2B RID: 77355 RVA: 0x002C19D8 File Offset: 0x002BFBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxBlockListRequest other)
		{
			return other != null && (other == this || (this.xboxAccountIds_.Equals(other.xboxAccountIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E2C RID: 77356 RVA: 0x002C1A0C File Offset: 0x002BFC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.xboxAccountIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012E2D RID: 77357 RVA: 0x002C1A40 File Offset: 0x002BFC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E2E RID: 77358 RVA: 0x002C1A4D File Offset: 0x002BFC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E2F RID: 77359 RVA: 0x002C1A56 File Offset: 0x002BFC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.xboxAccountIds_.WriteTo(ref output, PlayerXboxBlockListRequest._repeated_xboxAccountIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E30 RID: 77360 RVA: 0x002C1A80 File Offset: 0x002BFC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.xboxAccountIds_.CalculateSize(PlayerXboxBlockListRequest._repeated_xboxAccountIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012E31 RID: 77361 RVA: 0x002C1AB9 File Offset: 0x002BFCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxBlockListRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.xboxAccountIds_.Add(other.xboxAccountIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012E32 RID: 77362 RVA: 0x002C1AE7 File Offset: 0x002BFCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E33 RID: 77363 RVA: 0x002C1AF0 File Offset: 0x002BFCF0
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.xboxAccountIds_.AddEntriesFrom(ref input, PlayerXboxBlockListRequest._repeated_xboxAccountIds_codec);
				}
			}
		}

		// Token: 0x04007545 RID: 30021
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007546 RID: 30022
		public const int XboxAccountIdsFieldNumber = 14;

		// Token: 0x04007547 RID: 30023
		private static readonly FieldCodec<string> _repeated_xboxAccountIds_codec = FieldCodec.ForString(114U);

		// Token: 0x04007548 RID: 30024
		private readonly RepeatedField<string> xboxAccountIds_ = new RepeatedField<string>();
	}
}
