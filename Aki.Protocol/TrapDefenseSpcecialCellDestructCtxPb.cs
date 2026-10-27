using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200144F RID: 5199
	public sealed class TrapDefenseSpcecialCellDestructCtxPb : IMessage<TrapDefenseSpcecialCellDestructCtxPb>, IMessage, IEquatable<TrapDefenseSpcecialCellDestructCtxPb>, IDeepCloneable<TrapDefenseSpcecialCellDestructCtxPb>, IBufferMessage
	{
		// Token: 0x0601B88C RID: 112780 RVA: 0x003FC661 File Offset: 0x003FA861
		[NullableContext(1)]
		public static TrapDefenseSpcecialCellDestructCtxPb Create()
		{
			return new TrapDefenseSpcecialCellDestructCtxPb();
		}

		// Token: 0x17005CD8 RID: 23768
		// (get) Token: 0x0601B88D RID: 112781 RVA: 0x003FC668 File Offset: 0x003FA868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD9 RID: 23769
		// (get) Token: 0x0601B88E RID: 112782 RVA: 0x003FC66B File Offset: 0x003FA86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpcecialCellDestructCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B88F RID: 112783 RVA: 0x003FC672 File Offset: 0x003FA872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb()
		{
		}

		// Token: 0x0601B890 RID: 112784 RVA: 0x003FC67A File Offset: 0x003FA87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb(TrapDefenseSpcecialCellDestructCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B891 RID: 112785 RVA: 0x003FC693 File Offset: 0x003FA893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb Clone()
		{
			return new TrapDefenseSpcecialCellDestructCtxPb(this);
		}

		// Token: 0x0601B892 RID: 112786 RVA: 0x003FC69B File Offset: 0x003FA89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpcecialCellDestructCtxPb);
		}

		// Token: 0x0601B893 RID: 112787 RVA: 0x003FC6A9 File Offset: 0x003FA8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpcecialCellDestructCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601B894 RID: 112788 RVA: 0x003FC6C8 File Offset: 0x003FA8C8
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

		// Token: 0x0601B895 RID: 112789 RVA: 0x003FC6EE File Offset: 0x003FA8EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B896 RID: 112790 RVA: 0x003FC6FB File Offset: 0x003FA8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B897 RID: 112791 RVA: 0x003FC704 File Offset: 0x003FA904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B898 RID: 112792 RVA: 0x003FC71C File Offset: 0x003FA91C
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

		// Token: 0x0601B899 RID: 112793 RVA: 0x003FC742 File Offset: 0x003FA942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSpcecialCellDestructCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B89A RID: 112794 RVA: 0x003FC75F File Offset: 0x003FA95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B89B RID: 112795 RVA: 0x003FC768 File Offset: 0x003FA968
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

		// Token: 0x04009EC5 RID: 40645
		private UnknownFieldSet _unknownFields;
	}
}
