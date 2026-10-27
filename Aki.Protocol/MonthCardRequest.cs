using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A0C RID: 2572
	[NetMessage(EMessageId.MonthCardRequest)]
	public sealed class MonthCardRequest : IMessage<MonthCardRequest>, IMessage, IEquatable<MonthCardRequest>, IDeepCloneable<MonthCardRequest>, IBufferMessage
	{
		// Token: 0x0600E106 RID: 57606 RVA: 0x0020F6C6 File Offset: 0x0020D8C6
		[NullableContext(1)]
		public static MonthCardRequest Create()
		{
			return new MonthCardRequest();
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x0600E107 RID: 57607 RVA: 0x0020F6CD File Offset: 0x0020D8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x0600E108 RID: 57608 RVA: 0x0020F6D0 File Offset: 0x0020D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonthCardRequest.Descriptor;
			}
		}

		// Token: 0x0600E109 RID: 57609 RVA: 0x0020F6D7 File Offset: 0x0020D8D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest()
		{
		}

		// Token: 0x0600E10A RID: 57610 RVA: 0x0020F6DF File Offset: 0x0020D8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest(MonthCardRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E10B RID: 57611 RVA: 0x0020F6F8 File Offset: 0x0020D8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonthCardRequest Clone()
		{
			return new MonthCardRequest(this);
		}

		// Token: 0x0600E10C RID: 57612 RVA: 0x0020F700 File Offset: 0x0020D900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonthCardRequest);
		}

		// Token: 0x0600E10D RID: 57613 RVA: 0x0020F70E File Offset: 0x0020D90E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonthCardRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600E10E RID: 57614 RVA: 0x0020F72C File Offset: 0x0020D92C
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

		// Token: 0x0600E10F RID: 57615 RVA: 0x0020F752 File Offset: 0x0020D952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E110 RID: 57616 RVA: 0x0020F75F File Offset: 0x0020D95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E111 RID: 57617 RVA: 0x0020F768 File Offset: 0x0020D968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E112 RID: 57618 RVA: 0x0020F780 File Offset: 0x0020D980
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

		// Token: 0x0600E113 RID: 57619 RVA: 0x0020F7A6 File Offset: 0x0020D9A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonthCardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E114 RID: 57620 RVA: 0x0020F7C3 File Offset: 0x0020D9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E115 RID: 57621 RVA: 0x0020F7CC File Offset: 0x0020D9CC
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

		// Token: 0x04005C8A RID: 23690
		private UnknownFieldSet _unknownFields;
	}
}
