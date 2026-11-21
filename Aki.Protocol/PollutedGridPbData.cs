using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB5 RID: 3509
	public sealed class PollutedGridPbData : IMessage<PollutedGridPbData>, IMessage, IEquatable<PollutedGridPbData>, IDeepCloneable<PollutedGridPbData>, IBufferMessage
	{
		// Token: 0x06012EB9 RID: 77497 RVA: 0x002C2B09 File Offset: 0x002C0D09
		[NullableContext(1)]
		public static PollutedGridPbData Create()
		{
			return new PollutedGridPbData();
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x06012EBA RID: 77498 RVA: 0x002C2B10 File Offset: 0x002C0D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x06012EBB RID: 77499 RVA: 0x002C2B13 File Offset: 0x002C0D13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PollutedGridPbData.Descriptor;
			}
		}

		// Token: 0x06012EBC RID: 77500 RVA: 0x002C2B1A File Offset: 0x002C0D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData()
		{
		}

		// Token: 0x06012EBD RID: 77501 RVA: 0x002C2B22 File Offset: 0x002C0D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData(PollutedGridPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EBE RID: 77502 RVA: 0x002C2B3B File Offset: 0x002C0D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData Clone()
		{
			return new PollutedGridPbData(this);
		}

		// Token: 0x06012EBF RID: 77503 RVA: 0x002C2B43 File Offset: 0x002C0D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PollutedGridPbData);
		}

		// Token: 0x06012EC0 RID: 77504 RVA: 0x002C2B51 File Offset: 0x002C0D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PollutedGridPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012EC1 RID: 77505 RVA: 0x002C2B70 File Offset: 0x002C0D70
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

		// Token: 0x06012EC2 RID: 77506 RVA: 0x002C2B96 File Offset: 0x002C0D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EC3 RID: 77507 RVA: 0x002C2BA3 File Offset: 0x002C0DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EC4 RID: 77508 RVA: 0x002C2BAC File Offset: 0x002C0DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EC5 RID: 77509 RVA: 0x002C2BC4 File Offset: 0x002C0DC4
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

		// Token: 0x06012EC6 RID: 77510 RVA: 0x002C2BEA File Offset: 0x002C0DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PollutedGridPbData other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EC7 RID: 77511 RVA: 0x002C2C07 File Offset: 0x002C0E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EC8 RID: 77512 RVA: 0x002C2C10 File Offset: 0x002C0E10
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

		// Token: 0x04007564 RID: 30052
		private UnknownFieldSet _unknownFields;
	}
}
