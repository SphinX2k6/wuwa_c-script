using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DA5 RID: 3493
	[NetMessage(EMessageId.PlayerTitleRequest)]
	public sealed class PlayerTitleRequest : IMessage<PlayerTitleRequest>, IMessage, IEquatable<PlayerTitleRequest>, IDeepCloneable<PlayerTitleRequest>, IBufferMessage
	{
		// Token: 0x06012D8F RID: 77199 RVA: 0x002C07EA File Offset: 0x002BE9EA
		[NullableContext(1)]
		public static PlayerTitleRequest Create()
		{
			return new PlayerTitleRequest();
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x06012D90 RID: 77200 RVA: 0x002C07F1 File Offset: 0x002BE9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x06012D91 RID: 77201 RVA: 0x002C07F4 File Offset: 0x002BE9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleRequest.Descriptor;
			}
		}

		// Token: 0x06012D92 RID: 77202 RVA: 0x002C07FB File Offset: 0x002BE9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest()
		{
		}

		// Token: 0x06012D93 RID: 77203 RVA: 0x002C0803 File Offset: 0x002BEA03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest(PlayerTitleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D94 RID: 77204 RVA: 0x002C081C File Offset: 0x002BEA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest Clone()
		{
			return new PlayerTitleRequest(this);
		}

		// Token: 0x06012D95 RID: 77205 RVA: 0x002C0824 File Offset: 0x002BEA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleRequest);
		}

		// Token: 0x06012D96 RID: 77206 RVA: 0x002C0832 File Offset: 0x002BEA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012D97 RID: 77207 RVA: 0x002C0850 File Offset: 0x002BEA50
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

		// Token: 0x06012D98 RID: 77208 RVA: 0x002C0876 File Offset: 0x002BEA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D99 RID: 77209 RVA: 0x002C0883 File Offset: 0x002BEA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D9A RID: 77210 RVA: 0x002C088C File Offset: 0x002BEA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D9B RID: 77211 RVA: 0x002C08A4 File Offset: 0x002BEAA4
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

		// Token: 0x06012D9C RID: 77212 RVA: 0x002C08CA File Offset: 0x002BEACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerTitleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D9D RID: 77213 RVA: 0x002C08E7 File Offset: 0x002BEAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D9E RID: 77214 RVA: 0x002C08F0 File Offset: 0x002BEAF0
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

		// Token: 0x04007521 RID: 29985
		private UnknownFieldSet _unknownFields;
	}
}
