using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C2 RID: 5314
	public sealed class TrapDefenseSpcecialCellDestructCtxPb : IMessage<TrapDefenseSpcecialCellDestructCtxPb>, IMessage, IEquatable<TrapDefenseSpcecialCellDestructCtxPb>, IDeepCloneable<TrapDefenseSpcecialCellDestructCtxPb>, IBufferMessage
	{
		// Token: 0x0601C317 RID: 115479 RVA: 0x00417935 File Offset: 0x00415B35
		[NullableContext(1)]
		public static TrapDefenseSpcecialCellDestructCtxPb Create()
		{
			return new TrapDefenseSpcecialCellDestructCtxPb();
		}

		// Token: 0x17005F6D RID: 24429
		// (get) Token: 0x0601C318 RID: 115480 RVA: 0x0041793C File Offset: 0x00415B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F6E RID: 24430
		// (get) Token: 0x0601C319 RID: 115481 RVA: 0x0041793F File Offset: 0x00415B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSpcecialCellDestructCtxPb.Descriptor;
			}
		}

		// Token: 0x0601C31A RID: 115482 RVA: 0x00417946 File Offset: 0x00415B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb()
		{
		}

		// Token: 0x0601C31B RID: 115483 RVA: 0x0041794E File Offset: 0x00415B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb(TrapDefenseSpcecialCellDestructCtxPb other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C31C RID: 115484 RVA: 0x00417967 File Offset: 0x00415B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpcecialCellDestructCtxPb Clone()
		{
			return new TrapDefenseSpcecialCellDestructCtxPb(this);
		}

		// Token: 0x0601C31D RID: 115485 RVA: 0x0041796F File Offset: 0x00415B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSpcecialCellDestructCtxPb);
		}

		// Token: 0x0601C31E RID: 115486 RVA: 0x0041797D File Offset: 0x00415B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSpcecialCellDestructCtxPb other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0601C31F RID: 115487 RVA: 0x0041799C File Offset: 0x00415B9C
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

		// Token: 0x0601C320 RID: 115488 RVA: 0x004179C2 File Offset: 0x00415BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C321 RID: 115489 RVA: 0x004179CF File Offset: 0x00415BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C322 RID: 115490 RVA: 0x004179D8 File Offset: 0x00415BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C323 RID: 115491 RVA: 0x004179F0 File Offset: 0x00415BF0
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

		// Token: 0x0601C324 RID: 115492 RVA: 0x00417A16 File Offset: 0x00415C16
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

		// Token: 0x0601C325 RID: 115493 RVA: 0x00417A33 File Offset: 0x00415C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C326 RID: 115494 RVA: 0x00417A3C File Offset: 0x00415C3C
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

		// Token: 0x0400A30C RID: 41740
		private UnknownFieldSet _unknownFields;
	}
}
