using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D84 RID: 3460
	[NetMessage(EMessageId.PlayerHeadRequest)]
	public sealed class PlayerHeadRequest : IMessage<PlayerHeadRequest>, IMessage, IEquatable<PlayerHeadRequest>, IDeepCloneable<PlayerHeadRequest>, IBufferMessage
	{
		// Token: 0x06012AE2 RID: 76514 RVA: 0x002BA841 File Offset: 0x002B8A41
		[NullableContext(1)]
		public static PlayerHeadRequest Create()
		{
			return new PlayerHeadRequest();
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x06012AE3 RID: 76515 RVA: 0x002BA848 File Offset: 0x002B8A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x06012AE4 RID: 76516 RVA: 0x002BA84B File Offset: 0x002B8A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerHeadRequest.Descriptor;
			}
		}

		// Token: 0x06012AE5 RID: 76517 RVA: 0x002BA852 File Offset: 0x002B8A52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest()
		{
		}

		// Token: 0x06012AE6 RID: 76518 RVA: 0x002BA85A File Offset: 0x002B8A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest(PlayerHeadRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012AE7 RID: 76519 RVA: 0x002BA873 File Offset: 0x002B8A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerHeadRequest Clone()
		{
			return new PlayerHeadRequest(this);
		}

		// Token: 0x06012AE8 RID: 76520 RVA: 0x002BA87B File Offset: 0x002B8A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerHeadRequest);
		}

		// Token: 0x06012AE9 RID: 76521 RVA: 0x002BA889 File Offset: 0x002B8A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerHeadRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012AEA RID: 76522 RVA: 0x002BA8A8 File Offset: 0x002B8AA8
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

		// Token: 0x06012AEB RID: 76523 RVA: 0x002BA8CE File Offset: 0x002B8ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012AEC RID: 76524 RVA: 0x002BA8DB File Offset: 0x002B8ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012AED RID: 76525 RVA: 0x002BA8E4 File Offset: 0x002B8AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012AEE RID: 76526 RVA: 0x002BA8FC File Offset: 0x002B8AFC
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

		// Token: 0x06012AEF RID: 76527 RVA: 0x002BA922 File Offset: 0x002B8B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerHeadRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012AF0 RID: 76528 RVA: 0x002BA93F File Offset: 0x002B8B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012AF1 RID: 76529 RVA: 0x002BA948 File Offset: 0x002B8B48
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

		// Token: 0x04007452 RID: 29778
		private UnknownFieldSet _unknownFields;
	}
}
