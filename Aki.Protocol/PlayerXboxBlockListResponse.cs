using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAE RID: 3502
	[NetMessage(EMessageId.PlayerXboxBlockListResponse)]
	public sealed class PlayerXboxBlockListResponse : IMessage<PlayerXboxBlockListResponse>, IMessage, IEquatable<PlayerXboxBlockListResponse>, IDeepCloneable<PlayerXboxBlockListResponse>, IBufferMessage
	{
		// Token: 0x06012E35 RID: 77365 RVA: 0x002C1B48 File Offset: 0x002BFD48
		[NullableContext(1)]
		public static PlayerXboxBlockListResponse Create()
		{
			return new PlayerXboxBlockListResponse();
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x06012E36 RID: 77366 RVA: 0x002C1B4F File Offset: 0x002BFD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x06012E37 RID: 77367 RVA: 0x002C1B52 File Offset: 0x002BFD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerXboxBlockListResponse.Descriptor;
			}
		}

		// Token: 0x06012E38 RID: 77368 RVA: 0x002C1B59 File Offset: 0x002BFD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse()
		{
		}

		// Token: 0x06012E39 RID: 77369 RVA: 0x002C1B61 File Offset: 0x002BFD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse(PlayerXboxBlockListResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E3A RID: 77370 RVA: 0x002C1B7A File Offset: 0x002BFD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerXboxBlockListResponse Clone()
		{
			return new PlayerXboxBlockListResponse(this);
		}

		// Token: 0x06012E3B RID: 77371 RVA: 0x002C1B82 File Offset: 0x002BFD82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerXboxBlockListResponse);
		}

		// Token: 0x06012E3C RID: 77372 RVA: 0x002C1B90 File Offset: 0x002BFD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerXboxBlockListResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012E3D RID: 77373 RVA: 0x002C1BB0 File Offset: 0x002BFDB0
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

		// Token: 0x06012E3E RID: 77374 RVA: 0x002C1BD6 File Offset: 0x002BFDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E3F RID: 77375 RVA: 0x002C1BE3 File Offset: 0x002BFDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E40 RID: 77376 RVA: 0x002C1BEC File Offset: 0x002BFDEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E41 RID: 77377 RVA: 0x002C1C04 File Offset: 0x002BFE04
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

		// Token: 0x06012E42 RID: 77378 RVA: 0x002C1C2A File Offset: 0x002BFE2A
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

		// Token: 0x06012E43 RID: 77379 RVA: 0x002C1C47 File Offset: 0x002BFE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E44 RID: 77380 RVA: 0x002C1C50 File Offset: 0x002BFE50
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

		// Token: 0x04007549 RID: 30025
		private UnknownFieldSet _unknownFields;
	}
}
