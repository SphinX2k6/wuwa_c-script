using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D75 RID: 3445
	[NetMessage(EMessageId.PlayerCreatePsnSessionResponse)]
	public sealed class PlayerCreatePsnSessionResponse : IMessage<PlayerCreatePsnSessionResponse>, IMessage, IEquatable<PlayerCreatePsnSessionResponse>, IDeepCloneable<PlayerCreatePsnSessionResponse>, IBufferMessage
	{
		// Token: 0x0601297E RID: 76158 RVA: 0x002B6C01 File Offset: 0x002B4E01
		[NullableContext(1)]
		public static PlayerCreatePsnSessionResponse Create()
		{
			return new PlayerCreatePsnSessionResponse();
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x0601297F RID: 76159 RVA: 0x002B6C08 File Offset: 0x002B4E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x06012980 RID: 76160 RVA: 0x002B6C0B File Offset: 0x002B4E0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerCreatePsnSessionResponse.Descriptor;
			}
		}

		// Token: 0x06012981 RID: 76161 RVA: 0x002B6C12 File Offset: 0x002B4E12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse()
		{
		}

		// Token: 0x06012982 RID: 76162 RVA: 0x002B6C1A File Offset: 0x002B4E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse(PlayerCreatePsnSessionResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012983 RID: 76163 RVA: 0x002B6C33 File Offset: 0x002B4E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerCreatePsnSessionResponse Clone()
		{
			return new PlayerCreatePsnSessionResponse(this);
		}

		// Token: 0x06012984 RID: 76164 RVA: 0x002B6C3B File Offset: 0x002B4E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerCreatePsnSessionResponse);
		}

		// Token: 0x06012985 RID: 76165 RVA: 0x002B6C49 File Offset: 0x002B4E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerCreatePsnSessionResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012986 RID: 76166 RVA: 0x002B6C68 File Offset: 0x002B4E68
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

		// Token: 0x06012987 RID: 76167 RVA: 0x002B6C8E File Offset: 0x002B4E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012988 RID: 76168 RVA: 0x002B6C9B File Offset: 0x002B4E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x002B6CA4 File Offset: 0x002B4EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601298A RID: 76170 RVA: 0x002B6CBC File Offset: 0x002B4EBC
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

		// Token: 0x0601298B RID: 76171 RVA: 0x002B6CE2 File Offset: 0x002B4EE2
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

		// Token: 0x0601298C RID: 76172 RVA: 0x002B6CFF File Offset: 0x002B4EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601298D RID: 76173 RVA: 0x002B6D08 File Offset: 0x002B4F08
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

		// Token: 0x040073C8 RID: 29640
		private UnknownFieldSet _unknownFields;
	}
}
