using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014B0 RID: 5296
	[NetMessage(EMessageId.TrapDefenseRefreshShopRequest)]
	public sealed class TrapDefenseRefreshShopRequest : IMessage<TrapDefenseRefreshShopRequest>, IMessage, IEquatable<TrapDefenseRefreshShopRequest>, IDeepCloneable<TrapDefenseRefreshShopRequest>, IBufferMessage
	{
		// Token: 0x0601C19D RID: 115101 RVA: 0x004142AF File Offset: 0x004124AF
		[NullableContext(1)]
		public static TrapDefenseRefreshShopRequest Create()
		{
			return new TrapDefenseRefreshShopRequest();
		}

		// Token: 0x17005F19 RID: 24345
		// (get) Token: 0x0601C19E RID: 115102 RVA: 0x004142B6 File Offset: 0x004124B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F1A RID: 24346
		// (get) Token: 0x0601C19F RID: 115103 RVA: 0x004142B9 File Offset: 0x004124B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshShopRequest.Descriptor;
			}
		}

		// Token: 0x0601C1A0 RID: 115104 RVA: 0x004142C0 File Offset: 0x004124C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest()
		{
		}

		// Token: 0x0601C1A1 RID: 115105 RVA: 0x004142C8 File Offset: 0x004124C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest(TrapDefenseRefreshShopRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C1A2 RID: 115106 RVA: 0x004142E1 File Offset: 0x004124E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest Clone()
		{
			return new TrapDefenseRefreshShopRequest(this);
		}

		// Token: 0x0601C1A3 RID: 115107 RVA: 0x004142E9 File Offset: 0x004124E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshShopRequest);
		}

		// Token: 0x0601C1A4 RID: 115108 RVA: 0x004142F7 File Offset: 0x004124F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshShopRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C1A5 RID: 115109 RVA: 0x00414318 File Offset: 0x00412518
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

		// Token: 0x0601C1A6 RID: 115110 RVA: 0x0041433E File Offset: 0x0041253E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C1A7 RID: 115111 RVA: 0x0041434B File Offset: 0x0041254B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C1A8 RID: 115112 RVA: 0x00414354 File Offset: 0x00412554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C1A9 RID: 115113 RVA: 0x0041436C File Offset: 0x0041256C
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

		// Token: 0x0601C1AA RID: 115114 RVA: 0x00414392 File Offset: 0x00412592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshShopRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C1AB RID: 115115 RVA: 0x004143AF File Offset: 0x004125AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C1AC RID: 115116 RVA: 0x004143B8 File Offset: 0x004125B8
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

		// Token: 0x0400A297 RID: 41623
		private UnknownFieldSet _unknownFields;
	}
}
