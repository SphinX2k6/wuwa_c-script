using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000516 RID: 1302
	[NetMessage(EMessageId.FarmGoldResultRequest)]
	public sealed class FarmGoldResultRequest : IMessage<FarmGoldResultRequest>, IMessage, IEquatable<FarmGoldResultRequest>, IDeepCloneable<FarmGoldResultRequest>, IBufferMessage
	{
		// Token: 0x06007AA2 RID: 31394 RVA: 0x00129EFD File Offset: 0x001280FD
		[NullableContext(1)]
		public static FarmGoldResultRequest Create()
		{
			return new FarmGoldResultRequest();
		}

		// Token: 0x170017C4 RID: 6084
		// (get) Token: 0x06007AA3 RID: 31395 RVA: 0x00129F04 File Offset: 0x00128104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017C5 RID: 6085
		// (get) Token: 0x06007AA4 RID: 31396 RVA: 0x00129F07 File Offset: 0x00128107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultRequest.Descriptor;
			}
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00129F0E File Offset: 0x0012810E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest()
		{
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x00129F16 File Offset: 0x00128116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest(FarmGoldResultRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x00129F2F File Offset: 0x0012812F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultRequest Clone()
		{
			return new FarmGoldResultRequest(this);
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x00129F37 File Offset: 0x00128137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultRequest);
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x00129F45 File Offset: 0x00128145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x00129F64 File Offset: 0x00128164
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

		// Token: 0x06007AAB RID: 31403 RVA: 0x00129F8A File Offset: 0x0012818A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00129F97 File Offset: 0x00128197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00129FA0 File Offset: 0x001281A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x00129FB8 File Offset: 0x001281B8
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

		// Token: 0x06007AAF RID: 31407 RVA: 0x00129FDE File Offset: 0x001281DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00129FFB File Offset: 0x001281FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x0012A004 File Offset: 0x00128204
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

		// Token: 0x04003F4B RID: 16203
		private UnknownFieldSet _unknownFields;
	}
}
