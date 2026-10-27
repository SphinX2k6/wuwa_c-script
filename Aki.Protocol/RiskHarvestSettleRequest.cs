using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F65 RID: 3941
	[NetMessage(EMessageId.RiskHarvestSettleRequest)]
	public sealed class RiskHarvestSettleRequest : IMessage<RiskHarvestSettleRequest>, IMessage, IEquatable<RiskHarvestSettleRequest>, IDeepCloneable<RiskHarvestSettleRequest>, IBufferMessage
	{
		// Token: 0x06015132 RID: 86322 RVA: 0x0030E685 File Offset: 0x0030C885
		[NullableContext(1)]
		public static RiskHarvestSettleRequest Create()
		{
			return new RiskHarvestSettleRequest();
		}

		// Token: 0x1700461A RID: 17946
		// (get) Token: 0x06015133 RID: 86323 RVA: 0x0030E68C File Offset: 0x0030C88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700461B RID: 17947
		// (get) Token: 0x06015134 RID: 86324 RVA: 0x0030E68F File Offset: 0x0030C88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RiskHarvestSettleRequest.Descriptor;
			}
		}

		// Token: 0x06015135 RID: 86325 RVA: 0x0030E696 File Offset: 0x0030C896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest()
		{
		}

		// Token: 0x06015136 RID: 86326 RVA: 0x0030E69E File Offset: 0x0030C89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest(RiskHarvestSettleRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015137 RID: 86327 RVA: 0x0030E6B7 File Offset: 0x0030C8B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RiskHarvestSettleRequest Clone()
		{
			return new RiskHarvestSettleRequest(this);
		}

		// Token: 0x06015138 RID: 86328 RVA: 0x0030E6BF File Offset: 0x0030C8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RiskHarvestSettleRequest);
		}

		// Token: 0x06015139 RID: 86329 RVA: 0x0030E6CD File Offset: 0x0030C8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RiskHarvestSettleRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601513A RID: 86330 RVA: 0x0030E6EC File Offset: 0x0030C8EC
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

		// Token: 0x0601513B RID: 86331 RVA: 0x0030E712 File Offset: 0x0030C912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601513C RID: 86332 RVA: 0x0030E71F File Offset: 0x0030C91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601513D RID: 86333 RVA: 0x0030E728 File Offset: 0x0030C928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601513E RID: 86334 RVA: 0x0030E740 File Offset: 0x0030C940
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

		// Token: 0x0601513F RID: 86335 RVA: 0x0030E766 File Offset: 0x0030C966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RiskHarvestSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015140 RID: 86336 RVA: 0x0030E783 File Offset: 0x0030C983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015141 RID: 86337 RVA: 0x0030E78C File Offset: 0x0030C98C
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

		// Token: 0x04007EE8 RID: 32488
		private UnknownFieldSet _unknownFields;
	}
}
