using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001681 RID: 5761
	[NetMessage(EMessageId.CombatMaxCaseMessageRequest)]
	public sealed class CombatMaxCaseMessageRequest : IMessage<CombatMaxCaseMessageRequest>, IMessage, IEquatable<CombatMaxCaseMessageRequest>, IDeepCloneable<CombatMaxCaseMessageRequest>, IBufferMessage
	{
		// Token: 0x0601CBAF RID: 117679 RVA: 0x00425A1E File Offset: 0x00423C1E
		[NullableContext(1)]
		public static CombatMaxCaseMessageRequest Create()
		{
			return new CombatMaxCaseMessageRequest();
		}

		// Token: 0x170060D4 RID: 24788
		// (get) Token: 0x0601CBB0 RID: 117680 RVA: 0x00425A25 File Offset: 0x00423C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D5 RID: 24789
		// (get) Token: 0x0601CBB1 RID: 117681 RVA: 0x00425A28 File Offset: 0x00423C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMaxCaseMessageRequest.Descriptor;
			}
		}

		// Token: 0x0601CBB2 RID: 117682 RVA: 0x00425A2F File Offset: 0x00423C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest()
		{
		}

		// Token: 0x0601CBB3 RID: 117683 RVA: 0x00425A37 File Offset: 0x00423C37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest(CombatMaxCaseMessageRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBB4 RID: 117684 RVA: 0x00425A50 File Offset: 0x00423C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageRequest Clone()
		{
			return new CombatMaxCaseMessageRequest(this);
		}

		// Token: 0x0601CBB5 RID: 117685 RVA: 0x00425A58 File Offset: 0x00423C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMaxCaseMessageRequest);
		}

		// Token: 0x0601CBB6 RID: 117686 RVA: 0x00425A66 File Offset: 0x00423C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMaxCaseMessageRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CBB7 RID: 117687 RVA: 0x00425A84 File Offset: 0x00423C84
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

		// Token: 0x0601CBB8 RID: 117688 RVA: 0x00425AAA File Offset: 0x00423CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBB9 RID: 117689 RVA: 0x00425AB7 File Offset: 0x00423CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBBA RID: 117690 RVA: 0x00425AC0 File Offset: 0x00423CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBBB RID: 117691 RVA: 0x00425AD8 File Offset: 0x00423CD8
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

		// Token: 0x0601CBBC RID: 117692 RVA: 0x00425AFE File Offset: 0x00423CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMaxCaseMessageRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBBD RID: 117693 RVA: 0x00425B1B File Offset: 0x00423D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBBE RID: 117694 RVA: 0x00425B24 File Offset: 0x00423D24
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

		// Token: 0x0400C209 RID: 49673
		private UnknownFieldSet _unknownFields;
	}
}
