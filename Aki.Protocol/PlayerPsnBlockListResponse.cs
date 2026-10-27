using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA1 RID: 3489
	[NetMessage(EMessageId.PlayerPsnBlockListResponse)]
	public sealed class PlayerPsnBlockListResponse : IMessage<PlayerPsnBlockListResponse>, IMessage, IEquatable<PlayerPsnBlockListResponse>, IDeepCloneable<PlayerPsnBlockListResponse>, IBufferMessage
	{
		// Token: 0x06012CD6 RID: 77014 RVA: 0x002BE1A8 File Offset: 0x002BC3A8
		[NullableContext(1)]
		public static PlayerPsnBlockListResponse Create()
		{
			return new PlayerPsnBlockListResponse();
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x06012CD7 RID: 77015 RVA: 0x002BE1AF File Offset: 0x002BC3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x06012CD8 RID: 77016 RVA: 0x002BE1B2 File Offset: 0x002BC3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerPsnBlockListResponse.Descriptor;
			}
		}

		// Token: 0x06012CD9 RID: 77017 RVA: 0x002BE1B9 File Offset: 0x002BC3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse()
		{
		}

		// Token: 0x06012CDA RID: 77018 RVA: 0x002BE1C1 File Offset: 0x002BC3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse(PlayerPsnBlockListResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012CDB RID: 77019 RVA: 0x002BE1DA File Offset: 0x002BC3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerPsnBlockListResponse Clone()
		{
			return new PlayerPsnBlockListResponse(this);
		}

		// Token: 0x06012CDC RID: 77020 RVA: 0x002BE1E2 File Offset: 0x002BC3E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerPsnBlockListResponse);
		}

		// Token: 0x06012CDD RID: 77021 RVA: 0x002BE1F0 File Offset: 0x002BC3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerPsnBlockListResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012CDE RID: 77022 RVA: 0x002BE210 File Offset: 0x002BC410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012CDF RID: 77023 RVA: 0x002BE236 File Offset: 0x002BC436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012CE0 RID: 77024 RVA: 0x002BE243 File Offset: 0x002BC443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012CE1 RID: 77025 RVA: 0x002BE24C File Offset: 0x002BC44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012CE2 RID: 77026 RVA: 0x002BE264 File Offset: 0x002BC464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012CE3 RID: 77027 RVA: 0x002BE28A File Offset: 0x002BC48A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerPsnBlockListResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012CE4 RID: 77028 RVA: 0x002BE2A7 File Offset: 0x002BC4A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012CE5 RID: 77029 RVA: 0x002BE2B0 File Offset: 0x002BC4B0
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007472 RID: 29810
		private UnknownFieldSet _unknownFields;
	}
}
