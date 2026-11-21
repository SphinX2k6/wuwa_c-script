using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001337 RID: 4919
	public sealed class SurvivorsGoldenCoinAbosorbedCtxPb : IMessage<SurvivorsGoldenCoinAbosorbedCtxPb>, IMessage, IEquatable<SurvivorsGoldenCoinAbosorbedCtxPb>, IDeepCloneable<SurvivorsGoldenCoinAbosorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0601A393 RID: 107411 RVA: 0x003D2B8E File Offset: 0x003D0D8E
		[NullableContext(1)]
		public static SurvivorsGoldenCoinAbosorbedCtxPb Create()
		{
			return new SurvivorsGoldenCoinAbosorbedCtxPb();
		}

		// Token: 0x170058D2 RID: 22738
		// (get) Token: 0x0601A394 RID: 107412 RVA: 0x003D2B95 File Offset: 0x003D0D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058D3 RID: 22739
		// (get) Token: 0x0601A395 RID: 107413 RVA: 0x003D2B98 File Offset: 0x003D0D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGoldenCoinAbosorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A396 RID: 107414 RVA: 0x003D2B9F File Offset: 0x003D0D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb()
		{
		}

		// Token: 0x0601A397 RID: 107415 RVA: 0x003D2BA7 File Offset: 0x003D0DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb(SurvivorsGoldenCoinAbosorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A398 RID: 107416 RVA: 0x003D2BC0 File Offset: 0x003D0DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb Clone()
		{
			return new SurvivorsGoldenCoinAbosorbedCtxPb(this);
		}

		// Token: 0x0601A399 RID: 107417 RVA: 0x003D2BC8 File Offset: 0x003D0DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGoldenCoinAbosorbedCtxPb);
		}

		// Token: 0x0601A39A RID: 107418 RVA: 0x003D2BD6 File Offset: 0x003D0DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGoldenCoinAbosorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601A39B RID: 107419 RVA: 0x003D2BF4 File Offset: 0x003D0DF4
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

		// Token: 0x0601A39C RID: 107420 RVA: 0x003D2C1A File Offset: 0x003D0E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A39D RID: 107421 RVA: 0x003D2C27 File Offset: 0x003D0E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A39E RID: 107422 RVA: 0x003D2C30 File Offset: 0x003D0E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A39F RID: 107423 RVA: 0x003D2C48 File Offset: 0x003D0E48
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

		// Token: 0x0601A3A0 RID: 107424 RVA: 0x003D2C6E File Offset: 0x003D0E6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsGoldenCoinAbosorbedCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A3A1 RID: 107425 RVA: 0x003D2C8B File Offset: 0x003D0E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A3A2 RID: 107426 RVA: 0x003D2C94 File Offset: 0x003D0E94
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

		// Token: 0x04009A40 RID: 39488
		private UnknownFieldSet _unknownFields;
	}
}
