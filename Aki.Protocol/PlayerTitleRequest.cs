using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB5 RID: 3509
	[NetMessage(EMessageId.PlayerTitleRequest)]
	public sealed class PlayerTitleRequest : IMessage<PlayerTitleRequest>, IMessage, IEquatable<PlayerTitleRequest>, IDeepCloneable<PlayerTitleRequest>, IBufferMessage
	{
		// Token: 0x06012E8B RID: 77451 RVA: 0x002C240E File Offset: 0x002C060E
		[NullableContext(1)]
		public static PlayerTitleRequest Create()
		{
			return new PlayerTitleRequest();
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x06012E8C RID: 77452 RVA: 0x002C2415 File Offset: 0x002C0615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x06012E8D RID: 77453 RVA: 0x002C2418 File Offset: 0x002C0618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerTitleRequest.Descriptor;
			}
		}

		// Token: 0x06012E8E RID: 77454 RVA: 0x002C241F File Offset: 0x002C061F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest()
		{
		}

		// Token: 0x06012E8F RID: 77455 RVA: 0x002C2427 File Offset: 0x002C0627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest(PlayerTitleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E90 RID: 77456 RVA: 0x002C2440 File Offset: 0x002C0640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerTitleRequest Clone()
		{
			return new PlayerTitleRequest(this);
		}

		// Token: 0x06012E91 RID: 77457 RVA: 0x002C2448 File Offset: 0x002C0648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerTitleRequest);
		}

		// Token: 0x06012E92 RID: 77458 RVA: 0x002C2456 File Offset: 0x002C0656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerTitleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012E93 RID: 77459 RVA: 0x002C2474 File Offset: 0x002C0674
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

		// Token: 0x06012E94 RID: 77460 RVA: 0x002C249A File Offset: 0x002C069A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E95 RID: 77461 RVA: 0x002C24A7 File Offset: 0x002C06A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E96 RID: 77462 RVA: 0x002C24B0 File Offset: 0x002C06B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012E97 RID: 77463 RVA: 0x002C24C8 File Offset: 0x002C06C8
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

		// Token: 0x06012E98 RID: 77464 RVA: 0x002C24EE File Offset: 0x002C06EE
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

		// Token: 0x06012E99 RID: 77465 RVA: 0x002C250B File Offset: 0x002C070B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E9A RID: 77466 RVA: 0x002C2514 File Offset: 0x002C0714
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

		// Token: 0x04007509 RID: 29961
		private UnknownFieldSet _unknownFields;
	}
}
