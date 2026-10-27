using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBD RID: 3517
	[NetMessage(EMessageId.PlayerXboxBlockListRequest)]
	public sealed class PlayerXboxBlockListRequest : IMessage<PlayerXboxBlockListRequest>, IMessage, IEquatable<PlayerXboxBlockListRequest>, IDeepCloneable<PlayerXboxBlockListRequest>, IBufferMessage
	{
		// Token: 0x06012F1F RID: 77599 RVA: 0x002C3590 File Offset: 0x002C1790
		[NullableContext(1)]
		public static PlayerXboxBlockListRequest Create()
		{
			return new PlayerXboxBlockListRequest();
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x06012F20 RID: 77600 RVA: 0x002C3597 File Offset: 0x002C1797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x06012F21 RID: 77601 RVA: 0x002C359A File Offset: 0x002C179A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxBlockListRequest.Descriptor;
			}
		}

		// Token: 0x06012F22 RID: 77602 RVA: 0x002C35A1 File Offset: 0x002C17A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest()
		{
		}

		// Token: 0x06012F23 RID: 77603 RVA: 0x002C35B4 File Offset: 0x002C17B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest(PlayerXboxBlockListRequest other) : this()
		{
			this.xboxAccountIds_ = other.xboxAccountIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F24 RID: 77604 RVA: 0x002C35DE File Offset: 0x002C17DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListRequest Clone()
		{
			return new PlayerXboxBlockListRequest(this);
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x06012F25 RID: 77605 RVA: 0x002C35E6 File Offset: 0x002C17E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> XboxAccountIds
		{
			get
			{
				return this.xboxAccountIds_;
			}
		}

		// Token: 0x06012F26 RID: 77606 RVA: 0x002C35EE File Offset: 0x002C17EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxBlockListRequest);
		}

		// Token: 0x06012F27 RID: 77607 RVA: 0x002C35FC File Offset: 0x002C17FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxBlockListRequest other)
		{
			return other != null && (other == this || (this.xboxAccountIds_.Equals(other.xboxAccountIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F28 RID: 77608 RVA: 0x002C3630 File Offset: 0x002C1830
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

		// Token: 0x06012F29 RID: 77609 RVA: 0x002C3664 File Offset: 0x002C1864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F2A RID: 77610 RVA: 0x002C3671 File Offset: 0x002C1871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F2B RID: 77611 RVA: 0x002C367A File Offset: 0x002C187A
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

		// Token: 0x06012F2C RID: 77612 RVA: 0x002C36A4 File Offset: 0x002C18A4
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

		// Token: 0x06012F2D RID: 77613 RVA: 0x002C36DD File Offset: 0x002C18DD
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

		// Token: 0x06012F2E RID: 77614 RVA: 0x002C370B File Offset: 0x002C190B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F2F RID: 77615 RVA: 0x002C3714 File Offset: 0x002C1914
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
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.xboxAccountIds_.AddEntriesFrom(ref input, PlayerXboxBlockListRequest._repeated_xboxAccountIds_codec);
				}
			}
		}

		// Token: 0x0400752D RID: 29997
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400752E RID: 29998
		public const int XboxAccountIdsFieldNumber = 13;

		// Token: 0x0400752F RID: 29999
		private static readonly FieldCodec<string> _repeated_xboxAccountIds_codec = FieldCodec.ForString(106U);

		// Token: 0x04007530 RID: 30000
		private readonly RepeatedField<string> xboxAccountIds_ = new RepeatedField<string>();
	}
}
