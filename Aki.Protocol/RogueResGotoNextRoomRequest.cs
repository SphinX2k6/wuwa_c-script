using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD2 RID: 4050
	[NetMessage(EMessageId.RogueResGotoNextRoomRequest)]
	public sealed class RogueResGotoNextRoomRequest : IMessage<RogueResGotoNextRoomRequest>, IMessage, IEquatable<RogueResGotoNextRoomRequest>, IDeepCloneable<RogueResGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x06015ACC RID: 88780 RVA: 0x00326375 File Offset: 0x00324575
		[NullableContext(1)]
		public static RogueResGotoNextRoomRequest Create()
		{
			return new RogueResGotoNextRoomRequest();
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x06015ACD RID: 88781 RVA: 0x0032637C File Offset: 0x0032457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x06015ACE RID: 88782 RVA: 0x0032637F File Offset: 0x0032457F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x06015ACF RID: 88783 RVA: 0x00326386 File Offset: 0x00324586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest()
		{
		}

		// Token: 0x06015AD0 RID: 88784 RVA: 0x0032638E File Offset: 0x0032458E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest(RogueResGotoNextRoomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015AD1 RID: 88785 RVA: 0x003263A7 File Offset: 0x003245A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGotoNextRoomRequest Clone()
		{
			return new RogueResGotoNextRoomRequest(this);
		}

		// Token: 0x06015AD2 RID: 88786 RVA: 0x003263AF File Offset: 0x003245AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResGotoNextRoomRequest);
		}

		// Token: 0x06015AD3 RID: 88787 RVA: 0x003263BD File Offset: 0x003245BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResGotoNextRoomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06015AD4 RID: 88788 RVA: 0x003263DC File Offset: 0x003245DC
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

		// Token: 0x06015AD5 RID: 88789 RVA: 0x00326402 File Offset: 0x00324602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015AD6 RID: 88790 RVA: 0x0032640F File Offset: 0x0032460F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015AD7 RID: 88791 RVA: 0x00326418 File Offset: 0x00324618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015AD8 RID: 88792 RVA: 0x00326430 File Offset: 0x00324630
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

		// Token: 0x06015AD9 RID: 88793 RVA: 0x00326456 File Offset: 0x00324656
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

		// Token: 0x06015ADA RID: 88794 RVA: 0x00326473 File Offset: 0x00324673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015ADB RID: 88795 RVA: 0x0032647C File Offset: 0x0032467C
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

		// Token: 0x04008291 RID: 33425
		private UnknownFieldSet _unknownFields;
	}
}
