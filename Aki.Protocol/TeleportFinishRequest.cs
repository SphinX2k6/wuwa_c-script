using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AC RID: 5036
	[NetMessage(EMessageId.TeleportFinishRequest)]
	public sealed class TeleportFinishRequest : IMessage<TeleportFinishRequest>, IMessage, IEquatable<TeleportFinishRequest>, IDeepCloneable<TeleportFinishRequest>, IBufferMessage
	{
		// Token: 0x0601ACD4 RID: 109780 RVA: 0x003E7229 File Offset: 0x003E5429
		[NullableContext(1)]
		public static TeleportFinishRequest Create()
		{
			return new TeleportFinishRequest();
		}

		// Token: 0x17005ABF RID: 23231
		// (get) Token: 0x0601ACD5 RID: 109781 RVA: 0x003E7230 File Offset: 0x003E5430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AC0 RID: 23232
		// (get) Token: 0x0601ACD6 RID: 109782 RVA: 0x003E7233 File Offset: 0x003E5433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TeleportFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601ACD7 RID: 109783 RVA: 0x003E723A File Offset: 0x003E543A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest()
		{
		}

		// Token: 0x0601ACD8 RID: 109784 RVA: 0x003E7242 File Offset: 0x003E5442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest(TeleportFinishRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACD9 RID: 109785 RVA: 0x003E725B File Offset: 0x003E545B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportFinishRequest Clone()
		{
			return new TeleportFinishRequest(this);
		}

		// Token: 0x0601ACDA RID: 109786 RVA: 0x003E7263 File Offset: 0x003E5463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TeleportFinishRequest);
		}

		// Token: 0x0601ACDB RID: 109787 RVA: 0x003E7271 File Offset: 0x003E5471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TeleportFinishRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601ACDC RID: 109788 RVA: 0x003E7290 File Offset: 0x003E5490
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

		// Token: 0x0601ACDD RID: 109789 RVA: 0x003E72B6 File Offset: 0x003E54B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ACDE RID: 109790 RVA: 0x003E72C3 File Offset: 0x003E54C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ACDF RID: 109791 RVA: 0x003E72CC File Offset: 0x003E54CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ACE0 RID: 109792 RVA: 0x003E72E4 File Offset: 0x003E54E4
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

		// Token: 0x0601ACE1 RID: 109793 RVA: 0x003E730A File Offset: 0x003E550A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TeleportFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ACE2 RID: 109794 RVA: 0x003E7327 File Offset: 0x003E5527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ACE3 RID: 109795 RVA: 0x003E7330 File Offset: 0x003E5530
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

		// Token: 0x04009CD2 RID: 40146
		private UnknownFieldSet _unknownFields;
	}
}
