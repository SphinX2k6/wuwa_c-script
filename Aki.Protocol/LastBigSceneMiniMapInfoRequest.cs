using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E6 RID: 2278
	[NetMessage(EMessageId.LastBigSceneMiniMapInfoRequest)]
	public sealed class LastBigSceneMiniMapInfoRequest : IMessage<LastBigSceneMiniMapInfoRequest>, IMessage, IEquatable<LastBigSceneMiniMapInfoRequest>, IDeepCloneable<LastBigSceneMiniMapInfoRequest>, IBufferMessage
	{
		// Token: 0x0600C98A RID: 51594 RVA: 0x001DC549 File Offset: 0x001DA749
		[NullableContext(1)]
		public static LastBigSceneMiniMapInfoRequest Create()
		{
			return new LastBigSceneMiniMapInfoRequest();
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x0600C98B RID: 51595 RVA: 0x001DC550 File Offset: 0x001DA750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x0600C98C RID: 51596 RVA: 0x001DC553 File Offset: 0x001DA753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LastBigSceneMiniMapInfoRequest.Descriptor;
			}
		}

		// Token: 0x0600C98D RID: 51597 RVA: 0x001DC55A File Offset: 0x001DA75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest()
		{
		}

		// Token: 0x0600C98E RID: 51598 RVA: 0x001DC562 File Offset: 0x001DA762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest(LastBigSceneMiniMapInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x001DC57B File Offset: 0x001DA77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LastBigSceneMiniMapInfoRequest Clone()
		{
			return new LastBigSceneMiniMapInfoRequest(this);
		}

		// Token: 0x0600C990 RID: 51600 RVA: 0x001DC583 File Offset: 0x001DA783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LastBigSceneMiniMapInfoRequest);
		}

		// Token: 0x0600C991 RID: 51601 RVA: 0x001DC591 File Offset: 0x001DA791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LastBigSceneMiniMapInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600C992 RID: 51602 RVA: 0x001DC5B0 File Offset: 0x001DA7B0
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

		// Token: 0x0600C993 RID: 51603 RVA: 0x001DC5D6 File Offset: 0x001DA7D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C994 RID: 51604 RVA: 0x001DC5E3 File Offset: 0x001DA7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C995 RID: 51605 RVA: 0x001DC5EC File Offset: 0x001DA7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C996 RID: 51606 RVA: 0x001DC604 File Offset: 0x001DA804
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

		// Token: 0x0600C997 RID: 51607 RVA: 0x001DC62A File Offset: 0x001DA82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LastBigSceneMiniMapInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C998 RID: 51608 RVA: 0x001DC647 File Offset: 0x001DA847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C999 RID: 51609 RVA: 0x001DC650 File Offset: 0x001DA850
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

		// Token: 0x040055F4 RID: 22004
		private UnknownFieldSet _unknownFields;
	}
}
