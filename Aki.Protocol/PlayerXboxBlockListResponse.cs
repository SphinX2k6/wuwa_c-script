using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBE RID: 3518
	[NetMessage(EMessageId.PlayerXboxBlockListResponse)]
	public sealed class PlayerXboxBlockListResponse : IMessage<PlayerXboxBlockListResponse>, IMessage, IEquatable<PlayerXboxBlockListResponse>, IDeepCloneable<PlayerXboxBlockListResponse>, IBufferMessage
	{
		// Token: 0x06012F31 RID: 77617 RVA: 0x002C376C File Offset: 0x002C196C
		[NullableContext(1)]
		public static PlayerXboxBlockListResponse Create()
		{
			return new PlayerXboxBlockListResponse();
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x06012F32 RID: 77618 RVA: 0x002C3773 File Offset: 0x002C1973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06012F33 RID: 77619 RVA: 0x002C3776 File Offset: 0x002C1976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxBlockListResponse.Descriptor;
			}
		}

		// Token: 0x06012F34 RID: 77620 RVA: 0x002C377D File Offset: 0x002C197D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse()
		{
		}

		// Token: 0x06012F35 RID: 77621 RVA: 0x002C3785 File Offset: 0x002C1985
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse(PlayerXboxBlockListResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F36 RID: 77622 RVA: 0x002C379E File Offset: 0x002C199E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse Clone()
		{
			return new PlayerXboxBlockListResponse(this);
		}

		// Token: 0x06012F37 RID: 77623 RVA: 0x002C37A6 File Offset: 0x002C19A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxBlockListResponse);
		}

		// Token: 0x06012F38 RID: 77624 RVA: 0x002C37B4 File Offset: 0x002C19B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxBlockListResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012F39 RID: 77625 RVA: 0x002C37D4 File Offset: 0x002C19D4
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

		// Token: 0x06012F3A RID: 77626 RVA: 0x002C37FA File Offset: 0x002C19FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F3B RID: 77627 RVA: 0x002C3807 File Offset: 0x002C1A07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F3C RID: 77628 RVA: 0x002C3810 File Offset: 0x002C1A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F3D RID: 77629 RVA: 0x002C3828 File Offset: 0x002C1A28
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

		// Token: 0x06012F3E RID: 77630 RVA: 0x002C384E File Offset: 0x002C1A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerXboxBlockListResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F3F RID: 77631 RVA: 0x002C386B File Offset: 0x002C1A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F40 RID: 77632 RVA: 0x002C3874 File Offset: 0x002C1A74
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

		// Token: 0x04007531 RID: 30001
		private UnknownFieldSet _unknownFields;
	}
}
