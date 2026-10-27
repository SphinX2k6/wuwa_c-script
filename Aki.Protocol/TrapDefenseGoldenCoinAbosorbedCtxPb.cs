using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142B RID: 5163
	public sealed class TrapDefenseGoldenCoinAbosorbedCtxPb : IMessage<TrapDefenseGoldenCoinAbosorbedCtxPb>, IMessage, IEquatable<TrapDefenseGoldenCoinAbosorbedCtxPb>, IDeepCloneable<TrapDefenseGoldenCoinAbosorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0601B5B9 RID: 112057 RVA: 0x003F6769 File Offset: 0x003F4969
		[NullableContext(1)]
		public static TrapDefenseGoldenCoinAbosorbedCtxPb Create()
		{
			return new TrapDefenseGoldenCoinAbosorbedCtxPb();
		}

		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x0601B5BA RID: 112058 RVA: 0x003F6770 File Offset: 0x003F4970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x0601B5BB RID: 112059 RVA: 0x003F6773 File Offset: 0x003F4973
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGoldenCoinAbosorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B5BC RID: 112060 RVA: 0x003F677A File Offset: 0x003F497A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb()
		{
		}

		// Token: 0x0601B5BD RID: 112061 RVA: 0x003F6782 File Offset: 0x003F4982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb(TrapDefenseGoldenCoinAbosorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5BE RID: 112062 RVA: 0x003F679B File Offset: 0x003F499B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb Clone()
		{
			return new TrapDefenseGoldenCoinAbosorbedCtxPb(this);
		}

		// Token: 0x0601B5BF RID: 112063 RVA: 0x003F67A3 File Offset: 0x003F49A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGoldenCoinAbosorbedCtxPb);
		}

		// Token: 0x0601B5C0 RID: 112064 RVA: 0x003F67B1 File Offset: 0x003F49B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGoldenCoinAbosorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B5C1 RID: 112065 RVA: 0x003F67D0 File Offset: 0x003F49D0
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

		// Token: 0x0601B5C2 RID: 112066 RVA: 0x003F67F6 File Offset: 0x003F49F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5C3 RID: 112067 RVA: 0x003F6803 File Offset: 0x003F4A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5C4 RID: 112068 RVA: 0x003F680C File Offset: 0x003F4A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5C5 RID: 112069 RVA: 0x003F6824 File Offset: 0x003F4A24
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

		// Token: 0x0601B5C6 RID: 112070 RVA: 0x003F684A File Offset: 0x003F4A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGoldenCoinAbosorbedCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5C7 RID: 112071 RVA: 0x003F6867 File Offset: 0x003F4A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5C8 RID: 112072 RVA: 0x003F6870 File Offset: 0x003F4A70
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

		// Token: 0x04009E03 RID: 40451
		private UnknownFieldSet _unknownFields;
	}
}
