using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE2 RID: 4066
	[NetMessage(EMessageId.RogueResGotoNextRoomRequest)]
	public sealed class RogueResGotoNextRoomRequest : IMessage<RogueResGotoNextRoomRequest>, IMessage, IEquatable<RogueResGotoNextRoomRequest>, IDeepCloneable<RogueResGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x06015BB1 RID: 89009 RVA: 0x00327A29 File Offset: 0x00325C29
		[NullableContext(1)]
		public static RogueResGotoNextRoomRequest Create()
		{
			return new RogueResGotoNextRoomRequest();
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06015BB2 RID: 89010 RVA: 0x00327A30 File Offset: 0x00325C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06015BB3 RID: 89011 RVA: 0x00327A33 File Offset: 0x00325C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x06015BB4 RID: 89012 RVA: 0x00327A3A File Offset: 0x00325C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest()
		{
		}

		// Token: 0x06015BB5 RID: 89013 RVA: 0x00327A42 File Offset: 0x00325C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest(RogueResGotoNextRoomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015BB6 RID: 89014 RVA: 0x00327A5B File Offset: 0x00325C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest Clone()
		{
			return new RogueResGotoNextRoomRequest(this);
		}

		// Token: 0x06015BB7 RID: 89015 RVA: 0x00327A63 File Offset: 0x00325C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGotoNextRoomRequest);
		}

		// Token: 0x06015BB8 RID: 89016 RVA: 0x00327A71 File Offset: 0x00325C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGotoNextRoomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015BB9 RID: 89017 RVA: 0x00327A90 File Offset: 0x00325C90
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

		// Token: 0x06015BBA RID: 89018 RVA: 0x00327AB6 File Offset: 0x00325CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015BBB RID: 89019 RVA: 0x00327AC3 File Offset: 0x00325CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015BBC RID: 89020 RVA: 0x00327ACC File Offset: 0x00325CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015BBD RID: 89021 RVA: 0x00327AE4 File Offset: 0x00325CE4
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

		// Token: 0x06015BBE RID: 89022 RVA: 0x00327B0A File Offset: 0x00325D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResGotoNextRoomRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015BBF RID: 89023 RVA: 0x00327B27 File Offset: 0x00325D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015BC0 RID: 89024 RVA: 0x00327B30 File Offset: 0x00325D30
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

		// Token: 0x04008267 RID: 33383
		private UnknownFieldSet _unknownFields;
	}
}
