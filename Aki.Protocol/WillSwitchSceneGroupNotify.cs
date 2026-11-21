using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200158A RID: 5514
	[NetMessage(EMessageId.WillSwitchSceneGroupNotify)]
	public sealed class WillSwitchSceneGroupNotify : IMessage<WillSwitchSceneGroupNotify>, IMessage, IEquatable<WillSwitchSceneGroupNotify>, IDeepCloneable<WillSwitchSceneGroupNotify>, IBufferMessage
	{
		// Token: 0x0601D30E RID: 119566 RVA: 0x00439FE0 File Offset: 0x004381E0
		[NullableContext(1)]
		public static WillSwitchSceneGroupNotify Create()
		{
			return new WillSwitchSceneGroupNotify();
		}

		// Token: 0x170062C3 RID: 25283
		// (get) Token: 0x0601D30F RID: 119567 RVA: 0x00439FE7 File Offset: 0x004381E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062C4 RID: 25284
		// (get) Token: 0x0601D310 RID: 119568 RVA: 0x00439FEA File Offset: 0x004381EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WillSwitchSceneGroupNotify.Descriptor;
			}
		}

		// Token: 0x0601D311 RID: 119569 RVA: 0x00439FF1 File Offset: 0x004381F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify()
		{
		}

		// Token: 0x0601D312 RID: 119570 RVA: 0x00439FF9 File Offset: 0x004381F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify(WillSwitchSceneGroupNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D313 RID: 119571 RVA: 0x0043A012 File Offset: 0x00438212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WillSwitchSceneGroupNotify Clone()
		{
			return new WillSwitchSceneGroupNotify(this);
		}

		// Token: 0x0601D314 RID: 119572 RVA: 0x0043A01A File Offset: 0x0043821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WillSwitchSceneGroupNotify);
		}

		// Token: 0x0601D315 RID: 119573 RVA: 0x0043A028 File Offset: 0x00438228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WillSwitchSceneGroupNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601D316 RID: 119574 RVA: 0x0043A048 File Offset: 0x00438248
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

		// Token: 0x0601D317 RID: 119575 RVA: 0x0043A06E File Offset: 0x0043826E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D318 RID: 119576 RVA: 0x0043A07B File Offset: 0x0043827B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D319 RID: 119577 RVA: 0x0043A084 File Offset: 0x00438284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D31A RID: 119578 RVA: 0x0043A09C File Offset: 0x0043829C
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

		// Token: 0x0601D31B RID: 119579 RVA: 0x0043A0C2 File Offset: 0x004382C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WillSwitchSceneGroupNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D31C RID: 119580 RVA: 0x0043A0DF File Offset: 0x004382DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D31D RID: 119581 RVA: 0x0043A0E8 File Offset: 0x004382E8
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

		// Token: 0x0400A782 RID: 42882
		private UnknownFieldSet _unknownFields;
	}
}
