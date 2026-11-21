using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001438 RID: 5176
	[NetMessage(EMessageId.TowerRequest)]
	public sealed class TowerRequest : IMessage<TowerRequest>, IMessage, IEquatable<TowerRequest>, IDeepCloneable<TowerRequest>, IBufferMessage
	{
		// Token: 0x0601B816 RID: 112662 RVA: 0x003FF9E8 File Offset: 0x003FDBE8
		[NullableContext(1)]
		public static TowerRequest Create()
		{
			return new TowerRequest();
		}

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x0601B817 RID: 112663 RVA: 0x003FF9EF File Offset: 0x003FDBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D22 RID: 23842
		// (get) Token: 0x0601B818 RID: 112664 RVA: 0x003FF9F2 File Offset: 0x003FDBF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRequest.Descriptor;
			}
		}

		// Token: 0x0601B819 RID: 112665 RVA: 0x003FF9F9 File Offset: 0x003FDBF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest()
		{
		}

		// Token: 0x0601B81A RID: 112666 RVA: 0x003FFA01 File Offset: 0x003FDC01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest(TowerRequest other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B81B RID: 112667 RVA: 0x003FFA1A File Offset: 0x003FDC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRequest Clone()
		{
			return new TowerRequest(this);
		}

		// Token: 0x0601B81C RID: 112668 RVA: 0x003FFA22 File Offset: 0x003FDC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRequest);
		}

		// Token: 0x0601B81D RID: 112669 RVA: 0x003FFA30 File Offset: 0x003FDC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRequest other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B81E RID: 112670 RVA: 0x003FFA50 File Offset: 0x003FDC50
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

		// Token: 0x0601B81F RID: 112671 RVA: 0x003FFA76 File Offset: 0x003FDC76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B820 RID: 112672 RVA: 0x003FFA83 File Offset: 0x003FDC83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B821 RID: 112673 RVA: 0x003FFA8C File Offset: 0x003FDC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B822 RID: 112674 RVA: 0x003FFAA4 File Offset: 0x003FDCA4
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

		// Token: 0x0601B823 RID: 112675 RVA: 0x003FFACA File Offset: 0x003FDCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRequest other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B824 RID: 112676 RVA: 0x003FFAE7 File Offset: 0x003FDCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B825 RID: 112677 RVA: 0x003FFAF0 File Offset: 0x003FDCF0
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

		// Token: 0x0400A013 RID: 40979
		private UnknownFieldSet _unknownFields;
	}
}
