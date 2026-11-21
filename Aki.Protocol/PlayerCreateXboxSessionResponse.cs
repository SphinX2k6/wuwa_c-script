using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D77 RID: 3447
	[NetMessage(EMessageId.PlayerCreateXboxSessionResponse)]
	public sealed class PlayerCreateXboxSessionResponse : IMessage<PlayerCreateXboxSessionResponse>, IMessage, IEquatable<PlayerCreateXboxSessionResponse>, IDeepCloneable<PlayerCreateXboxSessionResponse>, IBufferMessage
	{
		// Token: 0x060129A0 RID: 76192 RVA: 0x002B6F41 File Offset: 0x002B5141
		[NullableContext(1)]
		public static PlayerCreateXboxSessionResponse Create()
		{
			return new PlayerCreateXboxSessionResponse();
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x060129A1 RID: 76193 RVA: 0x002B6F48 File Offset: 0x002B5148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x060129A2 RID: 76194 RVA: 0x002B6F4B File Offset: 0x002B514B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreateXboxSessionResponse.Descriptor;
			}
		}

		// Token: 0x060129A3 RID: 76195 RVA: 0x002B6F52 File Offset: 0x002B5152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse()
		{
		}

		// Token: 0x060129A4 RID: 76196 RVA: 0x002B6F5A File Offset: 0x002B515A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse(PlayerCreateXboxSessionResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060129A5 RID: 76197 RVA: 0x002B6F73 File Offset: 0x002B5173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreateXboxSessionResponse Clone()
		{
			return new PlayerCreateXboxSessionResponse(this);
		}

		// Token: 0x060129A6 RID: 76198 RVA: 0x002B6F7B File Offset: 0x002B517B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreateXboxSessionResponse);
		}

		// Token: 0x060129A7 RID: 76199 RVA: 0x002B6F89 File Offset: 0x002B5189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreateXboxSessionResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060129A8 RID: 76200 RVA: 0x002B6FA8 File Offset: 0x002B51A8
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

		// Token: 0x060129A9 RID: 76201 RVA: 0x002B6FCE File Offset: 0x002B51CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060129AA RID: 76202 RVA: 0x002B6FDB File Offset: 0x002B51DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060129AB RID: 76203 RVA: 0x002B6FE4 File Offset: 0x002B51E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060129AC RID: 76204 RVA: 0x002B6FFC File Offset: 0x002B51FC
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

		// Token: 0x060129AD RID: 76205 RVA: 0x002B7022 File Offset: 0x002B5222
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

		// Token: 0x060129AE RID: 76206 RVA: 0x002B703F File Offset: 0x002B523F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060129AF RID: 76207 RVA: 0x002B7048 File Offset: 0x002B5248
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

		// Token: 0x040073CC RID: 29644
		private UnknownFieldSet _unknownFields;
	}
}
