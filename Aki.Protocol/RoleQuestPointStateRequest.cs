using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A3 RID: 4259
	[NetMessage(EMessageId.RoleQuestPointStateRequest)]
	public sealed class RoleQuestPointStateRequest : IMessage<RoleQuestPointStateRequest>, IMessage, IEquatable<RoleQuestPointStateRequest>, IDeepCloneable<RoleQuestPointStateRequest>, IBufferMessage
	{
		// Token: 0x06016BEA RID: 93162 RVA: 0x0034E259 File Offset: 0x0034C459
		[NullableContext(1)]
		public static RoleQuestPointStateRequest Create()
		{
			return new RoleQuestPointStateRequest();
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x06016BEB RID: 93163 RVA: 0x0034E260 File Offset: 0x0034C460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C35 RID: 19509
		// (get) Token: 0x06016BEC RID: 93164 RVA: 0x0034E263 File Offset: 0x0034C463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestPointStateRequest.Descriptor;
			}
		}

		// Token: 0x06016BED RID: 93165 RVA: 0x0034E26A File Offset: 0x0034C46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest()
		{
		}

		// Token: 0x06016BEE RID: 93166 RVA: 0x0034E272 File Offset: 0x0034C472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest(RoleQuestPointStateRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BEF RID: 93167 RVA: 0x0034E28B File Offset: 0x0034C48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestPointStateRequest Clone()
		{
			return new RoleQuestPointStateRequest(this);
		}

		// Token: 0x06016BF0 RID: 93168 RVA: 0x0034E293 File Offset: 0x0034C493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestPointStateRequest);
		}

		// Token: 0x06016BF1 RID: 93169 RVA: 0x0034E2A1 File Offset: 0x0034C4A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestPointStateRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016BF2 RID: 93170 RVA: 0x0034E2C0 File Offset: 0x0034C4C0
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

		// Token: 0x06016BF3 RID: 93171 RVA: 0x0034E2E6 File Offset: 0x0034C4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BF4 RID: 93172 RVA: 0x0034E2F3 File Offset: 0x0034C4F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BF5 RID: 93173 RVA: 0x0034E2FC File Offset: 0x0034C4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BF6 RID: 93174 RVA: 0x0034E314 File Offset: 0x0034C514
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

		// Token: 0x06016BF7 RID: 93175 RVA: 0x0034E33A File Offset: 0x0034C53A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestPointStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BF8 RID: 93176 RVA: 0x0034E357 File Offset: 0x0034C557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BF9 RID: 93177 RVA: 0x0034E360 File Offset: 0x0034C560
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

		// Token: 0x040087D4 RID: 34772
		private UnknownFieldSet _unknownFields;
	}
}
