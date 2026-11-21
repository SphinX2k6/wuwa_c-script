using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F8E RID: 3982
	[NetMessage(EMessageId.RoguelikeGotoNextRoomRequest)]
	public sealed class RoguelikeGotoNextRoomRequest : IMessage<RoguelikeGotoNextRoomRequest>, IMessage, IEquatable<RoguelikeGotoNextRoomRequest>, IDeepCloneable<RoguelikeGotoNextRoomRequest>, IBufferMessage
	{
		// Token: 0x06015532 RID: 87346 RVA: 0x00318E95 File Offset: 0x00317095
		[NullableContext(1)]
		public static RoguelikeGotoNextRoomRequest Create()
		{
			return new RoguelikeGotoNextRoomRequest();
		}

		// Token: 0x17004718 RID: 18200
		// (get) Token: 0x06015533 RID: 87347 RVA: 0x00318E9C File Offset: 0x0031709C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004719 RID: 18201
		// (get) Token: 0x06015534 RID: 87348 RVA: 0x00318E9F File Offset: 0x0031709F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeGotoNextRoomRequest.Descriptor;
			}
		}

		// Token: 0x06015535 RID: 87349 RVA: 0x00318EA6 File Offset: 0x003170A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest()
		{
		}

		// Token: 0x06015536 RID: 87350 RVA: 0x00318EAE File Offset: 0x003170AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest(RoguelikeGotoNextRoomRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015537 RID: 87351 RVA: 0x00318EC7 File Offset: 0x003170C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeGotoNextRoomRequest Clone()
		{
			return new RoguelikeGotoNextRoomRequest(this);
		}

		// Token: 0x06015538 RID: 87352 RVA: 0x00318ECF File Offset: 0x003170CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeGotoNextRoomRequest);
		}

		// Token: 0x06015539 RID: 87353 RVA: 0x00318EDD File Offset: 0x003170DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeGotoNextRoomRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601553A RID: 87354 RVA: 0x00318EFC File Offset: 0x003170FC
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

		// Token: 0x0601553B RID: 87355 RVA: 0x00318F22 File Offset: 0x00317122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601553C RID: 87356 RVA: 0x00318F2F File Offset: 0x0031712F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601553D RID: 87357 RVA: 0x00318F38 File Offset: 0x00317138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601553E RID: 87358 RVA: 0x00318F50 File Offset: 0x00317150
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

		// Token: 0x0601553F RID: 87359 RVA: 0x00318F76 File Offset: 0x00317176
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

		// Token: 0x06015540 RID: 87360 RVA: 0x00318F93 File Offset: 0x00317193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015541 RID: 87361 RVA: 0x00318F9C File Offset: 0x0031719C
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

		// Token: 0x040080CA RID: 32970
		private UnknownFieldSet _unknownFields;
	}
}
