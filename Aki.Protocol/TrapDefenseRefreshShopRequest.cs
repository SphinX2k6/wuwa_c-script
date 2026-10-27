using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143D RID: 5181
	[NetMessage(EMessageId.TrapDefenseRefreshShopRequest)]
	public sealed class TrapDefenseRefreshShopRequest : IMessage<TrapDefenseRefreshShopRequest>, IMessage, IEquatable<TrapDefenseRefreshShopRequest>, IDeepCloneable<TrapDefenseRefreshShopRequest>, IBufferMessage
	{
		// Token: 0x0601B712 RID: 112402 RVA: 0x003F8FDB File Offset: 0x003F71DB
		[NullableContext(1)]
		public static TrapDefenseRefreshShopRequest Create()
		{
			return new TrapDefenseRefreshShopRequest();
		}

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x0601B713 RID: 112403 RVA: 0x003F8FE2 File Offset: 0x003F71E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x0601B714 RID: 112404 RVA: 0x003F8FE5 File Offset: 0x003F71E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshShopRequest.Descriptor;
			}
		}

		// Token: 0x0601B715 RID: 112405 RVA: 0x003F8FEC File Offset: 0x003F71EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest()
		{
		}

		// Token: 0x0601B716 RID: 112406 RVA: 0x003F8FF4 File Offset: 0x003F71F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest(TrapDefenseRefreshShopRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B717 RID: 112407 RVA: 0x003F900D File Offset: 0x003F720D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshShopRequest Clone()
		{
			return new TrapDefenseRefreshShopRequest(this);
		}

		// Token: 0x0601B718 RID: 112408 RVA: 0x003F9015 File Offset: 0x003F7215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshShopRequest);
		}

		// Token: 0x0601B719 RID: 112409 RVA: 0x003F9023 File Offset: 0x003F7223
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshShopRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B71A RID: 112410 RVA: 0x003F9044 File Offset: 0x003F7244
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

		// Token: 0x0601B71B RID: 112411 RVA: 0x003F906A File Offset: 0x003F726A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B71C RID: 112412 RVA: 0x003F9077 File Offset: 0x003F7277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B71D RID: 112413 RVA: 0x003F9080 File Offset: 0x003F7280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B71E RID: 112414 RVA: 0x003F9098 File Offset: 0x003F7298
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

		// Token: 0x0601B71F RID: 112415 RVA: 0x003F90BE File Offset: 0x003F72BE
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

		// Token: 0x0601B720 RID: 112416 RVA: 0x003F90DB File Offset: 0x003F72DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B721 RID: 112417 RVA: 0x003F90E4 File Offset: 0x003F72E4
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

		// Token: 0x04009E50 RID: 40528
		private UnknownFieldSet _unknownFields;
	}
}
