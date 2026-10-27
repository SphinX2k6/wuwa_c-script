using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D85 RID: 3461
	[NetMessage(EMessageId.PlayerCreatePsnSessionResponse)]
	public sealed class PlayerCreatePsnSessionResponse : IMessage<PlayerCreatePsnSessionResponse>, IMessage, IEquatable<PlayerCreatePsnSessionResponse>, IDeepCloneable<PlayerCreatePsnSessionResponse>, IBufferMessage
	{
		// Token: 0x06012A7A RID: 76410 RVA: 0x002B8821 File Offset: 0x002B6A21
		[NullableContext(1)]
		public static PlayerCreatePsnSessionResponse Create()
		{
			return new PlayerCreatePsnSessionResponse();
		}

		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x06012A7B RID: 76411 RVA: 0x002B8828 File Offset: 0x002B6A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DDB RID: 15835
		// (get) Token: 0x06012A7C RID: 76412 RVA: 0x002B882B File Offset: 0x002B6A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreatePsnSessionResponse.Descriptor;
			}
		}

		// Token: 0x06012A7D RID: 76413 RVA: 0x002B8832 File Offset: 0x002B6A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse()
		{
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x002B883A File Offset: 0x002B6A3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse(PlayerCreatePsnSessionResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x002B8853 File Offset: 0x002B6A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse Clone()
		{
			return new PlayerCreatePsnSessionResponse(this);
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x002B885B File Offset: 0x002B6A5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreatePsnSessionResponse);
		}

		// Token: 0x06012A81 RID: 76417 RVA: 0x002B8869 File Offset: 0x002B6A69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreatePsnSessionResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x002B8888 File Offset: 0x002B6A88
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

		// Token: 0x06012A83 RID: 76419 RVA: 0x002B88AE File Offset: 0x002B6AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x002B88BB File Offset: 0x002B6ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012A85 RID: 76421 RVA: 0x002B88C4 File Offset: 0x002B6AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012A86 RID: 76422 RVA: 0x002B88DC File Offset: 0x002B6ADC
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

		// Token: 0x06012A87 RID: 76423 RVA: 0x002B8902 File Offset: 0x002B6B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerCreatePsnSessionResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012A88 RID: 76424 RVA: 0x002B891F File Offset: 0x002B6B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012A89 RID: 76425 RVA: 0x002B8928 File Offset: 0x002B6B28
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

		// Token: 0x040073B0 RID: 29616
		private UnknownFieldSet _unknownFields;
	}
}
