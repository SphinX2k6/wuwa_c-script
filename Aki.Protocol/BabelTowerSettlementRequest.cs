using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000151 RID: 337
	[NetMessage(EMessageId.BabelTowerSettlementRequest)]
	public sealed class BabelTowerSettlementRequest : IMessage<BabelTowerSettlementRequest>, IMessage, IEquatable<BabelTowerSettlementRequest>, IDeepCloneable<BabelTowerSettlementRequest>, IBufferMessage
	{
		// Token: 0x06002AE5 RID: 10981 RVA: 0x000703BB File Offset: 0x0006E5BB
		[NullableContext(1)]
		public static BabelTowerSettlementRequest Create()
		{
			return new BabelTowerSettlementRequest();
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x000703C2 File Offset: 0x0006E5C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002AE7 RID: 10983 RVA: 0x000703C5 File Offset: 0x0006E5C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSettlementRequest.Descriptor;
			}
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000703CC File Offset: 0x0006E5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest()
		{
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000703D4 File Offset: 0x0006E5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest(BabelTowerSettlementRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x000703ED File Offset: 0x0006E5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSettlementRequest Clone()
		{
			return new BabelTowerSettlementRequest(this);
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000703F5 File Offset: 0x0006E5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSettlementRequest);
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00070403 File Offset: 0x0006E603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSettlementRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00070424 File Offset: 0x0006E624
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

		// Token: 0x06002AEE RID: 10990 RVA: 0x0007044A File Offset: 0x0006E64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00070457 File Offset: 0x0006E657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x00070460 File Offset: 0x0006E660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x00070478 File Offset: 0x0006E678
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

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0007049E File Offset: 0x0006E69E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSettlementRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x000704BB File Offset: 0x0006E6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x000704C4 File Offset: 0x0006E6C4
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

		// Token: 0x04002781 RID: 10113
		private UnknownFieldSet _unknownFields;
	}
}
