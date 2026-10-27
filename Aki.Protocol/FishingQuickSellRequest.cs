using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000574 RID: 1396
	[NetMessage(EMessageId.FishingQuickSellRequest)]
	public sealed class FishingQuickSellRequest : IMessage<FishingQuickSellRequest>, IMessage, IEquatable<FishingQuickSellRequest>, IDeepCloneable<FishingQuickSellRequest>, IBufferMessage
	{
		// Token: 0x060081E8 RID: 33256 RVA: 0x00139B93 File Offset: 0x00137D93
		[NullableContext(1)]
		public static FishingQuickSellRequest Create()
		{
			return new FishingQuickSellRequest();
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x00139B9A File Offset: 0x00137D9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060081EA RID: 33258 RVA: 0x00139B9D File Offset: 0x00137D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingQuickSellRequest.Descriptor;
			}
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x00139BA4 File Offset: 0x00137DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest()
		{
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x00139BAC File Offset: 0x00137DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest(FishingQuickSellRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x00139BC5 File Offset: 0x00137DC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingQuickSellRequest Clone()
		{
			return new FishingQuickSellRequest(this);
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x00139BCD File Offset: 0x00137DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingQuickSellRequest);
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x00139BDB File Offset: 0x00137DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingQuickSellRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x00139BFC File Offset: 0x00137DFC
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

		// Token: 0x060081F1 RID: 33265 RVA: 0x00139C22 File Offset: 0x00137E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x00139C2F File Offset: 0x00137E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x00139C38 File Offset: 0x00137E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00139C50 File Offset: 0x00137E50
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

		// Token: 0x060081F5 RID: 33269 RVA: 0x00139C76 File Offset: 0x00137E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingQuickSellRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x00139C93 File Offset: 0x00137E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x00139C9C File Offset: 0x00137E9C
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

		// Token: 0x04004124 RID: 16676
		private UnknownFieldSet _unknownFields;
	}
}
