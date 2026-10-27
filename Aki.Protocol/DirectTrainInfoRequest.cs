using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DA RID: 986
	[NetMessage(EMessageId.DirectTrainInfoRequest)]
	public sealed class DirectTrainInfoRequest : IMessage<DirectTrainInfoRequest>, IMessage, IEquatable<DirectTrainInfoRequest>, IDeepCloneable<DirectTrainInfoRequest>, IBufferMessage
	{
		// Token: 0x0600600B RID: 24587 RVA: 0x000E86F4 File Offset: 0x000E68F4
		[NullableContext(1)]
		public static DirectTrainInfoRequest Create()
		{
			return new DirectTrainInfoRequest();
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x000E86FB File Offset: 0x000E68FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600600D RID: 24589 RVA: 0x000E86FE File Offset: 0x000E68FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x000E8705 File Offset: 0x000E6905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest()
		{
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x000E870D File Offset: 0x000E690D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest(DirectTrainInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x000E8726 File Offset: 0x000E6926
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoRequest Clone()
		{
			return new DirectTrainInfoRequest(this);
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x000E872E File Offset: 0x000E692E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoRequest);
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x000E873C File Offset: 0x000E693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x000E875C File Offset: 0x000E695C
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

		// Token: 0x06006014 RID: 24596 RVA: 0x000E8782 File Offset: 0x000E6982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x000E878F File Offset: 0x000E698F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x000E8798 File Offset: 0x000E6998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x000E87B0 File Offset: 0x000E69B0
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

		// Token: 0x06006018 RID: 24600 RVA: 0x000E87D6 File Offset: 0x000E69D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x000E87F3 File Offset: 0x000E69F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x000E87FC File Offset: 0x000E69FC
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

		// Token: 0x0400374C RID: 14156
		private UnknownFieldSet _unknownFields;
	}
}
