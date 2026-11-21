using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149E RID: 5278
	public sealed class TrapDefenseGoldenCoinAbosorbedCtxPb : IMessage<TrapDefenseGoldenCoinAbosorbedCtxPb>, IMessage, IEquatable<TrapDefenseGoldenCoinAbosorbedCtxPb>, IDeepCloneable<TrapDefenseGoldenCoinAbosorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0601C044 RID: 114756 RVA: 0x00411A3D File Offset: 0x0040FC3D
		[NullableContext(1)]
		public static TrapDefenseGoldenCoinAbosorbedCtxPb Create()
		{
			return new TrapDefenseGoldenCoinAbosorbedCtxPb();
		}

		// Token: 0x17005ED8 RID: 24280
		// (get) Token: 0x0601C045 RID: 114757 RVA: 0x00411A44 File Offset: 0x0040FC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED9 RID: 24281
		// (get) Token: 0x0601C046 RID: 114758 RVA: 0x00411A47 File Offset: 0x0040FC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGoldenCoinAbosorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C047 RID: 114759 RVA: 0x00411A4E File Offset: 0x0040FC4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb()
		{
		}

		// Token: 0x0601C048 RID: 114760 RVA: 0x00411A56 File Offset: 0x0040FC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb(TrapDefenseGoldenCoinAbosorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C049 RID: 114761 RVA: 0x00411A6F File Offset: 0x0040FC6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinAbosorbedCtxPb Clone()
		{
			return new TrapDefenseGoldenCoinAbosorbedCtxPb(this);
		}

		// Token: 0x0601C04A RID: 114762 RVA: 0x00411A77 File Offset: 0x0040FC77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGoldenCoinAbosorbedCtxPb);
		}

		// Token: 0x0601C04B RID: 114763 RVA: 0x00411A85 File Offset: 0x0040FC85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGoldenCoinAbosorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x00411AA4 File Offset: 0x0040FCA4
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

		// Token: 0x0601C04D RID: 114765 RVA: 0x00411ACA File Offset: 0x0040FCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C04E RID: 114766 RVA: 0x00411AD7 File Offset: 0x0040FCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C04F RID: 114767 RVA: 0x00411AE0 File Offset: 0x0040FCE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C050 RID: 114768 RVA: 0x00411AF8 File Offset: 0x0040FCF8
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

		// Token: 0x0601C051 RID: 114769 RVA: 0x00411B1E File Offset: 0x0040FD1E
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

		// Token: 0x0601C052 RID: 114770 RVA: 0x00411B3B File Offset: 0x0040FD3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C053 RID: 114771 RVA: 0x00411B44 File Offset: 0x0040FD44
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

		// Token: 0x0400A24A RID: 41546
		private UnknownFieldSet _unknownFields;
	}
}
