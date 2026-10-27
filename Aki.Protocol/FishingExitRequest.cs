using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000559 RID: 1369
	[NetMessage(EMessageId.FishingExitRequest)]
	public sealed class FishingExitRequest : IMessage<FishingExitRequest>, IMessage, IEquatable<FishingExitRequest>, IDeepCloneable<FishingExitRequest>, IBufferMessage
	{
		// Token: 0x06007FC3 RID: 32707 RVA: 0x00134D81 File Offset: 0x00132F81
		[NullableContext(1)]
		public static FishingExitRequest Create()
		{
			return new FishingExitRequest();
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x00134D88 File Offset: 0x00132F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x06007FC5 RID: 32709 RVA: 0x00134D8B File Offset: 0x00132F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingExitRequest.Descriptor;
			}
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x00134D92 File Offset: 0x00132F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest()
		{
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x00134D9A File Offset: 0x00132F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest(FishingExitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x00134DB3 File Offset: 0x00132FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingExitRequest Clone()
		{
			return new FishingExitRequest(this);
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x00134DBB File Offset: 0x00132FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingExitRequest);
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x00134DC9 File Offset: 0x00132FC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingExitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x00134DE8 File Offset: 0x00132FE8
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

		// Token: 0x06007FCC RID: 32716 RVA: 0x00134E0E File Offset: 0x0013300E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007FCD RID: 32717 RVA: 0x00134E1B File Offset: 0x0013301B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x00134E24 File Offset: 0x00133024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x00134E3C File Offset: 0x0013303C
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

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00134E62 File Offset: 0x00133062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingExitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x00134E7F File Offset: 0x0013307F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x00134E88 File Offset: 0x00133088
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

		// Token: 0x04004074 RID: 16500
		private UnknownFieldSet _unknownFields;
	}
}
