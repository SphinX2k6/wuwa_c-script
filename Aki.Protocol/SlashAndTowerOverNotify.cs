using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001288 RID: 4744
	[NetMessage(EMessageId.SlashAndTowerOverNotify)]
	public sealed class SlashAndTowerOverNotify : IMessage<SlashAndTowerOverNotify>, IMessage, IEquatable<SlashAndTowerOverNotify>, IDeepCloneable<SlashAndTowerOverNotify>, IBufferMessage
	{
		// Token: 0x0601952F RID: 103727 RVA: 0x003B197D File Offset: 0x003AFB7D
		[NullableContext(1)]
		public static SlashAndTowerOverNotify Create()
		{
			return new SlashAndTowerOverNotify();
		}

		// Token: 0x170055A8 RID: 21928
		// (get) Token: 0x06019530 RID: 103728 RVA: 0x003B1984 File Offset: 0x003AFB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055A9 RID: 21929
		// (get) Token: 0x06019531 RID: 103729 RVA: 0x003B1987 File Offset: 0x003AFB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerOverNotify.Descriptor;
			}
		}

		// Token: 0x06019532 RID: 103730 RVA: 0x003B198E File Offset: 0x003AFB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify()
		{
		}

		// Token: 0x06019533 RID: 103731 RVA: 0x003B1996 File Offset: 0x003AFB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify(SlashAndTowerOverNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019534 RID: 103732 RVA: 0x003B19AF File Offset: 0x003AFBAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerOverNotify Clone()
		{
			return new SlashAndTowerOverNotify(this);
		}

		// Token: 0x06019535 RID: 103733 RVA: 0x003B19B7 File Offset: 0x003AFBB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerOverNotify);
		}

		// Token: 0x06019536 RID: 103734 RVA: 0x003B19C5 File Offset: 0x003AFBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerOverNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019537 RID: 103735 RVA: 0x003B19E4 File Offset: 0x003AFBE4
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

		// Token: 0x06019538 RID: 103736 RVA: 0x003B1A0A File Offset: 0x003AFC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019539 RID: 103737 RVA: 0x003B1A17 File Offset: 0x003AFC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601953A RID: 103738 RVA: 0x003B1A20 File Offset: 0x003AFC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601953B RID: 103739 RVA: 0x003B1A38 File Offset: 0x003AFC38
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

		// Token: 0x0601953C RID: 103740 RVA: 0x003B1A5E File Offset: 0x003AFC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerOverNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601953D RID: 103741 RVA: 0x003B1A7B File Offset: 0x003AFC7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601953E RID: 103742 RVA: 0x003B1A84 File Offset: 0x003AFC84
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

		// Token: 0x040095D6 RID: 38358
		private UnknownFieldSet _unknownFields;
	}
}
