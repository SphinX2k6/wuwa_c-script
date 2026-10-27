using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E2 RID: 738
	[NetMessage(EMessageId.ConsumptiveActivityInfoRequest)]
	public sealed class ConsumptiveActivityInfoRequest : IMessage<ConsumptiveActivityInfoRequest>, IMessage, IEquatable<ConsumptiveActivityInfoRequest>, IDeepCloneable<ConsumptiveActivityInfoRequest>, IBufferMessage
	{
		// Token: 0x06004B2F RID: 19247 RVA: 0x000B753B File Offset: 0x000B573B
		[NullableContext(1)]
		public static ConsumptiveActivityInfoRequest Create()
		{
			return new ConsumptiveActivityInfoRequest();
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06004B30 RID: 19248 RVA: 0x000B7542 File Offset: 0x000B5742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06004B31 RID: 19249 RVA: 0x000B7545 File Offset: 0x000B5745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveActivityInfoRequest.Descriptor;
			}
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x000B754C File Offset: 0x000B574C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest()
		{
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x000B7554 File Offset: 0x000B5754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest(ConsumptiveActivityInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x000B756D File Offset: 0x000B576D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveActivityInfoRequest Clone()
		{
			return new ConsumptiveActivityInfoRequest(this);
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x000B7575 File Offset: 0x000B5775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveActivityInfoRequest);
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x000B7583 File Offset: 0x000B5783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveActivityInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x000B75A4 File Offset: 0x000B57A4
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

		// Token: 0x06004B38 RID: 19256 RVA: 0x000B75CA File Offset: 0x000B57CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x000B75D7 File Offset: 0x000B57D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x000B75E0 File Offset: 0x000B57E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x000B75F8 File Offset: 0x000B57F8
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

		// Token: 0x06004B3C RID: 19260 RVA: 0x000B761E File Offset: 0x000B581E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveActivityInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x000B763B File Offset: 0x000B583B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x000B7644 File Offset: 0x000B5844
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

		// Token: 0x040030A7 RID: 12455
		private UnknownFieldSet _unknownFields;
	}
}
