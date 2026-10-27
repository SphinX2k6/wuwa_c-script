using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D87 RID: 3463
	[NetMessage(EMessageId.PlayerCreateXboxSessionResponse)]
	public sealed class PlayerCreateXboxSessionResponse : IMessage<PlayerCreateXboxSessionResponse>, IMessage, IEquatable<PlayerCreateXboxSessionResponse>, IDeepCloneable<PlayerCreateXboxSessionResponse>, IBufferMessage
	{
		// Token: 0x06012A9C RID: 76444 RVA: 0x002B8B61 File Offset: 0x002B6D61
		[NullableContext(1)]
		public static PlayerCreateXboxSessionResponse Create()
		{
			return new PlayerCreateXboxSessionResponse();
		}

		// Token: 0x17003DDF RID: 15839
		// (get) Token: 0x06012A9D RID: 76445 RVA: 0x002B8B68 File Offset: 0x002B6D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DE0 RID: 15840
		// (get) Token: 0x06012A9E RID: 76446 RVA: 0x002B8B6B File Offset: 0x002B6D6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreateXboxSessionResponse.Descriptor;
			}
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x002B8B72 File Offset: 0x002B6D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse()
		{
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x002B8B7A File Offset: 0x002B6D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse(PlayerCreateXboxSessionResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AA1 RID: 76449 RVA: 0x002B8B93 File Offset: 0x002B6D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse Clone()
		{
			return new PlayerCreateXboxSessionResponse(this);
		}

		// Token: 0x06012AA2 RID: 76450 RVA: 0x002B8B9B File Offset: 0x002B6D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreateXboxSessionResponse);
		}

		// Token: 0x06012AA3 RID: 76451 RVA: 0x002B8BA9 File Offset: 0x002B6DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreateXboxSessionResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012AA4 RID: 76452 RVA: 0x002B8BC8 File Offset: 0x002B6DC8
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

		// Token: 0x06012AA5 RID: 76453 RVA: 0x002B8BEE File Offset: 0x002B6DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AA6 RID: 76454 RVA: 0x002B8BFB File Offset: 0x002B6DFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AA7 RID: 76455 RVA: 0x002B8C04 File Offset: 0x002B6E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012AA8 RID: 76456 RVA: 0x002B8C1C File Offset: 0x002B6E1C
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

		// Token: 0x06012AA9 RID: 76457 RVA: 0x002B8C42 File Offset: 0x002B6E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerCreateXboxSessionResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012AAA RID: 76458 RVA: 0x002B8C5F File Offset: 0x002B6E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012AAB RID: 76459 RVA: 0x002B8C68 File Offset: 0x002B6E68
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

		// Token: 0x040073B4 RID: 29620
		private UnknownFieldSet _unknownFields;
	}
}
