using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F99 RID: 3993
	[NetMessage(EMessageId.RoguelikeQuitRequest)]
	public sealed class RoguelikeQuitRequest : IMessage<RoguelikeQuitRequest>, IMessage, IEquatable<RoguelikeQuitRequest>, IDeepCloneable<RoguelikeQuitRequest>, IBufferMessage
	{
		// Token: 0x0601561A RID: 87578 RVA: 0x0031B213 File Offset: 0x00319413
		[NullableContext(1)]
		public static RoguelikeQuitRequest Create()
		{
			return new RoguelikeQuitRequest();
		}

		// Token: 0x1700474C RID: 18252
		// (get) Token: 0x0601561B RID: 87579 RVA: 0x0031B21A File Offset: 0x0031941A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700474D RID: 18253
		// (get) Token: 0x0601561C RID: 87580 RVA: 0x0031B21D File Offset: 0x0031941D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601561D RID: 87581 RVA: 0x0031B224 File Offset: 0x00319424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest()
		{
		}

		// Token: 0x0601561E RID: 87582 RVA: 0x0031B22C File Offset: 0x0031942C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest(RoguelikeQuitRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601561F RID: 87583 RVA: 0x0031B245 File Offset: 0x00319445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeQuitRequest Clone()
		{
			return new RoguelikeQuitRequest(this);
		}

		// Token: 0x06015620 RID: 87584 RVA: 0x0031B24D File Offset: 0x0031944D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeQuitRequest);
		}

		// Token: 0x06015621 RID: 87585 RVA: 0x0031B25B File Offset: 0x0031945B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeQuitRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015622 RID: 87586 RVA: 0x0031B27C File Offset: 0x0031947C
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

		// Token: 0x06015623 RID: 87587 RVA: 0x0031B2A2 File Offset: 0x003194A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015624 RID: 87588 RVA: 0x0031B2AF File Offset: 0x003194AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x0031B2B8 File Offset: 0x003194B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015626 RID: 87590 RVA: 0x0031B2D0 File Offset: 0x003194D0
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

		// Token: 0x06015627 RID: 87591 RVA: 0x0031B2F6 File Offset: 0x003194F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015628 RID: 87592 RVA: 0x0031B313 File Offset: 0x00319513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015629 RID: 87593 RVA: 0x0031B31C File Offset: 0x0031951C
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

		// Token: 0x04008118 RID: 33048
		private UnknownFieldSet _unknownFields;
	}
}
