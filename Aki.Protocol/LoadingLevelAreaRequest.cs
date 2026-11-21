using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092E RID: 2350
	[NetMessage(EMessageId.LoadingLevelAreaRequest)]
	public sealed class LoadingLevelAreaRequest : IMessage<LoadingLevelAreaRequest>, IMessage, IEquatable<LoadingLevelAreaRequest>, IDeepCloneable<LoadingLevelAreaRequest>, IBufferMessage
	{
		// Token: 0x0600CF70 RID: 53104 RVA: 0x001E8C9A File Offset: 0x001E6E9A
		[NullableContext(1)]
		public static LoadingLevelAreaRequest Create()
		{
			return new LoadingLevelAreaRequest();
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600CF71 RID: 53105 RVA: 0x001E8CA1 File Offset: 0x001E6EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600CF72 RID: 53106 RVA: 0x001E8CA4 File Offset: 0x001E6EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingLevelAreaRequest.Descriptor;
			}
		}

		// Token: 0x0600CF73 RID: 53107 RVA: 0x001E8CAB File Offset: 0x001E6EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest()
		{
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x001E8CB3 File Offset: 0x001E6EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest(LoadingLevelAreaRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF75 RID: 53109 RVA: 0x001E8CCC File Offset: 0x001E6ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingLevelAreaRequest Clone()
		{
			return new LoadingLevelAreaRequest(this);
		}

		// Token: 0x0600CF76 RID: 53110 RVA: 0x001E8CD4 File Offset: 0x001E6ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingLevelAreaRequest);
		}

		// Token: 0x0600CF77 RID: 53111 RVA: 0x001E8CE2 File Offset: 0x001E6EE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingLevelAreaRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600CF78 RID: 53112 RVA: 0x001E8D00 File Offset: 0x001E6F00
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

		// Token: 0x0600CF79 RID: 53113 RVA: 0x001E8D26 File Offset: 0x001E6F26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x001E8D33 File Offset: 0x001E6F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x001E8D3C File Offset: 0x001E6F3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x001E8D54 File Offset: 0x001E6F54
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

		// Token: 0x0600CF7D RID: 53117 RVA: 0x001E8D7A File Offset: 0x001E6F7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadingLevelAreaRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x001E8D97 File Offset: 0x001E6F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x001E8DA0 File Offset: 0x001E6FA0
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

		// Token: 0x040057D9 RID: 22489
		private UnknownFieldSet _unknownFields;
	}
}
