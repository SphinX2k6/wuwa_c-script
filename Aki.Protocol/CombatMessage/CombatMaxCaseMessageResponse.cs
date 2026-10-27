using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.CombatMessage
{
	// Token: 0x02001682 RID: 5762
	[NetMessage(EMessageId.CombatMaxCaseMessageResponse)]
	public sealed class CombatMaxCaseMessageResponse : IMessage<CombatMaxCaseMessageResponse>, IMessage, IEquatable<CombatMaxCaseMessageResponse>, IDeepCloneable<CombatMaxCaseMessageResponse>, IBufferMessage
	{
		// Token: 0x0601CBBF RID: 117695 RVA: 0x00425B56 File Offset: 0x00423D56
		[NullableContext(1)]
		public static CombatMaxCaseMessageResponse Create()
		{
			return new CombatMaxCaseMessageResponse();
		}

		// Token: 0x170060D6 RID: 24790
		// (get) Token: 0x0601CBC0 RID: 117696 RVA: 0x00425B5D File Offset: 0x00423D5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060D7 RID: 24791
		// (get) Token: 0x0601CBC1 RID: 117697 RVA: 0x00425B60 File Offset: 0x00423D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CombatMaxCaseMessageResponse.Descriptor;
			}
		}

		// Token: 0x0601CBC2 RID: 117698 RVA: 0x00425B67 File Offset: 0x00423D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse()
		{
		}

		// Token: 0x0601CBC3 RID: 117699 RVA: 0x00425B6F File Offset: 0x00423D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse(CombatMaxCaseMessageResponse other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CBC4 RID: 117700 RVA: 0x00425B88 File Offset: 0x00423D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatMaxCaseMessageResponse Clone()
		{
			return new CombatMaxCaseMessageResponse(this);
		}

		// Token: 0x0601CBC5 RID: 117701 RVA: 0x00425B90 File Offset: 0x00423D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CombatMaxCaseMessageResponse);
		}

		// Token: 0x0601CBC6 RID: 117702 RVA: 0x00425B9E File Offset: 0x00423D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CombatMaxCaseMessageResponse other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601CBC7 RID: 117703 RVA: 0x00425BBC File Offset: 0x00423DBC
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

		// Token: 0x0601CBC8 RID: 117704 RVA: 0x00425BE2 File Offset: 0x00423DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CBC9 RID: 117705 RVA: 0x00425BEF File Offset: 0x00423DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CBCA RID: 117706 RVA: 0x00425BF8 File Offset: 0x00423DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CBCB RID: 117707 RVA: 0x00425C10 File Offset: 0x00423E10
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

		// Token: 0x0601CBCC RID: 117708 RVA: 0x00425C36 File Offset: 0x00423E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CombatMaxCaseMessageResponse other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CBCD RID: 117709 RVA: 0x00425C53 File Offset: 0x00423E53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CBCE RID: 117710 RVA: 0x00425C5C File Offset: 0x00423E5C
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

		// Token: 0x0400C20A RID: 49674
		private UnknownFieldSet _unknownFields;
	}
}
