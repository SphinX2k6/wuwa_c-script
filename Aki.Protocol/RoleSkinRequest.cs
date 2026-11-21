using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AD RID: 4269
	[NetMessage(EMessageId.RoleSkinRequest)]
	public sealed class RoleSkinRequest : IMessage<RoleSkinRequest>, IMessage, IEquatable<RoleSkinRequest>, IDeepCloneable<RoleSkinRequest>, IBufferMessage
	{
		// Token: 0x06016D16 RID: 93462 RVA: 0x00351213 File Offset: 0x0034F413
		[NullableContext(1)]
		public static RoleSkinRequest Create()
		{
			return new RoleSkinRequest();
		}

		// Token: 0x17004C79 RID: 19577
		// (get) Token: 0x06016D17 RID: 93463 RVA: 0x0035121A File Offset: 0x0034F41A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C7A RID: 19578
		// (get) Token: 0x06016D18 RID: 93464 RVA: 0x0035121D File Offset: 0x0034F41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinRequest.Descriptor;
			}
		}

		// Token: 0x06016D19 RID: 93465 RVA: 0x00351224 File Offset: 0x0034F424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest()
		{
		}

		// Token: 0x06016D1A RID: 93466 RVA: 0x0035122C File Offset: 0x0034F42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest(RoleSkinRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016D1B RID: 93467 RVA: 0x00351245 File Offset: 0x0034F445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinRequest Clone()
		{
			return new RoleSkinRequest(this);
		}

		// Token: 0x06016D1C RID: 93468 RVA: 0x0035124D File Offset: 0x0034F44D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinRequest);
		}

		// Token: 0x06016D1D RID: 93469 RVA: 0x0035125B File Offset: 0x0034F45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06016D1E RID: 93470 RVA: 0x0035127C File Offset: 0x0034F47C
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

		// Token: 0x06016D1F RID: 93471 RVA: 0x003512A2 File Offset: 0x0034F4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016D20 RID: 93472 RVA: 0x003512AF File Offset: 0x0034F4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016D21 RID: 93473 RVA: 0x003512B8 File Offset: 0x0034F4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x003512D0 File Offset: 0x0034F4D0
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

		// Token: 0x06016D23 RID: 93475 RVA: 0x003512F6 File Offset: 0x0034F4F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016D24 RID: 93476 RVA: 0x00351313 File Offset: 0x0034F513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x0035131C File Offset: 0x0034F51C
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

		// Token: 0x04008896 RID: 34966
		private UnknownFieldSet _unknownFields;
	}
}
