using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143B RID: 5179
	[NetMessage(EMessageId.TrapDefenseRefreshGainingGroupRequest)]
	public sealed class TrapDefenseRefreshGainingGroupRequest : IMessage<TrapDefenseRefreshGainingGroupRequest>, IMessage, IEquatable<TrapDefenseRefreshGainingGroupRequest>, IDeepCloneable<TrapDefenseRefreshGainingGroupRequest>, IBufferMessage
	{
		// Token: 0x0601B6EE RID: 112366 RVA: 0x003F8BAE File Offset: 0x003F6DAE
		[NullableContext(1)]
		public static TrapDefenseRefreshGainingGroupRequest Create()
		{
			return new TrapDefenseRefreshGainingGroupRequest();
		}

		// Token: 0x17005C7E RID: 23678
		// (get) Token: 0x0601B6EF RID: 112367 RVA: 0x003F8BB5 File Offset: 0x003F6DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C7F RID: 23679
		// (get) Token: 0x0601B6F0 RID: 112368 RVA: 0x003F8BB8 File Offset: 0x003F6DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseRefreshGainingGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601B6F1 RID: 112369 RVA: 0x003F8BBF File Offset: 0x003F6DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest()
		{
		}

		// Token: 0x0601B6F2 RID: 112370 RVA: 0x003F8BC7 File Offset: 0x003F6DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest(TrapDefenseRefreshGainingGroupRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6F3 RID: 112371 RVA: 0x003F8BE0 File Offset: 0x003F6DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseRefreshGainingGroupRequest Clone()
		{
			return new TrapDefenseRefreshGainingGroupRequest(this);
		}

		// Token: 0x0601B6F4 RID: 112372 RVA: 0x003F8BE8 File Offset: 0x003F6DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseRefreshGainingGroupRequest);
		}

		// Token: 0x0601B6F5 RID: 112373 RVA: 0x003F8BF6 File Offset: 0x003F6DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseRefreshGainingGroupRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B6F6 RID: 112374 RVA: 0x003F8C14 File Offset: 0x003F6E14
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

		// Token: 0x0601B6F7 RID: 112375 RVA: 0x003F8C3A File Offset: 0x003F6E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6F8 RID: 112376 RVA: 0x003F8C47 File Offset: 0x003F6E47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6F9 RID: 112377 RVA: 0x003F8C50 File Offset: 0x003F6E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6FA RID: 112378 RVA: 0x003F8C68 File Offset: 0x003F6E68
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

		// Token: 0x0601B6FB RID: 112379 RVA: 0x003F8C8E File Offset: 0x003F6E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseRefreshGainingGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6FC RID: 112380 RVA: 0x003F8CAB File Offset: 0x003F6EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6FD RID: 112381 RVA: 0x003F8CB4 File Offset: 0x003F6EB4
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

		// Token: 0x04009E4A RID: 40522
		private UnknownFieldSet _unknownFields;
	}
}
