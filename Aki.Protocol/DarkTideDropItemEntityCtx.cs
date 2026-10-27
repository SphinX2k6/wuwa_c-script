using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A2 RID: 930
	public sealed class DarkTideDropItemEntityCtx : IMessage<DarkTideDropItemEntityCtx>, IMessage, IEquatable<DarkTideDropItemEntityCtx>, IDeepCloneable<DarkTideDropItemEntityCtx>, IBufferMessage
	{
		// Token: 0x06005B97 RID: 23447 RVA: 0x000DECD7 File Offset: 0x000DCED7
		[NullableContext(1)]
		public static DarkTideDropItemEntityCtx Create()
		{
			return new DarkTideDropItemEntityCtx();
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x000DECDE File Offset: 0x000DCEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010FA RID: 4346
		// (get) Token: 0x06005B99 RID: 23449 RVA: 0x000DECE1 File Offset: 0x000DCEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideDropItemEntityCtx.Descriptor;
			}
		}

		// Token: 0x06005B9A RID: 23450 RVA: 0x000DECE8 File Offset: 0x000DCEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropItemEntityCtx()
		{
		}

		// Token: 0x06005B9B RID: 23451 RVA: 0x000DECF0 File Offset: 0x000DCEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropItemEntityCtx(DarkTideDropItemEntityCtx other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005B9C RID: 23452 RVA: 0x000DED09 File Offset: 0x000DCF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideDropItemEntityCtx Clone()
		{
			return new DarkTideDropItemEntityCtx(this);
		}

		// Token: 0x06005B9D RID: 23453 RVA: 0x000DED11 File Offset: 0x000DCF11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideDropItemEntityCtx);
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x000DED1F File Offset: 0x000DCF1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideDropItemEntityCtx other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x000DED40 File Offset: 0x000DCF40
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

		// Token: 0x06005BA0 RID: 23456 RVA: 0x000DED66 File Offset: 0x000DCF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BA1 RID: 23457 RVA: 0x000DED73 File Offset: 0x000DCF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BA2 RID: 23458 RVA: 0x000DED7C File Offset: 0x000DCF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BA3 RID: 23459 RVA: 0x000DED94 File Offset: 0x000DCF94
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

		// Token: 0x06005BA4 RID: 23460 RVA: 0x000DEDBA File Offset: 0x000DCFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideDropItemEntityCtx other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BA5 RID: 23461 RVA: 0x000DEDD7 File Offset: 0x000DCFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x000DEDE0 File Offset: 0x000DCFE0
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

		// Token: 0x0400360F RID: 13839
		private UnknownFieldSet _unknownFields;
	}
}
