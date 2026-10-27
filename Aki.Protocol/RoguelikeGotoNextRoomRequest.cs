using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9E RID: 3998
	[NetMessage(EMessageId.RoguelikeGotoNextRoomRequest)]
	public sealed class RoguelikeGotoNextRoomRequest : IMessage<RoguelikeGotoNextRoomRequest>, IMessage, IEquatable<RoguelikeGotoNextRoomRequest>, IDeepCloneable<RoguelikeGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x06015617 RID: 87575 RVA: 0x0031A53D File Offset: 0x0031873D
		[NullableContext(1)]
		public static RoguelikeGotoNextRoomRequest Create()
		{
			return new RoguelikeGotoNextRoomRequest();
		}

		// Token: 0x17004742 RID: 18242
		// (get) Token: 0x06015618 RID: 87576 RVA: 0x0031A544 File Offset: 0x00318744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004743 RID: 18243
		// (get) Token: 0x06015619 RID: 87577 RVA: 0x0031A547 File Offset: 0x00318747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x0601561A RID: 87578 RVA: 0x0031A54E File Offset: 0x0031874E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest()
		{
		}

		// Token: 0x0601561B RID: 87579 RVA: 0x0031A556 File Offset: 0x00318756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest(RoguelikeGotoNextRoomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601561C RID: 87580 RVA: 0x0031A56F File Offset: 0x0031876F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest Clone()
		{
			return new RoguelikeGotoNextRoomRequest(this);
		}

		// Token: 0x0601561D RID: 87581 RVA: 0x0031A577 File Offset: 0x00318777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGotoNextRoomRequest);
		}

		// Token: 0x0601561E RID: 87582 RVA: 0x0031A585 File Offset: 0x00318785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGotoNextRoomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601561F RID: 87583 RVA: 0x0031A5A4 File Offset: 0x003187A4
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

		// Token: 0x06015620 RID: 87584 RVA: 0x0031A5CA File Offset: 0x003187CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015621 RID: 87585 RVA: 0x0031A5D7 File Offset: 0x003187D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015622 RID: 87586 RVA: 0x0031A5E0 File Offset: 0x003187E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015623 RID: 87587 RVA: 0x0031A5F8 File Offset: 0x003187F8
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

		// Token: 0x06015624 RID: 87588 RVA: 0x0031A61E File Offset: 0x0031881E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeGotoNextRoomRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015625 RID: 87589 RVA: 0x0031A63B File Offset: 0x0031883B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015626 RID: 87590 RVA: 0x0031A644 File Offset: 0x00318844
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

		// Token: 0x040080A0 RID: 32928
		private UnknownFieldSet _unknownFields;
	}
}
