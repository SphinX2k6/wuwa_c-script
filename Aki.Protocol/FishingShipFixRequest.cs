using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000568 RID: 1384
	[NetMessage(EMessageId.FishingShipFixRequest)]
	public sealed class FishingShipFixRequest : IMessage<FishingShipFixRequest>, IMessage, IEquatable<FishingShipFixRequest>, IDeepCloneable<FishingShipFixRequest>, IBufferMessage
	{
		// Token: 0x06008126 RID: 33062 RVA: 0x00138268 File Offset: 0x00136468
		[NullableContext(1)]
		public static FishingShipFixRequest Create()
		{
			return new FishingShipFixRequest();
		}

		// Token: 0x17001925 RID: 6437
		// (get) Token: 0x06008127 RID: 33063 RVA: 0x0013826F File Offset: 0x0013646F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x06008128 RID: 33064 RVA: 0x00138272 File Offset: 0x00136472
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipFixRequest.Descriptor;
			}
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00138279 File Offset: 0x00136479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest()
		{
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00138281 File Offset: 0x00136481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest(FishingShipFixRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x0013829A File Offset: 0x0013649A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest Clone()
		{
			return new FishingShipFixRequest(this);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x001382A2 File Offset: 0x001364A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipFixRequest);
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x001382B0 File Offset: 0x001364B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipFixRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x001382D0 File Offset: 0x001364D0
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

		// Token: 0x0600812F RID: 33071 RVA: 0x001382F6 File Offset: 0x001364F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00138303 File Offset: 0x00136503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x0013830C File Offset: 0x0013650C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x00138324 File Offset: 0x00136524
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

		// Token: 0x06008133 RID: 33075 RVA: 0x0013834A File Offset: 0x0013654A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingShipFixRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x00138367 File Offset: 0x00136567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x00138370 File Offset: 0x00136570
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

		// Token: 0x0400413C RID: 16700
		private UnknownFieldSet _unknownFields;
	}
}
