using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001202 RID: 4610
	[NetMessage(EMessageId.ShortMessageInfoRequest)]
	public sealed class ShortMessageInfoRequest : IMessage<ShortMessageInfoRequest>, IMessage, IEquatable<ShortMessageInfoRequest>, IDeepCloneable<ShortMessageInfoRequest>, IBufferMessage
	{
		// Token: 0x06018934 RID: 100660 RVA: 0x00392DD6 File Offset: 0x00390FD6
		[NullableContext(1)]
		public static ShortMessageInfoRequest Create()
		{
			return new ShortMessageInfoRequest();
		}

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x06018935 RID: 100661 RVA: 0x00392DDD File Offset: 0x00390FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06018936 RID: 100662 RVA: 0x00392DE0 File Offset: 0x00390FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageInfoRequest.Descriptor;
			}
		}

		// Token: 0x06018937 RID: 100663 RVA: 0x00392DE7 File Offset: 0x00390FE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest()
		{
		}

		// Token: 0x06018938 RID: 100664 RVA: 0x00392DEF File Offset: 0x00390FEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest(ShortMessageInfoRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018939 RID: 100665 RVA: 0x00392E08 File Offset: 0x00391008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageInfoRequest Clone()
		{
			return new ShortMessageInfoRequest(this);
		}

		// Token: 0x0601893A RID: 100666 RVA: 0x00392E10 File Offset: 0x00391010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageInfoRequest);
		}

		// Token: 0x0601893B RID: 100667 RVA: 0x00392E1E File Offset: 0x0039101E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageInfoRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601893C RID: 100668 RVA: 0x00392E3C File Offset: 0x0039103C
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

		// Token: 0x0601893D RID: 100669 RVA: 0x00392E62 File Offset: 0x00391062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601893E RID: 100670 RVA: 0x00392E6F File Offset: 0x0039106F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601893F RID: 100671 RVA: 0x00392E78 File Offset: 0x00391078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018940 RID: 100672 RVA: 0x00392E90 File Offset: 0x00391090
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

		// Token: 0x06018941 RID: 100673 RVA: 0x00392EB6 File Offset: 0x003910B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018942 RID: 100674 RVA: 0x00392ED3 File Offset: 0x003910D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018943 RID: 100675 RVA: 0x00392EDC File Offset: 0x003910DC
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

		// Token: 0x04009137 RID: 37175
		private UnknownFieldSet _unknownFields;
	}
}
