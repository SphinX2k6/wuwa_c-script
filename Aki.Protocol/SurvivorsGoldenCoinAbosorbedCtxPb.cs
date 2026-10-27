using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012C8 RID: 4808
	public sealed class SurvivorsGoldenCoinAbosorbedCtxPb : IMessage<SurvivorsGoldenCoinAbosorbedCtxPb>, IMessage, IEquatable<SurvivorsGoldenCoinAbosorbedCtxPb>, IDeepCloneable<SurvivorsGoldenCoinAbosorbedCtxPb>, IBufferMessage
	{
		// Token: 0x0601995D RID: 104797 RVA: 0x003B8452 File Offset: 0x003B6652
		[NullableContext(1)]
		public static SurvivorsGoldenCoinAbosorbedCtxPb Create()
		{
			return new SurvivorsGoldenCoinAbosorbedCtxPb();
		}

		// Token: 0x17005651 RID: 22097
		// (get) Token: 0x0601995E RID: 104798 RVA: 0x003B8459 File Offset: 0x003B6659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005652 RID: 22098
		// (get) Token: 0x0601995F RID: 104799 RVA: 0x003B845C File Offset: 0x003B665C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsGoldenCoinAbosorbedCtxPb.Descriptor;
			}
		}

		// Token: 0x06019960 RID: 104800 RVA: 0x003B8463 File Offset: 0x003B6663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb()
		{
		}

		// Token: 0x06019961 RID: 104801 RVA: 0x003B846B File Offset: 0x003B666B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb(SurvivorsGoldenCoinAbosorbedCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019962 RID: 104802 RVA: 0x003B8484 File Offset: 0x003B6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsGoldenCoinAbosorbedCtxPb Clone()
		{
			return new SurvivorsGoldenCoinAbosorbedCtxPb(this);
		}

		// Token: 0x06019963 RID: 104803 RVA: 0x003B848C File Offset: 0x003B668C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsGoldenCoinAbosorbedCtxPb);
		}

		// Token: 0x06019964 RID: 104804 RVA: 0x003B849A File Offset: 0x003B669A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsGoldenCoinAbosorbedCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06019965 RID: 104805 RVA: 0x003B84B8 File Offset: 0x003B66B8
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

		// Token: 0x06019966 RID: 104806 RVA: 0x003B84DE File Offset: 0x003B66DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019967 RID: 104807 RVA: 0x003B84EB File Offset: 0x003B66EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019968 RID: 104808 RVA: 0x003B84F4 File Offset: 0x003B66F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019969 RID: 104809 RVA: 0x003B850C File Offset: 0x003B670C
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

		// Token: 0x0601996A RID: 104810 RVA: 0x003B8532 File Offset: 0x003B6732
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

		// Token: 0x0601996B RID: 104811 RVA: 0x003B854F File Offset: 0x003B674F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601996C RID: 104812 RVA: 0x003B8558 File Offset: 0x003B6758
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

		// Token: 0x04009616 RID: 38422
		private UnknownFieldSet _unknownFields;
	}
}
