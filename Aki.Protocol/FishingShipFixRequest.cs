using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057D RID: 1405
	[NetMessage(EMessageId.FishingShipFixRequest)]
	public sealed class FishingShipFixRequest : IMessage<FishingShipFixRequest>, IMessage, IEquatable<FishingShipFixRequest>, IDeepCloneable<FishingShipFixRequest>, IBufferMessage
	{
		// Token: 0x0600828E RID: 33422 RVA: 0x0013AE71 File Offset: 0x00139071
		[NullableContext(1)]
		public static FishingShipFixRequest Create()
		{
			return new FishingShipFixRequest();
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600828F RID: 33423 RVA: 0x0013AE78 File Offset: 0x00139078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x0013AE7B File Offset: 0x0013907B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingShipFixRequest.Descriptor;
			}
		}

		// Token: 0x06008291 RID: 33425 RVA: 0x0013AE82 File Offset: 0x00139082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest()
		{
		}

		// Token: 0x06008292 RID: 33426 RVA: 0x0013AE8A File Offset: 0x0013908A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest(FishingShipFixRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008293 RID: 33427 RVA: 0x0013AEA3 File Offset: 0x001390A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingShipFixRequest Clone()
		{
			return new FishingShipFixRequest(this);
		}

		// Token: 0x06008294 RID: 33428 RVA: 0x0013AEAB File Offset: 0x001390AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingShipFixRequest);
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x0013AEB9 File Offset: 0x001390B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingShipFixRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008296 RID: 33430 RVA: 0x0013AED8 File Offset: 0x001390D8
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

		// Token: 0x06008297 RID: 33431 RVA: 0x0013AEFE File Offset: 0x001390FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x0013AF0B File Offset: 0x0013910B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x0013AF14 File Offset: 0x00139114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x0013AF2C File Offset: 0x0013912C
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

		// Token: 0x0600829B RID: 33435 RVA: 0x0013AF52 File Offset: 0x00139152
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

		// Token: 0x0600829C RID: 33436 RVA: 0x0013AF6F File Offset: 0x0013916F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x0013AF78 File Offset: 0x00139178
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

		// Token: 0x04004146 RID: 16710
		private UnknownFieldSet _unknownFields;
	}
}
