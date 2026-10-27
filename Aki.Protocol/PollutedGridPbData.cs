using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC6 RID: 3526
	public sealed class PollutedGridPbData : IMessage<PollutedGridPbData>, IMessage, IEquatable<PollutedGridPbData>, IDeepCloneable<PollutedGridPbData>, IBufferMessage
	{
		// Token: 0x06012FC9 RID: 77769 RVA: 0x002C49B7 File Offset: 0x002C2BB7
		[NullableContext(1)]
		public static PollutedGridPbData Create()
		{
			return new PollutedGridPbData();
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x06012FCA RID: 77770 RVA: 0x002C49BE File Offset: 0x002C2BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x06012FCB RID: 77771 RVA: 0x002C49C1 File Offset: 0x002C2BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PollutedGridPbData.Descriptor;
			}
		}

		// Token: 0x06012FCC RID: 77772 RVA: 0x002C49C8 File Offset: 0x002C2BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData()
		{
		}

		// Token: 0x06012FCD RID: 77773 RVA: 0x002C49D0 File Offset: 0x002C2BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData(PollutedGridPbData other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012FCE RID: 77774 RVA: 0x002C49E9 File Offset: 0x002C2BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PollutedGridPbData Clone()
		{
			return new PollutedGridPbData(this);
		}

		// Token: 0x06012FCF RID: 77775 RVA: 0x002C49F1 File Offset: 0x002C2BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PollutedGridPbData);
		}

		// Token: 0x06012FD0 RID: 77776 RVA: 0x002C49FF File Offset: 0x002C2BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PollutedGridPbData other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06012FD1 RID: 77777 RVA: 0x002C4A20 File Offset: 0x002C2C20
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

		// Token: 0x06012FD2 RID: 77778 RVA: 0x002C4A46 File Offset: 0x002C2C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FD3 RID: 77779 RVA: 0x002C4A53 File Offset: 0x002C2C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FD4 RID: 77780 RVA: 0x002C4A5C File Offset: 0x002C2C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012FD5 RID: 77781 RVA: 0x002C4A74 File Offset: 0x002C2C74
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

		// Token: 0x06012FD6 RID: 77782 RVA: 0x002C4A9A File Offset: 0x002C2C9A
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

		// Token: 0x06012FD7 RID: 77783 RVA: 0x002C4AB7 File Offset: 0x002C2CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FD8 RID: 77784 RVA: 0x002C4AC0 File Offset: 0x002C2CC0
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

		// Token: 0x04007551 RID: 30033
		private UnknownFieldSet _unknownFields;
	}
}
