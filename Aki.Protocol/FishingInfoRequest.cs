using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000567 RID: 1383
	[NetMessage(EMessageId.FishingInfoRequest)]
	public sealed class FishingInfoRequest : IMessage<FishingInfoRequest>, IMessage, IEquatable<FishingInfoRequest>, IDeepCloneable<FishingInfoRequest>, IBufferMessage
	{
		// Token: 0x060080E7 RID: 32999 RVA: 0x00137970 File Offset: 0x00135B70
		[NullableContext(1)]
		public static FishingInfoRequest Create()
		{
			return new FishingInfoRequest();
		}

		// Token: 0x17001921 RID: 6433
		// (get) Token: 0x060080E8 RID: 33000 RVA: 0x00137977 File Offset: 0x00135B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001922 RID: 6434
		// (get) Token: 0x060080E9 RID: 33001 RVA: 0x0013797A File Offset: 0x00135B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingInfoRequest.Descriptor;
			}
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x00137981 File Offset: 0x00135B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest()
		{
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00137989 File Offset: 0x00135B89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest(FishingInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x001379A2 File Offset: 0x00135BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingInfoRequest Clone()
		{
			return new FishingInfoRequest(this);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x001379AA File Offset: 0x00135BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingInfoRequest);
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x001379B8 File Offset: 0x00135BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x001379D8 File Offset: 0x00135BD8
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

		// Token: 0x060080F0 RID: 33008 RVA: 0x001379FE File Offset: 0x00135BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x00137A0B File Offset: 0x00135C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00137A14 File Offset: 0x00135C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00137A2C File Offset: 0x00135C2C
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

		// Token: 0x060080F4 RID: 33012 RVA: 0x00137A52 File Offset: 0x00135C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x00137A6F File Offset: 0x00135C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x00137A78 File Offset: 0x00135C78
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

		// Token: 0x040040DC RID: 16604
		private UnknownFieldSet _unknownFields;
	}
}
